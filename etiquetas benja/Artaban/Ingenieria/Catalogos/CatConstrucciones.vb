Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class CatConstruccionesForm
    Dim SQL As String = ""

    Dim Estatus As String = ""
    Dim ID As String = "0"
    Private Sub CatConstrucciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CargaCatalogo()
    End Sub

    Private Sub CargaCatalogo()
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter
        SQL = "Select idConstruccion, ConstruccionDesc, ConstruccionObs, ConstruccionActivo from vCatConstrucciones order by idConstruccion"
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
        'GridView1.Columns(0).Visible = False
        gCatalogo.Enabled = True
        bNuevo.Enabled = True
        bIgnorar.Enabled = False
        bEliminar.Enabled = False
        bGuardar.Enabled = False
        Estatus = "L" 'Lectura
        CargaDetalle()
    End Sub

    Private Sub CatConstrucciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub CatConstrucciones_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bNuevo.Click
        Estatus = "N"
        bIgnorar.Enabled = True
        bGuardar.Enabled = True
        gCatalogo.Enabled = False
        eConstruccion.Text = ""
        eDesc.Text = ""
        eObs.Text = ""
        chkActivo.Enabled = True
        eDesc.Focus()
    End Sub

    Private Sub gCatalogo_Click(sender As System.Object, e As System.EventArgs) Handles gCatalogo.Click
        CargaDetalle()
    End Sub

    Private Sub CargaDetalle()
        If GridView1.SelectedRowsCount > 0 Then
            If IsDBNull(GridView1.GetFocusedRowCellValue("idConstruccion")) Then
                eConstruccion.Text = ""
            Else
                eConstruccion.Text = GridView1.GetFocusedRowCellValue("idConstruccion")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("ConstruccionDesc")) Then
                eDesc.Text = ""
            Else
                eDesc.Text = GridView1.GetFocusedRowCellValue("ConstruccionDesc")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("ConstruccionObs")) Then
                eObs.Text = ""
            Else
                eObs.Text = GridView1.GetFocusedRowCellValue("ConstruccionObs")
            End If
            chkActivo.Checked = GridView1.GetFocusedRowCellValue("ConstruccionActivo")
            ID = GridView1.GetFocusedRowCellValue("idConstruccion").ToString
        Else
            eConstruccion.Text = ""
            eDesc.Text = ""
            eObs.Text = ""
            chkActivo.Checked = False
        End If
    End Sub

    Private Sub eConstruccion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eConstruccion.KeyPress, eObs.KeyPress, eDesc.KeyPress
        CambiaStatus()
    End Sub

    Private Sub CambiaStatus()
        'If Estatus = "L" Then Exit Sub ' Lectura
        Select Case Estatus
            Case "L" 'Sin estatus
                Estatus = "E" 'Edicion
                bGuardar.Enabled = True
                bIgnorar.Enabled = True
                bNuevo.Enabled = False
                bEliminar.Enabled = False
                gCatalogo.Enabled = False
        End Select
    End Sub

    Private Sub bIgnorar_Click(sender As System.Object, e As System.EventArgs) Handles bIgnorar.Click
        CargaDetalle()
        bGuardar.Enabled = False
        bIgnorar.Enabled = False
        bNuevo.Enabled = True
        gCatalogo.Enabled = False
        gCatalogo.Enabled = True
        Estatus = "L"
    End Sub

    Private Sub CatConstruccions_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub Guardar()
        Try
            Dim cmd As New SqlCommand("spUPCatConstrucciones", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@IDConstruccion", Integer.Parse(ID))
            Select Case Estatus
                Case "N"
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 1
                Case "E"
                    cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = 2
            End Select
            cmd.Parameters.Add("@ConstruccionDesc", SqlDbType.VarChar, 250).Value = eDesc.Text
            cmd.Parameters.Add("@ConstruccionObs", SqlDbType.VarChar, 250).Value = eObs.Text
            cmd.Parameters.Add("@ConstruccionActivo", SqlDbType.Bit).Value = chkActivo.Checked
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

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        Guardar()
    End Sub

    Private Sub chkActivo_Click(sender As System.Object, e As System.EventArgs) Handles chkActivo.Click
        CambiaStatus()
    End Sub
End Class