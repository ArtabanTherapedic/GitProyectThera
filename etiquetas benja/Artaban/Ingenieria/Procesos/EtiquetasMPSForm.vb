Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class EtiquetasMPSForm
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
        If GridView1.SelectedRowsCount > 0 Then
MotReimp:
            Motivo = InputBox("Favor de escribir el Motivo de la Reimpresión. ", "Reimpresion de Etiquetas")
            If Motivo.Length < 10 Then
                If Motivo.Length = 0 Then
                    MsgBox(Msj00028, MsgBoxStyle.Information, Empresa & " MSJ00028")
                    Exit Sub
                End If
                MsgBox(Msj00026, MsgBoxStyle.Critical, Empresa & " MSJ00026")
                GoTo MotReimp
            Else
                Motivo = UCase(Motivo)
                Try
                    Dim cmd As New SqlCommand("spLogEtiquetas", Conexion01)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = 1
                    cmd.Parameters.Add("@Consecutivo", SqlDbType.BigInt).Value = GridView1.GetFocusedRowCellValue("Consecutivo")
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
                    cmd.Parameters.Add("@Motivo", SqlDbType.VarChar, 4000).Value = Motivo  
                    If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                    cmd.ExecuteNonQuery()
                Catch
                    MsgBox(Msj00075 & Chr(13), MsgBoxStyle.Critical, Empresa & " Msj00075")
                    GoTo MotReimp
                    Exit Sub
                End Try
            End If
            OP = GridView1.GetFocusedRowCellValue("OP")
            SKU = GridView1.GetFocusedRowCellValue("SKU")
            idEtiqueta = GridView1.GetFocusedRowCellValue("idEtiqueta")
            Pedido = GridView1.GetFocusedRowCellValue("Pedido")
            Tela = GridView1.GetFocusedRowCellValue("Tela")
            ImprimirPT(2, GridView1.GetFocusedRowCellValue("Consecutivo").ToString) 'Reimpresion
        Else
            MsgBox(Msj00025, MsgBoxStyle.Information, Empresa & " MSJ00025")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If chkEstilo.Checked = True Then
            bGenerar.Enabled = True
        Else
            bImprimir.Enabled = True
            bExcel.Enabled = True
            bBuscar.Enabled = True
        End If
        bLimpiar.Enabled = True
        LImpresion.Visible = False
        pGral.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub bLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLimpiar.Click
        FechaFab.Value = Now.Date
        FInicial.Value = Now.Date
        fFinal.Value = Now.Date
        cbFechas.Checked = False
        eSKU.Text = ""
        ePedido.Text = ""
        eIDEtiqueta.Text = ""
        eTelaM.Text = ""
        CbNoTrabajo.EditValue = ""
        cbOP.SelectedIndex = -1
        ePedidoM.Text = ""
        eCantidad.Value = 1
        cbArticulo.Text = "" 'cbArticulo.SelectedIndex = -1
        cbidArt.Text = "" 'cbidArt.SelectedIndex = -1
        eClienteM.Text = ""
    End Sub

    Private Sub Generar()
        Try
            Dim cmd As New SqlCommand("SpGenEtiquetas", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Opc", SqlDbType.Int).Value = ClaseProd
            cmd.Parameters.Add("@OP", SqlDbType.BigInt).Value = CInt(OP)
            cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = SKU
            cmd.Parameters.Add("@Cliente", SqlDbType.VarChar, 250).Value = Cliente
            cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = CInt(Cantidad)
            cmd.Parameters.Add("@Pedido", SqlDbType.VarChar, 50).Value = Pedido
            cmd.Parameters.Add("@Tela", SqlDbType.VarChar, 250).Value = Tela
            cmd.Parameters.Add("@JobNum", SqlDbType.VarChar, 6).Value = JobNum
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                MsgBox(cmd.Parameters("@Msj").Value.ToString() & Chr(13) & Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
                Exit Sub
            End If
        Catch
            MsgBox(Msj00020 & Chr(13), MsgBoxStyle.Critical, Empresa & " MSJ00020")
            Exit Sub
        End Try
        idEtiqueta = "0"
        Motivo = ""
        Select Case ClaseProd
            Case 1
                ImprimirPT(1, "") 'Impresion por primera vez
            Case 2
                ImprimirBL(1)
        End Select

        'MsgBox(Msj00021, MsgBoxStyle.Information, Empresa & " MSJ00021") 'Se guardo de manera correcta
    End Sub

    Private Sub ImprimirBL(ByVal Opcion As Int16)
        bLimpiar.Enabled = False
        bExcel.Enabled = False
        bBuscar.Enabled = False
        LImpresion.Visible = True
        bImprimir.Enabled = False

        Dim rpt As New EtViajera02
        Try
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
            rpt.SetParameterValue("@IDEtiqueta", idEtiqueta)
            rpt.PrintOptions.PrinterName = cbImpresora.Text
            rpt.PrintToPrinter(1, True, 0, 0)
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
        Threading.Thread.Sleep(3000)
        Try
            Dim cmd As New SqlCommand("SpUPEtiquetas", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = Opcion
            cmd.Parameters.Add("@OP", SqlDbType.BigInt).Value = CInt(OP)
            cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = SKU
            cmd.Parameters.Add("@Pedido", SqlDbType.VarChar, 250).Value = Pedido
            cmd.Parameters.Add("@Motivo", SqlDbType.VarChar, 250).Value = Motivo
            cmd.Parameters.Add("@idEtiqueta", SqlDbType.BigInt).Value = idEtiqueta
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                MsgBox(cmd.Parameters("@Msj").Value.ToString() & Chr(13) & "OP: " & OP.ToString & ", SKU: " & SKU.ToString & _
                       ", Pedido: " & Pedido.ToString & Chr(13) & Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
                bLimpiar.Enabled = True
                bBuscar.Enabled = True
                bExcel.Enabled = True
                bImprimir.Enabled = True
                LImpresion.Visible = False
                Exit Sub
            End If
        Catch
            MsgBox(Msj00024, MsgBoxStyle.Critical, Empresa & " MSJ00024")
            bLimpiar.Enabled = True
            bExcel.Enabled = True
            bBuscar.Enabled = True
            bImprimir.Enabled = True
            LImpresion.Visible = False
            Exit Sub
        End Try
        bExcel.Enabled = True
        bLimpiar.Enabled = True
        bBuscar.Enabled = True
        bImprimir.Enabled = True
        LImpresion.Visible = False
    End Sub

    Private Sub ImprimirPT(ByVal Opcion As Int16, ByVal Consecutivo As String)
        bLimpiar.Enabled = False
        bExcel.Enabled = False
        bBuscar.Enabled = False
        LImpresion.Visible = True
        bImprimir.Enabled = False
        Dim rpt
        Dim SQL = ""
        If EtiquetaPT = True Then
            'SQL = "Select EtiquetasProd.SKU, Descripcion, SubString(TipoDesc,1,3)TipoDesc, CodMedida, SubString(MedidaDesc,1,4)MedidaDesc, Consecutivo, Pedido, EtiquetasProd.Tela, " & _
            '" 'Piezas: ' +cast(netiqueta as varchar(10)) + ' de ' + cast(TotEtiquetas as varchar(10)) NoPiezas, " & _
            '" CompNom, UniResorte, case when len(SKUCTE)> 0 then concat('*',SKUCte, '*') else '' end SKUCte " & _
            '" from etiquetasProd with(noLock) left outer join catArticulosPT with(noLock) on etiquetasprod.sku = catArticulosPT.sku left outer join catTipos with(NoLock) " & _
            '" on CatArticulosPT.tipo = catTipos.idtipo left outer join catMedidas with(NoLock) on catARticulosPT.medida = CatMEdidas.Codmedida " & _
            SQL = "Select EtiquetasProd.SKU, Descripcion, SubString(TipoDesc,1,3)TipoDesc, CodMedida, SubString(MedidaDesc,1,4)MedidaDesc, Consecutivo, Pedido, EtiquetasProd.Tela,   " & _
                " 'Piezas: ' +cast(netiqueta as varchar(10)) + ' de ' + cast(TotEtiquetas as varchar(10)) NoPiezas,  " & _
                " CompNom, ISNULL(Variant,'')  UniResorte, case when isnull(EAN13,'') = '' then '' else concat('*',EAN13, '*') end SKUCte  " & _
                " from etiquetasProd with(noLock) left outer join catArticulosPT with(noLock) on etiquetasprod.sku = catArticulosPT.sku left outer join catTipos with(NoLock)  " & _
                " on CatArticulosPT.tipo = catTipos.idtipo left outer join catMedidas with(NoLock) on catARticulosPT.medida = CatMEdidas.Codmedida " & _
                "   where Consecutivo = " & Consecutivo
            rpt = New EtPT
        Else
            SQL = "exec ImpEtiquetaV " & idEtiqueta.ToString
            Select Case SKU.Substring(1, 1)
                Case "1"
                    rpt = New EtViajera02 'Colchones 
                Case "2"
                    rpt = New EtViajera03 'Box           
                Case "3"
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
                   Pedido.ToString & Chr(13), MsgBoxStyle.Critical, Empresa & " Msj00009")
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
        FechaFab.Value = Now.Date
        cbOP.Enabled = True
        If EtiquetaPT = True Then
            chkEstilo.Checked = False
            chkEstilo.Visible = False
        End If
        RevisaTipo()
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
        Dim SQLOPs = "Select JobNum, (Partnum + ' OP: ' + JobNum + ' - ' + PartDescription) as Descripcion " & _
            " from pilot.Erp.JobHead  with(nolock) where Company = 'ARTABAN2'  " & _
            " and prodqty > qtyCompleted " & _
            " and PartDescription not like ('MUELLE%') " & _
            " and PartDescription not like ('%ALMOHADA%') " & _
            " and PartDescription not like ('%PROTECTOR%') " & _
            " and PartDescription not like ('%FUNDA%') " & _
            " and PartDescription not like ('%SABANA%') " & _
            " and PartDescription not like ('MARCO%') " & _
            " and jobclosed = 0  " & _
            " and jobcomplete = 0 " & _
            " and JobEngineered = 1 " & _
            " and JobReleased = 1   " & _
            " order by Partnum, JobNum desc"
        Dim daOP = New SqlDataAdapter(SQLOPs, Conexion01)
        daOP.Fill(dsOP, "Items")
        With cbOP
            .DataSource = dsOP.Tables("Items")
            .DisplayMember = "Descripcion"
            .ValueMember = "JobNum"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            '.AutoCompleteSource = AutoCompleteSource.ListItems
            '.AutoCompleteSource = autocompletesource.
        End With
        Cargando = False
    End Sub

    Private Sub CargaGrid()
        Dim dtGrid As New System.Data.DataTable
        Dim daGrid As New SqlDataAdapter
        Dim SqlGrid As String = "select idEtiqueta, OP, Consecutivo, EtiquetasProd.SKU, Descripcion, Pedido, Cliente, EtiquetasProd.Tela, nEtiqueta, TotEtiquetas " & _
            " from EtiquetasProd with(Nolock) left outer join CatArticulosPT with(NoLock) on EtiquetasProd.sku = CatArticulosPT.SKU where 1 = 1 "
        If EtiquetaPT = True Then
            SqlGrid = SqlGrid + " and etiquetapt  = 1 "
            If cbFechas.Checked = True Then SqlGrid = SqlGrid & " and FEtiquetaPT between '" & FInicial.Value.Year.ToString & "-" & FInicial.Value.Month.ToString & "-" & FInicial.Value.Day.ToString & " 00:00' and '" & fFinal.Value.Year.ToString & "-" & fFinal.Value.Month.ToString & "-" & fFinal.Value.Day.ToString & " 23:59'"
        Else
            If cbFechas.Checked = True Then SqlGrid = SqlGrid & " and fIngreso between '" & FInicial.Value.Year.ToString & "-" & FInicial.Value.Month.ToString & "-" & FInicial.Value.Day.ToString & " ' and '" & fFinal.Value.Year.ToString & "-" & fFinal.Value.Month.ToString & "-" & fFinal.Value.Day.ToString & "'"
        End If
        If ClaseProd = 1 Then 'PT
            SqlGrid = SqlGrid & " and Clase = 'PT' "
        ElseIf ClaseProd = 2 Then 'Blancos
            SqlGrid = SqlGrid & " And Clase = 'BL' "
        End If
        If eIDEtiqueta.Text <> "" Then SqlGrid = SqlGrid & " and consecutivo = " & eIDEtiqueta.Text
        If ePedido.Text <> "" Then SqlGrid = SqlGrid & " and Pedido = '" & ePedido.Text & "'"
        If eSKU.Text <> "" Then SqlGrid = SqlGrid & " and EtiquetasProd.SKU = " & eSKU.Text
        SqlGrid = SqlGrid & " order by Consecutivo"
        Dim cmdGrid As New SqlCommand(SqlGrid, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daGrid.SelectCommand = cmdGrid
        daGrid.Fill(dtGrid)
        gCatalogo.DataSource = dtGrid
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
                If strExtension = ".xlsx" Or strExtension = ".xls" Then
                    If (File.Exists(xlsx)) Then
                        bExcel.Enabled = False
                        bBuscar.Enabled = False
                        bImprimir.Enabled = False
                        bLimpiar.Enabled = False
                        pGral.Enabled = False
                        If strExtension = "xls" Then
                            xls_cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + xlsx + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'")
                        Else
                            xls_cn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & xlsx & "; Extended Properties='Excel 12.0 Xml;HDR=YES';")
                        End If
                        Dim dt As New DataTable("Datos")
                        Using xls_cn
                            xls_cn.Open()
                            xls_cmd.CommandText = "SELECT * FROM [Hoja1$]"
                            xls_cmd.Connection = xls_cn
                            xls_reader.SelectCommand = xls_cmd
                            Dim da As New OleDbDataAdapter(xls_cmd)
                            da.Fill(dt)
                            If ClaseProd = 1 Then 'Producto Terminado
                                For i = 0 To dt.Rows.Count - 1
                                    If Not IsDBNull(dt.Rows(i).Item("Pedido")) Then Pedido = dt.Rows(i).Item("Pedido").ToString Else Pedido = ""
                                    If Not IsDBNull(dt.Rows(i).Item("SKU")) Then SKU = dt.Rows(i).Item("SKU").ToString Else SKU = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Cliente")) Then Cliente = dt.Rows(i).Item("Cliente").ToString Else Cliente = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Cantidad")) Then Cantidad = dt.Rows(i).Item("Cantidad").ToString Else Cantidad = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Tela")) Then Tela = dt.Rows(i).Item("Tela").ToString Else Tela = ""
                                    If Pedido = "" Or SKU = "" Or Cantidad = "" Or Cliente = "" Or Tela = "" Then
                                        MsgBox(Msj00023, MsgBoxStyle.Critical, Empresa & "Msj00023")
                                        Timer1.Enabled = True
                                        Exit Sub
                                    End If
                                    If CodigoValido() = False Then
                                        MsgBox("El Artículo " & SKU & " no existe o está inactivo, Favor de verificarlo.", MsgBoxStyle.Critical, Empresa & "Msj00024")
                                        Timer1.Enabled = True
                                        Exit Sub
                                    End If
                                Next
                                For i = 0 To dt.Rows.Count - 1
                                    If Not IsDBNull(dt.Rows(i).Item("Pedido")) Then Pedido = dt.Rows(i).Item("Pedido").ToString Else Pedido = ""
                                    If Not IsDBNull(dt.Rows(i).Item("SKU")) Then SKU = dt.Rows(i).Item("SKU").ToString Else SKU = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Cliente")) Then Cliente = dt.Rows(i).Item("Cliente").ToString Else Cliente = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Cantidad")) Then Cantidad = dt.Rows(i).Item("Cantidad").ToString Else Cantidad = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Tela")) Then Tela = dt.Rows(i).Item("Tela").ToString Else Tela = ""
                                    TipoOP = CStr(SKU).Substring(1, 1)
                                    OP = CStr(Microsoft.VisualBasic.DateAndTime.Year(FechaFab.Value)).Substring(2, 2) & Format(Microsoft.VisualBasic.DateAndTime.Month(FechaFab.Value), "00") & Format(Microsoft.VisualBasic.DateAndTime.Day(FechaFab.Value), "00") & TipoOP
                                    Generar()
                                Next
                            ElseIf ClaseProd = 2 Then 'Blancos
                                For i = 0 To dt.Rows.Count - 1
                                    If Not IsDBNull(dt.Rows(i).Item("SKU")) Then SKU = dt.Rows(i).Item("SKU").ToString Else SKU = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Cantidad")) Then Cantidad = dt.Rows(i).Item("Cantidad").ToString Else Cantidad = ""
                                    If SKU = "" Or Cantidad = "" Then
                                        MsgBox(Msj00023, MsgBoxStyle.Critical, Empresa & "Msj00023")
                                        Timer1.Enabled = True
                                        Exit Sub
                                    End If
                                Next
                                For i = 0 To dt.Rows.Count - 1
                                    If Not IsDBNull(dt.Rows(i).Item("SKU")) Then SKU = dt.Rows(i).Item("SKU").ToString Else SKU = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Cantidad")) Then Cantidad = dt.Rows(i).Item("Cantidad").ToString Else Cantidad = ""
                                    TipoOP = CStr(SKU).Substring(1, 1)
                                    OP = CStr(Microsoft.VisualBasic.DateAndTime.Year(FechaFab.Value)).Substring(2, 2) & Format(Microsoft.VisualBasic.DateAndTime.Month(FechaFab.Value), "00") & Format(Microsoft.VisualBasic.DateAndTime.Day(FechaFab.Value), "00") & TipoOP
                                    Generar()
                                Next
                            End If
                        End Using
                    End If
                    'Limpiar()
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

    Private Sub cbModelo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Tab(e)
    End Sub

    Private Sub eOP_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Tab(e)
    End Sub

    Private Sub eNoPiezas_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Tab(e)
    End Sub

    Private Sub FechaFab_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Tab(e)
    End Sub

    Private Sub cbComposicion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Tab(e)
    End Sub

    Private Sub cbColor1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Tab(e)
    End Sub

    Private Sub cbCliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Tab(e)
    End Sub

    Private Sub cbTPV_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Tab(e)
    End Sub

    Private Sub cbDecorativos_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        Tab(e)
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        CargaGrid()
    End Sub

    Private Sub cbArticulo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbArticulo.SelectedIndexChanged
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

    Private Sub cbidArt_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbidArt.SelectedIndexChanged
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

    Private Sub bGenerar_Click(sender As System.Object, e As System.EventArgs) Handles bGenerar.Click
        If cbidArt.Text = "" Then 'Or cbArticulo.SelectedIndex = -1 Then
            MsgBox(Msj00028, MsgBoxStyle.Information, Empresa & " Msj00056")
            Exit Sub
        End If
        
        Pedido = ePedidoM.Text
        SKU = cbidArt.Text 'cbArticulo.SelectedValue
        Cliente = eClienteM.Text
        Tela = eTelaM.Text
        JobNum = cbOP.SelectedValue ' CbNoTrabajo.EditValue
        Cantidad = eCantidad.Value.ToString
        If CodigoValido() = False Then
            MsgBox("El Artículo " & SKU & " no existe o está inactivo, Favor de verificarlo.", MsgBoxStyle.Critical, Empresa & "Msj00024")
            Timer1.Enabled = True
            Exit Sub
        End If
        Dim dtOP As DataTable = New DataTable
        Dim daOP As SqlDataAdapter = New SqlDataAdapter()
        Dim SQL As String = "select   OP.Jobnum, isnull(oper.Operacion,0)as Operacion, OP.JobClosed Cerrado, OP.JobComplete Completo, OP.JobEngineered Ingenieria, OP.JobReleased Aprobado, isnull(op.jobnum,'')OP " & _
            " from  pilot.erp.jobhead OP with(nolock) " & _
            " left outer join ( select jobnum, Max(OprSeq)Operacion from pilot.erp.joboper with(nolock) " & _
            " where company = 'ARTABAN2'  and AssemblySeq = 0 group by jobnum )as Oper on op.jobnum = Oper.Jobnum " & _
            " where  Company = 'Artaban2' and op.jobnum = '" & JobNum & "'"
        Dim cmdOP As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daOP.SelectCommand = cmdOP
        daOP.Fill(dtOP)
        If dtOP.Rows.Count = 0 Then
            MsgBox("Código inválido, intentar de nuevo.", MsgBoxStyle.Critical)  
            Exit Sub
        End If
        If dtOP.Rows(0)("OP") = "" Then
            MsgBox("No existe la Orden de trabajo", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If dtOP.Rows(0)("Cerrado") = 1 Then
            MsgBox("La Orden de Producción está cerrada.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If dtOP.Rows(0)("Completo") = 1 Then
            MsgBox("La Orden de Producción está Completa.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If dtOP.Rows(0)("Ingenieria") = 0 Then
            MsgBox("La Orden de Producción no tiene Ingenieria Aprobada.", MsgBoxStyle.Critical)  
            Exit Sub
        End If
        If dtOP.Rows(0)("Aprobado") = 0 Then
            MsgBox("La Orden de Producción no está Aprobada.", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If dtOP.Rows(0)("Operacion") = 0 Then
            MsgBox("La OP no cuenta con Operaciones de producción.", MsgBoxStyle.Critical)  
            Exit Sub
        End If
        TipoOP = CStr(SKU).Substring(1, 1)
        OP = CStr(Microsoft.VisualBasic.DateAndTime.Year(FechaFab.Value)).Substring(2, 2) & Format(Microsoft.VisualBasic.DateAndTime.Month(FechaFab.Value), "00") & Format(Microsoft.VisualBasic.DateAndTime.Day(FechaFab.Value), "00") & TipoOP
        Generar()
    End Sub

    Private Sub cbEstilo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEstilo.CheckedChanged
        RevisaTipo()
    End Sub

    Private Sub RevisaTipo()
        bImprimir.Enabled = Not chkEstilo.Checked
        bBuscar.Enabled = Not chkEstilo.Checked
        bExcel.Enabled = Not chkEstilo.Checked
        pGrid.Visible = Not chkEstilo.Checked
        fFinal.Enabled = Not chkEstilo.Checked
        FInicial.Enabled = Not chkEstilo.Checked
        eIDEtiqueta.Enabled = Not chkEstilo.Checked
        eSKU.Enabled = Not chkEstilo.Checked
        cbFechas.Enabled = Not chkEstilo.Checked
        pArticulo.Visible = chkEstilo.Checked
        bGenerar.Enabled = chkEstilo.Checked
        lFechaFab.Visible = chkEstilo.Checked
        FechaFab.Visible = chkEstilo.Checked
        If chkEstilo.Checked = True Then 'Por articulo
            pArticulo.Dock = DockStyle.Fill
            CargaComboItem()
        Else 'Desde excel
            pGrid.Dock = DockStyle.Fill
            CargaGrid()
        End If

    End Sub
    Private Sub CargaCombos()
        SQL = "Select JobNum, (JobNum + ' - ' + PartDescription) as Descripcion from pilot.Erp.JobHead  with(nolock) where Company = 'ARTABAN2' and jobclosed = 0 order by JobNum desc"
        Dim dsModelo As New DataTable
        Dim daModelo As New SqlDataAdapter
        Dim cmdModelo As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daModelo.SelectCommand = cmdModelo
        daModelo.Fill(dsModelo)
        CbNoTrabajo.Properties.DataSource = dsModelo
        CbNoTrabajo.Properties.ValueMember = "JobNum"
        CbNoTrabajo.Properties.DisplayMember = "Descripcion"
    End Sub

    'Private Sub CbNoTrabajo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CbNoTrabajo.EditValueChanged
    '    If CbNoTrabajo.Text = "" Then
    '        cbidArt.SelectedIndex = -1
    '    Else
    '        cbidArt.Text = cbOP.SelectedValue
    '    End If
    'End Sub

    'Private Sub cbOP_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbOP.SelectedIndexChanged

    'End Sub

    Private Sub cbOP_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbOP.SelectedValueChanged

        If cbOP.Text = "" Then
            cbidArt.SelectedIndex = -1
        Else
            If Cargando = True Then Exit Sub
            Dim SQLArt = "select top 10  job.Partnum, job.PartDescription, job.ProdQty Cantidad, isnull(cte.Name,'') Cliente, Prod.OrderNum Pedido " & _
                " from pilot.erp.jobhead Job with(nolock) " & _
                " left outer join pilot.erp.jobprod Prod with(nolock) on job.company = Prod.Company and job.jobnum = prod.jobnum " & _
                " left outer join pilot.erp.OrderHed OV with(nolock) on Prod.Company = ov.Company and prod.ordernum = ov.ordernum " & _
                " left outer join pilot.erp.customer Cte with(nolock) on ov.company = cte.company and  OV.custnum = cte.custnum " & _
                " where job.company = 'ARTABAN2' and job.Jobnum =  '" & cbOP.SelectedValue & "'"
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
            ePedidoM.Text = dsArt.Rows(0)("Pedido").ToString
            eClienteM.Text = dsArt.Rows(0)("Cliente").ToString
        End If
    End Sub
     
    Private Sub cbOP_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbOP.SelectedIndexChanged
        If cbOP.Text = "" Then
            cbidArt.SelectedIndex = -1
        Else
            If Cargando = True Then Exit Sub
            Dim SQLArt = "select top 10  job.Partnum, job.PartDescription, job.ProdQty Cantidad, isnull(cte.Name,'') Cliente, Prod.OrderNum Pedido " & _
                " from pilot.erp.jobhead Job with(nolock) " & _
                " left outer join pilot.erp.jobprod Prod with(nolock) on job.company = Prod.Company and job.jobnum = prod.jobnum " & _
                " left outer join pilot.erp.OrderHed OV with(nolock) on Prod.Company = ov.Company and prod.ordernum = ov.ordernum " & _
                " left outer join pilot.erp.customer Cte with(nolock) on ov.company = cte.company and  OV.custnum = cte.custnum " & _
                " where job.company = 'ARTABAN2' and job.Jobnum =  '" & cbOP.SelectedValue & "'"
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
            ePedidoM.Text = dsArt.Rows(0)("Pedido").ToString
            eClienteM.Text = dsArt.Rows(0)("Cliente").ToString
        End If
    End Sub

    Private Sub FInicial_ValueChanged(sender As System.Object, e As System.EventArgs) Handles FInicial.ValueChanged

    End Sub
End Class