<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepDestajosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepDestajosForm))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.FechaF = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FechaI = New DevExpress.XtraEditors.DateEdit()
        Me.cbEmpleado = New System.Windows.Forms.ComboBox()
        Me.cbIdEmp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Emplado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Area = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Color = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Operacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Foto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.FechaF.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FechaI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.bExportar)
        Me.pLeft.Controls.Add(Me.bImprimir)
        Me.pLeft.Controls.Add(Me.bGenerar)
        Me.pLeft.Controls.Add(Me.bNuevo)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(668, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 560)
        Me.pLeft.TabIndex = 5
        '
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(11, 269)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(140, 35)
        Me.bExportar.TabIndex = 103
        Me.bExportar.Text = "&Exportar"
        '
        'bImprimir
        '
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(11, 218)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(140, 35)
        Me.bImprimir.TabIndex = 102
        Me.bImprimir.Text = "&Imprimir"
        '
        'bGenerar
        '
        Me.bGenerar.Image = CType(resources.GetObject("bGenerar.Image"), System.Drawing.Image)
        Me.bGenerar.Location = New System.Drawing.Point(11, 168)
        Me.bGenerar.Name = "bGenerar"
        Me.bGenerar.Size = New System.Drawing.Size(140, 35)
        Me.bGenerar.TabIndex = 101
        Me.bGenerar.Text = "&Genear"
        '
        'bNuevo
        '
        Me.bNuevo.Image = CType(resources.GetObject("bNuevo.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(11, 120)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(140, 35)
        Me.bNuevo.TabIndex = 100
        Me.bNuevo.Text = "&Limpiar"
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
        Me.pTop.Controls.Add(Me.FechaF)
        Me.pTop.Controls.Add(Me.Label4)
        Me.pTop.Controls.Add(Me.FechaI)
        Me.pTop.Controls.Add(Me.cbEmpleado)
        Me.pTop.Controls.Add(Me.cbIdEmp)
        Me.pTop.Controls.Add(Me.Label5)
        Me.pTop.Controls.Add(Me.cbArea)
        Me.pTop.Controls.Add(Me.Label2)
        Me.pTop.Controls.Add(Me.Label1)
        Me.pTop.Controls.Add(Me.Foto)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(668, 114)
        Me.pTop.TabIndex = 6
        '
        'FechaF
        '
        Me.FechaF.EditValue = Nothing
        Me.FechaF.Location = New System.Drawing.Point(104, 86)
        Me.FechaF.Name = "FechaF"
        Me.FechaF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaF.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaF.Size = New System.Drawing.Size(100, 20)
        Me.FechaF.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Fecha Final:"
        '
        'FechaI
        '
        Me.FechaI.EditValue = Nothing
        Me.FechaI.Location = New System.Drawing.Point(104, 61)
        Me.FechaI.Name = "FechaI"
        Me.FechaI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaI.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FechaI.Size = New System.Drawing.Size(100, 20)
        Me.FechaI.TabIndex = 105
        '
        'cbEmpleado
        '
        Me.cbEmpleado.FormattingEnabled = True
        Me.cbEmpleado.Items.AddRange(New Object() {"ARMADO", "BORDADO", "CAPITONADO", "CERRADO", "CORTE", "EMBOLSADO", "PEGADO", "TAPIZADO"})
        Me.cbEmpleado.Location = New System.Drawing.Point(210, 8)
        Me.cbEmpleado.Name = "cbEmpleado"
        Me.cbEmpleado.Size = New System.Drawing.Size(315, 21)
        Me.cbEmpleado.TabIndex = 104
        '
        'cbIdEmp
        '
        Me.cbIdEmp.FormattingEnabled = True
        Me.cbIdEmp.Items.AddRange(New Object() {"ARMADO", "BORDADO", "CAPITONADO", "CERRADO", "CORTE", "EMBOLSADO", "PEGADO", "TAPIZADO"})
        Me.cbIdEmp.Location = New System.Drawing.Point(104, 8)
        Me.cbIdEmp.Name = "cbIdEmp"
        Me.cbIdEmp.Size = New System.Drawing.Size(100, 21)
        Me.cbIdEmp.TabIndex = 103
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Área: "
        '
        'cbArea
        '
        Me.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Items.AddRange(New Object() {"ARMADO", "BORDADO", "CAPITONADO", "CERRADO", "CORTE", "EMBOLSADO", "PEGADO", "TAPIZADO"})
        Me.cbArea.Location = New System.Drawing.Point(104, 34)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(153, 21)
        Me.cbArea.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fecha Inicial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "No. Empleado:"
        '
        'Foto
        '
        Me.Foto.Dock = System.Windows.Forms.DockStyle.Right
        Me.Foto.Location = New System.Drawing.Point(531, 0)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(137, 114)
        Me.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Foto.TabIndex = 9
        Me.Foto.TabStop = False
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idEmpleado, Me.Emplado, Me.Area, Me.Codigo, Me.Descripcion, Me.Color, Me.Operacion, Me.Cantidad, Me.Foto1})
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        '
        'idEmpleado
        '
        Me.idEmpleado.Caption = "No. Empleado"
        Me.idEmpleado.FieldName = "idEmpleado"
        Me.idEmpleado.Name = "idEmpleado"
        Me.idEmpleado.OptionsColumn.AllowEdit = False
        Me.idEmpleado.OptionsColumn.ReadOnly = True
        Me.idEmpleado.Visible = True
        Me.idEmpleado.VisibleIndex = 0
        '
        'Emplado
        '
        Me.Emplado.Caption = "Empleado"
        Me.Emplado.FieldName = "Empleado"
        Me.Emplado.Name = "Emplado"
        Me.Emplado.OptionsColumn.AllowEdit = False
        Me.Emplado.OptionsColumn.ReadOnly = True
        Me.Emplado.Visible = True
        Me.Emplado.VisibleIndex = 1
        '
        'Area
        '
        Me.Area.Caption = "Área"
        Me.Area.FieldName = "Area"
        Me.Area.Name = "Area"
        Me.Area.OptionsColumn.AllowEdit = False
        Me.Area.OptionsColumn.ReadOnly = True
        Me.Area.Visible = True
        Me.Area.VisibleIndex = 2
        '
        'Codigo
        '
        Me.Codigo.Caption = "Codigo"
        Me.Codigo.FieldName = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.OptionsColumn.AllowEdit = False
        Me.Codigo.OptionsColumn.ReadOnly = True
        Me.Codigo.Visible = True
        Me.Codigo.VisibleIndex = 3
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripcion"
        Me.Descripcion.FieldName = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.OptionsColumn.AllowEdit = False
        Me.Descripcion.OptionsColumn.ReadOnly = True
        Me.Descripcion.Visible = True
        Me.Descripcion.VisibleIndex = 4
        '
        'Color
        '
        Me.Color.Caption = "Color"
        Me.Color.FieldName = "Color"
        Me.Color.Name = "Color"
        Me.Color.OptionsColumn.AllowEdit = False
        Me.Color.OptionsColumn.ReadOnly = True
        Me.Color.Visible = True
        Me.Color.VisibleIndex = 5
        '
        'Operacion
        '
        Me.Operacion.Caption = "Operacion"
        Me.Operacion.FieldName = "Operacion"
        Me.Operacion.Name = "Operacion"
        Me.Operacion.OptionsColumn.AllowEdit = False
        Me.Operacion.OptionsColumn.ReadOnly = True
        Me.Operacion.Visible = True
        Me.Operacion.VisibleIndex = 6
        '
        'Cantidad
        '
        Me.Cantidad.Caption = "Cantidad"
        Me.Cantidad.FieldName = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.OptionsColumn.AllowEdit = False
        Me.Cantidad.OptionsColumn.ReadOnly = True
        Me.Cantidad.Visible = True
        Me.Cantidad.VisibleIndex = 7
        '
        'Foto1
        '
        Me.Foto1.Caption = "Foto"
        Me.Foto1.FieldName = "Foto"
        Me.Foto1.Name = "Foto1"
        Me.Foto1.OptionsColumn.AllowEdit = False
        Me.Foto1.OptionsColumn.ReadOnly = True
        '
        'RepDestajosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "RepDestajosForm"
        Me.Text = "Reporte de Destajos"
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.FechaF.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FechaI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Foto As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents idEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Emplado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Codigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Foto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Operacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FechaF As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FechaI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cbEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents cbIdEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Cantidad As DevExpress.XtraGrid.Columns.GridColumn
End Class
