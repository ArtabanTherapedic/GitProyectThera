<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanEmbarque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlanEmbarque))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.bPDF = New DevExpress.XtraEditors.SimpleButton()
        Me.bExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.eOV = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cbIDCliente = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbFechas = New System.Windows.Forms.CheckBox()
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.FechaI = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbDesc = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbCodigo = New DevExpress.XtraEditors.LookUpEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.OV1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Lin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Rel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoParte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IDCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Facturado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Parte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CodAdmin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FechaCita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FechaEmbarque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DomicilioEmbarque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoCita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HoraCita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Comentarios = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Estatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrecioU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbIDCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bLimpiar)
        Me.pLeft.Controls.Add(Me.bPDF)
        Me.pLeft.Controls.Add(Me.bExcel)
        Me.pLeft.Controls.Add(Me.bImprimir)
        Me.pLeft.Controls.Add(Me.bBuscar)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(722, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 560)
        Me.pLeft.TabIndex = 5
        '
        'bLimpiar
        '
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(11, 284)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(140, 35)
        Me.bLimpiar.TabIndex = 104
        Me.bLimpiar.Text = "&Limpiar"
        '
        'bPDF
        '
        Me.bPDF.Image = CType(resources.GetObject("bPDF.Image"), System.Drawing.Image)
        Me.bPDF.Location = New System.Drawing.Point(11, 202)
        Me.bPDF.Name = "bPDF"
        Me.bPDF.Size = New System.Drawing.Size(140, 35)
        Me.bPDF.TabIndex = 103
        Me.bPDF.Text = "&PDF"
        '
        'bExcel
        '
        Me.bExcel.Image = CType(resources.GetObject("bExcel.Image"), System.Drawing.Image)
        Me.bExcel.Location = New System.Drawing.Point(11, 243)
        Me.bExcel.Name = "bExcel"
        Me.bExcel.Size = New System.Drawing.Size(140, 35)
        Me.bExcel.TabIndex = 102
        Me.bExcel.Text = "&Excel"
        '
        'bImprimir
        '
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(11, 161)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(140, 35)
        Me.bImprimir.TabIndex = 101
        Me.bImprimir.Text = "&Imprimir"
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(11, 120)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(140, 35)
        Me.bBuscar.TabIndex = 100
        Me.bBuscar.Text = "&Buscar"
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
        'pTop
        '
        Me.pTop.Controls.Add(Me.eOV)
        Me.pTop.Controls.Add(Me.LabelControl5)
        Me.pTop.Controls.Add(Me.cbCliente)
        Me.pTop.Controls.Add(Me.LabelControl4)
        Me.pTop.Controls.Add(Me.cbIDCliente)
        Me.pTop.Controls.Add(Me.cbFechas)
        Me.pTop.Controls.Add(Me.FechaFinal)
        Me.pTop.Controls.Add(Me.FechaI)
        Me.pTop.Controls.Add(Me.LabelControl3)
        Me.pTop.Controls.Add(Me.LabelControl1)
        Me.pTop.Controls.Add(Me.cbDesc)
        Me.pTop.Controls.Add(Me.LabelControl2)
        Me.pTop.Controls.Add(Me.cbCodigo)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(722, 114)
        Me.pTop.TabIndex = 6
        '
        'eOV
        '
        Me.eOV.Location = New System.Drawing.Point(102, 83)
        Me.eOV.Name = "eOV"
        Me.eOV.Size = New System.Drawing.Size(100, 21)
        Me.eOV.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(20, 87)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl5.TabIndex = 26
        Me.LabelControl5.Text = "Orden de Venta:"
        '
        'cbCliente
        '
        Me.cbCliente.Location = New System.Drawing.Point(208, 57)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "IDCliente", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cliente", "Cliente")})
        Me.cbCliente.Properties.NullText = ""
        Me.cbCliente.Size = New System.Drawing.Size(441, 20)
        Me.cbCliente.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(20, 60)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "Cliente:"
        '
        'cbIDCliente
        '
        Me.cbIDCliente.Location = New System.Drawing.Point(73, 57)
        Me.cbIDCliente.Name = "cbIDCliente"
        Me.cbIDCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbIDCliente.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "IDCliente"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDCliente", "IDCliente", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cbIDCliente.Properties.NullText = ""
        Me.cbIDCliente.Size = New System.Drawing.Size(129, 20)
        Me.cbIDCliente.TabIndex = 6
        '
        'cbFechas
        '
        Me.cbFechas.AutoSize = True
        Me.cbFechas.Checked = True
        Me.cbFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFechas.Location = New System.Drawing.Point(392, 12)
        Me.cbFechas.Name = "cbFechas"
        Me.cbFechas.Size = New System.Drawing.Size(179, 17)
        Me.cbFechas.TabIndex = 3
        Me.cbFechas.Text = "Filtrado por Fecha de Embarque"
        Me.cbFechas.UseVisualStyleBackColor = True
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinal.Location = New System.Drawing.Point(275, 8)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(110, 21)
        Me.FechaFinal.TabIndex = 2
        '
        'FechaI
        '
        Me.FechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaI.Location = New System.Drawing.Point(92, 8)
        Me.FechaI.Name = "FechaI"
        Me.FechaI.Size = New System.Drawing.Size(110, 21)
        Me.FechaI.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(208, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "Fecha Final: "
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Fecha Inicial: "
        '
        'cbDesc
        '
        Me.cbDesc.Location = New System.Drawing.Point(208, 31)
        Me.cbDesc.Name = "cbDesc"
        Me.cbDesc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDesc.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SKU", "SKU", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.cbDesc.Properties.NullText = ""
        Me.cbDesc.Size = New System.Drawing.Size(441, 20)
        Me.cbDesc.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 34)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Producto:"
        '
        'cbCodigo
        '
        Me.cbCodigo.Location = New System.Drawing.Point(73, 31)
        Me.cbCodigo.Name = "cbCodigo"
        Me.cbCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCodigo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SKU", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cbCodigo.Properties.NullText = ""
        Me.cbCodigo.Size = New System.Drawing.Size(129, 20)
        Me.cbCodigo.TabIndex = 4
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 114)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(722, 446)
        Me.pCenter.TabIndex = 7
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(722, 446)
        Me.gCatalogo.TabIndex = 0
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.OV1, Me.Lin, Me.Rel, Me.NoParte, Me.Cantidad, Me.OV, Me.IDCliente, Me.Cliente, Me.OC, Me.Facturado, Me.Parte, Me.CodAdmin, Me.FechaCita, Me.FechaEmbarque, Me.DomicilioEmbarque, Me.NoCita, Me.HoraCita, Me.Comentarios, Me.Estatus, Me.PrecioU})
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'OV1
        '
        Me.OV1.Caption = "OV"
        Me.OV1.FieldName = "OV"
        Me.OV1.Name = "OV1"
        Me.OV1.OptionsColumn.AllowEdit = False
        Me.OV1.OptionsColumn.ReadOnly = True
        Me.OV1.Visible = True
        Me.OV1.VisibleIndex = 0
        Me.OV1.Width = 40
        '
        'Lin
        '
        Me.Lin.Caption = "Lin"
        Me.Lin.FieldName = "Lin"
        Me.Lin.Name = "Lin"
        Me.Lin.OptionsColumn.AllowEdit = False
        Me.Lin.OptionsColumn.ReadOnly = True
        Me.Lin.Visible = True
        Me.Lin.VisibleIndex = 1
        Me.Lin.Width = 30
        '
        'Rel
        '
        Me.Rel.Caption = "Rel"
        Me.Rel.FieldName = "Rel"
        Me.Rel.Name = "Rel"
        Me.Rel.OptionsColumn.AllowEdit = False
        Me.Rel.OptionsColumn.ReadOnly = True
        Me.Rel.Visible = True
        Me.Rel.VisibleIndex = 2
        Me.Rel.Width = 30
        '
        'NoParte
        '
        Me.NoParte.Caption = "No. Parte"
        Me.NoParte.FieldName = "NoParte"
        Me.NoParte.MinWidth = 100
        Me.NoParte.Name = "NoParte"
        Me.NoParte.OptionsColumn.AllowEdit = False
        Me.NoParte.OptionsColumn.ReadOnly = True
        Me.NoParte.Visible = True
        Me.NoParte.VisibleIndex = 3
        Me.NoParte.Width = 100
        '
        'Cantidad
        '
        Me.Cantidad.Caption = "Cantidad"
        Me.Cantidad.DisplayFormat.FormatString = "d"
        Me.Cantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.Cantidad.FieldName = "Cantidad"
        Me.Cantidad.MinWidth = 40
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.OptionsColumn.AllowEdit = False
        Me.Cantidad.OptionsColumn.ReadOnly = True
        Me.Cantidad.Visible = True
        Me.Cantidad.VisibleIndex = 4
        Me.Cantidad.Width = 80
        '
        'OV
        '
        Me.OV.Caption = "OV/Lin/Lib"
        Me.OV.FieldName = "OV/Lin/Lib"
        Me.OV.MinWidth = 30
        Me.OV.Name = "OV"
        Me.OV.OptionsColumn.AllowEdit = False
        Me.OV.OptionsColumn.ReadOnly = True
        Me.OV.Width = 60
        '
        'IDCliente
        '
        Me.IDCliente.Caption = "ID Cliente"
        Me.IDCliente.FieldName = "IDCliente"
        Me.IDCliente.MinWidth = 30
        Me.IDCliente.Name = "IDCliente"
        Me.IDCliente.OptionsColumn.AllowEdit = False
        Me.IDCliente.OptionsColumn.ReadOnly = True
        Me.IDCliente.Visible = True
        Me.IDCliente.VisibleIndex = 6
        Me.IDCliente.Width = 60
        '
        'Cliente
        '
        Me.Cliente.Caption = "Cliente"
        Me.Cliente.FieldName = "Cliente"
        Me.Cliente.MinWidth = 150
        Me.Cliente.Name = "Cliente"
        Me.Cliente.OptionsColumn.AllowEdit = False
        Me.Cliente.OptionsColumn.ReadOnly = True
        Me.Cliente.Visible = True
        Me.Cliente.VisibleIndex = 7
        Me.Cliente.Width = 291
        '
        'OC
        '
        Me.OC.Caption = "OC"
        Me.OC.FieldName = "OC"
        Me.OC.MinWidth = 50
        Me.OC.Name = "OC"
        Me.OC.OptionsColumn.AllowEdit = False
        Me.OC.OptionsColumn.ReadOnly = True
        Me.OC.Visible = True
        Me.OC.VisibleIndex = 8
        Me.OC.Width = 100
        '
        'Facturado
        '
        Me.Facturado.Caption = "Facturado"
        Me.Facturado.DisplayFormat.FormatString = "d"
        Me.Facturado.FieldName = "Facturado"
        Me.Facturado.MinWidth = 40
        Me.Facturado.Name = "Facturado"
        Me.Facturado.OptionsColumn.AllowEdit = False
        Me.Facturado.OptionsColumn.ReadOnly = True
        Me.Facturado.Visible = True
        Me.Facturado.VisibleIndex = 5
        Me.Facturado.Width = 80
        '
        'Parte
        '
        Me.Parte.Caption = "Parte"
        Me.Parte.FieldName = "Parte"
        Me.Parte.MinWidth = 150
        Me.Parte.Name = "Parte"
        Me.Parte.OptionsColumn.AllowEdit = False
        Me.Parte.OptionsColumn.ReadOnly = True
        Me.Parte.Visible = True
        Me.Parte.VisibleIndex = 9
        Me.Parte.Width = 300
        '
        'CodAdmin
        '
        Me.CodAdmin.Caption = "CodAdmin"
        Me.CodAdmin.FieldName = "CodAdmin"
        Me.CodAdmin.Name = "CodAdmin"
        Me.CodAdmin.OptionsColumn.AllowEdit = False
        Me.CodAdmin.OptionsColumn.ReadOnly = True
        Me.CodAdmin.Visible = True
        Me.CodAdmin.VisibleIndex = 10
        '
        'FechaCita
        '
        Me.FechaCita.Caption = "Fecha Cita"
        Me.FechaCita.FieldName = "FechaCita"
        Me.FechaCita.MinWidth = 40
        Me.FechaCita.Name = "FechaCita"
        Me.FechaCita.OptionsColumn.AllowEdit = False
        Me.FechaCita.OptionsColumn.ReadOnly = True
        Me.FechaCita.Visible = True
        Me.FechaCita.VisibleIndex = 11
        Me.FechaCita.Width = 80
        '
        'FechaEmbarque
        '
        Me.FechaEmbarque.Caption = "Fecha Embarque"
        Me.FechaEmbarque.FieldName = "FechaEmbarque"
        Me.FechaEmbarque.MinWidth = 40
        Me.FechaEmbarque.Name = "FechaEmbarque"
        Me.FechaEmbarque.OptionsColumn.AllowEdit = False
        Me.FechaEmbarque.OptionsColumn.ReadOnly = True
        Me.FechaEmbarque.Visible = True
        Me.FechaEmbarque.VisibleIndex = 12
        Me.FechaEmbarque.Width = 80
        '
        'DomicilioEmbarque
        '
        Me.DomicilioEmbarque.Caption = "Domicilio Embarque"
        Me.DomicilioEmbarque.FieldName = "DomicilioEmbarque"
        Me.DomicilioEmbarque.MinWidth = 200
        Me.DomicilioEmbarque.Name = "DomicilioEmbarque"
        Me.DomicilioEmbarque.OptionsColumn.AllowEdit = False
        Me.DomicilioEmbarque.OptionsColumn.ReadOnly = True
        Me.DomicilioEmbarque.Width = 400
        '
        'NoCita
        '
        Me.NoCita.Caption = "No. Cita"
        Me.NoCita.FieldName = "NoCita"
        Me.NoCita.MinWidth = 100
        Me.NoCita.Name = "NoCita"
        Me.NoCita.OptionsColumn.AllowEdit = False
        Me.NoCita.OptionsColumn.ReadOnly = True
        Me.NoCita.Visible = True
        Me.NoCita.VisibleIndex = 13
        Me.NoCita.Width = 150
        '
        'HoraCita
        '
        Me.HoraCita.Caption = "Hora Cita"
        Me.HoraCita.FieldName = "HoraCita"
        Me.HoraCita.MinWidth = 80
        Me.HoraCita.Name = "HoraCita"
        Me.HoraCita.OptionsColumn.AllowEdit = False
        Me.HoraCita.OptionsColumn.ReadOnly = True
        Me.HoraCita.Visible = True
        Me.HoraCita.VisibleIndex = 14
        Me.HoraCita.Width = 80
        '
        'Comentarios
        '
        Me.Comentarios.Caption = "Comentarios"
        Me.Comentarios.FieldName = "Comentarios"
        Me.Comentarios.MinWidth = 250
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.OptionsColumn.AllowEdit = False
        Me.Comentarios.OptionsColumn.ReadOnly = True
        Me.Comentarios.Visible = True
        Me.Comentarios.VisibleIndex = 15
        Me.Comentarios.Width = 250
        '
        'Estatus
        '
        Me.Estatus.Caption = "Estatus"
        Me.Estatus.FieldName = "Estatus"
        Me.Estatus.MinWidth = 50
        Me.Estatus.Name = "Estatus"
        Me.Estatus.OptionsColumn.AllowEdit = False
        Me.Estatus.OptionsColumn.ReadOnly = True
        Me.Estatus.Visible = True
        Me.Estatus.VisibleIndex = 16
        Me.Estatus.Width = 50
        '
        'PrecioU
        '
        Me.PrecioU.Caption = "Precio Unitario"
        Me.PrecioU.FieldName = "PrecioUnitario"
        Me.PrecioU.MinWidth = 50
        Me.PrecioU.Name = "PrecioU"
        Me.PrecioU.OptionsColumn.AllowEdit = False
        Me.PrecioU.OptionsColumn.ReadOnly = True
        Me.PrecioU.Visible = True
        Me.PrecioU.VisibleIndex = 17
        '
        'PlanEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "PlanEmbarque"
        Me.Text = "Plan de Embarques"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbIDCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bPDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cbDesc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbCodigo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbIDCliente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbFechas As System.Windows.Forms.CheckBox
    Friend WithEvents eOV As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IDCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Facturado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoParte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Parte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FechaCita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FechaEmbarque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DomicilioEmbarque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoCita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Comentarios As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HoraCita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CodAdmin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OV1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Lin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Estatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrecioU As DevExpress.XtraGrid.Columns.GridColumn
End Class
