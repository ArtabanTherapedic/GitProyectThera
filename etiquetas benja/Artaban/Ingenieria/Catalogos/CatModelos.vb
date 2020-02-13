Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class CatModelosForm
    Dim SQL As String = ""

    Dim Estatus As String = ""
    Dim ID As String = "0"
    Private Sub CatModelo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaCombo(cbLinea, "Select idLinea, LineaDesc from CatLineas with(nolock) order by lineaDesc", "idLinea", "LineaDesc")
        'CargaCatalogo()
    End Sub

    Private Sub CargaCatalogo()
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter
        SQL = "Select idModelo, ModeloDesc, ModeloObs, ModeloActivo from CatModelos With(Nolock) where idLinea = '" & cbLinea.EditValue.ToString & "' order by idModelo"
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
        gCatalogo.Enabled = True
        bNuevo.Enabled = True
        bIgnorar.Enabled = False
        bEliminar.Enabled = False
        bGuardar.Enabled = False
        Estatus = "L" 'Lectura
        CargaLinea()
    End Sub

    Private Sub CatModelo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub CatModelo_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bNuevo.Click
        Estatus = "N"
        bIgnorar.Enabled = True
        bGuardar.Enabled = True
        gCatalogo.Enabled = False
        eModelo.Text = ""
        'eLin.Text = ""
        eDesc.Text = ""
        chkActivo.Checked = True
        'eLin.Focus()
    End Sub

    Private Sub gCatalogo_Click(sender As System.Object, e As System.EventArgs) Handles gCatalogo.Click
        CargaLinea()
    End Sub

    Private Sub CargaLinea()
        If GridView1.SelectedRowsCount > 0 Then
            If IsDBNull(GridView1.GetFocusedRowCellValue("idModelo")) Then
                eModelo.Text = ""
            Else
                eModelo.Text = Format(GridView1.GetFocusedRowCellValue("idModelo"), "00")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("ModeloDesc")) Then
                ' eLin.Text = ""
            Else
                'eLin.Text = GridView1.GetFocusedRowCellValue("ModeloDesc")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("ModeloDesc")) Then
                eDesc.Text = ""
            Else
                eDesc.Text = GridView1.GetFocusedRowCellValue("ModeloDesc")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("ModeloActivo")) = False Then
                chkActivo.Checked = True
            Else
                If GridView1.GetFocusedRowCellValue("ModeloActivo") = True Then
                    chkActivo.Checked = True
                Else
                    chkActivo.Checked = GridView1.GetFocusedRowCellValue("ModeloActivo")
                End If
            End If
            ID = GridView1.GetFocusedRowCellValue("idModelo").ToString
        Else
            eModelo.Text = ""
            'eLin.Text = ""
            eDesc.Text = ""
            chkActivo.Checked = False
        End If
    End Sub

    Private Sub eModelo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eModelo.KeyPress, eDesc.KeyPress
        CambiaStatus()
    End Sub

    Private Sub CambiaStatus()
        'If Estatus = "L" Then Exit Sub ' Lectura
        Select Case Estatus
            Case "L" 'Sin estatus
                Estatus = "E" 'Edicion
                bGuardar.Enabled = True
                bIgnorar.Enabled = True
                bNuevo.Enabled = False
                bEliminar.Enabled = False
                gCatalogo.Enabled = False
        End Select
    End Sub

    Private Sub bIgnorar_Click(sender As System.Object, e As System.EventArgs) Handles bIgnorar.Click
        CargaLinea()
        bGuardar.Enabled = False
        bIgnorar.Enabled = False
        bNuevo.Enabled = True
        gCatalogo.Enabled = False
        gCatalogo.Enabled = True
        Estatus = "L"
    End Sub

    Private Sub CatModelo_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub Guardar()
        Try
            Dim cmd As New SqlCommand("spUPCatModelos", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            If ID = "" Then ID = "0"
            cmd.Parameters.AddWithValue("@IDModelo", Integer.Parse(ID))
            Select Case Estatus
                Case "N"
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
                Case "E"
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 2
            End Select
            'cmd.Parameters.Add("@idLinea", SqlDbType.Int).Value = eLin.Text
            cmd.Parameters.Add("@ModeloDesc", SqlDbType.VarChar, 250).Value = eDesc.Text
            cmd.Parameters.Add("@ModeloActivo", SqlDbType.Bit).Value = chkActivo.Checked
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
        CargaCatalogo()
        MsgBox(Msj00021, MsgBoxStyle.Information, Empresa & " MSJ00021") 'Se guardo de manera correcta
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        Guardar()
    End Sub

    Private Sub chkActivo_Click(sender As System.Object, e As System.EventArgs) Handles chkActivo.Click
        CambiaStatus()
    End Sub

    Private Sub cbLinea_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbLinea.EditValueChanged
        CargaCatalogo()
    End Sub
End Class