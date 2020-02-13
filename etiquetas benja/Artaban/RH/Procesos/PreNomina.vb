Imports System.Data.SqlClient

Public Class PreNomina
    Dim Inicio = False
    Dim SQL = ""
    Dim vReadOnly = True
    Dim idRegNomina As Integer
    Dim Nuevo = False
    Dim TipoNomina = ""
    Private Sub PreNomina_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        'SQL = "select [i-empl_num] IDEmp, [c-empl_app] + ' ' +  [c-empl_apm] + ' ' + [c-empl_nom]  Empleado  from  [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock) " & _
        '    " where  [c-comp_clv] = 1  "
        SQL = "  select [i-empl_num] IDEmp, [c-empl_app] + ' ' +  [c-empl_apm] + ' ' + [c-empl_nom]  Empleado  " & _
            "  from  [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock)  " & _
            "     where  [c-comp_clv] = 1 and [c-empl_sts] = 'ACTIVO' " & _
            "  union  " & _
            "	select [i-empl_num] IDEmp, [c-empl_app] + ' ' +  [c-empl_apm] + ' ' + [c-empl_nom]  Empleado from  [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock)   " & _
            "    where  [c-comp_clv] = 11 and [c-empl_sts] = 'ACTIVO'  " & _
            "	and substring([c-empl_rfc],1,9) not in (Select substring([c-empl_rfc],1,9) from  [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock)   " & _
            "    where  [c-comp_clv] = 1 and [c-empl_sts] = 'ACTIVO')  " & _
            "	and [c-empl_cur] not in (Select [c-empl_cur] from  [LYRA].[LYGRAL].[PUB].[empl_mstr] Emp with(nolock)   " & _
            "    where  [c-comp_clv] = 1 and [c-empl_sts] = 'ACTIVO') "
        CargaCombo(cbEmpleado, SQL, "IDEmp", "Empleado")
        cbEjercicio.Value = Now.Year
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
        cbPeriodo.Value = dsCod.Rows(0)("NoSemana")
        Inicio = True
        vReadOnly = False
        CargaPeriodo()
    End Sub

    Private Sub cbEjercicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles cbEjercicio.ValueChanged, cbPeriodo.ValueChanged
        CargaPeriodo()
        If cbEmpleado.Text <> "" Then CargaNominaEmp()
    End Sub

    Private Sub CargaPeriodo()
        vReadOnly = True
        If Inicio = False Then Exit Sub
        SQL = "SELECT idRegNomina, Ejercicio, NoSemana, Estatus, convert(varchar(10), FechaI, 103) as FechaI, convert(varchar(10), FechaF , 103) as FechaF FROM PreNominaHDr with(nolock) " & _
            " where Ejercicio = " & cbEjercicio.Value.ToString & " and NoSemana = " & cbPeriodo.Value.ToString
        Dim dsCod As New DataTable
        Dim daCod As New SqlDataAdapter
        Dim cmdCod As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daCod.SelectCommand = cmdCod
        daCod.Fill(dsCod)
        If dsCod.Rows.Count = 0 Then
            MsgBox("Periodo de Nomina no establecido, favor de verificar con el Administrador del Sistema.")
            Exit Sub
        End If
        If dsCod.Rows(0)("Estatus").ToString = "1" Then vReadOnly = False
        lPeriodo.Text = "Del " & dsCod.Rows(0)("FechaI").ToString & " al " & dsCod.Rows(0)("FechaF").ToString
        idRegNomina = dsCod.Rows(0)("idRegNomina")
    End Sub

    Private Sub PreNomina_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub CargaPren(Ventana As Form)
        Try

            Ventana.Icon = Me.Icon
            Ventana.MdiParent = Me
            Ventana.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            'ventana.TopLevel = False
            'ventana.Show()
            Ventana.TopLevel = False
            Ventana.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Ventana.Dock = DockStyle.Fill
            pGral.Controls.Clear()
            pGral.Controls.Add(Ventana)
            Ventana.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CargaNominaEmp()
        If cbEmpleado.Text = "[Vacío]" Then
            Exit Sub
        End If
        SQL = "SELECT        idRegNomina, NoEmpleado, idPuesto, Clave, Valor, D1A, D1B, D1C, D2A, D2B, D2C, D3A, D3B, D3C, D4A, D4B, D4C, D5A, D5B, D5C, D6A, D6B, D6C, D7A, D7B, D7C FROM PreNominaDtl with(nolock) " & _
            " where idRegNomina = " & idRegNomina.ToString & " and NoEmpleado = " & cbEmpleado.EditValue.ToString
        Dim dtNom As New DataTable
        Dim daNom As New SqlDataAdapter
        Dim cmdNom As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daNom.SelectCommand = cmdNom
        daNom.Fill(dtNom)
        If dtNom.Rows.Count = 0 Then
            Nuevo = True 
            pGral.Controls.Clear() 
            cbTipoNom.Enabled = Nuevo
            bReasignar.Enabled = Not Nuevo
            If cbTipoNom.Text = "" Then
                MsgBox("Favor de Seleccionar el tipo de prenómina")
                cbTipoNom.Focus()
                Exit Sub
            End If
            Select Case cbTipoNom.Text
                Case "Ayudantes Generales" '1
                    Dim Ventana As New PreNomAyuGral01
                    Ventana.bGuardar.Enabled = Not vReadOnly
                    Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                    Ventana.idRegNomina = idRegNomina
                    CargaPren(Ventana)
                Case "Armado y Pegado" '2
                    Dim Ventana As New PreNomPegado01
                    Ventana.bGuardar.Enabled = Not vReadOnly
                    Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                    Ventana.idRegNomina = idRegNomina
                    CargaPren(Ventana)
                Case "Costura" '3
                    Dim Ventana As New PreNomCostura01
                    Ventana.bGuardar.Enabled = Not vReadOnly
                    Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                    Ventana.idRegNomina = idRegNomina
                    CargaPren(Ventana)
                Case "Línea DOSS" '4
                    Dim Ventana As New PreNomLDoss01
                    Ventana.bGuardar.Enabled = Not vReadOnly
                    Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                    Ventana.idRegNomina = idRegNomina
                    CargaPren(Ventana)
                Case "Bases" '5
                    Dim Ventana As New PreNomBas01
                    Ventana.bGuardar.Enabled = Not vReadOnly
                    Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                    Ventana.idRegNomina = idRegNomina
                    CargaPren(Ventana)
                Case "Almacen PT y Embarques" '6  
                    Dim Ventana As New PreNomAlm01
                    Ventana.bGuardar.Enabled = Not vReadOnly
                    Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                    Ventana.idRegNomina = idRegNomina
                    CargaPren(Ventana)
                Case "Ensamble Final" '7
                    cbTipoNom.Text = "Ensamble Final"
                    Dim Ventana As New PreNomArm01
                    Ventana.bGuardar.Enabled = Not vReadOnly
                    Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                    Ventana.idRegNomina = idRegNomina
                    CargaPren(Ventana)

                Case Else
                    pGral.Controls.Clear()
                    Exit Sub
            End Select
            Exit Sub
        End If
        'Prenomina ya con registros
        'For x = 0 To dtNom.Rows.Count - 1
        pGral.Controls.Clear()
        Select Case dtNom.Rows(0)("idPuesto")
            Case 1 ' Ayudantes Generales
                cbTipoNom.Text = "Ayudantes Generales"
                Dim Ventana As New PreNomAyuGral01
                Ventana.bGuardar.Enabled = Not vReadOnly
                Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                Ventana.idRegNomina = idRegNomina
                Ventana.Nuevo = False
                CargaPren(Ventana)
            Case 2 ' Armado y Pegado
                cbTipoNom.Text = "Armado y Pegado"
                Dim Ventana As New PreNomPegado01
                Ventana.bGuardar.Enabled = Not vReadOnly
                Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                Ventana.idRegNomina = idRegNomina
                Ventana.Nuevo = False
                CargaPren(Ventana)
            Case 3 'Costura
                cbTipoNom.Text = "Costura"
                Dim Ventana As New PreNomCostura01
                Ventana.bGuardar.Enabled = Not vReadOnly
                Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                Ventana.idRegNomina = idRegNomina
                CargaPren(Ventana)
            Case 4 'Linea DOSS
                cbTipoNom.Text = "Línea DOSS"
                Dim Ventana As New PreNomLDoss01
                Ventana.bGuardar.Enabled = Not vReadOnly
                Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                Ventana.idRegNomina = idRegNomina
                CargaPren(Ventana)
            Case 5 'Bases Generales
                cbTipoNom.Text = "Bases"
                Dim Ventana As New PreNomBas01
                Ventana.bGuardar.Enabled = Not vReadOnly
                Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                Ventana.idRegNomina = idRegNomina
                CargaPren(Ventana)
            Case 6 'Almacen PT y Embarques
                cbTipoNom.Text = "Almacen PT y Embarques"
                Dim Ventana As New PreNomAlm01
                Ventana.bGuardar.Enabled = Not vReadOnly
                Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                Ventana.idRegNomina = idRegNomina
                CargaPren(Ventana)
            Case 7 'Ensamble Final
                cbTipoNom.Text = "Ensamble Final"
                Dim Ventana As New PreNomArm01
                Ventana.bGuardar.Enabled = Not vReadOnly
                Ventana.NoEmpleado = cbEmpleado.EditValue.ToString
                Ventana.idRegNomina = idRegNomina
                CargaPren(Ventana)

            Case Else
                Exit Sub
        End Select
        'Next
        Nuevo = False
        cbTipoNom.Enabled = Nuevo
        bReasignar.Enabled = Not Nuevo
        TipoNomina = dtNom.Rows(0)("idPuesto")
    End Sub

    Private Sub cbEmpleado_EditValueChanged(sender As System.Object, e As System.EventArgs) 'Handles cbEmpleado.EditValueChanged
        CargaNominaEmp()
    End Sub

    Private Sub cbTipoNom_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) 'Handles cbTipoNom.SelectedIndexChanged
        CargaNominaEmp()
    End Sub

    Private Sub bBuscar_Click(sender As System.Object, e As System.EventArgs) Handles bBuscar.Click
        CargaNominaEmp()
    End Sub

    Private Sub cbEmpleado_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cbEmpleado.KeyPress
        If e.KeyChar = Chr(13) Then
            CargaNominaEmp()
        End If
    End Sub

    Private Sub bReasignar_Click(sender As System.Object, e As System.EventArgs) Handles bReasignar.Click
        If MsgBox("¿Desea reasignar al operador de la prenomina? se eliminaran los registros almacenados.", vbYesNo) = MsgBoxResult.Yes Then
            Dim SQLUp = "delete PreNominaDtl where idRegNomina = " & idRegNomina.ToString & " and NoEmpleado = " & cbEmpleado.EditValue.ToString
            Dim Transac As SqlTransaction
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Transac = Conexion01.BeginTransaction
            Try
                If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                Dim cmd As New SqlCommand(SQLUp, Conexion01)
                cmd.Transaction = Transac
                cmd.ExecuteNonQuery()
                Transac.Commit()
                If Nuevo = True Then Nuevo = False
                CargaNominaEmp()
                MsgBox("Registro libreado con exito.")
            Catch ex As Exception
                Transac.Rollback()
                MsgBox(" Ocurrio un error al gardar la información" + ex.Message, MsgBoxStyle.Critical, Empresa & "")
                Exit Sub
            End Try
        End If
    End Sub
End Class