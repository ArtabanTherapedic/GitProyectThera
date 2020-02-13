Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class ProCargaFundasFrm
    Public Transac As SqlTransaction
    Public TipoRecibo As Int16
    Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If eConsecutivo.Focused = False Then eConsecutivo.Focus()
    End Sub

    Private Sub ProReciboEmpFormf_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        eConsecutivo.Focus()
        Select Case TipoRecibo
            Case 1
                Me.Text = "Etiqueta recibo de empaque"
            Case 2
                Me.Text = "Etiqueta recibo por devolución"
        End Select
    End Sub

    Private Sub ActualizaConteo()
        Dim Sql = "set dateformat dmy " & _
            " declare @Dia as varchar(10) " & _
            " set @dia = cast(datepart(day,getdate()) as varchar(2)) + '/' + cast(datepart(MONTH,getdate()) as varchar(2)) + '/' + cast(datepart(YEAR,getdate()) as varchar(4)) " & _
            " select count(*) from EtiquetasProd with(nolock) " & _
            " where fEtiquetaPT between @dia + ' 00:00' and @dia + ' 23:59'  "
        Dim daCat As New SqlDataAdapter
        Dim dsCat As New DataTable
        Dim CMD As New SqlCommand(Sql, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCat.Dispose()
        daCat.SelectCommand = CMD
        daCat.Fill(dsCat)
        If dsCat.Rows.Count <> 0 Then
            eConteo.Text = dsCat.Rows(0)(0).ToString
        End If
    End Sub

    Private Sub eConsecutivo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eConsecutivo.KeyPress
        If Timer2.Enabled = True Then Timer2.Enabled = False
        Try
            If Not (Char.IsNumber(e.KeyChar)) And Not (e.KeyChar = Chr(13)) Then e.Handled = True
            If e.KeyChar = Chr(13) Then
                If eConsecutivo.Text = "0000" Then ' si es codigo de apagado
                    Me.Close()
                    Exit Sub
                End If
                Dim ID As Int64
                If RevConexion(Conexion01) = False Then
                    eConsecutivo.Text = ""
                    Timer2.Enabled = True
                    eDescripcion.BackColor = Color.Salmon
                    eDescripcion.Text = Msj00063
                End If
                ID = (eConsecutivo.Text)
                eConsecutivo.Text = ""
                Transac = Conexion01.BeginTransaction
                GeneraEtiqueta(ID, "SpGenEtiquetaPT")
                ActualizaConteo()
                'Dim sql = "Select top 1 * from  MovInvIndPT with(nolock) where consecutivo = " & ID & " order by fechamov desc "
                'Dim DtMovs As New DataTable
                'Dim DaMovs As New SqlDataAdapter
                'Dim CmdMovs As New SqlCommand(sql, Conexion01)
                'DaMovs.SelectCommand = CmdMovs
                'DaMovs.Fill(DtMovs)
                'If DtMovs.Rows.Count > 0 Then
                '    Transac = Conexion01.BeginTransaction
                '    Select Case DtMovs.Rows(0)("Almacen")
                '        Case "ALMDE" 'Proviene de una Devolucion
                '            GeneraEtiqueta(ID, "SpGenEtiquetaDev")
                '        Case "ALMDN" 'Proviene de un retrabajo de produccion
                '            GeneraEtiqueta(ID, "SpGenEtiquetaRW")
                '        Case Else
                '            GeneraEtiqueta(ID, "SpGenEtiquetaPT")
                '    End Select
                'End If

                'Else

                '    Transac = Conexion01.BeginTransaction
                '    Select Case TipoRecibo
                '        Case 1 ' Recibo de produccion a Inventario
                '            GeneraEtiqueta(ID, "SpGenEtiquetaPT")
                '        Case 2 ' Etiqueta de Devolucion
                '            GeneraEtiqueta(ID, "SpGenEtiquetaDev")
                '    End Select
            End If

        Catch ex As Exception
            eConsecutivo.Text = ""
            eDescripcion.Text = ex.Message.ToString
            Timer2.Enabled = True
            eDescripcion.BackColor = Color.Salmon
        End Try


    End Sub

    Private Sub GeneraEtiqueta(ByVal id As Int64, ByVal Stored As String)
        Try
            Dim cmdEt As New SqlCommand(Stored, Conexion01)
            cmdEt.CommandType = CommandType.StoredProcedure
            cmdEt.Transaction = Transac
            cmdEt.Parameters.Add("@Consecutivo", SqlDbType.BigInt).Value = id
            cmdEt.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
            cmdEt.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmdEt.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmdEt.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmdEt.Parameters("@Msj").Direction = ParameterDirection.Output

            cmdEt.ExecuteNonQuery()

            eDescripcion.Text = cmdEt.Parameters("@Msj").Value.ToString()
            Timer2.Enabled = True
            If cmdEt.Parameters("@Resultado").Value.ToString() = "1" Then
                'System.Media.SystemSounds.Beep.Play()
                System.Media.SystemSounds.Exclamation.Play()
                If cmdEt.Parameters("@Msj").Value.ToString = "" Then eDescripcion.Text = Msj00030
                eDescripcion.BackColor = Color.Salmon
            ElseIf cmdEt.Parameters("@Resultado").Value.ToString() = "0" Then
                'id = Convert.ToInt64(cmdEt.Parameters("@Msj").Value.ToString)
                System.Media.SystemSounds.Hand.Play()
                eDescripcion.BackColor = Color.AliceBlue
                'Imprimir(ID)
                If RevConexion(Conexion01) = False Then
                    eConsecutivo.Text = ""
                    eDescripcion.Text = Msj00063
                    Timer2.Enabled = True
                    eDescripcion.BackColor = Color.Salmon
                    Transac.Rollback()
                    Exit Sub
                End If
                Dim Sql = "Select EtiquetasProd.SKU, Descripcion, SubString(TipoDesc,1,3)TipoDesc, CodMedida, SubString(MedidaDesc,1,4)MedidaDesc, Consecutivo, Pedido, EtiquetasProd.Tela, " & _
                    " 'Piezas: ' +cast(netiqueta as varchar(10)) + ' de ' + cast(TotEtiquetas as varchar(10)) NoPiezas, " & _
                    " CompNom, case when ISNULL(Variant,'') = ''then '' else concat('*',Variant, '*') end UniResorte, case when isnull(EAN13,'') = '' then '' else concat('*',EAN13, '*') end SKUCte " & _
                    " from etiquetasProd with(noLock) left outer join catArticulosPT with(noLock) on etiquetasprod.sku = catArticulosPT.sku left outer join catTipos with(NoLock) " & _
                    " on CatArticulosPT.tipo = catTipos.idtipo left outer join catMedidas with(NoLock) on catARticulosPT.medida = CatMEdidas.Codmedida " & _
                    " where Consecutivo = " & id.ToString
                Dim Reporte As New EtPT

                Dim SQLCopias = "select ISNULL(nocopias,1) NoCopias from EtiquetasProd ET with(nolock) " & _
                        " left  outer join catnocopiaset Copias with(nolock) on Et.SKU = Copias.SKU " & _
                        "  where Consecutivo = " & id.ToString
                Dim daCopias As New SqlDataAdapter
                Dim dsCopias As New DataTable
                Dim CMDCopias As New SqlCommand(SQLCopias, Conexion01)
                CMDCopias.Transaction = Transac
                If Conexion01.State = False Then Conexion01.Open()
                daCopias.Dispose()
                daCopias.SelectCommand = CMDCopias
                daCopias.Fill(dsCopias)
                Dim NCopias As Int16 = 0
                If dsCopias.Rows.Count = 0 Then
                    NCopias = 1
                Else
                    NCopias = dsCopias.Rows(0)(0)
                End If
                If ImprimeCR("", Sql, Reporte, NCopias, Transac, True) = False Then
                    eConsecutivo.Text = ""
                    eDescripcion.Text = Msj00064
                    Timer2.Enabled = True
                    eDescripcion.BackColor = Color.Salmon
                    Transac.Rollback()
                    Exit Sub
                End If

            ElseIf cmdEt.Parameters("@Resultado").Value.ToString() = "2" Then
                'id = Convert.ToInt64(cmdEt.Parameters("@Msj").Value.ToString)
                System.Media.SystemSounds.Hand.Play()
                eDescripcion.BackColor = Color.AliceBlue
                'Imprimir(ID)
                If RevConexion(Conexion01) = False Then
                    eConsecutivo.Text = ""
                    eDescripcion.Text = Msj00063
                    Timer2.Enabled = True
                    eDescripcion.BackColor = Color.Salmon
                    Transac.Rollback()
                    Exit Sub
                End If
                'Dim Sql = "Select EtiquetasProd.SKU, Descripcion, SubString(TipoDesc,1,3)TipoDesc, CodMedida, SubString(MedidaDesc,1,4)MedidaDesc, Consecutivo, Pedido, EtiquetasProd.Tela, " & _
                '    " 'Piezas: ' +cast(netiqueta as varchar(10)) + ' de ' + cast(TotEtiquetas as varchar(10)) NoPiezas, " & _
                '    " CompNom, UniResorte, case when len(SKUCTE)> 0 then concat('*',SKUCte, '*') else '' end SKUCte " & _
                '    " from etiquetasProd with(noLock) left outer join catArticulosPT with(noLock) on etiquetasprod.sku = catArticulosPT.sku left outer join catTipos with(NoLock) " & _
                '    " on CatArticulosPT.tipo = catTipos.idtipo left outer join catMedidas with(NoLock) on catARticulosPT.medida = CatMEdidas.Codmedida " & _
                '    " where Consecutivo = "
                Dim Sql = "Select EtiquetasProd.SKU, Descripcion, SubString(TipoDesc,1,3)TipoDesc, CodMedida, SubString(MedidaDesc,1,4)MedidaDesc, Consecutivo, Pedido, EtiquetasProd.Tela,   " & _
                    " 'Piezas: ' +cast(netiqueta as varchar(10)) + ' de ' + cast(TotEtiquetas as varchar(10)) NoPiezas,  " & _
                    " CompNom, ISNULL(Variant,'')  UniResorte, case when isnull(EAN13,'') = '' then '' else concat('*',EAN13, '*') end SKUCte  " & _
                    " from etiquetasProd with(noLock) left outer join catArticulosPT with(noLock) on etiquetasprod.sku = catArticulosPT.sku left outer join catTipos with(NoLock)  " & _
                    " on CatArticulosPT.tipo = catTipos.idtipo left outer join catMedidas with(NoLock) on catARticulosPT.medida = CatMEdidas.Codmedida " & _
                    "   where Consecutivo = " & id.ToString
                Dim Reporte As New EtPTD
                Dim SQLCopias = "select ISNULL(nocopias,1) NoCopias from EtiquetasProd ET with(nolock) " & _
                       " left  outer join catnocopiaset Copias with(nolock) on Et.SKU = Copias.SKU " & _
                       "  where Consecutivo = " & id.ToString
                Dim daCopias As New SqlDataAdapter
                Dim dsCopias As New DataTable
                Dim CMDCopias As New SqlCommand(SQLCopias, Conexion01)
                CMDCopias.Transaction = Transac
                If Conexion01.State = False Then Conexion01.Open()
                daCopias.Dispose()
                daCopias.SelectCommand = CMDCopias
                daCopias.Fill(dsCopias)
                Dim NCopias As Int16 = 0
                If dsCopias.Rows.Count = 0 Then
                    NCopias = 1
                Else
                    NCopias = dsCopias.Rows(0)(0)
                End If
                If ImprimeCR("", Sql, Reporte, NCopias, Transac, True) = False Then
                    eConsecutivo.Text = ""
                    eDescripcion.Text = Msj00064
                    Timer2.Enabled = True
                    eDescripcion.BackColor = Color.Salmon
                    Transac.Rollback()
                    Exit Sub
                End If
            End If
            Transac.Commit()
        Catch ex As Exception
            'If Transac.IsolationLevel.
            Transac.Rollback()
            eConsecutivo.Text = ""
            Timer2.Enabled = True
            eDescripcion.BackColor = Color.Salmon
            eDescripcion.Text = ex.Message
        End Try
    End Sub

    Private Sub Imprimir(ByVal ID As Int64)
        If RevConexion(Conexion01) = False Then
            eDescripcion.Text = Msj00063
        End If
        Dim Sql = "Select EtiquetasProd.SKU, Descripcion, SubString(TipoDesc,1,3)TipoDesc, CodMedida, SubString(MedidaDesc,1,4)MedidaDesc, Consecutivo, Pedido, EtiquetasProd.Tela, " & _
            " 'Piezas: ' +cast(netiqueta as varchar(10)) + ' de ' + cast(TotEtiquetas as varchar(10)) NoPiezas, " & _
            " CompNom, UniResorte, case when len(SKUCTE)> 0 then concat('*',SKUCte, '*') else '' end SKUCte " & _
            " from etiquetasProd with(noLock) left outer join catArticulosPT with(noLock) on etiquetasprod.sku = catArticulosPT.sku left outer join catTipos with(NoLock) " & _
            " on CatArticulosPT.tipo = catTipos.idtipo left outer join catMedidas with(NoLock) on catARticulosPT.medida = CatMEdidas.Codmedida " & _
            " where Consecutivo = " & ID.ToString
        Dim Reporte As New EtPT
        'ImprimeCR("", Sql, Reporte, 1)
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        eDescripcion.BackColor = Color.White
        eDescripcion.Text = ""
    End Sub

    Private Sub ProReciboEmpFormf_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If UCase(Usuario) = "EMBOLSADO" Or UCase(Usuario) = "EMBOLSADO1" Or UCase(Usuario) = "EMBOLSADO2" Or UCase(Usuario) = "EMBOLSADO3" Or UCase(Usuario) = "EMBOLSADOB" Or UCase(Usuario) = "EMBOLSADOC" Or UCase(Usuario) = "EMBOLSADO4" Then
            Process.Start("shutdown.exe", " -s -t 5 -f")
            Application.Exit()
        Else
            FrmMain.Visible = True
        End If
    End Sub


End Class