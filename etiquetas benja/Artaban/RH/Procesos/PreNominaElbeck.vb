Imports System.Data.SqlClient
Imports System.Data.OleDb

Imports System.IO
Public Class PreNominaElbeck
    Dim Original = ""
    Dim Nuevo = ""
    Dim SQL As String = ""
    Dim xls_cn As New OleDbConnection
    Dim xls_cmd As New OleDbCommand
    Dim xls_reader As New OleDbDataAdapter
    Dim xlsx As String
    Dim patharchivo As New OpenFileDialog
    Dim Columna As New DevExpress.XtraGrid.Columns.GridColumn
    Dim Renglon = 0
    Dim MuestraMensaje = True
    Dim NewDato As String = ""
    Dim OldDato As String = ""
    Public NoEmpresa = 0
    Private Sub CatComposiciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Select Case NoEmpresa
            Case 1
                Me.Text = "Prenomina Elbeck"
                ColDepartamento.Visible = False
            Case 2
                Me.Text = "Checadas Therapedic"
            Case 3
                Me.Text = "Checadas Metalicos"
            Case 4
                Me.Text = "Checadas FoumArt"
        End Select
        'CargaComposiciones()
        'CargaCatalogo()
    End Sub

    Private Sub CargaCatalogo()
        Dim NoEmp As String
        Dim dsCombos As New DataTable
        Dim daCombos As New SqlDataAdapter
        If Not IsNumeric(cbNoEmpleado.Text) Then NoEmp = "" Else NoEmp = cbNoEmpleado.Text
        Select Case NoEmpresa
            Case 0
                Me.Close()
                Exit Sub
            Case 1
                SQL = "exec spRevPrenominaElbeck '" & cbTipoNom.Text & "', '" & eEjercicio.Text & "', '" & ePeriodo.Text & "', '" & NoEmp & "' "
            Case 2
                SQL = "Exec spRepPrenominaThera '" & eEjercicio.Text & "', '" & ePeriodo.Text & "', '" & NoEmp & "', '" & Usuario & "'"
            Case 3
                SQL = "Exec spRepPrenominaMetalicos '" & eEjercicio.Text & "', '" & ePeriodo.Text & "', '" & NoEmp & "', '" & Usuario & "'"
            Case 4
                SQL = "Exec spRepPrenominaFoam '" & eEjercicio.Text & "', '" & ePeriodo.Text & "', '" & NoEmp & "', '" & Usuario & "'"
        End Select
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
        If dsCombos.Rows.Count > 0 Then 
            colD1E.Caption = dsCombos.Rows(0)(0).ToString.Substring(0, 10) & " ENT"
            ColD1S.Caption = dsCombos.Rows(0)(0).ToString.Substring(0, 10) & " SAL"
            ColTD1.Caption = dsCombos.Rows(0)(0).ToString.Substring(0, 10) '& " HRS."
            colD2E.Caption = CStr(DateAdd(DateInterval.Day, 1, dsCombos.Rows(0)(0))) & " ENT"
            ColD2S.Caption = CStr(DateAdd(DateInterval.Day, 1, dsCombos.Rows(0)(0))) & " SAL"
            ColTD2.Caption = CStr(DateAdd(DateInterval.Day, 1, dsCombos.Rows(0)(0))) '& " HRS."
            colD3E.Caption = CStr(DateAdd(DateInterval.Day, 2, dsCombos.Rows(0)(0))) & " ENT"
            ColD3S.Caption = CStr(DateAdd(DateInterval.Day, 2, dsCombos.Rows(0)(0))) & " SAL"
            ColTD3.Caption = CStr(DateAdd(DateInterval.Day, 2, dsCombos.Rows(0)(0))) '& " HRS."
            colD4E.Caption = CStr(DateAdd(DateInterval.Day, 3, dsCombos.Rows(0)(0))) & " ENT"
            ColD4S.Caption = CStr(DateAdd(DateInterval.Day, 3, dsCombos.Rows(0)(0))) & " SAL"
            ColTD4.Caption = CStr(DateAdd(DateInterval.Day, 3, dsCombos.Rows(0)(0))) '& " HRS."
            colD5E.Caption = CStr(DateAdd(DateInterval.Day, 4, dsCombos.Rows(0)(0))) & " ENT"
            ColD5S.Caption = CStr(DateAdd(DateInterval.Day, 4, dsCombos.Rows(0)(0))) & " SAL"
            ColTD5.Caption = CStr(DateAdd(DateInterval.Day, 4, dsCombos.Rows(0)(0))) '& " HRS."
            colD6E.Caption = CStr(DateAdd(DateInterval.Day, 5, dsCombos.Rows(0)(0))) & " ENT"
            ColD6S.Caption = CStr(DateAdd(DateInterval.Day, 5, dsCombos.Rows(0)(0))) & " SAL"
            ColTD6.Caption = CStr(DateAdd(DateInterval.Day, 5, dsCombos.Rows(0)(0))) '& " HRS."
            colD7E.Caption = CStr(DateAdd(DateInterval.Day, 6, dsCombos.Rows(0)(0))) & " ENT"
            ColD7S.Caption = CStr(DateAdd(DateInterval.Day, 6, dsCombos.Rows(0)(0))) & " SAL"
            ColTD7.Caption = CStr(DateAdd(DateInterval.Day, 6, dsCombos.Rows(0)(0))) '& " HRS."
        End If
    End Sub


    Private Sub CatComposiciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub CatComposiciones_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub cbTipoNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbTipoNom.SelectedIndexChanged
        Dim SQLCombo = ""
        Select Case NoEmpresa
            Case 1 'Elbeck
                SQLCombo = "Select '' as NoEmpleado, '' as Empleado union all " & _
                        " select cast([i-empl_num] as varchar(10)) NoEmpleado, [c-empl_nom] + ' ' + [c-empl_app] + ' ' + [c-empl_apm] Empleado  " & _
                        " from [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock) where [c-comp_clv] = 5 and [c-empl_sts] = 'ACTIVO' and [c-nomi_clv] = "

                If cbTipoNom.Text = "SEMANAL1" Then SQLCombo = SQLCombo + " 'SEMANA1' " Else SQLCombo = SQLCombo + " 'SEMANA2' "
                SQLCombo = SQLCombo + " order by Empleado"
                CargaCombo(cbEmpleado, SQLCombo, "NoEmpleado", "Empleado")

                SQLCombo = "Select '' as NoEmpleado, '' as Empleado union all " & _
                        " select Cast([i-empl_num] as varchar(10)) NoEmpleado, [c-empl_nom] + ' ' + [c-empl_app] + ' ' + [c-empl_apm] Empleado  " & _
                        " from [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock) where [c-comp_clv] = 5 and [c-empl_sts] = 'ACTIVO' and [c-nomi_clv] = "
                If cbTipoNom.Text = "SEMANAL1" Then SQLCombo = SQLCombo + "'SEMANA1' " Else SQLCombo = SQLCombo + "'SEMANA2' "
                SQLCombo = SQLCombo + " order by NoEmpleado "
                CargaCombo(cbNoEmpleado, SQLCombo, "Empleado", "NoEmpleado")
            Case 2 'Therapedic
                SQLCombo = "Select '' as NoEmpleado, '' as Empleado union all " & _
                    " select [i-empl_num] NoEmpleado, replace([c-empl_nom] + ' ' + [c-empl_app] + ' ' + [c-empl_apm],'  ',' ') Empleado  " & _
                    " from [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock) where [c-comp_clv] = 1 and [c-empl_sts] = 'ACTIVO' " & _
                    " union " & _
                    " select [i-empl_num] NoEmpleado, replace([c-empl_nom] + ' ' + [c-empl_app] + ' ' + [c-empl_apm],'  ',' ') Empleado  " & _
                    " from [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock) where [c-comp_clv] = 11 and [c-empl_sts] = 'ACTIVO' " & _
                    " order by Empleado "
                CargaCombo(cbEmpleado, SQLCombo, "NoEmpleado", "Empleado")


                SQLCombo = "Select '' as NoEmpleado, '' as Empleado union all " & _
                    " select [i-empl_num] NoEmpleado, replace([c-empl_nom] + ' ' + [c-empl_app] + ' ' + [c-empl_apm],'  ',' ') Empleado  " & _
                    " from [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock) where [c-comp_clv] = 1 and [c-empl_sts] = 'ACTIVO' " & _
                    " union " & _
                    " select [i-empl_num] NoEmpleado, replace([c-empl_nom] + ' ' + [c-empl_app] + ' ' + [c-empl_apm],'  ',' ') Empleado  " & _
                    " from [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock) where [c-comp_clv] = 11 and [c-empl_sts] = 'ACTIVO' " & _
                    " order by NoEmpleado "
                CargaCombo(cbNoEmpleado, SQLCombo, "Empleado", "NoEmpleado")
        End Select
        cbEmpleado.Text = ""
        cbNoEmpleado.Text = ""
    End Sub

    Private Sub bAgregar_Click(sender As System.Object, e As System.EventArgs) Handles bAgregar.Click
        If cbTipoNom.Text = "" Then
            MsgBox("Se debe indicar el tipo de nómina.")
            cbTipoNom.Focus()
            Exit Sub
        End If

        If eEjercicio.Text = "" Then
            MsgBox("Se debe indicar el año del ejercicio.")
            eEjercicio.Focus()
            Exit Sub
        End If

        If ePeriodo.Text = "" Then
            MsgBox("Se debe indicar el periodo.")
            ePeriodo.Focus()
            Exit Sub
        End If
        addEntrada.Value = Now()
        addSalida.Value = Now()
        pAdd.Visible = True
        pAdd.Dock = DockStyle.Fill
        cbAddNoEmp.Properties.DataSource = cbNoEmpleado.Properties.DataSource
        cbAddNoEmp.Properties.ValueMember = cbNoEmpleado.Properties.ValueMember
        cbAddNoEmp.Properties.DisplayMember = cbNoEmpleado.Properties.DisplayMember
        cbAddEmp.Properties.DataSource = cbEmpleado.Properties.DataSource
        cbAddEmp.Properties.ValueMember = cbEmpleado.Properties.ValueMember
        cbAddEmp.Properties.DisplayMember = cbEmpleado.Properties.DisplayMember
        cbAddEmp.Text = ""
        cbAddNoEmp.Text = ""
        addEntrada.Focus()
    End Sub

    Private Sub bAplicar_Click(sender As System.Object, e As System.EventArgs) Handles bAplicar.Click
        pEdicion.Enabled = False
        CargaCatalogo()
    End Sub

    Private Sub bEliminar_Click(sender As System.Object, e As System.EventArgs) Handles bEliminar.Click
        pEdicion.Enabled = False
        CargaCatalogo()
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        If cbTipoNom.Text = "" Then
            MsgBox("Favor de indicar el Tipo de Nomina (Semanal1,Semanal2)", MsgBoxStyle.Critical)
            cbTipoNom.Focus()
            Exit Sub
        End If
        If eEjercicio.Text = "" Then
            MsgBox("Favor de indicar el año del Ejercicio. (Ejem. 2019)", MsgBoxStyle.Critical)
            eEjercicio.Focus()
            Exit Sub
        End If
        If ePeriodo.Text = "" Then
            MsgBox("Favor de indicar el Periodo.", MsgBoxStyle.Critical)
            ePeriodo.Focus()
            Exit Sub
        End If
        CargaCatalogo()
    End Sub

    Private Sub bImportar_Click(sender As System.Object, e As System.EventArgs) Handles bImportar.Click
        Select Case NoEmpresa
            Case 1 'Elbeck
                ImportaElbeck()
            Case 2 'Therapedic
                ImportaTh()
        End Select
        
    End Sub

    Private Sub ImportaElbeck()
        If MsgBox("El proceso tardara unos minutos ¿desea continuar? Recuerda, el Nombre de la Hoja debe ser 'Sheet 1'", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        patharchivo.ShowDialog()
        xlsx = patharchivo.FileName
        Dim SqlCarga = "set dateformat dmy  " & _
             " declare @Fecha as datetime  " & _
             " set @Fecha = GETDATE() " & _
             " insert into PreNominaElbeckResp " & _
             " Select @Fecha, [NoEmpleado], [Checada], [Tipo] from [PreNominaElbeck] " & _
             " declare @Minutos as int  /*Cantidad de minutos entre checadas validas */   " & _
             " set @Minutos =10   " & _
             " declare @ChecadaIni datetime " & _
             " declare @NoEmpleado int   " & _
             " declare @Checado datetime   " & _
             " declare @TempIngreso as table (NoEmpleado int, Checado datetime)   " & _
             " insert into @TempIngreso  "
        Try
            If xlsx = "" Then
                MsgBox("Error", MsgBoxStyle.Critical, " Msj00010")
                Exit Sub
            Else
                Dim strExtension As String = ""
                Dim nombreXls As String

                nombreXls = Path.GetFileName(xlsx)
                strExtension = Path.GetExtension(xlsx)
                If strExtension = ".xlsx" Or strExtension = ".xls" Then
                    If (File.Exists(xlsx)) Then
                        If strExtension = "xls" Then
                            xls_cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + xlsx + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'")
                        Else
                            xls_cn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & xlsx & "; Extended Properties='Excel 12.0 Xml;HDR=YES';")
                        End If
                        Dim dt As New DataTable("Datos")
                        Using xls_cn
                            xls_cn.Open()
                            xls_cmd.CommandText = "SELECT * FROM [Sheet 1$]"
                            xls_cmd.Connection = xls_cn
                            xls_reader.SelectCommand = xls_cmd
                            Dim da As New OleDbDataAdapter(xls_cmd)
                            da.Fill(dt)
                            If dt.Rows.Count = 0 Then
                                MsgBox("No hay registros para importar")
                                Exit Sub
                                '[No.] as NoEmpleado, [Date/Time] as Checada 
                            End If
                            For i = 0 To dt.Rows.Count - 1
                                If i > 0 Then SqlCarga = SqlCarga & " Union all "
                                SqlCarga = SqlCarga & " Select " & dt.Rows(i).Item(0) & ", '" & Convert.ToDateTime(dt.Rows(i).Item(1)).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                            Next
                        End Using
                    End If
                End If
            End If
            SqlCarga = SqlCarga & " declare @Cont int " & _
                 "declare @TipoReg varchar(1)  " & _
                 "Set @TipoReg = 'E'  " & _
                 "declare @TempChecada as table (NoEmpleado int, Checado datetime)   " & _
                 "DECLARE Checada_Cur CURSOR FOR     " & _
                 "SELECT *FROM @TempIngreso order by NoEmpleado, Checado   " & _
                 "OPEN Checada_Cur   " & _
                 "   FETCH NEXT FROM Checada_Cur INTO @NoEmpleado, @Checado    " & _
                 "   WHILE @@FETCH_STATUS = 0    " & _
                 "   BEGIN   " & _
                 "		set @ChecadaIni = cast(convert(varchar(10), @Checado, 103) as datetime) " & _
                 "		select @ChecadaIni Inicial, @Checado Checado " & _
                 "		set @Cont = 0    " & _
                 "  	set @Cont = (Select count(*) From PrenominaElbeck  where NoEmpleado = @NoEmpleado and checada between dateadd(second,@MInutos * -60, @Checado) and  dateadd(second, 10*60, Checada))   " & _
                 "		if @Cont = 0   " & _
                 "      begin " & _
                 "		set @cont = (Select count(*) % 2 from PrenominaElbeck where noEmpleado = @NoEmpleado and checada between @Checadaini and @Checado) " & _
                 "	    if @Cont = 0 " & _
                 "		begin " & _
                 "			set @TipoReg = 'E' " & _
                 "		end 				 " & _
                 "		else  " & _
                 "      begin " & _
                 "      	set @TipoReg = 'S' " & _
                 "      End " & _
                 "		    insert into PrenominaElbeck   " & _
                 "		    select @NoEmpleado, @Checado, @TipoReg  " & _
                 "      End   " & _
                 "      FETCH NEXT FROM Checada_Cur INTO @NoEmpleado, @Checado   " & _
                 "  End   " & _
                 "  Close Checada_Cur   " & _
                 "  DEALLOCATE Checada_Cur     "

            Dim cmdIns As New SqlCommand(SqlCarga, Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmdIns.ExecuteNonQuery()
            MsgBox("Importación de registros finalizada.")
        Catch ex As Exception
            MsgBox("Error" & Chr(13) & Chr(13) & ex.Message)
        End Try
    End Sub

    Private Sub ImportaTH()
        If MsgBox("El proceso tardara unos minutos ¿desea continuar? Recuerda, el Nombre de la Hoja debe ser 'Hoja 1'", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        patharchivo.ShowDialog()
        xlsx = patharchivo.FileName
        Dim SqlCarga = "set dateformat dmy  " & _
             " declare @Fecha as datetime  " & _
             " set @Fecha = GETDATE() " & _
             " insert into PreNominaTHResp " & _
             " Select @Fecha, [NoEmpleado], [Checada], [Tipo] from [PreNominaTHResp] " & _
             " declare @Minutos as int  /*Cantidad de minutos entre checadas validas */   " & _
             " set @Minutos =10   " & _
             " declare @ChecadaIni datetime " & _
             " declare @NoEmpleado int   " & _
             " declare @Checado datetime   " & _
             " declare @TempIngreso as table (NoEmpleado int, Checado datetime)   " & _
             " insert into @TempIngreso  "
        Try
            If xlsx = "" Then
                MsgBox("Error", MsgBoxStyle.Critical, " Msj00010")
                Exit Sub
            Else
                Dim strExtension As String = ""
                Dim nombreXls As String

                nombreXls = Path.GetFileName(xlsx)
                strExtension = Path.GetExtension(xlsx)
                If strExtension = ".xlsx" Or strExtension = ".xls" Then
                    If (File.Exists(xlsx)) Then
                        If strExtension = "xls" Then
                            xls_cn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + xlsx + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=0'")
                        Else
                            xls_cn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & xlsx & "; Extended Properties='Excel 12.0 Xml;HDR=YES';")
                        End If
                        Dim dt As New DataTable("Datos")
                        Using xls_cn
                            xls_cn.Open()
                            xls_cmd.CommandText = "SELECT * FROM [Hoja 1$]"
                            xls_cmd.Connection = xls_cn
                            xls_reader.SelectCommand = xls_cmd
                            Dim da As New OleDbDataAdapter(xls_cmd)
                            da.Fill(dt)
                            If dt.Rows.Count = 0 Then
                                MsgBox("No hay registros para importar")
                                Exit Sub
                                '[No.] as NoEmpleado, [Date/Time] as Checada 
                            End If
                            For i = 0 To dt.Rows.Count - 1
                                If i > 0 Then SqlCarga = SqlCarga & " Union all "
                                SqlCarga = SqlCarga & " Select " & dt.Rows(i).Item(0) & ", '" & Convert.ToDateTime(dt.Rows(i).Item(1)).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                            Next
                        End Using
                    End If
                End If
            End If
            SqlCarga = SqlCarga & " declare @Cont int " & _
                 "declare @TipoReg varchar(1)  " & _
                 "Set @TipoReg = 'E'  " & _
                 "declare @TempChecada as table (NoEmpleado int, Checado datetime)   " & _
                 "DECLARE Checada_Cur CURSOR FOR     " & _
                 "SELECT *FROM @TempIngreso order by NoEmpleado, Checado   " & _
                 "OPEN Checada_Cur   " & _
                 "   FETCH NEXT FROM Checada_Cur INTO @NoEmpleado, @Checado    " & _
                 "   WHILE @@FETCH_STATUS = 0    " & _
                 "   BEGIN   " & _
                 "		set @ChecadaIni = cast(convert(varchar(10), @Checado, 103) as datetime) " & _
                 "		select @ChecadaIni Inicial, @Checado Checado " & _
                 "		set @Cont = 0    " & _
                 "  	set @Cont = (Select count(*) From PreNominaTH  where NoEmpleado = @NoEmpleado and checada between dateadd(second,@MInutos * -60, @Checado) and  dateadd(second, 10*60, Checada))   " & _
                 "		if @Cont = 0   " & _
                 "      begin " & _
                 "		set @cont = (Select count(*) % 2 from PreNominaTH where noEmpleado = @NoEmpleado and checada between @Checadaini and @Checado) " & _
                 "	    if @Cont = 0 " & _
                 "		begin " & _
                 "			set @TipoReg = 'E' " & _
                 "		end 				 " & _
                 "		else  " & _
                 "      begin " & _
                 "      	set @TipoReg = 'S' " & _
                 "      End " & _
                 "		    insert into PreNominaTH   " & _
                 "		    select @NoEmpleado, @Checado, @TipoReg  " & _
                 "      End   " & _
                 "      FETCH NEXT FROM Checada_Cur INTO @NoEmpleado, @Checado   " & _
                 "  End   " & _
                 "  Close Checada_Cur   " & _
                 "  DEALLOCATE Checada_Cur     "

            Dim cmdIns As New SqlCommand(SqlCarga, Conexion01)
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            cmdIns.ExecuteNonQuery()
            MsgBox("Importación de registros finalizada.")
        Catch ex As Exception
            MsgBox("Error" & Chr(13) & Chr(13) & ex.Message)
        End Try
    End Sub
    Private Sub cbNoEmpleado_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbNoEmpleado.EditValueChanged
        cbEmpleado.Text = cbNoEmpleado.EditValue
    End Sub

    Private Sub cbEmpleado_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbEmpleado.EditValueChanged
        cbNoEmpleado.Text = cbEmpleado.EditValue
    End Sub

    Private Sub GridView1_RowCellStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If (e.Column.FieldName = "D1E" Or e.Column.FieldName = "D1S" Or e.Column.FieldName = "D2E" Or e.Column.FieldName = "D2S" Or e.Column.FieldName = "D3E" Or e.Column.FieldName = "D3S" Or e.Column.FieldName = "D4E" Or e.Column.FieldName = "D4S" Or e.Column.FieldName = "D5E" Or e.Column.FieldName = "D5S" Or e.Column.FieldName = "D6E" Or e.Column.FieldName = "D6S" Or e.Column.FieldName = "D7E" Or e.Column.FieldName = "D7S") And e.CellValue.ToString = "" Then
            e.Appearance.BackColor = Color.Red
        End If
    End Sub

    Private Sub GridView1_CellValueChanging(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanging
        'Exit Sub
        Dim tipo = e.Column.ToString.Substring(e.Column.ToString.Length - 3, 1)
        Original = (GridView1.GetRowCellValue(e.RowHandle, e.Column))
        If IsDBNull(Original) Then Original = ""
        Dim SQL = ""
        If IsNothing(e.Value) Then
            Nuevo = ""
        Else
            Nuevo = e.Value.ToString
            Nuevo = Convert.ToDateTime(Nuevo).ToString("dd/MM/yyyy HH:mm:ss")
        End If
        If Original.ToString = Nuevo Then Exit Sub
        Select Case NoEmpresa
            Case 1 'Elbeck
                If Original.ToString = "" Then
                    SQL = "set dateformat dmy " & _
                        " Insert into PreNominaElbeck " & _
                        " Select " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " NoEmpleado, '" & Nuevo.ToString & "' as Checada, '" & tipo & "' Tipo "
                Else
                    If Nuevo.ToString = "" Then
                        SQL = "set dateformat dmy Delete PreNominaElbeck " & _
                            " where NoEmpleado = " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " And Checada = '" & Convert.ToDateTime(Original).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                    Else
                        SQL = "set dateformat dmy Update PreNominaElbeck " & _
                            " Set Checada = '" & Nuevo.ToString & "' " & _
                            " where NoEmpleado = " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " And Checada = '" & Convert.ToDateTime(Original).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                    End If
                End If
            Case 2 'Therapedic
                If Original.ToString = "" Then
                    SQL = "set dateformat dmy " & _
                        " Insert into PreNominaTH " & _
                        " Select " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " NoEmpleado, '" & Nuevo.ToString & "' as Checada, '" & tipo & "' Tipo "
                Else
                    If Nuevo.ToString = "" Then
                        SQL = "set dateformat dmy Delete PreNominaTH " & _
                            " where NoEmpleado = " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " And Checada = '" & Convert.ToDateTime(Original).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                    Else
                        SQL = "set dateformat dmy Update PreNominaTH " & _
                            " Set Checada = '" & Nuevo.ToString & "' " & _
                            " where NoEmpleado = " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " And Checada = '" & Convert.ToDateTime(Original).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                    End If
                End If
        End Select
        
        'MsgBox(SQL)
        'GridView1.SetRowCellValue(Renglon + 1, Columna, "20/03/2019 00:00:00")
        'Exit Sub
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
            If MuestraMensaje = True Then MsgBox("Registro Guardado con éxito.")
        Catch ex As Exception
            Transac.Rollback()
            MsgBox(" Ocurrio un error al gardar la información" + ex.Message, MsgBoxStyle.Critical, Empresa & "")
            Exit Sub
        End Try

    End Sub

    Private Sub GridView1_FocusedColumnChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        'MsgBox(e.FocusedColumn.AbsoluteIndex)
        ' MsgBox(e.FocusedColumn.Name)
        Columna = e.FocusedColumn 
        'MsgBox(GridView1.GetRowCellValue(10, GridView1.Columns(1)))
        ' MsgBox(GridView1.GetRowCellValue(10, GridView1.Columns(1)))
        'GridView1.SetRowCellValue(11,
        'MsgBox("Columna: " & Columna.Name & ", Renglon: " & Renglon.ToString)
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        ' MsgBox(e.FocusedRowHandle.ToString)
        Renglon = e.FocusedRowHandle.ToString
        'MsgBox("Columna: " & Columna.Name & ", Renglon: " & Renglon.ToString)
    End Sub

    Private Sub bCambiar_Click(sender As System.Object, e As System.EventArgs) Handles bCambiar.Click
        MuestraMensaje = False
        Select Case Columna.Name
            Case "colD1E"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD1E)) Then OldDato = Nothing Else OldDato = Convert.ToDateTime(GridView1.GetRowCellValue(Renglon, colD1E)).ToString("dd/MM/yyyy HH:mm:ss")
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD1S)) Then NewDato = Nothing Else NewDato = Convert.ToDateTime(GridView1.GetRowCellValue(Renglon, ColD1S)).ToString("dd/MM/yyyy HH:mm:ss")
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD1E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD1S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD1E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD1S, OldDato)
            Case "colD2E"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD2E)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, colD2E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD2S)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, ColD2S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD2E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD2S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD2E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD2S, OldDato)
            Case "colD3E"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD3E)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, colD3E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD3S)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, ColD3S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD3E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD3S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD3E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD3S, OldDato)
            Case "colD4E"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD4E)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, colD4E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD4S)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, ColD4S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD4E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD4S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD4E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD4S, OldDato)
            Case "colD5E"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD5E)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, colD5E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD5S)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, ColD5S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD5E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD5S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD5E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD5S, OldDato)
            Case "colD6E"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD6E)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, colD6E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD6S)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, ColD6S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD6E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD6S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD6E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD6S, OldDato)
            Case "colD7E"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD7E)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, colD7E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD7S)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, ColD7S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD7E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD7S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD7E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD7S, OldDato)
            Case "colD1S"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD1E)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, colD1E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD1S)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, ColD1S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD1E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD1S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD1E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD2S, OldDato)
            Case "colD2S"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD2E)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, colD2E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD2S)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, ColD2S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD2E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD2S, Nothing)
                Original = Nothing
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, colD2E, OldDato)
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, ColD2S, NewDato)
            Case "colD3S"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD3E)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, colD3E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD3S)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, ColD3S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD3E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD3S, Nothing)
                Original = Nothing
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, colD3E, Nuevo)
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, ColD3S, Original)
            Case "colD4S"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD4E)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, colD4E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD4S)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, ColD4S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD4E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD4S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD4E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD4S, OldDato)
            Case "colD5S"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD5E)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, colD5E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD5S)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, ColD5S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD5E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD5S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD5E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD5S, OldDato)
            Case "colD6S"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD6E)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, colD6E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD6S)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, ColD6S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD6E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD6S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD6E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD6S, OldDato)
            Case "colD7S"
                If IsDBNull(GridView1.GetRowCellValue(Renglon, colD7E)) Then NewDato = Nothing Else NewDato = GridView1.GetRowCellValue(Renglon, colD7E)
                If IsDBNull(GridView1.GetRowCellValue(Renglon, ColD7S)) Then OldDato = Nothing Else OldDato = GridView1.GetRowCellValue(Renglon, ColD7S)
                Original = OldDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, colD7E, Nothing)
                Original = NewDato
                Nuevo = Nothing
                GridView1.SetRowCellValue(Renglon, ColD7S, Nothing)
                Original = Nothing
                Nuevo = NewDato
                GridView1.SetRowCellValue(Renglon, colD7E, NewDato)
                Nuevo = OldDato
                GridView1.SetRowCellValue(Renglon, ColD7S, OldDato)
        End Select
        MsgBox("Registro Guardado con éxito...")
        MuestraMensaje = True
    End Sub

    Private Sub GridView1_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If MuestraMensaje = True Then Exit Sub
        Dim tipo = e.Column.ToString.Substring(e.Column.ToString.Length - 3, 1)
        'Original = (GridView1.GetRowCellValue(e.RowHandle, e.Column))
        ' Original = OldDato
        'If IsNothing(Original) Then Original = ""
        'If IsNothing(Nuevo) Then Nuevo = ""
        If IsDBNull(Original) Then Original = ""
        Dim SQL = ""
        If IsNothing(e.Value) Or Nuevo = "" Then
            Nuevo = ""
        Else
            'Nuevo = e.Value.ToString
            Nuevo = Convert.ToDateTime(Nuevo).ToString("dd/MM/yyyy HH:mm:ss")
        End If
        'Nuevo = NewDato
        If IsNothing(Original) = True Then
            If "" = Nuevo Then Exit Sub
        Else
            If Original.ToString = Nuevo Then Exit Sub
        End If
        Select Case NoEmpresa
            Case 1 'Elbeck
                If IsNothing(Original) = True Then
                    SQL = "set dateformat dmy " & _
                        " Insert into PreNominaElbeck " & _
                        " Select " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " NoEmpleado, '" & Nuevo.ToString & "' as Checada, '" & tipo & "' Tipo "
                Else
                    If Original.ToString = "" Then
                        SQL = "set dateformat dmy " & _
                            " Insert into PreNominaElbeck " & _
                            " Select " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " NoEmpleado, '" & Nuevo.ToString & "' as Checada, '" & tipo & "' Tipo "
                    Else
                        If Nuevo.ToString = "" Then
                            SQL = "set dateformat dmy Delete PreNominaElbeck " & _
                                " where NoEmpleado = " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " And Checada = '" & Convert.ToDateTime(Original).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                        Else
                            SQL = "set dateformat dmy Update PreNominaElbeck " & _
                                " Set Checada = '" & Nuevo.ToString & "' " & _
                                " where NoEmpleado = " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " And Checada = '" & Convert.ToDateTime(Original).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                        End If
                    End If
                End If
            Case 2 'Therapedic
                If IsNothing(Original) = True Then
                    SQL = "set dateformat dmy " & _
                        " Insert into PreNominaTh " & _
                        " Select " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " NoEmpleado, '" & Nuevo.ToString & "' as Checada, '" & tipo & "' Tipo " & _
                        " Insert into PreNominaThLog " & _
                        " Select 'Registro', " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " NoEmpleado, '" & Nuevo.ToString & "' as Checada, '" & tipo & "' Tipo "
                Else
                    If Original.ToString = "" Then
                        SQL = "set dateformat dmy " & _
                            " Insert into PreNominaTh " & _
                            " Select " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " NoEmpleado, '" & Nuevo.ToString & "' as Checada, '" & tipo & "' Tipo "
                    Else
                        If Nuevo.ToString = "" Then
                            SQL = "set dateformat dmy Delete PreNominaTh " & _
                                " where NoEmpleado = " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " And Checada = '" & Convert.ToDateTime(Original).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                        Else
                            SQL = "set dateformat dmy Update PreNominaTh " & _
                                " Set Checada = '" & Nuevo.ToString & "' " & _
                                " where NoEmpleado = " & (GridView1.GetRowCellValue(e.RowHandle, colNoEmpleado)) & " And Checada = '" & Convert.ToDateTime(Original).ToString("dd/MM/yyyy HH:mm:ss") & "'"
                        End If
                    End If
                End If
        End Select
        'MsgBox(SQL)
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
            If MuestraMensaje = True Then MsgBox("Registro Guardado con éxito.")
        Catch ex As Exception
            Transac.Rollback()
            MsgBox(" Ocurrio un error al gardar la información" + ex.Message, MsgBoxStyle.Critical, Empresa & "")
            Exit Sub
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        ExportarXLSX(gcatalogo)
    End Sub

    Private Sub bAddIgnorar_Click(sender As System.Object, e As System.EventArgs) Handles bAddIgnorar.Click
        pAdd.Visible = False
    End Sub

    Private Sub bAddAplicar_Click(sender As System.Object, e As System.EventArgs) Handles bAddAplicar.Click
        If Not IsNumeric(cbAddNoEmp.Text) Then
            MsgBox("Es necesario indicar un número de operador valido.")
            cbAddNoEmp.Focus()
            Exit Sub
        End If
        If cbAddNoEmp.Text = "" Then
            MsgBox("Es necesario indicar el operador a registrar.")
            cbAddNoEmp.Focus()
            Exit Sub
        End If
        SQL = "set dateformat dmy " & _
                 " Insert into PreNominaElbeck " & _
                 " Select " & cbAddNoEmp.Text & " NoEmpleado, '" & addEntrada.Text & "' as Checada, 'E' Tipo " & _
                 " Union All " & _
                 " Select " & cbAddNoEmp.Text & " NoEmpleado, '" & addSalida.Text & "' as Checada, 'S' Tipo "
        Dim Transac As SqlTransaction
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        Transac = Conexion01.BeginTransaction
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand(SQL, Conexion01)
            cmd.Transaction = Transac
            cmd.ExecuteNonQuery()
            Transac.Commit()
            If MuestraMensaje = True Then MsgBox("Registro Guardado con éxito.")
        Catch ex As Exception
            Transac.Rollback()
            MsgBox(" Ocurrio un error al gardar la información" + ex.Message, MsgBoxStyle.Critical, Empresa & "")
            Exit Sub
        End Try
        CargaCatalogo()
    End Sub

    Private Sub cbAddNoEmp_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbAddNoEmp.EditValueChanged
        cbAddEmp.Text = cbAddNoEmp.EditValue
    End Sub

    Private Sub cbAddEmp_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbAddEmp.EditValueChanged
        cbAddNoEmp.Text = cbAddEmp.EditValue
    End Sub
End Class