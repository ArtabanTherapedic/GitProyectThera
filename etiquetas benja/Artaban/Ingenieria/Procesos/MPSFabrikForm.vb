Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO

Public Class MPSFabrikForm
    Dim SKU As String = ""
    Dim idEtiqueta As String = ""
    Dim Cantidad As String = ""
    Dim Pedido As String = ""
    Dim Cliente As String = ""
    Dim Tela As String = ""
    Dim OP As String = ""
    Dim TipoOP As String = ""
    Dim Motivo As String = ""
    Dim Color As String = ""
    Public ClaseProd As Integer
    Dim SQL As String = ""
    Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo

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
            End If
            OP = GridView1.GetFocusedRowCellValue("OP")
            SKU = GridView1.GetFocusedRowCellValue("SKU")
            idEtiqueta = GridView1.GetFocusedRowCellValue("idEtiqueta")
            Pedido = GridView1.GetFocusedRowCellValue("Pedido")
            Tela = GridView1.GetFocusedRowCellValue("Tela")
            ImprimirPT(2) 'Reimpresion
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
        ePedidoM.Text = ""
        eCantidad.Value = 1
        cbArticulo.SelectedIndex = -1
        eClienteM.Text = ""
    End Sub

    Private Sub Generar()
        Try
            Dim cmd As New SqlCommand("SpGenEtiquetas2", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Opc", SqlDbType.Int).Value = ClaseProd
            cmd.Parameters.Add("@OP", SqlDbType.BigInt).Value = CInt(OP)
            cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = SKU
            cmd.Parameters.Add("@Cliente", SqlDbType.VarChar, 250).Value = Cliente
            cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = CInt(Cantidad)
            cmd.Parameters.Add("@Pedido", SqlDbType.VarChar, 50).Value = Pedido
            cmd.Parameters.Add("@Tela", SqlDbType.VarChar, 250).Value = Tela
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
        ImprimirPT(1)
        'Select Case ClaseProd
        '    Case 1
        '        ImprimirPT(1) 'Impresion por primera vez
        '    Case 2
        '        ImprimirBL(1)
        'End Select

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

    Private Sub ImprimirPT(ByVal Opcion As Int16)
        bLimpiar.Enabled = False
        bExcel.Enabled = False
        bBuscar.Enabled = False
        LImpresion.Visible = True
        bImprimir.Enabled = False
        Dim rpt

        rpt = New EtViajera04 'Salas
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

    Private Sub EtiquetasCalForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMain.Visible = True
    End Sub

    Private Sub EtiquetasCalForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FechaFab.Value = Now.Date
        CargaComboItem()
        RevisaTipo()
        obtener_impresoras(cbImpresora)
    End Sub

    Private Sub CargaComboItem()
        Dim ds = New DataSet
        Dim dt = ds.Tables
        Dim da = New SqlDataAdapter("Select SKU, Descripcion from CatArticulosPT with(Nolock)", Conexion01)
        da.Fill(ds, "Items")
        With cbArticulo
            .DataSource = ds.Tables("Items")
            .DisplayMember = "Descripcion"
            .ValueMember = "SKU"
            .SelectedIndex = -1
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
    End Sub

    Private Sub CargaGrid()
        Dim dtGrid As New System.Data.DataTable
        Dim daGrid As New SqlDataAdapter
        Dim SqlGrid As String = "select idEtiqueta, OP, Consecutivo, EtiquetasProd.SKU, Descripcion, Pedido, Cliente, EtiquetasProd.Tela, nEtiqueta, TotEtiquetas " & _
            " from EtiquetasProd with(Nolock) left outer join CatArticulosPT with(NoLock) on EtiquetasProd.sku = CatArticulosPT.SKU where 1 = 1 "
        If ClaseProd = 1 Then 'PT
            SqlGrid = SqlGrid & " and Clase = 'PT' "
        ElseIf ClaseProd = 2 Then 'Blancos
            SqlGrid = SqlGrid & " And Clase = 'BL' "
        End If
        If cbFechas.Checked = True Then SqlGrid = SqlGrid & " and fIngreso between '" & FInicial.Value.Year.ToString & "-" & FInicial.Value.Month.ToString & "-" & FInicial.Value.Day.ToString & " ' and '" & fFinal.Value.Year.ToString & "-" & fFinal.Value.Month.ToString & "-" & fFinal.Value.Day.ToString & "'"
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
        Dim cmdCod As New SqlCommand(Sql, Conexion01)
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

    Private Sub cbArticulo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        If cbArticulo.SelectedIndex = -1 Or cbArticulo.Text = "" Then
            bGenerar.Enabled = False
        Else
            bGenerar.Enabled = True
        End If
    End Sub

    Private Sub bGenerar_Click(sender As System.Object, e As System.EventArgs) Handles bGenerar.Click
        If cbArticulo.Text = "" Or cbArticulo.SelectedIndex = -1 Then
            MsgBox(Msj00028, MsgBoxStyle.Information, Empresa & " Msj00056")
            Exit Sub
        End If
        Pedido = ePedidoM.Text
        SKU = cbArticulo.SelectedValue
        Cliente = eClienteM.Text
        Tela = eTelaM.Text
        Cantidad = eCantidad.Value.ToString
        If CodigoValido() = False Then
            MsgBox("El Artículo " & SKU & " no existe o está inactivo, Favor de verificarlo.", MsgBoxStyle.Critical, Empresa & "Msj00024")
            Timer1.Enabled = True
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
        pArticulo.Visible = chkEstilo.Checked
        bGenerar.Enabled = chkEstilo.Checked
        If chkEstilo.Checked = True Then 'Por articulo
            pArticulo.Dock = DockStyle.Fill
        Else 'Desde excel
            pGrid.Dock = DockStyle.Fill
            CargaGrid()
        End If

    End Sub
End Class