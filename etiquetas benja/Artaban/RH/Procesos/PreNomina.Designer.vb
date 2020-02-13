<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreNomina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreNomina))
        Me.pTop = New DevExpress.XtraEditors.PanelControl()
        Me.bReasignar = New DevExpress.XtraEditors.SimpleButton()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lPeriodo = New System.Windows.Forms.Label()
        Me.cbPeriodo = New System.Windows.Forms.NumericUpDown()
        Me.cbEjercicio = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoNom = New System.Windows.Forms.ComboBox()
        Me.pGral = New DevExpress.XtraEditors.PanelControl()
        CType(Me.pTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pTop.SuspendLayout()
        CType(Me.cbEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbEjercicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pGral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.bReasignar)
        Me.pTop.Controls.Add(Me.bBuscar)
        Me.pTop.Controls.Add(Me.cbEmpleado)
        Me.pTop.Controls.Add(Me.Label4)
        Me.pTop.Controls.Add(Me.Label2)
        Me.pTop.Controls.Add(Me.lPeriodo)
        Me.pTop.Controls.Add(Me.cbPeriodo)
        Me.pTop.Controls.Add(Me.cbEjercicio)
        Me.pTop.Controls.Add(Me.label3)
        Me.pTop.Controls.Add(Me.Label1)
        Me.pTop.Controls.Add(Me.cbTipoNom)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(870, 55)
        Me.pTop.TabIndex = 0
        '
        'bReasignar
        '
        Me.bReasignar.Enabled = False
        Me.bReasignar.Image = CType(resources.GetObject("bReasignar.Image"), System.Drawing.Image)
        Me.bReasignar.Location = New System.Drawing.Point(688, 26)
        Me.bReasignar.Name = "bReasignar"
        Me.bReasignar.Size = New System.Drawing.Size(75, 23)
        Me.bReasignar.TabIndex = 13
        Me.bReasignar.Text = "&Reasignar"
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(607, 26)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(75, 23)
        Me.bBuscar.TabIndex = 12
        Me.bBuscar.Text = "&Buscar"
        '
        'cbEmpleado
        '
        Me.cbEmpleado.Location = New System.Drawing.Point(374, 29)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEmpleado.Size = New System.Drawing.Size(227, 20)
        Me.cbEmpleado.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Empleado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tipo de Prenómina:"
        '
        'lPeriodo
        '
        Me.lPeriodo.AutoSize = True
        Me.lPeriodo.Location = New System.Drawing.Point(275, 9)
        Me.lPeriodo.Name = "lPeriodo"
        Me.lPeriodo.Size = New System.Drawing.Size(156, 13)
        Me.lPeriodo.TabIndex = 6
        Me.lPeriodo.Text = "Del 01/01/2017 al 01/01/2017"
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Location = New System.Drawing.Point(192, 7)
        Me.cbPeriodo.Maximum = New Decimal(New Integer() {53, 0, 0, 0})
        Me.cbPeriodo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(52, 20)
        Me.cbPeriodo.TabIndex = 5
        Me.cbPeriodo.Value = New Decimal(New Integer() {52, 0, 0, 0})
        '
        'cbEjercicio
        '
        Me.cbEjercicio.Location = New System.Drawing.Point(82, 7)
        Me.cbEjercicio.Maximum = New Decimal(New Integer() {2099, 0, 0, 0})
        Me.cbEjercicio.Minimum = New Decimal(New Integer() {2017, 0, 0, 0})
        Me.cbEjercicio.Name = "cbEjercicio"
        Me.cbEjercicio.Size = New System.Drawing.Size(52, 20)
        Me.cbEjercicio.TabIndex = 4
        Me.cbEjercicio.Value = New Decimal(New Integer() {2017, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(140, 9)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(46, 13)
        Me.label3.TabIndex = 3
        Me.label3.Text = "Periodo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ejercicio:"
        '
        'cbTipoNom
        '
        Me.cbTipoNom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoNom.FormattingEnabled = True
        Me.cbTipoNom.Items.AddRange(New Object() {"Almacen PT y Embarques", "Armado y Pegado", "Ayudantes Generales", "Bases", "Cerrado", "Costura", "Ensamble Final", "Línea DOSS"})
        Me.cbTipoNom.Location = New System.Drawing.Point(131, 29)
        Me.cbTipoNom.Name = "cbTipoNom"
        Me.cbTipoNom.Size = New System.Drawing.Size(162, 21)
        Me.cbTipoNom.TabIndex = 1
        '
        'pGral
        '
        Me.pGral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pGral.Location = New System.Drawing.Point(0, 55)
        Me.pGral.Name = "pGral"
        Me.pGral.Size = New System.Drawing.Size(870, 315)
        Me.pGral.TabIndex = 1
        '
        'PreNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 370)
        Me.Controls.Add(Me.pGral)
        Me.Controls.Add(Me.pTop)
        Me.IsMdiContainer = True
        Me.Name = "PreNomina"
        Me.Text = "PreNominas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.cbEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbEjercicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pGral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pGral As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lPeriodo As System.Windows.Forms.Label
    Friend WithEvents cbPeriodo As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbEjercicio As System.Windows.Forms.NumericUpDown
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoNom As System.Windows.Forms.ComboBox
    Friend WithEvents cbEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bReasignar As DevExpress.XtraEditors.SimpleButton
End Class
