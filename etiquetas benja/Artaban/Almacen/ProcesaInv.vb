Imports System.Data.SqlClient

Public Class ProcesaInv
    Public TipoInv As Integer '1 = PT, 2 = MP
    Dim SQL As String = ""
    Private Sub ProcesaInv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CargaComposiciones()
        CargaCatalogo()
        bNuevo.Enabled = True
        bIgnorar.Enabled = False
        bGuardar.Enabled = False
    End Sub

    Private Sub CargaCatalogo()

        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter
        SQL = "select IDInventario ID, FechaInicio, UsuarioIngreso, FechaIngreso, UsuarioEstado, FechaEstado, Observaciones, " & _
            " case when Estado = 1 then 'Activo' else case when Estado = 0 then 'Cancelado' else 'Procesado' end end Estado "
        If TipoInv = 1 Then
            SQL = SQL & " from InvCapturaPTHdr with(nolock) order by FechaInicio desc "
        Else
            SQL = SQL & " from InvCapturaMPHdr with(nolock) order by FechaInicio desc "
        End If
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = Nothing
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = Nothing 
        gCatalogo.DataSource = dsCombos
    End Sub

    Private Sub ProcesaInv_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub ProcesaInv_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bNuevo.Click
        eFecha.MinDate = Today
        eFecha.Value = Today
        eObs.Text = ""
        pTop.Visible = True
        bIgnorar.Enabled = True
        bNuevo.Enabled = False
        bGuardar.Enabled = True
        bProcesar.Enabled = False
        bCancelar.Enabled = False
    End Sub

    Private Sub bIgnorar_Click(sender As System.Object, e As System.EventArgs) Handles bIgnorar.Click
        eFecha.MinDate = Today
        eFecha.Value = Today
        eObs.Text = ""
        pTop.Visible = False
        bIgnorar.Enabled = False
        bGuardar.Enabled = False
        bNuevo.Enabled = True
        bProcesar.Enabled = True
        bCancelar.Enabled = True
    End Sub

    Private Sub bCancelar_Click(sender As System.Object, e As System.EventArgs) Handles bCancelar.Click
        Dim seleccionados As Integer() = Me.GridView1.GetSelectedRows
        If seleccionados.Length = 0 Then
            '======Ningun seleccionado======
            Exit Sub
        Else
            Dim rowsSeleccionados As DataRow
            Dim File = ""
            For Each row As Integer In seleccionados
                rowsSeleccionados = Me.GridView1.GetDataRow(row)
                If rowsSeleccionados(7).ToString = "Activo" Then
                    If MsgBox(Msj00071, MsgBoxStyle.YesNo, Empresa & " Msj00071") = MsgBoxResult.No Then Exit Sub
                    'Exit Sub
                    Dim cmd As New SqlCommand("spAjusteInv", Conexion01)
                    cmd.CommandType = CommandType.StoredProcedure
                    If TipoInv = 1 Then
                        cmd.Parameters.AddWithValue("@Opc", SqlDbType.Int).Value = 2
                    Else
                        cmd.Parameters.AddWithValue("@Opc", SqlDbType.Int).Value = 5
                    End If
                    cmd.Parameters.Add("@idInventario", SqlDbType.Int).Value = rowsSeleccionados(0).ToString
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
                    cmd.Parameters.Add("@Obs", SqlDbType.VarChar, 250).Value = ""
                    cmd.Parameters.Add("@FechaInicio", SqlDbType.VarChar, 10).Value = ""
                    If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, Empresa)
                        Exit Sub
                    End Try
                Else
                    MsgBox(Msj00070, MsgBoxStyle.Critical, Empresa & " Msj00070")
                End If
                    'rowsSeleccionados(0).ToString()
            Next
        End If
        CargaCatalogo()
    End Sub

    Private Sub bProcesar_Click(sender As System.Object, e As System.EventArgs) Handles bProcesar.Click
        Dim seleccionados As Integer() = Me.GridView1.GetSelectedRows
        If seleccionados.Length = 0 Then
            '======Ningun seleccionado======
            Exit Sub
        Else
            Dim rowsSeleccionados As DataRow
            Dim File = ""
            For Each row As Integer In seleccionados
                rowsSeleccionados = Me.GridView1.GetDataRow(row)
                If rowsSeleccionados(7).ToString = "Activo" Then
                    If MsgBox(Msj00072, MsgBoxStyle.YesNo, Empresa & " Msj00072") = MsgBoxResult.No Then Exit Sub
                    'Exit Sub
                    Dim cmd As New SqlCommand("spAjusteInv", Conexion01)
                    cmd.CommandType = CommandType.StoredProcedure
                    If TipoInv = 1 Then
                        cmd.Parameters.AddWithValue("@Opc", SqlDbType.Int).Value = 3
                    Else
                        cmd.Parameters.AddWithValue("@Opc", SqlDbType.Int).Value = 6
                    End If
                    cmd.Parameters.Add("@idInventario", SqlDbType.Int).Value = rowsSeleccionados(0).ToString
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
                    cmd.Parameters.Add("@Obs", SqlDbType.VarChar, 250).Value = ""
                    cmd.Parameters.Add("@FechaInicio", SqlDbType.VarChar, 10).Value = ""
                    If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                    Try
                        cmd.ExecuteNonQuery()
                        'CargaCatalogo()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, Empresa)
                        Exit Sub
                    End Try
                Else
                    MsgBox(Msj00070, MsgBoxStyle.Critical, Empresa & " Msj00070")
                End If
                    'rowsSeleccionados(0).ToString()
            Next
        End If
        CargaCatalogo()
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        If Len(eObs.Text) < 10 Then
            MsgBox(Msj00073, MsgBoxStyle.Critical, Empresa & " Msj00073")
            Exit Sub
        End If
        Dim cmd As New SqlCommand("spAjusteInv", Conexion01)
        cmd.CommandType = CommandType.StoredProcedure
        If TipoInv = 1 Then
            cmd.Parameters.Add("@Opc", SqlDbType.Int).Value = 1
        Else
            cmd.Parameters.Add("@Opc", SqlDbType.Int).Value = 4
        End If
        cmd.Parameters.Add("@idInventario", SqlDbType.Int).Value = 0
        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
        cmd.Parameters.Add("@Obs", SqlDbType.VarChar, 250).Value = eObs.Text
        cmd.Parameters.Add("@FechaInicio", SqlDbType.VarChar, 10).Value = eFecha.Text
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Empresa)
            Exit Sub
        End Try
        CargaCatalogo()
        eFecha.MinDate = Today
        eFecha.Value = Today
        eObs.Text = ""
        pTop.Visible = False
        bIgnorar.Enabled = False
        bGuardar.Enabled = False
        bNuevo.Enabled = True
        bProcesar.Enabled = True
        bCancelar.Enabled = True
    End Sub
End Class