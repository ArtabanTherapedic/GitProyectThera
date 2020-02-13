<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProFiniquitos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProFiniquitos))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bSend = New DevExpress.XtraEditors.SimpleButton()
        Me.bImpContrato = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eObs = New DevExpress.XtraEditors.TextEdit()
        Me.eDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eAbreviacion = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpComp = New DevExpress.XtraEditors.LookUpEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NoPromotor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Promotor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pLeft.Controls.Add(Me.bSend)
        Me.pLeft.Controls.Add(Me.bImpContrato)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(1002, 0)
        Me.pLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(244, 818)
        Me.pLeft.TabIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(16, 393)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(210, 51)
        Me.SimpleButton1.TabIndex = 103
        Me.SimpleButton1.Text = "&Eliminar"
        Me.SimpleButton1.Visible = False
        '
        'bIgnorar
        '
        Me.bIgnorar.Image = CType(resources.GetObject("bIgnorar.Image"), System.Drawing.Image)
        Me.bIgnorar.Location = New System.Drawing.Point(16, 319)
        Me.bIgnorar.Margin = New System.Windows.Forms.Padding(4)
        Me.bIgnorar.Name = "bIgnorar"
        Me.bIgnorar.Size = New System.Drawing.Size(210, 51)
        Me.bIgnorar.TabIndex = 102
        Me.bIgnorar.Text = "&Ignorar"
        Me.bIgnorar.Visible = False
        '
        'bSend
        '
        Me.bSend.Image = CType(resources.GetObject("bSend.Image"), System.Drawing.Image)
        Me.bSend.Location = New System.Drawing.Point(16, 246)
        Me.bSend.Margin = New System.Windows.Forms.Padding(4)
        Me.bSend.Name = "bSend"
        Me.bSend.Size = New System.Drawing.Size(210, 51)
        Me.bSend.TabIndex = 101
        Me.bSend.Text = "&Envia por email"
        '
        'bImpContrato
        '
        Me.bImpContrato.Image = CType(resources.GetObject("bImpContrato.Image"), System.Drawing.Image)
        Me.bImpContrato.Location = New System.Drawing.Point(16, 175)
        Me.bImpContrato.Margin = New System.Windows.Forms.Padding(4)
        Me.bImpContrato.Name = "bImpContrato"
        Me.bImpContrato.Size = New System.Drawing.Size(210, 51)
        Me.bImpContrato.TabIndex = 100
        Me.bImpContrato.Text = "Imprime &Contrato"
        '
        'pExit
        '
        Me.pExit.Controls.Add(Me.bSalir)
        Me.pExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pExit.Location = New System.Drawing.Point(0, 511)
        Me.pExit.Margin = New System.Windows.Forms.Padding(4)
        Me.pExit.Name = "pExit"
        Me.pExit.Size = New System.Drawing.Size(244, 307)
        Me.pExit.TabIndex = 1
        '
        'bSalir
        '
        Me.bSalir.Image = CType(resources.GetObject("bSalir.Image"), System.Drawing.Image)
        Me.bSalir.Location = New System.Drawing.Point(10, 238)
        Me.bSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.bSalir.Name = "bSalir"
        Me.bSalir.Size = New System.Drawing.Size(210, 51)
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
        Me.pTop.Margin = New System.Windows.Forms.Padding(4)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(1002, 167)
        Me.pTop.TabIndex = 6
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(460, 133)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(98, 19)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Tipo Material:"
        Me.LabelControl7.Visible = False
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(567, 129)
        Me.LookUpEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idComp", "idComp", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abreviacion", "Abreviacion", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 300, "Descripcion"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Observaciones", 300, "Observaciones")})
        Me.LookUpEdit1.Size = New System.Drawing.Size(166, 26)
        Me.LookUpEdit1.TabIndex = 17
        Me.LookUpEdit1.Visible = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(506, 89)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(133, 19)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "Punto de Reorden:"
        Me.LabelControl6.Visible = False
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(651, 85)
        Me.TextEdit2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(93, 26)
        Me.TextEdit2.TabIndex = 15
        Me.TextEdit2.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(344, 89)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 19)
        Me.LabelControl5.TabIndex = 14
        Me.LabelControl5.Text = "Máximo:"
        Me.LabelControl5.Visible = False
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(406, 85)
        Me.TextEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(93, 26)
        Me.TextEdit1.TabIndex = 13
        Me.TextEdit1.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(174, 89)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Minimo:"
        Me.LabelControl4.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(428, 48)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Descripcion:"
        Me.LabelControl3.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(172, 133)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(158, 19)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Costo Ultima Compra:"
        Me.LabelControl2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(172, 48)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Código:"
        Me.LabelControl1.Visible = False
        '
        'eObs
        '
        Me.eObs.Location = New System.Drawing.Point(237, 85)
        Me.eObs.Margin = New System.Windows.Forms.Padding(4)
        Me.eObs.Name = "eObs"
        Me.eObs.Size = New System.Drawing.Size(93, 26)
        Me.eObs.TabIndex = 8
        Me.eObs.Visible = False
        '
        'eDesc
        '
        Me.eDesc.Location = New System.Drawing.Point(338, 129)
        Me.eDesc.Margin = New System.Windows.Forms.Padding(4)
        Me.eDesc.Name = "eDesc"
        Me.eDesc.Size = New System.Drawing.Size(106, 26)
        Me.eDesc.TabIndex = 7
        Me.eDesc.Visible = False
        '
        'eAbreviacion
        '
        Me.eAbreviacion.Location = New System.Drawing.Point(524, 44)
        Me.eAbreviacion.Margin = New System.Windows.Forms.Padding(4)
        Me.eAbreviacion.Name = "eAbreviacion"
        Me.eAbreviacion.Size = New System.Drawing.Size(386, 26)
        Me.eAbreviacion.TabIndex = 6
        Me.eAbreviacion.Visible = False
        '
        'LookUpComp
        '
        Me.LookUpComp.Location = New System.Drawing.Point(236, 44)
        Me.LookUpComp.Margin = New System.Windows.Forms.Padding(4)
        Me.LookUpComp.Name = "LookUpComp"
        Me.LookUpComp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpComp.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idComp", "idComp", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Abreviacion", "Abreviacion", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 300, "Descripcion"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Observaciones", 300, "Observaciones")})
        Me.LookUpComp.Size = New System.Drawing.Size(166, 26)
        Me.LookUpComp.TabIndex = 5
        Me.LookUpComp.Visible = False
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 167)
        Me.pCenter.Margin = New System.Windows.Forms.Padding(4)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(1002, 651)
        Me.pCenter.TabIndex = 7
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Margin = New System.Windows.Forms.Padding(4)
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.Size = New System.Drawing.Size(1002, 651)
        Me.gCatalogo.TabIndex = 0
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoPromotor, Me.Promotor})
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        '
        'NoPromotor
        '
        Me.NoPromotor.Caption = "NoPromotor"
        Me.NoPromotor.FieldName = "NoPromotor"
        Me.NoPromotor.Name = "NoPromotor"
        Me.NoPromotor.OptionsColumn.AllowEdit = False
        Me.NoPromotor.OptionsColumn.ReadOnly = True
        Me.NoPromotor.Visible = True
        Me.NoPromotor.VisibleIndex = 0
        Me.NoPromotor.Width = 65
        '
        'Promotor
        '
        Me.Promotor.Caption = "Promotor"
        Me.Promotor.FieldName = "Promotor"
        Me.Promotor.Name = "Promotor"
        Me.Promotor.OptionsColumn.AllowEdit = False
        Me.Promotor.OptionsColumn.ReadOnly = True
        Me.Promotor.Visible = True
        Me.Promotor.VisibleIndex = 1
        Me.Promotor.Width = 585
        '
        'ProFiniquitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 818)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ProFiniquitos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finiquito Promotoria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents bSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bImpContrato As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents NoPromotor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Promotor As DevExpress.XtraGrid.Columns.GridColumn
End Class
