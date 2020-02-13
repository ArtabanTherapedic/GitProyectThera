Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO 
Public Class ProRecDestajoFormf
    Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo
    Private idEmp As Integer = -1

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If eConsecutivo.Focused = False Then eConsecutivo.Focus()
    End Sub

    Private Sub ProReciboEmpFormf_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        eConsecutivo.Focus()
    End Sub

    Private Sub GetEmpleado()
        If idEmp = -1 Then
            idEmp = eConsecutivo.Text
            eConsecutivo.Text = ""
            Dim Sql = "Select a.idEmpleado, Isnull(a.Nombre,'')+ ' ' + Isnull(a.Paterno,'') + ' ' + isnull(a.Materno,'')Empleado, b.Area, a.Foto, a.Activo " & _
                " from CatEmpleados as a with(nolock) inner join CatAreas as b with(nolock) on (a.IDArea = b.IDArea) where a.idEmpleado = " & idEmp.ToString
            Dim daCat As New SqlDataAdapter
            Dim dsCat As New DataTable
            Dim CMD As New SqlCommand(Sql, Conexion01)
            If Conexion01.State = False Then Conexion01.Open()
            daCat.Dispose()
            daCat.SelectCommand = CMD
            daCat.Fill(dsCat)
            If dsCat.Rows.Count = 0 Then 'Si no existe el operador manda el mensaje y no continua'
                eDescripcion.Text = Msj00059
                eDescripcion.BackColor = Color.Salmon
                Timer2.Enabled = True
                idEmp = -1
                Exit Sub
            Else
                If dsCat.Rows(0)("Activo") = False Then 'Si el operador esta inactivo manda el mensaje y no continua
                    eDescripcion.Text = Msj00060
                    eDescripcion.BackColor = Color.Salmon
                    Timer2.Enabled = True
                    idEmp = -1
                    Exit Sub
                End If
            End If
            'Si el operador es valido carga su configuracion
            'tActivo.Enabled = False
            'tActivo.Enabled = True
            mEmpleado.Text = ""
            mEmpleado.Text = eConsecutivo.Text & Chr(13)
            mEmpleado.Text = "ID: " & idEmp & vbCrLf & vbCrLf & "NOMBRE: " & dsCat(0)("Empleado").ToString & vbCrLf & vbCrLf & "ÁREA: " & Chr(13) & dsCat(0)("Area").ToString
            'If dsCat(0)("Foto")
            Foto.Image = BytesToImagen(dsCat(0)("Foto"))
        ElseIf idEmp = eConsecutivo.Text Then
            Deslogueo()
        Else
            eDescripcion.Text = Msj00067
            eDescripcion.BackColor = Color.Salmon
            eConsecutivo.Text = ""
        End If
    End Sub

    Private Sub IngresaProd()
        Timer2.Enabled = False
        Dim Transac As SqlTransaction
        Transac = Conexion01.BeginTransaction
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand("spUpDestajos", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Transaction = Transac
            cmd.Parameters.Add("@Consecutivo", SqlDbType.VarChar, 13).Value = eConsecutivo.Text
            eConsecutivo.Text = ""
            cmd.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = idEmp
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            cmd.ExecuteNonQuery()
            Transac.Commit()
            If cmd.Parameters("@Resultado").Value = 1 Then eDescripcion.BackColor = Color.Salmon Else eDescripcion.BackColor = Color.AliceBlue
            eDescripcion.Text = cmd.Parameters("@Msj").Value
            Timer2.Enabled = True
        Catch ex As Exception
            Transac.Rollback()
            'MsgBox(Msj00049 + Chr(13) + ex.Message, MsgBoxStyle.Critical, Empresa & "MSJ00049")
            eDescripcion.Text = ex.Message
            eDescripcion.BackColor = Color.Salmon
            Timer2.Enabled = True
            Exit Sub
        End Try
    End Sub

    Private Sub eConsecutivo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eConsecutivo.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) And Not (e.KeyChar = Chr(13)) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            If Len(eConsecutivo.Text) = 5 Then
                GetEmpleado()
            Else
                If idEmp = -1 Then
                    eDescripcion.Text = Msj00061
                    eDescripcion.BackColor = Color.Salmon
                    eConsecutivo.Text = ""
                    Timer2.Enabled = True
                    Exit Sub
                End If
                IngresaProd()
            End If
                Exit Sub
                Dim ID As Int64
                ID = (eConsecutivo.Text)
                'eConsecutivo.Text = ""
                Dim cmdEt As New SqlCommand("SpGenEtiquetaPT", Conexion01)
                cmdEt.CommandType = CommandType.StoredProcedure
                cmdEt.Parameters.Add("@Consecutivo", SqlDbType.BigInt).Value = ID
                cmdEt.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
                cmdEt.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
                cmdEt.Parameters("@Resultado").Direction = ParameterDirection.Output
                cmdEt.Parameters("@Msj").Direction = ParameterDirection.Output
                If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                cmdEt.ExecuteNonQuery()
                eDescripcion.Text = cmdEt.Parameters("@Msj").Value.ToString()
                Timer2.Enabled = True
                If cmdEt.Parameters("@Resultado").Value.ToString() = "1" Then
                    'System.Media.SystemSounds.Beep.Play()
                    System.Media.SystemSounds.Exclamation.Play()

                    If cmdEt.Parameters("@Msj").Value.ToString = "" Then eDescripcion.Text = Msj00030
                    eDescripcion.BackColor = Color.Salmon
                Else
                    System.Media.SystemSounds.Hand.Play()
                    eDescripcion.BackColor = Color.AliceBlue
                    Imprimir(ID)
                End If
            End If
    End Sub

    Private Sub Imprimir(ByVal ID As Int64)
        Dim rpt As New EtPT
        Try
            'Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim contador As Int16
            contador = 0
            oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
            oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
            oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
            oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
            For x = 0 To rpt.Database.Tables.Count - 1
                rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
                rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
            Next
            rpt.SetParameterValue("@Consecutivo", ID)
            rpt.PrintToPrinter(1, True, 0, 0)
        Catch ex As Exception
            MsgBox(Msj00029, MsgBoxStyle.Critical, Empresa & " MSJ00029")
            rpt.Dispose()
            Exit Sub
        End Try
        rpt.Dispose()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        eDescripcion.BackColor = Color.White
        eDescripcion.Text = ""
        'eConsecutivo.Text = ""

    End Sub

    Private Sub ProReciboEmpFormf_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub tActivo_Tick(sender As System.Object, e As System.EventArgs) Handles tActivo.Tick
        mEmpleado.Text = ""
        idEmp = -1
        Foto.Image = Nothing
        tActivo.Enabled = False
    End Sub

    Private Sub Deslogueo()
        mEmpleado.Text = ""
        idEmp = -1
        Foto.Image = Nothing
        eConsecutivo.Text = ""
        'tActivo.Enabled = False
    End Sub
End Class