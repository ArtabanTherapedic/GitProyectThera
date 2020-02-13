<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferFrm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbArticulo = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.eFolio = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fMovimiento = New DevExpress.XtraEditors.DateEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bTransferir = New DevExpress.XtraEditors.SimpleButton()
        Me.cbUbicacionD = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbAlmacenD = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbUbicacionO = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbAlmacenO = New DevExpress.XtraEditors.LookUpEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Ubicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.cbArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFolio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fMovimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbUbicacionD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAlmacenD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbUbicacionO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAlmacenO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbArticulo)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.bLimpiar)
        Me.Panel1.Controls.Add(Me.eFolio)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.fMovimiento)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.bTransferir)
        Me.Panel1.Controls.Add(Me.cbUbicacionD)
        Me.Panel1.Controls.Add(Me.cbAlmacenD)
        Me.Panel1.Controls.Add(Me.cbUbicacionO)
        Me.Panel1.Controls.Add(Me.cbAlmacenO)
        Me.Panel1.Controls.Add(Me.TextEdit2)
        Me.Panel1.Controls.Add(Me.TextEdit1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(897, 183)
        Me.Panel1.TabIndex = 0
        '
        'cbArticulo
        '
        Me.cbArticulo.Location = New System.Drawing.Point(137, 71)
        Me.cbArticulo.Name = "cbArticulo"
        Me.cbArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbArticulo.Size = New System.Drawing.Size(250, 20)
        Me.cbArticulo.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(85, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Artículo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(640, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Movimientos Registrados:"
        '
        'bLimpiar
        '
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(664, 103)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(117, 41)
        Me.bLimpiar.TabIndex = 9
        Me.bLimpiar.Text = "&Limpiar"
        '
        'eFolio
        '
        Me.eFolio.Location = New System.Drawing.Point(531, 16)
        Me.eFolio.Name = "eFolio"
        Me.eFolio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eFolio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eFolio.Size = New System.Drawing.Size(100, 20)
        Me.eFolio.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(435, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Folio Movimiento:"
        '
        'fMovimiento
        '
        Me.fMovimiento.EditValue = Nothing
        Me.fMovimiento.Location = New System.Drawing.Point(137, 16)
        Me.fMovimiento.Name = "fMovimiento"
        Me.fMovimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fMovimiento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fMovimiento.Size = New System.Drawing.Size(100, 20)
        Me.fMovimiento.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Fecha:"
        '
        'bTransferir
        '
        Me.bTransferir.Image = CType(resources.GetObject("bTransferir.Image"), System.Drawing.Image)
        Me.bTransferir.Location = New System.Drawing.Point(438, 103)
        Me.bTransferir.Name = "bTransferir"
        Me.bTransferir.Size = New System.Drawing.Size(193, 41)
        Me.bTransferir.TabIndex = 8
        Me.bTransferir.Text = "&Transferir"
        '
        'cbUbicacionD
        '
        Me.cbUbicacionD.Location = New System.Drawing.Point(531, 70)
        Me.cbUbicacionD.Name = "cbUbicacionD"
        Me.cbUbicacionD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbUbicacionD.Size = New System.Drawing.Size(100, 20)
        Me.cbUbicacionD.TabIndex = 7
        '
        'cbAlmacenD
        '
        Me.cbAlmacenD.Location = New System.Drawing.Point(531, 43)
        Me.cbAlmacenD.Name = "cbAlmacenD"
        Me.cbAlmacenD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAlmacenD.Size = New System.Drawing.Size(250, 20)
        Me.cbAlmacenD.TabIndex = 6
        '
        'cbUbicacionO
        '
        Me.cbUbicacionO.Location = New System.Drawing.Point(137, 100)
        Me.cbUbicacionO.Name = "cbUbicacionO"
        Me.cbUbicacionO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbUbicacionO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDAlmacen", "IDAlmacen", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Almacen", "Almacen")})
        Me.cbUbicacionO.Size = New System.Drawing.Size(100, 20)
        Me.cbUbicacionO.TabIndex = 3
        '
        'cbAlmacenO
        '
        Me.cbAlmacenO.Location = New System.Drawing.Point(137, 43)
        Me.cbAlmacenO.Name = "cbAlmacenO"
        Me.cbAlmacenO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAlmacenO.Size = New System.Drawing.Size(250, 20)
        Me.cbAlmacenO.TabIndex = 1
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(137, 150)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit2.TabIndex = 5
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(137, 126)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cantidad a Transferir:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad Disponible:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ubicacion Origen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(435, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Almacen Destino:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(435, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ubicacion Destino:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Almacen Origen:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 183)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(897, 374)
        Me.Panel2.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(897, 374)
        Me.SplitContainer1.SplitterDistance = 406
        Me.SplitContainer1.SplitterWidth = 40
        Me.SplitContainer1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(406, 374)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Ubicacion, Me.Codigo, Me.Descripcion, Me.Cantidad})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Ubicacion
        '
        Me.Ubicacion.Caption = "Ubicacion"
        Me.Ubicacion.FieldName = "Ubicacion"
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.OptionsColumn.AllowEdit = False
        Me.Ubicacion.OptionsColumn.ReadOnly = True
        Me.Ubicacion.Visible = True
        Me.Ubicacion.VisibleIndex = 0
        '
        'Codigo
        '
        Me.Codigo.Caption = "Codigo"
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.OptionsColumn.AllowEdit = False
        Me.Codigo.OptionsColumn.ReadOnly = True
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
        '
        'Cantidad
        '
        Me.Cantidad.Caption = "Cantidad"
        Me.Cantidad.FieldName = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.OptionsColumn.AllowEdit = False
        Me.Cantidad.OptionsColumn.ReadOnly = True
        Me.Cantidad.Visible = True
        Me.Cantidad.VisibleIndex = 3
        '
        'TransferFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 557)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "TransferFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencias de Inventarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFolio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fMovimiento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbUbicacionD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAlmacenD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbUbicacionO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAlmacenO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbUbicacionD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbAlmacenD As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbUbicacionO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbAlmacenO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bTransferir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents eFolio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fMovimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Ubicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbArticulo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
