<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatMedidasForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatMedidasForm))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eObs = New DevExpress.XtraEditors.TextEdit()
        Me.eDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eMedida = New DevExpress.XtraEditors.TextEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idMedida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Medida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Observaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Activo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.eObs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMedida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bEliminar)
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
        'bEliminar
        '
        Me.bEliminar.Enabled = False
        Me.bEliminar.Image = CType(resources.GetObject("bEliminar.Image"), System.Drawing.Image)
        Me.bEliminar.Location = New System.Drawing.Point(11, 269)
        Me.bEliminar.Name = "bEliminar"
        Me.bEliminar.Size = New System.Drawing.Size(140, 35)
        Me.bEliminar.TabIndex = 103
        Me.bEliminar.Text = "&Eliminar"
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
        Me.bGuardar.Enabled = False
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
        Me.bNuevo.Text = "&Nuevo"
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
        Me.pTop.Controls.Add(Me.chkActivo)
        Me.pTop.Controls.Add(Me.LabelControl3)
        Me.pTop.Controls.Add(Me.LabelControl2)
        Me.pTop.Controls.Add(Me.LabelControl1)
        Me.pTop.Controls.Add(Me.eObs)
        Me.pTop.Controls.Add(Me.eDesc)
        Me.pTop.Controls.Add(Me.eMedida)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(668, 114)
        Me.pTop.TabIndex = 6
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(200, 21)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 18
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 48)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Descripción:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Observaciones:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Medida:"
        '
        'eObs
        '
        Me.eObs.Location = New System.Drawing.Point(93, 71)
        Me.eObs.Name = "eObs"
        Me.eObs.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eObs.Size = New System.Drawing.Size(270, 20)
        Me.eObs.TabIndex = 8
        '
        'eDesc
        '
        Me.eDesc.Location = New System.Drawing.Point(93, 45)
        Me.eDesc.Name = "eDesc"
        Me.eDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eDesc.Size = New System.Drawing.Size(270, 20)
        Me.eDesc.TabIndex = 7
        '
        'eMedida
        '
        Me.eMedida.Location = New System.Drawing.Point(93, 19)
        Me.eMedida.Name = "eMedida"
        Me.eMedida.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eMedida.Properties.Mask.BeepOnError = True
        Me.eMedida.Properties.Mask.EditMask = "n0"
        Me.eMedida.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eMedida.Properties.MaxLength = 2
        Me.eMedida.Properties.ReadOnly = True
        Me.eMedida.Size = New System.Drawing.Size(100, 20)
        Me.eMedida.TabIndex = 5
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idMedida, Me.Medida, Me.Descripcion, Me.Observaciones, Me.Activo})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'idMedida
        '
        Me.idMedida.Caption = "idMedida"
        Me.idMedida.DisplayFormat.FormatString = "{0:d1}"
        Me.idMedida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.idMedida.FieldName = "idMedida"
        Me.idMedida.Name = "idMedida"
        Me.idMedida.OptionsColumn.AllowEdit = False
        Me.idMedida.OptionsColumn.ReadOnly = True
        Me.idMedida.Width = 60
        '
        'Medida
        '
        Me.Medida.Caption = "Medida"
        Me.Medida.FieldName = "CodMedida"
        Me.Medida.Name = "Medida"
        Me.Medida.OptionsColumn.AllowEdit = False
        Me.Medida.OptionsColumn.ReadOnly = True
        Me.Medida.Visible = True
        Me.Medida.VisibleIndex = 0
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripcion"
        Me.Descripcion.FieldName = "MedidaDesc"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.OptionsColumn.AllowEdit = False
        Me.Descripcion.OptionsColumn.ReadOnly = True
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 1
        Me.Descripcion.Width = 318
        '
        'Observaciones
        '
        Me.Observaciones.Caption = "Observaciones"
        Me.Observaciones.FieldName = "MedidaObs"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.OptionsColumn.AllowEdit = False
        Me.Observaciones.OptionsColumn.ReadOnly = True
        Me.Observaciones.Visible = True
        Me.Observaciones.VisibleIndex = 2
        Me.Observaciones.Width = 272
        '
        'Activo
        '
        Me.Activo.Caption = "Activo"
        Me.Activo.FieldName = "MedidaActivo"
        Me.Activo.Name = "Activo"
        Me.Activo.OptionsColumn.AllowEdit = False
        Me.Activo.OptionsColumn.ReadOnly = True
        Me.Activo.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.Activo.Visible = True
        Me.Activo.VisibleIndex = 3
        '
        'CatMedidasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "CatMedidasForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Medidas"
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.eObs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMedida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bIgnorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents eObs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eMedida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents idMedida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Observaciones As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Activo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Medida As DevExpress.XtraGrid.Columns.GridColumn
End Class
