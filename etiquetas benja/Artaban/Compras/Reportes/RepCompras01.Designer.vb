<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepCompras01
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
        Me.Panel01 = New System.Windows.Forms.Panel()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.grdRep01 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.bGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.sbEmpresa = New DevExpress.XtraEditors.SimpleButton()
        Me.TxTFic = New DevExpress.XtraEditors.TextEdit()
        Me.TxtSelect = New DevExpress.XtraEditors.TextEdit()
        Me.Panel01.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        CType(Me.grdRep01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        CType(Me.TxTFic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel01
        '
        Me.Panel01.Controls.Add(Me.PanelButton)
        Me.Panel01.Controls.Add(Me.PanelTop)
        Me.Panel01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel01.Location = New System.Drawing.Point(0, 0)
        Me.Panel01.Name = "Panel01"
        Me.Panel01.Size = New System.Drawing.Size(984, 561)
        Me.Panel01.TabIndex = 0
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.grdRep01)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelButton.Location = New System.Drawing.Point(0, 100)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(984, 461)
        Me.PanelButton.TabIndex = 1
        '
        'grdRep01
        '
        Me.grdRep01.Cursor = System.Windows.Forms.Cursors.Default
        Me.grdRep01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRep01.Location = New System.Drawing.Point(0, 0)
        Me.grdRep01.MainView = Me.GridView1
        Me.grdRep01.Name = "grdRep01"
        Me.grdRep01.Size = New System.Drawing.Size(984, 461)
        Me.grdRep01.TabIndex = 0
        Me.grdRep01.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdRep01
        Me.GridView1.Name = "GridView1"
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.TxtSelect)
        Me.PanelTop.Controls.Add(Me.TxTFic)
        Me.PanelTop.Controls.Add(Me.sbEmpresa)
        Me.PanelTop.Controls.Add(Me.bGenerar)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(984, 100)
        Me.PanelTop.TabIndex = 0
        '
        'bGenerar
        '
        Me.bGenerar.Location = New System.Drawing.Point(53, 69)
        Me.bGenerar.Name = "bGenerar"
        Me.bGenerar.Size = New System.Drawing.Size(75, 23)
        Me.bGenerar.TabIndex = 0
        Me.bGenerar.Text = "SimpleButton1"
        '
        'sbEmpresa
        '
        Me.sbEmpresa.Location = New System.Drawing.Point(53, 40)
        Me.sbEmpresa.Name = "sbEmpresa"
        Me.sbEmpresa.Size = New System.Drawing.Size(114, 23)
        Me.sbEmpresa.TabIndex = 1
        Me.sbEmpresa.Text = "Seleccionar Empresa"
        '
        'TxTFic
        '
        Me.TxTFic.Location = New System.Drawing.Point(190, 42)
        Me.TxTFic.Name = "TxTFic"
        Me.TxTFic.Size = New System.Drawing.Size(100, 20)
        Me.TxTFic.TabIndex = 2
        '
        'TxtSelect
        '
        Me.TxtSelect.Location = New System.Drawing.Point(316, 43)
        Me.TxtSelect.Name = "TxtSelect"
        Me.TxtSelect.Size = New System.Drawing.Size(100, 20)
        Me.TxtSelect.TabIndex = 3
        '
        'RepCompras01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Panel01)
        Me.Name = "RepCompras01"
        Me.Text = "RepCompras01"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel01.ResumeLayout(False)
        Me.PanelButton.ResumeLayout(False)
        CType(Me.grdRep01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        CType(Me.TxTFic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel01 As System.Windows.Forms.Panel
    Friend WithEvents PanelButton As System.Windows.Forms.Panel
    Friend WithEvents grdRep01 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents bGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbEmpresa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxTFic As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtSelect As DevExpress.XtraEditors.TextEdit
End Class
