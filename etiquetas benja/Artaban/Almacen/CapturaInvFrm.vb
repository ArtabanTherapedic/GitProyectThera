Imports System.Data.SqlClient
Class CapturaInv
    Dim SQL As String
    Dim Estatus As String
    Dim ID As Integer
    Dim oConexInfo As New CrystalDecisions.Shared.TableLogOnInfo

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub CatArticulos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
Rev:
        Try
            nRev = CInt(InputBox("Indica el Número de Revisión: ", "Inventarios Artaban", ""))
        Catch
            MsgBox(Msj00044, MsgBoxStyle.Critical, Empresa & " MSJ00044")
            GoTo Rev
        End Try
        If nRev < 1 Or nRev > 3 Then
            MsgBox(Msj00044, MsgBoxStyle.Critical, Empresa & " MSJ00044")
            GoTo Rev
        End If
        CargaCombos()
        CargaCatalogo()
        Habilitado(True)
        eFolio.Focus()
    End Sub

    Private Sub CargaCombos()
        'Carga el combo de Tipos
        SQL = "Select Producto, Descripcion from factory..productos with(NoLock) order by Descripcion"
        'SQL = "Select Codigo as Producto, Descripcion from productos with(NoLock) order by Descripcion"
        Dim dsCod As New DataTable
        Dim daCod As New SqlDataAdapter
        Dim cmdCod As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dsCod)
        cbDescripcion.Properties.DataSource = dsCod
        cbDescripcion.Properties.DisplayMember = "Descripcion"
        cbDescripcion.Properties.ValueMember = "Producto"
        cbDescripcion.Properties.Columns(0).Visible = False
        cbDescripcion.EditValue = ""
    End Sub

    Private Sub CargaCatalogo()
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter

        SQL = "Select ID, Folio, Linea, Codigo, Descripcion, Ubicacion, isnull(Cantidad" & nRev & ", 0) as Cantidad from RevInv with(NoLock) where 1 = 1 "

        If eFolio.Text = "" Then
            SQL = SQL & " and Folio = 0"
        Else

            SQL = SQL & " and Folio = " & eFolio.Text
        End If
        If nRev = 3 Then SQL = SQL & " and isnull(Cantidad1,0) <> isnull(Cantidad2,0)"
        SQL = SQL & " Order by Linea "
        Dim CMD As New SqlCommand(Sql, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
        gCatalogo.Enabled = True
        bNuevo.Enabled = True
        bIgnorar.Enabled = False
        bEliminar.Enabled = False
        'bGuardar.Enabled = False
        If nRev = 1 Then Exit Sub
        'CargaLinea()
    End Sub

    Private Sub CatArticulos_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        'Select Case True
        '    Case eCantidad.Focused
        '        If e.KeyChar = Chr(13) Then bGuardar.Focus()
        '    Case eFolio.Focused
        '        If e.KeyChar = Chr(13) Then
        '            CargaCatalogo()
        '            cbDescripcion.Focus()
        '        End If
        '    Case Else
        '        Tab(e)
        'End Select
        ''Exit Sub
        If eCantidad.Focused = True Then
            If e.KeyChar = Chr(13) Then bGuardar.Focus()
        Else
            If eFolio.Focused = True Then
                If e.KeyChar = Chr(13) Then
                    CargaCatalogo()
                    cbDescripcion.Focus()
                End If
            End If
            Tab(e)
        End If


    End Sub

    Private Sub CargaLinea()
        If nRev = 1 Then
            If GridView1.SelectedRowsCount > 0 Then
                ID = GridView1.GetFocusedRowCellValue("ID")
                bEliminar.Enabled = True
            End If
            Exit Sub
        End If

        If GridView1.SelectedRowsCount > 0 Then
            If IsDBNull(GridView1.GetFocusedRowCellValue("ID")) Then
                ID = "0"
            Else
                ID = GridView1.GetFocusedRowCellValue("ID")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Folio")) Then
                eFolio.Text = "0"
            Else
                eFolio.Text = GridView1.GetFocusedRowCellValue("Folio")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Codigo")) Then
                cbDescripcion.EditValue = ""
            Else
                cbDescripcion.EditValue = GridView1.GetFocusedRowCellValue("Codigo")
                'cbDescripcion.Text = GridView1.GetFocusedRowCellValue("Codigo")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Ubicacion")) Then
                eUbicacion.Text = ""
            Else
                eUbicacion.Text = GridView1.GetFocusedRowCellValue("Ubicacion")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Catidad")) Then
                eCantidad.Text = ""
            Else
                eCantidad.Text = GridView1.GetFocusedRowCellValue("Cantidad")
            End If
            If IsDBNull(GridView1.GetFocusedRowCellValue("Linea")) Then
                eLinea.Text = ""
            Else
                eLinea.Text = GridView1.GetFocusedRowCellValue("Linea")
            End If
        Else
            eFolio.Text = ""
            cbDescripcion.EditValue = ""
            ' cbDescripcion.Text = ""
            eUbicacion.Text = ""
            eCantidad.Text = ""
            eLinea.Text = ""
        End If
        eFolio.Focus()
        Estatus = "L" 'Lectura
        'Habilitado(False)
    End Sub

    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bNuevo.Click
        eFolio.Text = ""
        'eFolio.Properties.ReadOnly = True
        'bIgnorar.Enabled = True
        'bGuardar.Enabled = True
        'gCatalogo.Enabled = False
        eFolio.Text = ""
        cbDescripcion.EditValue = ""
        eUbicacion.SelectedIndex = -1
        eCantidad.Text = ""
        eLinea.Text = ""
        Habilitado(True)
        Estatus = "N"
        ID = 0
        eFolio.Focus()
    End Sub

    Private Sub Habilitado(ByVal Estado As Boolean)

        Exit Sub
        eFolio.Enabled = Not (Estado)
        'cbEstatus.Enabled = Estado
        eCantidad.Enabled = Estado
        eUbicacion.Enabled = Estado
        eLinea.Enabled = Estado
        cbDescripcion.Enabled = Estado
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
        If eCantidad.Text <> "" And cbDescripcion.Text <> "" And eUbicacion.Text <> "" Then
            Valido = True
        Else
            MsgBox(Msj00042, MsgBoxStyle.Critical, Empresa & " MSJ00042")
        End If
    End Function

    Private Sub Guardar()
        If nRev = 1 Then ID = 0
        Dim Transac As SqlTransaction
        Transac = Conexion01.BeginTransaction
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand("spRegInv", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Transaction = Transac
            cmd.Parameters.Add("@OPC", SqlDbType.Int).Value = nRev
            If eFolio.Text = "" Then eFolio.Text = "0"
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = eFolio.Text
            cmd.Parameters.Add("@Linea", SqlDbType.Int).Value = 0
            cmd.Parameters.Add("@Codigo", SqlDbType.VarChar, 100).Value = cbDescripcion.EditValue
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 4000).Value = cbDescripcion.Text
            cmd.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 100).Value = eUbicacion.Text
            cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = eCantidad.Text
            cmd.Parameters("@Folio").Direction = ParameterDirection.InputOutput
            cmd.ExecuteNonQuery()
            Transac.Commit()
            eFolio.Text = cmd.Parameters("@Folio").Value.ToString
        Catch ex As Exception
            Transac.Rollback()
            MsgBox(Msj00043 + " " + ex.Message, MsgBoxStyle.Critical, Empresa & "MSJ00043")
            Exit Sub
        End Try
        CargaCatalogo()
        cbDescripcion.EditValue = ""
        'cbDescripcion.Text = ""
        eCantidad.Text = ""
        cbDescripcion.Focus()
    End Sub

    Private Sub CatArticulos_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Dim Desicion As MsgBoxResult = MsgBoxResult.No
        'Select Case Estatus
        '    Case "E"
        '        Desicion = MsgBox(Msj00019, MsgBoxStyle.YesNoCancel, Empresa & " MSJ00019")
        '    Case "N"
        '        Desicion = MsgBox(Msj00019, MsgBoxStyle.YesNoCancel, Empresa & " MSJ00019")
        'End Select
        'Select Case Desicion
        '    Case MsgBoxResult.Yes
        '        Guardar()
        '    Case MsgBoxResult.Cancel
        '        e.Cancel = True
        'End Select
    End Sub

    Private Sub CatArticulos_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub gCatalogo_Click(sender As System.Object, e As System.EventArgs) Handles gCatalogo.Click
        CargaLinea()
        If eLinea.Text <> "" Then
