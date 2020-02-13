Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports.Engine

Public Class ReportView

    Private Sub ReportView_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim oConexInfo As ConnectionInfo = New ConnectionInfo()
        oConexInfo.ServerName = DatosCon.Server
        oConexInfo.DatabaseName = DatosCon.DataBase
        oConexInfo.UserID = DatosCon.dbUser
        oConexInfo.Password = DatosCon.dbPW
        oConexInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type 
        oConexInfo.IntegratedSecurity = False
        'Visor.DataBindings()
        'For x = 0 To rpt.Database.Tables.Count - 1
        '    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
        '    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
        'Next
        setDBLOGONforREPORT(oConexInfo)

        'End Try
    End Sub

    Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)
        Dim mytableloginfos As New TableLogOnInfos()
        mytableloginfos = Visor.LogOnInfo
        For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
            myTableLogOnInfo.ConnectionInfo = myconnectioninfo
        Next
    End Sub
End Class