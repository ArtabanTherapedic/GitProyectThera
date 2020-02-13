Imports System.Data.SqlClient 
Public Class ReImpETEpicor
    Dim SQL As String = ""
    Public Tipo As String = ""

    Private Sub ProdProcesoFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If cbPT.Checked Then bReasignar.Enabled = False Else bReasignar.Enabled = True
        obtener_impresoras(cbImpresora)
        CargaCombo(cbOperador, "Select '-1' EmpID, '' Name union all select EmpID, Name from Produccion.erp.EmpBasic with(nolock) where EmpStatus = 'A'", "EmpID", "Name")
        'CargaCombo(cbOperacion, "Select '-1' OpCode, ''OpDesc union all select OpCode, OpDesc from Pilot.erp.OpMaster with(nolock) where OpType = 'MFG' ", "OpCode", "OpDesc")
        tClic.Enabled = True
    End Sub

    Private Sub CargaCatalogo()
        gCatalogo.DataSource = Nothing
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter
        Dim Producido As String = ""
        If cbPT.Checked = True Then Producido = "1" Else Producido = "0"
        SQL = "exec spRepImpET 'ARTABAN1','" + Tipo + "', '" + Producido + "', '" + eOP.Text + "', '" + eParte.Text + "',"
        If cbOperador.Text = "" Then SQL = SQL + " '', " Else SQL = SQL + "'" + cbOperador.EditValue.ToString + "', "
        SQL = SQL + "'" + eNoEtiqueta.Text + "'"
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD 
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
    End Sub

    Private Sub CatComposiciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub CatComposiciones_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub tRClic_Tick(sender As System.Object, e As System.EventArgs) Handles tClic.Tick
        bImprimir.Enabled = True
        bReasignar.Enabled = True
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        CargaCatalogo()
    End Sub

    Private Sub bLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles bLimpiar.Click
        eOP.Text = ""
        eParte.Text = ""
        'cbOperacion.EditValue = "-1"
        cbOperador.EditValue = -1
        gCatalogo.DataSource = Nothing
    End Sub

    Private Sub bImprimir_Click(sender As System.Object, e As System.EventArgs) Handles bImprimir.Click
        tClic.Enabled = True
        bImprimir.Enabled = False
        'ExportarXLSX(gCatalogo)
        If GridView1.SelectedRowsCount <> 1 Then
            bImprimir.Enabled = True
            tClic.Enabled = False
            Exit Sub
        End If

        Dim seleccionados As Integer() = Me.GridView1.GetSelectedRows
        If seleccionados.Length = 0 Then
            '======Ningun seleccionado======
            'MsgBox("sin registros")
        Else
            Dim rowsSeleccionados As DataRow
            Dim File = ""
            For Each row As Integer In seleccionados
                rowsSeleccionados = Me.GridView1.GetDataRow(row)
                'MsgBox(rowsSeleccionados(1))
                If Tipo = 8 Then ' Tapizado
                    'MsgBox("tipo 8 ")
                    'File = "\\epicor01\Reportes\ArtaReport.exe 1 " + rowsSeleccionados(0).ToString + " " + rowsSeleccionados(1).ToString
                    If rowsSeleccionados(9).ToString = "Artaban" Then
                        'MsgBox("Entra Artaban")
                        ImpETPT(rowsSeleccionados(0).ToString, rowsSeleccionados(1).ToString)
                    Else
                        'ImpETPT_Plantas(rowsSeleccionados(0).ToString, rowsSeleccionados(1).ToString)
                        'MsgBox("Entra Plantas")
                        Shell("\\epicor01\Reportes\Plantas\ArtaReport.exe 8 " + rowsSeleccionados(0).ToString + " " + rowsSeleccionados(1).ToString, AppWinStyle.Hide)
                    End If


                Else
                    'MsgBox("Entra else")
                    File = "\\epicor01\Reportes\ArtaReport.exe 3 " + rowsSeleccionados(0).ToString + " " + rowsSeleccionados(2).ToString + " " + rowsSeleccionados(5).ToString + " " + rowsSeleccionados(7).ToString + " COST " + rowsSeleccionados(1).ToString
                    Shell(File, AppWinStyle.Hide)
                End If

            Next
        End If
    End Sub

    Private Sub ImpETPT(ByVal Company As String, ByVal Etiqueta As String)
        Dim rpt As New EtiquetaPT
        ImprimeCR(cbImpresora.Text, "exec spRepEtiqueta '" & Company & "', '" & Etiqueta & "'", rpt, 1, Nothing, False)
        rpt.Dispose()
    End Sub
    Private Sub ImpETPT_Plantas(ByVal Company As String, ByVal Etiqueta As String)
        Dim rpt As New EtiquetaPT
        ImprimeCR(cbImpresora.Text, "exec spRepEtiqueta_Plantas '" & Company & "', '" & Etiqueta & "'", rpt, 1, Nothing, False)
        rpt.Dispose()
    End Sub

    Private Sub bReasignar_Click(sender As System.Object, e As System.EventArgs) Handles bReasignar.Click
        tClic.Enabled = True
        bImprimir.Enabled = False
        bReasignar.Enabled = False
        If GridView1.SelectedRowsCount <> 1 Then
            bImprimir.Enabled = True
            bReasignar.Enabled = True
            tClic.Enabled = False
            Exit Sub
        End If

        Dim seleccionados As Integer() = Me.GridView1.GetSelectedRows
        If seleccionados.Length = 0 Then
            '======Ningun seleccionado======
        Else
            Dim rowsSeleccionados As DataRow
            Dim File = ""
            For Each row As Integer In seleccionados
                rowsSeleccionados = Me.GridView1.GetDataRow(row)
                Dim NOper As String
                Dim Motivo As String
                Dim Operador
                NOper = InputBox("Indicar el Nuevo numero de Operador:", "Reasignacion de Trabajo.")
                If NOper = "" Then Exit Sub
                Motivo = InputBox("Favor de Indicar el Motivo de la reasignacion:", "Motivo de Reasignacion")
                If Motivo = "" Then Exit Sub
                If Len(Motivo) < 10 Then
                    MsgBox(Msj00068, MsgBoxStyle.Critical, Empresa & " MSJ00068")
                    Exit Sub
                End If
                Operador = OperadorValido(NOper)
                If Operador = "" Then
                    MsgBox(Msj00067, MsgBoxStyle.Critical, Empresa & " MSJ00067")
                    Exit Sub
                End If
                If MsgBox("Se Reasignaran " + rowsSeleccionados(7).ToString + " - " + rowsSeleccionados(4).ToString + Chr(13) + "Al Operador: " + NOper + " - " + Operador + Chr(13) + "¿Desea Continuar?", MsgBoxStyle.YesNo, "Artaban Internacional") = MsgBoxResult.Yes Then
                    Dim cmd As New SqlCommand("spReasigna", Conexion01)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@Opc", SqlDbType.Int).Value = 1
                    cmd.Parameters.Add("@Company", SqlDbType.VarChar, 10).Value = rowsSeleccionados(0).ToString
                    cmd.Parameters.Add("@idEtiqueta", SqlDbType.VarChar, 10).Value = rowsSeleccionados(1).ToString
                    cmd.Parameters.Add("@Operador", SqlDbType.VarChar, 50).Value = NOper
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
                    cmd.Parameters.Add("@Motivo", SqlDbType.VarChar, 500).Value = Motivo
                    If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, Empresa)
                        Exit Sub
                    End Try
                    If Tipo = 8 Then ' Tapizado   
                        Exit Sub
                        ImpETPT(rowsSeleccionados(0).ToString, rowsSeleccionados(1).ToString)
                    Else
                        File = "\\epicor01\Reportes\ArtaReport.exe 3 " + rowsSeleccionados(0).ToString + " " + rowsSeleccionados(2).ToString + " " + NOper + " " + rowsSeleccionados(7).ToString + " COST " + rowsSeleccionados(1).ToString
                        Shell(File, AppWinStyle.Hide)
                    End If
                    CargaCatalogo()
                End If
            Next
        End If
    End Sub

    Private Function OperadorValido(ByVal Operador As String) As String
        OperadorValido = ""
        Dim dsOperador As New DataTable
        Dim daOperador As New SqlDataAdapter
        SQL = "select EmpID, Name from produccion.erp.EmpBasic with(nolock) where EmpStatus = 'A' and EmpID = '" + Operador + "'"
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daOperador.SelectCommand = CMD
        daOperador.Fill(dsOperador)
        If dsOperador.Rows.Count = 0 Then
            OperadorValido = ""
            Exit Function
        End If
        OperadorValido = dsOperador(0)(1).ToString
    End Function

    Private Function Cancelacion(ByVal Operador As String, JobNum As String, Cantidad As String) As Boolean
        Cancelacion = False
        Dim dsOperador As New DataTable
        Dim daOperador As New SqlDataAdapter
        SQL = "select isnull(Sum(Cantidad),0) as Cantidad, isnull(sum(laborQty),0) as CantidadProd " & _
            " from EtiquetasEpicor ET with(nolock) " & _
            " left outer join  produccion.erp.labordtl Prod with(nolock) " & _
            " on Et.Company = Prod.Company and Et.Jobnum = prod.Jobnum and Et.idOperador = prod.EmployeeNum " & _
            " where et.jobnum = '" + JobNum + "' and idoperador = '" + Operador + "'"
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daOperador.SelectCommand = CMD
        daOperador.Fill(dsOperador)
        If dsOperador.Rows.Count = 0 Then
            Cancelacion = False
            Exit Function
        End If
        If dsOperador(0)("Cantidad") - Cantidad = dsOperador(0)("CantidadProd") Then
            Cancelacion = True
        Else
            MsgBox("Existe un desface de " + (dsOperador(0)("Cantidad") - Cantidad - dsOperador(0)("CantidadProd")).ToString + Chr(13) + _
                   "Favor de hacer el movimientos de produccion previo a este proceso", MsgBoxStyle.Critical, Empresa)
        End If
            Cancelacion = True
    End Function

    Private Sub bCancelar_Click(sender As System.Object, e As System.EventArgs) Handles bCancelar.Click

        'Dim Update As New SqlCommand("spReasigna", Conexion01)
        'Update.CommandType = CommandType.StoredProcedure
        'Update.Parameters.AddWithValue("@Opc", SqlDbType.Int).Value = 1
        'Update.Parameters.Add("@Opcion", SqlDbType.VarChar, 10).Value = rowsSeleccionados(0).ToString
        'Update.Parameters.Add("@idEtiqueta", SqlDbType.VarChar, 10).Value = rowsSeleccionados(1).ToString
        'Update.Parameters.Add("@Operador", SqlDbType.VarChar, 50).Value = NOper
        'Update.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
        'Update.Parameters.Add("@Motivo", SqlDbType.VarChar, 500).Value = Motivo
        'If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        'Try
        '    Update.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, Empresa)
        '    Exit Sub
        'End Try
    End Sub

    
    Private Sub pLeft_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pLeft.Paint

    End Sub
End Class