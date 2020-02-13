Imports System.Data.SqlClient
Imports CrystalDecisions.Shared

Class ProEmbarquesFrm
    Dim SQL As String
    Dim Estatus As String
    Dim ID As Int16
    Dim LocOrigen As String
    Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo


    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub CatArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaCatalogo()

        txtPedido.Hide()
        LabelControl8.Hide()

    End Sub

    Private Sub CargaCatalogo()
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter

        If cbJaula.Text = "" Then Exit Sub
        LocOrigen = cbJaula.Text.Substring(6, 2) & "-" & cbJaula.Text.Substring(6, 2) & "-" & cbJaula.Text.Substring(6, 2)
        SQL = "select IdRevision, SKU, Descripcion, sum(Ingreso)Ingreso, Sum(Revision1)Revision1, sum(Revision2)Revision2, Sum(Revision3)Revision3, NoSeries, 0  cant From(" & _
            " select Hdr.IdRevision, Art.SKU, Descripcion, Ingreso, Revision1, Revision2, Revision3, " & _
            " STUFF((SELECT ',' + cast(Consecutivo as varchar(50)) FROM PyFEmbarquesDet with(NoLock) where PyFEmbarquesDet.idRevision = Det.IdRevision   " & _
            " ORDER BY consecutivo FOR XML PATH('') ), 1, 1, '') + ' ' as NoSeries " & _
            " from PyFEmbarquesHdr hdr With(NoLock) inner join PyfEmbarquesDet Det with(NoLock) on Hdr.idrevision = det.idrevision " & _
            " inner join EtiquetasProd Et with(NoLock) on Det.Consecutivo = Et.Consecutivo " & _
            " inner join CatArticulosPT Art  with(NoLock) on Art.SKU = Et.SKU where Hdr.Estado = 'N' and Hdr.Origen = '" & LocOrigen & "') EmbAgrupados " & _
            " group by idrevision, sku, Descripcion, NoSeries "
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
        gCatalogo.Enabled = True
        bNuevo.Enabled = True
        bIgnorar.Enabled = False
        bEtiquetas.Enabled = True                        
        bEliminar.Enabled = False
        If GridView1.RowCount > 0 Then
            bGuardar.Enabled = True
            bRevision.Enabled = True
            GridView1.SelectRow(0)
            bEtiquetas.Enabled = True
        Else
            bGuardar.Enabled = False
            bRevision.Enabled = False
            bEtiquetas.Enabled = True
        End If

    End Sub

    Private Sub Limpia()
        gCatalogo.DataSource = Nothing
        gCatalogo.Refresh()
        cbJaula.Text = ""
        cbJaula.SelectedIndex = -1
        cbTipoEnvio.Text = ""
        cbTipoEnvio.SelectedIndex = -1
        eChofer.Text = ""
        eCliente.Text = ""
        eEntrega.Text = ""
        eNoEco.Text = ""
        ePlacas.Text = ""
        eSello.Text = ""
    End Sub

    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bNuevo.Click
        Limpia()
    End Sub

    Private Sub bIgnorar_Click(sender As System.Object, e As System.EventArgs) Handles bIgnorar.Click
        ' CargaLinea()
        bGuardar.Enabled = False
        bRevision.Enabled = False
        bIgnorar.Enabled = False
        bNuevo.Enabled = True
        gCatalogo.Enabled = True
        bEtiquetas.Enabled = True
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        If Valido() = True Then Guardar()
    End Sub

    Private Function Valido() As Boolean
        Valido = False
        If GridView1.RowCount = 0 Then
            MsgBox(Msj00031, MsgBoxStyle.Critical, Empresa & " MSJ00031")
            Exit Function
        End If
        If cbTipoEnvio.Text = "" Then
            MsgBox(Msj00032, MsgBoxStyle.Critical, Empresa & " MSJ00032")
            cbTipoEnvio.Focus()
            Exit Function
        End If
        If eSello.Text = "" Then
            MsgBox(Msj00033, MsgBoxStyle.Critical, Empresa & " MSJ00033")
            eSello.Focus()
            Exit Function
        End If
        If eCliente.Text = "" Then
            MsgBox(Msj00034, MsgBoxStyle.Critical, Empresa & " MSJ00034")
            eCliente.Focus()
            Exit Function
        End If
        If eNoEco.Text = "" Then
            MsgBox(Msj00035, MsgBoxStyle.Critical, Empresa & " MSJ00035")
            eNoEco.Focus()
            Exit Function
        End If
        If ePlacas.Text = "" Then
            MsgBox(Msj00036, MsgBoxStyle.Critical, Empresa & " MSJ00036")
            ePlacas.Focus()
            Exit Function
        End If
        If eChofer.Text = "" Then
            MsgBox(Msj00037, MsgBoxStyle.Critical, Empresa & " MSJ00037")
            eChofer.Focus()
            Exit Function
        End If
        If eEntrega.Text = "" Then
            MsgBox(Msj00038, MsgBoxStyle.Critical, Empresa & " MSJ00038")
            eEntrega.Focus()
            Exit Function
        End If
        idRevision = GridView1.GetFocusedRowCellValue("idRevision")
        Valido = True
    End Function

    Private Sub Guardar()
        Dim Transac As SqlTransaction
        Transac = Conexion01.BeginTransaction
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand("spGenEmbarque", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Transaction = Transac
            cmd.Parameters.Add("@IdRevision", SqlDbType.Int).Value = GridView1.GetFocusedRowCellValue("IdRevision")
            cmd.Parameters.Add("@Origen", SqlDbType.VarChar, 8).Value = LocOrigen
            cmd.Parameters.Add("@TipoEnvio", SqlDbType.VarChar, 250).Value = cbTipoEnvio.Text
            cmd.Parameters.Add("@Cliente", SqlDbType.VarChar, 250).Value = eCliente.Text
            cmd.Parameters.Add("@NoEconomico", SqlDbType.VarChar, 50).Value = eNoEco.Text
            cmd.Parameters.Add("@Placas", SqlDbType.VarChar, 50).Value = ePlacas.Text
            cmd.Parameters.Add("@Chofer", SqlDbType.VarChar, 250).Value = eChofer.Text
            cmd.Parameters.Add("@DomEntrega", SqlDbType.VarChar, 500).Value = eEntrega.Text
            cmd.Parameters.Add("@NoSello", SqlDbType.VarChar, 50).Value = eSello.Text
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
            cmd.Parameters.Add("@Consecutivo", SqlDbType.VarChar, 8000).Value = GridView1.GetFocusedRowCellValue("NoSeries").ToString
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery()
            Transac.Commit()
            Imprime(GridView1.GetFocusedRowCellValue("IdRevision"))
            If MsgBox(Msj00050, MsgBoxStyle.YesNo, Empresa & " Msj00050") = MsgBoxResult.Yes Then
                ImprimeRev(GridView1.GetFocusedRowCellValue("IdRevision"))
            End If
            Limpia()
        Catch ex As Exception
            Transac.Rollback()
            MsgBox(Msj00039 + " " + ex.Message, MsgBoxStyle.Critical, Empresa & "MSJ00039")
        End Try
    End Sub

    Private Sub Imprime(ByVal idRevision As Integer)
        'Dim rpt As New RptEmbarque
        'Try
        'oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
        'oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
        'oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
        'oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
        'For x = 0 To rpt.Database.Tables.Count - 1
        '    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
        '    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
        'Next
        'rpt.SetParameterValue("@idRevision", idRevision)
        'Dim rptEmbarque As New ReportView
        'rptEmbarque.Icon = Me.Icon
        'rptEmbarque.Visor.ReportSource = rpt
        'rptEmbarque.Show()
        
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Empresa)
        'End Try
        'rpt.Dispose()
        Dim Sql = "select IdRevision, SKU, Descripcion, TipoEnvio, Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque, " & _
               " sum(Ingreso)Ingreso, Sum(Revision1)Revision1, sum(Revision2)Revision2, Sum(Revision3)Revision3, NoSeries " & _
               " From( select Hdr.IdRevision, Art.SKU, Descripcion, Ingreso, Revision1, Revision2, Revision3,  STUFF((SELECT ',' + cast(Emb.Consecutivo as varchar(50)) " & _
               " FROM PyFEmbarquesDet emb with(NoLock)  left outer join EtiquetasProd et1 with(nolock) on emb.Consecutivo = et1.consecutivo " & _
               " where Emb.idRevision = Det.IdRevision  and et1.sku = et.SKu  ORDER BY emb.consecutivo FOR XML PATH('') ), 1, 1, '') + ' ' as NoSeries, " & _
               " TipoEnvio, Hdr.Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque " & _
               " from PyFEmbarquesHdr hdr With(NoLock) inner join PyfEmbarquesDet Det with(NoLock) on Hdr.idrevision = det.idrevision  inner join EtiquetasProd Et with(NoLock) " & _
               " on Det.Consecutivo = Et.Consecutivo  inner join CatArticulosPT Art with(NoLock) on Art.SKU = Et.SKU " & _
               " where Hdr.idRevision = " & idRevision.ToString & _
               " ) EmbAgrupados  group by idrevision, sku, Descripcion, NoSeries, TipoEnvio, Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque "

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New RptEmbarque
        PreviewCR(SQL, CrReport)
    End Sub

    Private Sub ImprimeRev(ByVal idRevision As Integer)
        'Dim rpt As New RptRevEmbarque
        'Try
        '    oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
        '    oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
        '    oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
        '    oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
        '    For x = 0 To rpt.Database.Tables.Count - 1
        '        rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
        '        rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
        '    Next
        '    rpt.SetParameterValue("@idRevision", idRevision)
        '    Dim RptRevision As New ReportView
        '    RptRevision.Icon = Me.Icon
        '    RptRevision.Visor.ReportSource = rpt
        '    RptRevision.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Empresa)
        'End Try
        'rpt.Dispose()
        Dim Sql = "select IdRevision, SKU, Descripcion, TipoEnvio, Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque, " & _
              " sum(Ingreso)Ingreso, Sum(Revision1)Revision1, sum(Revision2)Revision2, Sum(Revision3)Revision3, NoSeries " & _
              " From( select Hdr.IdRevision, Art.SKU, Descripcion, Ingreso, Revision1, Revision2, Revision3,  STUFF((SELECT ',' + cast(Emb.Consecutivo as varchar(50)) " & _
              " FROM PyFEmbarquesDet emb with(NoLock)  left outer join EtiquetasProd et1 with(nolock) on emb.Consecutivo = et1.consecutivo " & _
              " where Emb.idRevision = Det.IdRevision  and et1.sku = et.SKu  ORDER BY emb.consecutivo FOR XML PATH('') ), 1, 1, '') + ' ' as NoSeries, " & _
              " TipoEnvio, Hdr.Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque " & _
              " from PyFEmbarquesHdr hdr With(NoLock) inner join PyfEmbarquesDet Det with(NoLock) on Hdr.idrevision = det.idrevision  inner join EtiquetasProd Et with(NoLock) " & _
              " on Det.Consecutivo = Et.Consecutivo  inner join CatArticulosPT Art with(NoLock) on Art.SKU = Et.SKU " & _
              " where Hdr.idRevision = " & idRevision.ToString & _
              " ) EmbAgrupados  group by idrevision, sku, Descripcion, NoSeries, TipoEnvio, Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque "
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        CrReport = New RptRevEmbarque
        PreviewCR(Sql, CrReport)
    End Sub

    Private Sub CatArticulos_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Desicion As MsgBoxResult = MsgBoxResult.No
        Select Case Estatus
            Case "E"
                Desicion = MsgBox(Msj00019, MsgBoxStyle.YesNoCancel, Empresa & " MSJ00019")
            Case "N"
                Desicion = MsgBox(Msj00019, MsgBoxStyle.YesNoCancel, Empresa & " MSJ00019")
        End Select
        Select Case Desicion
            Case MsgBoxResult.Yes
                Guardar()
            Case MsgBoxResult.Cancel
                e.Cancel = True
        End Select
    End Sub

    Private Sub CatArticulos_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub cbTipo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbJaula.SelectedIndexChanged, eEntrega.Properties.EditValueChanged, eChofer.Properties.EditValueChanged, ePlacas.Properties.EditValueChanged, eNoEco.Properties.EditValueChanged, eCliente.Properties.EditValueChanged, eSello.Properties.EditValueChanged, txtPedido.Properties.EditValueChanged
        CargaCatalogo()
    End Sub

    Private Sub ProEmbarquesFrm_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub bRevision_Click(sender As System.Object, e As System.EventArgs) Handles bRevision.Click
        If GridView1.SelectedRowsCount > 0 Then ImprimeRev(GridView1.GetFocusedRowCellValue("IdRevision"))
    End Sub
    Private Sub bEtiquetas_Click(sender As System.Object, e As System.EventArgs) Handles bEtiquetas.Click

        Dim dt As DataTable = New DataTable
        Dim adapter As SqlDataAdapter
        Dim Rs As SqlDataReader
        Dim fecha As String
        fecha = FechaEt.Value.Year.ToString & "/" & FechaEt.Value.Month.ToString & "/" & FechaEt.Value.Day.ToString

        ' MsgBox(fecha)



        If Conexion01.State = False Then Conexion01.Open()

        If cb_cliente.Text = "" Then
            MessageBox.Show("Seleccione Cliente")
            Exit Sub
        End If

        For i As Integer = 0 To GridView1.RowCount - 1
            ' If GridView1.GetRowCellValue(i, "SKU") <> Nothing Then

            ' End If

            Dim SQLParte = "select * from Therapedic.dbo.BD_ETIQUETAS$ " & _
            "where cliente ='" & cb_cliente.Text & "' and EPICOR= '" & GridView1.GetRowCellValue(i, "SKU") & "'"


            adapter = New SqlDataAdapter(SQLParte, Conexion01)
            Dim Com As New SqlCommand(SQLParte, Conexion01)
            dt = New DataTable
            adapter.Fill(dt)



            ' If eCliente.Text <> "" Then

            ' Else : MsgBox("EL Campo Cliente no puede estar vacio")


            ' End If


            If dt.Rows.Count > 0 Then

                Rs = Com.ExecuteReader()
                Rs.Read()


                ' SQLParte = "select * from Therapedic.dbo.BD_ETIQUETAS$ " & _
                ' "where cliente like '%" & eCliente.Text & "%' and EPICOR= '" & GridView1.GetRowCellValue(i, "SKU") & "'"

                'adapter = New SqlDataAdapter(SQLParte, Conexion01)

                'adapter.Fill(dt)


                '  If GridView1.GetRowCellValue(i, "SKU").Equals(Rs(1).ToString()) And cb_cliente.Text.Equals(Rs(0).ToString()) Then



                ' ImpEtiPrEmb(eCliente.Text.ToString(), GridView1.GetRowCellValue(i, "SKU").ToString())

                'Conexion01.Close()
                'MsgBox(Rs(5) & "  bultos " & Rs(1) & "  repeticion " & GridView1.GetRowCellValue(i, "cant") & " fecha " & fecha)



                ImpEtiPrEmb(SQLParte, cb_cliente.Text, GridView1.GetRowCellValue(i, "SKU"), fecha, Rs(5), GridView1.GetRowCellValue(i, "cant"))

                Rs.Close()

            Else
                MessageBox.Show("El CODIGO " & GridView1.GetRowCellValue(i, "SKU") & " No Existe  codigo " & "")

            End If





            
        Next


    End Sub

    Private Sub gCatalogo_Click(sender As System.Object, e As System.EventArgs) Handles gCatalogo.Click

    End Sub

    Public Function ImprimeCR(ByVal Impresora As String, SQL As String, CrReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, NCopias As Integer, Transaccion As SqlTransaction, UsaTran As Boolean) As Boolean
        ImprimeCR = False
        Dim dtRep As New DataTable
        Dim daRep As New SqlDataAdapter
        Dim CMD As New SqlCommand(SQL, Conexion01)
        Dim Conteo = 0
        RevConexion(Conexion01)
