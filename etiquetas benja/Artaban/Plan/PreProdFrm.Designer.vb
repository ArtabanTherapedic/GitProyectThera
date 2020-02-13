<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreProdFrm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreProdFrm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fFinal = New DevExpress.XtraEditors.DateEdit()
        Me.FInicial = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbFechas = New DevExpress.XtraEditors.CheckEdit()
        Me.eProducto = New DevExpress.XtraEditors.TextEdit()
        Me.ePC = New DevExpress.XtraEditors.TextEdit()
        Me.ePedido = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Grid1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Pedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Producto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FNecesidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FTela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ObsTela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FHuleEsp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ObsHuleEsp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FMadera = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ObsMadera = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R11Habilitado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.R11Retraso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R11Obs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R21Corte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R21Retraso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R21Obs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R12Armado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R12Retraso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R12Obs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R22Costura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R22Retraso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R22Obs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R13Encintado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R13Retraso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R13Obs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R23Llenado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R23Retraso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R23Obs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R24Moldeo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R24Retraso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R24Obs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R31Tapizado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R31Retraso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R31Obs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R32Empaque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R32Retraso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R32Obs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FechaPT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.fFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fFinal)
        Me.Panel1.Controls.Add(Me.FInicial)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbFechas)
        Me.Panel1.Controls.Add(Me.eProducto)
        Me.Panel1.Controls.Add(Me.ePC)
        Me.Panel1.Controls.Add(Me.ePedido)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 100)
        Me.Panel1.TabIndex = 0
        '
        'fFinal
        '
        Me.fFinal.EditValue = Nothing
        Me.fFinal.Enabled = False
        Me.fFinal.Location = New System.Drawing.Point(249, 69)
        Me.fFinal.Name = "fFinal"
        Me.fFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fFinal.Size = New System.Drawing.Size(126, 20)
        Me.fFinal.TabIndex = 10
        '
        'FInicial
        '
        Me.FInicial.EditValue = Nothing
        Me.FInicial.Enabled = False
        Me.FInicial.Location = New System.Drawing.Point(249, 39)
        Me.FInicial.Name = "FInicial"
        Me.FInicial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FInicial.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FInicial.Size = New System.Drawing.Size(126, 20)
        Me.FInicial.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Al :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Del:"
        '
        'cbFechas
        '
        Me.cbFechas.Location = New System.Drawing.Point(230, 10)
        Me.cbFechas.Name = "cbFechas"
        Me.cbFechas.Properties.Caption = "Activar Fecha Necesidad"
        Me.cbFechas.Size = New System.Drawing.Size(145, 19)
        Me.cbFechas.TabIndex = 6
        '
        'eProducto
        '
        Me.eProducto.Location = New System.Drawing.Point(61, 69)
        Me.eProducto.Name = "eProducto"
        Me.eProducto.Size = New System.Drawing.Size(100, 20)
        Me.eProducto.TabIndex = 5
        '
        'ePC
        '
        Me.ePC.Location = New System.Drawing.Point(61, 39)
        Me.ePC.Name = "ePC"
        Me.ePC.Size = New System.Drawing.Size(100, 20)
        Me.ePC.TabIndex = 4
        '
        'ePedido
        '
        Me.ePedido.Location = New System.Drawing.Point(61, 10)
        Me.ePedido.Name = "ePedido"
        Me.ePedido.Size = New System.Drawing.Size(100, 20)
        Me.ePedido.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PC:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pedido:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bLimpiar)
        Me.Panel3.Controls.Add(Me.bBuscar)
        Me.Panel3.Controls.Add(Me.bSalir)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(707, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(165, 340)
        Me.Panel3.TabIndex = 2
        '
        'bLimpiar
        '
        Me.bLimpiar.Dock = System.Windows.Forms.DockStyle.Top
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(0, 35)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(165, 35)
        Me.bLimpiar.TabIndex = 101
        Me.bLimpiar.Text = "&Limpiar"
        '
        'bBuscar
        '
        Me.bBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(0, 0)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(165, 35)
        Me.bBuscar.TabIndex = 100
        Me.bBuscar.Text = "&Buscar"
        '
        'bSalir
        '
        Me.bSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(0, 305)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(165, 35)
        Me.bSalir.TabIndex = 105
        Me.bSalir.Text = "&Salir"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Grid1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(707, 340)
        Me.Panel2.TabIndex = 3
        '
        'Grid1
        '
        Me.Grid1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Location = New System.Drawing.Point(0, 0)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.Grid1.Size = New System.Drawing.Size(707, 340)
        Me.Grid1.TabIndex = 0
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.Pedido, Me.PC, Me.Producto, Me.Cantidad, Me.FNecesidad, Me.FTela, Me.ObsTela, Me.FHuleEsp, Me.ObsHuleEsp, Me.FMadera, Me.ObsMadera, Me.R11Habilitado, Me.R11Retraso, Me.R11Obs, Me.R21Corte, Me.R21Retraso, Me.R21Obs, Me.R12Armado, Me.R12Retraso, Me.R12Obs, Me.R22Costura, Me.R22Retraso, Me.R22Obs, Me.R13Encintado, Me.R13Retraso, Me.R13Obs, Me.R23Llenado, Me.R23Retraso, Me.R23Obs, Me.R24Moldeo, Me.R24Retraso, Me.R24Obs, Me.R31Tapizado, Me.R31Retraso, Me.R31Obs, Me.R32Empaque, Me.R32Retraso, Me.R32Obs, Me.FechaPT})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.NewItemRowText = "Nuevo Registro"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'ID
        '
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        Me.ID.OptionsColumn.AllowEdit = False
        Me.ID.OptionsColumn.ReadOnly = True
        Me.ID.Visible = True
        Me.ID.VisibleIndex = 0
        Me.ID.Width = 50
        '
        'Pedido
        '
        Me.Pedido.FieldName = "Pedido"
        Me.Pedido.Name = "Pedido"
        Me.Pedido.OptionsColumn.AllowEdit = False
        Me.Pedido.OptionsColumn.ReadOnly = True
        Me.Pedido.Visible = True
        Me.Pedido.VisibleIndex = 1
        Me.Pedido.Width = 50
        '
        'PC
        '
        Me.PC.Caption = "PC"
        Me.PC.FieldName = "PC"
        Me.PC.Name = "PC"
        Me.PC.OptionsColumn.AllowEdit = False
        Me.PC.OptionsColumn.ReadOnly = True
        Me.PC.Visible = True
        Me.PC.VisibleIndex = 2
        Me.PC.Width = 76
        '
        'Producto
        '
        Me.Producto.Caption = "Producto"
        Me.Producto.FieldName = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.OptionsColumn.AllowEdit = False
        Me.Producto.OptionsColumn.ReadOnly = True
        Me.Producto.Visible = True
        Me.Producto.VisibleIndex = 3
        Me.Producto.Width = 250
        '
        'Cantidad
        '
        Me.Cantidad.Caption = "Cantidad"
        Me.Cantidad.FieldName = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.OptionsColumn.AllowEdit = False
        Me.Cantidad.OptionsColumn.ReadOnly = True
        Me.Cantidad.Visible = True
        Me.Cantidad.VisibleIndex = 4
        Me.Cantidad.Width = 55
        '
        'FNecesidad
        '
        Me.FNecesidad.Caption = "Fecha Necesidad"
        Me.FNecesidad.FieldName = "FNecesidad"
        Me.FNecesidad.Name = "FNecesidad"
        Me.FNecesidad.OptionsColumn.AllowEdit = False
        Me.FNecesidad.OptionsColumn.ReadOnly = True
        Me.FNecesidad.Visible = True
        Me.FNecesidad.VisibleIndex = 5
        Me.FNecesidad.Width = 90
        '
        'FTela
        '
        Me.FTela.Caption = "Fecha Tela"
        Me.FTela.FieldName = "FTela"
        Me.FTela.Name = "FTela"
        Me.FTela.OptionsColumn.AllowEdit = False
        Me.FTela.OptionsColumn.ReadOnly = True
        Me.FTela.Visible = True
        Me.FTela.VisibleIndex = 6
        Me.FTela.Width = 70
        '
        'ObsTela
        '
        Me.ObsTela.AppearanceCell.Options.UseTextOptions = True
        Me.ObsTela.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ObsTela.Caption = "Observaciones de Tela"
        Me.ObsTela.FieldName = "ObsTela"
        Me.ObsTela.Name = "ObsTela"
        Me.ObsTela.OptionsColumn.AllowEdit = False
        Me.ObsTela.OptionsColumn.ReadOnly = True
        Me.ObsTela.Visible = True
        Me.ObsTela.VisibleIndex = 7
        Me.ObsTela.Width = 200
        '
        'FHuleEsp
        '
        Me.FHuleEsp.Caption = "Fecha Hule Esp."
        Me.FHuleEsp.FieldName = "FHuleEsp"
        Me.FHuleEsp.Name = "FHuleEsp"
        Me.FHuleEsp.OptionsColumn.AllowEdit = False
        Me.FHuleEsp.OptionsColumn.ReadOnly = True
        Me.FHuleEsp.Visible = True
        Me.FHuleEsp.VisibleIndex = 8
        Me.FHuleEsp.Width = 85
        '
        'ObsHuleEsp
        '
        Me.ObsHuleEsp.AppearanceCell.Options.UseTextOptions = True
        Me.ObsHuleEsp.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ObsHuleEsp.Caption = "Observaciones de Hule Espuma"
        Me.ObsHuleEsp.FieldName = "ObsHuleEsp"
        Me.ObsHuleEsp.Name = "ObsHuleEsp"
        Me.ObsHuleEsp.OptionsColumn.AllowEdit = False
        Me.ObsHuleEsp.OptionsColumn.ReadOnly = True
        Me.ObsHuleEsp.Visible = True
        Me.ObsHuleEsp.VisibleIndex = 9
        Me.ObsHuleEsp.Width = 200
        '
        'FMadera
        '
        Me.FMadera.Caption = "Fecha de Madera"
        Me.FMadera.FieldName = "FMadera"
        Me.FMadera.Name = "FMadera"
        Me.FMadera.OptionsColumn.AllowEdit = False
        Me.FMadera.OptionsColumn.ReadOnly = True
        Me.FMadera.Visible = True
        Me.FMadera.VisibleIndex = 10
        Me.FMadera.Width = 95
        '
        'ObsMadera
        '
        Me.ObsMadera.AppearanceCell.Options.UseTextOptions = True
        Me.ObsMadera.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.ObsMadera.Caption = "Observaciones de Madera"
        Me.ObsMadera.FieldName = "ObsMadera"
        Me.ObsMadera.Name = "ObsMadera"
        Me.ObsMadera.OptionsColumn.AllowEdit = False
        Me.ObsMadera.OptionsColumn.ReadOnly = True
        Me.ObsMadera.Visible = True
        Me.ObsMadera.VisibleIndex = 11
        Me.ObsMadera.Width = 200
        '
        'R11Habilitado
        '
        Me.R11Habilitado.Caption = "Habilitado"
        Me.R11Habilitado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.R11Habilitado.FieldName = "R11Habilitado"
        Me.R11Habilitado.Name = "R11Habilitado"
        Me.R11Habilitado.OptionsColumn.AllowEdit = False
        Me.R11Habilitado.OptionsColumn.ReadOnly = True
        Me.R11Habilitado.Visible = True
        Me.R11Habilitado.VisibleIndex = 12
        Me.R11Habilitado.Width = 55
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'R11Retraso
        '
        Me.R11Retraso.Caption = "Ret. Habilitado"
        Me.R11Retraso.FieldName = "R11Retraso"
        Me.R11Retraso.Name = "R11Retraso"
        Me.R11Retraso.OptionsColumn.AllowEdit = False
        Me.R11Retraso.OptionsColumn.ReadOnly = True
        Me.R11Retraso.Visible = True
        Me.R11Retraso.VisibleIndex = 13
        Me.R11Retraso.Width = 80
        '
        'R11Obs
        '
        Me.R11Obs.AppearanceCell.Options.UseTextOptions = True
        Me.R11Obs.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.R11Obs.Caption = "Observaciones de Habilitado"
        Me.R11Obs.FieldName = "R11Obs"
        Me.R11Obs.Name = "R11Obs"
        Me.R11Obs.OptionsColumn.AllowEdit = False
        Me.R11Obs.OptionsColumn.ReadOnly = True
        Me.R11Obs.Visible = True
        Me.R11Obs.VisibleIndex = 14
        Me.R11Obs.Width = 200
        '
        'R21Corte
        '
        Me.R21Corte.Caption = "Corte"
        Me.R21Corte.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.R21Corte.FieldName = "R21Corte"
        Me.R21Corte.Name = "R21Corte"
        Me.R21Corte.OptionsColumn.AllowEdit = False
        Me.R21Corte.OptionsColumn.ReadOnly = True
        Me.R21Corte.Visible = True
        Me.R21Corte.VisibleIndex = 15
        Me.R21Corte.Width = 35
        '
        'R21Retraso
        '
        Me.R21Retraso.Caption = "Ret. Corte"
        Me.R21Retraso.FieldName = "R21Retraso"
        Me.R21Retraso.Name = "R21Retraso"
        Me.R21Retraso.OptionsColumn.AllowEdit = False
        Me.R21Retraso.OptionsColumn.ReadOnly = True
        Me.R21Retraso.Visible = True
        Me.R21Retraso.VisibleIndex = 16
        Me.R21Retraso.Width = 60
        '
        'R21Obs
        '
        Me.R21Obs.AppearanceCell.Options.UseTextOptions = True
        Me.R21Obs.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.R21Obs.Caption = "Observaciones de Corte"
        Me.R21Obs.Name = "R21Obs"
        Me.R21Obs.OptionsColumn.AllowEdit = False
        Me.R21Obs.OptionsColumn.ReadOnly = True
        Me.R21Obs.Visible = True
        Me.R21Obs.VisibleIndex = 17
        Me.R21Obs.Width = 200
        '
        'R12Armado
        '
        Me.R12Armado.Caption = "Armado"
        Me.R12Armado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.R12Armado.FieldName = "R12Armado"
        Me.R12Armado.Name = "R12Armado"
        Me.R12Armado.OptionsColumn.AllowEdit = False
        Me.R12Armado.OptionsColumn.ReadOnly = True
        Me.R12Armado.Visible = True
        Me.R12Armado.VisibleIndex = 18
        Me.R12Armado.Width = 45
        '
        'R12Retraso
        '
        Me.R12Retraso.Caption = "Ret. Armado"
        Me.R12Retraso.FieldName = "R12Retraso"
        Me.R12Retraso.Name = "R12Retraso"
        Me.R12Retraso.OptionsColumn.AllowEdit = False
        Me.R12Retraso.OptionsColumn.ReadOnly = True
        Me.R12Retraso.Visible = True
        Me.R12Retraso.VisibleIndex = 19
        Me.R12Retraso.Width = 70
        '
        'R12Obs
        '
        Me.R12Obs.AppearanceCell.Options.UseTextOptions = True
        Me.R12Obs.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.R12Obs.Caption = "Observaciones de Armado"
        Me.R12Obs.FieldName = "R12Obs"
        Me.R12Obs.Name = "R12Obs"
        Me.R12Obs.OptionsColumn.AllowEdit = False
        Me.R12Obs.OptionsColumn.ReadOnly = True
        Me.R12Obs.Visible = True
        Me.R12Obs.VisibleIndex = 20
        Me.R12Obs.Width = 200
        '
        'R22Costura
        '
        Me.R22Costura.Caption = "Costura"
        Me.R22Costura.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.R22Costura.FieldName = "R22Costura"
        Me.R22Costura.Name = "R22Costura"
        Me.R22Costura.OptionsColumn.AllowEdit = False
        Me.R22Costura.OptionsColumn.ReadOnly = True
        Me.R22Costura.Visible = True
        Me.R22Costura.VisibleIndex = 21
        Me.R22Costura.Width = 48
        '
        'R22Retraso
        '
        Me.R22Retraso.Caption = "Ret. Costura"
        Me.R22Retraso.FieldName = "R22Retraso"
        Me.R22Retraso.Name = "R22Retraso"
        Me.R22Retraso.OptionsColumn.AllowEdit = False
        Me.R22Retraso.OptionsColumn.ReadOnly = True
        Me.R22Retraso.Visible = True
        Me.R22Retraso.VisibleIndex = 22
        Me.R22Retraso.Width = 70
        '
        'R22Obs
        '
        Me.R22Obs.AppearanceCell.Options.UseTextOptions = True
        Me.R22Obs.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.R22Obs.Caption = "Observaciones de Costura"
        Me.R22Obs.FieldName = "R22Obs"
        Me.R22Obs.Name = "R22Obs"
        Me.R22Obs.OptionsColumn.AllowEdit = False
        Me.R22Obs.OptionsColumn.ReadOnly = True
        Me.R22Obs.Visible = True
        Me.R22Obs.VisibleIndex = 23
        Me.R22Obs.Width = 200
        '
        'R13Encintado
        '
        Me.R13Encintado.Caption = "Encintado"
        Me.R13Encintado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.R13Encintado.FieldName = "R13Encintado"
        Me.R13Encintado.Name = "R13Encintado"
        Me.R13Encintado.OptionsColumn.AllowEdit = False
        Me.R13Encintado.OptionsColumn.ReadOnly = True
        Me.R13Encintado.Visible = True
        Me.R13Encintado.VisibleIndex = 24
        Me.R13Encintado.Width = 55
        '
        'R13Retraso
        '
        Me.R13Retraso.Caption = "Ret. Encintado"
        Me.R13Retraso.FieldName = "R13Retraso"
        Me.R13Retraso.Name = "R13Retraso"
        Me.R13Retraso.OptionsColumn.AllowEdit = False
        Me.R13Retraso.OptionsColumn.ReadOnly = True
        Me.R13Retraso.Visible = True
        Me.R13Retraso.VisibleIndex = 25
        Me.R13Retraso.Width = 80
        '
        'R13Obs
        '
        Me.R13Obs.AppearanceCell.Options.UseTextOptions = True
        Me.R13Obs.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.R13Obs.Caption = "Observaciones de Encintado"
        Me.R13Obs.FieldName = "R13Obs"
        Me.R13Obs.Name = "R13Obs"
        Me.R13Obs.OptionsColumn.AllowEdit = False
        Me.R13Obs.OptionsColumn.ReadOnly = True
        Me.R13Obs.Visible = True
        Me.R13Obs.VisibleIndex = 26
        Me.R13Obs.Width = 200
        '
        'R23Llenado
        '
        Me.R23Llenado.Caption = "Llenado"
        Me.R23Llenado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.R23Llenado.FieldName = "R23Llenado"
        Me.R23Llenado.Name = "R23Llenado"
        Me.R23Llenado.OptionsColumn.AllowEdit = False
        Me.R23Llenado.OptionsColumn.ReadOnly = True
        Me.R23Llenado.Visible = True
        Me.R23Llenado.VisibleIndex = 27
        Me.R23Llenado.Width = 45
        '
        'R23Retraso
        '
        Me.R23Retraso.Caption = "Ret. Llenado"
        Me.R23Retraso.FieldName = "R23Retraso"
        Me.R23Retraso.Name = "R23Retraso"
        Me.R23Retraso.OptionsColumn.AllowEdit = False
        Me.R23Retraso.OptionsColumn.ReadOnly = True
        Me.R23Retraso.Visible = True
        Me.R23Retraso.VisibleIndex = 28
        Me.R23Retraso.Width = 70
        '
        'R23Obs
        '
        Me.R23Obs.AppearanceCell.Options.UseTextOptions = True
        Me.R23Obs.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.R23Obs.Caption = "Observaciones de Llenado"
        Me.R23Obs.FieldName = "R23Obs"
        Me.R23Obs.Name = "R23Obs"
        Me.R23Obs.OptionsColumn.AllowEdit = False
        Me.R23Obs.OptionsColumn.ReadOnly = True
        Me.R23Obs.Visible = True
        Me.R23Obs.VisibleIndex = 29
        Me.R23Obs.Width = 200
        '
        'R24Moldeo
        '
        Me.R24Moldeo.Caption = "Moldeo"
        Me.R24Moldeo.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.R24Moldeo.FieldName = "R24Moldeo"
        Me.R24Moldeo.Name = "R24Moldeo"
        Me.R24Moldeo.OptionsColumn.AllowEdit = False
        Me.R24Moldeo.OptionsColumn.ReadOnly = True
        Me.R24Moldeo.Visible = True
        Me.R24Moldeo.VisibleIndex = 30
        Me.R24Moldeo.Width = 43
        '
        'R24Retraso
        '
        Me.R24Retraso.Caption = "Ret. Moldeo"
        Me.R24Retraso.FieldName = "R24Retraso"
        Me.R24Retraso.Name = "R24Retraso"
        Me.R24Retraso.OptionsColumn.AllowEdit = False
        Me.R24Retraso.OptionsColumn.ReadOnly = True
        Me.R24Retraso.Visible = True
        Me.R24Retraso.VisibleIndex = 31
        Me.R24Retraso.Width = 68
        '
        'R24Obs
        '
        Me.R24Obs.AppearanceCell.Options.UseTextOptions = True
        Me.R24Obs.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.R24Obs.Caption = "Observaciones de Moldeo"
        Me.R24Obs.FieldName = "R24Obs"
        Me.R24Obs.Name = "R24Obs"
        Me.R24Obs.OptionsColumn.AllowEdit = False
        Me.R24Obs.OptionsColumn.ReadOnly = True
        Me.R24Obs.Visible = True
        Me.R24Obs.VisibleIndex = 32
        Me.R24Obs.Width = 200
        '
        'R31Tapizado
        '
        Me.R31Tapizado.Caption = "Tapizado"
        Me.R31Tapizado.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.R31Tapizado.FieldName = "R31Tapizado"
        Me.R31Tapizado.Name = "R31Tapizado"
        Me.R31Tapizado.OptionsColumn.AllowEdit = False
        Me.R31Tapizado.OptionsColumn.ReadOnly = True
        Me.R31Tapizado.Visible = True
        Me.R31Tapizado.VisibleIndex = 33
        Me.R31Tapizado.Width = 52
        '
        'R31Retraso
        '
        Me.R31Retraso.Caption = "Ret. Tapizado"
        Me.R31Retraso.FieldName = "R31Retraso"
        Me.R31Retraso.Name = "R31Retraso"
        Me.R31Retraso.OptionsColumn.AllowEdit = False
        Me.R31Retraso.OptionsColumn.ReadOnly = True
        Me.R31Retraso.Visible = True
        Me.R31Retraso.VisibleIndex = 34
        '
        'R31Obs
        '
        Me.R31Obs.Caption = "Observaciones de Tapizado"
        Me.R31Obs.FieldName = "R31Obs"
        Me.R31Obs.Name = "R31Obs"
        Me.R31Obs.OptionsColumn.AllowEdit = False
        Me.R31Obs.OptionsColumn.ReadOnly = True
        Me.R31Obs.Visible = True
        Me.R31Obs.VisibleIndex = 35
        Me.R31Obs.Width = 200
        '
        'R32Empaque
        '
        Me.R32Empaque.Caption = "Empaque"
        Me.R32Empaque.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.R32Empaque.FieldName = "R32Empaque"
        Me.R32Empaque.Name = "R32Empaque"
        Me.R32Empaque.OptionsColumn.AllowEdit = False
        Me.R32Empaque.OptionsColumn.ReadOnly = True
        Me.R32Empaque.Visible = True
        Me.R32Empaque.VisibleIndex = 36
        Me.R32Empaque.Width = 55
        '
        'R32Retraso
        '
        Me.R32Retraso.Caption = "Ret. Empaque"
        Me.R32Retraso.FieldName = "R32Retraso"
        Me.R32Retraso.Name = "R32Retraso"
        Me.R32Retraso.OptionsColumn.AllowEdit = False
        Me.R32Retraso.OptionsColumn.ReadOnly = True
        Me.R32Retraso.Visible = True
        Me.R32Retraso.VisibleIndex = 37
        Me.R32Retraso.Width = 76
        '
        'R32Obs
        '
        Me.R32Obs.Caption = "Observaciones de Empaque"
        Me.R32Obs.FieldName = "R32Obs"
        Me.R32Obs.Name = "R32Obs"
        Me.R32Obs.OptionsColumn.AllowEdit = False
        Me.R32Obs.OptionsColumn.ReadOnly = True
        Me.R32Obs.Visible = True
        Me.R32Obs.VisibleIndex = 38
        Me.R32Obs.Width = 200
        '
        'FechaPT
        '
        Me.FechaPT.Caption = "Fecha PT"
        Me.FechaPT.FieldName = "FechaPT"
        Me.FechaPT.Name = "FechaPT"
        Me.FechaPT.OptionsColumn.AllowEdit = False
        Me.FechaPT.OptionsColumn.ReadOnly = True
        Me.FechaPT.Visible = True
        Me.FechaPT.VisibleIndex = 39
        '
        'PreProdFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 440)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "PreProdFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preparación de Producción"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.fFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FInicial.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents fFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents FInicial As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbFechas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents eProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Pedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Producto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FNecesidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FTela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ObsTela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FHuleEsp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ObsHuleEsp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FMadera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ObsMadera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R11Habilitado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents R11Retraso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R11Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R21Corte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R21Retraso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R21Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R12Armado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R12Retraso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R12Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R22Costura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R22Retraso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R22Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R13Encintado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R13Retraso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R13Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R23Llenado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R23Retraso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R23Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R24Moldeo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R24Retraso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R24Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R31Tapizado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R31Retraso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R31Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R32Empaque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R32Retraso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R32Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FechaPT As DevExpress.XtraGrid.Columns.GridColumn
End Class
