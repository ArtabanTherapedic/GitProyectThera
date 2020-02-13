<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtiquetasAlm
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtiquetasAlm))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.eNoEtiquetas = New System.Windows.Forms.NumericUpDown()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.BarCode1 = New DevExpress.XtraEditors.BarCodeControl()
        Me.bGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbArticulo = New DevExpress.XtraEditors.LookUpEdit()
        Me.lbIUM = New System.Windows.Forms.Label()
        Me.cbIDArticulo = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbImpresora = New System.Windows.Forms.ComboBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.bImprimeP = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.eCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eNoEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbIDArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(174, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 113
        Me.LabelControl1.Text = "Articulo:"
        '
        'eCantidad
        '
        Me.eCantidad.Location = New System.Drawing.Point(422, 55)
        Me.eCantidad.Name = "eCantidad"
        Me.eCantidad.Size = New System.Drawing.Size(100, 20)
        Me.eCantidad.TabIndex = 114
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(422, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 115
        Me.LabelControl2.Text = "Cantidad:"
        '
        'eNoEtiquetas
        '
        Me.eNoEtiquetas.Location = New System.Drawing.Point(572, 55)
        Me.eNoEtiquetas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.eNoEtiquetas.Name = "eNoEtiquetas"
        Me.eNoEtiquetas.Size = New System.Drawing.Size(88, 20)
        Me.eNoEtiquetas.TabIndex = 116
        Me.eNoEtiquetas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(572, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 117
        Me.LabelControl3.Text = "No. Etiquetas"
        '
        'BarCode1
        '
        Me.BarCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarCode1.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BarCode1.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BarCode1.Location = New System.Drawing.Point(43, 118)
        Me.BarCode1.Name = "BarCode1"
        Me.BarCode1.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
        Me.BarCode1.Size = New System.Drawing.Size(617, 122)
        Me.BarCode1.Symbology = Code128Generator1
        Me.BarCode1.TabIndex = 118
        Me.BarCode1.Visible = False
        '
        'bGenerar
        '
        Me.bGenerar.Image = CType(resources.GetObject("bGenerar.Image"), System.Drawing.Image)
        Me.bGenerar.Location = New System.Drawing.Point(374, 79)
        Me.bGenerar.Name = "bGenerar"
        Me.bGenerar.Size = New System.Drawing.Size(133, 33)
        Me.bGenerar.TabIndex = 119
        Me.bGenerar.Text = "Generar Etiquetas"
        '
        'cbArticulo
        '
        Me.cbArticulo.Location = New System.Drawing.Point(174, 55)
        Me.cbArticulo.Name = "cbArticulo"
        Me.cbArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbArticulo.Size = New System.Drawing.Size(242, 20)
        Me.cbArticulo.TabIndex = 112
        '
        'lbIUM
        '
        Me.lbIUM.AutoSize = True
        Me.lbIUM.Location = New System.Drawing.Point(525, 59)
        Me.lbIUM.Name = "lbIUM"
        Me.lbIUM.Size = New System.Drawing.Size(27, 13)
        Me.lbIUM.TabIndex = 120
        Me.lbIUM.Text = "IUM"
        '
        'cbIDArticulo
        '
        Me.cbIDArticulo.Location = New System.Drawing.Point(43, 55)
        Me.cbIDArticulo.Name = "cbIDArticulo"
        Me.cbIDArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbIDArticulo.Size = New System.Drawing.Size(125, 20)
        Me.cbIDArticulo.TabIndex = 111
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 13)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Selección de Impresora :"
        '
        'cbImpresora
        '
        Me.cbImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImpresora.FormattingEnabled = True
        Me.cbImpresora.Location = New System.Drawing.Point(174, 86)
        Me.cbImpresora.Name = "cbImpresora"
        Me.cbImpresora.Size = New System.Drawing.Size(194, 21)
        Me.cbImpresora.TabIndex = 121
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(43, 33)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 123
        Me.LabelControl4.Text = "ID Articulo:"
        '
        'bImprimeP
        '
        Me.bImprimeP.Image = CType(resources.GetObject("bImprimeP.Image"), System.Drawing.Image)
        Me.bImprimeP.Location = New System.Drawing.Point(513, 81)
        Me.bImprimeP.Name = "bImprimeP"
        Me.bImprimeP.Size = New System.Drawing.Size(147, 33)
        Me.bImprimeP.TabIndex = 124
        Me.bImprimeP.Text = "Generar En Pantalla"
        '
        'EtiquetasAlm
        '
        Me.ClientSize = New System.Drawing.Size(697, 261)
        Me.Controls.Add(Me.bImprimeP)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbImpresora)
        Me.Controls.Add(Me.cbIDArticulo)
        Me.Controls.Add(Me.lbIUM)
        Me.Controls.Add(Me.bGenerar)
        Me.Controls.Add(Me.BarCode1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.eNoEtiquetas)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.eCantidad)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbArticulo)
        Me.Name = "EtiquetasAlm"
        Me.Text = "Generar etiquetas de Materia Prima"
        CType(Me.eCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eNoEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbIDArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents cbArticulo As DevExpress.XtraEditors.LookUpEdit
    'Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents eCantidad As System.Windows.Forms.TextBox
    'Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents eNoEtiquetas As System.Windows.Forms.NumericUpDown
    'Friend WithEvents BarCode1 As DevExpress.XtraEditors.BarCodeControl
    'Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eNoEtiquetas As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarCode1 As DevExpress.XtraEditors.BarCodeControl
    Friend WithEvents bGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbArticulo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lbIUM As System.Windows.Forms.Label
    Friend WithEvents cbIDArticulo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbImpresora As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bImprimeP As DevExpress.XtraEditors.SimpleButton
End Class
