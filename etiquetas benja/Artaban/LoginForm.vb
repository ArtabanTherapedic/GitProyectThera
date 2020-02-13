Public Class LoginForm

    Private Sub bIngresar_Click(sender As System.Object, e As System.EventArgs) Handles bIngresar.Click
        Dim txtEmpresa = ""
        If eUsuario.Text = "" Then
            MsgBox(Msj00014, MsgBoxStyle.Critical, Empresa & " Msj00014")
            eUsuario.Focus()
            Exit Sub
        End If
        If eClave.Text = "" Then
            MsgBox(Msj00015, MsgBoxStyle.Critical, Empresa & " Msj00015")
            eClave.Focus()
            Exit Sub
        End If 
        If cbEmpresa.Text = "" Then
            MsgBox(Msj00066, MsgBoxStyle.Critical, Empresa & "Msj00066")
            cbEmpresa.Focus()
            Exit Sub
        End If
        Select Case cbEmpresa.SelectedIndex
            Case 0
                DatosCon.DataBase = "Artaban"
                DatosCon.dbUser = "sa"
                DatosCon.dbPW = "saArtabanE10"
                DatosCon.Server = "epicor01\Epicordb"
                txtEmpresa = "Artaban Internacional"
            Case 1
                DatosCon.DataBase = "Therapedic"
                DatosCon.dbUser = "sa"
                DatosCon.dbPW = "saArtabanE10"
                DatosCon.Server = "epicor01\Epicordb"
                txtEmpresa = "Artaban Therapedic"
            Case 2
                DatosCon.DataBase = "Therapedic"
                DatosCon.dbUser = "sa"
                DatosCon.dbPW = "saArtabanE10"
                DatosCon.Server = "epicor01\Epicordb"
                txtEmpresa = "Metalicos"
            Case 3
                DatosCon.DataBase = "Therapedic"
                DatosCon.dbUser = "sa"
                DatosCon.dbPW = "saArtabanE10"
                DatosCon.Server = "epicor01\Epicordb"
                txtEmpresa = "FoamArt"
        End Select
        Empresa = txtEmpresa
        'DataBase = "Calidad"
        'dbUser = "sa"
        'dbPW = "@rt@b@n2o7o"
        'Server = "SYSTEMAS\SQLEXPRESS2012"

        'If GetDatos() = False Then Exit Sub
        DatosConexion()
        If Acceso(eUsuario.Text, eClave.Text) = True Then
            'Dim FrmMain As New FrmMain
            Usuario = eUsuario.Text
            UsEmpresa = txtEmpresa
            FrmMain.Icon = Me.Icon
            FrmMain.Text = "Artaban Internacional v." & Me.ProductVersion.ToString + " " + txtEmpresa
            FrmMain.Show()
            Me.Hide()
            'FrmMain.ShowDialog(Me)
            'Me.Close()
        End If
        'If Acceso = False Then
        '    MsgBox(Msj00016, MsgBoxStyle.Critical, Empresa & "Msj00016")
        '    eUsuario.Focus()
        '    Exit Sub
        'End If
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        If eUsuario.Text = "Administrador" And eClave.Text = "@rt@b@n" Then
            Dim dbForm As New DatosDBForm
            dbForm.Icon = Me.Icon
            Me.Hide()
            dbForm.ShowDialog(Me)
            Application.Restart()
            Me.Close()
        Else
            Close()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Artaban Internacional v." & Me.ProductVersion.ToString
        eUsuario.Focus()
    End Sub

    Private Sub eUsuario_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eUsuario.KeyPress
        Tab(e)
    End Sub

    Private Sub eClave_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eClave.KeyPress
        If e.KeyChar = Chr(13) And (eUsuario.Text = "EMBOLSADO" Or UCase(eUsuario.Text) = "EMBOLSADO1" Or UCase(eUsuario.Text) = "EMBOLSADO2" Or UCase(eUsuario.Text) = "EMBOLSADO3" Or UCase(eUsuario.Text) = "EMBOLSADOB" Or UCase(eUsuario.Text) = "EMBOLSADOC" Or UCase(eUsuario.Text) = "EMBOLSADO4") Then
            bIngresar_Click(sender, e)
        End If
    End Sub

    Private Sub cbEmpresa_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbEmpresa.SelectedIndexChanged
        'Tab(e)
    End Sub

    Private Sub cbEmpresa_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbEmpresa.KeyPress
        If e.KeyChar = Chr(13) Then
            bIngresar_Click(sender, e)
        End If
    End Sub
End Class