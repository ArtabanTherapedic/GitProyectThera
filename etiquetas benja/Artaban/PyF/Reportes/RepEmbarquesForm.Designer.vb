<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepEmbarquesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepEmbarquesForm))
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.bExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pTop = New System.Windows.Forms.Panel()
        Me.FFinal = New System.Windows.Forms.DateTimePicker()
        Me.FInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pCenter = New System.Windows.Forms.Panel()
        Me.gCatalogo = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NoEmbarque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Origen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Cliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Piezas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TipoEnvio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Placas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DomEntrega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IdRevision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pLeft.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pTop.SuspendLayout()
        Me.pCenter.SuspendLayout()
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.SimpleButton1)
        Me.pLeft.Controls.Add(Me.bExportar)
        Me.pLeft.Controls.Add(Me.bImprimir)
        Me.pLeft.Controls.Add(Me.bBuscar)
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
        Me.SimpleButton1.Visible = False
        '
        'bExportar
        '
        Me.bExportar.Image = CType(resources.GetObject("bExportar.Image"), System.Drawing.Image)
        Me.bExportar.Location = New System.Drawing.Point(11, 218)
        Me.bExportar.Name = "bExportar"
        Me.bExportar.Size = New System.Drawing.Size(140, 35)
        Me.bExportar.TabIndex = 102
        Me.bExportar.Text = "&Exportar"
        '
        'bImprimir
        '
        Me.bImprimir.Enabled = False
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(11, 168)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(140, 35)
        Me.bImprimir.TabIndex = 4
        Me.bImprimir.Text = "&Vista Previa"
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(11, 120)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(140, 35)
        Me.bBuscar.TabIndex = 3
        Me.bBuscar.Text = "&Buscar"
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
        Me.bSalir.TabIndex = 5
        Me.bSalir.Text = "&Salir"
        '
        'pTop
        '
        Me.pTop.Controls.Add(Me.FFinal)
        Me.pTop.Controls.Add(Me.FInicial)
        Me.pTop.Controls.Add(Me.Label2)
        Me.pTop.Controls.Add(Me.Label1)
        Me.pTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pTop.Location = New System.Drawing.Point(0, 0)
        Me.pTop.Name = "pTop"
        Me.pTop.Size = New System.Drawing.Size(668, 114)
        Me.pTop.TabIndex = 6
        '
        'FFinal
        '
        Me.FFinal.CustomFormat = "dd/MM/yyyy"
        Me.FFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FFinal.Location = New System.Drawing.Point(84, 50)
        Me.FFinal.Name = "FFinal"
        Me.FFinal.Size = New System.Drawing.Size(105, 21)
        Me.FFinal.TabIndex = 2
        '
        'FInicial
        '
        Me.FInicial.CustomFormat = "dd/MM/yyyy"
        Me.FInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FInicial.Location = New System.Drawing.Point(84, 5)
        Me.FInicial.Name = "FInicial"
        Me.FInicial.Size = New System.Drawing.Size(105, 21)
        Me.FInicial.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha Inicial"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoEmbarque, Me.Origen, Me.Cliente, Me.Piezas, Me.TipoEnvio, Me.Placas, Me.DomEntrega, Me.Fecha, Me.IdRevision})
        Me.GridView1.GridControl = Me.gCatalogo
        Me.GridView1.Name = "GridView1"
        '
        'NoEmbarque
        '
        Me.NoEmbarque.Caption = "No. Embarque"
        Me.NoEmbarque.FieldName = "NoEmbarque"
        Me.NoEmbarque.Name = "NoEmbarque"
        Me.NoEmbarque.OptionsColumn.AllowEdit = False
        Me.NoEmbarque.OptionsColumn.ReadOnly = True
        Me.NoEmbarque.Visible = True
        Me.NoEmbarque.VisibleIndex = 0
        '
        'Origen
        '
        Me.Origen.Caption = "Origen"
        Me.Origen.FieldName = "Origen"
        Me.Origen.Name = "Origen"
        Me.Origen.OptionsColumn.AllowEdit = False
        Me.Origen.OptionsColumn.ReadOnly = True
        Me.Origen.Visible = True
        Me.Origen.VisibleIndex = 1
        '
        'Cliente
        '
        Me.Cliente.Caption = "Cliente"
        Me.Cliente.FieldName = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.OptionsColumn.AllowEdit = False
        Me.Cliente.OptionsColumn.ReadOnly = True
        Me.Cliente.Visible = True
        Me.Cliente.VisibleIndex = 3
        '
        'Piezas
        '
        Me.Piezas.Caption = "Piezas"
        Me.Piezas.FieldName = "Piezas"
        Me.Piezas.Name = "Piezas"
        Me.Piezas.OptionsColumn.AllowEdit = False
        Me.Piezas.OptionsColumn.ReadOnly = True
        Me.Piezas.Visible = True
        Me.Piezas.VisibleIndex = 2
        '
        'TipoEnvio
        '
        Me.TipoEnvio.Caption = "Tipo de Envio"
        Me.TipoEnvio.FieldName = "TipoEnvio"
        Me.TipoEnvio.Name = "TipoEnvio"
        Me.TipoEnvio.OptionsColumn.AllowEdit = False
        Me.TipoEnvio.OptionsColumn.ReadOnly = True
        Me.TipoEnvio.Visible = True
        Me.TipoEnvio.VisibleIndex = 4
        '
        'Placas
        '
        Me.Placas.Caption = "Placas"
        Me.Placas.FieldName = "Placas"
        Me.Placas.Name = "Placas"
        Me.Placas.OptionsColumn.AllowEdit = False
        Me.Placas.OptionsColumn.ReadOnly = True
        Me.Placas.Visible = True
        Me.Placas.VisibleIndex = 5
        '
        'DomEntrega
        '
        Me.DomEntrega.Caption = "Domicilio de Entrega"
        Me.DomEntrega.FieldName = "DomEntrega"
        Me.DomEntrega.Name = "DomEntrega"
        Me.DomEntrega.OptionsColumn.AllowEdit = False
        Me.DomEntrega.OptionsColumn.ReadOnly = True
        Me.DomEntrega.Visible = True
        Me.DomEntrega.VisibleIndex = 6
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.FieldName = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.OptionsColumn.AllowEdit = False
        Me.Fecha.OptionsColumn.ReadOnly = True
        Me.Fecha.Visible = True
        Me.Fecha.VisibleIndex = 7
        '
        'IdRevision
        '
        Me.IdRevision.Caption = "IdRevision"
        Me.IdRevision.FieldName = "IdRevision"
        Me.IdRevision.Name = "IdRevision"
        Me.IdRevision.OptionsColumn.AllowEdit = False
        Me.IdRevision.OptionsColumn.ReadOnly = True
        '
        'RepEmbarquesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 560)
        Me.Controls.Add(Me.pCenter)
        Me.Controls.Add(Me.pTop)
        Me.Controls.Add(Me.pLeft)
        Me.KeyPreview = True
        Me.Name = "RepEmbarquesForm"
        Me.Text = "Reporte de Embarques"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLeft.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pTop.ResumeLayout(False)
        Me.pTop.PerformLayout()
        Me.pCenter.ResumeLayout(False)
        CType(Me.gCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pTop As System.Windows.Forms.Panel
    Friend WithEvents pCenter As System.Windows.Forms.Panel
    Friend WithEvents gCatalogo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents NoEmbarque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Origen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TipoEnvio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Placas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DomEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IdRevision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Piezas As DevExpress.XtraGrid.Columns.GridColumn
End Class
