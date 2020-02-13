Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Public Class ReportesForm
    Dim SQL As String = ""
    Dim dsCombos As New DataTable
    Dim daCombos As New SqlDataAdapter
    Dim P1 = False
    Dim P2 = False
    Dim P3 = False
    Dim P4 = False
    Dim P5 = False
    Dim P6 = False
    Dim P7 = False
    Dim P8 = False
    Dim ComboVar1 = ""
    Dim ComboVar2 = ""
    Dim ComboVar3 = ""
    Dim FiltroVar1 = ""
    Dim FiltroVar2 = ""
    Dim FiltroVar3 = ""
    Dim FiltroVar4 = ""
    Dim SQLRep = ""
    Dim FormatoImp = ""
    Public Modulo As String 

    Dim dtRep As New DataTable
    Dim daRep As New SqlDataAdapter

    Private Sub ReportesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CargaComposiciones()
        SQL = "select idReporte, Descripcion from CatReportes with(Nolock) where idReporte in(Select idAcceso from CatAccesos with(nolock) where idModulo = " & Modulo & _
             " and idUsuario = '" & Usuario & "' and UsEmpresa = '" & UsEmpresa & "') order by Descripcion"
        CargaCombo(cbReportes, SQL, "idReporte", "Descripcion")
        cbReportes.EditValue = "-1"
        'CargaCatalogo()
    End Sub

    Private Sub CargaCatalogo()
        SQL = "select idReporte, Descripcion from CatReportes with(Nolock) where idReporte in(Select idAcceso from CatAccesos with(nolock) where idModulo = " & Modulo & _
            " and idUsuario = '" & Usuario & "') order by Descripcion"
        CargaCombo(cbReportes, SQL, "idReporte", "Descripcion")
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
    End Sub

    Private Sub ReportesForm_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub ReportesForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub Splitter1_Click(sender As System.Object, e As System.EventArgs)
        pTop.Visible = Not (pTop.Visible)
    End Sub

    Private Sub bExportar_Click(sender As System.Object, e As System.EventArgs) Handles bExportar.Click
        ExportarXLSX(gCatalogo)
    End Sub

    Private Sub bImprimir_Click(sender As System.Object, e As System.EventArgs) Handles bImprimir.Click
        If FormatoImp = "" Then
            gCatalogo.PrintDialog()
        Else
            CargaSQL()
            Dim Reporte = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Select Case FormatoImp
                Case "RepDestajos01"
                    Reporte = New RepDestajos01
                Case "RepDestajos02"
                    Reporte = New RepDestajos02
                Case "RepTomaInv"
                    Reporte = New RepTomaInv
                Case "RepTomaInvMP"
                    Reporte = New RepTomaInvMP
                Case "RepSalidasBox"
                    Reporte = New RepSalidasBox
                Case Else
                    gCatalogo.PrintDialog()
            End Select
            PreviewCR(SQL, Reporte) 
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles bLimpiar.Click
        Limpiar()
    End Sub

    Private Sub Limpiar()
        GridView1.Columns.Clear()
        gCatalogo.DataSource = Nothing
        cbFechas.Checked = True
        FechaI.Value = Now
        FechaF.Value = Now
        cbCombo1.EditValue = ""
        cbCombo2.EditValue = ""
        cbCombo3.EditValue = "" 
        eFiltro1.Text = ""
        eFiltro2.Text = ""
        eFiltro3.Text = ""
        eFiltro4.Text = ""
    End Sub

    Private Sub cbReportes_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbReportes.EditValueChanged
        Limpiar()
        If cbReportes.EditValue = -1 Then
            cbFechas.Checked = True
            FechaF.Value = Now
            FechaI.Value = Now
            cbCombo1.EditValue = "-1" 
            cbCombo2.EditValue = "-1" 
            cbCombo3.EditValue = "-1" 
            eFiltro1.Text = ""
            eFiltro2.Text = ""
            eFiltro3.Text = ""
            eFiltro4.Text = ""
        Else 'Si escoje un reporte
            Dim dtRep As New DataTable
            Dim daRep As New SqlDataAdapter
            Dim SQL = "Select idReporte, Descripcion, ActFechas, ActCombo1, ComboDesc1, ComboSQL1, ActCombo2, ComboDesc2, ComboSQL2, ActCombo3, " & _
                " ComboDesc3, ComboSQL3, ActFiltro1, FiltroDesc1, ActFiltro2, FiltroDesc2, ActFiltro3, FiltroDesc3, ActFiltro4, FiltroDesc4, SQL, " & _
                " ComboVar1, ComboVar2, ComboVar3, FiltroVar1, FiltroVar2, FiltroVar3, FiltroVar4, isnull(FormatoImp,'')FormatoImp " & _
                " from CatReportes with(nolock) where idReporte = " & cbReportes.EditValue.ToString
            Dim CMD As New SqlCommand(SQL, Conexion01)
            If Conexion01.State = False Then Conexion01.Open()
            daRep.SelectCommand = CMD
            daRep.Fill(dtRep)
            If dtRep.Rows.Count = 0 Then Exit Sub
            SQLRep = dtRep.Rows(0)("SQL")
            If dtRep.Rows(0)("ActFechas") = True Then
                cbFechas.Checked = True
                FechaI.Value = Now
                FechaF.Value = Now
                P1 = True
            Else
                P1 = False
            End If
            If dtRep.Rows(0)("ActCombo1") = True Then
                CargaCombo(cbCombo1, dtRep.Rows(0)("ComboSQL1").ToString, "ID", "Valor")
                lbCombo1.Text = dtRep.Rows(0)("ComboDesc1").ToString
                ComboVar1 = dtRep.Rows(0)("ComboVar1").ToString
                P2 = True
            Else
                'pCombo1.Visible = False
                P2 = False
                ComboVar1 = ""
            End If
            If dtRep.Rows(0)("ActCombo2") = True Then
                CargaCombo(cbCombo2, dtRep.Rows(0)("ComboSQL2").ToString, "ID", "Valor")
                lbCombo2.Text = dtRep.Rows(0)("ComboDesc2").ToString
                ComboVar2 = dtRep.Rows(0)("ComboVar2").ToString
                P3 = True
            Else
                P3 = False
                ComboVar2 = ""
            End If
            If dtRep.Rows(0)("ActCombo3") = True Then
                CargaCombo(cbCombo3, dtRep.Rows(0)("ComboSQL3").ToString, "ID", "Valor")
                lbCombo3.Text = dtRep.Rows(0)("ComboDesc3").ToString
                ComboVar3 = dtRep.Rows(0)("ComboVar3").ToString
                P4 = True
            Else
                P4 = False
                ComboVar3 = ""
            End If
            If dtRep.Rows(0)("ActFiltro1") = True Then
                eFiltro1.Text = ""
                FiltroVar1 = dtRep.Rows(0)("FiltroVar1").ToString
                lbFiltro1.Text = dtRep.Rows(0)("FiltroDesc1").ToString
                P5 = True
            Else
                P5 = False
                FiltroVar1 = ""
            End If
            If dtRep.Rows(0)("ActFiltro2") = True Then
                eFiltro2.Text = ""
                FiltroVar2 = dtRep.Rows(0)("FiltroVar2").ToString
                lbFiltro2.Text = dtRep.Rows(0)("FiltroDesc2").ToString
                P6 = True
            Else
                P6 = False
                FiltroVar2 = ""
            End If
            If dtRep.Rows(0)("ActFiltro3") = True Then
                eFiltro3.Text = ""
                P7 = True
                FiltroVar3 = dtRep.Rows(0)("FiltroVar3").ToString
                lbFiltro3.Text = dtRep.Rows(0)("FiltroDesc3").ToString
            Else
                P7 = False
                FiltroVar3 = ""
            End If
            If dtRep.Rows(0)("ActFiltro4") = True Then
                eFiltro4.Text = ""
                P8 = True
                FiltroVar4 = dtRep.Rows(0)("FiltroVar4").ToString
                lbFiltro4.Text = dtRep.Rows(0)("FiltroDesc4").ToString
            Else
                P8 = False
                FiltroVar4 = ""
            End If
            pTop.Visible = True
            FormatoImp = dtRep.Rows(0)("FormatoImp").ToString
            MuestraPanel(True)
            PersonalizaGrid()
        End If
    End Sub

    Private Sub PersonalizaGrid()
        GridView1.OptionsView.ShowFooter = False
        GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        GridView1.OptionsView.ColumnAutoWidth = True
        GridView1.OptionsBehavior.ReadOnly = True
        GridView1.OptionsBehavior.Editable = False
        daRep.SelectCommand = Nothing
        dtRep.Clear()
        Dim SQL = "Select IDReporte, Columna, Descripcion, Alineacion, Formato, Longitud, ColColor, ColFont, Visible, isnull(Resumen,0)Resumen, isnull(FormatoR,'')FormatoR, isnull(TipoR,0)TipoR from CatReportesCol with(nolock) where idReporte = " & cbReportes.EditValue.ToString & " order by Posicion "
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daRep.SelectCommand = CMD
        daRep.Fill(dtRep)
        Dim Ancho As Integer = 0
        If dtRep.Rows.Count = 0 Then Exit Sub
        GridView1.Columns.Clear()
        For Colum = 0 To dtRep.Rows.Count - 1
            Dim col As New DevExpress.XtraGrid.Columns.GridColumn
            col.Name = "Col" + dtRep.Rows(Colum)("Columna").ToString
            col.Caption = dtRep.Rows(Colum)("Descripcion").ToString
            col.FieldName = dtRep.Rows(Colum)("Columna").ToString
            If dtRep.Rows(Colum)("Formato").ToString <> "" Then
                col.DisplayFormat.FormatString = dtRep.Rows(Colum)("Formato").ToString
                Dim ri As New RepositoryItemTextEdit()
                col.ColumnEdit = ri
                ri.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
                ri.Mask.EditMask = dtRep.Rows(Colum)("Formato").ToString
                ri.Mask.UseMaskAsDisplayFormat = True
            End If
            col.Visible = True
            col.Width = dtRep.Rows(Colum)("Longitud")
            col.Visible = dtRep.Rows(Colum)("Visible")
            'GridView1.GroupSummary.Add() 
            If dtRep.Rows(Colum)("Resumen") = True Then
                GridView1.OptionsView.ShowFooter = True
                Select Case dtRep.Rows(Colum)("TipoR")
                    Case 0 'Nada
                        'col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.None
                        col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Custom
                    Case 1 'Sumatoria
                        col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    Case 2 'Promedio
                        col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average
                    Case 3 'Maximo
                        col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Max
                    Case 4 'Minimo
                        col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Min
                    Case 5 'Conteo
                        col.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                End Select
                col.SummaryItem.DisplayFormat = dtRep.Rows(Colum)("FormatoR").ToString
            End If
            GridView1.Columns.Add(col)

        Next
        GridView1.OptionsView.ColumnAutoWidth = False
    End Sub

    Private Sub MuestraPanel(Estado As Boolean)
        If Estado = True Then
            pFechas.Visible = P1
            pCombo1.Visible = P2
            pCombo2.Visible = P3
            pCombo3.Visible = P4
            If P5 = True Or P6 = True Or P7 = True Or P8 = True Then
                pFiltros.Visible = True
            Else
                pFiltros.Visible = False
            End If
            pFiltro1.Visible = P5
            pFiltro2.Visible = P6
            pFiltro3.Visible = P7
            pFiltro4.Visible = P8
        Else
            pFechas.Visible = False
            pCombo1.Visible = False
            pCombo2.Visible = False
            pCombo3.Visible = False
            pFiltro1.Visible = False
            pFiltro2.Visible = False
            pFiltro3.Visible = False
            pFiltro4.Visible = False
        End If
    End Sub

    Private Sub Splitter1_Click_1(sender As System.Object, e As System.EventArgs) Handles Splitter1.Click
        If Splitter1.Location.Y = 25 Then
            MuestraPanel(True)
        Else
            MuestraPanel(False)
        End If
    End Sub

    Private Sub CargaSQL()
        Dim Conteo = 0
        SQL = SQLRep + " "
        If P1 = True Then
            If cbFechas.Checked = False Then
                SQL = SQL + "@FI = '', @FF = ''"
            Else
                SQL = SQL + "@FI = '" & FechaI.Text & "', @FF = '" & FechaF.Text & "'"
            End If
            Conteo = 1
        End If
        If P2 = True Then
            If Conteo = 1 Then SQL = SQL + ", "
            ' Exit Sub
            If cbCombo1.Text <> "" Then SQL = SQL + ComboVar1 + " = '" + cbCombo1.EditValue.ToString + "'" Else SQL = SQL + ComboVar1 + " = ''"
            Conteo = 1
        End If
        If P3 = True Then
            If Conteo = 1 Then SQL = SQL + ", "
            If cbCombo2.Text <> "" Then SQL = SQL + ComboVar2 + " = '" + cbCombo2.EditValue.ToString + "'" Else SQL = SQL + ComboVar2 + " = ''"
            Conteo = 1
        End If
        If P4 = True Then
            If Conteo = 1 Then SQL = SQL + ", "
            If cbCombo3.Text <> "" Then SQL = SQL + ComboVar3 + " = '" + cbCombo3.EditValue.ToString + "'" Else SQL = SQL + ComboVar3 + " = ''"
            Conteo = 1
        End If
        If P5 = True Then
            If Conteo = 1 Then SQL = SQL + ", "
            SQL = SQL + FiltroVar1 + " = '" + eFiltro1.Text + "'"
            Conteo = 1
        End If
        If P6 = True Then
            If Conteo = 1 Then SQL = SQL + ", "
            SQL = SQL + FiltroVar2 + " = '" + eFiltro2.Text + "'"
            Conteo = 1
        End If
        If P7 = True Then
            If Conteo = 1 Then SQL = SQL + ", "
            SQL = SQL + FiltroVar3 + " = '" + eFiltro3.Text + "'"
            Conteo = 1
        End If
        If P8 = True Then
            If Conteo = 1 Then SQL = SQL + ", "
            SQL = SQL + FiltroVar4 + "= '" + eFiltro4.Text + "'"
            Conteo = 1
        End If
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        Try
            If Conexion01.State = False Then Conexion01.Open()
            GridView1.Columns.Clear()
            gCatalogo.DataSource = Nothing
            PersonalizaGrid()
            Dim dsCombos As New DataTable
            Dim daCombos As New SqlDataAdapter
            CargaSQL()

            Dim CMD As New SqlCommand(SQL, Conexion01)
            CMD.CommandTimeout = 10 * 60
            daCombos.SelectCommand = CMD
            daCombos.Fill(dsCombos)
            gCatalogo.DataSource = dsCombos
            gCatalogo.Enabled = True

            'GridView1.Columns.Clear()
            PersonalizaGrid()
        Catch ex As Exception
            MsgBox("Ocurrio un error al generar el reporte: " + Chr(13) + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cbCombo1_EditValueChanged(sender As System.Object, e As System.EventArgs) 'Handles cbCombo1.EditValueChanged
        If cbCombo1.Text = "" Then
            cbComboDesc1.EditValue = "-1"
            'Exit Sub
        End If
        'Exit Sub
        If cbComboDesc1.EditValue.ToString <> cbCombo1.Text Then
            cbComboDesc1.EditValue = CStr(cbCombo1.Text)
        End If
    End Sub

    Private Sub cbComboDesc1_EditValueChanged(sender As System.Object, e As System.EventArgs) 'Handles cbComboDesc1.EditValueChanged
        If cbComboDesc1.Text = "" Then
            cbCombo1.EditValue = "-1"
            Exit Sub
        End If
        If cbCombo1.EditValue.ToString <> cbComboDesc1.Text Then
            cbCombo1.EditValue = cbComboDesc1.Text
        End If
    End Sub

    Private Sub cbCombo2_EditValueChanged(sender As System.Object, e As System.EventArgs) 'Handles cbCombo2.EditValueChanged
        If cbCombo2.Text = "" Then
            cbComboDesc2.EditValue = "-1"
            Exit Sub
        End If
        If cbComboDesc2.EditValue.ToString <> cbCombo2.Text Then
            cbComboDesc2.EditValue = cbCombo2.Text
        End If
    End Sub

    Private Sub cbComboDesc2_EditValueChanged(sender As System.Object, e As System.EventArgs) 'Handles cbComboDesc2.EditValueChanged
        If cbComboDesc2.Text = "" Then
            cbCombo2.EditValue = "-1"
            Exit Sub
        End If
        If cbCombo2.EditValue.ToString <> cbComboDesc2.Text Then
            cbCombo2.EditValue = cbComboDesc2.Text
        End If
    End Sub

    Private Sub cbCombo3_EditValueChanged(sender As System.Object, e As System.EventArgs) 'Handles cbCombo3.EditValueChanged
        If cbCombo3.Text = "" Then
            cbComboDesc3.EditValue = "-1"
            Exit Sub
        End If
        If cbComboDesc3.EditValue.ToString <> cbCombo3.Text Then
            cbComboDesc3.EditValue = cbCombo3.Text
        End If
    End Sub

    Private Sub cbComboDesc3_EditValueChanged(sender As System.Object, e As System.EventArgs) 'Handles cbComboDesc3.EditValueChanged
        If cbComboDesc3.Text = "" Then
            cbCombo3.EditValue = "-1"
            Exit Sub
        End If
        If cbCombo3.EditValue.ToString <> cbComboDesc3.Text Then
            cbCombo3.EditValue = cbComboDesc3.Text
        End If
    End Sub

    Private Sub GridView1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        For x = 0 To dtRep.Rows.Count - 1
            If dtRep.Rows(x)("ColColor").ToString() <> "" Then
                If e.Column.FieldName = dtRep.Rows(x)("Columna").ToString() Then
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml(View.GetRowCellDisplayText(e.RowHandle, View.Columns(dtRep.Rows(x)("ColColor").ToString())))
                End If
            End If
            If dtRep.Rows(x)("ColFont").ToString() <> "" Then
                If e.Column.FieldName = dtRep.Rows(x)("Columna").ToString() Then
                    e.Appearance.ForeColor = System.Drawing.ColorTranslator.FromHtml(View.GetRowCellDisplayText(e.RowHandle, View.Columns(dtRep.Rows(x)("ColFont").ToString())))
                End If
            End If
        Next
    End Sub

End Class