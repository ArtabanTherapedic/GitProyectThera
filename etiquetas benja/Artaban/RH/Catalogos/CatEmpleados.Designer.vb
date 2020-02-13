<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatEmpleados))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.cbAreas = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbActivo = New System.Windows.Forms.CheckBox()
        Me.bFoto = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.rbHombre = New System.Windows.Forms.RadioButton()
        Me.rbMujer = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.eMaterno = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ePaterno = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.eNombre = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.eIDEmp = New DevExpress.XtraEditors.TextEdit()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Paterno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Materno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Genero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Area = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Foto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Activo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        CType(Me.cbAreas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eIDEmp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
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
        Me.pTop.Controls.Add(Me.cbAreas)
        Me.pTop.Controls.Add(Me.cbActivo)
        Me.pTop.Controls.Add(Me.bFoto)
        Me.pTop.Controls.Add(Me.Label5)
        Me.pTop.Controls.Add(Me.cbArea)
        Me.pTop.Controls.Add(Me.rbHombre)
        Me.pTop.Controls.Add(Me.rbMujer)
        Me.pTop.Controls.Add(Me.Label4)
        Me.pTop.Controls.Add(Me.eMaterno)
        Me.pTop.Controls.Add(Me.Label3)
        Me.pTop.Controls.Add(Me.ePaterno)
        Me.pTop.Controls.Add(Me.Label2)
        Me.pTop.Controls.Add(Me.eNombre)
        Me.pTop.Controls.Add(Me.Label1)
        Me.pTop.Controls.Add(Me.Foto)
        Me.pTop.Controls.Add(Me.eIDEmp)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(668, 114)
        Me.pTop.TabIndex = 6
        '
        'cbAreas
        '
        Me.cbAreas.Location = New System.Drawing.Point(308, 56)
        Me.cbAreas.Name = "cbAreas"
        Me.cbAreas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAreas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDArea", "IDArea", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Area", "Area")})
        Me.cbAreas.Properties.NullText = ""
        Me.cbAreas.Size = New System.Drawing.Size(217, 20)
        Me.cbAreas.TabIndex = 103
        '
        'cbActivo
        '
        Me.cbActivo.AutoSize = True
        Me.cbActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbActivo.Location = New System.Drawing.Point(235, 11)
        Me.cbActivo.Name = "cbActivo"
        Me.cbActivo.Size = New System.Drawing.Size(56, 17)
        Me.cbActivo.TabIndex = 102
        Me.cbActivo.Text = "Activo"
        Me.cbActivo.UseVisualStyleBackColor = True
        '
        'bFoto
        '
        Me.bFoto.Image = CType(resources.GetObject("bFoto.Image"), System.Drawing.Image)
        Me.bFoto.Location = New System.Drawing.Point(349, 83)
        Me.bFoto.Name = "bFoto"
        Me.bFoto.Size = New System.Drawing.Size(140, 25)
        Me.bFoto.TabIndex = 101
        Me.bFoto.Text = "Cambiar &Fotografía"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Área"
        '
        'cbArea
        '
        Me.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Items.AddRange(New Object() {"ARMADO", "BORDADO", "CAPITONADO", "CERRADO", "CORTE", "EMBOLSADO", "PEGADO", "TAPIZADO"})
        Me.cbArea.Location = New System.Drawing.Point(567, 55)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(217, 21)
        Me.cbArea.TabIndex = 7
        Me.cbArea.Visible = False
        '
        'rbHombre
        '
        Me.rbHombre.AutoSize = True
        Me.rbHombre.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbHombre.Location = New System.Drawing.Point(441, 4)
        Me.rbHombre.Name = "rbHombre"
        Me.rbHombre.Size = New System.Drawing.Size(48, 30)
        Me.rbHombre.TabIndex = 6
        Me.rbHombre.TabStop = True
        Me.rbHombre.Text = "Hombre"
        Me.rbHombre.UseVisualStyleBackColor = True
        '
        'rbMujer
        '
        Me.rbMujer.AutoSize = True
        Me.rbMujer.CheckAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.rbMujer.Location = New System.Drawing.Point(352, 4)
        Me.rbMujer.Name = "rbMujer"
        Me.rbMujer.Size = New System.Drawing.Size(38, 30)
        Me.rbMujer.TabIndex = 5
        Me.rbMujer.TabStop = True
        Me.rbMujer.Text = "Mujer"
        Me.rbMujer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Apellido Materno"
        '
        'eMaterno
        '
        Me.eMaterno.Location = New System.Drawing.Point(104, 86)
        Me.eMaterno.Name = "eMaterno"
        Me.eMaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eMaterno.Size = New System.Drawing.Size(187, 20)
        Me.eMaterno.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Apellido Paterno"
        '
        'ePaterno
        '
        Me.ePaterno.Location = New System.Drawing.Point(104, 60)
        Me.ePaterno.Name = "ePaterno"
        Me.ePaterno.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ePaterno.Size = New System.Drawing.Size(187, 20)
        Me.ePaterno.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre(s)"
        '
        'eNombre
        '
        Me.eNombre.Location = New System.Drawing.Point(104, 34)
        Me.eNombre.Name = "eNombre"
        Me.eNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eNombre.Size = New System.Drawing.Size(187, 20)
        Me.eNombre.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "No. Empleado"
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
        'eIDEmp
        '
        Me.eIDEmp.Location = New System.Drawing.Point(104, 10)
        Me.eIDEmp.Name = "eIDEmp"
        Me.eIDEmp.Size = New System.Drawing.Size(100, 20)
        Me.eIDEmp.TabIndex = 1
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idEmpleado, Me.Nombre, Me.Paterno, Me.Materno, Me.Genero, Me.Area, Me.Foto1, Me.Activo})
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        'Nombre
        '
        Me.Nombre.Caption = "Nombre"
        Me.Nombre.FieldName = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.OptionsColumn.AllowEdit = False
        Me.Nombre.OptionsColumn.ReadOnly = True
        Me.Nombre.Visible = True
        Me.Nombre.VisibleIndex = 1
        '
        'Paterno
        '
        Me.Paterno.Caption = "Apllido Paterno"
        Me.Paterno.FieldName = "Paterno"
        Me.Paterno.Name = "Paterno"
        Me.Paterno.OptionsColumn.AllowEdit = False
        Me.Paterno.OptionsColumn.ReadOnly = True
        Me.Paterno.Visible = True
        Me.Paterno.VisibleIndex = 2
        '
        'Materno
        '
        Me.Materno.Caption = "Apellido Materno"
        Me.Materno.FieldName = "Materno"
        Me.Materno.Name = "Materno"
        Me.Materno.OptionsColumn.AllowEdit = False
        Me.Materno.OptionsColumn.ReadOnly = True
        Me.Materno.Visible = True
        Me.Materno.VisibleIndex = 3
        '
        'Genero
        '
        Me.Genero.Caption = "Genero"
        Me.Genero.FieldName = "Genero"
        Me.Genero.Name = "Genero"
        Me.Genero.OptionsColumn.AllowEdit = False
        Me.Genero.OptionsColumn.ReadOnly = True
        Me.Genero.Visible = True
        Me.Genero.VisibleIndex = 4
        '
        'Area
        '
        Me.Area.Caption = "Área"
        Me.Area.FieldName = "Area"
        Me.Area.Name = "Area"
        Me.Area.OptionsColumn.AllowEdit = False
        Me.Area.OptionsColumn.ReadOnly = True
        Me.Area.Visible = True
        Me.Area.VisibleIndex = 5
        '
        'Foto1
        '
        Me.Foto1.Caption = "Foto"
        Me.Foto1.FieldName = "Foto"
        Me.Foto1.Name = "Foto1"
        Me.Foto1.OptionsColumn.AllowEdit = False
        Me.Foto1.OptionsColumn.ReadOnly = True
        '
        'Activo
        '
        Me.Activo.Caption = "Activo"
        Me.Activo.FieldName = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.OptionsColumn.AllowEdit = False
        Me.Activo.OptionsColumn.ReadOnly = True
        Me.Activo.Visible = True
        Me.Activo.VisibleIndex = 6
        '
        'CatEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "CatEmpleados"
        Me.Text = "Catalogo de Empleados"
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.cbAreas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eIDEmp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents bIgnorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents eIDEmp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Foto As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents eNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbHombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbMujer As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents eMaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ePaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents bFoto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbActivo As System.Windows.Forms.CheckBox
    Friend WithEvents idEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Paterno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Materno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Genero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Foto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Activo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbAreas As DevExpress.XtraEditors.LookUpEdit
End Class
