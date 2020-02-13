<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtiquetasMPSForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtiquetasMPSForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.bExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pGral = New System.Windows.Forms.Panel()
        Me.pArticulo = New System.Windows.Forms.Panel()
        Me.cbOP = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbNoTrabajo = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbidArt = New System.Windows.Forms.ComboBox()
        Me.eTelaM = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.eClienteM = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ePedidoM = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.eCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbArticulo = New System.Windows.Forms.ComboBox()
        Me.pGrid = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gidEtiqueta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gConsecutivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gSKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gPedido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gTela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gnEtiqueta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbImpresora = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.eSKU = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ePedido = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.eIDEtiqueta = New DevExpress.XtraEditors.TextEdit()
        Me.cbFechas = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FFinallabel = New System.Windows.Forms.Label()
        Me.fFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FInicial = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LImpresion = New System.Windows.Forms.Label()
        Me.chkEstilo = New System.Windows.Forms.CheckBox()
        Me.lFechaFab = New System.Windows.Forms.Label()
        Me.FechaFab = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager1 = New Artaban.CalidadDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager2 = New Artaban.CalidadDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager3 = New Artaban.CalidadDataSetTableAdapters.TableAdapterManager()
        Me.pLeft.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pGral.SuspendLayout()
        Me.pArticulo.SuspendLayout()
        CType(Me.CbNoTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eTelaM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eClienteM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePedidoM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pGrid.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.eSKU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eIDEtiqueta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.Panel1)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(774, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 560)
        Me.pLeft.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bGenerar)
        Me.Panel1.Controls.Add(Me.bBuscar)
        Me.Panel1.Controls.Add(Me.bLimpiar)
        Me.Panel1.Controls.Add(Me.bExcel)
        Me.Panel1.Controls.Add(Me.bImprimir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 350)
        Me.Panel1.TabIndex = 104
        '
        'bGenerar
        '
        Me.bGenerar.Image = CType(resources.GetObject("bGenerar.Image"), System.Drawing.Image)
        Me.bGenerar.Location = New System.Drawing.Point(11, 186)
        Me.bGenerar.Name = "bGenerar"
        Me.bGenerar.Size = New System.Drawing.Size(140, 35)
        Me.bGenerar.TabIndex = 111
        Me.bGenerar.Text = "&Generar Etiquetas"
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(11, 309)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(140, 35)
        Me.bBuscar.TabIndex = 110
        Me.bBuscar.Text = "&Buscar"
        '
        'bLimpiar
        '
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(11, 268)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(140, 35)
        Me.bLimpiar.TabIndex = 109
        Me.bLimpiar.Text = "&Limpiar"
        '
        'bExcel
        '
        Me.bExcel.Image = CType(resources.GetObject("bExcel.Image"), System.Drawing.Image)
        Me.bExcel.Location = New System.Drawing.Point(11, 144)
        Me.bExcel.Name = "bExcel"
        Me.bExcel.Size = New System.Drawing.Size(140, 35)
        Me.bExcel.TabIndex = 108
        Me.bExcel.Text = "Generar de &Excel"
        '
        'bImprimir
        '
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(11, 227)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(140, 35)
        Me.bImprimir.TabIndex = 10
        Me.bImprimir.Text = "&Imprimir"
        '
        'pExit
        '
        Me.pExit.Controls.Add(Me.bSalir)
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pExit.Location = New System.Drawing.Point(0, 350)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(163, 210)
        Me.pExit.TabIndex = 1
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(7, 163)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(140, 35)
        Me.bSalir.TabIndex = 104
        Me.bSalir.Text = "&Salir"
        '
        'pGral
        '
        Me.pGral.Controls.Add(Me.pArticulo)
        Me.pGral.Controls.Add(Me.pGrid)
        Me.pGral.Controls.Add(Me.Panel2)
        Me.pGral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pGral.Location = New System.Drawing.Point(0, 0)
        Me.pGral.Name = "pGral"
        Me.pGral.Size = New System.Drawing.Size(774, 560)
        Me.pGral.TabIndex = 8
        '
        'pArticulo
        '
        Me.pArticulo.Controls.Add(Me.cbOP)
        Me.pArticulo.Controls.Add(Me.Label2)
        Me.pArticulo.Controls.Add(Me.CbNoTrabajo)
        Me.pArticulo.Controls.Add(Me.cbidArt)
        Me.pArticulo.Controls.Add(Me.eTelaM)
        Me.pArticulo.Controls.Add(Me.Label14)
        Me.pArticulo.Controls.Add(Me.eClienteM)
        Me.pArticulo.Controls.Add(Me.Label13)
        Me.pArticulo.Controls.Add(Me.ePedidoM)
        Me.pArticulo.Controls.Add(Me.Label12)
        Me.pArticulo.Controls.Add(Me.eCantidad)
        Me.pArticulo.Controls.Add(Me.Label11)
        Me.pArticulo.Controls.Add(Me.Label10)
        Me.pArticulo.Controls.Add(Me.cbArticulo)
        Me.pArticulo.Dock = System.Windows.Forms.DockStyle.Right
        Me.pArticulo.Location = New System.Drawing.Point(125, 116)
        Me.pArticulo.Name = "pArticulo"
        Me.pArticulo.Size = New System.Drawing.Size(649, 444)
        Me.pArticulo.TabIndex = 79
        '
        'cbOP
        '
        Me.cbOP.Enabled = False
        Me.cbOP.FormattingEnabled = True
        Me.cbOP.Location = New System.Drawing.Point(69, 10)
        Me.cbOP.Name = "cbOP"
        Me.cbOP.Size = New System.Drawing.Size(523, 21)
        Me.cbOP.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Trabajo:"
        '
        'CbNoTrabajo
        '
        Me.CbNoTrabajo.Location = New System.Drawing.Point(69, 149)
        Me.CbNoTrabajo.Name = "CbNoTrabajo"
        Me.CbNoTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CbNoTrabajo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("JobNum", "JobNum", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.CbNoTrabajo.Properties.NullText = ""
        Me.CbNoTrabajo.Size = New System.Drawing.Size(523, 20)
        Me.CbNoTrabajo.TabIndex = 109
        Me.CbNoTrabajo.Visible = False
        '
        'cbidArt
        '
        Me.cbidArt.Enabled = False
        Me.cbidArt.FormattingEnabled = True
        Me.cbidArt.Location = New System.Drawing.Point(69, 36)
        Me.cbidArt.Name = "cbidArt"
        Me.cbidArt.Size = New System.Drawing.Size(121, 21)
        Me.cbidArt.TabIndex = 110
        '
        'eTelaM
        '
        Me.eTelaM.Location = New System.Drawing.Point(69, 119)
        Me.eTelaM.Name = "eTelaM"
        Me.eTelaM.Size = New System.Drawing.Size(316, 20)
        Me.eTelaM.TabIndex = 114
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Tela:"
        '
        'eClienteM
        '
        Me.eClienteM.Location = New System.Drawing.Point(276, 90)
        Me.eClienteM.Name = "eClienteM"
        Me.eClienteM.Size = New System.Drawing.Size(316, 20)
        Me.eClienteM.TabIndex = 113
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(230, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Cliente:"
        '
        'ePedidoM
        '
        Me.ePedidoM.Location = New System.Drawing.Point(69, 90)
        Me.ePedidoM.Name = "ePedidoM"
        Me.ePedidoM.Size = New System.Drawing.Size(121, 20)
        Me.ePedidoM.TabIndex = 112
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 103
        Me.Label12.Text = "Pedido:"
        '
        'eCantidad
        '
        Me.eCantidad.Location = New System.Drawing.Point(69, 63)
        Me.eCantidad.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.eCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.eCantidad.Name = "eCantidad"
        Me.eCantidad.Size = New System.Drawing.Size(97, 21)
        Me.eCantidad.TabIndex = 111
        Me.eCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.eCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Cantidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Artículo:"
        '
        'cbArticulo
        '
        Me.cbArticulo.Enabled = False
        Me.cbArticulo.FormattingEnabled = True
        Me.cbArticulo.Location = New System.Drawing.Point(196, 36)
        Me.cbArticulo.Name = "cbArticulo"
        Me.cbArticulo.Size = New System.Drawing.Size(396, 21)
        Me.cbArticulo.TabIndex = 110
        '
        'pGrid
        '
        Me.pGrid.Controls.Add(Me.gCatalogo)
        Me.pGrid.Dock = System.Windows.Forms.DockStyle.Left
        Me.pGrid.Location = New System.Drawing.Point(0, 116)
        Me.pGrid.Name = "pGrid"
        Me.pGrid.Size = New System.Drawing.Size(416, 444)
        Me.pGrid.TabIndex = 78
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(416, 444)
        Me.gCatalogo.TabIndex = 79
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gidEtiqueta, Me.gConsecutivo, Me.gOP, Me.gSKU, Me.Descripcion, Me.gPedido, Me.gCliente, Me.gTela, Me.gnEtiqueta, Me.gTotal})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'gidEtiqueta
        '
        Me.gidEtiqueta.Caption = "idEtiqueta"
        Me.gidEtiqueta.FieldName = "idEtiqueta"
        Me.gidEtiqueta.Name = "gidEtiqueta"
        Me.gidEtiqueta.OptionsColumn.AllowEdit = False
        Me.gidEtiqueta.OptionsColumn.ReadOnly = True
        '
        'gConsecutivo
        '
        Me.gConsecutivo.Caption = "No. Etiqueta"
        Me.gConsecutivo.FieldName = "Consecutivo"
        Me.gConsecutivo.Name = "gConsecutivo"
        Me.gConsecutivo.OptionsColumn.AllowEdit = False
        Me.gConsecutivo.OptionsColumn.ReadOnly = True
        Me.gConsecutivo.Visible = True
        Me.gConsecutivo.VisibleIndex = 1
        '
        'gOP
        '
        Me.gOP.Caption = "OP"
        Me.gOP.FieldName = "OP"
        Me.gOP.Name = "gOP"
        Me.gOP.OptionsColumn.AllowEdit = False
        Me.gOP.OptionsColumn.ReadOnly = True
        Me.gOP.Visible = True
        Me.gOP.VisibleIndex = 2
        '
        'gSKU
        '
        Me.gSKU.Caption = "SKU"
        Me.gSKU.FieldName = "SKU"
        Me.gSKU.Name = "gSKU"
        Me.gSKU.OptionsColumn.AllowEdit = False
        Me.gSKU.OptionsColumn.ReadOnly = True
        Me.gSKU.Visible = True
        Me.gSKU.VisibleIndex = 3
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripcion"
        Me.Descripcion.FieldName = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.OptionsColumn.AllowEdit = False
        Me.Descripcion.OptionsColumn.ReadOnly = True
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 0
        Me.Descripcion.Width = 180
        '
        'gPedido
        '
        Me.gPedido.Caption = "Pedido"
        Me.gPedido.FieldName = "Pedido"
        Me.gPedido.Name = "gPedido"
        Me.gPedido.OptionsColumn.AllowEdit = False
        Me.gPedido.OptionsColumn.ReadOnly = True
        Me.gPedido.Visible = True
        Me.gPedido.VisibleIndex = 4
        '
        'gCliente
        '
        Me.gCliente.Caption = "Cliente"
        Me.gCliente.FieldName = "Cliente"
        Me.gCliente.Name = "gCliente"
        Me.gCliente.OptionsColumn.AllowEdit = False
        Me.gCliente.OptionsColumn.ReadOnly = True
        Me.gCliente.Visible = True
        Me.gCliente.VisibleIndex = 5
        '
        'gTela
        '
        Me.gTela.Caption = "Tela"
        Me.gTela.FieldName = "Tela"
        Me.gTela.Name = "gTela"
        Me.gTela.OptionsColumn.AllowEdit = False
        Me.gTela.OptionsColumn.ReadOnly = True
        Me.gTela.Visible = True
        Me.gTela.VisibleIndex = 6
        '
        'gnEtiqueta
        '
        Me.gnEtiqueta.Caption = "Etiqueta"
        Me.gnEtiqueta.FieldName = "nEtiqueta"
        Me.gnEtiqueta.Name = "gnEtiqueta"
        Me.gnEtiqueta.OptionsColumn.AllowEdit = False
        Me.gnEtiqueta.OptionsColumn.ReadOnly = True
        Me.gnEtiqueta.Visible = True
        Me.gnEtiqueta.VisibleIndex = 7
        '
        'gTotal
        '
        Me.gTotal.Caption = "Total"
        Me.gTotal.FieldName = "TotEtiquetas"
        Me.gTotal.Name = "gTotal"
        Me.gTotal.OptionsColumn.AllowEdit = False
        Me.gTotal.OptionsColumn.ReadOnly = True
        Me.gTotal.Visible = True
        Me.gTotal.VisibleIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cbImpresora)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.eSKU)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ePedido)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.eIDEtiqueta)
        Me.Panel2.Controls.Add(Me.cbFechas)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.FFinallabel)
        Me.Panel2.Controls.Add(Me.fFinal)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.FInicial)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 116)
        Me.Panel2.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(574, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Selección de Impresora :"
        '
        'cbImpresora
        '
        Me.cbImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImpresora.FormattingEnabled = True
        Me.cbImpresora.Location = New System.Drawing.Point(577, 86)
        Me.cbImpresora.Name = "cbImpresora"
        Me.cbImpresora.Size = New System.Drawing.Size(194, 21)
        Me.cbImpresora.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(402, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "SKU:"
        '
        'eSKU
        '
        Me.eSKU.Location = New System.Drawing.Point(438, 86)
        Me.eSKU.Name = "eSKU"
        Me.eSKU.Size = New System.Drawing.Size(121, 20)
        Me.eSKU.TabIndex = 90
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(229, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Pedido:"
        '
        'ePedido
        '
        Me.ePedido.Location = New System.Drawing.Point(278, 86)
        Me.ePedido.Name = "ePedido"
        Me.ePedido.Size = New System.Drawing.Size(105, 20)
        Me.ePedido.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "No. Etiqueta:"
        '
        'eIDEtiqueta
        '
        Me.eIDEtiqueta.Location = New System.Drawing.Point(88, 86)
        Me.eIDEtiqueta.Name = "eIDEtiqueta"
        Me.eIDEtiqueta.Size = New System.Drawing.Size(105, 20)
        Me.eIDEtiqueta.TabIndex = 86
        '
        'cbFechas
        '
        Me.cbFechas.AutoSize = True
        Me.cbFechas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbFechas.Checked = True
        Me.cbFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFechas.Location = New System.Drawing.Point(399, 59)
        Me.cbFechas.Name = "cbFechas"
        Me.cbFechas.Size = New System.Drawing.Size(160, 17)
        Me.cbFechas.TabIndex = 85
        Me.cbFechas.Text = "Habilitar Filtrado por Fechas"
        Me.cbFechas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Filtros de Busqueda:"
        '
        'FFinallabel
        '
        Me.FFinallabel.AutoSize = True
        Me.FFinallabel.Location = New System.Drawing.Point(207, 63)
        Me.FFinallabel.Name = "FFinallabel"
        Me.FFinallabel.Size = New System.Drawing.Size(65, 13)
        Me.FFinallabel.TabIndex = 83
        Me.FFinallabel.Text = "Fecha Final:"
        '
        'fFinal
        '
        Me.fFinal.CustomFormat = "dd/MMM/yyyy"
        Me.fFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fFinal.Location = New System.Drawing.Point(278, 59)
        Me.fFinal.Name = "fFinal"
        Me.fFinal.Size = New System.Drawing.Size(105, 21)
        Me.fFinal.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Fecha Inicial:"
        '
        'FInicial
        '
        Me.FInicial.CustomFormat = "dd/MMM/yyyy"
        Me.FInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FInicial.Location = New System.Drawing.Point(88, 59)
        Me.FInicial.Name = "FInicial"
        Me.FInicial.Size = New System.Drawing.Size(105, 21)
        Me.FInicial.TabIndex = 80
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LImpresion)
        Me.Panel3.Controls.Add(Me.chkEstilo)
        Me.Panel3.Controls.Add(Me.lFechaFab)
        Me.Panel3.Controls.Add(Me.FechaFab)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(774, 40)
        Me.Panel3.TabIndex = 78
        '
        'LImpresion
        '
        Me.LImpresion.AutoSize = True
        Me.LImpresion.BackColor = System.Drawing.Color.Red
        Me.LImpresion.ForeColor = System.Drawing.Color.White
        Me.LImpresion.Location = New System.Drawing.Point(558, 13)
        Me.LImpresion.Name = "LImpresion"
        Me.LImpresion.Size = New System.Drawing.Size(210, 13)
        Me.LImpresion.TabIndex = 82
        Me.LImpresion.Text = "Generando Impresion, favor de esperar..."
        Me.LImpresion.Visible = False
        '
        'chkEstilo
        '
        Me.chkEstilo.AutoSize = True
        Me.chkEstilo.Checked = True
        Me.chkEstilo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstilo.Location = New System.Drawing.Point(278, 12)
        Me.chkEstilo.Name = "chkEstilo"
        Me.chkEstilo.Size = New System.Drawing.Size(180, 17)
        Me.chkEstilo.TabIndex = 81
        Me.chkEstilo.Text = "Generacion de etiquetas Manual"
        Me.chkEstilo.UseVisualStyleBackColor = True
        '
        'lFechaFab
        '
        Me.lFechaFab.AutoSize = True
        Me.lFechaFab.Location = New System.Drawing.Point(14, 17)
        Me.lFechaFab.Name = "lFechaFab"
        Me.lFechaFab.Size = New System.Drawing.Size(112, 13)
        Me.lFechaFab.TabIndex = 79
        Me.lFechaFab.Text = "Fecha de Fabricacion:"
        '
        'FechaFab
        '
        Me.FechaFab.CustomFormat = "dd/MMM/yyyy"
        Me.FechaFab.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaFab.Location = New System.Drawing.Point(132, 11)
        Me.FechaFab.Name = "FechaFab"
        Me.FechaFab.Size = New System.Drawing.Size(105, 21)
        Me.FechaFab.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Fecha de Fabricacion:"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = Artaban.CalidadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = Artaban.CalidadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = Artaban.CalidadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EtiquetasMPSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 560)
        Me.Controls.Add(Me.pGral)
        Me.Controls.Add(Me.pLeft)
        Me.Name = "EtiquetasMPSForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLeft.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pGral.ResumeLayout(False)
        Me.pArticulo.ResumeLayout(False)
        Me.pArticulo.PerformLayout()
        CType(Me.CbNoTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eTelaM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eClienteM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePedidoM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pGrid.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.eSKU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eIDEtiqueta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pGral As System.Windows.Forms.Panel
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FFinallabel As System.Windows.Forms.Label
    Friend WithEvents fFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lFechaFab As System.Windows.Forms.Label
    Friend WithEvents FechaFab As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbFechas As System.Windows.Forms.CheckBox
    Friend WithEvents bLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents eIDEtiqueta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents eSKU As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ePedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbImpresora As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pArticulo As System.Windows.Forms.Panel
    Friend WithEvents eCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents pGrid As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gidEtiqueta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gConsecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gSKU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gTela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gnEtiqueta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkEstilo As System.Windows.Forms.CheckBox
    Friend WithEvents eClienteM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ePedidoM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents eTelaM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LImpresion As System.Windows.Forms.Label
    Friend WithEvents cbidArt As System.Windows.Forms.ComboBox
    Friend WithEvents TableAdapterManager1 As Artaban.CalidadDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager2 As Artaban.CalidadDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbNoTrabajo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TableAdapterManager3 As Artaban.CalidadDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cbOP As System.Windows.Forms.ComboBox
    Friend WithEvents FechaEt As System.Windows.Forms.DateTimePicker
End Class
