<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrenomProm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrenomProm))
        Me.pTop = New System.Windows.Forms.Panel()
        Me.bCierreP = New DevExpress.XtraEditors.SimpleButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBp = New System.Windows.Forms.NumericUpDown()
        Me.CBe = New System.Windows.Forms.NumericUpDown()
        Me.lPeriodo = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNoEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NoCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.D1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbInsidencia = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.D2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.D3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.D4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.D5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.D6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.D7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Sueldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Comisiones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PerTot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sDiario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pTop.SuspendLayout()
        CType(Me.CBp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbInsidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.bCierreP)
        Me.pTop.Controls.Add(Me.Label8)
        Me.pTop.Controls.Add(Me.Label7)
        Me.pTop.Controls.Add(Me.Label6)
        Me.pTop.Controls.Add(Me.Label5)
        Me.pTop.Controls.Add(Me.Label4)
        Me.pTop.Controls.Add(Me.Label1)
        Me.pTop.Controls.Add(Me.CBp)
        Me.pTop.Controls.Add(Me.CBe)
        Me.pTop.Controls.Add(Me.lPeriodo)
        Me.pTop.Controls.Add(Me.label3)
        Me.pTop.Controls.Add(Me.Label2)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.ForeColor = System.Drawing.Color.Black
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(917, 85)
        Me.pTop.TabIndex = 0
        '
        'bCierreP
        '
        Me.bCierreP.Enabled = False
        Me.bCierreP.Image = CType(resources.GetObject("bCierreP.Image"), System.Drawing.Image)
        Me.bCierreP.Location = New System.Drawing.Point(546, 17)
        Me.bCierreP.Name = "bCierreP"
        Me.bCierreP.Size = New System.Drawing.Size(140, 56)
        Me.bCierreP.TabIndex = 106
        Me.bCierreP.Text = "&Cerrar el Periodo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.DimGray
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(380, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "        BAJA = BAJ         "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(380, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = " INCAPACIDAD = INC "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SkyBlue
        Me.Label6.Location = New System.Drawing.Point(380, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = " VACACIONES = VAC "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(264, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "   PERMISO S/S = P   "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(264, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "          FALTA = F         "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(264, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "     ASISTENCIA = X    "
        '
        'CBp
        '
        Me.CBp.Location = New System.Drawing.Point(179, 16)
        Me.CBp.Name = "CBp"
        Me.CBp.Size = New System.Drawing.Size(60, 20)
        Me.CBp.TabIndex = 12
        '
        'CBe
        '
        Me.CBe.Location = New System.Drawing.Point(69, 17)
        Me.CBe.Name = "CBe"
        Me.CBe.Size = New System.Drawing.Size(61, 20)
        Me.CBe.TabIndex = 11
        '
        'lPeriodo
        '
        Me.lPeriodo.AutoSize = True
        Me.lPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPeriodo.Location = New System.Drawing.Point(261, 12)
        Me.lPeriodo.Name = "lPeriodo"
        Me.lPeriodo.Size = New System.Drawing.Size(224, 17)
        Me.lPeriodo.TabIndex = 10
        Me.lPeriodo.Text = "Del 01/01/2017 al 01/01/2017"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(126, 17)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(46, 13)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Periodo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ejercicio:"
        '
        'pCenter
        '
        Me.pCenter.Controls.Add(Me.gCatalogo)
        Me.pCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCenter.Location = New System.Drawing.Point(0, 85)
        Me.pCenter.Name = "pCenter"
        Me.pCenter.Size = New System.Drawing.Size(917, 462)
        Me.pCenter.TabIndex = 1
        '
        'gCatalogo
        '
        Me.gCatalogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.gCatalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gCatalogo.Location = New System.Drawing.Point(0, 0)
        Me.gCatalogo.MainView = Me.GridView1
        Me.gCatalogo.Name = "gCatalogo"
        Me.gCatalogo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbInsidencia})
        Me.gCatalogo.Size = New System.Drawing.Size(917, 462)
        Me.gCatalogo.TabIndex = 1
        Me.gCatalogo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoEmpleado, Me.colEmpleado, Me.NoCuenta, Me.D1, Me.D2, Me.D3, Me.D4, Me.D5, Me.D6, Me.D7, Me.Sueldo, Me.Comisiones, Me.PerTot, Me.sDiario})
        Me.GridView1.GridControl = Me.gCatalogo
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
        Me.colNoEmpleado.OptionsColumn.ReadOnly = True
        Me.colNoEmpleado.Visible = True
        Me.colNoEmpleado.VisibleIndex = 0
        Me.colNoEmpleado.Width = 70
        '
        'colEmpleado
        '
        Me.colEmpleado.Caption = "Promotor"
        Me.colEmpleado.FieldName = "Promotor"
        Me.colEmpleado.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.colEmpleado.Name = "colEmpleado"
        Me.colEmpleado.OptionsColumn.AllowEdit = False
        Me.colEmpleado.OptionsColumn.AllowFocus = False
        Me.colEmpleado.OptionsColumn.ReadOnly = True
        Me.colEmpleado.Visible = True
        Me.colEmpleado.VisibleIndex = 1
        Me.colEmpleado.Width = 230
        '
        'NoCuenta
        '
        Me.NoCuenta.Caption = "No.Cuenta"
        Me.NoCuenta.FieldName = "NoCuenta"
        Me.NoCuenta.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.NoCuenta.Name = "NoCuenta"
        Me.NoCuenta.OptionsColumn.AllowEdit = False
        Me.NoCuenta.OptionsColumn.AllowFocus = False
        Me.NoCuenta.OptionsColumn.ReadOnly = True
        Me.NoCuenta.Visible = True
        Me.NoCuenta.VisibleIndex = 2
        Me.NoCuenta.Width = 100
        '
        'D1
        '
        Me.D1.Caption = "MIE"
        Me.D1.ColumnEdit = Me.cbInsidencia
        Me.D1.FieldName = "D1"
        Me.D1.Name = "D1"
        Me.D1.Visible = True
        Me.D1.VisibleIndex = 3
        Me.D1.Width = 50
        '
        'cbInsidencia
        '
        Me.cbInsidencia.AutoHeight = False
        Me.cbInsidencia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbInsidencia.Items.AddRange(New Object() {"", "X", "F", "P", "VAC", "INC", "BAJ"})
        Me.cbInsidencia.Name = "cbInsidencia"
        Me.cbInsidencia.UseReadOnlyAppearance = False
        Me.cbInsidencia.ValidateOnEnterKey = True
        '
        'D2
        '
        Me.D2.Caption = "JUE"
        Me.D2.ColumnEdit = Me.cbInsidencia
        Me.D2.FieldName = "D2"
        Me.D2.Name = "D2"
        Me.D2.Visible = True
        Me.D2.VisibleIndex = 4
        Me.D2.Width = 50
        '
        'D3
        '
        Me.D3.Caption = "VIE"
        Me.D3.ColumnEdit = Me.cbInsidencia
        Me.D3.FieldName = "D3"
        Me.D3.Name = "D3"
        Me.D3.Visible = True
        Me.D3.VisibleIndex = 5
        Me.D3.Width = 50
        '
        'D4
        '
        Me.D4.Caption = "SAB"
        Me.D4.ColumnEdit = Me.cbInsidencia
        Me.D4.FieldName = "D4"
        Me.D4.Name = "D4"
        Me.D4.Visible = True
        Me.D4.VisibleIndex = 6
        Me.D4.Width = 50
        '
        'D5
        '
        Me.D5.Caption = "DOM"
        Me.D5.ColumnEdit = Me.cbInsidencia
        Me.D5.FieldName = "D5"
        Me.D5.Name = "D5"
        Me.D5.Visible = True
        Me.D5.VisibleIndex = 7
        Me.D5.Width = 50
        '
        'D6
        '
        Me.D6.Caption = "LUN"
        Me.D6.ColumnEdit = Me.cbInsidencia
        Me.D6.FieldName = "D6"
        Me.D6.Name = "D6"
        Me.D6.Visible = True
        Me.D6.VisibleIndex = 8
        Me.D6.Width = 50
        '
        'D7
        '
        Me.D7.Caption = "MAR"
        Me.D7.ColumnEdit = Me.cbInsidencia
        Me.D7.FieldName = "D7"
        Me.D7.Name = "D7"
        Me.D7.Visible = True
        Me.D7.VisibleIndex = 9
        Me.D7.Width = 50
        '
        'Sueldo
        '
        Me.Sueldo.Caption = "Sueldo"
        Me.Sueldo.DisplayFormat.FormatString = "c2"
        Me.Sueldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Sueldo.FieldName = "Sueldo"
        Me.Sueldo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.Sueldo.Name = "Sueldo"
        Me.Sueldo.OptionsColumn.AllowEdit = False
        Me.Sueldo.OptionsColumn.AllowFocus = False
        Me.Sueldo.OptionsColumn.ReadOnly = True
        Me.Sueldo.Visible = True
        Me.Sueldo.VisibleIndex = 11
        Me.Sueldo.Width = 100
        '
        'Comisiones
        '
        Me.Comisiones.Caption = "Comisiones"
        Me.Comisiones.DisplayFormat.FormatString = "c2"
        Me.Comisiones.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Comisiones.FieldName = "Comisiones"
        Me.Comisiones.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.Comisiones.Name = "Comisiones"
        Me.Comisiones.Visible = True
        Me.Comisiones.VisibleIndex = 10
        Me.Comisiones.Width = 100
        '
        'PerTot
        '
        Me.PerTot.Caption = "Total"
        Me.PerTot.DisplayFormat.FormatString = "c2"
        Me.PerTot.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PerTot.FieldName = "PerTot"
        Me.PerTot.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.PerTot.Name = "PerTot"
        Me.PerTot.OptionsColumn.AllowEdit = False
        Me.PerTot.OptionsColumn.AllowFocus = False
        Me.PerTot.OptionsColumn.ReadOnly = True
        Me.PerTot.Visible = True
        Me.PerTot.VisibleIndex = 12
        '
        'sDiario
        '
        Me.sDiario.Caption = "Sueldo Diario"
        Me.sDiario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sDiario.FieldName = "SDiario"
        Me.sDiario.Name = "sDiario"
        '
        'PrenomProm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 547)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Name = "PrenomProm"
        Me.Text = "Prenomina Promotoria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        CType(Me.CBp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbInsidencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents lPeriodo As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNoEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NoCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Sueldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Comisiones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CBp As System.Windows.Forms.NumericUpDown
    Friend WithEvents CBe As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbInsidencia As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sDiario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bCierreP As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PerTot As DevExpress.XtraGrid.Columns.GridColumn
End Class
