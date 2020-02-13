Imports System.Data.SqlClient

Public Class CatSupyProm
    Dim SQL = ""
    Dim RenglonAgregados = -1
    Dim RenglonDisponibles = -1
    Dim IDSup As String = ""

    Private Sub CatSupyProm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'SQL = " Select IDEmp, Empleado from v_CatEmpLyraProm where ClvDepto in ('A1CIM', 'A1COPP','A1PSEARS', 'A1VTASAY','A1VTASC','A1VTASY','A1VADMC','A1RADA')"
        SQL = " Select IDEmp, Empleado from v_CatEmpLyraProm "
        CargaCombo(cbEmpleado, SQL, "IDEmp", "Empleado")
        CargaCombo(cbNoEmpleado, SQL, "Empleado", "IDEmp")
    End Sub

    Private Sub CargaDisponibles()
        Try

            Dim dsDisp As New DataTable
            Dim daDisp As New SqlDataAdapter
            'SQL = " Select IDEmp as NoEmp, Empleado from v_CatEmpLyraProm  Emp where Emp.Estatus = 'ACTIVO' and ClvDepto in ('A1CIM', 'A1COPP','A1PSEARS', 'A1VTASAY','A1VTASC','A1VTASY') " & _
            SQL = " Select IDEmp as NoEmp, Empleado from v_CatEmpLyraProm  Emp " & _
                " where idEmp not in(Select NoEmp from catRHPromotores where NoSupervisor = " & cbNoEmpleado.Text & ")"
            Dim CMD As New SqlCommand(SQL, Conexion01)
            If Conexion01.State = False Then Conexion01.Open()
            CMD.CommandTimeout = 6000
            daDisp.SelectCommand = CMD
            daDisp.Fill(dsDisp)
            gDisponibles.DataSource = dsDisp
        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener la información: " & ex.Message)
        End Try
    End Sub

    Private Sub CargaAgregados()
        Try
            Dim dsAgre As New DataTable
            Dim daAgre As New SqlDataAdapter
            '"   where ClvDepto in ('A1CIM', 'A1COPP','A1PSEARS', 'A1VTASAY','A1VTASC','A1VTASY') and NoSupervisor = " & cbNoEmpleado.Text & _

            SQL = "  Select IDEmp, Empleado, Prom.Sueldo, Emp.Estatus EstatusLyra, prom.Estatus from v_CatEmpLyraProm emp  " & _
                " inner join catRHPromotores Prom with(nolock) on Emp.idEmp = Prom.NoEmp " & _
                "   where NoSupervisor = " & cbNoEmpleado.Text & _
                "  order by idEmp "
            Dim CMD As New SqlCommand(SQL, Conexion01)
            If Conexion01.State = False Then Conexion01.Open()
            CMD.CommandTimeout = 6000
            daAgre.SelectCommand = CMD
            daAgre.Fill(dsAgre)
            gAgragados.DataSource = dsAgre
        Catch ex As Exception
            MsgBox("Ocurrio un error al obtener la información: " & ex.Message)
        End Try
    End Sub

    Private Sub cbNoEmpleado_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbNoEmpleado.EditValueChanged
        cbEmpleado.Text = cbNoEmpleado.EditValue

    End Sub

    Private Sub cbEmpleado_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbEmpleado.EditValueChanged
        cbNoEmpleado.Text = cbEmpleado.EditValue
    End Sub

    Private Sub CatSupyProm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        RenglonDisponibles = -1
        RenglonAgregados = -1
        If cbEmpleado.Text = "" Then Exit Sub
        CargaDisponibles()
        CargaAgregados()
    End Sub

    Private Sub GridView2_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        RenglonAgregados = e.FocusedRowHandle.ToString
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        RenglonDisponibles = e.FocusedRowHandle.ToString
    End Sub

    Private Sub GridView2_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand("spPromotores", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = 3 'Modificacion 
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
            cmd.Parameters.Add("@NoSup", SqlDbType.Int).Value = CInt(cbNoEmpleado.Text)
            cmd.Parameters.Add("@NoEmp", SqlDbType.VarChar, 15).Value = GridView2.GetRowCellValue(RenglonAgregados, ColNoEmp)
            cmd.Parameters.Add("@Estatus", SqlDbType.Bit).Value = GridView2.GetRowCellValue(RenglonAgregados, ColEstatus)
            cmd.Parameters.Add("@Sueldo", SqlDbType.VarChar, 15).Value = GridView2.GetRowCellValue(RenglonAgregados, ColSueldo)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el registro, error: " + Chr(13) + ex.Message)
        End Try
         
    End Sub

    Private Sub GridView2_CellValueChanging(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanging
        'Try
        '    If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        '    Dim cmd As New SqlCommand("spPromotors", Conexion01)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = 3 'Modificacion 
        '    cmd.Parameters.Add("@NoSup", SqlDbType.Int).Value = CInt(cbNoEmpleado.Text)
        '    cmd.Parameters.Add("@NoEmp", SqlDbType.VarChar, 15).Value = GridView2.GetRowCellValue(RenglonAgregados, ColEmp)
        '    cmd.Parameters.Add("@Estatus", SqlDbType.Bit).Value = GridView2.GetRowCellValue(RenglonAgregados, ColEstatus)
        '    cmd.Parameters.Add("@Sueldo", SqlDbType.VarChar, 15).Value = GridView2.GetRowCellValue(RenglonAgregados, ColSueldo)
        '    cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
        '    cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
        '    cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
        '    cmd.Parameters("@Msj").Direction = ParameterDirection.Output
        '    If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        '    cmd.ExecuteNonQuery()
        '    If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
        '        MsgBox("Ocurrio un error al guardar el Registro, error:")
        '        Exit Sub
        '    End If 
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error al guardar el registro, error: " + Chr(13) + ex.Message)
        'End Try
    End Sub

    Private Sub bAgregar_Click(sender As System.Object, e As System.EventArgs) Handles bAgregar.Click
        If RenglonDisponibles = -1 Then Exit Sub
        IDSup = ""
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand("spPromotores", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = 1 'Agregar
            If GridView2.RowCount = 0 Then
                IDSup = InputBox("Indica el Usuario del supervisor: ", Empresa)
            Else
                IDSup = Usuario
            End If
            If IDSup = "" Then
                MsgBox("El id de usuario del supervisor no puede estar en blanco.")
                Exit Sub
            End If
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = IDSup
            cmd.Parameters.Add("@NoSup", SqlDbType.Int).Value = CInt(cbNoEmpleado.Text)
            cmd.Parameters.Add("@NoEmp", SqlDbType.VarChar, 15).Value = GridView1.GetRowCellValue(RenglonDisponibles, colNoEmpleado)
            cmd.Parameters.Add("@Estatus", SqlDbType.Bit).Value = 1
            cmd.Parameters.Add("@Sueldo", SqlDbType.VarChar, 15).Value = 0
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            CargaDisponibles()
            CargaAgregados()
        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el registro, error: " + Chr(13) + ex.Message)
        End Try
    End Sub

    Private Sub bQuitar_Click(sender As System.Object, e As System.EventArgs) Handles bQuitar.Click
        If RenglonAgregados = -1 Then Exit Sub
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand("spPromotores", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = 2 'Eliminar
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
            cmd.Parameters.Add("@NoSup", SqlDbType.Int).Value = CInt(cbNoEmpleado.Text)
            cmd.Parameters.Add("@NoEmp", SqlDbType.VarChar, 15).Value = GridView2.GetRowCellValue(RenglonAgregados, ColNoEmp)
            cmd.Parameters.Add("@Estatus", SqlDbType.Bit).Value = GridView2.GetRowCellValue(RenglonAgregados, ColEstatus)
            cmd.Parameters.Add("@Sueldo", SqlDbType.VarChar, 15).Value = GridView2.GetRowCellValue(RenglonAgregados, ColSueldo)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            CargaDisponibles()
            CargaAgregados()
        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el registro, error: " + Chr(13) + ex.Message)
        End Try
    End Sub
End Class