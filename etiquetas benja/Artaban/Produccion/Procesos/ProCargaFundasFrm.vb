Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class ProCargaFundasFrm1
    Public Transac As SqlTransaction
    Public TipoRecibo As Int16
    Dim IDMovimiento As Integer = 0
    Dim SQL = ""
    Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If eConsecutivo.Focused = False Then eConsecutivo.Focus()
    End Sub

    Private Sub ProReciboEmpFormf_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        eConsecutivo.Focus()
        Select Case TipoRecibo
            Case 1
                Me.Text = "Salida de Bases a Planta Therapedic"
                SQL = "Select distinct idDocumento from MovBases with(nolock) where Estatus = 1"
                Dim daMov As New SqlDataAdapter
                Dim dsMov As New DataTable
                Dim cmdMov As New SqlCommand(SQL, Conexion01)
                If Conexion01.State = False Then Conexion01.Open()
                'daMov.Dispose()
                daMov.SelectCommand = cmdMov
                daMov.Fill(dsMov)
                If dsMov.Rows.Count = 0 Then IDMovimiento = 0 Else IDMovimiento = dsMov.Rows(0)(0)
                ActualizaConteo()
            Case 2
                Me.Text = "Etiqueta recibo por devolución"
        End Select
    End Sub

    Private Sub ActualizaConteo()
        SQL = "Select Count(*)Conteo from MovBases with(nolock) where idDocumento = " & IDMovimiento.ToString
        Dim daCat As New SqlDataAdapter
        Dim dsCat As New DataTable
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCat.Dispose()
        daCat.SelectCommand = CMD
        daCat.Fill(dsCat)
        If dsCat.Rows.Count <> 0 Then
            eConteo.Text = dsCat.Rows(0)(0).ToString
        End If
        '' & IDMovimiento.ToString & _
        SQL = "Select Consecutivo, SKU, PartDescription as Parte, convert(varchar(10), FechaSB,108) Hora from MovBases with(nolock) " & _
            " inner join pilot.erp.part with(nolock) on Part.company = 'ARTABAN2' and movbases.sku collate SQL_Latin1_General_CP1_CI_AS = part.partnum " & _
            " where idDocumento = " & IDMovimiento.ToString & _
            " order by convert(varchar(10), FechaSB,108) desc "
        Dim daGrid As New SqlDataAdapter
        Dim dsGrid As New DataTable
        Dim cmdGrid As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daGrid.Dispose()
        daGrid.SelectCommand = cmdGrid
        daGrid.Fill(dsGrid)
        gDetalles.DataSource = dsGrid
    End Sub

    Private Sub eConsecutivo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eConsecutivo.KeyPress
        If Timer2.Enabled = True Then Timer2.Enabled = False
        Try
            If Not (Char.IsNumber(e.KeyChar)) And Not (e.KeyChar = Chr(13)) Then e.Handled = True
            If e.KeyChar = Chr(13) Then
                Dim ID As Int64
                If RevConexion(Conexion01) = False Then
                    eConsecutivo.Text = ""
                    Timer2.Enabled = True
                    eDescripcion.BackColor = Color.Salmon
                    eDescripcion.Text = Msj00063
                    ActualizaConteo()
                    Exit Sub
                End If
                If Len(eConsecutivo.Text) < 11 Then
                    eConsecutivo.Text = ""
                    eDescripcion.Text = "Numero de etiqueta incorrecto."
                    Timer2.Enabled = True
                    eDescripcion.BackColor = Color.Salmon
                    ActualizaConteo()
                    Exit Sub
                End If
                ID = (eConsecutivo.Text.Substring(0, 11))
                eConsecutivo.Text = ""
                Select Case TipoRecibo
                    Case 1
                        'Transac = Conexion01.BeginTransaction
                        If cbRetorno.Checked = True Then RetornoBase(ID, "spMovBases") Else CargaBase(ID, "spMovBases")
                End Select
                ActualizaConteo()
            End If
        Catch ex As Exception
            eConsecutivo.Text = ""
            eDescripcion.Text = ex.Message.ToString
            Timer2.Enabled = True
            eDescripcion.BackColor = Color.Salmon
        End Try
    End Sub

    Private Sub CargaBase(ByVal id As Int64, ByVal Stored As String)
        Dim cmdCB As New SqlCommand(Stored, Conexion01)
        cmdCB.CommandType = CommandType.StoredProcedure
        'cmdCB.Transaction = Transac
        cmdCB.Parameters.Add("@Opc", SqlDbType.Int).Value = TipoRecibo
        cmdCB.Parameters.Add("@Consecutivo", SqlDbType.BigInt).Value = id
        cmdCB.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
        cmdCB.Parameters.Add("@IDMov", SqlDbType.Int).Value = IDMovimiento
        cmdCB.Parameters.Add("@SKU", SqlDbType.VarChar, 15)
        cmdCB.Parameters.Add("@Producto", SqlDbType.VarChar, 500)
        cmdCB.Parameters("@IDMov").Direction = ParameterDirection.InputOutput
        cmdCB.Parameters("@SKU").Direction = ParameterDirection.Output
        cmdCB.Parameters("@Producto").Direction = ParameterDirection.Output
        cmdCB.ExecuteNonQuery()
        Select Case cmdCB.Parameters("@IDMov").Value
            Case -1 'Codigo Incorrecto
                System.Media.SystemSounds.Exclamation.Play()
                eDescripcion.Text = "El código ingresado es incorrecto, Verificar."
                eDescripcion.BackColor = Color.Salmon
            Case -2 'Codigo ya escaneado
                System.Media.SystemSounds.Exclamation.Play()
                eDescripcion.Text = cmdCB.Parameters("@SKU").Value.ToString & " - " & cmdCB.Parameters("@Producto").Value.ToString
                eDescripcion.BackColor = Color.Salmon
            Case Else 'Base agregada
                System.Media.SystemSounds.Hand.Play()
                eDescripcion.BackColor = Color.AliceBlue
                eDescripcion.Text = cmdCB.Parameters("@SKU").Value.ToString & " - " & cmdCB.Parameters("@Producto").Value.ToString
                IDMovimiento = cmdCB.Parameters("@IDMov").Value
        End Select
        Timer2.Enabled = True
    End Sub

    Private Sub RetornoBase(ByVal id As Int64, ByVal Stored As String)
        If IDMovimiento = 0 Then
            System.Media.SystemSounds.Exclamation.Play()
            eDescripcion.Text = "No hay bases disponibles para retornar"
            eDescripcion.BackColor = Color.Salmon
            Timer2.Enabled = True
            ActualizaConteo()
            Exit Sub
        End If
        Dim cmdCB As New SqlCommand(Stored, Conexion01)
        cmdCB.CommandType = CommandType.StoredProcedure
        'cmdCB.Transaction = Transac
        cmdCB.Parameters.Add("@Opc", SqlDbType.Int).Value = 4
        cmdCB.Parameters.Add("@Consecutivo", SqlDbType.BigInt).Value = id
        cmdCB.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
        cmdCB.Parameters.Add("@IDMov", SqlDbType.Int).Value = IDMovimiento
        cmdCB.Parameters.Add("@SKU", SqlDbType.VarChar, 15)
        cmdCB.Parameters.Add("@Producto", SqlDbType.VarChar, 500)
        cmdCB.Parameters("@IDMov").Direction = ParameterDirection.InputOutput
        cmdCB.Parameters("@SKU").Direction = ParameterDirection.Output
        cmdCB.Parameters("@Producto").Direction = ParameterDirection.Output
        cmdCB.ExecuteNonQuery()
        Select Case cmdCB.Parameters("@IDMov").Value
            Case -1 'Codigo Incorrecto
                System.Media.SystemSounds.Exclamation.Play()
                eDescripcion.Text = "El código ingresado es incorrecto, Verificar."
                eDescripcion.BackColor = Color.Salmon
            Case -2 'Codigo ya escaneado
                System.Media.SystemSounds.Exclamation.Play()
                eDescripcion.Text = cmdCB.Parameters("@SKU").Value.ToString & " - " & cmdCB.Parameters("@Producto").Value.ToString
                eDescripcion.BackColor = Color.Salmon
            Case Else 'Base agregada
                System.Media.SystemSounds.Hand.Play()
                eDescripcion.BackColor = Color.AliceBlue
                eDescripcion.Text = cmdCB.Parameters("@SKU").Value.ToString & " - " & cmdCB.Parameters("@Producto").Value.ToString
                IDMovimiento = cmdCB.Parameters("@IDMov").Value
        End Select
        Timer2.Enabled = True
    End Sub

    Private Sub GeneraEtiqueta(ByVal id As Int64, ByVal Stored As String)
        Try
            Dim cmdEt As New SqlCommand(Stored, Conexion01)
            cmdEt.CommandType = CommandType.StoredProcedure
            'cmdEt.Transaction = Transac
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
                    ' Transac.Rollback()
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
                'CMDCopias.Transaction = Transac
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
                'CMDCopias.Transaction = Transac
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
                    ' Transac.Rollback()
                    Exit Sub
                End If
            End If
            'Transac.Commit()
        Catch ex As Exception
            'If Transac.IsolationLevel.
            ' Transac.Rollback()
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
        FrmMain.Visible = True
    End Sub

    Private Sub bGenerar_Click(sender As System.Object, e As System.EventArgs) Handles bGenerar.Click
        If MsgBox("Una vez generada la salida no se podrá modificar el packing slip. ¿Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
 
        Select Case TipoRecibo
            Case 1 'Salida de Bases a planta Therapedic
                GeneraSalidaBases()
        End Select
    End Sub

    Private Sub GeneraSalidaBases()
        Dim cmdCB As New SqlCommand("spMovBases", Conexion01)
        cmdCB.CommandType = CommandType.StoredProcedure
        'cmdCB.Transaction = Transac
        cmdCB.Parameters.Add("@Opc", SqlDbType.Int).Value = 2
        cmdCB.Parameters.Add("@Consecutivo", SqlDbType.BigInt).Value = 0
        cmdCB.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
        cmdCB.Parameters.Add("@IDMov", SqlDbType.Int).Value = IDMovimiento
        cmdCB.Parameters.Add("@SKU", SqlDbType.VarChar, 15)
        cmdCB.Parameters.Add("@Producto", SqlDbType.VarChar, 500)
        cmdCB.Parameters("@IDMov").Direction = ParameterDirection.InputOutput
        cmdCB.Parameters("@SKU").Direction = ParameterDirection.Output
        cmdCB.Parameters("@Producto").Direction = ParameterDirection.Output
        cmdCB.ExecuteNonQuery()
        Select Case cmdCB.Parameters("@IDMov").Value
            Case -3 'Salida inexistente o ya embarcada
                System.Media.SystemSounds.Exclamation.Play()
                eDescripcion.Text = "Salida realizada o inexistente"
                eDescripcion.BackColor = Color.Salmon
                Timer2.Enabled = True
                ActualizaConteo()
                Exit Sub
            Case 0 'Salida generada con exito
                System.Media.SystemSounds.Hand.Play()
                eDescripcion.BackColor = Color.AliceBlue
                eDescripcion.Text = "Salida de bases a planta Therapedic confirmada"
                SQL = " Select iddocumento, SKU, PartDescription Parte, Sum(Cantidad)Cantidad, " & _
                    " STUFF((SELECT ',' + cast(Consecutivo as varchar(50)) " & _
                    " FROM MovBases Salida with(NoLock) where iddocumento = " & IDMovimiento & " and Bases.SKU= Salida.SKU  " & _
                    " ORDER BY consecutivo FOR XML PATH('') ), 1, 1, '') + ' ' as NoSeries, " & _
                    " row_number() over (order by sku) NReg " & _
                    " from ( " & _
                    " Select iddocumento , 1 Cantidad, SKU from MovBases  " & _
                    " where iddocumento = " & IDMovimiento & " ) Bases " & _
                    " left outer join pilot.erp.part parte with(nolock) on parte.Company = 'ARTABAN2' and partnum = SKU collate SQL_Latin1_General_CP1_CI_AS " & _
                    "  group by iddocumento, SKU, PartDescription "


ImpresionSalida:
                Dim Reporte As New FSalBases
                ImprimeCR("", SQL, Reporte, 1, Nothing, False)
                If MsgBox("¿La salida se imprimio de forma correcta?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then GoTo ImpresionSalida
                'IDMovimiento
        End Select
        IDMovimiento = 0
        Timer2.Enabled = True
        ActualizaConteo()
    End Sub

    Private Sub cbRetorno_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbRetorno.CheckedChanged
        If cbRetorno.Checked = True Then cbRetorno.ForeColor = Color.Lime Else cbRetorno.ForeColor = Color.Black
    End Sub
End Class