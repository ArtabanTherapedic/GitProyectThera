Public Class DatosDBForm

    Private Sub DatosDBForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If GetDatos() = False Then
            MsgBox(Msj00013, MsgBoxStyle.Critical, Empresa & " Msj00013")
            Me.Close()
        Else
            eDB.Text = DatosCon.DataBase
            eServer.Text = DatosCon.Server
            eUsuario.Text = DatosCon.dbUser
            ePW.Text = DatosCon.dbPW
        End If
        eServer.Focus()
    End Sub

    Private Sub bCancelar_Click(sender As System.Object, e As System.EventArgs) Handles bCancelar.Click
        FrmMain.Visible = True
        Me.Close()
    End Sub

    Private Sub DatosDBForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        If eServer.Text = "" Then
            MsgBox(Msj00001, MsgBoxStyle.Critical, Empresa & " Msj00001")
            eServer.Focus()
            Exit Sub
        End If
        If eDB.Text = "" Then
            MsgBox(Msj00002, MsgBoxStyle.Critical, Empresa & " Msj00002")
            eDB.Focus()
            Exit Sub
        End If
        If eUsuario.Text = "" Then
            MsgBox(Msj00003, MsgBoxStyle.Critical, Empresa & " Msj00003")
            eUsuario.Focus()
            Exit Sub
        End If
        If ePW.Text = "" Then
            MsgBox(Msj00004, MsgBoxStyle.Critical, Empresa & " Msj00004")
            ePW.Focus()
            Exit Sub
        End If
        DatosCon.Server = eServer.Text
        DatosCon.dbPW = ePW.Text
        DatosCon.dbUser = eUsuario.Text
        DatosCon.DataBase = eDB.Text
        If GuardaConfig() = True Then
            Me.Close()
        Else
            MsgBox(Msj00005, MsgBoxStyle.Critical, Empresa & " Msj00005")
        End If
    End Sub

    Private Sub DatosDBForm_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub
End Class