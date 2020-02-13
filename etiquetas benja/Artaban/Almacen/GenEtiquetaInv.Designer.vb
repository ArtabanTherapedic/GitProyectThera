<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenEtiquetaInv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenEtiquetaInv))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.bExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.Progreso = New System.Windows.Forms.ProgressBar()
        Me.eCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbImpresora = New System.Windows.Forms.ComboBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cbDesc = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cbCodigo = New DevExpress.XtraEditors.LookUpEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cant = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Observaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.eCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bEliminar)
        Me.pLeft.Controls.Add(Me.bIgnorar)
        Me.pLeft.Controls.Add(Me.bGenerar)
        Me.pLeft.Controls.Add(Me.bExcel)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(780, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 540)
        Me.pLeft.TabIndex = 19
        '
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Image = CType(resources.GetObject("bEliminar.Image"), System.Drawing.Image)
        Me.bEliminar.Location = New System.Drawing.Point(11, 269)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(140, 35)
        Me.bEliminar.TabIndex = 103
        Me.bEliminar.Text = "&Eliminar"
        Me.bEliminar.Visible = False
        '
        'bIgnorar
        '
        Me.bIgnorar.Image = CType(resources.GetObject("bIgnorar.Image"), System.Drawing.Image)
        Me.bIgnorar.Location = New System.Drawing.Point(11, 218)
        Me.bIgnorar.Name = "bIgnorar"
        Me.bIgnorar.Size = New System.Drawing.Size(140, 35)
        Me.bIgnorar.TabIndex = 102
        Me.bIgnorar.Text = "&Ignorar"
        Me.bIgnorar.Visible = False
        '
        'bGenerar
        '
        Me.bGenerar.Enabled = False
        Me.bGenerar.Image = CType(resources.GetObject("bGenerar.Image"), System.Drawing.Image)
        Me.bGenerar.Location = New System.Drawing.Point(11, 168)
        Me.bGenerar.Name = "bGenerar"
        Me.bGenerar.Size = New System.Drawing.Size(140, 35)
        Me.bGenerar.TabIndex = 101
        Me.bGenerar.Text = "&Generar"
        '
        'bExcel
        '
        Me.bExcel.Image = CType(resources.GetObject("bExcel.Image"), System.Drawing.Image)
        Me.bExcel.Location = New System.Drawing.Point(11, 120)
        Me.bExcel.Name = "bExcel"
        Me.bExcel.Size = New System.Drawing.Size(140, 35)
        Me.bExcel.TabIndex = 100
        Me.bExcel.Text = "Generar por &Excel"
        Me.bExcel.Visible = False
        '
        'pExit
        '
        Me.pExit.Controls.Add(Me.bSalir)
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pExit.Location = New System.Drawing.Point(0, 330)
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
        Me.pTop.Controls.Add(Me.Progreso)
        Me.pTop.Controls.Add(Me.eCantidad)
        Me.pTop.Controls.Add(Me.Label9)
        Me.pTop.Controls.Add(Me.cbImpresora)
        Me.pTop.Controls.Add(Me.LabelControl10)
        Me.pTop.Controls.Add(Me.cbDesc)
        Me.pTop.Controls.Add(Me.LabelControl2)
        Me.pTop.Controls.Add(Me.cbCodigo)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(780, 80)
        Me.pTop.TabIndex = 105
        '
        'Progreso
        '
        Me.Progreso.Location = New System.Drawing.Point(523, 41)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(251, 23)
        Me.Progreso.TabIndex = 96
        Me.Progreso.Visible = False
        '
        'eCantidad
        '
        Me.eCantidad.Location = New System.Drawing.Point(65, 41)
        Me.eCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.eCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.eCantidad.Name = "eCantidad"
        Me.eCantidad.Size = New System.Drawing.Size(120, 21)
        Me.eCantidad.TabIndex = 2
        Me.eCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(191, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Selección de Impresora :"
        '
        'cbImpresora
        '
        Me.cbImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImpresora.FormattingEnabled = True
        Me.cbImpresora.Location = New System.Drawing.Point(322, 41)
        Me.cbImpresora.Name = "cbImpresora"
        Me.cbImpresora.Size = New System.Drawing.Size(194, 21)
        Me.cbImpresora.TabIndex = 94
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(12, 44)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl10.TabIndex = 22
        Me.LabelControl10.Text = "Cantidad:"
        '
        'cbDesc
        '
        Me.cbDesc.Location = New System.Drawing.Point(191, 12)
        Me.cbDesc.Name = "cbDesc"
        Me.cbDesc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDesc.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SKU", "SKU", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion")})
        Me.cbDesc.Properties.NullText = ""
        Me.cbDesc.Size = New System.Drawing.Size(450, 20)
        Me.cbDesc.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Producto:"
        '
        'cbCodigo
        '
        Me.cbCodigo.Location = New System.Drawing.Point(65, 12)
        Me.cbCodigo.Name = "cbCodigo"
        Me.cbCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCodigo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SKU", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cbCodigo.Properties.NullText = ""
        Me.cbCodigo.Size = New System.Drawing.Size(120, 20)
        Me.cbCodigo.TabIndex = 0
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Controls.Add(Me.MemoEdit1)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 80)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(780, 460)
        Me.pCenter.TabIndex = 106
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.Location = New System.Drawing.Point(0, 158)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(780, 302)
        Me.gCatalogo.TabIndex = 79
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Codigo, Me.Cant, Me.Observaciones})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Codigo
        '
        Me.Codigo.Caption = "Codigo"
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 0
        Me.Codigo.Width = 98
        '
        'Cant
        '
        Me.Cant.Caption = "Cantidad"
        Me.Cant.FieldName = "Cantidad"
        Me.Cant.Name = "Cant"
        Me.Cant.Visible = True
        Me.Cant.VisibleIndex = 1
        Me.Cant.Width = 76
        '
        'Observaciones
        '
        Me.Observaciones.Caption = "Observaciones"
        Me.Observaciones.FieldName = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Visible = True
        Me.Observaciones.VisibleIndex = 2
        Me.Observaciones.Width = 588
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MemoEdit1.EditValue = resources.GetString("MemoEdit1.EditValue")
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemoEdit1.Properties.Appearance.Options.UseFont = True
        Me.MemoEdit1.Size = New System.Drawing.Size(780, 158)
        Me.MemoEdit1.TabIndex = 0
        Me.MemoEdit1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'GenEtiquetaInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 540)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "GenEtiquetaInv"
        Me.Text = "Generador de Etiquetas para Producto Terminado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.eCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bIgnorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbDesc As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbCodigo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbImpresora As System.Windows.Forms.ComboBox
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cant As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Observaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
End Class
