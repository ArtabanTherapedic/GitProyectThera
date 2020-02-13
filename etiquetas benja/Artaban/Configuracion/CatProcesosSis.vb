Imports System.Data.SqlClient

Public Class CatProcesosSis
    Dim SQL As String = ""
    Dim dsCombos As New DataTable
    Dim daCombos As New SqlDataAdapter
    Private Sub CatComposiciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CargaComposiciones()
        CargaCatalogo()
    End Sub

    Private Sub CargaCatalogo()
        SQL = "Select idComp, Abreviacion, Descripcion, Observaciones from vCatComposicionesE "
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
    End Sub

    Private Sub CargaComposiciones()

        SQL = "Select idComp, Abreviacion, Descripcion, Observaciones from vCatComposicionesE "
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        With LookUpComp.Properties
            .DataSource = dsCombos
            .ValueMember = "idComp"
            .DisplayMember = "Abreviacion"
            '.Columns("idComp").Width = 50
            '.Columns("Abreviacion").Width = 50
            'Dim Colid As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idComp", "idComp", 50)
            'Dim ColAbre As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abreviacion", "Abreviacion", 500)
            'Dim ColDesc As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 300)
            'Dim ColObs As New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Observaciones", "Observaciones", 300)
            'Colid.Visible = False
            'ColAbre.Width = 100
            'ColDesc.Width = 300
            'ColObs.Width = 300
            'ColAbre.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            '.Columns.Add(Colid)
            '.Columns.Add(ColAbre)
            '.Columns.Add(ColDesc)
            '.Columns.Add(ColObs)
            '.Columns(1).Width = 100
            '.Columns(2).Width = 500
            '.Columns(3).Width = 500
            '.
        End With
        LookUpComp.EditValue = 0



        'For Each row As DataRow In dtCombos.Rows
        '    LookUpComp.Properties.Items.Add(row.Item("Nombre").ToString.ToUpper)
        '    LookUpComp.Properties.display()
        'Next()
        'daCombos.Dispose()
        'dtCombos.Reset()
    End Sub

    Private Sub CatComposiciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub CatComposiciones_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub LookUpComp_EditValueChanged(sender As System.Object, e As System.EventArgs)
        eAbreviacion.Text = LookUpComp.EditValue
        'dsCombos.row()
        eDesc.Text = LookUpComp.Properties.Columns(2).ToString
        eObs.Text = LookUpComp.Properties.Columns(3).ToString
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub
End Class