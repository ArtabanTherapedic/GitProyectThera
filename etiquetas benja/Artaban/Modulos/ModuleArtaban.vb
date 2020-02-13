Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Drawing.Printing
Module ModuleArtaban
   
    'Public DataBase As String
    'Public Server As String
    'Public dbUser As String
    'Public dbPW As String
    Public Conexion01 As New SqlConnection
    Public PathFileConf As String = "c:\Artaban\Config.cfg"
    Public Structure dbDatos
        Public DataBase As String
        Public Server As String
        Public dbUser As String
        Public dbPW As String
    End Structure

    Public dtAcceso As New System.Data.DataTable
    Public daAcceso As New SqlDataAdapter
    Public nRev As Integer
    Public DatosCon As New dbDatos
    Public Top01 As Int16 = -20
    Public Top02 As Int16 = -20
    Public Top03 As Int16 = -20
    Public Top04 As Int16 = -20
    Public Top05 As Int16 = -20
    Public Top06 As Int16 = -20
    Public Top07 As Int16 = -20
    Public Top08 As Int16 = -20
    Public Top09 As Int16 = -20
    Public Top10 As Int16 = -20
    Public Top11 As Int16 = -20
    Public Top12 As Int16 = -20
    Public Top13 As Int16 = -20
    Public Top14 As Int16 = -20
    Public Top15 As Int16 = -20
    Public Top16 As Int16 = -20
    Public Top17 As Int16 = -20
    Public Top18 As Int16 = -20
    Public Top19 As Int16 = -20
    Public Top2 As Int16 = -20
    Public Top20 As Int16 = -20
    Public Top21 As Int16 = -20
    Public Usuario As String = ""
    Public UsEmpresa As String = ""
    Public Nombre As String = ""

    Public Sub SoloEnteros(e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub ImportaCodPT(ByVal TipoImp As Integer)
        If MsgBox(Msj00053, MsgBoxStyle.YesNo, Empresa & " Msj00053") = MsgBoxResult.No Then Exit Sub
        Dim xls_cn As New OleDbConnection
        Dim xls_cmd As New OleDbCommand
        Dim xls_reader As New OleDbDataAdapter
        Dim xlsx As String
        Dim patharchivo As New OpenFileDialog
        Dim Tipo = ""
        Dim IDTipo = ""
        Dim Linea = ""
        Dim idLinea = ""
        Dim Modelo = ""
        Dim idModelo = ""
        Dim Medida = ""
        Dim IDMedida = ""
        Dim idArticulo = ""
        Dim P10 = ""
        Dim P20 = ""
        Dim P30 = ""
        Dim P40 = ""
        Dim P50 = ""
        Dim P60 = ""
        Dim P70 = ""
        Dim P80 = ""
        Dim P90 = ""
        Dim P100 = ""
        Dim P110 = ""
        Dim P120 = ""
        Dim P130 = ""
        Dim P140 = ""
        Dim P150 = ""
        Dim P160 = ""
        Dim Color = ""
        Dim SKU = ""
        Dim Garantia = ""
        Dim Composicion = ""
        Dim UnidResorte = ""
        Dim LogName = Now.ToString
        Dim LogData = ""
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
                        If strExtension = ".xlsx" Then
                            xls_cn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & xlsx & "; Extended Properties='Excel 12.0 Xml;HDR=YES';")
                        Else
                            xls_cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + xlsx + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'")
                        End If
                        Dim dt As New DataTable("Datos")
                        Using xls_cn
                            xls_cn.Open()
                            xls_cmd.CommandText = "SELECT * FROM [Hoja1$]"
                            xls_cmd.Connection = xls_cn
                            xls_reader.SelectCommand = xls_cmd
                            Dim da As New OleDbDataAdapter(xls_cmd)
                            da.Fill(dt)
                            For i = 0 To dt.Rows.Count - 1
                                If Not IsDBNull(dt.Rows(i).Item("TIPO")) Then Tipo = dt.Rows(i).Item("TIPO") Else Tipo = ""
                                If Not IsDBNull(dt.Rows(i).Item("CODIGO TIPO")) Then IDTipo = Format(CInt(dt.Rows(i).Item("CODIGO TIPO")), "00") Else IDTipo = ""
                                If Not IsDBNull(dt.Rows(i).Item("LINEA")) Then Linea = dt.Rows(i).Item("LINEA").ToString Else Linea = ""
                                If Not IsDBNull(dt.Rows(i).Item("CODIGO LINEA")) Then idLinea = Format(CInt(dt.Rows(i).Item("CODIGO LINEA")), "00") Else idLinea = ""
                                If Not IsDBNull(dt.Rows(i).Item("MODELO")) Then Modelo = dt.Rows(i).Item("MODELO").ToString Else Modelo = ""
                                If Not IsDBNull(dt.Rows(i).Item("CODIGO MODELO")) Then idModelo = Format(CInt(dt.Rows(i).Item("CODIGO MODELO")), "0000").ToString Else idModelo = ""
                                If Not IsDBNull(dt.Rows(i).Item("MEDIDA")) Then Medida = dt.Rows(i).Item("MEDIDA").ToString Else Medida = ""
                                If Not IsDBNull(dt.Rows(i).Item("CODIGO MEDIDA")) Then IDMedida = dt.Rows(i).Item("CODIGO MEDIDA").ToString Else IDMedida = ""
                                If Not IsDBNull(dt.Rows(i).Item("CODIGO CONCATENADO")) Then idArticulo = dt.Rows(i).Item("CODIGO CONCATENADO").ToString Else idArticulo = ""
                                If TipoImp = 1 Then ' Cuando es importacion de codigos de PT
                                    If Not IsDBNull(dt.Rows(i).Item("SKU")) Then SKU = dt.Rows(i).Item("SKU").ToString Else SKU = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Garantia")) Then Garantia = dt.Rows(i).Item("Garantia").ToString Else Garantia = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Composicion")) Then Composicion = dt.Rows(i).Item("Composicion").ToString Else Composicion = ""
                                    If Not IsDBNull(dt.Rows(i).Item("Unidad de Resorte")) Then UnidResorte = dt.Rows(i).Item("Unidad de Resorte").ToString Else UnidResorte = ""
                                    If Not IsDBNull(dt.Rows(i).Item("10 CERRADO TAPA")) Then P10 = dt.Rows(i).Item("10 CERRADO TAPA").ToString Else P10 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("20 PEGADO TAPA")) Then P20 = dt.Rows(i).Item("20 PEGADO TAPA").ToString Else P20 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("30 CERRADO DOBLE TAPA")) Then P30 = dt.Rows(i).Item("30 CERRADO DOBLE TAPA").ToString Else P30 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("40 PEGADO DOBLE TAPA")) Then P40 = dt.Rows(i).Item("40 PEGADO DOBLE TAPA").ToString Else P40 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("50 CERRADO BORDE")) Then P50 = dt.Rows(i).Item("50 CERRADO BORDE").ToString Else P50 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("60 ARMADO")) Then P60 = dt.Rows(i).Item("60 ARMADO").ToString Else P60 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("70 UNION DE BORDE")) Then P70 = dt.Rows(i).Item("70 UNION DE BORDE").ToString Else P70 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("80 BORDADO")) Then P80 = dt.Rows(i).Item("80 BORDADO").ToString Else P80 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("90 CORTE DE ARO")) Then P90 = dt.Rows(i).Item("90 CORTE DE ARO").ToString Else P90 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("100 CAPIT TAPA")) Then P100 = dt.Rows(i).Item("100 CAPIT TAPA").ToString Else P100 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("110 CERRADO COLCHONETA")) Then P110 = dt.Rows(i).Item("110 CERRADO COLCHONETA").ToString Else P110 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("120 PEGADO COLCHONETA")) Then P120 = dt.Rows(i).Item("120 PEGADO COLCHONETA").ToString Else P120 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("130 EMBOLSADO")) Then P130 = dt.Rows(i).Item("130 EMBOLSADO").ToString Else P130 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("140 TAPIZADO")) Then P140 = dt.Rows(i).Item("140 TAPIZADO").ToString Else P140 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("150 FUNDA BOX")) Then P150 = dt.Rows(i).Item("150 FUNDA BOX").ToString Else P150 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("160 CORTE ARO BOX")) Then P160 = dt.Rows(i).Item("160 CORTE ARO BOX").ToString Else P160 = ""
                                    If Not IsDBNull(dt.Rows(i).Item("COLOR")) Then Color = dt.Rows(i).Item("COLOR").ToString Else Color = ""
                                Else
                                    If Not IsDBNull(dt.Rows(i).Item("Nombre Producto")) Then Color = dt.Rows(i).Item("Nombre Producto").ToString Else Color = ""
                                End If
                                If IDTipo = "" Then
                                    LogData = LogData + "El articulo " + idArticulo + " no tiene un codigo de tipo no valido." + Chr(13)
                                    Continue For
                                End If
                                If idLinea = "" Then
                                    LogData = LogData + "El articulo " + idArticulo + " no tiene un codigo de linea no valido." + Chr(13)
                                    Continue For
                                End If
                                If idModelo = "" Then
                                    LogData = LogData + "El articulo " + idArticulo + " no tiene un codigo de modelo no valido." + Chr(13)
                                    Continue For
                                End If
                                If IDMedida = "" Then
                                    LogData = LogData + "El articulo " + idArticulo + " no tiene un codigo de medida no valido." + Chr(13)
                                    Continue For
                                End If
                                If idArticulo <> (IDTipo & idLinea & idModelo & IDMedida) Then
                                    LogData = LogData & "El Codigo del concatenado del articulo " + idArticulo + " no es valido" & Chr(13)
                                    Continue For
                                End If
                                If Not ValidaTipo(IDTipo, Tipo) Then
                                    LogData = LogData + "Existe un conflicto con el codigo de tipo del articulo " + idArticulo + Chr(13)
                                    Continue For
                                End If
                                If Not ValidaLinea(idLinea, Linea) Then
                                    LogData = LogData + "Existe un conflicto con el codigo de linea del articulo " + idArticulo + Chr(13)
                                    Continue For
                                End If
                                If Not ValidaModelo(idModelo, idLinea, Modelo) Then
                                    LogData = LogData + "Existe un conflicto con el codigo de modelo del articulo " + idArticulo + Chr(13)
                                    Continue For
                                End If
                                If Not ValidaMedida(IDMedida, Medida) Then
                                    LogData = LogData + "Existe un conflicto con el codigo del Tipo del articulo " + idArticulo + Chr(13)
                                    Continue For
                                End If
                                If Not ValidaArticulo(idArticulo) Then ' Si no existe el artículo se da de alta
                                    Try
                                        Dim cmd As New SqlCommand("spUPArticuloPT", Conexion01)
                                        cmd.CommandType = CommandType.StoredProcedure
                                        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = TipoImp '1 = PT 2 = Blancos
                                        cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = idArticulo
                                        cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = IDTipo
                                        cmd.Parameters.Add("@Linea", SqlDbType.Int).Value = idLinea
                                        cmd.Parameters.Add("@Modelo", SqlDbType.Int).Value = idModelo
                                        cmd.Parameters.Add("@Medida", SqlDbType.VarChar, 50).Value = IDMedida
                                        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
                                        cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
                                        cmd.Parameters.Add("@Color", SqlDbType.VarChar, 250).Value = Color
                                        cmd.Parameters.Add("@Composicion", SqlDbType.VarChar, 250).Value = Composicion
                                        cmd.Parameters.Add("@Garantia", SqlDbType.VarChar, 250).Value = Garantia
                                        cmd.Parameters.Add("@SKUCte", SqlDbType.VarChar, 15).Value = SKU
                                        cmd.Parameters.Add("@UniResorte", SqlDbType.VarChar, 15).Value = UnidResorte
                                        cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
                                        cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
                                        cmd.Parameters("@Msj").Direction = ParameterDirection.Output
                                        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                                        cmd.ExecuteNonQuery()
                                        If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                                            LogData = LogData & "Ocurrio un error al guardar el Articulo " & idArticulo + Chr(13) + cmd.Parameters("@Msj").Value.ToString() + Chr(13)
                                            Continue For
                                        End If
                                    Catch
                                        LogData = LogData & "Ocurrio un error al guardar el Articulo " & idArticulo + Chr(13)
                                        Continue For
                                    End Try
                                Else
                                    Try
                                        Dim cmd As New SqlCommand("spUPArticuloPT", Conexion01)
                                        cmd.CommandType = CommandType.StoredProcedure
                                        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 3 '1 = PT 2 = Blancos 3 = Actualizar PT
                                        cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = idArticulo
                                        cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = IDTipo
                                        cmd.Parameters.Add("@Linea", SqlDbType.Int).Value = idLinea
                                        cmd.Parameters.Add("@Modelo", SqlDbType.Int).Value = idModelo
                                        cmd.Parameters.Add("@Medida", SqlDbType.VarChar, 50).Value = IDMedida
                                        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
                                        cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
                                        cmd.Parameters.Add("@Color", SqlDbType.VarChar, 250).Value = Color
                                        cmd.Parameters.Add("@Composicion", SqlDbType.VarChar, 250).Value = Composicion
                                        cmd.Parameters.Add("@Garantia", SqlDbType.VarChar, 250).Value = Garantia
                                        cmd.Parameters.Add("@SKUCte", SqlDbType.VarChar, 15).Value = SKU
                                        cmd.Parameters.Add("@UniResorte", SqlDbType.VarChar, 15).Value = UnidResorte
                                        cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
                                        cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
                                        cmd.Parameters("@Msj").Direction = ParameterDirection.Output
                                        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                                        cmd.ExecuteNonQuery()
                                        If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                                            LogData = LogData & "Ocurrio un error al guardar el Articulo " & idArticulo + Chr(13) + cmd.Parameters("@Msj").Value.ToString() + Chr(13)
                                            Continue For
                                        End If
                                    Catch
                                        LogData = LogData & "Ocurrio un error al guardar el Articulo " & idArticulo + Chr(13)
                                        Continue For
                                    End Try
                                End If
                                If TipoImp = 1 Then
                                    If GeneraProcesos(idArticulo, P10, P20, P30, P40, P50, P60, P70, P80, P90, P100, P110, P120, P130, P140, P150, P160) = False Then
                                        LogData = LogData & "Ocurrio un error al generar los procesos del Artículo " & idArticulo + Chr(13)
                                        Continue For
                                    End If
                                End If
                            Next

                        End Using
                    End If
                    'Limpiar()
                Else
                    MsgBox(Msj00054, MsgBoxStyle.Critical, Empresa & " Msj00054")
                    'Exit Sub
                End If
            End If
        Catch ex As Exception
            LogData = "Error: " & ex.Message
            'Exit Sub
        End Try
        If LogData <> "" Then
            MsgBox(LogData, MsgBoxStyle.Critical)
        Else
            MsgBox(Msj00055, MsgBoxStyle.Information, Empresa & " MSJ00055")
        End If
    End Sub

    Private Function GeneraProcesos(ByVal idArticulo As String, ByVal P10 As String, ByVal P20 As String, ByVal P30 As String, ByVal P40 As String, _
                                    ByVal P50 As String, ByVal P60 As String, ByVal P70 As String, ByVal P80 As String, ByVal P90 As String, _
                                    ByVal P100 As String, ByVal P110 As String, ByVal P120 As String, ByVal P130 As String, ByVal P140 As String, _
                                    ByVal P150 As String, ByVal P160 As String) As Boolean
        GeneraProcesos = False
        Try
            Dim cmd As New SqlCommand("spUpRutaProceso", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 0 'Elimina Procesos
            cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = idArticulo
            cmd.Parameters.Add("@idPro", SqlDbType.Int).Value = 0
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                Exit Function
            End If
        Catch
            Exit Function
        End Try
        'linea normal
        If P100.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 10) = False Then Exit Function
        End If
        If P90.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 9) = False Then Exit Function
        End If
        If P80.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 8) = False Then Exit Function
        End If
        If P70.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 7) = False Then Exit Function
        End If
        If P60.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 6) = False Then Exit Function
        End If
        If P50.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 5) = False Then Exit Function
        End If
        If P40.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 4) = False Then Exit Function
        End If
        If P20.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 2) = False Then Exit Function
        End If
        If P30.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 3) = False Then Exit Function
        End If
        If P10.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 1) = False Then Exit Function
        End If
        'linea doss
        If P110.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 11) = False Then Exit Function
        End If
        If P120.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 12) = False Then Exit Function
        End If
        'bases
        If P160.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 16) = False Then Exit Function
        End If
        If P150.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 15) = False Then Exit Function
        End If
        If P140.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 14) = False Then Exit Function
        End If

        'embolsado final
        If P130.ToString.ToUpper = "X" Then
            If InsProceso(idArticulo, 13) = False Then Exit Function
        End If

        GeneraProcesos = True
    End Function

    Private Function InsProceso(ByVal IdArt As String, ByVal Proceso As Integer) As Boolean
        InsProceso = False
        Try
            Dim cmd As New SqlCommand("spUpRutaProceso", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1 'Inserta Registro
            cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = IdArt
            cmd.Parameters.Add("@idPro", SqlDbType.Int).Value = Proceso
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                Exit Function
            End If
        Catch
            Exit Function
        End Try
        InsProceso = True
    End Function

    Private Function ValidaArticulo(ByVal IdArticulo As String) As Boolean
        ValidaArticulo = False
        Dim dtCod As New System.Data.DataTable
        Dim daCod As New SqlDataAdapter
        Dim cmdCod As New SqlCommand("Select * from CatArticulosPT with(Nolock) where SKU = '" & IdArticulo & "'", Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dtCod)
        If dtCod.Rows.Count > 0 Then
            ValidaArticulo = True
        End If

    End Function

    Private Function ValidaTipo(ByVal idTipo As String, ByVal Desc As String) As Boolean
        ValidaTipo = False
        Dim dtCod As New System.Data.DataTable
        Dim daCod As New SqlDataAdapter
        Dim cmdCod As New SqlCommand("Select * from CatTipos with(Nolock) where idTipo = " & idTipo, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dtCod)
        If dtCod.Rows.Count > 0 Then
            ValidaTipo = True
        Else
            Dim cmdIns As New SqlCommand("Insert into CatTipos(idTipo, TipoDesc, TipoObs, TipoActivo) Select " & idTipo & ", '" & Desc & "', '', 1", Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Try
                cmdIns.ExecuteNonQuery()
                ValidaTipo = True
            Catch
                ValidaTipo = False
            End Try
        End If
    End Function

    Private Function ValidaMedida(ByVal idMedida As String, ByVal Desc As String) As Boolean
        ValidaMedida = False
        Dim dtCod As New System.Data.DataTable
        Dim daCod As New SqlDataAdapter
        Dim cmdCod As New SqlCommand("Select * from CatMedidas with(Nolock) where CodMedida = '" & idMedida & "'", Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dtCod)
        If dtCod.Rows.Count > 0 Then
            ValidaMedida = True
        Else
            Dim cmdIns As New SqlCommand("Insert into CatMedidas(MedidaDesc, MedidaObs, MedidaActivo, CodMedida) Select '" & Desc & "', '', 1, '" & idMedida & "'", Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Try
                cmdIns.ExecuteNonQuery()
                ValidaMedida = True
            Catch
                ValidaMedida = False
            End Try
        End If
    End Function

    Private Function ValidaLinea(ByVal idLinea As String, ByVal Desc As String) As Boolean
        ValidaLinea = False
        Dim dtCod As New System.Data.DataTable
        Dim daCod As New SqlDataAdapter
        Dim cmdCod As New SqlCommand("Select * from CatLineas with(Nolock) where idLinea = " & idLinea, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dtCod)
        If dtCod.Rows.Count > 0 Then
            ValidaLinea = True
        Else
            Dim cmdIns As New SqlCommand("Insert into CatLineas(idLinea, LineaDesc, LineaObs, LineaActivo) Select " & idLinea & ", '" & Desc & "', '', 1", Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Try
                cmdIns.ExecuteNonQuery()
                ValidaLinea = True
            Catch
                ValidaLinea = False
            End Try
        End If
    End Function

    Private Function ValidaModelo(ByVal idModelo As String, ByVal idLinea As String, ByVal Desc As String) As Boolean
        ValidaModelo = False
        Dim dtCod As New System.Data.DataTable
        Dim daCod As New SqlDataAdapter
        Dim cmdCod As New SqlCommand("Select * from CatModelos with(Nolock) where idModelo = " & idModelo & " and idLinea = " & idLinea, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dtCod)
        If dtCod.Rows.Count > 0 Then
            ValidaModelo = True
        Else
            Dim cmdIns As New SqlCommand("Insert into CatModelos(idModelo, idLinea, ModeloDesc, ModeloObs, ModeloActivo) Select " & idModelo & ", " & idLinea & ", '" & Desc & "', '', 1", Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Try
                cmdIns.ExecuteNonQuery()
                ValidaModelo = True
            Catch
                ValidaModelo = False
            End Try
        End If
    End Function

    Public Sub obtener_impresoras(ByVal sender As Object)
        'Sender es el objeto donde se veran las impresoras
        'en este caso yo utilizo un ListBox pero podria tambien ser un ComboBox
        'un List, entre otros que sean de tipo collections
        Dim pd As New PrintDocument
        'Se define el print Document.
        Dim impresora_predeterminada As String = pd.PrinterSettings.PrinterName
        'Todo muy claro pero en ingles, se asigna en una variable el nombre
        'de la impresora predeterminada.
        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            'Por todas las impresoras instaladas ir agregandolas al objeto sender
            sender.Items.Add(PrinterSettings.InstalledPrinters.Item(i).ToString)
        Next
        For i = 0 To sender.Items.Count - 1
            If sender.Items.Item(i).ToString = impresora_predeterminada Then
                'La impresora de la lista que posea el nombre de la predeterminada
                'sera la seleccionada
                sender.SelectedIndex = i
            End If
        Next
    End Sub

    Public Function Acceso(ByVal Usuario As String, ByVal Clave As String) As Boolean
        Try
            Acceso = False
            Dim sql As String = "select distinct idUsuario, Nombre, Activo, idModulo, idAcceso from vAccesos where upper(idUsuario) = '" & UCase(Usuario) & "' and Clave = '" & Clave & "' order by idModulo, idAcceso"
            Dim CMD As New SqlCommand(sql, Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            daAcceso.SelectCommand = CMD
            daAcceso.Fill(dtAcceso)
            If dtAcceso.Rows.Count = 0 Then
                MsgBox(Msj00016, MsgBoxStyle.Critical, Empresa & " Msj00016")
                Exit Function
            End If
            Nombre = dtAcceso.Rows(0)("Nombre")
            For Each row As DataRow In dtAcceso.Rows
                If row.Item("Activo").ToString = "False" Then
                    MsgBox(Msj00017, MsgBoxStyle.Critical, Empresa & " Msj00017")
                    Exit For
                End If
                Acceso = True
                Dim upcmd As New SqlCommand("Update catUsuarios set UltimoAcceso = getdate() where idUsuario = '" & Usuario & "'", Conexion01)
                upcmd.ExecuteNonQuery()
                Exit For
            Next
        Catch ex As Exception
            MsgBox(Msj00018, MsgBoxStyle.Critical, Empresa & " Msj00018")
        End Try
    End Function

    Public Function GetDatos() As Boolean
        GetDatos = False

        'GetDatos = False
        'If Not Directory.Exists("C:\Artaban") Then
        '    Directory.CreateDirectory("C:\Artaban")
        'End If
        'If File.Exists(PathFileConf) Then
        '    If CargaConfiguracion() = True Then
        '        GetDatos = True
        '    Else
        '        GetDatos = False
        '    End If
        'Else
        '    If CrearArchivoConfig() = False Then
        '        MsgBox(Msj00012, MsgBoxStyle.Critical, Empresa & " Msj00012")
        '    Else
        '        If CargaConfiguracion() = True Then
        '            GetDatos = True
        '        Else
        '            GetDatos = False
        '        End If
        '    End If

        'End If
    End Function

    Public Function RevConexion(Conexion As SqlConnection) As Boolean
        Dim Intentos = 0
        RevConexion = False
IniRevC:
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
            End If
        Catch ex As Exception
            If Intentos = 5 Then
                RevConexion = False
                Exit Function
            Else
                GoTo IniRevC
            End If
        End Try
        RevConexion = True
    End Function

    Public Sub DatosConexion()
        'DataBase = "Calidad"
        'dbUser = "sa"
        'dbPW = "@rt@b@n2o7o"
        'Server = "SYSTEMAS\SQLEXPRESS2012"
        If Conexion01.State = ConnectionState.Closed Then
            Conexion01.ConnectionString = "Data Source= " & DatosCon.Server & ";Initial Catalog = " & DatosCon.DataBase & " ;User id = " & DatosCon.dbUser & ";Password = " & DatosCon.dbPW
            'Conexion01.Close()
            ' Conexion01.ConnectionString = "SERVER= SERVER1\sqlexpress" & ";Initial Catalog = FACTORY" & " ;User id = " & DatosCon.dbUser & ";Password = " & DatosCon.dbPW

            Conexion01.Open()
        End If
    End Sub

    Public Function CargaConfiguracion() As Boolean
        Try
            CargaConfiguracion = True
            FileOpen(1, PathFileConf, OpenMode.Binary)
            FileGet(1, DatosCon)
            FileClose(1)
            CargaConfiguracion = True
        Catch ex As Exception
            CargaConfiguracion = False
        End Try
    End Function

    Public Function CrearArchivoConfig() As Boolean
        CrearArchivoConfig = False
        Try
            Dim ArchivoNew As System.IO.FileStream
            DatosCon.DataBase = ""
            DatosCon.dbPW = ""
            DatosCon.dbUser = ""
            DatosCon.Server = ""
            ArchivoNew = System.IO.File.Create(PathFileConf)
            ArchivoNew.Close()
            FileOpen(1, PathFileConf, OpenMode.Binary)
            FilePut(1, DatosCon)
            FileClose(1)
            CrearArchivoConfig = True
        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
            CrearArchivoConfig = False
        End Try
    End Function

    Public Function GuardaConfig() As Boolean
        GuardaConfig = False
        Try
            FileOpen(1, PathFileConf, OpenMode.Binary)
            FilePut(1, DatosCon)
            FileClose(1)
            GuardaConfig = True
        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
            GuardaConfig = False
        End Try
    End Function

    Public Sub Tab(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Sub ExportarXLSX(ByVal Grid As Object)
        Dim fileDialog As New OpenFileDialog()
        Dim filename As String
        fileDialog.AddExtension = True
        fileDialog.DefaultExt = "xlsx"
        fileDialog.CheckFileExists = False

        'If fileDialog.ShowDialog() = DialogResult.OK Then
        filename = fileDialog.ShowDialog
        ' Assign the file name to a string.
        filename = fileDialog.FileName
        If filename <> "" Then
            ' Open the file and use the contents. 
            Grid.ExportToXlsx(filename)
            System.Diagnostics.Process.Start(filename)
        End If
    End Sub

    Public Sub ExportarPDF(ByVal Grid As Object)
        Dim fileDialog As New OpenFileDialog()
        Dim filename As String
        fileDialog.AddExtension = True
        fileDialog.DefaultExt = "pdf"
        fileDialog.CheckFileExists = False

        'If fileDialog.ShowDialog() = DialogResult.OK Then
        filename = fileDialog.ShowDialog
        ' Assign the file name to a string.
        filename = fileDialog.FileName
        If filename <> "" Then
            ' Open the file and use the contents. 
            Grid.exporttoPDF(filename)
            'Grid.ExportarPDF(filename)
            System.Diagnostics.Process.Start(filename)
        End If
    End Sub

    Public Sub CargaCombo(Combo As DevExpress.XtraEditors.LookUpEdit, SQLCombo As String, ValueMember As String, DisplayMember As String)
        Dim Conteo = 0
        Dim dsCombo As New DataTable
        Dim daCombo As New SqlDataAdapter
        Dim cmdCombo As New SqlCommand(SQLCombo, Conexion01)
        Try
CargaCombo:
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            'cbLinea.Properties.Columns(1).Visible = False
            Conteo = Conteo + 1
            daCombo.SelectCommand = cmdCombo
            daCombo.Fill(dsCombo)
            Combo.Properties.DataSource = dsCombo
            Combo.Properties.ValueMember = ValueMember
            Combo.Properties.DisplayMember = DisplayMember
        Catch ex As Exception
            If Conteo = 10 Then
                MsgBox("Ocurrio un error al cargar el componente " & ex.Message)
                Exit Sub
            Else
                GoTo CargaCombo
            End If
        End Try
    End Sub

    Public Function ImagenToBytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        Dim arreglo As Byte() = Nothing
        Try
            If Not Imagen Is Nothing Then
                'variable de datos binarios en stream(flujo)
                Dim Bin As New MemoryStream
                'convertir a bytes
                Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
                'retorna binario
                arreglo = Bin.GetBuffer
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("No convirtio a bytes por: " + ex.ToString)
        End Try
        Return arreglo
    End Function

    Public Function consultaByte(ByVal identificacion As String) As Byte()   'Consulta el String que Bytes() almacenados en la base de datos y convierte ese String en un Arreglo de bytes() '
        Dim resultado As String = ""
        Dim x As Integer = 0
        Dim arreglo As Byte() = Nothing
        Dim arregloTexto()
        Try
            'Llena un arreglo de Texto con los datos de la consulta separados por coma"'
            'arregloTexto = resultado.Split(",")
            arregloTexto = identificacion.Split(",")
            'Redimenciona el tamaño del arreglo de bytes'
            ReDim arreglo(arregloTexto.Length - 1)
            'Recorre el arreglo para llenar el arreglo de Bytes con el arreglo de la consulta'
            For x = 0 To arregloTexto.Length - 1
                If arregloTexto(x).Equals("") = False Then
                    arreglo(x) = arregloTexto(x)
                End If
            Next
        Catch ex As Exception
        End Try
        Return arreglo
    End Function

    Public Function BytesToImagen(ByVal Imagen As Byte()) As Image  'Funcion que convierte de Byte() a Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function bytesToString(ByVal arreglo As Byte()) As String 'Retorna un String apartir de un arreglo de Bytes. Concatena cada elemento en la variable salida para ser almacenada en la Base de Datos'
        Dim salida As String = ""
        Dim x As Integer = 0
        'MsgBox("Tamaño del arreglo: " + arreglo.Length.ToString)
        Try
            For x = 0 To arreglo.Length - 1
                salida += arreglo(x).ToString + ","
            Next
        Catch ex As Exception
            MsgBox("No lo convertio a String por: " + ex.ToString)
        End Try

        Return salida
    End Function

    Public Function ImprimeCR(ByVal Impresora As String, SQL As String, CrReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, NCopias As Integer, Transaccion As SqlTransaction, UsaTran As Boolean) As Boolean
        ImprimeCR = False
        Dim dtRep As New DataTable
        Dim daRep As New SqlDataAdapter
        Dim CMD As New SqlCommand(SQL, Conexion01)
        Dim Conteo = 0
        RevConexion(Conexion01)
Reimp:
        Try
            If Conteo > 5 Then Exit Function
            Conteo = 1
            If UsaTran = True Then CMD.Transaction = Transaccion
            daRep.SelectCommand = CMD
            daRep.Fill(dtRep)
            CrReport.SetDataSource(dtRep)
            If Impresora <> "" Then CrReport.PrintOptions.PrinterName = Impresora
            For x = 1 To NCopias
                CrReport.PrintToPrinter(1, True, 0, 0)
            Next
            ImprimeCR = True
            CrReport.Dispose()
        Catch ex As Exception
            ImprimeCR = False
        End Try
    End Function

    Public Sub PreviewCR(ByVal SQL As String, CrReport As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Try
            If Conexion01.State = False Then Conexion01.Open()
            Dim dtRep As New DataTable
            Dim daRep As New SqlDataAdapter
            Dim CMD As New SqlCommand(SQL, Conexion01)
            daRep.SelectCommand = CMD
            daRep.Fill(dtRep)
            CrReport.SetDataSource(dtRep)
            ReportView.Visor.ReportSource = CrReport
            'ReportView.Show()
            CrReport.PrintToPrinter(1, True, 0, 0)
        Catch ex As Exception
            MsgBox(Msj00062 + " " + ex.Message, MsgBoxStyle.Critical, Empresa & " Msj00062")
        End Try
    End Sub

    Public Function ceros(Nro As String, Cantidad As Integer) As String
        Dim numero As String, cuantos As String, i As Integer
        numero = Trim(Nro) 'Trim quita los espacion en blanco
        cuantos = "0"
        For i = 1 To Cantidad
            cuantos = cuantos & "0"
        Next i
        If Cantidad < Len(numero) Then Cantidad = Len(numero)
        ceros = Mid(cuantos, 1, Cantidad - Len(numero)) & numero
    End Function

End Module
