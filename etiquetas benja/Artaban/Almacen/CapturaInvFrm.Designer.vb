<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapturaInv
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CapturaInv))
        Me.pTop = New System.Windows.Forms.Panel()
        Me.eUbicacion = New System.Windows.Forms.ComboBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.eLinea = New DevExpress.XtraEditors.TextEdit()
        Me.eCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.cbDescripcion = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eFolio = New DevExpress.XtraEditors.TextEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Folio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Linea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ubicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop.SuspendLayout()
        CType(Me.eLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFolio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pExit.SuspendLayout()
        Me.pLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.eUbicacion)
        Me.pTop.Controls.Add(Me.LabelControl5)
        Me.pTop.Controls.Add(Me.eLinea)
        Me.pTop.Controls.Add(Me.eCantidad)
        Me.pTop.Controls.Add(Me.cbDescripcion)
        Me.pTop.Controls.Add(Me.LabelControl4)
        Me.pTop.Controls.Add(Me.LabelControl2)
        Me.pTop.Controls.Add(Me.LabelControl3)
        Me.pTop.Controls.Add(Me.LabelControl1)
        Me.pTop.Controls.Add(Me.eFolio)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(774, 114)
        Me.pTop.TabIndex = 7
        '
        'eUbicacion
        '
        Me.eUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.eUbicacion.FormattingEnabled = True
        Me.eUbicacion.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "P", "U", "V", "W", "X", "Y", "Z"})
        Me.eUbicacion.Location = New System.Drawing.Point(175, 36)
        Me.eUbicacion.Name = "eUbicacion"
        Me.eUbicacion.Size = New System.Drawing.Size(102, 21)
        Me.eUbicacion.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "Línea:"
        '
        'eLinea
        '
        Me.eLinea.EditValue = ""
        Me.eLinea.Location = New System.Drawing.Point(41, 37)
        Me.eLinea.Name = "eLinea"
        Me.eLinea.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eLinea.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eLinea.Properties.ReadOnly = True
        Me.eLinea.Size = New System.Drawing.Size(62, 20)
        Me.eLinea.TabIndex = 17
        '
        'eCantidad
        '
        Me.eCantidad.EditValue = ""
        Me.eCantidad.Location = New System.Drawing.Point(349, 36)
        Me.eCantidad.Name = "eCantidad"
        Me.eCantidad.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eCantidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eCantidad.Size = New System.Drawing.Size(100, 20)
        Me.eCantidad.TabIndex = 4
        '
        'cbDescripcion
        '
        Me.cbDescripcion.Location = New System.Drawing.Point(175, 10)
        Me.cbDescripcion.Name = "cbDescripcion"
        Me.cbDescripcion.Properties.AutoSearchColumnIndex = 1
        Me.cbDescripcion.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.cbDescripcion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.[Default], Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.cbDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbDescripcion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[True])})
        Me.cbDescripcion.Properties.NullText = ""
        Me.cbDescripcion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbDescripcion.Size = New System.Drawing.Size(340, 20)
        Me.cbDescripcion.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(296, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "Cantidad:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(120, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Ubicacion:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(111, 13)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Descripción:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Folio:"
        '
        'eFolio
        '
        Me.eFolio.EditValue = ""
        Me.eFolio.Location = New System.Drawing.Point(41, 10)
        Me.eFolio.Name = "eFolio"
        Me.eFolio.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eFolio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eFolio.Size = New System.Drawing.Size(62, 20)
        Me.eFolio.TabIndex = 1
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 114)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(774, 446)
        Me.pCenter.TabIndex = 8
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(774, 446)
        Me.gCatalogo.TabIndex = 0
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.SKU, Me.Folio, Me.Linea, Me.Codigo, Me.Descripcion, Me.Ubicacion, Me.Cantidad})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SKU
        '
        Me.SKU.Caption = "ID"
        Me.SKU.FieldName = "ID"
        Me.SKU.Name = "SKU"
        Me.SKU.OptionsColumn.AllowEdit = False
        Me.SKU.OptionsColumn.ReadOnly = True
        Me.SKU.Width = 73
        '
        'Folio
        '
        Me.Folio.Caption = "idMarca"
        Me.Folio.FieldName = "idMarca"
        Me.Folio.Name = "Folio"
        Me.Folio.OptionsColumn.AllowEdit = False
        Me.Folio.OptionsColumn.ReadOnly = True
        '
        'Linea
        '
        Me.Linea.Caption = "Linea"
        Me.Linea.FieldName = "Linea"
        Me.Linea.Name = "Linea"
        Me.Linea.OptionsColumn.AllowEdit = False
        Me.Linea.OptionsColumn.ReadOnly = True
        Me.Linea.Visible = True
        Me.Linea.VisibleIndex = 0
        Me.Linea.Width = 51
        '
        'Codigo
        '
        Me.Codigo.Caption = "Codigo"
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 1
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripcion"
        Me.Descripcion.FieldName = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.OptionsColumn.AllowEdit = False
        Me.Descripcion.OptionsColumn.ReadOnly = True
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 2
        Me.Descripcion.Width = 180
        '
        'Ubicacion
        '
        Me.Ubicacion.Caption = "Ubicacion"
        Me.Ubicacion.FieldName = "Ubicacion"
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.OptionsColumn.AllowEdit = False
        Me.Ubicacion.OptionsColumn.ReadOnly = True
        Me.Ubicacion.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.Ubicacion.Visible = True
        Me.Ubicacion.VisibleIndex = 3
        Me.Ubicacion.Width = 51
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
        Me.Cantidad.Width = 82
        '
        'pExit
        '
        Me.pExit.Controls.Add(Me.bSalir)
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pExit.Location = New System.Drawing.Point(0, 356)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(163, 204)
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
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(11, 168)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(140, 35)
        Me.bGuardar.TabIndex = 101
        Me.bGuardar.Text = "&Guardar"
        '
        'bIgnorar
        '
        Me.bIgnorar.Image = CType(resources.GetObject("bIgnorar.Image"), System.Drawing.Image)
        Me.bIgnorar.Location = New System.Drawing.Point(11, 268)
        Me.bIgnorar.Name = "bIgnorar"
        Me.bIgnorar.Size = New System.Drawing.Size(140, 35)
        Me.bIgnorar.TabIndex = 102
        Me.bIgnorar.Text = "I&gnorar"
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Image = CType(resources.GetObject("bEliminar.Image"), System.Drawing.Image)
        Me.bEliminar.Location = New System.Drawing.Point(11, 315)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(140, 35)
        Me.bEliminar.TabIndex = 103
        Me.bEliminar.Text = "&Eliminar"
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bImprimir)
        Me.pLeft.Controls.Add(Me.bEliminar)
        Me.pLeft.Controls.Add(Me.bIgnorar)
        Me.pLeft.Controls.Add(Me.bGuardar)
        Me.pLeft.Controls.Add(Me.bNuevo)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(774, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 560)
        Me.pLeft.TabIndex = 6
        '
        'bImprimir
        '
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(11, 218)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(140, 35)
        Me.bImprimir.TabIndex = 104
        Me.bImprimir.Text = "&Imprime Rev."
        '
        'CapturaInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.Name = "CapturaInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revision de Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.eLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFolio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pExit.ResumeLayout(False)
        Me.pLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eFolio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SKU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ubicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Linea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Folio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bIgnorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents eCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eLinea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbDescripcion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eUbicacion As System.Windows.Forms.ComboBox
End Class
