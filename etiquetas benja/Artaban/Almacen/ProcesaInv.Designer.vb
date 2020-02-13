<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcesaInv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcesaInv))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bProcesar = New DevExpress.XtraEditors.SimpleButton()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.eFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eObs = New DevExpress.XtraEditors.TextEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.eObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bCancelar)
        Me.pLeft.Controls.Add(Me.bProcesar)
        Me.pLeft.Controls.Add(Me.bIgnorar)
        Me.pLeft.Controls.Add(Me.bGuardar)
        Me.pLeft.Controls.Add(Me.bNuevo)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(668, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 560)
        Me.pLeft.TabIndex = 5
        '
        'bCancelar
        '
        Me.bCancelar.Image = CType(resources.GetObject("bCancelar.Image"), System.Drawing.Image)
        Me.bCancelar.Location = New System.Drawing.Point(11, 284)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(140, 35)
        Me.bCancelar.TabIndex = 104
        Me.bCancelar.Text = "&Cancelar"
        '
        'bProcesar
        '
        Me.bProcesar.Image = CType(resources.GetObject("bProcesar.Image"), System.Drawing.Image)
        Me.bProcesar.Location = New System.Drawing.Point(11, 243)
        Me.bProcesar.Name = "bProcesar"
        Me.bProcesar.Size = New System.Drawing.Size(140, 35)
        Me.bProcesar.TabIndex = 103
        Me.bProcesar.Text = "&Procesar"
        '
        'bIgnorar
        '
        Me.bIgnorar.Image = CType(resources.GetObject("bIgnorar.Image"), System.Drawing.Image)
        Me.bIgnorar.Location = New System.Drawing.Point(11, 202)
        Me.bIgnorar.Name = "bIgnorar"
        Me.bIgnorar.Size = New System.Drawing.Size(140, 35)
        Me.bIgnorar.TabIndex = 102
        Me.bIgnorar.Text = "&Ignorar"
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(11, 161)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(140, 35)
        Me.bGuardar.TabIndex = 101
        Me.bGuardar.Text = "&Guardar"
        '
        'bNuevo
        '
        Me.bNuevo.Image = CType(resources.GetObject("bNuevo.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(11, 120)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(140, 35)
        Me.bNuevo.TabIndex = 100
        Me.bNuevo.Text = "Nuevo"
        '
        'pExit
        '
        Me.pExit.Controls.Add(Me.bSalir)
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pExit.Location = New System.Drawing.Point(0, 350)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(163, 210)
        Me.pExit.TabIndex = 1
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(7, 163)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(140, 35)
        Me.bSalir.TabIndex = 104
        Me.bSalir.Text = "&Salir"
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.eFecha)
        Me.pTop.Controls.Add(Me.Label2)
        Me.pTop.Controls.Add(Me.Label1)
        Me.pTop.Controls.Add(Me.eObs)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(668, 71)
        Me.pTop.TabIndex = 6
        Me.pTop.Visible = False
        '
        'eFecha
        '
        Me.eFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.eFecha.Location = New System.Drawing.Point(102, 9)
        Me.eFecha.Name = "eFecha"
        Me.eFecha.Size = New System.Drawing.Size(107, 21)
        Me.eFecha.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Observaciones"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha de Inicio:"
        '
        'eObs
        '
        Me.eObs.Location = New System.Drawing.Point(96, 36)
        Me.eObs.Name = "eObs"
        Me.eObs.Size = New System.Drawing.Size(555, 20)
        Me.eObs.TabIndex = 8
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 71)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(668, 489)
        Me.pCenter.TabIndex = 7
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(668, 489)
        Me.gCatalogo.TabIndex = 0
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        '
        'ProcesaInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "ProcesaInv"
        Me.Text = "Procesa Inventarios"
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.eObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bProcesar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bIgnorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents eObs As DevExpress.XtraEditors.TextEdit
End Class
