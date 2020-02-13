<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatProcesosSis
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
    'Do not modify it using the code editor.ca
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eObs = New DevExpress.XtraEditors.TextEdit()
        Me.eDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eAbreviacion = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpComp = New DevExpress.XtraEditors.LookUpEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.eObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eAbreviacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpComp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.SimpleButton1)
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
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(11, 269)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(140, 35)
        Me.SimpleButton1.TabIndex = 103
        Me.SimpleButton1.Text = "&Eliminar"
        '
        'bIgnorar
        '
        Me.bIgnorar.Location = New System.Drawing.Point(11, 218)
        Me.bIgnorar.Name = "bIgnorar"
        Me.bIgnorar.Size = New System.Drawing.Size(140, 35)
        Me.bIgnorar.TabIndex = 102
        Me.bIgnorar.Text = "&Ignorar"
        '
        'bGuardar
        '
        Me.bGuardar.Location = New System.Drawing.Point(11, 168)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(140, 35)
        Me.bGuardar.TabIndex = 101
        Me.bGuardar.Text = "&Guardar"
        '
        'bNuevo
        '
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
        Me.bSalir.Location = New System.Drawing.Point(7, 163)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(140, 35)
        Me.bSalir.TabIndex = 104
        Me.bSalir.Text = "&Salir"
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.ComboBox1)
        Me.pTop.Controls.Add(Me.Label4)
        Me.pTop.Controls.Add(Me.Label3)
        Me.pTop.Controls.Add(Me.Label2)
        Me.pTop.Controls.Add(Me.Label1)
        Me.pTop.Controls.Add(Me.eObs)
        Me.pTop.Controls.Add(Me.eDesc)
        Me.pTop.Controls.Add(Me.eAbreviacion)
        Me.pTop.Controls.Add(Me.LookUpComp)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(668, 114)
        Me.pTop.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Num. Acceso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID Acceso:"
        '
        'eObs
        '
        Me.eObs.Location = New System.Drawing.Point(208, 82)
        Me.eObs.Name = "eObs"
        Me.eObs.Size = New System.Drawing.Size(270, 20)
        Me.eObs.TabIndex = 8
        '
        'eDesc
        '
        Me.eDesc.Location = New System.Drawing.Point(208, 56)
        Me.eDesc.Name = "eDesc"
        Me.eDesc.Size = New System.Drawing.Size(270, 20)
        Me.eDesc.TabIndex = 7
        '
        'eAbreviacion
        '
        Me.eAbreviacion.Location = New System.Drawing.Point(378, 30)
        Me.eAbreviacion.Name = "eAbreviacion"
        Me.eAbreviacion.Size = New System.Drawing.Size(100, 20)
        Me.eAbreviacion.TabIndex = 6
        '
        'LookUpComp
        '
        Me.LookUpComp.Location = New System.Drawing.Point(186, 30)
        Me.LookUpComp.Name = "LookUpComp"
        Me.LookUpComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpComp.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idComp", "idComp", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abreviacion", "Abreviacion", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 300, "Descripcion"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Observaciones", 300, "Observaciones")})
        Me.LookUpComp.Size = New System.Drawing.Size(152, 20)
        Me.LookUpComp.TabIndex = 5
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Módulo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Decripción:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(90, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        '
        'CatProcesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "CatProcesos"
        Me.Text = "Catalogo de Procesos"
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.eObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eAbreviacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpComp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bIgnorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents eObs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eAbreviacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpComp As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
