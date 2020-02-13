Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource 
Imports System.Data.OleDb
Imports System.IO

Public Class RepEmbarquesForm
    Dim SQL As String = "" 
    Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo


    Private Sub CatComposiciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            IO.File.Delete("c:\artaban\*.pdf")
        Catch ex As Exception

        End Try
        FInicial.Value = Today
        FFinal.Value = Today
    End Sub

    Private Sub CatComposiciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub CatComposiciones_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        bImprimir.Enabled = False
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter
        gCatalogo.DataSource = Nothing
        SQL = "set dateformat dmy select NoEmbarque, Origen, Cliente, TipoEnvio, Placas, DomEntrega, convert(varchar(10), FEmbarque, 103)Fecha, Hdr.IdRevision, isnull(dtl.Cantidad,0)Piezas from PyFEmbarquesHdr Hdr with (nolock) " & _
            " left outer join ( select sum(revision1)Cantidad, idRevision from PyFEmbarquesDet with(nolock) group by idRevision ) Dtl on Hdr.idrevision = dtl.idrevision where  " & _
            " FEmbarque between '" & FInicial.Text & " 00:00' and '" & FFinal.Text & " 23:59' Order by NoEmbarque"
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        If dsCombos.Rows.Count > 0 Then bImprimir.Enabled = True
        gCatalogo.DataSource = dsCombos
    End Sub

    Private Sub bImprimir_Click(sender As System.Object, e As System.EventArgs) Handles bImprimir.Click
        If GridView1.SelectedRowsCount = 0 Then Exit Sub
        Try

            Dim Sql = "select IdRevision, SKU, Descripcion, TipoEnvio, Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque, " & _
                " sum(Ingreso)Ingreso, Sum(Revision1)Revision1, sum(Revision2)Revision2, Sum(Revision3)Revision3, NoSeries " & _
                " From( select Hdr.IdRevision, Art.SKU, Descripcion, Ingreso, Revision1, Revision2, Revision3,  STUFF((SELECT ',' + cast(Emb.Consecutivo as varchar(50)) " & _
                " FROM PyFEmbarquesDet emb with(NoLock)  left outer join EtiquetasProd et1 with(nolock) on emb.Consecutivo = et1.consecutivo " & _
                " where Emb.idRevision = Det.IdRevision  and et1.sku = et.SKu  ORDER BY emb.consecutivo FOR XML PATH('') ), 1, 1, '') + ' ' as NoSeries, " & _
                " TipoEnvio, Hdr.Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque " & _
                " from PyFEmbarquesHdr hdr With(NoLock) inner join PyfEmbarquesDet Det with(NoLock) on Hdr.idrevision = det.idrevision  inner join EtiquetasProd Et with(NoLock) " & _
                " on Det.Consecutivo = Et.Consecutivo  inner join CatArticulosPT Art with(NoLock) on Art.SKU = Et.SKU " & _
                " where Hdr.idRevision = " & GridView1.GetFocusedRowCellValue("IdRevision").ToString & _
                " ) EmbAgrupados  group by idrevision, sku, Descripcion, NoSeries, TipoEnvio, Cliente, NoEconomico, Placas, Chofer, DomEntrega, NoSello, NoEmbarque, FEmbarque "

            'Dim CMD As New SqlCommand(Sql, Conexion01)
            'If Conexion01.State = False Then Conexion01.Open()
            'daRep.SelectCommand = CMD
            'daRep.Fill(dtRep)

            Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            CrReport = New RptEmbarque
            PreviewCR(Sql, CrReport)
            'CrReport.SetDataSource(dtRep)
            'ReportView.Visor.ReportSource = CrReport
            'ReportView.Show()
        Catch ex As Exception
            MsgBox(Msj00062 + " " + ex.Message, MsgBoxStyle.Critical, Empresa & " Msj00062")
        End Try
    End Sub

    Private Sub bExportar_Click(sender As System.Object, e As System.EventArgs) Handles bExportar.Click
        ExportarXLSX(gCatalogo)
    End Sub
End Class