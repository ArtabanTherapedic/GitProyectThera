Imports System.Data.SqlClient
Public Class BuscaItemFrm
    Dim SQL = ""
    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        If eCodigo.Text = "" Then Exit Sub
        SQL = "Select Cod.Producto, Cod.Descripcion from Factory..Produccion Prod inner join factory..Productos Cod " &
            " on Prod.Producto = Cod.Producto where ID = '" & eCodigo.Text & "'"
        Dim ds As New DataTable
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da.SelectCommand = cmd
        da.Fill(ds)
        If ds.Rows.Count = 0 Then
            eCFactory.Text = ""
            eDescripcion.Text = Msj00046
            eCodigo.Focus()
            Exit Sub
        End If
        eCFactory.Text = ds.Rows(0)(0).ToString
        eDescripcion.Text = ds.Rows(0)(1).ToString
        eCodigo.Text = ""
        eDescripcion.Focus()
    End Sub

    Private Sub BuscaItemFrm_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub BuscaItemFrm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub
End Class