Rev2:
            Try
                eCantidad.Text = CInt(InputBox("Indica la Cantidad a Registrar: ", "Inventarios Artaban", ""))
                If CInt(eCantidad.Text) < 0 Then GoTo Rev2
                Guardar()
            Catch
                MsgBox(Msj00045, vbCritical, Empresa & " MSJ00045")
            End Try
        End If
    End Sub

    Private Sub eFolio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eFolio.KeyPress
        If e.KeyChar = Chr(13) Then
            CargaCatalogo()
            cbDescripcion.Focus()
        End If
    End Sub

    Private Sub cbDescripcion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbDescripcion.KeyPress
        Tab(e)
    End Sub

    Private Sub eCantidad_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eCantidad.KeyPress
        If e.KeyChar = Chr(13) Then
            bGuardar_Click(sender, e)
        End If
    End Sub

    Private Sub bImprimir_Click(sender As System.Object, e As System.EventArgs) Handles bImprimir.Click
        Select Case nRev
            Case 1
                Dim rpt As New rptRevInv02
                oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
                oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
                oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
                oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
                For x = 0 To rpt.Database.Tables.Count - 1
                    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
                    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
                Next
                'Fuente http://scn.sap.com/thread/1886030
                rpt.SetParameterValue("@Folio", eFolio.Text)
                Dim rptEmbarque As New ReportView
                rptEmbarque.Icon = Me.Icon
                rptEmbarque.Visor.ReportSource = rpt
                rptEmbarque.Show()
            Case 2
                Dim rpt As New rptRevInv02 
                oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
                oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
                oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
                oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
                For x = 0 To rpt.Database.Tables.Count - 1
                    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
                    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
                Next
                'Fuente http://scn.sap.com/thread/1886030
                rpt.SetParameterValue("@Folio", eFolio.Text)
                Dim rptEmbarque As New ReportView
                rptEmbarque.Icon = Me.Icon
                rptEmbarque.Visor.ReportSource = rpt
                rptEmbarque.Show()
            Case 3
                Dim rpt As New rptRevInv03 
                oConexInfo.ConnectionInfo.ServerName = DatosCon.Server
                oConexInfo.ConnectionInfo.DatabaseName = DatosCon.DataBase
                oConexInfo.ConnectionInfo.UserID = DatosCon.dbUser
                oConexInfo.ConnectionInfo.Password = DatosCon.dbPW
                For x = 0 To rpt.Database.Tables.Count - 1
                    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
                    rpt.Database.Tables(x).ApplyLogOnInfo(oConexInfo)
                Next
                'Fuente http://scn.sap.com/thread/1886030
                rpt.SetParameterValue("@Folio", eFolio.Text)
                Dim rptEmbarque As New ReportView
                rptEmbarque.Icon = Me.Icon
                rptEmbarque.Visor.ReportSource = rpt
                rptEmbarque.Show()
        End Select
    End Sub

    Private Sub eUbicacion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles eUbicacion.KeyPress
        If e.KeyChar = Chr(13) Then
            eCantidad.Focus()
        End If
    End Sub

    Private Sub bEliminar_Click(sender As System.Object, e As System.EventArgs) Handles bEliminar.Click
        Dim Transac As SqlTransaction
        Transac = Conexion01.BeginTransaction
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand("spRegInv", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Transaction = Transac
            cmd.Parameters.Add("@OPC", SqlDbType.Int).Value = 0
            If eFolio.Text = "" Then eFolio.Text = "0"
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID
            cmd.Parameters.Add("@Folio", SqlDbType.Int).Value = eFolio.Text
            cmd.Parameters.Add("@Linea", SqlDbType.Int).Value = 0
            cmd.Parameters.Add("@Codigo", SqlDbType.VarChar, 100).Value = "."
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 4000).Value = "."
            cmd.Parameters.Add("@Ubicacion", SqlDbType.VarChar, 100).Value = "."
            cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = "0"
            cmd.Parameters("@Folio").Direction = ParameterDirection.InputOutput
            cmd.ExecuteNonQuery()
            Transac.Commit()
            eFolio.Text = cmd.Parameters("@Folio").Value.ToString
        Catch ex As Exception
            Transac.Rollback()
            MsgBox(Msj00043 + " " + ex.Message, MsgBoxStyle.Critical, Empresa & "MSJ00043")
            Exit Sub
        End Try
        CargaCatalogo()
        cbDescripcion.EditValue = ""
        'cbDescripcion.Text = ""
        eCantidad.Text = ""
        CargaLinea()
        cbDescripcion.Focus()
    End Sub
End Class