<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportView
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
        Me.Visor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Visor
        '
        Me.Visor.ActiveViewIndex = -1
        Me.Visor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Visor.Cursor = System.Windows.Forms.Cursors.Default
        Me.Visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Visor.Location = New System.Drawing.Point(0, 0)
        Me.Visor.Name = "Visor"
        Me.Visor.ShowParameterPanelButton = False
        Me.Visor.Size = New System.Drawing.Size(721, 485)
        Me.Visor.TabIndex = 0
        Me.Visor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ReportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 485)
        Me.Controls.Add(Me.Visor)
        Me.Name = "ReportView"
        Me.Text = "ReportView"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Visor As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
