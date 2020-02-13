Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository

Public Class PrenomProm
    Dim Inicio = True
    Dim SQL As String
    Dim idRegNomina As Integer
    Dim Renglon = 0
    Dim NoSemana = 0
    Private Sub PrenomProm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Usuario = "alvirde" Or Usuario = "sacosta" Or Usuario = "cFlores" Then sDiario.Visible = True
        CBe.Minimum = 2019
        CBe.Maximum = 2030
        CBp.Minimum = 1
        CBp.Maximum = 53
        CBe.Value = Now.Year
        ' Inicio = False
        SQL = "select NoSemana from PreNominaHDr with(nolock) where estatus = 1 "
        Dim dsCod As New DataTable
        Dim daCod As New SqlDataAdapter
        Dim cmdCod As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dsCod)
        If dsCod.Rows.Count = 0 Then
            MsgBox("Ocurrio un error al obtener los datos iniciales. Favor de informar al administrador del sistema.")
            Exit Sub
        End If
        NoSemana = dsCod.Rows(0)("NoSemana")
        CBp.Value = NoSemana
        Inicio = False
        CargaPeriodo()
        CargaCatalogo()
    End Sub

    Public Sub CargaRepositorio()
        'InitializeComponent()
        ' gcatalogo.DataSource = GetData(20)
        ' gCatalogo.ForceInitialize()
        Dim _riEditor As New RepositoryItemComboBox()
        _riEditor.Items.AddRange(New String() {1, 3, 5})
        gCatalogo.RepositoryItems.Add(_riEditor)
        GridView1.Columns("D1").ColumnEdit = _riEditor

        GridView1.Columns(0).ColumnEdit = _riEditor
        GridView1.Columns(1).ColumnEdit = _riEditor
        GridView1.Columns(2).ColumnEdit = _riEditor
        GridView1.Columns(3).ColumnEdit = _riEditor
        GridView1.Columns(4).ColumnEdit = _riEditor
        GridView1.Columns(7).ColumnEdit = _riEditor
        GridView1.Columns(6).ColumnEdit = _riEditor
    End Sub
    Private Sub CargaCatalogo()
        CambiarLectura(True)
        'cbE.Value = Now.Year
        Dim NoEmp As String
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter
        SQL = "declare @tEmp as table(NoEmp int, Empleado varchar(MAx), Cuenta varchar(MAx), Estatus varchar(Max)) " & _
            " insert into @tEmp  " & _
            " Select IDEmp, Empleado, Cuenta, Estatus from v_CatEmpLyraProm " & _
            " select Emp.NoEmp, Emp.Empleado Promotor, Cuenta as NoCuenta, isnull(Nomina.Estatus,0)Estatus, " & _
            " CASE isnull(D1,0) WHEN 1 THEN 'X' WHEN 2 THEN 'F' WHEN 3 THEN 'P' WHEN 4 THEN 'VAC' WHEN 5 THEN 'INC' WHEN 6 THEN 'BAJ' ELSE '' END  D1, " & _
            " CASE isnull(D2,0) WHEN 1 THEN 'X' WHEN 2 THEN 'F' WHEN 3 THEN 'P' WHEN 4 THEN 'VAC' WHEN 5 THEN 'INC' WHEN 6 THEN 'BAJ' ELSE '' END  D2, " & _
            " CASE isnull(D3,0) WHEN 1 THEN 'X' WHEN 2 THEN 'F' WHEN 3 THEN 'P' WHEN 4 THEN 'VAC' WHEN 5 THEN 'INC' WHEN 6 THEN 'BAJ' ELSE '' END  D3, " & _
            " CASE Isnull(D4,0) WHEN 1 THEN 'X' WHEN 2 THEN 'F' WHEN 3 THEN 'P' WHEN 4 THEN 'VAC' WHEN 5 THEN 'INC' WHEN 6 THEN 'BAJ' ELSE '' END  D4, " & _
            " CASE isnull(d5,0) WHEN 1 THEN 'X' WHEN 2 THEN 'F' WHEN 3 THEN 'P' WHEN 4 THEN 'VAC' WHEN 5 THEN 'INC' WHEN 6 THEN 'BAJ' ELSE '' END  D5, " & _
            " CASE isnull(d6,0) WHEN 1 THEN 'X' WHEN 2 THEN 'F' WHEN 3 THEN 'P' WHEN 4 THEN 'VAC' WHEN 5 THEN 'INC' WHEN 6 THEN 'BAJ' ELSE '' END  D6, " & _
            " CASE isnull(D7,0) WHEN 1 THEN 'X' WHEN 2 THEN 'F' WHEN 3 THEN 'P' WHEN 4 THEN 'VAC' WHEN 5 THEN 'INC' WHEN 6 THEN 'BAJ' ELSE '' END  D7, " & _
            " isnull(Nomina.Sueldo,0)Sueldo, isnull(Comisiones,0)Comisiones, isnull(Prom.Sueldo, 0) as SDiario, isnull(Nomina.Sueldo,0) + isnull(Comisiones,0) PerTot" & _
            " from catRHSupervisores as Sup  with(nolock) inner join catrhPromotores as Prom  with(nolock) " & _
            " on case when sup.SU = 1 then Prom.NoSupervisor else sup.NoEmp end = Prom.NoSupervisor " & _
            " left outer join @tEmp as Emp on Prom.Noemp = Emp.NoEmp " & _
            " left outer join PreNominaProm Nomina with(nolock) on Emp.NoEmp = Nomina.NoEmp and Nomina.IDRegNom = " + idRegNomina.ToString & _
            " where  sup.usuario = '" & Usuario & "' and  emp.Estatus = 'ACTIVO' " & _
            " order by Empleado "
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        CMD.CommandTimeout = 6000
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
        For Each Row As DataRow In dsCombos.Rows
            If Row("Estatus").ToString = "True" Then
                CambiarLectura(False)
            End If
        Next


    End Sub

    Private Sub cbEjercicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles CBe.ValueChanged, CBp.ValueChanged
        If CBe.Value = 2019 Then CBp.Minimum = 22 Else CBp.Minimum = 1
        CargaPeriodo()
        CargaCatalogo()
    End Sub

    Private Sub CargaPeriodo()
        If Inicio = True Then Exit Sub
        SQL = "SELECT idRegNomina, Ejercicio, NoSemana, Estatus, convert(varchar(10), FechaI, 103) as FechaI, convert(varchar(10), FechaF , 103) as FechaF FROM PreNominaHDr with(nolock) " & _
            " where Ejercicio = " & CBe.Value.ToString & " and NoSemana = " & CBp.Value.ToString
        Dim dsCod As New DataTable
        Dim daCod As New SqlDataAdapter
        Dim cmdCod As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dsCod)
        If dsCod.Rows.Count = 0 Then
            MsgBox("Periodo de Nomina no establecido, favor de verificar con el Administrador del Sistema.")
            CBe.Value = Now.Year
            CBp.Value = NoSemana
            Exit Sub
        End If
        ''If dsCod.Rows(0)("Estatus").ToString = "1" Then vReadOnly = False
        lPeriodo.Text = "Del " & dsCod.Rows(0)("FechaI").ToString & " al " & dsCod.Rows(0)("FechaF").ToString
        idRegNomina = dsCod.Rows(0)("idRegNomina")
    End Sub

    Private Sub PrenomProm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub GridView1_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        'e.Column.Caption = "Sueldo" Or 
        Try
            If e.Column.Caption = "Sueldo" Or e.Column.Caption = "Total" Then Exit Sub
            If e.Column.Caption = "Comisiones" Then
                Actualiza(GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado), e.Column.Caption, e.Value)
            Else
                If e.Column.Caption <> "Sueldo Diario" Then
                    Actualiza(GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado), e.Column.Caption, e.Value.ToString)
                    If e.Value.ToString = "BAJ" Then
                        Select Case e.Column.Caption
                            Case "MIE"
                                GridView1.SetRowCellValue(Renglon, D2, "BAJ")
                            Case "JUE"
                                GridView1.SetRowCellValue(Renglon, D3, "BAJ")
                            Case "VIE"
                                GridView1.SetRowCellValue(Renglon, D4, "BAJ")
                            Case "SAB"
                                GridView1.SetRowCellValue(Renglon, D5, "BAJ")
                            Case "DOM"
                                GridView1.SetRowCellValue(Renglon, D6, "BAJ")
                            Case "LUN"
                                GridView1.SetRowCellValue(Renglon, D7, "BAJ")
                        End Select
                    Else
                        '  MsgBox("El Dato que intentas ingresar es incorrecto, favor de verificarlo.")
                    End If
                Else
                    Try

                        SQL = "update catrhPromotores set Sueldo = " & GridView1.GetRowCellValue(e.RowHandle, sDiario).ToString & _
                            " where NoEmp = " & GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado).ToString
                        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                        Dim cmd As New SqlCommand(SQL, Conexion01)
                        cmd.ExecuteNonQuery()
                        Dim TotDias = 0.0
                        If GridView1.GetRowCellValue(e.RowHandle, D1) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D1) = "VAC" Then TotDias = TotDias + 1
                        If GridView1.GetRowCellValue(e.RowHandle, D2) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D2) = "VAC" Then TotDias = TotDias + 1
                        If GridView1.GetRowCellValue(e.RowHandle, D3) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D3) = "VAC" Then TotDias = TotDias + 1
                        If GridView1.GetRowCellValue(e.RowHandle, D4) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D4) = "VAC" Then TotDias = TotDias + 1
                        If GridView1.GetRowCellValue(e.RowHandle, D5) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D5) = "VAC" Then TotDias = TotDias + 1
                        If GridView1.GetRowCellValue(e.RowHandle, D6) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D6) = "VAC" Then TotDias = TotDias + 1
                        If GridView1.GetRowCellValue(e.RowHandle, D7) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D7) = "VAC" Then TotDias = TotDias + 1
                        TotDias = GridView1.GetRowCellValue(e.RowHandle, sDiario) * TotDias
                        GridView1.SetRowCellValue(Renglon, Sueldo, TotDias)
                        GridView1.SetRowCellValue(Renglon, PerTot, TotDias + GridView1.GetRowCellValue(e.RowHandle, Comisiones))

                    Catch ex As Exception
                        MsgBox("Oucurrio un error al guardar la información.")
                    End Try
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Actualiza(ByVal NoEmp As String, Dato As String, Valor As String)
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand("spPreNomProm", Conexion01)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@idRegNom", SqlDbType.Int).Value = idRegNomina
            cmd.Parameters.Add("@NoEmp", SqlDbType.VarChar, 15).Value = NoEmp
            cmd.Parameters.Add("@Dato", SqlDbType.VarChar, 15).Value = Dato
            cmd.Parameters.Add("@Valor", SqlDbType.VarChar, 15).Value = Valor
            cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
            cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
            cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
            cmd.Parameters("@Msj").Direction = ParameterDirection.Output
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmd.ExecuteNonQuery()
            If cmd.Parameters("@Resultado").Value.ToString() = "1" Then
                MsgBox("Ocurrio un error al guardar el Registro, error:")
                Exit Sub
            End If
            GridView1.SetRowCellValue(Renglon, Sueldo, cmd.Parameters("@Msj").Value.ToString())
            GridView1.SetRowCellValue(Renglon, PerTot, (GridView1.GetRowCellValue(Renglon, Sueldo) + GridView1.GetRowCellValue(Renglon, Comisiones)).ToString)
            'GridView1.SetRowCellValue(Renglon, Sueldo, (GridView1.GetRowCellValue(Renglon, Sueldo) + GridView1.GetRowCellValue(Renglon, Sueldo)).ToString)
        Catch ex As Exception
            MsgBox("Ocurrio un error al guardar el Registro, error: " + Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub GridView1_CellValueChanging(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        'e.Column.Caption = "Sueldo" Or
        If e.Column.Caption = "Sueldo" Or e.Column.Caption = "Total" Then Exit Sub
        If e.Column.Caption = "Comisiones" Then
            Actualiza(GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado), e.Column.Caption, e.Value)
        Else
            If e.Column.Caption <> "Sueldo Diario" Then
                If e.Value = "X" Or e.Value = "F" Or e.Value = "P" Or e.Value = "VAC" Or e.Value = "INC" Or e.Value = "BAJ" Or e.Value = "" Then
                    Actualiza(GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado), e.Column.Caption, e.Value)
                Else
                    MsgBox("El Dato que intentas ingresar es incorrecto, favor de verificarlo.")
                End If
            Else
                Try
                    SQL = "update catrhPromotores set Sueldo = " & GridView1.GetRowCellValue(e.RowHandle, sDiario).ToString & _
                        " where NoEmp = " & GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado).ToString
                    Dim TotDias = 0.0
                    If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                    Dim cmd As New SqlCommand(SQL, Conexion01)
                    cmd.ExecuteNonQuery()
                    If GridView1.GetRowCellValue(e.RowHandle, D1) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D1) = "VAC" Then TotDias = TotDias + 1
                    If GridView1.GetRowCellValue(e.RowHandle, D2) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D2) = "VAC" Then TotDias = TotDias + 1
                    If GridView1.GetRowCellValue(e.RowHandle, D3) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D3) = "VAC" Then TotDias = TotDias + 1
                    If GridView1.GetRowCellValue(e.RowHandle, D4) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D4) = "VAC" Then TotDias = TotDias + 1
                    If GridView1.GetRowCellValue(e.RowHandle, D5) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D5) = "VAC" Then TotDias = TotDias + 1
                    If GridView1.GetRowCellValue(e.RowHandle, D6) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D6) = "VAC" Then TotDias = TotDias + 1
                    If GridView1.GetRowCellValue(e.RowHandle, D7) = "X" Or GridView1.GetRowCellValue(e.RowHandle, D7) = "VAC" Then TotDias = TotDias + 1
                    TotDias = GridView1.GetRowCellValue(e.RowHandle, sDiario) * TotDias
                    GridView1.SetRowCellValue(Renglon, Sueldo, TotDias)
                    GridView1.SetRowCellValue(Renglon, PerTot, TotDias + GridView1.GetRowCellValue(e.RowHandle, Comisiones))
                    
                Catch ex As Exception
                    MsgBox("Oucurrio un error al guardar la información.")
                End Try
            End If

        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Renglon = e.FocusedRowHandle.ToString
    End Sub

    Private Sub GridView1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Try
            Select Case e.CellValue.ToString
                Case "X"
                    e.Appearance.BackColor = Color.LimeGreen
                Case "F"
                    e.Appearance.BackColor = Color.Red
                Case "P"
                    e.Appearance.BackColor = Color.Yellow
                Case "VAC"
                    e.Appearance.BackColor = Color.SkyBlue
                Case "INC"
                    e.Appearance.BackColor = Color.LightGray
                Case "BAJ"
                    e.Appearance.BackColor = Color.DimGray
                Case Else
                    e.Appearance.BackColor = Color.White
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub bCierreP_Click(sender As System.Object, e As System.EventArgs) Handles bCierreP.Click
        If MsgBox("Una vez cerrado el periodo no podrás realizar modificaciones en el mismo, ¿Deseas continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        'Exit Sub
        SQL = "update PreNominaProm set estatus = 1  where NoEmp in (" & _
            " Select Prom.NoEmp from catRHSupervisores as Sup  with(nolock) " & _
            " inner join catrhPromotores as Prom  with(nolock)  on case when sup.SU = 1 then Prom.NoSupervisor else sup.NoEmp end = Prom.NoSupervisor " & _
            "  where  sup.usuario = '" & Usuario & "' )"
        Dim Transac As SqlTransaction
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        Transac = Conexion01.BeginTransaction
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand(SQL, Conexion01)
            cmd.Transaction = Transac
            cmd.ExecuteNonQuery()
            Transac.Commit()
            ' If Nuevo = True Then Nuevo = False
            'GridView1.SetRowCellValue(Renglon, Columna, "20/03/2019 00:00:00") 
            CambiarLectura(False)
            MsgBox("Periodo Cerrado con éxito.")
        Catch ex As Exception
            Transac.Rollback()
            MsgBox(" Ocurrio un error al cerrar el periodo" + ex.Message, MsgBoxStyle.Critical, Empresa & "")
            Exit Sub
        End Try
    End Sub

    Private Sub CambiarLectura(ByVal Estatus As Boolean)
        Estatus = Not Estatus
        bCierreP.Enabled = Not Estatus
        GridView1.Columns("D1").OptionsColumn.ReadOnly = Estatus
        GridView1.Columns("D2").OptionsColumn.ReadOnly = Estatus
        GridView1.Columns("D3").OptionsColumn.ReadOnly = Estatus
        GridView1.Columns("D4").OptionsColumn.ReadOnly = Estatus
        GridView1.Columns("D5").OptionsColumn.ReadOnly = Estatus
        GridView1.Columns("D6").OptionsColumn.ReadOnly = Estatus
        GridView1.Columns("D7").OptionsColumn.ReadOnly = Estatus
        ' GridView1.Columns("Sueldo").OptionsColumn.ReadOnly = Estatus
        GridView1.Columns("Comisiones").OptionsColumn.ReadOnly = Estatus
    End Sub
End Class