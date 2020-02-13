Imports System.Data.SqlClient
Imports Microsoft
Public Class RepExistenciasForm
    Dim SQL
    Private Sub RepExistenciasForm_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub RepExistenciasForm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub
    Private Sub CargaCombos()
        'Carga el combo de artículos
        SQL = "Select SKU, Descripcion from CatArticulosPT with(NoLock)"
        Dim dsArt As New DataTable
        Dim daArt As New SqlDataAdapter
        Dim cmdArt As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daArt.SelectCommand = cmdArt
        daArt.Fill(dsArt)
        cbArticulo.Properties.DataSource = dsArt
        cbArticulo.Properties.DisplayMember = "SKU"
        cbArticulo.Properties.ValueMember = "Descripcion"

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

        'CArga Combo de Modelos
        SQL = "Select idModelo, ModeloDesc from vCatModelos order by ModeloDesc"
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

    Private Sub RepExistenciasForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaCombos()
    End Sub

    Private Sub cbArticulo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbArticulo.EditValueChanged
        eDesc.Text = cbArticulo.EditValue.ToString
    End Sub

    Private Sub bLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles bLimpiar.Click
        cbArticulo.EditValue = ""
        cbTipo.EditValue = -1
        cbMarca.EditValue = -1
        cbModelo.EditValue = -1
        cbCategoria.EditValue = -1
        cbLinea.EditValue = -1
        cbEstatus.SelectedIndex = -1
        cbConstruccion.EditValue = -1
        cbConfort.EditValue = -1
        cbMedida.EditValue = -1
        eAlmacen.Text = ""
        eLocacion.Text = ""
    End Sub 

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        SQL = "select Inv.SKU, Descripcion, Almacen, Locacion, Cantidad, " & _
            " STUFF((SELECT ',' + cast(InvInd.Consecutivo as varchar(50)) FROM ExistenciaIndPT InvInd with(NoLock) inner join EtiquetasProd Et on InvInd.Consecutivo = Et.Consecutivo " & _
            " where Et.SKU = Inv.SKU and InvInd.Almacen = Inv.Almacen and InvInd.Locacion = Inv.Locacion ORDER BY invInd.consecutivo FOR XML PATH('') ), 1, 1, '') + ' ' as NoSeries   " & _
            " from existenciaPT Inv with(nolock) inner join catArticulosPT Art with(NoLock) on Inv.SKU = Art.SKU where 1 = 1 "
        SQL = SQL & getFiltro()
        Dim dsBuscar As New DataTable
        Dim DaBuscar As New SqlDataAdapter
        Dim cmdBuscar As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        DaBuscar.SelectCommand = cmdBuscar
        DaBuscar.Fill(dsBuscar)
        gCatalogo.DataSource = dsBuscar
        cbArticulo.Focus()
    End Sub

    Private Function getFiltro() As String
        Dim filtro As String = ""
        If cbArticulo.Text <> "" Then filtro = filtro & " and Art.SKU = '" & cbArticulo.Text & "' "
        If cbTipo.Text <> "" Then Filtro = Filtro & " and art.Tipo = " & cbTipo.EditValue.ToString
        If cbMarca.Text <> "" Then Filtro = Filtro & " and Art.Marca = " & cbMarca.EditValue.ToString
        If cbModelo.Text <> "" Then Filtro = Filtro & " and Art.Modelo = " & cbModelo.EditValue.ToString
        If cbCategoria.Text <> "" Then Filtro = Filtro & " and Art.Categoria = " & cbCategoria.EditValue.ToString
        If cbLinea.Text <> "" Then Filtro = Filtro & " and Art.Linea = " & cbLinea.EditValue.ToString
        If cbEstatus.Text <> "" Then
            Select Case cbEstatus.Text
                Case "ACTIVO"
                    Filtro = Filtro & " and estatus = 1 "
                Case "INACTIVO"
                    Filtro = Filtro & " and estatus = 2 "
                Case "OBSOLETO"
                    Filtro = Filtro & " and estatus = 3 "
            End Select
        End If
        If eAlmacen.Text <> "" Then Filtro = Filtro & " And Almacen = '" & eAlmacen.Text & "'"
        If eLocacion.Text <> "" Then Filtro = Filtro & " and Locacion = '" & eLocacion.Text & "'"
        If cbConstruccion.Text <> "" Then Filtro = Filtro & " and Construccion = " & cbConstruccion.EditValue.ToString
        If cbConfort.Text <> "" Then Filtro = Filtro & " and Confort = " & cbConfort.EditValue.ToString
        If cbMedida.Text <> "" Then Filtro = Filtro & " And Medida = " & cbMedida.EditValue.ToString
        If eAlmacen.Text <> "" Then Filtro = Filtro & " and Almacen = '" & eAlmacen.Text & "'"
        If eLocacion.Text <> "" Then Filtro = Filtro & " And locacion = '" & eLocacion.Text & "'"
        getFiltro = Filtro
    End Function

    Private Sub bImprimir_Click(sender As System.Object, e As System.EventArgs) Handles bImprimir.Click
        Dim rpt As New RptExistenciasPT
        Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo
        oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
        oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
        oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
        oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
        For x = 0 To rpt.Database.Tables.Count - 1
            rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
            rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
        Next
        SQL = getFiltro()

        rpt.SetParameterValue("@Filtro", SQL)
        If MsgBox(Msj00041, MsgBoxStyle.YesNo, Empresa & " MSJ00041") = MsgBoxResult.Yes Then
            rpt.SetParameterValue("@NS", True)
        Else
            rpt.SetParameterValue("@NS", False)
        End If
        Dim rptEmbarque As New ReportView
        rptEmbarque.Icon = Me.Icon
        rptEmbarque.Visor.ReportSource = rpt
        rptEmbarque.Show()
    End Sub

    Private Sub bIgnorar_Click(sender As System.Object, e As System.EventArgs) Handles bExportar.Click
        ExportarXLSX(gCatalogo)
    End Sub
End Class