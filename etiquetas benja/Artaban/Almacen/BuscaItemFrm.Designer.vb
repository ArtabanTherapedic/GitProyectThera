<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaItemFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscaItemFrm))
        Me.eCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.eCFactory = New DevExpress.XtraEditors.TextEdit()
        Me.eDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.eCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCFactory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'eCodigo
        '
        Me.eCodigo.Location = New System.Drawing.Point(118, 12)
        Me.eCodigo.Name = "eCodigo"
        Me.eCodigo.Size = New System.Drawing.Size(125, 20)
        Me.eCodigo.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Código de Etiqueta:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Código Factory:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 95)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Descripción:"
        '
        'eCFactory
        '
        Me.eCFactory.Location = New System.Drawing.Point(118, 51)
        Me.eCFactory.Name = "eCFactory"
        Me.eCFactory.Properties.ReadOnly = True
        Me.eCFactory.Size = New System.Drawing.Size(125, 20)
        Me.eCFactory.TabIndex = 2
        '
        'eDescripcion
        '
        Me.eDescripcion.Location = New System.Drawing.Point(118, 88)
        Me.eDescripcion.Name = "eDescripcion"
        Me.eDescripcion.Properties.ReadOnly = True
        Me.eDescripcion.Size = New System.Drawing.Size(481, 108)
        Me.eDescripcion.TabIndex = 3
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(118, 213)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(125, 40)
        Me.bBuscar.TabIndex = 1
        Me.bBuscar.Text = "&Buscar"
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(474, 213)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(125, 40)
        Me.bSalir.TabIndex = 7
        Me.bSalir.Text = "&Salir"
        '
        'BuscaItemFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 268)
        Me.Controls.Add(Me.bSalir)
        Me.Controls.Add(Me.bBuscar)
        Me.Controls.Add(Me.eCFactory)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.eCodigo)
        Me.Controls.Add(Me.eDescripcion)
        Me.KeyPreview = True
        Me.Name = "BuscaItemFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información de Items"
        CType(Me.eCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCFactory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents eCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eCFactory As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
End Class
