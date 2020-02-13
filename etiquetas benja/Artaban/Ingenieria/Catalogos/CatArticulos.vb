Imports System.Data.SqlClient
Class CatArticulos
    Dim SQL As String
    Dim Estatus As String
    Dim ID As Int16
    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub CatArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaCombos()
        CargaCatalogo()
    End Sub

    Private Sub CargaCombos()
        'Carga el combo de Tipos
        SQL = "Select idTipo, TipoDesc from vCatTipos order by TipoDesc"
        Dim dsTipo As New DataTable
        Dim daTipo As New SqlDataAdapter
        Dim cmdTipo As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daTipo.SelectCommand = cmdTipo
        daTipo.Fill(dsTipo)
        cbTipo.Properties.DataSource = dsTipo
        cbTipo.Properties.DisplayMember = "TipoDesc"
        cbTipo.Properties.ValueMember = "idTipo"
        cbTipo.Properties.Columns(0).Visible = False

        'Carga el Combo de Marca
        SQL = "Select idMarca, MarcaDesc from vCatMarcas order by MarcaDesc"
        Dim dsMarca As New DataTable
        Dim daMarca As New SqlDataAdapter
        Dim cmdMarca As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daMarca.SelectCommand = cmdMarca
        daMarca.Fill(dsMarca)
        cbMarca.Properties.DataSource = dsMarca
        cbMarca.Properties.DisplayMember = "MarcaDesc"
        cbMarca.Properties.ValueMember = "idMarca"
        'cbMarca.Properties.Columns(1).Visible = False

        'Carga el Combo de Categorias
        SQL = "Select idCategoria, CategoriaDesc from vCatCategorias order by CategoriaDesc"
        Dim dsCategoria As New DataTable
        Dim daCategoria As New SqlDataAdapter
        Dim cmdCategoria As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCategoria.SelectCommand = cmdCategoria
        daCategoria.Fill(dsCategoria)
        cbCategoria.Properties.DataSource = dsCategoria
        cbCategoria.Properties.DisplayMember = "CategoriaDesc"
        cbCategoria.Properties.ValueMember = "idCategoria"
        'cbCategoria.Properties.Columns(1).Visible = False

        'Carga el combo de lineas
        SQL = "Select idLinea, LineaDesc from vCatLineas order by lineaDesc"
        Dim dsLinea As New DataTable
        Dim daLinea As New SqlDataAdapter
        Dim cmdLinea As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daLinea.SelectCommand = cmdLinea
        daLinea.Fill(dsLinea)
        cbLinea.Properties.DataSource = dsLinea
        cbLinea.Properties.ValueMember = "idLinea"
        cbLinea.Properties.DisplayMember = "LineaDesc"
        'cbLinea.Properties.Columns(1).Visible = False

        'Carga el Combo de Contrucciones
        SQL = "Select idConstruccion, ConstruccionDesc, ConstruccionObs from vCatConstrucciones order by ConstruccionDesc"
        Dim dsCons As New DataTable
        Dim daCons As New SqlDataAdapter
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCons.SelectCommand = CMD
        daCons.Fill(dsCons)
        cbConstruccion.Properties.DataSource = dsCons
        cbConstruccion.Properties.DisplayMember = "ConstruccionDesc"
        cbConstruccion.Properties.ValueMember = "idConstruccion"
        'cbConstruccion.Properties.Columns(1).Visible = False

        'Carga el combo de Confort
        SQL = "Select idConfort, ConfortDesc from vCatConfort order by confortDesc"
        Dim dsConfort As New DataTable
        Dim daConfort As New SqlDataAdapter
        Dim cmdConfort As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daConfort.SelectCommand = cmdConfort
        daConfort.Fill(dsConfort)
        cbConfort.Properties.DataSource = dsConfort
        cbConfort.Properties.DisplayMember = "ConfortDesc"
        cbConfort.Properties.ValueMember = "idConfort"
        'cbConfort.Properties.Columns(1).Visible = False

        'Carga el Combo de Medidas
        SQL = "Select idMedida, MedidaDesc, CodMedida as Medida from vCatMedidas order by CodMedida"
        Dim dsMedida As New DataTable
        Dim daMedida As New SqlDataAdapter
        Dim cmdMedida As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daMedida.SelectCommand = cmdMedida
        daMedida.Fill(dsMedida)
        cbMedida.Properties.DataSource = dsMedida
        cbMedida.Properties.ValueMember = "idMedida"
        cbMedida.Properties.DisplayMember = "MedidaDesc"
        ' cbMedida.Properties.Columns(1).Visible = False


    End Sub

    Private Sub CargaCatalogo()
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter
        SQL = "SELECT SKU, Descripcion, idTipo, TipoDesc, idMarca, MarcaDesc, idModelo, ModeloDesc, idCategoria, CategoriaDesc, " & _
            " idLinea, LineaDesc, idConstruccion, ConstruccionDesc, idConfort, ConfortDesc, idMedida, MedidaDesc, Estatus FROM vArticulosPT "
        Dim CMD As New SqlCommand(Sql, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
        gCatalogo.Enabled = True
        bNuevo.Enabled = True
        bIgnorar.Enabled = False
        bEliminar.Enabled = False
        bGuardar.Enabled = False
        CargaLinea()
    End Sub

    Private Sub CatArticulos_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If cbMedida.Focused = True Then
            If e.KeyChar = Chr(13) Then bGuardar.Focus()
        Else
            Tab(e)
        End If

    End Sub

    Private Sub CargaLinea()
        If GridView1.SelectedRowsCount > 0 Then
            If IsDBNull(GridView1.GetFocusedRowCellValue("SKU")) Then
                eSKU.Text = "000000000000"
            Else
                eSKU.Text = Format(GridView1.GetFocusedRowCellValue("SKU"), "000000000000")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Descripcion")) Then
                eDesc.Text = ""
            Else
                eDesc.Text = GridView1.GetFocusedRowCellValue("Descripcion")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("idTipo")) Then
                cbTipo.EditValue = -1
            Else
                cbTipo.EditValue = GridView1.GetFocusedRowCellValue("idTipo")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("idMarca")) Then
                cbMarca.EditValue = -1
            Else
                cbMarca.EditValue = GridView1.GetFocusedRowCellValue("idMarca")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("idModelo")) Then
                cbModelo.EditValue = -1
            Else
                cbModelo.EditValue = GridView1.GetFocusedRowCellValue("idModelo")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("idCategoria")) Then
                cbCategoria.EditValue = -1
            Else
                cbCategoria.EditValue = GridView1.GetFocusedRowCellValue("idCategoria")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("idLinea")) Then
                cbLinea.EditValue = -1
            Else
                cbLinea.EditValue = GridView1.GetFocusedRowCellValue("idLinea")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("idConstruccion")) Then
                cbConstruccion.EditValue = -1
            Else
                cbConstruccion.EditValue = GridView1.GetFocusedRowCellValue("idConstruccion")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("idConfort")) Then
                cbConfort.EditValue = -1
            Else
                cbConfort.EditValue = GridView1.GetFocusedRowCellValue("idConfort")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("idMedida")) Then
                cbMedida.EditValue = -1
            Else
                cbMedida.EditValue = GridView1.GetFocusedRowCellValue("idMedida")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Estatus")) Then
                cbEstatus.Text = ""
            Else
                cbEstatus.Text = GridView1.GetFocusedRowCellValue("Estatus")
            End If
            'ID = eSKU.Text
            cbEstatus.Enabled = True
        Else
            cbEstatus.Text = ""
            cbCategoria.EditValue = -1
            cbConfort.EditValue = -1
            cbConstruccion.EditValue = -1
            cbLinea.EditValue = -1
            cbMarca.EditValue = -1
            cbMedida.EditValue = -1
            cbModelo.EditValue = -1
        End If
        eDesc.Focus()
        Estatus = "L" 'Lectura
        Habilitado(False)
    End Sub

    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bNuevo.Click
        eDesc.Text = ""
        eSKU.Text = "0000000000000"
        bIgnorar.Enabled = True
        bGuardar.Enabled = True
        gCatalogo.Enabled = False
        cbEstatus.Text = "ACTIVO"
        cbTipo.EditValue = -1
        cbCategoria.EditValue = -1
        cbConfort.EditValue = -1
        cbConstruccion.EditValue = -1
        cbLinea.EditValue = -1
        cbMarca.EditValue = -1
        cbMedida.EditValue = -1
        cbModelo.EditValue = -1
        Habilitado(True)
        Estatus = "N"
        eDesc.Focus()
    End Sub

    Private Sub Habilitado(ByVal Estado As Boolean)
        cbTipo.Enabled = Estado
        'cbEstatus.Enabled = Estado
        cbCategoria.Enabled = Estado
        cbConfort.Enabled = Estado
        cbConstruccion.Enabled = Estado
        cbLinea.Enabled = Estado
        cbMarca.Enabled = Estado
        cbMedida.Enabled = Estado
        cbModelo.Enabled = Estado
        bGuardar.Enabled = Estado
        bIgnorar.Enabled = Estado
        bNuevo.Enabled = Not (Estado)
        gCatalogo.Enabled = Not (Estado)

    End Sub

    Private Sub bIgnorar_Click(sender As System.Object, e As System.EventArgs) Handles bIgnorar.Click
        CargaLinea()
        bGuardar.Enabled = False
        bIgnorar.Enabled = False
        bNuevo.Enabled = True
        gCatalogo.Enabled = True
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        If Valido = True Then Guardar()
    End Sub

    Private Function Valido() As Boolean
        Valido = False
        If cbEstatus.Text <> "" And cbLinea.Text <> "" And cbMedida.Text <> "" And cbModelo.Text <> "" And eDesc.Text <> "" Then
            Valido = True
        Else
            MsgBox(Msj00022, MsgBoxStyle.Critical, Empresa & " MSJ00022")
        End If
    End Function

    Private Sub Guardar()
        Try
            Dim cmd As New SqlCommand("spUPCatArticulosPT", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            Select Case Estatus
                Case "N"
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
                Case "E"
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 2
            End Select
            cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = eSKU.Text
            cmd.Parameters.Add("@Desc", SqlDbType.VarChar, 250).Value = eDesc.Text
            cmd.Parameters.Add("@Clase", SqlDbType.VarChar, 250).Value = "PT"
            cmd.Parameters.Add("@Tipo", SqlDbType.Int).Value = cbTipo.EditValue
            cmd.Parameters.Add("@Marca", SqlDbType.Int).Value = cbMarca.EditValue
            cmd.Parameters.Add("@Modelo", SqlDbType.Int).Value = cbModelo.EditValue
            cmd.Parameters.Add("@Categoria", SqlDbType.Int).Value = cbCategoria.EditValue
            cmd.Parameters.Add("@Linea", SqlDbType.Int).Value = cbLinea.EditValue
            cmd.Parameters.Add("@Construccion", SqlDbType.Int).Value = cbConstruccion.EditValue
            cmd.Parameters.Add("@Confort", SqlDbType.Int).Value = cbConfort.EditValue
            cmd.Parameters.Add("@Medida", SqlDbType.Int).Value = cbMedida.EditValue
            Select Case cbEstatus.Text
                Case "ACTIVO"
                    cmd.Parameters.Add("@Estatus", SqlDbType.Int).Value = 1
                Case "INACTIVO"
                    cmd.Parameters.Add("@Estatus", SqlDbType.Int).Value = 2
                Case "OBSOLETO"
                    cmd.Parameters.Add("@Estatus", SqlDbType.Int).Value = 3
            End Select
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
            MsgBox(Msj00020, MsgBoxStyle.Critical, Empresa & " MSJ00020")
            Exit Sub
        End Try
        CargaCatalogo()
        MsgBox(Msj00021, MsgBoxStyle.Information, Empresa & " MSJ00021") 'Se guardo de manera correcta
    End Sub

    Private Sub CatArticulos_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Desicion As MsgBoxResult = MsgBoxResult.No
        Select Case Estatus
            Case "E"
                Desicion = MsgBox(Msj00019, MsgBoxStyle.YesNoCancel, Empresa & " MSJ00019")
            Case "N"
                Desicion = MsgBox(Msj00019, MsgBoxStyle.YesNoCancel, Empresa & " MSJ00019")
        End Select
        Select Case Desicion
            Case MsgBoxResult.Yes
                Guardar()
            Case MsgBoxResult.Cancel
                e.Cancel = True
        End Select
    End Sub

    Private Sub CatArticulos_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub cbTipo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbTipo.EditValueChanged, cbMarca.EditValueChanged, cbModelo.EditValueChanged, cbCategoria.EditValueChanged, cbLinea.EditValueChanged, cbConstruccion.EditValueChanged, cbConfort.EditValueChanged, cbMedida.EditValueChanged, cbEstatus.SelectedIndexChanged
        If cbLinea.Focused = True Then
            'CArga Combo de Modelos
            SQL = "Select idModelo, ModeloDesc from CatModelos with(nolock) where idLinea = " & cbLinea.EditValue.ToString & " order by ModeloDesc"
            Dim dsModelo As New DataTable
            Dim daModelo As New SqlDataAdapter
            Dim cmdModelo As New SqlCommand(SQL, Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            daModelo.SelectCommand = cmdModelo
            daModelo.Fill(dsModelo)
            cbModelo.Properties.DataSource = dsModelo
            cbModelo.Properties.ValueMember = "idModelo"
            cbModelo.Properties.DisplayMember = "ModeloDesc"
            'cbModelo.Properties.Columns(1).Visible = False
        End If
        If cbTipo.Text = "" Then
            eSKU.Text = "00"
            eDesc.Text = ""
        Else
            eSKU.Text = Format(cbTipo.EditValue, "00")
            Select Case Format(cbTipo.EditValue, "00")
                Case "15"
                    eDesc.Text = "COL DOMMIE"
                Case "16"
                    eDesc.Text = "BOX DOMMIE"
                Case Else
                    eDesc.Text = cbTipo.Text.Substring(0, 3)
            End Select

        End If
        If cbLinea.Text = "" Then
            eSKU.Text = eSKU.Text & "00"
        Else
            eSKU.Text = eSKU.Text & Format(cbLinea.EditValue, "00").ToString
            eDesc.Text = eDesc.Text & " " & cbLinea.Text
        End If
        If cbModelo.Text = "" Then
            eSKU.Text = eSKU.Text & "0000"
        Else
            eSKU.Text = eSKU.Text & Format(cbModelo.EditValue, "0000").ToString
            eDesc.Text = eDesc.Text & " " & cbModelo.Text
        End If
        'If cbCategoria.Text = "" Then
        '    eSKU.Text = eSKU.Text & "00"
        'Else
        '    eSKU.Text = eSKU.Text & Format(cbCategoria.EditValue, "00")
        'End If
        'If cbLinea.Text = "" Then
        '    eSKU.Text = eSKU.Text & "00"
        'Else
        '    eSKU.Text = eSKU.Text & Format(cbLinea.EditValue, "00")
        'End If
        'If cbConstruccion.Text = "" Then
        '    eSKU.Text = eSKU.Text & "0"
        'Else
        '    eSKU.Text = eSKU.Text & Format(cbConstruccion.EditValue, "0")
        'End If
        'If cbConfort.Text = "" Then
        '    eSKU.Text = eSKU.Text & "0"
        'Else
        '    eSKU.Text = eSKU.Text & Format(cbConfort.EditValue, "0")
        'End If
        If cbMedida.Text = "" Then
            eSKU.Text = eSKU.Text & "00"
        Else
            Dim SqlMed As String = "Select CodMedida from catMedidas with(NoLock) where idMedida = " & cbMedida.EditValue
            Dim cmdMed As New SqlCommand(SqlMed, Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim dsMed As New DataTable
            Dim daMed As New SqlDataAdapter
            daMed.SelectCommand = cmdMed
            daMed.Fill(dsMed)
            eSKU.Text = eSKU.Text & dsMed.Rows(0)(0).ToString
            eDesc.Text = eDesc.Text & " " & cbMedida.Text
            'eSKU.Text = eSKU.Text & Format(cbMedida.EditValue, "00")
        End If
        If bGuardar.Enabled = False Then
            bGuardar.Enabled = True
            bIgnorar.Enabled = True
            bNuevo.Enabled = False
            Estatus = "E"
        End If
    End Sub

    Private Sub gCatalogo_Click(sender As System.Object, e As System.EventArgs) Handles gCatalogo.Click
        CargaLinea()
    End Sub

End Class