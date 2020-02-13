Imports System.Data.SqlClient
Public Class ProRutaProceso

    Dim SQL As String = ""
    Private Sub ProRutaProceso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaConstrucciones()
    End Sub

    Private Sub CargaConstrucciones()
        SQL = "Select idConstruccion, ConstruccionDesc, ConstruccionObs from vCatConstrucciones order by ConstruccionDesc"
        Dim dsCons As New DataTable
        Dim daCons As New SqlDataAdapter
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCons.SelectCommand = CMD
        daCons.Fill(dsCons)
        cbConstruccion.Properties.DataSource = dsCons
        cbConstruccion.Properties.DisplayMember = "ConstruccionDesc"
        cbConstruccion.Properties.ValueMember = "idConstruccion"
    End Sub

    Private Sub ProRutaProceso_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub cbConstruccion_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbConstruccion.EditValueChanged
        CargaGrids()
    End Sub

    Private Sub CargaGrids()
        SQL = "select idProceso as  idDisponible, ProcesoDesc as ProcesoDisponible from vCatProcesos " & _
            " where procesoactivo = 1 and  idProceso not in(select idProcesoR from vCatRutaProceso where idConstruccionR = " & cbConstruccion.EditValue.ToString & ")"
        Dim dsDisp As New DataTable
        Dim daDisp As New SqlDataAdapter
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daDisp.SelectCommand = CMD
        daDisp.Fill(dsDisp)
        gDisponible.DataSource = dsDisp
        SQL = "select idProceso as  idAgregado, ProcesoDesc as ProcesoAgregado, Orden from vCatProcesos " & _
           " left outer join vCatRutaProceso on vCatProcesos.idProceso = vCatRutaProceso.idProcesoR " & _
            " where procesoactivo = 1 and idConstruccionR = " & cbConstruccion.EditValue.ToString & _
            " and  idProceso in(select idProcesoR from vCatRutaProceso where idConstruccionR = " & cbConstruccion.EditValue.ToString & ") order by orden"
        Dim dsAdd As New DataTable
        Dim daAdd As New SqlDataAdapter
        Dim CMDAdd As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daAdd.SelectCommand = CMDAdd
        daAdd.Fill(dsAdd)
        gAgregados.DataSource = dsAdd
    End Sub

    Private Sub bAdd_Click(sender As System.Object, e As System.EventArgs) Handles bAdd.Click
        If gViewD.RowCount = 0 Then Exit Sub
        Try
            Dim cmd As New SqlCommand("spUPCatRutaProceso", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
            cmd.Parameters.Add("@idProcesoR", SqlDbType.Int).Value = gViewD.GetFocusedRowCellValue("idDisponible")
            cmd.Parameters.Add("@idConstruccionR", SqlDbType.Int).Value = cbConstruccion.EditValue
            cmd.Parameters.Add("@RutaProcesoObs", SqlDbType.VarChar, 250).Value = ""
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                MsgBox(cmd.Parameters("@Msj").Value.ToString() & Chr(13) & Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
                Exit Sub
            End If
        Catch
            MsgBox(Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
            Exit Sub
        End Try
        CargaGrids()
        'MsgBox(Msj00021, MsgBoxStyle.Information, Empresa & " MSJ00021") 'Se guardo de manera correcta
    End Sub

    Private Sub bDel_Click(sender As System.Object, e As System.EventArgs) Handles bDel.Click
        If gViewA.RowCount = 0 Then Exit Sub
        Try
            Dim cmd As New SqlCommand("spUPCatRutaProceso", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 4
            cmd.Parameters.Add("@idProcesoR", SqlDbType.Int).Value = gViewA.GetFocusedRowCellValue("idAgregado")
            cmd.Parameters.Add("@idConstruccionR", SqlDbType.Int).Value = cbConstruccion.EditValue
            cmd.Parameters.Add("@RutaProcesoObs", SqlDbType.VarChar, 250).Value = ""
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                MsgBox(cmd.Parameters("@Msj").Value.ToString() & Chr(13) & Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
                Exit Sub
            End If
        Catch
            MsgBox(Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
            Exit Sub
        End Try
        CargaGrids()
        'MsgBox(Msj00021, MsgBoxStyle.Information, Empresa & " MSJ00021") 'Se guardo de manera correcta
    End Sub

    Private Sub bUp_Click(sender As System.Object, e As System.EventArgs) Handles bUp.Click
        If gViewA.RowCount = 0 Then Exit Sub
        Try
            Dim cmd As New SqlCommand("spUPCatRutaProceso", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 2
            cmd.Parameters.Add("@idProcesoR", SqlDbType.Int).Value = gViewA.GetFocusedRowCellValue("idAgregado")
            cmd.Parameters.Add("@idConstruccionR", SqlDbType.Int).Value = cbConstruccion.EditValue
            cmd.Parameters.Add("@RutaProcesoObs", SqlDbType.VarChar, 250).Value = ""
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                MsgBox(cmd.Parameters("@Msj").Value.ToString() & Chr(13) & Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
                Exit Sub
            End If
        Catch
            MsgBox(Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
            Exit Sub
        End Try
        CargaGrids()
        'MsgBox(Msj00021, MsgBoxStyle.Information, Empresa & " MSJ00021") 'Se guardo de manera correcta
    End Sub

    Private Sub bDown_Click(sender As System.Object, e As System.EventArgs) Handles bDown.Click
        If gViewA.RowCount = 0 Then Exit Sub
        Try
            Dim cmd As New SqlCommand("spUPCatRutaProceso", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 3
            cmd.Parameters.Add("@idProcesoR", SqlDbType.Int).Value = gViewA.GetFocusedRowCellValue("idAgregado")
            cmd.Parameters.Add("@idConstruccionR", SqlDbType.Int).Value = cbConstruccion.EditValue
            cmd.Parameters.Add("@RutaProcesoObs", SqlDbType.VarChar, 250).Value = ""
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                MsgBox(cmd.Parameters("@Msj").Value.ToString() & Chr(13) & Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
                Exit Sub
            End If
        Catch
            MsgBox(Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
            Exit Sub
        End Try
        CargaGrids()
        'MsgBox(Msj00021, MsgBoxStyle.Information, Empresa & " MSJ00021") 'Se guardo de manera correcta
    End Sub
End Class