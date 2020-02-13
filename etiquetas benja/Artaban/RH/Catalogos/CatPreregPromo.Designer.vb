<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CatPreregPromo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CatPreregPromo))
        Me.pLateral = New System.Windows.Forms.Panel()
        Me.bIgnorar = New DevExpress.XtraEditors.SimpleButton()
        Me.bGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.pCentro = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.fIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.eSueldo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.eCentroTrab = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.eEstado = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.eCiudad = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.eCP = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.eColonia = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.eDomicilio = New System.Windows.Forms.TextBox()
        Me.eEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.eCredInfo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.eCuentaB = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbEstadoCiv = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.eRFC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.eCurp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.eNoClinica = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.eIMMS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.eTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.eNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.eMaterno = New System.Windows.Forms.TextBox()
        Me.ePaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pLateral.SuspendLayout()
        Me.pCentro.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cbEstadoCiv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pLateral
        '
        Me.pLateral.Controls.Add(Me.bIgnorar)
        Me.pLateral.Controls.Add(Me.bGuardar)
        Me.pLateral.Controls.Add(Me.bNuevo)
        Me.pLateral.Dock = System.Windows.Forms.DockStyle.Right
        Me.pLateral.Location = New System.Drawing.Point(672, 0)
        Me.pLateral.Margin = New System.Windows.Forms.Padding(2)
        Me.pLateral.Name = "pLateral"
        Me.pLateral.Size = New System.Drawing.Size(157, 424)
        Me.pLateral.TabIndex = 0
        '
        'bIgnorar
        '
        Me.bIgnorar.Image = CType(resources.GetObject("bIgnorar.Image"), System.Drawing.Image)
        Me.bIgnorar.Location = New System.Drawing.Point(9, 85)
        Me.bIgnorar.Name = "bIgnorar"
        Me.bIgnorar.Size = New System.Drawing.Size(140, 33)
        Me.bIgnorar.TabIndex = 104
        Me.bIgnorar.Text = "&Ignorar"
        '
        'bGuardar
        '
        Me.bGuardar.Image = CType(resources.GetObject("bGuardar.Image"), System.Drawing.Image)
        Me.bGuardar.Location = New System.Drawing.Point(9, 47)
        Me.bGuardar.Name = "bGuardar"
        Me.bGuardar.Size = New System.Drawing.Size(140, 33)
        Me.bGuardar.TabIndex = 103
        Me.bGuardar.Text = "&Guardar"
        '
        'bNuevo
        '
        Me.bNuevo.Image = CType(resources.GetObject("bNuevo.Image"), System.Drawing.Image)
        Me.bNuevo.Location = New System.Drawing.Point(9, 8)
        Me.bNuevo.Name = "bNuevo"
        Me.bNuevo.Size = New System.Drawing.Size(140, 33)
        Me.bNuevo.TabIndex = 101
        Me.bNuevo.Text = "Nuevo"
        '
        'pCentro
        '
        Me.pCentro.Controls.Add(Me.Panel1)
        Me.pCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pCentro.Location = New System.Drawing.Point(0, 0)
        Me.pCentro.Margin = New System.Windows.Forms.Padding(2)
        Me.pCentro.Name = "pCentro"
        Me.pCentro.Size = New System.Drawing.Size(672, 424)
        Me.pCentro.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.fIngreso)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.eSueldo)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.eCentroTrab)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.eEstado)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.eCiudad)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.eCP)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.eColonia)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.eDomicilio)
        Me.Panel1.Controls.Add(Me.eEmail)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.eCredInfo)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.eCuentaB)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cbEstadoCiv)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.eRFC)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.eCurp)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.eNoClinica)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.eIMMS)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.eTelefono)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.eNombre)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.eMaterno)
        Me.Panel1.Controls.Add(Me.ePaterno)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 424)
        Me.Panel1.TabIndex = 5
        '
        'fIngreso
        '
        Me.fIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fIngreso.Location = New System.Drawing.Point(543, 267)
        Me.fIngreso.Name = "fIngreso"
        Me.fIngreso.Size = New System.Drawing.Size(100, 20)
        Me.fIngreso.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(454, 270)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 13)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Fecha de Ingreso:"
        '
        'eSueldo
        '
        Me.eSueldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eSueldo.Location = New System.Drawing.Point(323, 268)
        Me.eSueldo.Margin = New System.Windows.Forms.Padding(2)
        Me.eSueldo.Name = "eSueldo"
        Me.eSueldo.Size = New System.Drawing.Size(128, 20)
        Me.eSueldo.TabIndex = 40
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(237, 270)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 13)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Sueldo Semanal:"
        '
        'eCentroTrab
        '
        Me.eCentroTrab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eCentroTrab.Location = New System.Drawing.Point(97, 268)
        Me.eCentroTrab.Margin = New System.Windows.Forms.Padding(2)
        Me.eCentroTrab.Name = "eCentroTrab"
        Me.eCentroTrab.Size = New System.Drawing.Size(128, 20)
        Me.eCentroTrab.TabIndex = 38
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(7, 270)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 13)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Centro de Trabajo:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 243)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(195, 25)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Información laboral"
        '
        'eEstado
        '
        Me.eEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eEstado.Location = New System.Drawing.Point(97, 213)
        Me.eEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.eEstado.Name = "eEstado"
        Me.eEstado.Size = New System.Drawing.Size(128, 20)
        Me.eEstado.TabIndex = 35
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(49, 215)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 13)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "Estado:"
        '
        'eCiudad
        '
        Me.eCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eCiudad.Location = New System.Drawing.Point(515, 192)
        Me.eCiudad.Margin = New System.Windows.Forms.Padding(2)
        Me.eCiudad.Name = "eCiudad"
        Me.eCiudad.Size = New System.Drawing.Size(128, 20)
        Me.eCiudad.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(469, 194)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Ciudad:"
        '
        'eCP
        '
        Me.eCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eCP.Location = New System.Drawing.Point(323, 192)
        Me.eCP.Margin = New System.Windows.Forms.Padding(2)
        Me.eCP.Name = "eCP"
        Me.eCP.Size = New System.Drawing.Size(128, 20)
        Me.eCP.TabIndex = 31
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(249, 194)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Código Postal:"
        '
        'eColonia
        '
        Me.eColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eColonia.Location = New System.Drawing.Point(97, 192)
        Me.eColonia.Margin = New System.Windows.Forms.Padding(2)
        Me.eColonia.Name = "eColonia"
        Me.eColonia.Size = New System.Drawing.Size(128, 20)
        Me.eColonia.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(49, 194)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Colonia:"
        '
        'eDomicilio
        '
        Me.eDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eDomicilio.Location = New System.Drawing.Point(97, 172)
        Me.eDomicilio.Margin = New System.Windows.Forms.Padding(2)
        Me.eDomicilio.Name = "eDomicilio"
        Me.eDomicilio.Size = New System.Drawing.Size(546, 20)
        Me.eDomicilio.TabIndex = 27
        '
        'eEmail
        '
        Me.eEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.eEmail.Location = New System.Drawing.Point(515, 107)
        Me.eEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.eEmail.Name = "eEmail"
        Me.eEmail.Size = New System.Drawing.Size(128, 20)
        Me.eEmail.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(484, 109)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "email:"
        '
        'eCredInfo
        '
        Me.eCredInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eCredInfo.Location = New System.Drawing.Point(323, 107)
        Me.eCredInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.eCredInfo.Name = "eCredInfo"
        Me.eCredInfo.Size = New System.Drawing.Size(128, 20)
        Me.eCredInfo.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(229, 109)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "No. Cred. Infonavit:"
        '
        'eCuentaB
        '
        Me.eCuentaB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eCuentaB.Location = New System.Drawing.Point(97, 107)
        Me.eCuentaB.Margin = New System.Windows.Forms.Padding(2)
        Me.eCuentaB.Name = "eCuentaB"
        Me.eCuentaB.Size = New System.Drawing.Size(128, 20)
        Me.eCuentaB.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 109)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Cuenta Santander:"
        '
        'cbEstadoCiv
        '
        Me.cbEstadoCiv.Location = New System.Drawing.Point(515, 86)
        Me.cbEstadoCiv.Name = "cbEstadoCiv"
        Me.cbEstadoCiv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbEstadoCiv.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Estado", 100, "Estado")})
        Me.cbEstadoCiv.Size = New System.Drawing.Size(127, 20)
        Me.cbEstadoCiv.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(454, 88)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Estado Civil:"
        '
        'eRFC
        '
        Me.eRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eRFC.Location = New System.Drawing.Point(323, 86)
        Me.eRFC.Margin = New System.Windows.Forms.Padding(2)
        Me.eRFC.Name = "eRFC"
        Me.eRFC.Size = New System.Drawing.Size(128, 20)
        Me.eRFC.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(295, 88)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "RFC:"
        '
        'eCurp
        '
        Me.eCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eCurp.Location = New System.Drawing.Point(97, 86)
        Me.eCurp.Margin = New System.Windows.Forms.Padding(2)
        Me.eCurp.Name = "eCurp"
        Me.eCurp.Size = New System.Drawing.Size(128, 20)
        Me.eCurp.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 88)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "CURP:"
        '
        'eNoClinica
        '
        Me.eNoClinica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eNoClinica.Location = New System.Drawing.Point(515, 65)
        Me.eNoClinica.Margin = New System.Windows.Forms.Padding(2)
        Me.eNoClinica.Name = "eNoClinica"
        Me.eNoClinica.Size = New System.Drawing.Size(128, 20)
        Me.eNoClinica.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(459, 67)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "No. Clinica:"
        '
        'eIMMS
        '
        Me.eIMMS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eIMMS.Location = New System.Drawing.Point(323, 65)
        Me.eIMMS.Margin = New System.Windows.Forms.Padding(2)
        Me.eIMMS.Name = "eIMMS"
        Me.eIMMS.Size = New System.Drawing.Size(128, 20)
        Me.eIMMS.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(227, 67)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "No. Afiliacion IMSS:"
        '
        'eTelefono
        '
        Me.eTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eTelefono.Location = New System.Drawing.Point(97, 65)
        Me.eTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.eTelefono.Name = "eTelefono"
        Me.eTelefono.Size = New System.Drawing.Size(128, 20)
        Me.eTelefono.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(49, 67)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Domicilio"
        '
        'eNombre
        '
        Me.eNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eNombre.Location = New System.Drawing.Point(515, 44)
        Me.eNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.eNombre.Name = "eNombre"
        Me.eNombre.Size = New System.Drawing.Size(128, 20)
        Me.eNombre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 172)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Calle y numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(459, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre(s):"
        '
        'eMaterno
        '
        Me.eMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.eMaterno.Location = New System.Drawing.Point(323, 44)
        Me.eMaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.eMaterno.Name = "eMaterno"
        Me.eMaterno.Size = New System.Drawing.Size(128, 20)
        Me.eMaterno.TabIndex = 3
        '
        'ePaterno
        '
        Me.ePaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ePaterno.Location = New System.Drawing.Point(97, 44)
        Me.ePaterno.Margin = New System.Windows.Forms.Padding(2)
        Me.ePaterno.Name = "ePaterno"
        Me.ePaterno.Size = New System.Drawing.Size(128, 20)
        Me.ePaterno.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Apellido Paterno:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 19)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(295, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Datos generales del promotor"
        '
        'CatPreregPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 424)
        Me.Controls.Add(Me.pCentro)
        Me.Controls.Add(Me.pLateral)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CatPreregPromo"
        Me.Text = "Preregistro Promotoria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pLateral.ResumeLayout(False)
        Me.pCentro.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cbEstadoCiv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pLateral As System.Windows.Forms.Panel
    Friend WithEvents pCentro As System.Windows.Forms.Panel
    Friend WithEvents bNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bIgnorar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents eRFC As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents eCurp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents eNoClinica As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents eIMMS As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents eTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents eNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents eMaterno As System.Windows.Forms.TextBox
    Friend WithEvents ePaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents eCP As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents eColonia As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents eDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents eEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents eCredInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents eCuentaB As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbEstadoCiv As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents eSueldo As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents eCentroTrab As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents eEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents fIngreso As System.Windows.Forms.DateTimePicker
End Class
