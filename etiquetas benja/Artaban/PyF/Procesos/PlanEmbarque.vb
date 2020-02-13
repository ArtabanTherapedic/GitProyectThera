Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid

Public Class PlanEmbarque
    Dim SQL As String = ""
    Dim dsCombos As New DataTable
    Dim daCombos As New SqlDataAdapter
    Private Sub CatComposiciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaArticulos()
        CargaClientes()
        'MsgBox(txtempresa)
    End Sub

    Private Sub CargaArticulos()
        If Empresa = "Artaban Internacional" Then
            SQL = "Select PartNum as SKU, PartDescription as Descripcion from produccion.erp.part as Parte with(nolock)" & _
                        " where company = 'ARTABAN1' AND substring(PArtNum,1,1) = '8' and InActive = 0"
        Else
            SQL = " Select PartNum as SKU, PartDescription as Descripcion from pilot.erp.part as Parte with(nolock)" & _
                        " where company = 'ARTABAN2'"
        End If
        Dim dsPT As New DataTable
        Dim daPT As New SqlDataAdapter
        Dim cmdPT As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daPT.SelectCommand = cmdPT
        daPT.Fill(dsPT)
        cbCodigo.Properties.DataSource = dsPT
        cbCodigo.Properties.DisplayMember = "SKU"
        cbCodigo.Properties.ValueMember = "SKU"
        'cbCodigo.Properties.Columns(0).Visible = False
        cbDesc.Properties.DataSource = dsPT
        cbDesc.Properties.DisplayMember = "Descripcion"
        cbDesc.Properties.ValueMember = "SKU"
    End Sub

    Private Sub CargaClientes()
        If Empresa = "Artaban Internacional" Then
            SQL = "select CustID IDCliente, Name Cliente  from produccion.erp.Customer with(Nolock) where Company = 'ARTABAN1'"
        Else
            SQL = "select CustID IDCliente, Name Cliente  from pilot.erp.Customer with(Nolock) where Company = 'ARTABAN2'"
        End If
        Dim dsPT As New DataTable
        Dim daPT As New SqlDataAdapter
        Dim cmdPT As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daPT.SelectCommand = cmdPT
        daPT.Fill(dsPT)
        cbIDCliente.Properties.DataSource = dsPT
        cbIDCliente.Properties.DisplayMember = "IDCliente"
        cbIDCliente.Properties.ValueMember = "IDCliente"
        'cbCodigo.Properties.Columns(0).Visible = False
        cbCliente.Properties.DataSource = dsPT
        cbCliente.Properties.DisplayMember = "Cliente"
        cbCliente.Properties.ValueMember = "IDCliente"
    End Sub

    Private Sub CargaCatalogo()
        SQL = "Select idComp, Abreviacion, Descripcion, Observaciones from vCatComposicionesE "
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

    Private Sub cbCodigo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbCodigo.EditValueChanged
        If Not cbCodigo.EditValue = cbDesc.EditValue Then ' si los registros de la descripcion es igual al del codigo no realiza cambios
            cbDesc.EditValue = cbCodigo.EditValue
        End If
    End Sub

    Private Sub cbDesc_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbDesc.EditValueChanged
        If Not cbCodigo.EditValue = cbDesc.EditValue Then ' si los registros de la descripcion es igual al del codigo no realiza cambios
            cbCodigo.EditValue = cbDesc.EditValue
        End If
    End Sub

    Private Sub cbIDCliente_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbIDCliente.EditValueChanged
        If Not cbIDCliente.EditValue = cbCliente.EditValue Then ' si los registros de la descripcion es igual al del codigo no realiza cambios
            cbCliente.EditValue = cbIDCliente.EditValue
        End If
    End Sub

    Private Sub cbCliente_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbCliente.EditValueChanged
        If Not cbIDCliente.EditValue = cbCliente.EditValue Then ' si los registros de la descripcion es igual al del codigo no realiza cambios
            cbIDCliente.EditValue = cbCliente.EditValue
        End If
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        Dim dtGrid As New System.Data.DataTable
        Dim daGrid As New SqlDataAdapter
        Dim SQLArmado = "exec spRepPlanEmb " 'spRepPlanEmb(@FI varchar(10), @FF varchar(10), @IdCliente varchar(10), @OV as varchar(10), @NoParte varchar(50))
        If cbFechas.Checked = True Then
            SQLArmado = SQLArmado + "'" + FechaI.Text + "', '" + FechaFinal.Text + "', "
        Else
            SQLArmado = SQLArmado + "'', '', "
        End If

        If cbIDCliente.Text = "" Then
            SQLArmado = SQLArmado + "'',"
        Else
            SQLArmado = SQLArmado + "'" + cbIDCliente.Text + "', "
        End If

        If eOV.Text <> "" Then
            If IsNumeric(eOV.Text) = True Then
                SQLArmado = SQLArmado + "'" + eOV.Text + "', "
            Else
                SQLArmado = SQLArmado + "'', "
            End If
        Else
            SQLArmado = SQLArmado + "'', "
        End If

        If cbCodigo.Text <> "" Then
            SQLArmado = SQLArmado + "'" + cbCodigo.Text + "'"
        Else
            SQLArmado = SQLArmado + "''"
        End If

        Dim cmdGrid As New SqlCommand(SQLArmado, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daGrid.SelectCommand = cmdGrid
        daGrid.Fill(dtGrid)
        gCatalogo.DataSource = dtGrid
    End Sub

    Private Sub bImprimir_Click(sender As System.Object, e As System.EventArgs) Handles bImprimir.Click
        gCatalogo.PrintDialog()
    End Sub

    Private Sub bPDF_Click(sender As System.Object, e As System.EventArgs) Handles bPDF.Click
        ' gCatalogo.ExportToPdf("C:\Artaban\PlanEmb.pdf")
        ExportarPDF(gCatalogo)
    End Sub

    Private Sub bExcel_Click(sender As System.Object, e As System.EventArgs) Handles bExcel.Click
        ExportarXLSX(gCatalogo)
    End Sub

    Private Sub bLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles bLimpiar.Click
        gCatalogo.DataSource = Nothing
        cbCliente.EditValue = ""
        cbIDCliente.EditValue = ""
        cbFechas.Checked = True
        cbCodigo.EditValue = ""
        cbDesc.EditValue = ""
        eOV.Text = ""
        FechaI.Value = Now
        FechaFinal.Value = Now
    End Sub

    Private Sub GridView1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.FieldName = "Facturado" Then
            'Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Category"))
            Dim Cantidad As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Cantidad"))
            Dim Facturado As Integer = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Facturado"))
            If Facturado = 0 Then
                e.Appearance.BackColor = Color.White
            Else
                If Facturado < Cantidad Then
                    e.Appearance.BackColor = Color.Salmon
                    'e.Appearance.BackColor2 = Color.LightCyan
                Else
                    e.Appearance.BackColor = Color.LightBlue
                End If
            End If
        End If

        If e.Column.FieldName = "OV" Then
            'Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Category"))
            Dim Estatus As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Estatus"))
            If Estatus = "Cerrado" Then
                e.Appearance.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub pLeft_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pLeft.Paint

    End Sub
End Class