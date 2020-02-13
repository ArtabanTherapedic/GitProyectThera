Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class ProImpEtForm
    Dim Cargando As Boolean = True
    Dim SKU As String = ""
    Dim idEtiqueta As String = ""
    Dim Cantidad As String = ""
    Dim Pedido As String = ""
    Dim Cliente As String = ""
    Dim Tela As String = ""
    Dim JobNum As String = ""
    Dim OP As String = ""
    Dim TipoOP As String = ""
    Dim Motivo As String = ""
    Dim Color As String = ""
    Public ClaseProd As Integer
    Dim SQL As String = ""
    Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo
    Public EtiquetaPT = False

    Private Sub bImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bImprimir.Click
        If cbEtiqueta.Text = "" Then
            MsgBox(Msj00074, MsgBoxStyle.Critical, Empresa & " Msj00074")
            Exit Sub
        End If
        Imprimir()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        bImprimir.Enabled = True
        bExcel.Enabled = True
        bBuscar.Enabled = True
        bLimpiar.Enabled = True
        LImpresion.Visible = False
        pGral.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub bLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLimpiar.Click
        cbOP.SelectedIndex = -1
        eCantidad.Value = 1
        cbArticulo.Text = "" 'cbArticulo.SelectedIndex = -1
        cbidArt.Text = "" 'cbidArt.SelectedIndex = -1
    End Sub

    Private Sub Imprimir()
        bLimpiar.Enabled = False
        bExcel.Enabled = False
        bBuscar.Enabled = False
        LImpresion.Visible = True
        bImprimir.Enabled = False
        Dim rpt
        Dim SQL = ""
        Select Case cbEtiqueta.Text
            Case "Etiqueta de Manufactura"
                rpt = New ETMF01
                'preview.ImageLocation = "\\\\srvdominio\SmarThera\ET01.jpg"
                SQL = " exec spRepEt01 " & JobNum & ", " & eCantidad.Value
            Case "Etiqueta de Medida"
                rpt = New ETMF02
                ' Preview.ImageLocation = "\\\\srvdominio\SmarThera\ET02.jpg"
                SQL = " exec spRepEt02 " & JobNum & ", " & eCantidad.Value
            Case Else
                Preview.ImageLocation = Nothing
                Exit Sub
        End Select
        Try
            If ImprimeCR(cbImpresora.Text, SQL, rpt, 1, Nothing, False) = False Then
                LImpresion.Visible = False
                Timer1.Enabled = True
                rpt.dispose()
            End If
        Catch ex As Exception

        End Try
        Timer1.Enabled = True

        Exit Sub

        SQL = "exec ImpEtiquetaV " & idEtiqueta.ToString
        Select Case SKU.Substring(1, 1)
            Case "1"
                rpt = New EtViajera02 'Colchones
            Case "2" Or "3"
                rpt = New EtViajera03 'Box                
            Case Else
                rpt = New EtViajera04 'Salas
        End Select
        
        Try
            'Dim Transac As SqlTransaction
            'Transac = Conexion01.BeginTransaction
            If ImprimeCR(cbImpresora.Text, SQL, rpt, 1, Nothing, False) = False Then
                MsgBox(Msj00009 & Chr(13) & "OP: " & OP.ToString & ", SKU: " & SKU.ToString & ", Pedido: " & _
                   Pedido.ToString & Chr(13) & MsgBoxStyle.Critical, Empresa & " Msj00009")
                bLimpiar.Enabled = True
                bBuscar.Enabled = True
                bImprimir.Enabled = True
                LImpresion.Visible = False
                bExcel.Enabled = True
                rpt.Dispose()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(Msj00009 & Chr(13) & "OP: " & OP.ToString & ", SKU: " & SKU.ToString & ", Pedido: " & _
                   Pedido.ToString & Chr(13) & ex.Message, MsgBoxStyle.Critical, Empresa & " Msj00009")
            bLimpiar.Enabled = True
            bBuscar.Enabled = True
            bImprimir.Enabled = True
            LImpresion.Visible = False
            bExcel.Enabled = True
            rpt.Dispose()
            Exit Sub
        End Try
        rpt.Dispose()
        bExcel.Enabled = True
        bLimpiar.Enabled = True
        bBuscar.Enabled = True
        bImprimir.Enabled = True
        LImpresion.Visible = False
    End Sub

    Private Sub Imprimir2(ByVal Opcion As Int16, ByVal Consecutivo As String)
        bLimpiar.Enabled = False
        bExcel.Enabled = False
        bBuscar.Enabled = False
        LImpresion.Visible = True
        bImprimir.Enabled = False
        Dim rpt
        Dim SQL = ""
        If EtiquetaPT = True Then
            SQL = "Select EtiquetasProd.SKU, Descripcion, SubString(TipoDesc,1,3)TipoDesc, CodMedida, SubString(MedidaDesc,1,4)MedidaDesc, Consecutivo, Pedido, EtiquetasProd.Tela, " & _
            " 'Piezas: ' +cast(netiqueta as varchar(10)) + ' de ' + cast(TotEtiquetas as varchar(10)) NoPiezas, " & _
            " CompNom, UniResorte, case when len(SKUCTE)> 0 then concat('*',SKUCte, '*') else '' end SKUCte " & _
            " from etiquetasProd with(noLock) left outer join catArticulosPT with(noLock) on etiquetasprod.sku = catArticulosPT.sku left outer join catTipos with(NoLock) " & _
            " on CatArticulosPT.tipo = catTipos.idtipo left outer join catMedidas with(NoLock) on catARticulosPT.medida = CatMEdidas.Codmedida " & _
            " where Consecutivo = " & Consecutivo
            rpt = New EtPT
        Else
            SQL = "exec ImpEtiquetaV " & idEtiqueta.ToString
            Select Case SKU.Substring(1, 1)
                Case "1"
                    rpt = New EtViajera02 'Colchones
                Case "2" Or "3"
                    rpt = New EtViajera03 'Box                
                Case Else
                    rpt = New EtViajera04 'Salas
            End Select
        End If
        Try

            'Dim Transac As SqlTransaction
            'Transac = Conexion01.BeginTransaction
            If ImprimeCR(cbImpresora.Text, SQL, rpt, 1, Nothing, False) = False Then
                MsgBox(Msj00009 & Chr(13) & "OP: " & OP.ToString & ", SKU: " & SKU.ToString & ", Pedido: " & _
                   Pedido.ToString & Chr(13) & MsgBoxStyle.Critical, Empresa & " Msj00009")
                bLimpiar.Enabled = True
                bBuscar.Enabled = True
                bImprimir.Enabled = True
                LImpresion.Visible = False
                bExcel.Enabled = True
                rpt.Dispose()
                Exit Sub
            End If

        Catch ex As Exception

            MsgBox(Msj00009 & Chr(13) & "OP: " & OP.ToString & ", SKU: " & SKU.ToString & ", Pedido: " & _
                   Pedido.ToString & Chr(13) & ex.Message, MsgBoxStyle.Critical, Empresa & " Msj00009")
            bLimpiar.Enabled = True
            bBuscar.Enabled = True
            bImprimir.Enabled = True
            LImpresion.Visible = False
            bExcel.Enabled = True
            rpt.Dispose()
            Exit Sub
        End Try
        rpt.Dispose()

        bExcel.Enabled = True
        bLimpiar.Enabled = True
        bBuscar.Enabled = True
        bImprimir.Enabled = True
        LImpresion.Visible = False
    End Sub

    Private Sub EtiquetasCalForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMain.Visible = True
    End Sub

    Private Sub EtiquetasCalForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbOP.Enabled = True
        'RevisaTipo()
        CargaComboItem()
        cbidArt.Text = ""
        cbArticulo.Text = ""
        'CargaCombos()
        obtener_impresoras(cbImpresora)
    End Sub

    Private Sub CargaComboItem()
        'Dim ds = New DataSet
        'Dim dt = ds.Tables
        'Dim da = New SqlDataAdapter("Select SKU, Descripcion from CatArticulosPT with(Nolock)", Conexion01)
        'da.Fill(ds, "Items")
        'With cbArticulo
        '    .DataSource = ds.Tables("Items")
        '    .DisplayMember = "Descripcion"
        '    .ValueMember = "SKU"
        '    .SelectedIndex = -1
        '    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    .AutoCompleteSource = AutoCompleteSource.ListItems
        'End With
        'Dim ds1 As New DataSet
        'Dim dt1 = ds1.Tables
        'Dim da1 = New SqlDataAdapter("Select SKU, SKU Descripcion from CatArticulosPT with(Nolock)", Conexion01)
        'da1.Fill(ds1, "Items")
        'With cbidArt
        '    .DataSource = ds1.Tables("Items")
        '    .DisplayMember = "SKU"
        '    .ValueMember = "Descripcion"
        '    .SelectedIndex = -1
        '    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    .AutoCompleteSource = AutoCompleteSource.ListItems
        'End With
        Cargando = True
        Dim dsOP As New DataSet
        Dim dtOP = dsOP.Tables
        Dim daOP = New SqlDataAdapter("Select JobNum, (Partnum + ' OP: ' + JobNum + ' - ' + PartDescription) as Descripcion from pilot.Erp.JobHead  with(nolock) where Company = 'ARTABAN2' and substring(partnum,1,1) = '0'  and PartDescription not like ('MUELLE%') and jobclosed = 0  and jobcomplete = 0 and JobEngineered = 1 and JobReleased = 1  order by Partnum, JobNum desc", Conexion01)
        daOP.Fill(dsOP, "Items")
        With cbOP
            .DataSource = dsOP.Tables("Items")
            .DisplayMember = "Descripcion"
            .ValueMember = "JobNum"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        Cargando = False
    End Sub

    Private Function CodigoValido() As Boolean
        CodigoValido = False
        Dim dtCod As New System.Data.DataTable
        Dim daCod As New SqlDataAdapter
        SQL = "Select * from CatArticulosPT with(Nolock) where Estatus = 1 and SKU = '" & SKU & "'"
        If ClaseProd = 1 Then
            SQL = SQL & " and Clase = 'PT' "
        ElseIf ClaseProd = 2 Then
            SQL = SQL & " and Clase = 'BL' "
        End If
        Dim cmdCod As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dtCod)
        If dtCod.Rows.Count > 0 Then CodigoValido = True
    End Function

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub cbArticulo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        If cbArticulo.Items.Count = 0 Then Exit Sub
        If cbArticulo.SelectedIndex = -1 Or cbArticulo.Text = "" Then
            bGenerar.Enabled = False
            cbidArt.SelectedIndex = -1
            cbidArt.Text = ""
        Else
            bGenerar.Enabled = True
            If cbidArt.Items.Count = 0 Then Exit Sub
            If cbidArt.Text <> cbArticulo.SelectedValue Then cbidArt.Text = cbArticulo.SelectedValue
            'cbidArt.SelectedValue = cbArticulo.Text
        End If
    End Sub

    Private Sub cbidArt_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        If cbidArt.Items.Count = 0 Then Exit Sub
        If cbidArt.SelectedIndex = -1 Or cbidArt.Text = "" Then
            bGenerar.Enabled = False
            cbidArt.SelectedIndex = -1
            cbidArt.Text = ""
        Else
            bGenerar.Enabled = True
            If cbArticulo.Items.Count = 0 Or cbidArt.Text = "" Then Exit Sub
            cbArticulo.SelectedValue = cbidArt.SelectedValue
        End If
    End Sub

     
    'Private Sub cbEstilo_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '    RevisaTipo()
    'End Sub

    'Private Sub RevisaTipo()
    '    bImprimir.Enabled = Not chkEstilo.Checked
    '    bBuscar.Enabled = Not chkEstilo.Checked
    '    bExcel.Enabled = Not chkEstilo.Checked
    '    pGrid.Visible = Not chkEstilo.Checked
    '    fFinal.Enabled = Not chkEstilo.Checked
    '    FInicial.Enabled = Not chkEstilo.Checked
    '    eIDEtiqueta.Enabled = Not chkEstilo.Checked
    '    eSKU.Enabled = Not chkEstilo.Checked
    '    cbFechas.Enabled = Not chkEstilo.Checked
    '    pArticulo.Visible = chkEstilo.Checked
    '    bGenerar.Enabled = chkEstilo.Checked
    '    lFechaFab.Visible = chkEstilo.Checked
    '    FechaFab.Visible = chkEstilo.Checked
    '    If chkEstilo.Checked = True Then 'Por articulo
    '        pArticulo.Dock = DockStyle.Fill
    '        CargaComboItem()
    '    Else 'Desde excel
    '        pGrid.Dock = DockStyle.Fill
    '        CargaGrid()
    '    End If

    'End Sub

    Private Sub CargaCombos()
        SQL = "Select JobNum, (JobNum + ' - ' + PartDescription) as Descripcion from pilot.Erp.JobHead  with(nolock) where Company = 'ARTABAN2' and jobclosed = 0 order by JobNum desc"
        Dim dsModelo As New DataTable
        Dim daModelo As New SqlDataAdapter
        Dim cmdModelo As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daModelo.SelectCommand = cmdModelo
        daModelo.Fill(dsModelo)
        'CbNoTrabajo.Properties.DataSource = dsModelo
        'CbNoTrabajo.Properties.ValueMember = "JobNum"
        'CbNoTrabajo.Properties.DisplayMember = "Descripcion"
    End Sub

    'Private Sub CbNoTrabajo_EditValueChanged(sender As System.Object, e As System.EventArgs)
    '    If CbNoTrabajo.Text = "" Then
    '        cbidArt.SelectedIndex = -1
    '    Else
    '        cbidArt.Text = cbOP.SelectedValue
    '    End If
    'End Sub

    Private Sub cbOP_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        If cbOP.Text = "" Then
            cbidArt.SelectedIndex = -1
        Else
            If Cargando = True Then Exit Sub
            Dim SQLArt = "select top 10  job.Partnum, job.PartDescription, job.ProdQty Cantidad, isnull(cte.Name,'') Cliente, Prod.OrderNum Pedido " & _
                " from pilot.erp.jobhead Job with(nolock) " & _
                " left outer join pilot.erp.jobprod Prod with(nolock) on job.company = Prod.Company and job.jobnum = prod.jobnum " & _
                " left outer join pilot.erp.OrderHed OV with(nolock) on Prod.Company = ov.Company and prod.ordernum = ov.ordernum " & _
                " left outer join pilot.erp.customer Cte with(nolock) on ov.company = cte.company and  OV.custnum = cte.custnum " & _
                " where  job.Jobnum =  '" & cbOP.SelectedValue & "'"
            Dim cmdArt As New SqlCommand(SQLArt, Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim daArt As New SqlDataAdapter
            Dim dsArt As New DataTable
            daArt.SelectCommand = cmdArt
            daArt.Fill(dsArt)
            If dsArt.Rows.Count = 0 Then
                cbidArt.SelectedIndex = -1
                Exit Sub
            End If
            cbidArt.Text = dsArt.Rows(0)("Partnum").ToString
            'cbidArt.SelectedValue = cbidArt.Text
            ' cbidArt.SelectedText = dsArt.Rows(0)("Partnum").ToString
            cbArticulo.Text = dsArt.Rows(0)("PartDescription").ToString
            eCantidad.Value = CInt(dsArt.Rows(0)("Cantidad"))
            'ePedidoM.Text = dsArt.Rows(0)("Pedido").ToString
            'eClienteM.Text = dsArt.Rows(0)("Cliente").ToString
        End If
    End Sub

    Private Sub cbOP_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbOP.KeyPress
        Tab(e)
    End Sub

    Private Sub cbidArt_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbidArt.KeyPress
        Tab(e)
    End Sub

    Private Sub cbArticulo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbArticulo.KeyPress
        Tab(e)
    End Sub

    Private Sub eCantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eCantidad.KeyPress
        Tab(e)
    End Sub

    Private Sub ComboBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbEtiqueta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            bImprimir.Focus()
        End If
    End Sub

    Private Sub cbOP_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cbOP.SelectedIndexChanged
        If cbOP.Text = "" Then
            cbidArt.SelectedIndex = -1
        Else
            If Cargando = True Then Exit Sub
            Dim SQLArt = "select top 10  job.Partnum, job.PartDescription, job.ProdQty Cantidad, isnull(cte.Name,'') Cliente, Prod.OrderNum Pedido, Job.Jobnum " & _
                " from pilot.erp.jobhead Job with(nolock) " & _
                " left outer join pilot.erp.jobprod Prod with(nolock) on job.company = Prod.Company and job.jobnum = prod.jobnum " & _
                " left outer join pilot.erp.OrderHed OV with(nolock) on Prod.Company = ov.Company and prod.ordernum = ov.ordernum " & _
                " left outer join pilot.erp.customer Cte with(nolock) on ov.company = cte.company and  OV.custnum = cte.custnum " & _
                " where  job.Jobnum =  '" & cbOP.SelectedValue & "'"
            Dim cmdArt As New SqlCommand(SQLArt, Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim daArt As New SqlDataAdapter
            Dim dsArt As New DataTable
            daArt.SelectCommand = cmdArt
            daArt.Fill(dsArt)
            If dsArt.Rows.Count = 0 Then
                cbidArt.SelectedIndex = -1
                Exit Sub
            End If
            JobNum = "'" & dsArt.Rows(0)("Jobnum").ToString & "'"
            cbidArt.Text = dsArt.Rows(0)("Partnum").ToString
            'cbidArt.SelectedValue = cbidArt.Text
            ' cbidArt.SelectedText = dsArt.Rows(0)("Partnum").ToString
            cbArticulo.Text = dsArt.Rows(0)("PartDescription").ToString
            eCantidad.Value = CInt(dsArt.Rows(0)("Cantidad"))
             
        End If
    End Sub

    Private Sub cbEtiqueta_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbEtiqueta.SelectedValueChanged
        Select Case cbEtiqueta.Text
            Case "Etiqueta de Manufactura"
                Preview.ImageLocation = "\\\\srvdominio\SmarThera\ET01.jpg"
            Case "Etiqueta de Medida"
                Preview.ImageLocation = "\\\\srvdominio\SmarThera\ET02.jpg"
            Case Else
                Preview.ImageLocation = Nothing
        End Select

    End Sub
End Class