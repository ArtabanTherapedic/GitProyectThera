Imports System.Data.SqlClient
Public Class PreProdFrm
    Dim SQL = ""
    Dim Validador = ""
    Dim SQLUp = ""
    Dim SQLVal = ""
    Dim SQLUp2 = ""

    Private Sub PreProdFrm_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Show()
    End Sub
    Private Sub CargaRegistros(ByVal IDReg As String)
        Dim dtGrid As New DataTable
        Dim daGrid As New SqlDataAdapter
        If Conexion01.State = False Then Conexion01.Open()
        SQL = " Select case when FechaX4 > FechaY3 then case when isnull(R31retraso,0) > isnull(R32Retraso,0) then " & _
            " case when datepart(weekday, dateadd(Day, isnull(R31retraso,0)+1, FechaX4)) = 7 then dateadd(day,isnull(R31retraso,0)+3, FechaX4) else " & _
            " dateadd(day,isnull(R31retraso,0)+1, FechaX4) end else " & _
            " case when datepart(weekday, dateadd(Day, isnull(R32retraso,0)+1, FechaX4)) = 7 then dateadd(day,isnull(R32retraso,0)+3, FechaX4) else " & _
            " DateAdd(Day, isnull(R32Retraso, 0) + 1, FechaX4) " & _
            " end end " & _
            " else " & _
            " case when isnull(R31retraso,0) > isnull(R32Retraso,0) then " & _
            " case when datepart(weekday, dateadd(Day, isnull(R31retraso,0)+1, FechaY3)) = 7 then dateadd(day,isnull(R31retraso,0)+3, FechaY3) else " & _
            " dateadd(day,isnull(R31retraso,0)+1, FechaY3) end else " & _
            " case when datepart(weekday, dateadd(Day, isnull(R32retraso,0)+1, FechaY3)) = 7 then dateadd(day,isnull(R32retraso,0)+3, FechaY3) else " & _
            " DateAdd(Day, isnull(R32Retraso, 0) + 1, FechaY3) " & _
            " end end end AS FechaPT, " & _
            " * from (Select case when datepart(weekday, dateadd(Day, isnull(R24Retraso,0)+1, FechaX3)) = 7 then dateadd(day,isnull(R24retraso,0)+3, FechaX3) else " & _
            " dateadd(day,isnull(R24Retraso,0)+1, FechaX3) end FechaX4, " & _
            " * From (select case when FHuleEsp > FechaX2 then " & _
            " case when datepart(weekday, dateadd(Day, isnull(R23Retraso,0)+1, FHuleEsp)) = 7 then dateadd(day,isnull(R23retraso,0)+3, FHuleEsp) else " & _
            " dateadd(day,isnull(R23Retraso,0)+1, FHuleEsp) end  else " & _
            " case when datepart(weekday, dateadd(Day, isnull(R23Retraso,0)+1, FechaX2)) = 7 then dateadd(day,isnull(R23retraso,0)+3, FechaX2) else " & _
            " dateadd(day,isnull(R23Retraso,0)+1, FechaX2) end  end FechaX3,  " & _
            " case when datepart(weekday,dateadd(day,isnull(R13Retraso,0)+1, FechaY2)) = 7 then dateadd(day,isnull(R13Retraso,0)+3, FechaY2) else " & _
            " dateadd(day,isnull(R13Retraso,0)+1, FechaY2) end  FechaY3, " & _
            " * from (Select case when datepart(weekday, dateadd(Day, isnull(R22Retraso,0)+1, FechaX1)) = 7 then dateadd(day,isnull(R22retraso,0)+3, FechaX1) else " & _
            " dateadd(day,isnull(R22Retraso,0)+1, FechaX1) end FechaX2, " & _
            " case when datepart(weekday,dateadd(day,isnull(R12Retraso,0)+1, FechaY1)) = 7 then dateadd(day,isnull(R12Retraso,0)+3, FechaY1) else " & _
            " dateadd(day,isnull(R12Retraso,0)+1, FechaY1) end  FechaY2, " & _
            " * from( Select	 case when datepart(weekday,dateadd(day,isnull(R21Retraso,0)+1, FTela)) = 7 then dateadd(day,isnull(R21Retraso,0)+3, FTela) else " & _
            " dateadd(day,isnull(R21Retraso,0)+1, FTela) end  FechaX1, " & _
            " case when datepart(weekday,dateadd(day,isnull(R11Retraso,0)+1, FMadera)) = 7 then dateadd(day,isnull(R11Retraso,0)+3, FMadera) else " & _
            " dateadd(day,isnull(R11Retraso,0)+1, FMadera) end  FechaY1, " & _
            " * from ProdPreProduccion with (nolock) where 1 = " & Validador
        If IDReg <> "" Then SQL = SQL & " and ID = " & IDReg
        If ePedido.Text <> "" Then SQL = SQL & " And Pedido = '" & ePedido.Text & "'"
        If ePC.Text <> "" Then SQL = SQL & " And PC = '" & ePC.Text & "'"
        If eProducto.Text <> "" Then SQL = SQL & " And Producto like('%" & Replace(eProducto.Text, " ", "%") & "%')"
        If cbFechas.Checked = True Then
            SQL = SQL & " and FNecesidad between('" & FInicial.Text & "' and '" & fFinal.Text & "')"
        End If
        SQL = SQL & " )X1 )X2 )X3)X4 Order by FNecesidad "
        Dim CMD As New SqlCommand(SQL, Conexion01)

        daGrid.SelectCommand = CMD
        daGrid.Fill(dtGrid)
        Grid1.DataSource = dtGrid
    End Sub

    Private Sub PreProdFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SQL = "SELECT Parametro, Descripcion, Valor FROM CatParametros where parametro = 1 and valor like('%" & Usuario & "%')"
        Dim dtPermisoN As New DataTable
        Dim daPermisoN As New SqlDataAdapter
        If Conexion01.State = False Then Conexion01.Open()
        Dim cmdPermisoN As New SqlCommand(SQL, Conexion01)
        daPermisoN.SelectCommand = cmdPermisoN
        daPermisoN.Fill(dtPermisoN)
        If dtPermisoN.Rows.Count = 0 Then
            GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        Else
            GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
            Validador = "0"
            CargaRegistros("")
        End If
        ActivaPermisos()
    End Sub

    Private Sub ActivaPermisos()
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        Dim dtPerm As New DataTable
        Dim daPerm As New SqlDataAdapter
        SQL = "Select Valor2 from CatParametros with(nolock) where parametro between 2 and 39 and Valor like('%" & Usuario & "%')"
        Dim cmdPerm As New SqlCommand(SQL, Conexion01)
        daPerm.SelectCommand = cmdPerm
        daPerm.Fill(dtPerm)
        If dtPerm.Rows.Count = 0 Then Exit Sub
        For Cont = 1 To dtPerm.Rows.Count - 1
            GridView1.Columns(Cont).OptionsColumn.AllowEdit = True
            GridView1.Columns(Cont).OptionsColumn.ReadOnly = False
        Next
        GridView1.Columns(39).VisibleIndex = 6
    End Sub
    Private Sub PreProdFrm_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Exit Sub
        If GridView1.Focus Then
            Exit Sub
        End If
        If e.KeyChar = Chr(13) Then Tab(e)
    End Sub

    Private Sub cbFechas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbFechas.CheckedChanged
        FInicial.Enabled = Not (FInicial.Enabled)
        fFinal.Enabled = Not (fFinal.Enabled)
        If fFinal.Enabled = True Then
            FInicial.Focus()
        Else
            bBuscar.Focus()
            fFinal.Text = ""
            FInicial.Text = ""
        End If
    End Sub

    Private Sub bLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles bLimpiar.Click
        ePC.Text = ""
        ePedido.Text = ""
        eProducto.Text = ""
        cbFechas.Checked = False
        ePedido.Focus()
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        If cbFechas.Checked = True Then
            If FInicial.Text = "" Then
                MsgBox(Msj00047, MsgBoxStyle.Critical, Empresa & " MSJ00047")
                FInicial.Focus()
                Exit Sub
            End If
            If fFinal.Text = "" Then
                MsgBox(Msj00048, MsgBoxStyle.Critical, Empresa & " MSJ00048")
                fFinal.Focus()
                Exit Sub
            End If
        End If
        Validador = "1"
        CargaRegistros("")
        Dim IDrw = GridView1.SelectedRowsCount
        GridView1.SetRowCellValue(IDrw, 0, IDrw + 1)
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub GridView1_ShowingEditor(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
        '  e.Cancel = False

    End Sub

    Private Sub GridView1_ValidateRow(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow
        'Dim Row = DataGridViewRow = GridView1.SelectRow
        ''dim GridViewRow row = GridView1.SelectedRow;
        ''    TextBox1.Text = row.Cells[1].Text;
        ''    TextBox2.Text = row.Cells[2].Text;
        'Row = GridView1.SelectRow(0)
        ''        If e.Row(0).ToString = "" Then 'Registro nuevo
        Dim ID = ""
        If Not IsDBNull(GridView1.GetDataRow(GridView1.FocusedRowHandle).Item("ID")) Then
            ID = GridView1.GetDataRow(GridView1.FocusedRowHandle).Item("ID")
        End If

        If ID = "" Then
            '  If Row.Cells(0).ToString = "" Then 'Registro Nuevo

            ' SQLUp = ""
            'SQLVal = ""
            SQL = "Set Dateformat DMY Insert Into ProdPreProduccion(" & SQLUp & ") "
            SQL = SQL & "Select '" & SQLVal & "'"
            'MsgBox(SQLUp)
            'MsgBox(e.Row(0).ToString)
            'e.Row(0) = "13"

            Dim dtMax As New DataTable
            Dim dsMax As New SqlDataAdapter
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmdMax As New SqlCommand("Select Max(id)IdMax from ProdPreProduccion with(nolock)", Conexion01)
            Dim cmdIns As New SqlCommand(SQL, Conexion01)
            Try
                cmdIns.ExecuteNonQuery()
                dsMax.SelectCommand = cmdMax
                dsMax.Fill(dtMax)
                Validador = "1"
                CargaRegistros(dtMax(0)(0).ToString)
            Catch ex As Exception
                MsgBox(ex.Message & " " & Msj00049, MsgBoxStyle.Critical, Empresa & " MSJ00049")
                e.Valid = False
                Exit Sub
            End Try
            SQLUp = ""
            SQLVal = ""
            'e.Row(0) = dtMax(0)(0).ToString
        Else 'Actualizacion de registro
            SQLUp = "Set DateFormat DMY Update ProdPreProduccion Set " & SQLUp2
            ' Dim IDrw = GridView1.SelectedRowsCount
            ' GridView1.SetRowCellValue(IDrw, 0, IDrw + 1)

            SQLUp = SQLUp & " where id = " & ID
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmdUp As New SqlCommand(SQLUp, Conexion01)
            Try
                cmdUp.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message & " " & Msj00050, MsgBoxStyle.Critical, Empresa & " MSJ00050")
                e.Valid = False
                Exit Sub
            End Try
            'MsgBox(SQLUp)
            SQLUp = ""
            SQLUp2 = ""
            SQLVal = ""
            bBuscar_Click(sender, e)
        End If

        'e.Valid = False
    End Sub

    Private Sub GridView1_CellValueChanged(sender As System.Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If SQLUp = "" Then 'Cuando no hay registros anteriores
            SQLUp = "" & e.Column.Name
            SQLVal = e.Value
            SQLUp2 = "" & e.Column.Name & " = '" & e.Value & "'"
        Else ' Cuando ya hay registros anteriores
            SQLUp = SQLUp & ", " & e.Column.Name
            SQLVal = SQLVal & "', '" & e.Value
            SQLUp2 = SQLUp2 & ", " & e.Column.Name & " = '" & e.Value & "'"
        End If
    End Sub

    Private Sub GridView1_RowStyle(sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        'Dim View As DataGridView = sender
        If (e.RowHandle >= 0) Then
            ' Dim category As String = GridView1.GetDataRow(e.RowHandle).Item("FechaPT")
            'View.GetRowCellDisplayText(e.RowHandle, View.Columns("Category"))
            'If category = "Beverages" Then
            If IsDBNull(GridView1.GetDataRow(e.RowHandle).Item("FechaPT")) = True Then Exit Sub
            If IsDBNull(GridView1.GetDataRow(e.RowHandle).Item("FNecesidad")) Then Exit Sub

            If GridView1.GetDataRow(e.RowHandle).Item("FechaPT") > GridView1.GetDataRow(e.RowHandle).Item("FNecesidad") Then
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.SeaShell
            End If
        End If
    End Sub
End Class