<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.eUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.eClave = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bIngresar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.eUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 58)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID de Usuario:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 129)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(120, 19)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Clave de Acceso:"
        '
        'eUsuario
        '
        Me.eUsuario.Location = New System.Drawing.Point(20, 89)
        Me.eUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eUsuario.Name = "eUsuario"
        Me.eUsuario.Size = New System.Drawing.Size(150, 26)
        Me.eUsuario.TabIndex = 0
        '
        'eClave
        '
        Me.eClave.Location = New System.Drawing.Point(20, 158)
        Me.eClave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.eClave.Name = "eClave"
        Me.eClave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.eClave.Size = New System.Drawing.Size(150, 26)
        Me.eClave.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(20, 198)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Empresa:"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Items.AddRange(New Object() {"Artaban Internacional", "Artaban Therapedic", "Metalicos", "FoamArt"})
        Me.cbEmpresa.Location = New System.Drawing.Point(20, 229)
        Me.cbEmpresa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(386, 28)
        Me.cbEmpresa.TabIndex = 2
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bSalir.Location = New System.Drawing.Point(296, 288)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(112, 83)
        Me.bSalir.TabIndex = 4
        Me.bSalir.Text = "&Salir"
        '
        'bIngresar
        '
        Me.bIngresar.Image = CType(resources.GetObject("bIngresar.Image"), System.Drawing.Image)
        Me.bIngresar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bIngresar.Location = New System.Drawing.Point(12, 288)
        Me.bIngresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bIngresar.Name = "bIngresar"
        Me.bIngresar.Size = New System.Drawing.Size(112, 83)
        Me.bIngresar.TabIndex = 3
        Me.bIngresar.Text = "&Ingresar"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 375)
        Me.Controls.Add(Me.cbEmpresa)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.eClave)
        Me.Controls.Add(Me.eUsuario)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bIngresar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(439, 431)
        Me.MinimumSize = New System.Drawing.Size(439, 431)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso al Sistema"
        CType(Me.eUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bIngresar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
End Class
