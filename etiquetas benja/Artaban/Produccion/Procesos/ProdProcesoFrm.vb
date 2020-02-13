Imports System.Data.SqlClient

Public Class ProdProcesoFrm
    Dim SQL As String = ""
   
    Private Sub ProdProcesoFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaCombo(cbOperador, "Select -1 EmpID, '' Name union all select EmpID, Name from produccion.erp.EmpBasic with(nolock) where EmpStatus = 'A'", "EmpID", "Name")
        CargaCombo(cbOperacion, "Select '-1' OpCode, ''OpDesc union all select OpCode, OpDesc from Produccion.erp.OpMaster with(nolock) where OpType = 'MFG' ", "OpCode", "OpDesc")
        tRefrescar.Enabled = True
    End Sub

    Private Sub CargaCatalogo()
        gCatalogo.DataSource = Nothing
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter
        SQL = "exec spRepProdP '" + eOP.Text + "', '" + eParte.Text + "', "
        If cbOperador.Text = "" Then SQL = SQL + "'', " Else SQL = SQL + "'" + cbOperador.EditValue.ToString + "', "
        If cbOperacion.Text = "" Then SQL = SQL + "''" Else SQL = SQL + "'" + cbOperacion.EditValue.ToString + "'"
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

    Private Sub tRefrescar_Tick(sender As System.Object, e As System.EventArgs) Handles tRefrescar.Tick
        CargaCatalogo()
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        CargaCatalogo()
    End Sub

    Private Sub bLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles bLimpiar.Click
        eOP.Text = ""
        eParte.Text = ""
        cbOperacion.EditValue = "-1"
        cbOperador.EditValue = -1
        gCatalogo.DataSource = Nothing
    End Sub

    Private Sub bExportar_Click(sender As System.Object, e As System.EventArgs) Handles bExportar.Click
        ExportarXLSX(gCatalogo)
    End Sub
End Class