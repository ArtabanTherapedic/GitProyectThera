Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports CrystalDecisions.ReportSource
Imports System.Data.OleDb
Imports System.IO

Public Class TestFormvb
    Private Mi_Reporte As New ReportDocument

    Private Sub ConfigureCrystalReports()

        Dim reportPath As String = "\\EPICOR01\ERP10.0.700Deployment\RPT\RptTest.rpt" 'Server.MapPath("CryRptCobranzat.rpt")
        Mi_Reporte = New ReportDocument()
        reportPath = "\\EPICOR01\ERP10.0.700Deployment\RPT\RptEmbarque.rpt"
        Mi_Reporte.Load(reportPath)

        Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()

        myConnectionInfo.ServerName = DatosCon.Server
        myConnectionInfo.DatabaseName = DatosCon.DataBase
        myConnectionInfo.UserID = DatosCon.dbUser
        myConnectionInfo.Password = DatosCon.dbPW
        'Mi_Reporte.vi = True
        SetDBLogonForReport(myConnectionInfo, Mi_Reporte)
        'Mi_Reporte.SetParameterValue("@idRevision", 2)
        Dim CRVW_detcorgdelearning As New ReportView
        With CRVW_detcorgdelearning.Visor
            .ReportSource = Mi_Reporte
            '.SelectionFormula = "{TC_RUTAS_HM.rut_id_num} = 14"
            '.RefreshReport()
            .PrintReport()
            '.Show()
            '.Visible = True
        End With
        'Visor.Visible = True
    End Sub

    Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables

        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'ConfigureCrystalReports()
    End Sub


    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        Mi_Reporte.Close()
        Mi_Reporte.Dispose()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'ConfigureCrystalReports()
        test01()
    End Sub

    Private Sub test01()

        Dim dtRep As New DataTable
        Dim daRep As New SqlDataAdapter
        Dim Sql = "select IdRevision, SKU, Descripcion, TipoEnvio, Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque, " & _
            " sum(Ingreso)Ingreso, Sum(Revision1)Revision1, sum(Revision2)Revision2, Sum(Revision3)Revision3, NoSeries " & _
            " From( select Hdr.IdRevision, Art.SKU, Descripcion, Ingreso, Revision1, Revision2, Revision3,  STUFF((SELECT ',' + cast(Consecutivo as varchar(50)) " & _
            " FROM PyFEmbarquesDet with(NoLock) where PyFEmbarquesDet.idRevision = Det.IdRevision    ORDER BY consecutivo FOR XML PATH('') ), 1, 1, '') + ' ' as NoSeries, " & _
            " TipoEnvio, Hdr.Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque " & _
            " from PyFEmbarquesHdr hdr With(NoLock) inner join PyfEmbarquesDet Det with(NoLock) on Hdr.idrevision = det.idrevision  inner join EtiquetasProd Et with(NoLock) " & _
            " on Det.Consecutivo = Et.Consecutivo  inner join CatArticulosPT Art with(NoLock) on Art.SKU = Et.SKU " & _
            " where Hdr.idRevision = 1 " & _
            " ) EmbAgrupados  group by idrevision, sku, Descripcion, NoSeries, TipoEnvio, Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque "

        Dim CMD As New SqlCommand(Sql, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daRep.SelectCommand = CMD
        daRep.Fill(dtRep)
        Try
            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New RptEmbarque
            CrReport.SetDataSource(dtRep) 
            ReportView.Visor.ReportSource = CrReport
            ReportView.Show() 
        Catch ex As Exception
            MessageBox.Show("excepcion: " & ex.Message, "Mostrando Reporte")
        End Try

    End Sub

End Class