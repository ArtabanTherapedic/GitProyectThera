<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdProcesoFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProdProcesoFrm))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.eOP = New DevExpress.XtraEditors.TextEdit()
        Me.cbOperador = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbOperacion = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eParte = New DevExpress.XtraEditors.TextEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.tRefrescar = New System.Windows.Forms.Timer(Me.components)
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.eOP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOperador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbOperacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eParte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bBuscar)
        Me.pLeft.Controls.Add(Me.bLimpiar)
        Me.pLeft.Controls.Add(Me.bExportar)
        Me.pLeft.Controls.Add(Me.bNuevo)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(668, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 560)
        Me.pLeft.TabIndex = 5
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(11, 269)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(140, 35)
        Me.bBuscar.TabIndex = 103
        Me.bBuscar.Text = "&Buscar"
        '
        'bLimpiar
        '
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(11, 218)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(140, 35)
        Me.bLimpiar.TabIndex = 102
        Me.bLimpiar.Text = "&Limpiar"
        '
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(11, 168)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(140, 35)
        Me.bExportar.TabIndex = 101
        Me.bExportar.Text = "&Exportar"
        '
        'bNuevo
        '
        Me.bNuevo.Image = CType(resources.GetObject("bNuevo.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(11, 120)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(140, 35)
        Me.bNuevo.TabIndex = 100
        Me.bNuevo.Text = "Nuevo"
        Me.bNuevo.Visible = False
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
        Me.pTop.Controls.Add(Me.eOP)
        Me.pTop.Controls.Add(Me.cbOperador)
        Me.pTop.Controls.Add(Me.Label4)
        Me.pTop.Controls.Add(Me.cbOperacion)
        Me.pTop.Controls.Add(Me.Label3)
        Me.pTop.Controls.Add(Me.Label2)
        Me.pTop.Controls.Add(Me.Label1)
        Me.pTop.Controls.Add(Me.eParte)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(668, 114)
        Me.pTop.TabIndex = 6
        '
        'eOP
        '
        Me.eOP.Location = New System.Drawing.Point(48, 12)
        Me.eOP.Name = "eOP"
        Me.eOP.Size = New System.Drawing.Size(75, 20)
        Me.eOP.TabIndex = 1
        '
        'cbOperador
        '
        Me.cbOperador.Location = New System.Drawing.Point(192, 12)
        Me.cbOperador.Name = "cbOperador"
        Me.cbOperador.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOperador.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpID", "EmpID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")})
        Me.cbOperador.Properties.NullText = ""
        Me.cbOperador.Size = New System.Drawing.Size(223, 20)
        Me.cbOperador.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Operador:"
        '
        'cbOperacion
        '
        Me.cbOperacion.Location = New System.Drawing.Point(76, 78)
        Me.cbOperacion.Name = "cbOperacion"
        Me.cbOperacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOperacion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OpCode", "OpCode", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OpDesc", "OpDesc")})
        Me.cbOperacion.Properties.NullText = ""
        Me.cbOperacion.Size = New System.Drawing.Size(339, 20)
        Me.cbOperacion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Operación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Parte:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "OP:"
        '
        'eParte
        '
        Me.eParte.Location = New System.Drawing.Point(48, 44)
        Me.eParte.Name = "eParte"
        Me.eParte.Size = New System.Drawing.Size(367, 20)
        Me.eParte.TabIndex = 2
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 114)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(668, 446)
        Me.pCenter.TabIndex = 7
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(668, 446)
        Me.gCatalogo.TabIndex = 0
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        '
        'tRefrescar
        '
        Me.tRefrescar.Interval = 600000
        '
        'ProdProcesoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "ProdProcesoFrm"
        Me.Text = "Informe de Produccion en Proceso"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.eOP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOperador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbOperacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eParte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents eParte As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbOperador As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbOperacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tRefrescar As System.Windows.Forms.Timer
    Friend WithEvents eOP As DevExpress.XtraEditors.TextEdit
End Class
