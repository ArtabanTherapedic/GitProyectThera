<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProRutaProceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProRutaProceso))
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.cbConstruccion = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.gDisponible = New DevExpress.XtraGrid.GridControl()
        Me.gViewD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idDisponible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Proceso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gAgregados = New DevExpress.XtraGrid.GridControl()
        Me.gViewA = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idAgregado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProcesoAdd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Orden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelFill = New System.Windows.Forms.Panel()
        Me.bDown = New DevExpress.XtraEditors.SimpleButton()
        Me.bUp = New DevExpress.XtraEditors.SimpleButton()
        Me.bDelAll = New DevExpress.XtraEditors.SimpleButton()
        Me.bAddAll = New DevExpress.XtraEditors.SimpleButton()
        Me.bDel = New DevExpress.XtraEditors.SimpleButton()
        Me.bAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelTop.SuspendLayout()
        CType(Me.cbConstruccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLeft.SuspendLayout()
        CType(Me.gDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gViewD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRight.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gAgregados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gViewA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFill.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.cbConstruccion)
        Me.PanelTop.Controls.Add(Me.LabelControl1)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(831, 51)
        Me.PanelTop.TabIndex = 0
        '
        'cbConstruccion
        '
        Me.cbConstruccion.Location = New System.Drawing.Point(122, 13)
        Me.cbConstruccion.Name = "cbConstruccion"
        Me.cbConstruccion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbConstruccion.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("idConstruccion", "id", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConstruccionDesc", "Construccion"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ConstruccionObs", "Observaciones")})
        Me.cbConstruccion.Size = New System.Drawing.Size(258, 20)
        Me.cbConstruccion.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Tipo de Construcción:"
        '
        'PanelLeft
        '
        Me.PanelLeft.Controls.Add(Me.gDisponible)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 51)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(380, 509)
        Me.PanelLeft.TabIndex = 1
        '
        'gDisponible
        '
        Me.gDisponible.Cursor = System.Windows.Forms.Cursors.Default
        Me.gDisponible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gDisponible.Location = New System.Drawing.Point(0, 0)
        Me.gDisponible.MainView = Me.gViewD
        Me.gDisponible.Name = "gDisponible"
        Me.gDisponible.Size = New System.Drawing.Size(380, 509)
        Me.gDisponible.TabIndex = 0
        Me.gDisponible.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gViewD})
        '
        'gViewD
        '
        Me.gViewD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idDisponible, Me.Proceso})
        Me.gViewD.GridControl = Me.gDisponible
        Me.gViewD.Name = "gViewD"
        Me.gViewD.OptionsCustomization.AllowGroup = False
        Me.gViewD.OptionsView.ShowGroupPanel = False
        '
        'idDisponible
        '
        Me.idDisponible.Caption = "idDisponible"
        Me.idDisponible.FieldName = "idDisponible"
        Me.idDisponible.Name = "idDisponible"
        Me.idDisponible.OptionsColumn.AllowEdit = False
        Me.idDisponible.OptionsColumn.ReadOnly = True
        '
        'Proceso
        '
        Me.Proceso.Caption = "Procesos Disponibles"
        Me.Proceso.FieldName = "ProcesoDisponible"
        Me.Proceso.Name = "Proceso"
        Me.Proceso.OptionsColumn.AllowEdit = False
        Me.Proceso.OptionsColumn.ReadOnly = True
        Me.Proceso.Visible = True
        Me.Proceso.VisibleIndex = 0
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.Panel1)
        Me.PanelRight.Controls.Add(Me.PanelFill)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Location = New System.Drawing.Point(380, 51)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(451, 509)
        Me.PanelRight.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gAgregados)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(71, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 509)
        Me.Panel1.TabIndex = 6
        '
        'gAgregados
        '
        Me.gAgregados.Cursor = System.Windows.Forms.Cursors.Default
        Me.gAgregados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gAgregados.Location = New System.Drawing.Point(0, 0)
        Me.gAgregados.MainView = Me.gViewA
        Me.gAgregados.Name = "gAgregados"
        Me.gAgregados.Size = New System.Drawing.Size(380, 509)
        Me.gAgregados.TabIndex = 2
        Me.gAgregados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gViewA})
        '
        'gViewA
        '
        Me.gViewA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idAgregado, Me.ProcesoAdd, Me.Orden})
        Me.gViewA.GridControl = Me.gAgregados
        Me.gViewA.Name = "gViewA"
        Me.gViewA.OptionsCustomization.AllowGroup = False
        Me.gViewA.OptionsView.ShowGroupPanel = False
        '
        'idAgregado
        '
        Me.idAgregado.Caption = "idAgregado"
        Me.idAgregado.FieldName = "idAgregado"
        Me.idAgregado.Name = "idAgregado"
        Me.idAgregado.OptionsColumn.AllowEdit = False
        Me.idAgregado.OptionsColumn.ReadOnly = True
        '
        'ProcesoAdd
        '
        Me.ProcesoAdd.Caption = "Procesos Agregados"
        Me.ProcesoAdd.FieldName = "ProcesoAgregado"
        Me.ProcesoAdd.Name = "ProcesoAdd"
        Me.ProcesoAdd.OptionsColumn.AllowEdit = False
        Me.ProcesoAdd.OptionsColumn.ReadOnly = True
        Me.ProcesoAdd.Visible = True
        Me.ProcesoAdd.VisibleIndex = 0
        '
        'Orden
        '
        Me.Orden.Caption = "Orden"
        Me.Orden.FieldName = "Orden"
        Me.Orden.Name = "Orden"
        '
        'PanelFill
        '
        Me.PanelFill.Controls.Add(Me.bDown)
        Me.PanelFill.Controls.Add(Me.bUp)
        Me.PanelFill.Controls.Add(Me.bDelAll)
        Me.PanelFill.Controls.Add(Me.bAddAll)
        Me.PanelFill.Controls.Add(Me.bDel)
        Me.PanelFill.Controls.Add(Me.bAdd)
        Me.PanelFill.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelFill.Location = New System.Drawing.Point(0, 0)
        Me.PanelFill.Name = "PanelFill"
        Me.PanelFill.Size = New System.Drawing.Size(71, 509)
        Me.PanelFill.TabIndex = 5
        '
        'bDown
        '
        Me.bDown.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bDown.Image = CType(resources.GetObject("bDown.Image"), System.Drawing.Image)
        Me.bDown.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.bDown.Location = New System.Drawing.Point(6, 227)
        Me.bDown.Name = "bDown"
        Me.bDown.Size = New System.Drawing.Size(59, 46)
        Me.bDown.TabIndex = 5
        Me.bDown.ToolTip = "Bajar orden del proceso"
        '
        'bUp
        '
        Me.bUp.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bUp.Image = CType(resources.GetObject("bUp.Image"), System.Drawing.Image)
        Me.bUp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.bUp.Location = New System.Drawing.Point(6, 175)
        Me.bUp.Name = "bUp"
        Me.bUp.Size = New System.Drawing.Size(59, 46)
        Me.bUp.TabIndex = 4
        Me.bUp.ToolTip = "Subir orden del proceso"
        '
        'bDelAll
        '
        Me.bDelAll.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bDelAll.Image = CType(resources.GetObject("bDelAll.Image"), System.Drawing.Image)
        Me.bDelAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.bDelAll.Location = New System.Drawing.Point(6, 435)
        Me.bDelAll.Name = "bDelAll"
        Me.bDelAll.Size = New System.Drawing.Size(59, 46)
        Me.bDelAll.TabIndex = 3
        Me.bDelAll.ToolTip = "Quitar todos los procesos"
        Me.bDelAll.Visible = False
        '
        'bAddAll
        '
        Me.bAddAll.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bAddAll.Image = CType(resources.GetObject("bAddAll.Image"), System.Drawing.Image)
        Me.bAddAll.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.bAddAll.Location = New System.Drawing.Point(6, 383)
        Me.bAddAll.Name = "bAddAll"
        Me.bAddAll.Size = New System.Drawing.Size(59, 46)
        Me.bAddAll.TabIndex = 2
        Me.bAddAll.ToolTip = "Agregar todos los procesos"
        Me.bAddAll.Visible = False
        '
        'bDel
        '
        Me.bDel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bDel.Image = CType(resources.GetObject("bDel.Image"), System.Drawing.Image)
        Me.bDel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.bDel.Location = New System.Drawing.Point(6, 123)
        Me.bDel.Name = "bDel"
        Me.bDel.Size = New System.Drawing.Size(59, 46)
        Me.bDel.TabIndex = 1
        Me.bDel.ToolTip = "Quitar proceso seleccionado"
        '
        'bAdd
        '
        Me.bAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bAdd.Image = CType(resources.GetObject("bAdd.Image"), System.Drawing.Image)
        Me.bAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.bAdd.Location = New System.Drawing.Point(6, 71)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(59, 46)
        Me.bAdd.TabIndex = 0
        Me.bAdd.ToolTip = "Agregar proceso seleccionado"
        '
        'ProRutaProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 560)
        Me.Controls.Add(Me.PanelRight)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "ProRutaProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rutas de Proceso"
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        CType(Me.cbConstruccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLeft.ResumeLayout(False)
        CType(Me.gDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gViewD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRight.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.gAgregados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gViewA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFill.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents PanelLeft As System.Windows.Forms.Panel
    Friend WithEvents gDisponible As DevExpress.XtraGrid.GridControl
    Friend WithEvents gViewD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idDisponible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Proceso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbConstruccion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PanelRight As System.Windows.Forms.Panel
    Friend WithEvents PanelFill As System.Windows.Forms.Panel
    Friend WithEvents bDown As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bDelAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAddAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bDel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gAgregados As DevExpress.XtraGrid.GridControl
    Friend WithEvents gViewA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idAgregado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProcesoAdd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Orden As DevExpress.XtraGrid.Columns.GridColumn
End Class
