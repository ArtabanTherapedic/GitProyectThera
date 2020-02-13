<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProImpEtForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProImpEtForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pLeft = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.bBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bLimpiar = New DevExpress.XtraEditors.SimpleButton()
        Me.bExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.bImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.pExit = New System.Windows.Forms.Panel()
        Me.bSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.pGral = New System.Windows.Forms.Panel()
        Me.pGrid = New System.Windows.Forms.Panel()
        Me.Preview = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEtiqueta = New System.Windows.Forms.ComboBox()
        Me.cbidArt = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbArticulo = New System.Windows.Forms.ComboBox()
        Me.eCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbOP = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbImpresora = New System.Windows.Forms.ComboBox()
        Me.LImpresion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager1 = New Artaban.CalidadDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager2 = New Artaban.CalidadDataSetTableAdapters.TableAdapterManager()
        Me.TableAdapterManager3 = New Artaban.CalidadDataSetTableAdapters.TableAdapterManager()
        Me.pLeft.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pExit.SuspendLayout()
        Me.pGral.SuspendLayout()
        Me.pGrid.SuspendLayout()
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.eCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'pLeft
        '
        Me.pLeft.Controls.Add(Me.Panel1)
        Me.pLeft.Controls.Add(Me.pExit)
        Me.pLeft.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLeft.Location = New System.Drawing.Point(774, 0)
        Me.pLeft.Name = "pLeft"
        Me.pLeft.Size = New System.Drawing.Size(163, 560)
        Me.pLeft.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bGenerar)
        Me.Panel1.Controls.Add(Me.bBuscar)
        Me.Panel1.Controls.Add(Me.bLimpiar)
        Me.Panel1.Controls.Add(Me.bExcel)
        Me.Panel1.Controls.Add(Me.bImprimir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(163, 350)
        Me.Panel1.TabIndex = 104
        '
        'bGenerar
        '
        Me.bGenerar.Image = CType(resources.GetObject("bGenerar.Image"), System.Drawing.Image)
        Me.bGenerar.Location = New System.Drawing.Point(11, 186)
        Me.bGenerar.Name = "bGenerar"
        Me.bGenerar.Size = New System.Drawing.Size(140, 35)
        Me.bGenerar.TabIndex = 111
        Me.bGenerar.Text = "&Generar Etiquetas"
        Me.bGenerar.Visible = False
        '
        'bBuscar
        '
        Me.bBuscar.Image = CType(resources.GetObject("bBuscar.Image"), System.Drawing.Image)
        Me.bBuscar.Location = New System.Drawing.Point(11, 309)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(140, 35)
        Me.bBuscar.TabIndex = 110
        Me.bBuscar.Text = "&Buscar"
        Me.bBuscar.Visible = False
        '
        'bLimpiar
        '
        Me.bLimpiar.Image = CType(resources.GetObject("bLimpiar.Image"), System.Drawing.Image)
        Me.bLimpiar.Location = New System.Drawing.Point(11, 268)
        Me.bLimpiar.Name = "bLimpiar"
        Me.bLimpiar.Size = New System.Drawing.Size(140, 35)
        Me.bLimpiar.TabIndex = 109
        Me.bLimpiar.Text = "&Limpiar"
        Me.bLimpiar.Visible = False
        '
        'bExcel
        '
        Me.bExcel.Image = CType(resources.GetObject("bExcel.Image"), System.Drawing.Image)
        Me.bExcel.Location = New System.Drawing.Point(11, 144)
        Me.bExcel.Name = "bExcel"
        Me.bExcel.Size = New System.Drawing.Size(140, 35)
        Me.bExcel.TabIndex = 108
        Me.bExcel.Text = "Generar de &Excel"
        Me.bExcel.Visible = False
        '
        'bImprimir
        '
        Me.bImprimir.Image = CType(resources.GetObject("bImprimir.Image"), System.Drawing.Image)
        Me.bImprimir.Location = New System.Drawing.Point(11, 227)
        Me.bImprimir.Name = "bImprimir"
        Me.bImprimir.Size = New System.Drawing.Size(140, 35)
        Me.bImprimir.TabIndex = 10
        Me.bImprimir.Text = "&Imprimir"
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
        'pGral
        '
        Me.pGral.Controls.Add(Me.pGrid)
        Me.pGral.Controls.Add(Me.Panel2)
        Me.pGral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pGral.Location = New System.Drawing.Point(0, 0)
        Me.pGral.Name = "pGral"
        Me.pGral.Size = New System.Drawing.Size(774, 560)
        Me.pGral.TabIndex = 8
        '
        'pGrid
        '
        Me.pGrid.Controls.Add(Me.Preview)
        Me.pGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pGrid.Location = New System.Drawing.Point(0, 131)
        Me.pGrid.Name = "pGrid"
        Me.pGrid.Size = New System.Drawing.Size(774, 429)
        Me.pGrid.TabIndex = 78
        '
        'Preview
        '
        Me.Preview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Preview.Location = New System.Drawing.Point(0, 0)
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(774, 429)
        Me.Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Preview.TabIndex = 0
        Me.Preview.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cbEtiqueta)
        Me.Panel2.Controls.Add(Me.cbidArt)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.cbArticulo)
        Me.Panel2.Controls.Add(Me.eCantidad)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.cbOP)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(774, 131)
        Me.Panel2.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Tipo de Etiqueta:"
        '
        'cbEtiqueta
        '
        Me.cbEtiqueta.FormattingEnabled = True
        Me.cbEtiqueta.Items.AddRange(New Object() {"Etiqueta de Manufactura", "Etiqueta de Medida"})
        Me.cbEtiqueta.Location = New System.Drawing.Point(293, 99)
        Me.cbEtiqueta.Name = "cbEtiqueta"
        Me.cbEtiqueta.Size = New System.Drawing.Size(301, 21)
        Me.cbEtiqueta.TabIndex = 123
        '
        'cbidArt
        '
        Me.cbidArt.Enabled = False
        Me.cbidArt.FormattingEnabled = True
        Me.cbidArt.Location = New System.Drawing.Point(71, 73)
        Me.cbidArt.Name = "cbidArt"
        Me.cbidArt.Size = New System.Drawing.Size(121, 21)
        Me.cbidArt.TabIndex = 122
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Artículo:"
        '
        'cbArticulo
        '
        Me.cbArticulo.Enabled = False
        Me.cbArticulo.FormattingEnabled = True
        Me.cbArticulo.Location = New System.Drawing.Point(198, 73)
        Me.cbArticulo.Name = "cbArticulo"
        Me.cbArticulo.Size = New System.Drawing.Size(396, 21)
        Me.cbArticulo.TabIndex = 121
        '
        'eCantidad
        '
        Me.eCantidad.Location = New System.Drawing.Point(71, 100)
        Me.eCantidad.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.eCantidad.Name = "eCantidad"
        Me.eCantidad.Size = New System.Drawing.Size(121, 21)
        Me.eCantidad.TabIndex = 119
        Me.eCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.eCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Cantidad:"
        '
        'cbOP
        '
        Me.cbOP.Enabled = False
        Me.cbOP.FormattingEnabled = True
        Me.cbOP.Location = New System.Drawing.Point(71, 46)
        Me.cbOP.Name = "cbOP"
        Me.cbOP.Size = New System.Drawing.Size(523, 21)
        Me.cbOP.TabIndex = 117
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Trabajo:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cbImpresora)
        Me.Panel3.Controls.Add(Me.LImpresion)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(774, 40)
        Me.Panel3.TabIndex = 78
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Selección de Impresora :"
        '
        'cbImpresora
        '
        Me.cbImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbImpresora.FormattingEnabled = True
        Me.cbImpresora.Location = New System.Drawing.Point(144, 10)
        Me.cbImpresora.Name = "cbImpresora"
        Me.cbImpresora.Size = New System.Drawing.Size(194, 21)
        Me.cbImpresora.TabIndex = 94
        '
        'LImpresion
        '
        Me.LImpresion.AutoSize = True
        Me.LImpresion.BackColor = System.Drawing.Color.Red
        Me.LImpresion.ForeColor = System.Drawing.Color.White
        Me.LImpresion.Location = New System.Drawing.Point(558, 13)
        Me.LImpresion.Name = "LImpresion"
        Me.LImpresion.Size = New System.Drawing.Size(210, 13)
        Me.LImpresion.TabIndex = 82
        Me.LImpresion.Text = "Generando Impresion, favor de esperar..."
        Me.LImpresion.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Fecha de Fabricacion:"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = Artaban.CalidadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = Artaban.CalidadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = Artaban.CalidadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProImpEtForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 560)
        Me.Controls.Add(Me.pGral)
        Me.Controls.Add(Me.pLeft)
        Me.Name = "ProImpEtForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLeft.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pExit.ResumeLayout(False)
        Me.pGral.ResumeLayout(False)
        Me.pGrid.ResumeLayout(False)
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.eCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pLeft As System.Windows.Forms.Panel
    Friend WithEvents pExit As System.Windows.Forms.Panel
    Friend WithEvents bSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pGral As System.Windows.Forms.Panel
    Friend WithEvents bImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents bLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pGrid As System.Windows.Forms.Panel
    Friend WithEvents LImpresion As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager1 As Artaban.CalidadDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager2 As Artaban.CalidadDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager3 As Artaban.CalidadDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cbOP As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents eCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Preview As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbEtiqueta As System.Windows.Forms.ComboBox
    Friend WithEvents cbidArt As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbImpresora As System.Windows.Forms.ComboBox
End Class