Reimp:
        Try
            If Conteo > 5 Then Exit Function
            Conteo = 1
            If UsaTran = True Then CMD.Transaction = Transaccion
            daRep.SelectCommand = CMD
            daRep.Fill(dtRep)
            CrReport.SetDataSource(dtRep)
            If Impresora <> "" Then CrReport.PrintOptions.PrinterName = Impresora
            For x = 1 To NCopias
                CrReport.PrintToPrinter(1, True, 0, 0)
            Next
            ImprimeCR = True
            CrReport.Dispose()
        Catch ex As Exception
            ImprimeCR = False
        End Try
    End Function

    Private Sub ImpEtiPrEmb(ByVal SQL As String, ByVal cliente As String, ByVal codigo As String, ByVal fecha As Date, bultos As Integer, cantidad As Integer)

        Dim conteo As Integer
        'Dim dtRep As New DataTable
        'Dim daRep As New SqlDataAdapter
        ' Dim CMD As New SqlCommand(SQL, Conexion01)
        'RevConexion(Conexion01)
        'daRep.SelectCommand = CMD
        'daRep.Fill(dtRep)
        'CrReport.SetDataSource(dtRep)
        'Private Sub ImpEtiPrEmb(ByVal sql As String)
        'Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'CrReport = New EtembarqC
        'Try
        '  CrReport.PrintToPrinter(1, True, 0, 0)

        ' Catch ex As Exception
        'MsgBox(Msj00062 + " " + ex.Message, MsgBoxStyle.Critical, Empresa & " Msj00062")
        ' End Try


        ' CrReport = New EtembarqC
        '  PreviewCR(sql, CrReport)
        'Try
        'oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
        'oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
        'oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
        'oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
        'For x = 0 To rpt.Database.Tables.Count - 1
        '    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
        '    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
        'Next
        'rpt.SetParameterValue("@idRevision", idRevision)
        'Dim rptEmbarque As New ReportView
        'rptEmbarque.Icon = Me.Icon
        'rptEmbarque.Visor.ReportSource = rpt
        'rptEmbarque.Show()

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Empresa)
        'End Try
        'rpt.Dispose()


        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim data1, data2, data3, data4, data5 As New ParameterValues
        Dim pvisual, pvisual2, pvisual3, pvisual4, pvisual5 As New ParameterDiscreteValue

        ' CrReport = New etd

        Dim xx = 0
        If cantidad > 0 Then

            For k = 1 To cantidad
                conteo = bultos
                For x = 1 To bultos

                    Try
                        CrReport = New etd
                        oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
                        oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
                        oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
                        oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
                        For xx = 0 To CrReport.Database.Tables.Count - 1
                            CrReport.Database.Tables(xx).ApplyLogOnInfo(oConexInfo)
                            CrReport.Database.Tables(xx).ApplyLogOnInfo(oConexInfo)
                        Next
                        '    If Conexion01.State = False Then Conexion01.Open()



                        pvisual.Value = cliente
                        pvisual2.Value = codigo
                        ' pvisual3.Value = pedido
                        pvisual4.Value = fecha





                        data1.Add(pvisual)
                        data2.Add(pvisual2)
                        'data3.Add(pvisual3)
                        data4.Add(pvisual4)

                        pvisual5.Value = conteo
                        data5.Add(pvisual5)


                        CrReport.DataDefinition.ParameterFields("@cliente").ApplyCurrentValues(data1)
                        CrReport.DataDefinition.ParameterFields("@codigo").ApplyCurrentValues(data2)
                        'CrReport.DataDefinition.ParameterFields("@pedido").ApplyCurrentValues(data3)
                        CrReport.DataDefinition.ParameterFields("@fecha").ApplyCurrentValues(data4)
                        CrReport.DataDefinition.ParameterFields("@bultos").ApplyCurrentValues(data5)


                        conteo = conteo - 1
                        ReportView.Visor.ReportSource = CrReport
                        ReportView.Show()
                        '   CrReport.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape

                        CrReport.PrintToPrinter(1, True, 0, 0)




                        'ImprimeCR(ByVal Impresora As String, SQL As String, CrReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, NCopias As Integer, Transaccion As SqlTransaction, UsaTran As Boolean) As Boolean


                        'ReportView.Show()
                    Catch ex As Exception
                    End Try

                Next
            Next
        Else : MessageBox.Show("la cantidad de etiquetas esta en 0")
        End If


        ' CrReport.Dispose()

    End Sub
End Class