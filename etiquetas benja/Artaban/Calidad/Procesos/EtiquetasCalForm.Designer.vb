<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtiquetasCalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtiquetasCalForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pGral = New System.Windows.Forms.Panel()
        Me.bExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.LImpresion = New System.Windows.Forms.Label()
        Me.bLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.eNoPiezas = New DevExpress.XtraEditors.TextEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbDecorativos = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbTPV = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbCliente = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbColor1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbComposicion = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbModelo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.eOP = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaFab = New System.Windows.Forms.DateTimePicker()
        Me.pGral.SuspendLayout()
        CType(Me.eNoPiezas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbDecorativos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbTPV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbColor1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbComposicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eOP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'pGral
        '
        Me.pGral.Controls.Add(Me.bExcel)
        Me.pGral.Controls.Add(Me.LImpresion)
        Me.pGral.Controls.Add(Me.bLimpiar)
        Me.pGral.Controls.Add(Me.bImprimir)
        Me.pGral.Controls.Add(Me.eNoPiezas)
        Me.pGral.Controls.Add(Me.Label18)
        Me.pGral.Controls.Add(Me.cbDecorativos)
        Me.pGral.Controls.Add(Me.Label10)
        Me.pGral.Controls.Add(Me.cbTPV)
        Me.pGral.Controls.Add(Me.Label9)
        Me.pGral.Controls.Add(Me.cbCliente)
        Me.pGral.Controls.Add(Me.Label7)
        Me.pGral.Controls.Add(Me.cbColor1)
        Me.pGral.Controls.Add(Me.Label6)
        Me.pGral.Controls.Add(Me.cbComposicion)
        Me.pGral.Controls.Add(Me.Label5)
        Me.pGral.Controls.Add(Me.cbModelo)
        Me.pGral.Controls.Add(Me.Label4)
        Me.pGral.Controls.Add(Me.Label3)
        Me.pGral.Controls.Add(Me.eOP)
        Me.pGral.Controls.Add(Me.Label1)
        Me.pGral.Controls.Add(Me.FechaFab)
        Me.pGral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pGral.Location = New System.Drawing.Point(0, 0)
        Me.pGral.Name = "pGral"
        Me.pGral.Size = New System.Drawing.Size(642, 242)
        Me.pGral.TabIndex = 0
        '
        'bExcel
        '
        Me.bExcel.Image = CType(resources.GetObject("bExcel.Image"), System.Drawing.Image)
        Me.bExcel.Location = New System.Drawing.Point(217, 187)
        Me.bExcel.Name = "bExcel"
        Me.bExcel.Size = New System.Drawing.Size(131, 42)
        Me.bExcel.TabIndex = 11
        Me.bExcel.Text = "Imprimir de &Excel"
        '
        'LImpresion
        '
        Me.LImpresion.AutoSize = True
        Me.LImpresion.Location = New System.Drawing.Point(15, 216)
        Me.LImpresion.Name = "LImpresion"
        Me.LImpresion.Size = New System.Drawing.Size(210, 13)
        Me.LImpresion.TabIndex = 74
        Me.LImpresion.Text = "Generando Impresion, favor de esperar..."
        Me.LImpresion.Visible = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(502, 187)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(131, 42)
        Me.bLimpiar.TabIndex = 12
        Me.bLimpiar.Text = "&Limpiar"
        '
        'bImprimir
        '
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(361, 187)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(131, 42)
        Me.bImprimir.TabIndex = 10
        Me.bImprimir.Text = "&Imprimir"
        '
        'eNoPiezas
        '
        Me.eNoPiezas.Location = New System.Drawing.Point(463, 52)
        Me.eNoPiezas.Name = "eNoPiezas"
        Me.eNoPiezas.Size = New System.Drawing.Size(110, 20)
        Me.eNoPiezas.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(382, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 13)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "No. De Piezas:"
        '
        'cbDecorativos
        '
        Me.cbDecorativos.Location = New System.Drawing.Point(314, 129)
        Me.cbDecorativos.Name = "cbDecorativos"
        Me.cbDecorativos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbDecorativos.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbDecorativos.Properties.Items.AddRange(New Object() {"SI", "NO"})
        Me.cbDecorativos.Size = New System.Drawing.Size(132, 20)
        Me.cbDecorativos.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(244, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Decorativos:"
        '
        'cbTPV
        '
        Me.cbTPV.Location = New System.Drawing.Point(102, 129)
        Me.cbTPV.Name = "cbTPV"
        Me.cbTPV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbTPV.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbTPV.Size = New System.Drawing.Size(132, 20)
        Me.cbTPV.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Tela / Piel / Vinil"
        '
        'cbCliente
        '
        Me.cbCliente.Location = New System.Drawing.Point(463, 90)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbCliente.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbCliente.Size = New System.Drawing.Size(167, 20)
        Me.cbCliente.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Cliente:"
        '
        'cbColor1
        '
        Me.cbColor1.Location = New System.Drawing.Point(294, 90)
        Me.cbColor1.Name = "cbColor1"
        Me.cbColor1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbColor1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbColor1.Size = New System.Drawing.Size(100, 20)
        Me.cbColor1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Color:"
        '
        'cbComposicion
        '
        Me.cbComposicion.Location = New System.Drawing.Point(91, 90)
        Me.cbComposicion.Name = "cbComposicion"
        Me.cbComposicion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbComposicion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbComposicion.Size = New System.Drawing.Size(143, 20)
        Me.cbComposicion.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Composicion:"
        '
        'cbModelo
        '
        Me.cbModelo.Location = New System.Drawing.Point(67, 52)
        Me.cbModelo.Name = "cbModelo"
        Me.cbModelo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbModelo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbModelo.Size = New System.Drawing.Size(167, 20)
        Me.cbModelo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Modelo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "PC:"
        '
        'eOP
        '
        Me.eOP.Location = New System.Drawing.Point(294, 51)
        Me.eOP.Name = "eOP"
        Me.eOP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eOP.Size = New System.Drawing.Size(72, 20)
        Me.eOP.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Fecha de Fabricacion:"
        '
        'FechaFab
        '
        Me.FechaFab.CustomFormat = "dd/MMM/yyyy"
        Me.FechaFab.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaFab.Location = New System.Drawing.Point(129, 12)
        Me.FechaFab.Name = "FechaFab"
        Me.FechaFab.Size = New System.Drawing.Size(105, 21)
        Me.FechaFab.TabIndex = 1
        '
        'EtiquetasCalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 242)
        Me.Controls.Add(Me.pGral)
        Me.Name = "EtiquetasCalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Impresion de etiquetas de Calidad"
        Me.pGral.ResumeLayout(False)
        Me.pGral.PerformLayout()
        CType(Me.eNoPiezas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbDecorativos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbTPV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbColor1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbComposicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eOP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pGral As System.Windows.Forms.Panel
    Friend WithEvents bExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LImpresion As System.Windows.Forms.Label
    Friend WithEvents bLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eNoPiezas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbTPV As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbCliente As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbColor1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbComposicion As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbModelo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents eOP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FechaFab As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbDecorativos As DevExpress.XtraEditors.ComboBoxEdit
End Class
