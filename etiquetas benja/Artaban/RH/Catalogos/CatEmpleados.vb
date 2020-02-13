Imports System.Data.SqlClient
Imports System.IO

Public Class CatEmpleados
    Dim SQL As String = ""
    Dim dsCombos As New DataTable
    Dim daCombos As New SqlDataAdapter
    Dim id As String = "0"
    Dim sFoto As String = ""
    Dim Estatus As String = ""

    Private Sub CatComposiciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CargaComposiciones()
        CargaCatalogo()
        CargaCombos()
    End Sub

    Private Sub CargaCatalogo()
        SQL = "Select * from CatEmpleados with(nolock)  "
        Dim daCat As New SqlDataAdapter
        Dim dsCat As New DataTable
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCat.Dispose()
        daCat.SelectCommand = CMD
        daCat.Fill(dsCat)
        gCatalogo.DataSource = dsCat
        CargaLinea()
        Estatus = "L" 'Lectura
        gCatalogo.Enabled = True
    End Sub

    Private Sub CargaLinea()
        If GridView1.SelectedRowsCount > 0 Then
            If IsDBNull(GridView1.GetFocusedRowCellValue("idEmpleado")) Then
                eIDEmp.Text = ""
                id = 0
            Else
                eIDEmp.Text = Format(GridView1.GetFocusedRowCellValue("idEmpleado"), "000000")
                id = Convert.ToInt64(eIDEmp.Text)
            End If
            'If IsDBNull(GridView1.GetFocusedRowCellValue("Area")) Then
            'cbArea.SelectedIndex = -1
            'Else
            'cbArea.Text = GridView1.GetFocusedRowCellValue("Area")
            'End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("IDArea")) Then
                cbAreas.EditValue = -1
            Else
                cbAreas.EditValue = GridView1.GetFocusedRowCellValue("IDArea")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Nombre")) Then
                eNombre.Text = ""
            Else
                eNombre.Text = GridView1.GetFocusedRowCellValue("Nombre")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Paterno")) Then
                ePaterno.Text = ""
            Else
                ePaterno.Text = GridView1.GetFocusedRowCellValue("Paterno")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Materno")) Then
                eMaterno.Text = ""
            Else
                eMaterno.Text = GridView1.GetFocusedRowCellValue("Materno")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Activo")) Then
                cbActivo.Checked = False
            Else
                cbActivo.Checked = GridView1.GetFocusedRowCellValue("Activo")
            End If
            If Not IsDBNull(GridView1.GetFocusedRowCellValue("Genero")) Then
                If GridView1.GetFocusedRowCellValue("Genero") = "M" Then
                    rbMujer.Checked = True
                Else
                    rbHombre.Checked = True
                End If
            End If

            If IsDBNull(GridView1.GetFocusedRowCellValue("Foto")) Then
                Foto.Image = Nothing
            Else
                Foto.Image = BytesToImagen(GridView1.GetFocusedRowCellValue("Foto"))
                'sFoto = GridView1.GetFocusedRowCellValue("Foto")
                'If sFoto = "" Then
                '    Foto.Image = Nothing
                'Else
                '    'Foto.Image = BytesToImagen(consultaByte(sFoto))
                '    Foto.Image = BytesToImagen(consultaByte(sFoto))
                'End If
            End If
        Else
            eIDEmp.Text = "000000"
            cbActivo.Checked = False
        End If
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

    Private Sub rbHombre_Click(sender As System.Object, e As System.EventArgs) Handles rbHombre.Click
        rbMujer.Checked = False
        CambiaStatus()
    End Sub

    Private Sub rbMujer_Click(sender As System.Object, e As System.EventArgs) Handles rbMujer.Click
        rbHombre.Checked = False
        CambiaStatus()
    End Sub

    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bNuevo.Click
        Estatus = "N"
        gCatalogo.Enabled = False
        Foto.Image = Nothing
        eIDEmp.Enabled = True
        eIDEmp.Text = ""
        eNombre.Text = ""
        ePaterno.Text = ""
        eMaterno.Text = ""
        cbAreas.EditValue = 1
        rbMujer.Checked = False
        rbHombre.Checked = False
        bIgnorar.Enabled = True
        bNuevo.Enabled = False
        bGuardar.Enabled = True
        eIDEmp.Focus()
        Foto.Image = Me.Icon.ToBitmap
    End Sub

    Private Sub CambiaStatus()
        'If Estatus = "L" Then Exit Sub ' Lectura
        Select Case Estatus
            Case "L" 'Sin estatus
                Estatus = "E" 'Edicion
                bGuardar.Enabled = True
                bIgnorar.Enabled = True
                bNuevo.Enabled = False
                'bEliminar.Enabled = False
                gCatalogo.Enabled = False
        End Select
    End Sub

    Private Sub bIgnorar_Click(sender As System.Object, e As System.EventArgs) Handles bIgnorar.Click
        gCatalogo.Enabled = True
        Foto.Image = Nothing
        eIDEmp.Enabled = True
        eIDEmp.Text = ""
        eNombre.Text = ""
        ePaterno.Text = ""
        eMaterno.Text = ""
        cbAreas.EditValue = -1
        rbMujer.Checked = False
        rbHombre.Checked = False
        bIgnorar.Enabled = False
        bNuevo.Enabled = True
        bGuardar.Enabled = False
        CargaLinea()
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        If IsNothing(Foto.Image) Then Foto.Image = Me.Icon.ToBitmap
        sFoto = bytesToString(ImagenToBytes(Foto.Image))
        If eNombre.Text = "" Or ePaterno.Text = "" Or (rbHombre.Checked = False And rbMujer.Checked = False) Or cbAreas.Text = "" Then
            MsgBox(Msj00057, MsgBoxStyle.Critical, Empresa & " Msj00057")
            Exit Sub
        Else
            Guardar()
        End If
    End Sub

    Private Sub Guardar()
        Try
            Dim cmd As New SqlCommand("spUPCatEmpleados", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            id = eIDEmp.Text
            If id = "" Then id = "0"
            cmd.Parameters.AddWithValue("@IDEmpleado", Integer.Parse(id))
            Select Case Estatus
                Case "N"
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
                Case "E"
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 2
            End Select
            'cmd.Parameters.Add("@idLinea", SqlDbType.Int).Value = eLin.Text
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 250).Value = eNombre.Text
            cmd.Parameters.Add("@Paterno", SqlDbType.VarChar, 50).Value = ePaterno.Text
            cmd.Parameters.Add("@Materno", SqlDbType.VarChar, 50).Value = eMaterno.Text
            If rbHombre.Checked = True Then
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar, 1).Value = "H"
            Else
                cmd.Parameters.Add("@Genero", SqlDbType.VarChar, 1).Value = "M"
            End If
            cmd.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = ImagenToBytes(Foto.Image) 'sFoto
            cmd.Parameters.Add("@Area", SqlDbType.VarChar, 50).Value = cbAreas.Text
            cmd.Parameters.Add("@Activo", SqlDbType.Bit).Value = cbActivo.Checked
            cmd.Parameters.Add("@IDArea", SqlDbType.VarChar, 50).Value = cbAreas.EditValue
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
        Catch ex As Exception
            MsgBox(Msj00020 & " " & ex.Message.ToString, MsgBoxStyle.Critical, Empresa & " MSJ00020")
            Exit Sub
        End Try
        bGuardar.Enabled = False
        bNuevo.Enabled = True
        bIgnorar.Enabled = False
        CargaCatalogo()
        MsgBox(Msj00021, MsgBoxStyle.Information, Empresa & " MSJ00021") 'Se guardo de manera correcta
    End Sub

    Private Sub bFoto_Click(sender As System.Object, e As System.EventArgs) Handles bFoto.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Archivo de Imagenes|*.jpg"
        openFileDialog1.Title = "Selecciona una imagen"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ' Assign the cursor in the Stream to the Form's Cursor property.
            Dim fi As New FileInfo(openFileDialog1.FileName)
            If fi.Exists Then
                If (fi.Length / 1024) > 1024 Then
                    MsgBox(Msj00058 & Math.Round(((fi.Length / 1024) / 1024), 2).ToString() & " Mb", MsgBoxStyle.Critical, Empresa & " MSJ00028")
                    Exit Sub
                End If
            Else
            End If
            Foto.Load(openFileDialog1.FileName)
            CambiaStatus()
            'Foto.
            'Me.Cursor = New Cursor(openFileDialog1.OpenFile())
        End If
    End Sub

    Private Sub eNombre_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eNombre.KeyPress, ePaterno.KeyPress, eMaterno.KeyPress
        CambiaStatus()
    End Sub

    Private Sub cbArea_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbArea.SelectedValueChanged
        CambiaStatus()
    End Sub

    Private Sub cbActivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbActivo.CheckedChanged
        CambiaStatus()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        CargaLinea()
        Estatus = "L"
    End Sub
    Private Sub CargaCombos()
        SQL = "Select IDArea, Area from CatAreas with(nolock) where Activo = 1 order by Area"
        Dim dsModelo As New DataTable
        Dim daModelo As New SqlDataAdapter
        Dim cmdModelo As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daModelo.SelectCommand = cmdModelo
        daModelo.Fill(dsModelo)
        cbAreas.Properties.DataSource = dsModelo
        cbAreas.Properties.ValueMember = "IDArea"
        cbAreas.Properties.DisplayMember = "Area"
    End Sub

    Private Sub cbAreas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAreas.Click
        CambiaStatus()
    End Sub
End Class