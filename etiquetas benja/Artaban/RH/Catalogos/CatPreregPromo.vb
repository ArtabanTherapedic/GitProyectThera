Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading
Public Class CatPreregPromo

    Dim NoSup As Integer
    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bNuevo.Click
        Limpia()
    End Sub
    Private Sub Limpia()
        ePaterno.Clear()
        eMaterno.Clear()
        eNombre.Clear()
        eTelefono.Clear()
        eIMMS.Clear()
        eNoClinica.Clear()
        eCurp.Clear()
        eRFC.Clear()
        cbEstadoCiv.EditValue = -1
        eCuentaB.Clear()
        eCredInfo.Clear()
        eEmail.Clear()
        eDomicilio.Clear()
        eColonia.Clear()
        eCP.Clear()
        eCiudad.Clear()
        eEstado.Clear()
        eSueldo.Clear()
        eCentroTrab.Clear()
        fIngreso.Text = Now.Date.ToString
        ePaterno.Focus()
    End Sub

    Private Sub CatPreregPromo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaCombo(cbEstadoCiv, "Select 0 as ID, 'Soltero' as Estado union Select 1, 'Casado' Union Select 2, 'Divorciado' union Select 3, 'Viudo'", "ID", "Estado")
        Limpia()
    End Sub

    Private Sub CatPreregPromo_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bIgnorar_Click(sender As System.Object, e As System.EventArgs) Handles bIgnorar.Click
        Limpia()
    End Sub

    Private Sub eTelefono_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eTelefono.KeyPress, eCredInfo.KeyPress

        SoloEnteros(e)
    End Sub

    Private Sub eCuentaB_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eCuentaB.KeyPress
        SoloEnteros(e)
    End Sub

    Private Sub eSueldo_Leave(sender As System.Object, e As System.EventArgs) Handles eSueldo.Leave
        Dim Validar As Double
        Dim NDecimal As Integer
        If eSueldo.Text = "" Then eSueldo.Text = "0.00"
        Try
            Validar = CDbl(eSueldo.Text)
            eSueldo.Text = Math.Round(Validar, 4)
            NDecimal = eSueldo.Text.IndexOf(".")
            If NDecimal = -1 Then
                eSueldo.Text = eSueldo.Text & ".0000"
            Else
                If NDecimal + 4 >= eSueldo.Text.Length Then
                    For x = 0 To (NDecimal + 4) - eSueldo.Text.Length
                        eSueldo.Text = eSueldo.Text & "0"
                    Next
                End If
            End If
        Catch ex As Exception
            eSueldo.Focus()
            MsgBox("El dato debe ser un numerico valido.")
            Exit Sub
        End Try
    End Sub

    Private Function ValidaDatos() As Boolean
        ValidaDatos = False
        If ePaterno.Text = "" Then
            MsgBox("Es necesario indicar el apellido paterno.")
            ePaterno.Focus()
            Exit Function
        End If
        If eNombre.Text = "" Then
            MsgBox("Es necesario indicar el nombre.")
            eNombre.Focus()
            Exit Function
        End If
        If eSueldo.Text = "" Then
            MsgBox("Es necesario indicar el sueldo.")
            eSueldo.Focus()
            Exit Function
        End If
        If fIngreso.Text = "" Then
            MsgBox("Es necesario indicar la fecha de ingreso.")
            fIngreso.Focus()
            Exit Function
        End If
        If eDomicilio.Text = "" Then
            MsgBox("Es necesario indicar Domicilio.")
            eDomicilio.Focus()
            Exit Function
        End If
        If eColonia.Text = "" Then
            MsgBox("Es necesario indicar la Colonia.")
            eColonia.Focus()
            Exit Function
        End If
        If eCP.Text = "" Then
            MsgBox("Es necesario indicar el Código Postal.")
            eCP.Focus()
            Exit Function
        End If
        If eCiudad.Text = "" Then
            MsgBox("Es necesario indicar la Ciudad.")
            eCiudad.Focus()
            Exit Function
        End If
        If eEstado.Text = "" Then
            MsgBox("Es necesario indicar el Estado.")
            eEstado.Focus()
            Exit Function
        End If
        If eIMMS.Text = "" Then
            MsgBox("Es necesario indicar el Número de Afiliacion.")
            eIMMS.Focus()
            Exit Function
        End If
        If eCurp.Text = "" Then
            MsgBox("Es necesario indicar la CURP.")
            eCurp.Focus()
            Exit Function
        End If
        If eRFC.Text = "" Then
            MsgBox("Es necesario indicar el RFC.")
            eRFC.Focus()
            Exit Function
        End If
        If eNoClinica.Text = "" Then
            MsgBox("Es necesario indicar el número de clinica al que pertenece.")
            eNoClinica.Focus()
            Exit Function
        End If
        If cbEstadoCiv.Text = "" Then
            MsgBox("Es necesario indicar el estado civil.")
            cbEstadoCiv.Focus()
            Exit Function
        End If
        If eCentroTrab.Text = "" Then
            MsgBox("Es necesario indicar el centro de trabajo.")
            eCentroTrab.Focus()
            Exit Function
        End If
        If eCuentaB.Text = "" Then
            MsgBox("Es necesario indicar el número de cuenta bancaria.")
            eCuentaB.Focus()
            Exit Function
        End If
        If eCuentaB.Text = "" Then
            MsgBox("Es necesario indicar el número de cuenta bancaria.")
            eCuentaB.Focus()
            Exit Function
        End If
        ValidaDatos = True
    End Function
    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        If ValidaDatos() = False Then
            Exit Sub
        End If
        Dim cmdCB As New SqlCommand("spGenPreProm", Conexion01)
        cmdCB.CommandType = CommandType.StoredProcedure
        'cmdCB.Transaction = Transac
        cmdCB.Parameters.Add("@Opc", SqlDbType.Int).Value = 1
        cmdCB.Parameters.Add("@NoSupervisor", SqlDbType.Int).Value = NoSup
        cmdCB.Parameters.Add("@Paterno", SqlDbType.VarChar, 100).Value = ePaterno.Text
        cmdCB.Parameters.Add("@Materno", SqlDbType.VarChar, 100).Value = eMaterno.Text
        cmdCB.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = eNombre.Text
        cmdCB.Parameters.Add("@Sueldo", SqlDbType.Float).Value = CDbl(eSueldo.Text)
        cmdCB.Parameters.Add("@FechaAlta", SqlDbType.VarChar, 15).Value = fIngreso.Text
        cmdCB.Parameters.Add("@Domicilio", SqlDbType.VarChar, 500).Value = eDomicilio.Text
        cmdCB.Parameters.Add("@Colonia", SqlDbType.VarChar, 500).Value = eColonia.Text
        cmdCB.Parameters.Add("@CP", SqlDbType.Int).Value = CInt(eCP.Text)
        cmdCB.Parameters.Add("@Ciudad", SqlDbType.VarChar, 100).Value = eCiudad.Text
        cmdCB.Parameters.Add("@Estado", SqlDbType.VarChar, 100).Value = eEstado.Text
        cmdCB.Parameters.Add("@Telefono", SqlDbType.VarChar, 20).Value = eTelefono.Text
        cmdCB.Parameters.Add("@NoAfiliacion", SqlDbType.VarChar, 50).Value = eIMMS.Text
        cmdCB.Parameters.Add("@CURP", SqlDbType.VarChar, 50).Value = eCurp.Text
        cmdCB.Parameters.Add("@RFC", SqlDbType.VarChar, 50).Value = eRFC.Text
        cmdCB.Parameters.Add("@Clinica", SqlDbType.VarChar, 50).Value = eNoClinica.Text
        cmdCB.Parameters.Add("@EstadoCiv", SqlDbType.Int).Value = cbEstadoCiv.EditValue
        cmdCB.Parameters.Add("@CentroTrab", SqlDbType.VarChar, 100).Value = eCentroTrab.Text
        cmdCB.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = eEmail.Text
        cmdCB.Parameters.Add("@NoCuenta", SqlDbType.VarChar, 50).Value = eCuentaB.Text
        cmdCB.Parameters.Add("@NoCredInf", SqlDbType.VarChar, 50).Value = eCredInfo.Text
        cmdCB.Parameters.Add("@Sueldo2", SqlDbType.Float).Value = 0.0
        cmdCB.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
        cmdCB.Parameters.Add("@idPreRegProm", SqlDbType.Int)
        cmdCB.Parameters("@idPreRegProm").Direction = ParameterDirection.Output
        cmdCB.ExecuteNonQuery()
        Select Case cmdCB.Parameters("@idPreRegProm").Value
            Case 0 'Error al generar el proceso
                MsgBox("Ocurrio un error al generar el alta en el sistema.")
                Exit Sub
            Case Else 'Generar contrato
                Limpia()
                Dim Destinatario = InputBox("Indicar el destinatario(s)")
                If Destinatario <> "" Then
                    Dim sqlEnvio = "Insert into logEnvioAdjuntos " & _
                        " Select 1, 'SELECT   Prom.Paterno,  Prom.Materno, Prom.Nombre, ((Sueldo/7.0)*30.4) as Sueldo,  therapedic.dbo.CantidadConLetra(((Sueldo/7.0)*30.4))SueldoLetra, FechaAlta, usuarios.nombre as Testigo FROM therapedic.dbo.PreRegPromotoria Prom inner join therapedic.dbo.catUsuarios Usuarios on prom.UsuAlta = usuarios.idusuario  where idPreRegProm = " & cmdCB.Parameters("@idPreRegProm").Value.ToString & " ', " & _
                        cmdCB.Parameters("@idPreRegProm").Value.ToString & ", '" & Usuario & "', getdate(), '" & Destinatario & "', '', NULL"
                    Dim CmdEnvio As New SqlCommand(sqlEnvio, Conexion01)
                    CmdEnvio.ExecuteNonQuery()
                    MsgBox("El contrato fue enviado a " & Destinatario)
                End If
                If MsgBox("¿Desea Visualizar el contrato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
VerContrato:
                    If File.Exists("\\192.168.1.251\Reportes\Contratos\" & cmdCB.Parameters("@idPreRegProm").ToString & ".pdf") Then
                        Process.Start("\\192.168.1.251\Reportes\Contratos\" & cmdCB.Parameters("@idPreRegProm").ToString & ".pdf")
                    Else
                        Thread.Sleep(5000)
                        GoTo verContrato
                    End If

                    Exit Sub
                    'Dim sql = " SELECT   Paterno, Materno, Nombre, ((Sueldo/7.0)*30.4) as Sueldo, " & _
                    '    " therapedic.dbo.CantidadConLetra(((Sueldo/7.0)*30.4))SueldoLetra, FechaAlta, '" & Nombre & "' as Testigo" & _
                    '    " FROM therapedic.dbo.PreRegPromotoria where idPreRegProm = " & cmdCB.Parameters("@idPreRegProm").Value.ToString
                    Dim sql = " SELECT   Prom.Paterno,  Prom.Materno, Prom.Nombre, ((Sueldo/7.0)*30.4) as Sueldo, " & _
                        " therapedic.dbo.CantidadConLetra(((Sueldo/7.0)*30.4))SueldoLetra, FechaAlta, usuarios.nombre as Testigo" & _
                        " FROM therapedic.dbo.PreRegPromotoria Prom " & _
                        " inner join therapedic.dbo.catUsuarios Usuarios on prom.UsuAlta = usuarios.idusuario " & _
                        " where idPreRegProm = " & cmdCB.Parameters("@idPreRegProm").Value.ToString
ImprimeContrato:
                    Dim Reporte As New RepContratoPromotoria
                    'ImprimeCR("", sql, Reporte, 2, Nothing, False)
                    PreviewCR(sql, Reporte)
                    If MsgBox("¿Se imprimio el contrato de forma correcta?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then GoTo ImprimeContrato
                    'IDMovimiento
                End If
        End Select
    End Sub

    Private Sub CatPreregPromo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub
End Class