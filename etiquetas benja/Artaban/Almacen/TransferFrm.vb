Imports System.Data.SqlClient

Public Class TransferFrm
    Public Origen As String
    Dim SQL = ""
    Private Sub TransferFrm_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If eFolio.Focused = True And (e.KeyChar = ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Tab)) Then BuscaFolio()
        Tab(e)
    End Sub

    Private Sub BuscaFolio()
        MsgBox("Hola")
    End Sub

    Private Sub TransferFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fMovimiento.DateTime = Now()
        CargaAlmO()
        CargaAlmD()
    End Sub
    Private Sub CargaAlmO()
        'Carga el Almacen Origen
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        SQL = "Select IDAlmacen, Almacen from CatAlmacen where Activo = 1 and Tipo = '" & Origen & "'"
        'SQL = "Select Codigo as Producto, Descripcion from productos with(NoLock) order by Descripcion"
        Dim dsAlmO As New DataTable
        Dim daAlmO As New SqlDataAdapter
        Dim cmdAlmO As New SqlCommand(SQL, Conexion01)
        daAlmO.SelectCommand = cmdAlmO
        daAlmO.Fill(dsAlmO)
        cbAlmacenO.Properties.DataSource = dsAlmO
        cbAlmacenO.Properties.DisplayMember = "Almacen"
        cbAlmacenO.Properties.ValueMember = "IDAlmacen"
        'cbAlmacenO.Properties.Columns(0).Visible = False
        cbAlmacenO.EditValue = ""
    End Sub

    Private Sub CargaUbO()
        If cbAlmacenO.Text = "" Then Exit Sub
        'Carga Ubicaciones para el Origen
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        SQL = "Select IDUbicacion, Ubicacion from catUbicacion where Activo = 1 and IDAlmacen = '" & cbAlmacenO.EditValue.ToString & "'"
        Dim ds As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand(SQL, Conexion01)
        da.SelectCommand = cmd
        cbUbicacionO.Properties.DataSource = ds
        cbUbicacionO.Properties.DisplayMember = "Ubicacion"
        cbUbicacionO.Properties.ValueMember = "IDUbicacion"
        cbUbicacionO.Properties.Columns(0).Visible = False
        cbUbicacionO.EditValue = ""
    End Sub

    Private Sub CargaUbD()
        If cbAlmacenO.Text = "" Then Exit Sub
        'Carga Ubicaciones para el Origen
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        SQL = "Select IDUbicacion, Ubicacion from catUbicaciones where activo = 1 and IDAlmacen = '" & cbAlmacenO.EditValue.ToString & "'"
        Dim ds As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand(SQL, Conexion01)
        da.SelectCommand = cmd
        cbUbicacionD.Properties.DataSource = ds
        cbUbicacionD.Properties.DisplayMember = "Ubicacion"
        cbUbicacionD.Properties.ValueMember = "IDUbicacion"
        cbUbicacionD.Properties.Columns(0).Visible = False
        cbUbicacionD.EditValue = ""
    End Sub

    Private Sub CargaAlmD()
        'Carga el Almacen Destino
        SQL = "Select IDAlmacen, Almacen from CatAlmacen where Activo = 1 and Tipo = '" & Origen & "'"
        'SQL = "Select Codigo as Producto, Descripcion from productos with(NoLock) order by Descripcion"
        Dim ds As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        cbAlmacenD.Properties.DataSource = ds
        cbAlmacenD.Properties.DisplayMember = "Almacen"
        cbAlmacenD.Properties.ValueMember = "IDAlmacen"
        'cbAlmacenD.Properties.Columns(0).Visible = False
        cbAlmacenD.EditValue = ""
    End Sub

    Private Sub cbAlmacenO_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbAlmacenO.EditValueChanged
        CargaUbO()
    End Sub

    Private Sub cbAlmacenD_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbAlmacenD.EditValueChanged
        CargaUbO()
    End Sub

    Private Sub TransferFrm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub
End Class