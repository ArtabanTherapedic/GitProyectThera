<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accesos
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
        Me.pTop = New System.Windows.Forms.Panel()
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.cbUsuario = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eIDUsuario = New System.Windows.Forms.TextBox()
        Me.cbNuevo = New System.Windows.Forms.CheckBox()
        Me.bGuardar = New System.Windows.Forms.Button()
        Me.bPassword = New System.Windows.Forms.Button()
        Me.pGral = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.tAccesos = New System.Windows.Forms.TreeView()
        Me.tPermiso = New System.Windows.Forms.TreeView()
        Me.pTop.SuspendLayout()
        Me.pLeft.SuspendLayout()
        CType(Me.cbUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pGral.SuspendLayout()
        Me.SuspendLayout()
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.bPassword)
        Me.pTop.Controls.Add(Me.bGuardar)
        Me.pTop.Controls.Add(Me.cbNuevo)
        Me.pTop.Controls.Add(Me.eIDUsuario)
        Me.pTop.Controls.Add(Me.LabelControl1)
        Me.pTop.Controls.Add(Me.cbUsuario)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(891, 75)
        Me.pTop.TabIndex = 0
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.tAccesos)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pLeft.Location = New System.Drawing.Point(0, 75)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(451, 319)
        Me.pLeft.TabIndex = 1
        '
        'cbUsuario
        '
        Me.cbUsuario.Location = New System.Drawing.Point(166, 16)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbUsuario.Size = New System.Drawing.Size(337, 20)
        Me.cbUsuario.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Usuario:"
        '
        'eIDUsuario
        '
        Me.eIDUsuario.Location = New System.Drawing.Point(60, 15)
        Me.eIDUsuario.Name = "eIDUsuario"
        Me.eIDUsuario.Size = New System.Drawing.Size(100, 21)
        Me.eIDUsuario.TabIndex = 2
        '
        'cbNuevo
        '
        Me.cbNuevo.AutoSize = True
        Me.cbNuevo.Location = New System.Drawing.Point(509, 19)
        Me.cbNuevo.Name = "cbNuevo"
        Me.cbNuevo.Size = New System.Drawing.Size(57, 17)
        Me.cbNuevo.TabIndex = 3
        Me.cbNuevo.Text = "Nuevo"
        Me.cbNuevo.UseVisualStyleBackColor = True
        '
        'bGuardar
        '
        Me.bGuardar.Location = New System.Drawing.Point(60, 43)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(100, 23)
        Me.bGuardar.TabIndex = 4
        Me.bGuardar.Text = "&Guardar"
        Me.bGuardar.UseVisualStyleBackColor = True
        '
        'bPassword
        '
        Me.bPassword.Location = New System.Drawing.Point(393, 43)
        Me.bPassword.Name = "bPassword"
        Me.bPassword.Size = New System.Drawing.Size(110, 23)
        Me.bPassword.TabIndex = 5
        Me.bPassword.Text = "&Limpiar Contraseña"
        Me.bPassword.UseVisualStyleBackColor = True
        '
        'pGral
        '
        Me.pGral.Controls.Add(Me.tPermiso)
        Me.pGral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pGral.Location = New System.Drawing.Point(451, 75)
        Me.pGral.Name = "pGral"
        Me.pGral.Size = New System.Drawing.Size(440, 319)
        Me.pGral.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(451, 75)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 319)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'tAccesos
        '
        Me.tAccesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tAccesos.Location = New System.Drawing.Point(0, 0)
        Me.tAccesos.Name = "tAccesos"
        Me.tAccesos.Size = New System.Drawing.Size(451, 319)
        Me.tAccesos.TabIndex = 0
        '
        'tPermiso
        '
        Me.tPermiso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tPermiso.Location = New System.Drawing.Point(0, 0)
        Me.tPermiso.Name = "tPermiso"
        Me.tPermiso.Size = New System.Drawing.Size(440, 319)
        Me.tPermiso.TabIndex = 1
        '
        'Accesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 394)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.pGral)
        Me.Controls.Add(Me.pLeft)
        Me.Controls.Add(Me.pTop)
        Me.Name = "Accesos"
        Me.Text = "Accesos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        Me.pLeft.ResumeLayout(False)
        CType(Me.cbUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pGral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bPassword As System.Windows.Forms.Button
    Friend WithEvents bGuardar As System.Windows.Forms.Button
    Friend WithEvents cbNuevo As System.Windows.Forms.CheckBox
    Friend WithEvents eIDUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbUsuario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pGral As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents tAccesos As System.Windows.Forms.TreeView
    Friend WithEvents tPermiso As System.Windows.Forms.TreeView
End Class
