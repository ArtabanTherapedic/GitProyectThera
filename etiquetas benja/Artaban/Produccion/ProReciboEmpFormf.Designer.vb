<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProCargaFundasFrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.eConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.eConteo = New DevExpress.XtraEditors.TextEdit()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.eDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.eConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eConteo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.eDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.eConsecutivo)
        Me.Panel1.Controls.Add(Me.eConteo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 85)
        Me.Panel1.TabIndex = 0
        '
        'eConsecutivo
        '
        Me.eConsecutivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eConsecutivo.EditValue = ""
        Me.eConsecutivo.Location = New System.Drawing.Point(0, 0)
        Me.eConsecutivo.Name = "eConsecutivo"
        Me.eConsecutivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 48.0!)
        Me.eConsecutivo.Properties.Appearance.Options.UseFont = True
        Me.eConsecutivo.Size = New System.Drawing.Size(538, 84)
        Me.eConsecutivo.TabIndex = 2
        '
        'eConteo
        '
        Me.eConteo.Dock = System.Windows.Forms.DockStyle.Right
        Me.eConteo.EditValue = ""
        Me.eConteo.Enabled = False
        Me.eConteo.Location = New System.Drawing.Point(538, 0)
        Me.eConteo.Name = "eConteo"
        Me.eConteo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 48.0!)
        Me.eConteo.Properties.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.eConteo.Properties.Appearance.Options.UseFont = True
        Me.eConteo.Properties.Appearance.Options.UseForeColor = True
        Me.eConteo.Properties.ReadOnly = True
        Me.eConteo.Size = New System.Drawing.Size(264, 84)
        Me.eConteo.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.eDescripcion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 399)
        Me.Panel2.TabIndex = 1
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
        Me.eDescripcion.Size = New System.Drawing.Size(802, 399)
        Me.eDescripcion.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'ProCargaFundasFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 484)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ProCargaFundasFrm"
        Me.Text = "Etiqueta recibo de empaque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.eConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eConteo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.eDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents eDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents eConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eConteo As DevExpress.XtraEditors.TextEdit
End Class
