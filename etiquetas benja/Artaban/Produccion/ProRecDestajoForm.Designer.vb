<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProRecDestajoFormf
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.mEmpleado = New DevExpress.XtraEditors.MemoEdit()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.eDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.eConsecutivo = New DevExpress.XtraEditors.TextEdit()
        Me.tActivo = New System.Windows.Forms.Timer(Me.components)
        Me.TableAdapterManager1 = New Artaban.CalidadDataSetTableAdapters.TableAdapterManager()
        Me.Panel3.SuspendLayout()
        CType(Me.mEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.eDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eConsecutivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.mEmpleado)
        Me.Panel3.Controls.Add(Me.Foto)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(564, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(238, 484)
        Me.Panel3.TabIndex = 3
        '
        'mEmpleado
        '
        Me.mEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mEmpleado.EditValue = ""
        Me.mEmpleado.Location = New System.Drawing.Point(0, 207)
        Me.mEmpleado.Name = "mEmpleado"
        Me.mEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.mEmpleado.Properties.Appearance.Options.UseBackColor = True
        Me.mEmpleado.Properties.Appearance.Options.UseFont = True
        Me.mEmpleado.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.mEmpleado.Properties.ReadOnly = True
        Me.mEmpleado.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mEmpleado.Size = New System.Drawing.Size(238, 277)
        Me.mEmpleado.TabIndex = 3
        '
        'Foto
        '
        Me.Foto.Dock = System.Windows.Forms.DockStyle.Top
        Me.Foto.Location = New System.Drawing.Point(0, 0)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(238, 207)
        Me.Foto.TabIndex = 0
        Me.Foto.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.eDescripcion)
        Me.Panel2.Controls.Add(Me.eConsecutivo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(564, 484)
        Me.Panel2.TabIndex = 4
        '
        'eDescripcion
        '
        Me.eDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eDescripcion.EditValue = ""
        Me.eDescripcion.Location = New System.Drawing.Point(0, 84)
        Me.eDescripcion.Name = "eDescripcion"
        Me.eDescripcion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 32.0!)
        Me.eDescripcion.Properties.Appearance.Options.UseFont = True
        Me.eDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eDescripcion.Properties.ReadOnly = True
        Me.eDescripcion.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.eDescripcion.Size = New System.Drawing.Size(564, 400)
        Me.eDescripcion.TabIndex = 4
        '
        'eConsecutivo
        '
        Me.eConsecutivo.Dock = System.Windows.Forms.DockStyle.Top
        Me.eConsecutivo.EditValue = ""
        Me.eConsecutivo.Location = New System.Drawing.Point(0, 0)
        Me.eConsecutivo.Name = "eConsecutivo"
        Me.eConsecutivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 48.0!)
        Me.eConsecutivo.Properties.Appearance.Options.UseFont = True
        Me.eConsecutivo.Size = New System.Drawing.Size(564, 84)
        Me.eConsecutivo.TabIndex = 3
        '
        'tActivo
        '
        Me.tActivo.Interval = 36000
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = Artaban.CalidadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProRecDestajoFormf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 484)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "ProRecDestajoFormf"
        Me.Text = "Etiqueta recibo de empaque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        CType(Me.mEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.eDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eConsecutivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents mEmpleado As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Foto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tActivo As System.Windows.Forms.Timer
    Friend WithEvents eDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents eConsecutivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TableAdapterManager1 As Artaban.CalidadDataSetTableAdapters.TableAdapterManager
End Class
