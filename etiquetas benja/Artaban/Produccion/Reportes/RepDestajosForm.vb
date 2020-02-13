Imports System.Data.SqlClient
Imports System.IO

Public Class RepDestajosForm
    Dim SQL As String = ""
    Dim dsCombos As New DataTable
    Dim daCombos As New SqlDataAdapter
    Dim id As String = "0"
    Dim sFoto As String = ""
    Dim Estatus As String = ""

    Private Sub RepDestajos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaComboItem()
        FechaI.DateTime = Now
        FechaF.DateTime = Now
        'CargaComposiciones()
        ' CargaCatalogo()
    End Sub

    Private Sub CargaComboItem()
        Dim ds1 As New DataSet
        Dim dt1 = ds1.Tables
        Dim da1 = New SqlDataAdapter("Select idEmpleado, Nombre + ' ' +isnull(Paterno,'') + ' ' + isnull(Materno, '') Nombre, Foto from CatEmpleados with(Nolock) where Activo = 1", Conexion01)
        da1.Fill(ds1, "Items")
        With cbIdEmp
            .DataSource = ds1.Tables("Items")
            .DisplayMember = "idEmpleado"
            .ValueMember = "Nombre"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        'cbIdEmp.Text = ""
        Dim ds = New DataSet
        Dim dt = ds.Tables
        Dim da = New SqlDataAdapter("Select idEmpleado, Nombre + ' ' +isnull(Paterno,'') + ' ' + isnull(Materno, '') Nombre, Foto from CatEmpleados with(Nolock) where Activo = 1", Conexion01)
        da.Fill(ds, "Items")
        With cbEmpleado
            .DataSource = ds.Tables("Items")
            .DisplayMember = "Nombre"
            .ValueMember = "idEmpleado"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        'cbEmpleado.Text = ""

    End Sub

    Private Sub CargaCatalogo()
        SQL = "exec spRepDestajos '" + cbIdEmp.Text + "', '" + FechaI.Text + "', '" + FechaF.Text + "', '" + cbArea.Text + "'"
        Dim daCat As New SqlDataAdapter
        Dim dsCat As New DataTable
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCat.Dispose()
        daCat.SelectCommand = CMD
        daCat.Fill(dsCat)
        gCatalogo.DataSource = dsCat
        'CargaLinea()
        'Estatus = "L" 'Lectura
        'gCatalogo.Enabled = True
    End Sub

    Private Sub CargaLinea()
        'If GridView1.SelectedRowsCount > 0 Then
        '    If IsDBNull(GridView1.GetFocusedRowCellValue("idEmpleado")) Then
        '        eIDEmp.Text = ""
        '        id = 0
        '    Else
        '        eIDEmp.Text = Format(GridView1.GetFocusedRowCellValue("idEmpleado"), "000000")
        '        id = Convert.ToInt64(eIDEmp.Text)
        '    End If
        '    If IsDBNull(GridView1.GetFocusedRowCellValue("Area")) Then
        '        cbArea.SelectedIndex = -1
        '    Else
        '        cbArea.Text = GridView1.GetFocusedRowCellValue("Area")
        '    End If
        '    If IsDBNull(GridView1.GetFocusedRowCellValue("Nombre")) Then
        '        eNombre.Text = ""
        '    Else
        '        eNombre.Text = GridView1.GetFocusedRowCellValue("Nombre")
        '    End If
        '    If IsDBNull(GridView1.GetFocusedRowCellValue("Paterno")) Then
        '        ePaterno.Text = ""
        '    Else
        '        ePaterno.Text = GridView1.GetFocusedRowCellValue("Paterno")
        '    End If
        '    If IsDBNull(GridView1.GetFocusedRowCellValue("Materno")) Then
        '        eMaterno.Text = ""
        '    Else
        '        eMaterno.Text = GridView1.GetFocusedRowCellValue("Materno")
        '    End If
        '    If IsDBNull(GridView1.GetFocusedRowCellValue("Activo")) Then
        '        cbActivo.Checked = False
        '    Else
        '        cbActivo.Checked = GridView1.GetFocusedRowCellValue("Activo")
        '    End If
        '    If Not IsDBNull(GridView1.GetFocusedRowCellValue("Genero")) Then
        '        If GridView1.GetFocusedRowCellValue("Genero") = "M" Then
        '            rbMujer.Checked = True
        '        Else
        '            rbHombre.Checked = True
        '        End If
        '    End If

        '    If IsDBNull(GridView1.GetFocusedRowCellValue("Foto")) Then
        '        Foto.Image = Nothing
        '    Else
        '        Foto.Image = BytesToImagen(GridView1.GetFocusedRowCellValue("Foto"))
        '        'sFoto = GridView1.GetFocusedRowCellValue("Foto")
        '        'If sFoto = "" Then
        '        '    Foto.Image = Nothing
        '        'Else
        '        '    'Foto.Image = BytesToImagen(consultaByte(sFoto))
        '        '    Foto.Image = BytesToImagen(consultaByte(sFoto))
        '        'End If
        '    End If
        'Else
        '    eIDEmp.Text = "000000"
        '    cbActivo.Checked = False
        'End If
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

    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bNuevo.Click
        cbIdEmp.Text = ""
        cbArea.Text = ""
        cbEmpleado.Text = ""
        gCatalogo.DataSource = Nothing
        Foto.Image = Nothing
        FechaF.DateTime = Now
        FechaI.DateTime = Now
        cbArea.Text = ""
        cbArea.SelectedIndex = -1
    End Sub

    Private Sub CambiaStatus()
        'If Estatus = "L" Then Exit Sub ' Lectura
        Select Case Estatus
            Case "L" 'Sin estatus
                Estatus = "E" 'Edicion
                bGenerar.Enabled = True 
                bImprimir.Enabled = True
                bNuevo.Enabled = False
                'bEliminar.Enabled = False
                gCatalogo.Enabled = False
        End Select
    End Sub

    Private Sub bImprimir_Click(sender As System.Object, e As System.EventArgs) Handles bImprimir.Click
        gCatalogo.PrintDialog() 
    End Sub


    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        CargaLinea()
        'Estatus = "L"
    End Sub

    Private Sub bGenerar_Click(sender As System.Object, e As System.EventArgs) Handles bGenerar.Click
        CargaCatalogo()
    End Sub

    Private Sub bExportar_Click(sender As System.Object, e As System.EventArgs) Handles bExportar.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.CheckFileExists = False
        openFileDialog1.Title = "Selecciona la Ruta donde se Guardara el Documento"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim fi As New FileInfo(openFileDialog1.FileName)
            If fi.Extension = "" Then gCatalogo.ExportToXlsx(openFileDialog1.FileName + ".xlsx") Else gCatalogo.ExportToXlsx(openFileDialog1.FileName)
            Try
                If fi.Extension = "" Then Process.Start(openFileDialog1.FileName + ".xlsx") Else Process.Start(openFileDialog1.FileName)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If

    End Sub

    Private Sub cbIdEmp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbIdEmp.SelectedIndexChanged
        If cbIdEmp.Items.Count = 0 Then Exit Sub
        If cbIdEmp.SelectedIndex = -1 Or cbIdEmp.Text = "" Then
            cbIdEmp.SelectedIndex = -1
            cbIdEmp.Text = ""
        Else 
            If cbEmpleado.Items.Count = 0 Or cbIdEmp.Text = "" Then Exit Sub
            cbEmpleado.SelectedValue = cbIdEmp.Text
        End If
    End Sub

    Private Sub cbEmpleado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbEmpleado.SelectedIndexChanged
        If cbEmpleado.Items.Count = 0 Then Exit Sub
        If cbEmpleado.SelectedIndex = -1 Or cbEmpleado.Text = "" Then
            cbIdEmp.SelectedIndex = -1
            cbIdEmp.Text = ""
        Else 
            If cbIdEmp.Items.Count = 0 Then Exit Sub
            cbIdEmp.Text = cbEmpleado.SelectedValue.ToString
            'cbidArt.SelectedValue = cbArticulo.Text
        End If
    End Sub
End Class