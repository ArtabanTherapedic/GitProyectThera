<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatSupyProm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatSupyProm))
        Me.pTop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.cbEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbNoEmpleado = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pDown = New System.Windows.Forms.Panel()
        Me.pRight = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gAgragados = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColNoEmp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEmp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSueldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstatusLyra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.bQuitar = New DevExpress.XtraEditors.SimpleButton()
        Me.bAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.gDisponibles = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNoEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.pTop.SuspendLayout()
        CType(Me.cbEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbNoEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pDown.SuspendLayout()
        Me.pRight.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.gAgragados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        Me.pLeft.SuspendLayout()
        CType(Me.gDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.Label2)
        Me.pTop.Controls.Add(Me.Label1)
        Me.pTop.Controls.Add(Me.bBuscar)
        Me.pTop.Controls.Add(Me.cbEmpleado)
        Me.pTop.Controls.Add(Me.cbNoEmpleado)
        Me.pTop.Controls.Add(Me.Label5)
        Me.pTop.Controls.Add(Me.Label4)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(870, 79)
        Me.pTop.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(453, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Promotores Agregados:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Promotores Disponibles:"
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(412, 12)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(104, 44)
        Me.bBuscar.TabIndex = 108
        Me.bBuscar.Text = "&Buscar"
        '
        'cbEmpleado
        '
        Me.cbEmpleado.Location = New System.Drawing.Point(91, 36)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(315, 20)
        Me.cbEmpleado.TabIndex = 24
        '
        'cbNoEmpleado
        '
        Me.cbNoEmpleado.Location = New System.Drawing.Point(91, 13)
        Me.cbNoEmpleado.Name = "cbNoEmpleado"
        Me.cbNoEmpleado.Size = New System.Drawing.Size(315, 20)
        Me.cbNoEmpleado.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Supervisor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "No. Empleado:"
        '
        'pDown
        '
        Me.pDown.Controls.Add(Me.pRight)
        Me.pDown.Controls.Add(Me.pCenter)
        Me.pDown.Controls.Add(Me.pLeft)
        Me.pDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pDown.Location = New System.Drawing.Point(0, 79)
        Me.pDown.Name = "pDown"
        Me.pDown.Size = New System.Drawing.Size(870, 495)
        Me.pDown.TabIndex = 1
        '
        'pRight
        '
        Me.pRight.Controls.Add(Me.Panel1)
        Me.pRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pRight.Location = New System.Drawing.Point(456, 0)
        Me.pRight.Name = "pRight"
        Me.pRight.Size = New System.Drawing.Size(414, 495)
        Me.pRight.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gAgragados)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 495)
        Me.Panel1.TabIndex = 4
        '
        'gAgragados
        '
        Me.gAgragados.Cursor = System.Windows.Forms.Cursors.Default
        Me.gAgragados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gAgragados.Location = New System.Drawing.Point(0, 0)
        Me.gAgragados.MainView = Me.GridView2
        Me.gAgragados.Name = "gAgragados"
        Me.gAgragados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit2})
        Me.gAgragados.Size = New System.Drawing.Size(414, 495)
        Me.gAgragados.TabIndex = 2
        Me.gAgragados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNoEmp, Me.ColEmp, Me.ColSueldo, Me.ColEstatus, Me.colEstatusLyra})
        Me.GridView2.GridControl = Me.gAgragados
        Me.GridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'ColNoEmp
        '
        Me.ColNoEmp.Caption = "No Empleado"
        Me.ColNoEmp.FieldName = "IDEmp"
        Me.ColNoEmp.Name = "ColNoEmp"
        Me.ColNoEmp.OptionsColumn.AllowEdit = False
        Me.ColNoEmp.OptionsColumn.AllowFocus = False
        Me.ColNoEmp.Visible = True
        Me.ColNoEmp.VisibleIndex = 0
        '
        'ColEmp
        '
        Me.ColEmp.Caption = "Empleado"
        Me.ColEmp.FieldName = "Empleado"
        Me.ColEmp.Name = "ColEmp"
        Me.ColEmp.OptionsColumn.AllowEdit = False
        Me.ColEmp.OptionsColumn.AllowFocus = False
        Me.ColEmp.Visible = True
        Me.ColEmp.VisibleIndex = 1
        Me.ColEmp.Width = 252
        '
        'ColSueldo
        '
        Me.ColSueldo.Caption = "Sueldo Diario"
        Me.ColSueldo.DisplayFormat.FormatString = "c2"
        Me.ColSueldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColSueldo.FieldName = "Sueldo"
        Me.ColSueldo.Name = "ColSueldo"
        Me.ColSueldo.Visible = True
        Me.ColSueldo.VisibleIndex = 2
        '
        'ColEstatus
        '
        Me.ColEstatus.Caption = "Estatus"
        Me.ColEstatus.FieldName = "Estatus"
        Me.ColEstatus.Name = "ColEstatus"
        Me.ColEstatus.Visible = True
        Me.ColEstatus.VisibleIndex = 3
        Me.ColEstatus.Width = 46
        '
        'colEstatusLyra
        '
        Me.colEstatusLyra.Caption = "Estatus Lyra"
        Me.colEstatusLyra.FieldName = "EstatusLyra"
        Me.colEstatusLyra.Name = "colEstatusLyra"
        Me.colEstatusLyra.OptionsColumn.AllowEdit = False
        Me.colEstatusLyra.OptionsColumn.AllowFocus = False
        Me.colEstatusLyra.Visible = True
        Me.colEstatusLyra.VisibleIndex = 4
        Me.colEstatusLyra.Width = 120
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Mask.EditMask = ""
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.Mask.EditMask = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.bQuitar)
        Me.pCenter.Controls.Add(Me.bAgregar)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Left
        Me.pCenter.Location = New System.Drawing.Point(378, 0)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(78, 495)
        Me.pCenter.TabIndex = 1
        '
        'bQuitar
        '
        Me.bQuitar.Image = CType(resources.GetObject("bQuitar.Image"), System.Drawing.Image)
        Me.bQuitar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.bQuitar.Location = New System.Drawing.Point(6, 141)
        Me.bQuitar.Name = "bQuitar"
        Me.bQuitar.Size = New System.Drawing.Size(65, 56)
        Me.bQuitar.TabIndex = 108
        '
        'bAgregar
        '
        Me.bAgregar.Image = CType(resources.GetObject("bAgregar.Image"), System.Drawing.Image)
        Me.bAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.bAgregar.Location = New System.Drawing.Point(6, 79)
        Me.bAgregar.Name = "bAgregar"
        Me.bAgregar.Size = New System.Drawing.Size(65, 56)
        Me.bAgregar.TabIndex = 107
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.gDisponibles)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pLeft.Location = New System.Drawing.Point(0, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(378, 495)
        Me.pLeft.TabIndex = 0
        '
        'gDisponibles
        '
        Me.gDisponibles.Cursor = System.Windows.Forms.Cursors.Default
        Me.gDisponibles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gDisponibles.Location = New System.Drawing.Point(0, 0)
        Me.gDisponibles.MainView = Me.GridView1
        Me.gDisponibles.Name = "gDisponibles"
        Me.gDisponibles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.gDisponibles.Size = New System.Drawing.Size(378, 495)
        Me.gDisponibles.TabIndex = 1
        Me.gDisponibles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoEmpleado, Me.colEmpleado})
        Me.GridView1.GridControl = Me.gDisponibles
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colNoEmpleado
        '
        Me.colNoEmpleado.Caption = "NoEmpleado"
        Me.colNoEmpleado.FieldName = "NoEmp"
        Me.colNoEmpleado.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colNoEmpleado.Name = "colNoEmpleado"
        Me.colNoEmpleado.OptionsColumn.AllowEdit = False
        Me.colNoEmpleado.OptionsColumn.AllowFocus = False
        Me.colNoEmpleado.Visible = True
        Me.colNoEmpleado.VisibleIndex = 0
        Me.colNoEmpleado.Width = 73
        '
        'colEmpleado
        '
        Me.colEmpleado.Caption = "Empleado"
        Me.colEmpleado.FieldName = "Empleado"
        Me.colEmpleado.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colEmpleado.Name = "colEmpleado"
        Me.colEmpleado.OptionsColumn.AllowEdit = False
        Me.colEmpleado.OptionsColumn.AllowFocus = False
        Me.colEmpleado.Visible = True
        Me.colEmpleado.VisibleIndex = 1
        Me.colEmpleado.Width = 281
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.[True]
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Mask.EditMask = ""
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy HH:mm"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'CatSupyProm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 574)
        Me.Controls.Add(Me.pDown)
        Me.Controls.Add(Me.pTop)
        Me.Name = "CatSupyProm"
        Me.Text = "Catalogo de Supervisores y Promotores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.cbEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbNoEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pDown.ResumeLayout(False)
        Me.pRight.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.gAgragados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        Me.pLeft.ResumeLayout(False)
        CType(Me.gDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents pDown As System.Windows.Forms.Panel
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents pRight As System.Windows.Forms.Panel
    Friend WithEvents bQuitar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbNoEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gDisponibles As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNoEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gAgragados As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNoEmp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEmp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents ColSueldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColEstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstatusLyra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
