<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProEmbarquesFrm
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProEmbarquesFrm))
        Me.pTop = New System.Windows.Forms.Panel()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cb_cliente = New System.Windows.Forms.ComboBox()
        Me.txtPedido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.FechaEt = New System.Windows.Forms.DateTimePicker()
        Me.eSello = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.eEntrega = New DevExpress.XtraEditors.TextEdit()
        Me.eChofer = New DevExpress.XtraEditors.TextEdit()
        Me.ePlacas = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.eNoEco = New DevExpress.XtraEditors.TextEdit()
        Me.eCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTipoEnvio = New System.Windows.Forms.ComboBox()
        Me.Origen = New DevExpress.XtraEditors.LabelControl()
        Me.cbJaula = New System.Windows.Forms.ComboBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cantImpres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.idRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ingreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Revision1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Revision2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Revision3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoSeries = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bEtiquetas = New DevExpress.XtraEditors.SimpleButton()
        Me.bRevision = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop.SuspendLayout()
        CType(Me.txtPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSello.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChofer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePlacas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eNoEco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pExit.SuspendLayout()
        Me.pLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.LabelControl9)
        Me.pTop.Controls.Add(Me.cb_cliente)
        Me.pTop.Controls.Add(Me.txtPedido)
        Me.pTop.Controls.Add(Me.LabelControl8)
        Me.pTop.Controls.Add(Me.LabelControl7)
        Me.pTop.Controls.Add(Me.FechaEt)
        Me.pTop.Controls.Add(Me.eSello)
        Me.pTop.Controls.Add(Me.LabelControl6)
        Me.pTop.Controls.Add(Me.eEntrega)
        Me.pTop.Controls.Add(Me.eChofer)
        Me.pTop.Controls.Add(Me.ePlacas)
        Me.pTop.Controls.Add(Me.LabelControl3)
        Me.pTop.Controls.Add(Me.eNoEco)
        Me.pTop.Controls.Add(Me.eCliente)
        Me.pTop.Controls.Add(Me.LabelControl11)
        Me.pTop.Controls.Add(Me.cbTipoEnvio)
        Me.pTop.Controls.Add(Me.Origen)
        Me.pTop.Controls.Add(Me.cbJaula)
        Me.pTop.Controls.Add(Me.LabelControl5)
        Me.pTop.Controls.Add(Me.LabelControl4)
        Me.pTop.Controls.Add(Me.LabelControl2)
        Me.pTop.Controls.Add(Me.LabelControl1)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(1153, 114)
        Me.pTop.TabIndex = 7
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(717, 60)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl9.TabIndex = 84
        Me.LabelControl9.Text = "Cliente:"
        '
        'cb_cliente
        '
        Me.cb_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cliente.FormattingEnabled = True
        Me.cb_cliente.Items.AddRange(New Object() {"Liverpool"})
        Me.cb_cliente.Location = New System.Drawing.Point(771, 57)
        Me.cb_cliente.Name = "cb_cliente"
        Me.cb_cliente.Size = New System.Drawing.Size(195, 21)
        Me.cb_cliente.TabIndex = 83
        '
        'txtPedido
        '
        Me.txtPedido.Location = New System.Drawing.Point(771, 31)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPedido.Properties.MaxLength = 500
        Me.txtPedido.Size = New System.Drawing.Size(195, 20)
        Me.txtPedido.TabIndex = 82
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(717, 34)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl8.TabIndex = 81
        Me.LabelControl8.Text = "Pedido:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.LabelControl7.Location = New System.Drawing.Point(707, 8)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(197, 13)
        Me.LabelControl7.TabIndex = 80
        Me.LabelControl7.Text = "FECHA PARA IMPRESION DE ETIQUETAS"
        '
        'FechaEt
        '
        Me.FechaEt.CustomFormat = "dd/MMM/yyyy"
        Me.FechaEt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaEt.Location = New System.Drawing.Point(921, 5)
        Me.FechaEt.Name = "FechaEt"
        Me.FechaEt.Size = New System.Drawing.Size(102, 21)
        Me.FechaEt.TabIndex = 79
        '
        'eSello
        '
        Me.eSello.Location = New System.Drawing.Point(570, 8)
        Me.eSello.Name = "eSello"
        Me.eSello.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eSello.Properties.MaxLength = 50
        Me.eSello.Size = New System.Drawing.Size(99, 20)
        Me.eSello.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(518, 11)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 39
        Me.LabelControl6.Text = "No. Sello:"
        '
        'eEntrega
        '
        Me.eEntrega.Location = New System.Drawing.Point(417, 62)
        Me.eEntrega.Name = "eEntrega"
        Me.eEntrega.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eEntrega.Properties.MaxLength = 500
        Me.eEntrega.Size = New System.Drawing.Size(252, 20)
        Me.eEntrega.TabIndex = 8
        '
        'eChofer
        '
        Me.eChofer.Location = New System.Drawing.Point(55, 62)
        Me.eChofer.Name = "eChofer"
        Me.eChofer.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eChofer.Properties.MaxLength = 250
        Me.eChofer.Size = New System.Drawing.Size(261, 20)
        Me.eChofer.TabIndex = 7
        '
        'ePlacas
        '
        Me.ePlacas.Location = New System.Drawing.Point(558, 35)
        Me.ePlacas.Name = "ePlacas"
        Me.ePlacas.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ePlacas.Properties.MaxLength = 50
        Me.ePlacas.Size = New System.Drawing.Size(111, 20)
        Me.ePlacas.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(518, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Placas:"
        '
        'eNoEco
        '
        Me.eNoEco.Location = New System.Drawing.Point(401, 35)
        Me.eNoEco.Name = "eNoEco"
        Me.eNoEco.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eNoEco.Properties.MaxLength = 50
        Me.eNoEco.Size = New System.Drawing.Size(111, 20)
        Me.eNoEco.TabIndex = 5
        '
        'eCliente
        '
        Me.eCliente.Location = New System.Drawing.Point(57, 35)
        Me.eCliente.Name = "eCliente"
        Me.eCliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eCliente.Properties.MaxLength = 250
        Me.eCliente.Size = New System.Drawing.Size(261, 20)
        Me.eCliente.TabIndex = 4
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(14, 38)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl11.TabIndex = 32
        Me.LabelControl11.Text = "Cliente:"
        '
        'cbTipoEnvio
        '
        Me.cbTipoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoEnvio.FormattingEnabled = True
        Me.cbTipoEnvio.Items.AddRange(New Object() {"CLIENTE RECOGE", "TRANSPORTE EXTERNO", "TRANSPORTE INTERNO"})
        Me.cbTipoEnvio.Location = New System.Drawing.Point(271, 8)
        Me.cbTipoEnvio.Name = "cbTipoEnvio"
        Me.cbTipoEnvio.Size = New System.Drawing.Size(241, 21)
        Me.cbTipoEnvio.TabIndex = 2
        '
        'Origen
        '
        Me.Origen.Location = New System.Drawing.Point(14, 13)
        Me.Origen.Name = "Origen"
        Me.Origen.Size = New System.Drawing.Size(36, 13)
        Me.Origen.TabIndex = 30
        Me.Origen.Text = "Origen:"
        '
        'cbJaula
        '
        Me.cbJaula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJaula.FormattingEnabled = True
        Me.cbJaula.Items.AddRange(New Object() {"JAULA 01", "JAULA 02", "JAULA 03", "JAULA 04", "JAULA 05", "JAULA 06", "JAULA 07"})
        Me.cbJaula.Location = New System.Drawing.Point(60, 8)
        Me.cbJaula.Name = "cbJaula"
        Me.cbJaula.Size = New System.Drawing.Size(120, 21)
        Me.cbJaula.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(324, 65)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "Lugar de Entrega:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(324, 38)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "No. Económico:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Chofér:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(197, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Tipo de Envio:"
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 114)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(1153, 446)
        Me.pCenter.TabIndex = 8
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.gCatalogo.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(1153, 446)
        Me.gCatalogo.TabIndex = 0
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cantImpres, Me.idRevision, Me.SKU, Me.Descripcion, Me.Ingreso, Me.Revision1, Me.Revision2, Me.Revision3, Me.NoSeries})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'cantImpres
        '
        Me.cantImpres.Caption = "Cantidad_Impresion"
        Me.cantImpres.FieldName = "cant"
        Me.cantImpres.Name = "cantImpres"
        Me.cantImpres.Visible = True
        Me.cantImpres.VisibleIndex = 7
        Me.cantImpres.Width = 138
        '
        'idRevision
        '
        Me.idRevision.Caption = "idRevision"
        Me.idRevision.FieldName = "idRevision"
        Me.idRevision.Name = "idRevision"
        Me.idRevision.OptionsColumn.AllowEdit = False
        Me.idRevision.OptionsColumn.ReadOnly = True
        Me.idRevision.Width = 65
        '
        'SKU
        '
        Me.SKU.Caption = "SKU"
        Me.SKU.FieldName = "SKU"
        Me.SKU.Name = "SKU"
        Me.SKU.OptionsColumn.AllowEdit = False
        Me.SKU.OptionsColumn.ReadOnly = True
        Me.SKU.Visible = True
        Me.SKU.VisibleIndex = 0
        Me.SKU.Width = 68
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripcion"
        Me.Descripcion.FieldName = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.OptionsColumn.AllowEdit = False
        Me.Descripcion.OptionsColumn.ReadOnly = True
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 1
        Me.Descripcion.Width = 169
        '
        'Ingreso
        '
        Me.Ingreso.Caption = "Ingreso"
        Me.Ingreso.FieldName = "Ingreso"
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.OptionsColumn.AllowEdit = False
        Me.Ingreso.OptionsColumn.ReadOnly = True
        Me.Ingreso.Visible = True
        Me.Ingreso.VisibleIndex = 2
        Me.Ingreso.Width = 41
        '
        'Revision1
        '
        Me.Revision1.Caption = "Revision1"
        Me.Revision1.FieldName = "Revision1"
        Me.Revision1.Name = "Revision1"
        Me.Revision1.OptionsColumn.AllowEdit = False
        Me.Revision1.OptionsColumn.ReadOnly = True
        Me.Revision1.Visible = True
        Me.Revision1.VisibleIndex = 3
        Me.Revision1.Width = 44
        '
        'Revision2
        '
        Me.Revision2.Caption = "Revision2"
        Me.Revision2.FieldName = "Revision2"
        Me.Revision2.Name = "Revision2"
        Me.Revision2.OptionsColumn.AllowEdit = False
        Me.Revision2.OptionsColumn.ReadOnly = True
        Me.Revision2.Visible = True
        Me.Revision2.VisibleIndex = 4
        Me.Revision2.Width = 42
        '
        'Revision3
        '
        Me.Revision3.Caption = "Revision3"
        Me.Revision3.FieldName = "Revision3"
        Me.Revision3.Name = "Revision3"
        Me.Revision3.OptionsColumn.AllowEdit = False
        Me.Revision3.OptionsColumn.ReadOnly = True
        Me.Revision3.Visible = True
        Me.Revision3.VisibleIndex = 5
        Me.Revision3.Width = 44
        '
        'NoSeries
        '
        Me.NoSeries.Caption = "No. Series"
        Me.NoSeries.FieldName = "NoSeries"
        Me.NoSeries.Name = "NoSeries"
        Me.NoSeries.OptionsColumn.AllowEdit = False
        Me.NoSeries.OptionsColumn.ReadOnly = True
        Me.NoSeries.Visible = True
        Me.NoSeries.VisibleIndex = 6
        Me.NoSeries.Width = 120
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
        'bNuevo
        '
        Me.bNuevo.Image = CType(resources.GetObject("bNuevo.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(11, 120)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(140, 35)
        Me.bNuevo.TabIndex = 100
        Me.bNuevo.Text = "&Nuevo"
        '
        'bGuardar
        '
        Me.bGuardar.Enabled = False
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(11, 168)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(140, 35)
        Me.bGuardar.TabIndex = 101
        Me.bGuardar.Text = "&Generar Embarque"
        '
        'bIgnorar
        '
        Me.bIgnorar.Image = CType(resources.GetObject("bIgnorar.Image"), System.Drawing.Image)
        Me.bIgnorar.Location = New System.Drawing.Point(11, 260)
        Me.bIgnorar.Name = "bIgnorar"
        Me.bIgnorar.Size = New System.Drawing.Size(140, 35)
        Me.bIgnorar.TabIndex = 102
        Me.bIgnorar.Text = "&Ignorar"
        Me.bIgnorar.Visible = False
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Image = CType(resources.GetObject("bEliminar.Image"), System.Drawing.Image)
        Me.bEliminar.Location = New System.Drawing.Point(11, 311)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(140, 35)
        Me.bEliminar.TabIndex = 103
        Me.bEliminar.Text = "&Eliminar"
        Me.bEliminar.Visible = False
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bEtiquetas)
        Me.pLeft.Controls.Add(Me.bRevision)
        Me.pLeft.Controls.Add(Me.bEliminar)
        Me.pLeft.Controls.Add(Me.bIgnorar)
        Me.pLeft.Controls.Add(Me.bGuardar)
        Me.pLeft.Controls.Add(Me.bNuevo)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(1153, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 560)
        Me.pLeft.TabIndex = 6
        '
        'bEtiquetas
        '
        Me.bEtiquetas.Enabled = False
        Me.bEtiquetas.Image = CType(resources.GetObject("bEtiquetas.Image"), System.Drawing.Image)
        Me.bEtiquetas.Location = New System.Drawing.Point(11, 79)
        Me.bEtiquetas.Name = "bEtiquetas"
        Me.bEtiquetas.Size = New System.Drawing.Size(140, 35)
        Me.bEtiquetas.TabIndex = 105
        Me.bEtiquetas.Text = "&Imprimir Etiquetas"
        '
        'bRevision
        '
        Me.bRevision.Enabled = False
        Me.bRevision.Image = CType(resources.GetObject("bRevision.Image"), System.Drawing.Image)
        Me.bRevision.Location = New System.Drawing.Point(11, 216)
        Me.bRevision.Name = "bRevision"
        Me.bRevision.Size = New System.Drawing.Size(140, 35)
        Me.bRevision.TabIndex = 104
        Me.bRevision.Text = "&Imprimir Revisión"
        '
        'ProEmbarquesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "ProEmbarquesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generación de Embarques"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.txtPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eSello.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChofer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePlacas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eNoEco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pExit.ResumeLayout(False)
        Me.pLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Origen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbJaula As System.Windows.Forms.ComboBox
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bIgnorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents eEntrega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eChofer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePlacas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eNoEco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbTipoEnvio As System.Windows.Forms.ComboBox
    Friend WithEvents idRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SKU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ingreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Revision1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Revision2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Revision3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoSeries As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eSello As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bRevision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bEtiquetas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FechaEt As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cantImpres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_cliente As System.Windows.Forms.ComboBox
End Class
