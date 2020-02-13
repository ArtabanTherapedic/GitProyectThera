<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProCargaFundasFrm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProCargaFundasFrm1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbRetorno = New System.Windows.Forms.CheckBox()
        Me.bGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.eConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.eConteo = New DevExpress.XtraEditors.TextEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.eDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.gDetalles = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Consecutivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Parte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Hora = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.eConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eConteo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.eDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.eConsecutivo)
        Me.Panel1.Controls.Add(Me.eConteo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 85)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbRetorno)
        Me.Panel3.Controls.Add(Me.bGenerar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(320, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(304, 85)
        Me.Panel3.TabIndex = 0
        '
        'cbRetorno
        '
        Me.cbRetorno.AutoSize = True
        Me.cbRetorno.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRetorno.Location = New System.Drawing.Point(118, 12)
        Me.cbRetorno.Name = "cbRetorno"
        Me.cbRetorno.Size = New System.Drawing.Size(179, 49)
        Me.cbRetorno.TabIndex = 1
        Me.cbRetorno.Text = "Retornar"
        Me.cbRetorno.UseVisualStyleBackColor = True
        '
        'bGenerar
        '
        Me.bGenerar.Image = CType(resources.GetObject("bGenerar.Image"), System.Drawing.Image)
        Me.bGenerar.Location = New System.Drawing.Point(3, 12)
        Me.bGenerar.Name = "bGenerar"
        Me.bGenerar.Size = New System.Drawing.Size(104, 56)
        Me.bGenerar.TabIndex = 0
        Me.bGenerar.Text = "Generar"
        '
        'eConsecutivo
        '
        Me.eConsecutivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eConsecutivo.EditValue = ""
        Me.eConsecutivo.Location = New System.Drawing.Point(0, 0)
        Me.eConsecutivo.Name = "eConsecutivo"
        Me.eConsecutivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 48.0!)
        Me.eConsecutivo.Properties.Appearance.Options.UseFont = True
        Me.eConsecutivo.Size = New System.Drawing.Size(624, 84)
        Me.eConsecutivo.TabIndex = 2
        '
        'eConteo
        '
        Me.eConteo.Dock = System.Windows.Forms.DockStyle.Right
        Me.eConteo.EditValue = ""
        Me.eConteo.Enabled = False
        Me.eConteo.Location = New System.Drawing.Point(624, 0)
        Me.eConteo.Name = "eConteo"
        Me.eConteo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 48.0!)
        Me.eConteo.Properties.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.eConteo.Properties.Appearance.Options.UseFont = True
        Me.eConteo.Properties.Appearance.Options.UseForeColor = True
        Me.eConteo.Properties.ReadOnly = True
        Me.eConteo.Size = New System.Drawing.Size(178, 84)
        Me.eConteo.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 399)
        Me.Panel2.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.eDescripcion)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gDetalles)
        Me.SplitContainer1.Size = New System.Drawing.Size(802, 399)
        Me.SplitContainer1.SplitterDistance = 224
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 5
        '
        'eDescripcion
        '
        Me.eDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eDescripcion.EditValue = ""
        Me.eDescripcion.Location = New System.Drawing.Point(0, 0)
        Me.eDescripcion.Name = "eDescripcion"
        Me.eDescripcion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 46.0!)
        Me.eDescripcion.Properties.Appearance.Options.UseFont = True
        Me.eDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eDescripcion.Properties.ReadOnly = True
        Me.eDescripcion.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.eDescripcion.Size = New System.Drawing.Size(802, 224)
        Me.eDescripcion.TabIndex = 5
        '
        'gDetalles
        '
        Me.gDetalles.Cursor = System.Windows.Forms.Cursors.Default
        Me.gDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gDetalles.Location = New System.Drawing.Point(0, 0)
        Me.gDetalles.MainView = Me.GridView1
        Me.gDetalles.Name = "gDetalles"
        Me.gDetalles.Size = New System.Drawing.Size(802, 172)
        Me.gDetalles.TabIndex = 4
        Me.gDetalles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Consecutivo, Me.SKU, Me.Parte, Me.Hora})
        Me.GridView1.GridControl = Me.gDetalles
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Consecutivo
        '
        Me.Consecutivo.Caption = "No. Etiqueta"
        Me.Consecutivo.FieldName = "Consecutivo"
        Me.Consecutivo.Name = "Consecutivo"
        Me.Consecutivo.OptionsColumn.AllowEdit = False
        Me.Consecutivo.Visible = True
        Me.Consecutivo.VisibleIndex = 0
        Me.Consecutivo.Width = 90
        '
        'SKU
        '
        Me.SKU.Caption = "SKU"
        Me.SKU.FieldName = "SKU"
        Me.SKU.Name = "SKU"
        Me.SKU.OptionsColumn.AllowEdit = False
        Me.SKU.Visible = True
        Me.SKU.VisibleIndex = 1
        Me.SKU.Width = 90
        '
        'Parte
        '
        Me.Parte.Caption = "Parte"
        Me.Parte.FieldName = "Parte"
        Me.Parte.Name = "Parte"
        Me.Parte.OptionsColumn.AllowEdit = False
        Me.Parte.Visible = True
        Me.Parte.VisibleIndex = 2
        Me.Parte.Width = 400
        '
        'Hora
        '
        Me.Hora.Caption = "Hora"
        Me.Hora.FieldName = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.OptionsColumn.AllowEdit = False
        Me.Hora.Visible = True
        Me.Hora.VisibleIndex = 3
        Me.Hora.Width = 80
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'ProCargaFundasFrm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 484)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProCargaFundasFrm1"
        Me.Text = "Etiqueta recibo de empaque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.eConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eConteo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.eDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents eConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eConteo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents bGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbRetorno As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents eDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents gDetalles As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Consecutivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SKU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Parte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Hora As DevExpress.XtraGrid.Columns.GridColumn
End Class
