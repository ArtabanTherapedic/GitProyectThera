<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportesForm))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pReportes = New System.Windows.Forms.Panel()
        Me.cbReportes = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pFiltros = New System.Windows.Forms.Panel()
        Me.pFiltro4 = New System.Windows.Forms.Panel()
        Me.eFiltro4 = New System.Windows.Forms.TextBox()
        Me.lbFiltro4 = New System.Windows.Forms.Label()
        Me.pFiltro3 = New System.Windows.Forms.Panel()
        Me.eFiltro3 = New System.Windows.Forms.TextBox()
        Me.lbFiltro3 = New System.Windows.Forms.Label()
        Me.pFiltro2 = New System.Windows.Forms.Panel()
        Me.eFiltro2 = New System.Windows.Forms.TextBox()
        Me.lbFiltro2 = New System.Windows.Forms.Label()
        Me.pFiltro1 = New System.Windows.Forms.Panel()
        Me.eFiltro1 = New System.Windows.Forms.TextBox()
        Me.lbFiltro1 = New System.Windows.Forms.Label()
        Me.pCombo3 = New System.Windows.Forms.Panel()
        Me.cbComboDesc3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbCombo3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lbCombo3 = New System.Windows.Forms.Label()
        Me.pCombo2 = New System.Windows.Forms.Panel()
        Me.cbComboDesc2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbCombo2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lbCombo2 = New System.Windows.Forms.Label()
        Me.pCombo1 = New System.Windows.Forms.Panel()
        Me.cbComboDesc1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbCombo1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lbCombo1 = New System.Windows.Forms.Label()
        Me.pFechas = New System.Windows.Forms.Panel()
        Me.cbFechas = New System.Windows.Forms.CheckBox()
        Me.FechaF = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FechaI = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager1 = New Artaban.CalidadDataSetTableAdapters.TableAdapterManager()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pReportes.SuspendLayout()
        CType(Me.cbReportes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTop.SuspendLayout()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pFiltros.SuspendLayout()
        Me.pFiltro4.SuspendLayout()
        Me.pFiltro3.SuspendLayout()
        Me.pFiltro2.SuspendLayout()
        Me.pFiltro1.SuspendLayout()
        Me.pCombo3.SuspendLayout()
        CType(Me.cbComboDesc3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCombo3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCombo2.SuspendLayout()
        CType(Me.cbComboDesc2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCombo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCombo1.SuspendLayout()
        CType(Me.cbComboDesc1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCombo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pFechas.SuspendLayout()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bBuscar)
        Me.pLeft.Controls.Add(Me.bImprimir)
        Me.pLeft.Controls.Add(Me.bExportar)
        Me.pLeft.Controls.Add(Me.bLimpiar)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(684, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 560)
        Me.pLeft.TabIndex = 5
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(11, 174)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(140, 35)
        Me.bBuscar.TabIndex = 100
        Me.bBuscar.Text = "&Buscar"
        '
        'bImprimir
        '
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(11, 309)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(140, 35)
        Me.bImprimir.TabIndex = 103
        Me.bImprimir.Text = "&Imprimir"
        '
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(11, 263)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(140, 35)
        Me.bExportar.TabIndex = 102
        Me.bExportar.Text = "&Exportar"
        '
        'bLimpiar
        '
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(11, 218)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(140, 35)
        Me.bLimpiar.TabIndex = 101
        Me.bLimpiar.Text = "&Limpiar"
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
        'pReportes
        '
        Me.pReportes.Controls.Add(Me.cbReportes)
        Me.pReportes.Controls.Add(Me.Label5)
        Me.pReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.pReportes.Location = New System.Drawing.Point(0, 0)
        Me.pReportes.Name = "pReportes"
        Me.pReportes.Size = New System.Drawing.Size(684, 34)
        Me.pReportes.TabIndex = 8
        '
        'cbReportes
        '
        Me.cbReportes.Location = New System.Drawing.Point(127, 6)
        Me.cbReportes.Name = "cbReportes"
        Me.cbReportes.Size = New System.Drawing.Size(551, 20)
        Me.cbReportes.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Reportes Disponibles :"
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.Splitter1)
        Me.pTop.Controls.Add(Me.pCenter)
        Me.pTop.Controls.Add(Me.pFiltros)
        Me.pTop.Controls.Add(Me.pCombo3)
        Me.pTop.Controls.Add(Me.pCombo2)
        Me.pTop.Controls.Add(Me.pCombo1)
        Me.pTop.Controls.Add(Me.pFechas)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pTop.Location = New System.Drawing.Point(0, 34)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(684, 526)
        Me.pTop.TabIndex = 11
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Red
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 229)
        Me.Splitter1.MinSize = 10
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(684, 10)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 229)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(684, 297)
        Me.pCenter.TabIndex = 12
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(684, 297)
        Me.gCatalogo.TabIndex = 0
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "EneroFacturado", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'pFiltros
        '
        Me.pFiltros.Controls.Add(Me.pFiltro4)
        Me.pFiltros.Controls.Add(Me.pFiltro3)
        Me.pFiltros.Controls.Add(Me.pFiltro2)
        Me.pFiltros.Controls.Add(Me.pFiltro1)
        Me.pFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pFiltros.Location = New System.Drawing.Point(0, 184)
        Me.pFiltros.Name = "pFiltros"
        Me.pFiltros.Size = New System.Drawing.Size(684, 45)
        Me.pFiltros.TabIndex = 11
        Me.pFiltros.Visible = False
        '
        'pFiltro4
        '
        Me.pFiltro4.Controls.Add(Me.eFiltro4)
        Me.pFiltro4.Controls.Add(Me.lbFiltro4)
        Me.pFiltro4.Dock = System.Windows.Forms.DockStyle.Left
        Me.pFiltro4.Location = New System.Drawing.Point(513, 0)
        Me.pFiltro4.Name = "pFiltro4"
        Me.pFiltro4.Size = New System.Drawing.Size(171, 45)
        Me.pFiltro4.TabIndex = 14
        '
        'eFiltro4
        '
        Me.eFiltro4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eFiltro4.Location = New System.Drawing.Point(15, 19)
        Me.eFiltro4.Name = "eFiltro4"
        Me.eFiltro4.Size = New System.Drawing.Size(150, 21)
        Me.eFiltro4.TabIndex = 2
        '
        'lbFiltro4
        '
        Me.lbFiltro4.AutoSize = True
        Me.lbFiltro4.Location = New System.Drawing.Point(12, 3)
        Me.lbFiltro4.Name = "lbFiltro4"
        Me.lbFiltro4.Size = New System.Drawing.Size(83, 13)
        Me.lbFiltro4.TabIndex = 1
        Me.lbFiltro4.Text = "Etiqueta Filtro 3"
        '
        'pFiltro3
        '
        Me.pFiltro3.Controls.Add(Me.eFiltro3)
        Me.pFiltro3.Controls.Add(Me.lbFiltro3)
        Me.pFiltro3.Dock = System.Windows.Forms.DockStyle.Left
        Me.pFiltro3.Location = New System.Drawing.Point(342, 0)
        Me.pFiltro3.Name = "pFiltro3"
        Me.pFiltro3.Size = New System.Drawing.Size(171, 45)
        Me.pFiltro3.TabIndex = 13
        '
        'eFiltro3
        '
        Me.eFiltro3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eFiltro3.Location = New System.Drawing.Point(15, 19)
        Me.eFiltro3.Name = "eFiltro3"
        Me.eFiltro3.Size = New System.Drawing.Size(150, 21)
        Me.eFiltro3.TabIndex = 2
        '
        'lbFiltro3
        '
        Me.lbFiltro3.AutoSize = True
        Me.lbFiltro3.Location = New System.Drawing.Point(12, 3)
        Me.lbFiltro3.Name = "lbFiltro3"
        Me.lbFiltro3.Size = New System.Drawing.Size(83, 13)
        Me.lbFiltro3.TabIndex = 1
        Me.lbFiltro3.Text = "Etiqueta Filtro 3"
        '
        'pFiltro2
        '
        Me.pFiltro2.Controls.Add(Me.eFiltro2)
        Me.pFiltro2.Controls.Add(Me.lbFiltro2)
        Me.pFiltro2.Dock = System.Windows.Forms.DockStyle.Left
        Me.pFiltro2.Location = New System.Drawing.Point(171, 0)
        Me.pFiltro2.Name = "pFiltro2"
        Me.pFiltro2.Size = New System.Drawing.Size(171, 45)
        Me.pFiltro2.TabIndex = 12
        '
        'eFiltro2
        '
        Me.eFiltro2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eFiltro2.Location = New System.Drawing.Point(15, 19)
        Me.eFiltro2.Name = "eFiltro2"
        Me.eFiltro2.Size = New System.Drawing.Size(150, 21)
        Me.eFiltro2.TabIndex = 2
        '
        'lbFiltro2
        '
        Me.lbFiltro2.AutoSize = True
        Me.lbFiltro2.Location = New System.Drawing.Point(12, 3)
        Me.lbFiltro2.Name = "lbFiltro2"
        Me.lbFiltro2.Size = New System.Drawing.Size(83, 13)
        Me.lbFiltro2.TabIndex = 1
        Me.lbFiltro2.Text = "Etiqueta Filtro 2"
        '
        'pFiltro1
        '
        Me.pFiltro1.Controls.Add(Me.eFiltro1)
        Me.pFiltro1.Controls.Add(Me.lbFiltro1)
        Me.pFiltro1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pFiltro1.Location = New System.Drawing.Point(0, 0)
        Me.pFiltro1.Name = "pFiltro1"
        Me.pFiltro1.Size = New System.Drawing.Size(171, 45)
        Me.pFiltro1.TabIndex = 11
        '
        'eFiltro1
        '
        Me.eFiltro1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eFiltro1.Location = New System.Drawing.Point(15, 19)
        Me.eFiltro1.Name = "eFiltro1"
        Me.eFiltro1.Size = New System.Drawing.Size(150, 21)
        Me.eFiltro1.TabIndex = 2
        '
        'lbFiltro1
        '
        Me.lbFiltro1.AutoSize = True
        Me.lbFiltro1.Location = New System.Drawing.Point(12, 3)
        Me.lbFiltro1.Name = "lbFiltro1"
        Me.lbFiltro1.Size = New System.Drawing.Size(83, 13)
        Me.lbFiltro1.TabIndex = 1
        Me.lbFiltro1.Text = "Etiqueta Filtro 1"
        '
        'pCombo3
        '
        Me.pCombo3.Controls.Add(Me.cbComboDesc3)
        Me.pCombo3.Controls.Add(Me.cbCombo3)
        Me.pCombo3.Controls.Add(Me.lbCombo3)
        Me.pCombo3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pCombo3.Location = New System.Drawing.Point(0, 135)
        Me.pCombo3.Name = "pCombo3"
        Me.pCombo3.Size = New System.Drawing.Size(684, 49)
        Me.pCombo3.TabIndex = 10
        Me.pCombo3.Visible = False
        '
        'cbComboDesc3
        '
        Me.cbComboDesc3.Location = New System.Drawing.Point(215, 2)
        Me.cbComboDesc3.Name = "cbComboDesc3"
        Me.cbComboDesc3.Size = New System.Drawing.Size(466, 20)
        Me.cbComboDesc3.TabIndex = 3
        Me.cbComboDesc3.Visible = False
        '
        'cbCombo3
        '
        Me.cbCombo3.Location = New System.Drawing.Point(10, 24)
        Me.cbCombo3.Name = "cbCombo3"
        Me.cbCombo3.Size = New System.Drawing.Size(668, 20)
        Me.cbCombo3.TabIndex = 2
        '
        'lbCombo3
        '
        Me.lbCombo3.AutoSize = True
        Me.lbCombo3.Location = New System.Drawing.Point(12, 9)
        Me.lbCombo3.Name = "lbCombo3"
        Me.lbCombo3.Size = New System.Drawing.Size(90, 13)
        Me.lbCombo3.TabIndex = 0
        Me.lbCombo3.Text = "Etiqueta combo 3"
        '
        'pCombo2
        '
        Me.pCombo2.Controls.Add(Me.cbComboDesc2)
        Me.pCombo2.Controls.Add(Me.cbCombo2)
        Me.pCombo2.Controls.Add(Me.lbCombo2)
        Me.pCombo2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pCombo2.Location = New System.Drawing.Point(0, 86)
        Me.pCombo2.Name = "pCombo2"
        Me.pCombo2.Size = New System.Drawing.Size(684, 49)
        Me.pCombo2.TabIndex = 9
        Me.pCombo2.Visible = False
        '
        'cbComboDesc2
        '
        Me.cbComboDesc2.Location = New System.Drawing.Point(215, 3)
        Me.cbComboDesc2.Name = "cbComboDesc2"
        Me.cbComboDesc2.Size = New System.Drawing.Size(466, 20)
        Me.cbComboDesc2.TabIndex = 3
        Me.cbComboDesc2.Visible = False
        '
        'cbCombo2
        '
        Me.cbCombo2.Location = New System.Drawing.Point(10, 24)
        Me.cbCombo2.Name = "cbCombo2"
        Me.cbCombo2.Size = New System.Drawing.Size(668, 20)
        Me.cbCombo2.TabIndex = 2
        '
        'lbCombo2
        '
        Me.lbCombo2.AutoSize = True
        Me.lbCombo2.Location = New System.Drawing.Point(12, 9)
        Me.lbCombo2.Name = "lbCombo2"
        Me.lbCombo2.Size = New System.Drawing.Size(90, 13)
        Me.lbCombo2.TabIndex = 0
        Me.lbCombo2.Text = "Etiqueta combo 2"
        '
        'pCombo1
        '
        Me.pCombo1.Controls.Add(Me.cbComboDesc1)
        Me.pCombo1.Controls.Add(Me.cbCombo1)
        Me.pCombo1.Controls.Add(Me.lbCombo1)
        Me.pCombo1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pCombo1.Location = New System.Drawing.Point(0, 37)
        Me.pCombo1.Name = "pCombo1"
        Me.pCombo1.Size = New System.Drawing.Size(684, 49)
        Me.pCombo1.TabIndex = 8
        Me.pCombo1.Visible = False
        '
        'cbComboDesc1
        '
        Me.cbComboDesc1.Location = New System.Drawing.Point(215, 2)
        Me.cbComboDesc1.Name = "cbComboDesc1"
        Me.cbComboDesc1.Size = New System.Drawing.Size(466, 20)
        Me.cbComboDesc1.TabIndex = 3
        Me.cbComboDesc1.Visible = False
        '
        'cbCombo1
        '
        Me.cbCombo1.Location = New System.Drawing.Point(10, 24)
        Me.cbCombo1.Name = "cbCombo1"
        Me.cbCombo1.Size = New System.Drawing.Size(668, 20)
        Me.cbCombo1.TabIndex = 2
        '
        'lbCombo1
        '
        Me.lbCombo1.AutoSize = True
        Me.lbCombo1.Location = New System.Drawing.Point(12, 9)
        Me.lbCombo1.Name = "lbCombo1"
        Me.lbCombo1.Size = New System.Drawing.Size(90, 13)
        Me.lbCombo1.TabIndex = 0
        Me.lbCombo1.Text = "Etiqueta combo 1"
        '
        'pFechas
        '
        Me.pFechas.Controls.Add(Me.cbFechas)
        Me.pFechas.Controls.Add(Me.FechaF)
        Me.pFechas.Controls.Add(Me.Label2)
        Me.pFechas.Controls.Add(Me.FechaI)
        Me.pFechas.Controls.Add(Me.Label1)
        Me.pFechas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pFechas.Location = New System.Drawing.Point(0, 0)
        Me.pFechas.Name = "pFechas"
        Me.pFechas.Size = New System.Drawing.Size(684, 37)
        Me.pFechas.TabIndex = 7
        Me.pFechas.Visible = False
        '
        'cbFechas
        '
        Me.cbFechas.AutoSize = True
        Me.cbFechas.Checked = True
        Me.cbFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFechas.Location = New System.Drawing.Point(15, 14)
        Me.cbFechas.Name = "cbFechas"
        Me.cbFechas.Size = New System.Drawing.Size(110, 17)
        Me.cbFechas.TabIndex = 4
        Me.cbFechas.Text = "Filtrar por Fechas"
        Me.cbFechas.UseVisualStyleBackColor = True
        '
        'FechaF
        '
        Me.FechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaF.Location = New System.Drawing.Point(528, 6)
        Me.FechaF.Name = "FechaF"
        Me.FechaF.Size = New System.Drawing.Size(110, 21)
        Me.FechaF.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(449, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Final :"
        '
        'FechaI
        '
        Me.FechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaI.Location = New System.Drawing.Point(314, 7)
        Me.FechaI.Name = "FechaI"
        Me.FechaI.Size = New System.Drawing.Size(110, 21)
        Me.FechaI.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicial :"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = Artaban.CalidadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReportesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 560)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pReportes)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "ReportesForm"
        Me.Text = "Reporteador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pReportes.ResumeLayout(False)
        Me.pReportes.PerformLayout()
        CType(Me.cbReportes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTop.ResumeLayout(False)
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pFiltros.ResumeLayout(False)
        Me.pFiltro4.ResumeLayout(False)
        Me.pFiltro4.PerformLayout()
        Me.pFiltro3.ResumeLayout(False)
        Me.pFiltro3.PerformLayout()
        Me.pFiltro2.ResumeLayout(False)
        Me.pFiltro2.PerformLayout()
        Me.pFiltro1.ResumeLayout(False)
        Me.pFiltro1.PerformLayout()
        Me.pCombo3.ResumeLayout(False)
        Me.pCombo3.PerformLayout()
        CType(Me.cbComboDesc3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCombo3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCombo2.ResumeLayout(False)
        Me.pCombo2.PerformLayout()
        CType(Me.cbComboDesc2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCombo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCombo1.ResumeLayout(False)
        Me.pCombo1.PerformLayout()
        CType(Me.cbComboDesc1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCombo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pFechas.ResumeLayout(False)
        Me.pFechas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pReportes As System.Windows.Forms.Panel
    Friend WithEvents cbReportes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents pFiltros As System.Windows.Forms.Panel
    Friend WithEvents pFiltro4 As System.Windows.Forms.Panel
    Friend WithEvents eFiltro4 As System.Windows.Forms.TextBox
    Friend WithEvents lbFiltro4 As System.Windows.Forms.Label
    Friend WithEvents pFiltro3 As System.Windows.Forms.Panel
    Friend WithEvents eFiltro3 As System.Windows.Forms.TextBox
    Friend WithEvents lbFiltro3 As System.Windows.Forms.Label
    Friend WithEvents pFiltro2 As System.Windows.Forms.Panel
    Friend WithEvents eFiltro2 As System.Windows.Forms.TextBox
    Friend WithEvents lbFiltro2 As System.Windows.Forms.Label
    Friend WithEvents pFiltro1 As System.Windows.Forms.Panel
    Friend WithEvents eFiltro1 As System.Windows.Forms.TextBox
    Friend WithEvents lbFiltro1 As System.Windows.Forms.Label
    Friend WithEvents pCombo3 As System.Windows.Forms.Panel
    Friend WithEvents cbComboDesc3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbCombo3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbCombo3 As System.Windows.Forms.Label
    Friend WithEvents pCombo2 As System.Windows.Forms.Panel
    Friend WithEvents cbComboDesc2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbCombo2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbCombo2 As System.Windows.Forms.Label
    Friend WithEvents pCombo1 As System.Windows.Forms.Panel
    Friend WithEvents cbComboDesc1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbCombo1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbCombo1 As System.Windows.Forms.Label
    Friend WithEvents pFechas As System.Windows.Forms.Panel
    Friend WithEvents cbFechas As System.Windows.Forms.CheckBox
    Friend WithEvents FechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TableAdapterManager1 As Artaban.CalidadDataSetTableAdapters.TableAdapterManager
End Class
