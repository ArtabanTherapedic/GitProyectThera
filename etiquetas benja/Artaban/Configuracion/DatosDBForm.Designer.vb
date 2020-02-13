<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosDBForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosDBForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.eServer = New DevExpress.XtraEditors.TextEdit()
        Me.eDB = New DevExpress.XtraEditors.TextEdit()
        Me.eUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.ePW = New DevExpress.XtraEditors.TextEdit()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bCancelar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.eServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePW.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos de Conexión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IP del Servidor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Base de Datos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Usuario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña:"
        '
        'eServer
        '
        Me.eServer.Location = New System.Drawing.Point(101, 64)
        Me.eServer.Name = "eServer"
        Me.eServer.Size = New System.Drawing.Size(159, 20)
        Me.eServer.TabIndex = 5
        '
        'eDB
        '
        Me.eDB.Location = New System.Drawing.Point(101, 90)
        Me.eDB.Name = "eDB"
        Me.eDB.Size = New System.Drawing.Size(159, 20)
        Me.eDB.TabIndex = 6
        '
        'eUsuario
        '
        Me.eUsuario.Location = New System.Drawing.Point(101, 116)
        Me.eUsuario.Name = "eUsuario"
        Me.eUsuario.Size = New System.Drawing.Size(159, 20)
        Me.eUsuario.TabIndex = 7
        '
        'ePW
        '
        Me.ePW.Location = New System.Drawing.Point(101, 142)
        Me.ePW.Name = "ePW"
        Me.ePW.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ePW.Size = New System.Drawing.Size(159, 20)
        Me.ePW.TabIndex = 8
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bGuardar.Location = New System.Drawing.Point(12, 196)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(119, 53)
        Me.bGuardar.TabIndex = 9
        Me.bGuardar.Text = "Guardar Configuración"
        '
        'bCancelar
        '
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bCancelar.Location = New System.Drawing.Point(141, 196)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(119, 53)
        Me.bCancelar.TabIndex = 10
        Me.bCancelar.Text = "Cancelar y Cerrar"
        '
        'DatosDBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 261)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.bGuardar)
        Me.Controls.Add(Me.ePW)
        Me.Controls.Add(Me.eUsuario)
        Me.Controls.Add(Me.eDB)
        Me.Controls.Add(Me.eServer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(288, 300)
        Me.MinimumSize = New System.Drawing.Size(288, 300)
        Me.Name = "DatosDBForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion de DB"
        CType(Me.eServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePW.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents eServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eDB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePW As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bCancelar As DevExpress.XtraEditors.SimpleButton
End Class
