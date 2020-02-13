Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class EtiquetasCalForm

    Private Sub bImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImprimir.Click
        If DatosValidos() = True Then
            'Generar()
            Timer1.Enabled = True
        End If
    End Sub

    Private Function DatosValidos() As Boolean
        DatosValidos = False
        Dim cWarning As String = ""
        If eOP.Text = "" Then
            MsgBox(Msj00006, MsgBoxStyle.Critical, Empresa & " Msj00006")
            eOP.Focus()
            Exit Function
        End If
        If eNoPiezas.Text = "" Then
            MsgBox(Msj00007, MsgBoxStyle.Critical, Empresa & " Msj00007")
            eNoPiezas.Focus()
            Exit Function
        End If
        DatosValidos = True
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        bImprimir.Enabled = True
        bExcel.Enabled = True
        bLimpiar.Enabled = True
        LImpresion.Visible = False
        pGral.Enabled = True
    End Sub

    Private Sub bLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLimpiar.Click
        If bImprimir.Enabled = False Then Exit Sub
        If MsgBox(Msj00008, MsgBoxStyle.YesNo, Empresa & " Msj00008") = MsgBoxResult.Yes Then
            Limpiar()
        End If
    End Sub

    'Private Sub Generar()
    '    bLimpiar.Enabled = False
    '    bImprimir.Enabled = False
    '    LImpresion.Visible = True
    '    Try
    '        'Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '        Dim contador As Int16
    '        contador = 0
    '        Dim rpt As New EtiquetasCal02
    '        Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo
    '        oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
    '        oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
    '        oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
    '        oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
    '        For x = 0 To rpt.Database.Tables.Count - 1
    '            rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
    '            rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
    '        Next
    '        'Fuente http://scn.sap.com/thread/1886030
    '        rpt.SetParameterValue("@Emisor", "ARTABAN INTERNACIONAL S. A. DE C. V.")
    '        rpt.SetParameterValue("@Max", Convert.ToInt64(eNoPiezas.Text))
    '        rpt.SetParameterValue("@Serie", Year(FechaFab.Text).ToString.Substring(2, 2) & Format(Month(FechaFab.Text), "##00") & Format(Microsoft.VisualBasic.DateAndTime.Day(FechaFab.Text), "##00"))
    '        rpt.SetParameterValue("@Modelo", UCase(cbModelo.Text))
    '        rpt.SetParameterValue("@OP", UCase(eOP.Text))
    '        rpt.SetParameterValue("@Composicion", UCase(cbComposicion.Text))
    '        rpt.SetParameterValue("@Color1", UCase(cbColor1.Text))
    '        rpt.SetParameterValue("@Cliente", UCase(cbCliente.Text))
    '        rpt.SetParameterValue("@Grado", UCase(cbTPV.Text))
    '        rpt.SetParameterValue("@Decorativos", UCase(cbDecorativos.Text))
    '        rpt.PrintToPrinter(1, True, 0, 0)
    '        'If cbComposicion.Text Like ("3*") And cbComposicion.Text Like ("*1") And cbComposicion.Text.Length = 5 Then
    '        '    contador = 3
    '        '    For x = 1 To contador
    '        '        rpt.SetParameterValue("@Ad", "(" & x.ToString & ")")
    '        '        rpt.PrintToPrinter(1, True, 0, 0)
    '        '    Next
    '        'End If
    '        'If cbComposicion.Text Like ("3*") And cbComposicion.Text Like ("*2") And cbComposicion.Text.Length = 3 Then
    '        '    contador = 2
    '        '    For x = 1 To contador
    '        '        rpt.SetParameterValue("@Ad", "(" & (x + 1).ToString & ")")
    '        '        rpt.PrintToPrinter(1, True, 0, 0)
    '        '    Next
    '        'End If
    '        'If cbComposicion.Text Like ("3*") And cbComposicion.Text Like ("*1") And cbComposicion.Text.Length = 3 Then
    '        '    contador = 2
    '        '    rpt.SetParameterValue("@Ad", "(1)")
    '        '    rpt.PrintToPrinter(1, True, 0, 0)
    '        '    rpt.SetParameterValue("@Ad", "(3)")
    '        '    rpt.PrintToPrinter(1, True, 0, 0)
    '        'End If
    '        'If contador = 0 Then
    '        '    rpt.SetParameterValue("@Ad", "")
    '        '    rpt.PrintToPrinter(1, True, 0, 0)
    '        'End If
    '    Catch ex As Exception
    '        MsgBox(Msj00009 & Chr(13) & ex.Message, MsgBoxStyle.Critical, Empresa & " Msj00009")
    '    End Try
    'End Sub

    Private Sub Limpiar()
        eOP.Text = ""
        eNoPiezas.Text = ""
        cbModelo.Text = ""
        cbCliente.Text = ""
        cbColor1.Text = ""
        cbComposicion.Text = ""
        cbDecorativos.Text = ""
        cbModelo.Text = ""
        cbTPV.Text = ""
    End Sub

    Private Sub EtiquetasCalForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMain.Visible = True
    End Sub

    Private Sub EtiquetasCalForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        'CargaCombos()
    End Sub

    Private Sub CargaCombos()
        Dim dtCombos As New System.Data.DataTable
        Dim daCombos As New SqlDataAdapter
        Dim CMD As New SqlCommand("Select IDCliente, FechaAlta, IDUsuarioAlta, Nombre, IDUsuarioMod, FechaMod from CatClientesEC ", Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dtCombos)
        For Each row As DataRow In dtCombos.Rows
            cbCliente.Properties.Items.Add(row.Item("Nombre").ToString.ToUpper)
        Next
        daCombos.Dispose()
        dtCombos.Reset()
        'CMD.CommandText = "Select 'Juan' Nombre union all Select 'Eduardo' "
        'daCombos.SelectCommand = CMD
        'daCombos.Fill(dtCombos)
        'For Each row As DataRow In dtCombos.Rows
        '    cbColor1.Properties.Items.Add(row.Item("Nombre").ToString.ToUpper)
        'Next
    End Sub

    Private Sub bExcel_Click(sender As System.Object, e As System.EventArgs) Handles bExcel.Click
        Dim xls_cn As New OleDbConnection
        Dim xls_cmd As New OleDbCommand
        Dim xls_reader As New OleDbDataAdapter
        Dim xlsx As String
        Dim patharchivo As New OpenFileDialog
        patharchivo.ShowDialog()
        xlsx = patharchivo.FileName
        Try
            If xlsx = "" Then
                MsgBox(Msj00010, MsgBoxStyle.Critical, Empresa & " Msj00010")
                Exit Sub
            Else
                Dim strExtension As String = ""
                Dim nombreXls As String
                nombreXls = Path.GetFileName(xlsx)
                strExtension = Path.GetExtension(xlsx)
                If strExtension = ".xls" Then
                    If (File.Exists(xlsx)) Then
                        bExcel.Enabled = False
                        bImprimir.Enabled = False
                        bLimpiar.Enabled = False
                        pGral.Enabled = False
                        xls_cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + xlsx + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'")
                        Dim dt As New DataTable("Datos")
                        Using xls_cn
                            xls_cn.Open()
                            xls_cmd.CommandText = "SELECT * FROM [Hoja1$]"
                            xls_cmd.Connection = xls_cn
                            xls_reader.SelectCommand = xls_cmd
                            Dim da As New OleDbDataAdapter(xls_cmd)
                            da.Fill(dt)
                            For i = 0 To dt.Rows.Count - 1
                                If Not IsDBNull(dt.Rows(i).Item(0)) Or Not IsDBNull(dt.Rows(i).Item(2)) Or Not IsDBNull(dt.Rows(i).Item(3)) Or Not IsDBNull(dt.Rows(i).Item(4)) Or Not IsDBNull(dt.Rows(i).Item(5)) Or Not IsDBNull(dt.Rows(i).Item(6)) Or Not IsDBNull(dt.Rows(i).Item(7)) Or Not IsDBNull(dt.Rows(i).Item(9)) Then
                                    If Not IsDBNull(dt.Rows(i).Item(0)) Then FechaFab.Text = dt.Rows(i).Item(0).ToString Else FechaFab.Text = ""
                                    If Not IsDBNull(dt.Rows(i).Item(2)) Then cbCliente.Text = dt.Rows(i).Item(2).ToString Else cbCliente.Text = ""
                                    If Not IsDBNull(dt.Rows(i).Item(3)) Then cbComposicion.Text = dt.Rows(i).Item(3).ToString Else cbComposicion.Text = ""
                                    If Not IsDBNull(dt.Rows(i).Item(4)) Then cbModelo.Text = dt.Rows(i).Item(4).ToString Else cbModelo.Text = ""
                                    If Not IsDBNull(dt.Rows(i).Item(5)) Then cbTPV.Text = dt.Rows(i).Item(5).ToString Else cbTPV.Text = ""
                                    If Not IsDBNull(dt.Rows(i).Item(6)) Then cbColor1.Text = dt.Rows(i).Item(6).ToString Else cbColor1.Text = ""
                                    If Not IsDBNull(dt.Rows(i).Item(7)) Then eNoPiezas.Text = dt.Rows(i).Item(7).ToString Else eNoPiezas.Text = "1"
                                    If Not IsDBNull(dt.Rows(i).Item(9)) Then eOP.Text = dt.Rows(i).Item(9).ToString Else eOP.Text = ""
                                    If Not IsDBNull(dt.Rows(i).Item(11)) Then cbDecorativos.Text = dt.Rows(i).Item(11).ToString Else cbDecorativos.Text = ""
                                    'Generar()
                                End If
                            Next
                        End Using
                    End If
                    Limpiar()
                Else
                    MsgBox(Msj00011, MsgBoxStyle.Critical, Empresa & " Msj00011")
                    Timer1.Enabled = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Error" & Chr(13) & Chr(13) & ex.Message)

        End Try
        Timer1.Enabled = True
    End Sub

    Private Sub cbModelo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbModelo.KeyPress
        Tab(e)
    End Sub

    Private Sub eOP_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eOP.KeyPress
        Tab(e)
    End Sub

    Private Sub eNoPiezas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eNoPiezas.KeyPress
        Tab(e)
    End Sub

    Private Sub FechaFab_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles FechaFab.KeyPress
        Tab(e)
    End Sub

    Private Sub cbComposicion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbComposicion.KeyPress
        Tab(e)
    End Sub

    Private Sub cbColor1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbColor1.KeyPress
        Tab(e)
    End Sub

    Private Sub cbCliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbCliente.KeyPress
        Tab(e)
    End Sub

    Private Sub cbTPV_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbTPV.KeyPress
        Tab(e)
    End Sub

    Private Sub cbDecorativos_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbDecorativos.KeyPress
        Tab(e)
    End Sub
End Class