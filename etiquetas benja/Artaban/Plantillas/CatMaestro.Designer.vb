<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class catMaestro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(catMaestro))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.eObs = New DevExpress.XtraEditors.TextEdit()
        Me.eDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eAbreviacion = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpComp = New DevExpress.XtraEditors.LookUpEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(11, 269)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(140, 35)
        Me.SimpleButton1.TabIndex = 103
        Me.SimpleButton1.Text = "&Eliminar"
        '
        'bIgnorar
        '
        Me.bIgnorar.Image = CType(resources.GetObject("bIgnorar.Image"), System.Drawing.Image)
        Me.bIgnorar.Location = New System.Drawing.Point(11, 218)
        Me.bIgnorar.Name = "bIgnorar"
        Me.bIgnorar.Size = New System.Drawing.Size(140, 35)
        Me.bIgnorar.TabIndex = 102
        Me.bIgnorar.Text = "&Ignorar"
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(11, 168)
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
        Me.pTop.Controls.Add(Me.LabelControl7)
        Me.pTop.Controls.Add(Me.LookUpEdit1)
        Me.pTop.Controls.Add(Me.LabelControl6)
        Me.pTop.Controls.Add(Me.TextEdit2)
        Me.pTop.Controls.Add(Me.LabelControl5)
        Me.pTop.Controls.Add(Me.TextEdit1)
        Me.pTop.Controls.Add(Me.LabelControl4)
        Me.pTop.Controls.Add(Me.LabelControl3)
        Me.pTop.Controls.Add(Me.LabelControl2)
        Me.pTop.Controls.Add(Me.LabelControl1)
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
        'eObs
        '
        Me.eObs.Location = New System.Drawing.Point(158, 58)
        Me.eObs.Name = "eObs"
        Me.eObs.Size = New System.Drawing.Size(62, 20)
        Me.eObs.TabIndex = 8
        '
        'eDesc
        '
        Me.eDesc.Location = New System.Drawing.Point(225, 88)
        Me.eDesc.Name = "eDesc"
        Me.eDesc.Size = New System.Drawing.Size(71, 20)
        Me.eDesc.TabIndex = 7
        '
        'eAbreviacion
        '
        Me.eAbreviacion.Location = New System.Drawing.Point(349, 30)
        Me.eAbreviacion.Name = "eAbreviacion"
        Me.eAbreviacion.Size = New System.Drawing.Size(257, 20)
        Me.eAbreviacion.TabIndex = 6
        '
        'LookUpComp
        '
        Me.LookUpComp.Location = New System.Drawing.Point(157, 30)
        Me.LookUpComp.Name = "LookUpComp"
        Me.LookUpComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpComp.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idComp", "idComp", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abreviacion", "Abreviacion", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 300, "Descripcion"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Observaciones", 300, "Observaciones")})
        Me.LookUpComp.Size = New System.Drawing.Size(111, 20)
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
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(115, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Código:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(115, 91)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Costo Ultima Compra:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(285, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Descripcion:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(116, 61)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Minimo:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(229, 61)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Máximo:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(271, 58)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(62, 20)
        Me.TextEdit1.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(337, 61)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Punto de Reorden:"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(434, 58)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(62, 20)
        Me.TextEdit2.TabIndex = 15
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(307, 91)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Tipo Material:"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(378, 88)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idComp", "idComp", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abreviacion", "Abreviacion", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 300, "Descripcion"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Observaciones", 300, "Observaciones")})
        Me.LookUpEdit1.Size = New System.Drawing.Size(111, 20)
        Me.LookUpEdit1.TabIndex = 17
        '
        'CatMaestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "CatMaestro"
        Me.Text = "Catalogo de Refacciones"
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
