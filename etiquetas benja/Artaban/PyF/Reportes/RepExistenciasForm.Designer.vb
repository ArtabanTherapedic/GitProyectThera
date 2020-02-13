<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepExistenciasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepExistenciasForm))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.eLocacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.eAlmacen = New DevExpress.XtraEditors.TextEdit()
        Me.cbArticulo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.cbEstatus = New System.Windows.Forms.ComboBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cbMedida = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cbConfort = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cbConstruccion = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cbLinea = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbCategoria = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbModelo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cbMarca = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbTipo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eDesc = New DevExpress.XtraEditors.TextEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Almacen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Locacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoSeries = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.eLocacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eAlmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMedida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbConfort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbConstruccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bImprimir)
        Me.pLeft.Controls.Add(Me.bEliminar)
        Me.pLeft.Controls.Add(Me.bExportar)
        Me.pLeft.Controls.Add(Me.bBuscar)
        Me.pLeft.Controls.Add(Me.bLimpiar)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(785, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 595)
        Me.pLeft.TabIndex = 7
        '
        'bImprimir
        '
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(11, 215)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(140, 35)
        Me.bImprimir.TabIndex = 104
        Me.bImprimir.Text = "&Imprimir"
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
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(11, 265)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(140, 35)
        Me.bExportar.TabIndex = 102
        Me.bExportar.Text = "&Exportar a Excel"
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(11, 120)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(140, 35)
        Me.bBuscar.TabIndex = 99
        Me.bBuscar.Text = "&Buscar"
        '
        'bLimpiar
        '
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(11, 168)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(140, 35)
        Me.bLimpiar.TabIndex = 100
        Me.bLimpiar.Text = "&Limpiar"
        '
        'pExit
        '
        Me.pExit.Controls.Add(Me.bSalir)
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pExit.Location = New System.Drawing.Point(0, 385)
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
        Me.pTop.Controls.Add(Me.LabelControl12)
        Me.pTop.Controls.Add(Me.eLocacion)
        Me.pTop.Controls.Add(Me.LabelControl3)
        Me.pTop.Controls.Add(Me.eAlmacen)
        Me.pTop.Controls.Add(Me.cbArticulo)
        Me.pTop.Controls.Add(Me.LabelControl11)
        Me.pTop.Controls.Add(Me.cbEstatus)
        Me.pTop.Controls.Add(Me.LabelControl7)
        Me.pTop.Controls.Add(Me.cbMedida)
        Me.pTop.Controls.Add(Me.LabelControl8)
        Me.pTop.Controls.Add(Me.cbConfort)
        Me.pTop.Controls.Add(Me.LabelControl9)
        Me.pTop.Controls.Add(Me.cbConstruccion)
        Me.pTop.Controls.Add(Me.LabelControl10)
        Me.pTop.Controls.Add(Me.cbLinea)
        Me.pTop.Controls.Add(Me.LabelControl6)
        Me.pTop.Controls.Add(Me.cbCategoria)
        Me.pTop.Controls.Add(Me.LabelControl5)
        Me.pTop.Controls.Add(Me.cbModelo)
        Me.pTop.Controls.Add(Me.LabelControl4)
        Me.pTop.Controls.Add(Me.cbMarca)
        Me.pTop.Controls.Add(Me.LabelControl2)
        Me.pTop.Controls.Add(Me.cbTipo)
        Me.pTop.Controls.Add(Me.LabelControl1)
        Me.pTop.Controls.Add(Me.eDesc)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(785, 114)
        Me.pTop.TabIndex = 8
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(219, 94)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl12.TabIndex = 56
        Me.LabelControl12.Text = "Locación:"
        '
        'eLocacion
        '
        Me.eLocacion.Location = New System.Drawing.Point(270, 91)
        Me.eLocacion.Name = "eLocacion"
        Me.eLocacion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eLocacion.Size = New System.Drawing.Size(120, 20)
        Me.eLocacion.TabIndex = 55
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(4, 94)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 54
        Me.LabelControl3.Text = "Almacén:"
        '
        'eAlmacen
        '
        Me.eAlmacen.Location = New System.Drawing.Point(54, 91)
        Me.eAlmacen.Name = "eAlmacen"
        Me.eAlmacen.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eAlmacen.Size = New System.Drawing.Size(120, 20)
        Me.eAlmacen.TabIndex = 53
        '
        'cbArticulo
        '
        Me.cbArticulo.Location = New System.Drawing.Point(53, 9)
        Me.cbArticulo.Name = "cbArticulo"
        Me.cbArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbArticulo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SKU", 80, "SKU"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 400, "Descripcion")})
        Me.cbArticulo.Properties.NullText = ""
        Me.cbArticulo.Size = New System.Drawing.Size(120, 20)
        Me.cbArticulo.TabIndex = 31
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(614, 13)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl11.TabIndex = 52
        Me.LabelControl11.Text = "Estatus:"
        '
        'cbEstatus
        '
        Me.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstatus.FormattingEnabled = True
        Me.cbEstatus.Items.AddRange(New Object() {"ACTIVO", "INACTIVO", "OBSOLETO"})
        Me.cbEstatus.Location = New System.Drawing.Point(660, 8)
        Me.cbEstatus.Name = "cbEstatus"
        Me.cbEstatus.Size = New System.Drawing.Size(120, 21)
        Me.cbEstatus.TabIndex = 34
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(616, 68)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 51
        Me.LabelControl7.Text = "Medida:"
        '
        'cbMedida
        '
        Me.cbMedida.Location = New System.Drawing.Point(660, 65)
        Me.cbMedida.Name = "cbMedida"
        Me.cbMedida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMedida.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idMedida", "idMedida", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Medida", "Medida"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MedidaDesc", "Medidas")})
        Me.cbMedida.Properties.NullText = ""
        Me.cbMedida.Size = New System.Drawing.Size(120, 20)
        Me.cbMedida.TabIndex = 50
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(414, 68)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl8.TabIndex = 49
        Me.LabelControl8.Text = "Confort:"
        '
        'cbConfort
        '
        Me.cbConfort.Location = New System.Drawing.Point(461, 65)
        Me.cbConfort.Name = "cbConfort"
        Me.cbConfort.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbConfort.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idConfort", "idConfort", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConfortDesc", "Confort's")})
        Me.cbConfort.Properties.NullText = ""
        Me.cbConfort.Size = New System.Drawing.Size(120, 20)
        Me.cbConfort.TabIndex = 48
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(198, 68)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl9.TabIndex = 47
        Me.LabelControl9.Text = "Construcción:"
        '
        'cbConstruccion
        '
        Me.cbConstruccion.Location = New System.Drawing.Point(270, 65)
        Me.cbConstruccion.Name = "cbConstruccion"
        Me.cbConstruccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbConstruccion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idConstruccion", "idConstruccion", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConstruccionDesc", "Construcciones"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConstruccionObs", "Observaciones")})
        Me.cbConstruccion.Properties.NullText = ""
        Me.cbConstruccion.Size = New System.Drawing.Size(120, 20)
        Me.cbConstruccion.TabIndex = 46
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(19, 68)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl10.TabIndex = 45
        Me.LabelControl10.Text = "Línea:"
        '
        'cbLinea
        '
        Me.cbLinea.Location = New System.Drawing.Point(54, 65)
        Me.cbLinea.Name = "cbLinea"
        Me.cbLinea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLinea.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idLinea", "idLinea", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LineaDesc", "Lineas")})
        Me.cbLinea.Properties.NullText = ""
        Me.cbLinea.Size = New System.Drawing.Size(120, 20)
        Me.cbLinea.TabIndex = 44
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(603, 39)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl6.TabIndex = 43
        Me.LabelControl6.Text = "Categoria:"
        '
        'cbCategoria
        '
        Me.cbCategoria.Location = New System.Drawing.Point(660, 36)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCategoria.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idCategoria", "idCategoria", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoriaDesc", "Categorias")})
        Me.cbCategoria.Properties.NullText = ""
        Me.cbCategoria.Size = New System.Drawing.Size(120, 20)
        Me.cbCategoria.TabIndex = 42
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(417, 39)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl5.TabIndex = 41
        Me.LabelControl5.Text = "Modelo:"
        '
        'cbModelo
        '
        Me.cbModelo.Location = New System.Drawing.Point(461, 36)
        Me.cbModelo.Name = "cbModelo"
        Me.cbModelo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbModelo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idModelo", "idModelo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModeloDesc", "Modelos")})
        Me.cbModelo.Properties.NullText = ""
        Me.cbModelo.Size = New System.Drawing.Size(120, 20)
        Me.cbModelo.TabIndex = 40
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(231, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 39
        Me.LabelControl4.Text = "Marca:"
        '
        'cbMarca
        '
        Me.cbMarca.Location = New System.Drawing.Point(270, 36)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbMarca.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idMarca", "idMarca", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MarcaDesc", "Marcas")})
        Me.cbMarca.Properties.NullText = ""
        Me.cbMarca.Size = New System.Drawing.Size(120, 20)
        Me.cbMarca.TabIndex = 38
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl2.TabIndex = 37
        Me.LabelControl2.Text = "Tipo:"
        '
        'cbTipo
        '
        Me.cbTipo.Location = New System.Drawing.Point(53, 36)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTipo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idTipo", "idTipo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipoDesc", "Tipos")})
        Me.cbTipo.Properties.NullText = ""
        Me.cbTipo.Size = New System.Drawing.Size(120, 20)
        Me.cbTipo.TabIndex = 36
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 33
        Me.LabelControl1.Text = "SKU:"
        '
        'eDesc
        '
        Me.eDesc.Location = New System.Drawing.Point(179, 9)
        Me.eDesc.Name = "eDesc"
        Me.eDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eDesc.Properties.ReadOnly = True
        Me.eDesc.Size = New System.Drawing.Size(402, 20)
        Me.eDesc.TabIndex = 32
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 114)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(785, 481)
        Me.pCenter.TabIndex = 9
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(785, 481)
        Me.gCatalogo.TabIndex = 0
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SKU, Me.Descripcion, Me.Almacen, Me.Locacion, Me.Cantidad, Me.NoSeries})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", Nothing, "", "Cantidad Total:")})
        Me.GridView1.Name = "GridView1"
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
        '
        'Almacen
        '
        Me.Almacen.Caption = "Almacen"
        Me.Almacen.FieldName = "Almacen"
        Me.Almacen.Name = "Almacen"
        Me.Almacen.OptionsColumn.AllowEdit = False
        Me.Almacen.OptionsColumn.ReadOnly = True
        Me.Almacen.Visible = True
        Me.Almacen.VisibleIndex = 2
        '
        'Locacion
        '
        Me.Locacion.Caption = "Locacion"
        Me.Locacion.FieldName = "Locacion"
        Me.Locacion.Name = "Locacion"
        Me.Locacion.OptionsColumn.AllowEdit = False
        Me.Locacion.OptionsColumn.ReadOnly = True
        Me.Locacion.Visible = True
        Me.Locacion.VisibleIndex = 3
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
        '
        'NoSeries
        '
        Me.NoSeries.Caption = "No. Series"
        Me.NoSeries.FieldName = "NoSeries"
        Me.NoSeries.Name = "NoSeries"
        Me.NoSeries.OptionsColumn.AllowEdit = False
        Me.NoSeries.OptionsColumn.ReadOnly = True
        Me.NoSeries.Visible = True
        Me.NoSeries.VisibleIndex = 5
        '
        'RepExistenciasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 595)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "RepExistenciasForm"
        Me.Text = "Reporte de inventarios de producto terminado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.eLocacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eAlmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMedida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbConfort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbConstruccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbEstatus As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbMedida As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbConfort As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbConstruccion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbLinea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbCategoria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbModelo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbMarca As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbArticulo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eLocacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eAlmacen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SKU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Almacen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Locacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoSeries As DevExpress.XtraGrid.Columns.GridColumn
End Class
