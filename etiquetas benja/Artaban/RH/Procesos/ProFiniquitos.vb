
Imports System.Data.SqlClient
Imports System.IO

Public Class ProFiniquitos
    Dim SQL As String = ""
    Dim dsCombos As New DataTable
    Dim daCombos As New SqlDataAdapter
    Private Sub CatComposiciones_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'CargaComposiciones()
        CargaCatalogo()
    End Sub

    Private Sub CargaCatalogo()
        SQL = "Select distinct Prom.NoEmp NoPromotor, Empleado as Promotor from catrhpromotores Prom with(nolock) " & _
            " inner join catrhsupervisores Sub with(nolock) on Prom.NoSupervisor = case when sub.SU = 1 then PRom.NoSupervisor else Sub.NoEmp end " & _
            " inner join v_CatEmpLyraProm Emp with(nolock) on prom.noemp = emp.IDEmp " & _
            " where usuario = '" & Usuario & "' and prom.estatus = 1  and emp.estatus <> 'BAJA' order by prom.noemp  "
        Dim CMD As New SqlCommand(SQL, Conexion01)
        If Conexion01.State = False Then Conexion01.Open()
        daCombos.SelectCommand = CMD
        daCombos.Fill(dsCombos)
        gCatalogo.DataSource = dsCombos
    End Sub

    Private Sub CatComposiciones_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Tab(e)
    End Sub

    Private Sub CatComposiciones_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub LookUpComp_EditValueChanged(sender As System.Object, e As System.EventArgs)
        eAbreviacion.Text = LookUpComp.EditValue
        'dsCombos.row()
        eDesc.Text = LookUpComp.Properties.Columns(2).ToString
        eObs.Text = LookUpComp.Properties.Columns(3).ToString
    End Sub

    Private Sub bSalir_Click(sender As System.Object, e As System.EventArgs) Handles bSalir.Click
        Me.Close()
    End Sub

    Private Sub bNuevo_Click(sender As System.Object, e As System.EventArgs) Handles bImpContrato.Click
        'If GridView1.SelectedRowsCount <> 1 Then
        '    bImprimir.Enabled = True
        '    tClic.Enabled = False
        '    Exit Sub
        'End If

        Dim seleccionados As Integer() = Me.GridView1.GetSelectedRows
        If seleccionados.Length > 0 Then

            Dim rowsSeleccionados As DataRow 
            For Each row As Integer In seleccionados
                rowsSeleccionados = Me.GridView1.GetDataRow(row) 

                If File.Exists("\\192.168.1.251\Reportes\Contratos\" & rowsSeleccionados(0).ToString & ".pdf") Then
                    Process.Start("\\192.168.1.251\Reportes\Contratos\" & rowsSeleccionados(0).ToString & ".pdf")
                    Exit Sub
                Else
                    Dim sql = " SELECT   Prom.Paterno,  Prom.Materno, Prom.Nombre, ((Sueldo/7.0)*30.4) as Sueldo, " & _
                        " therapedic.dbo.CantidadConLetra(((Sueldo/7.0)*30.4))SueldoLetra, FechaAlta, usuarios.nombre as Testigo" & _
                        " FROM therapedic.dbo.PreRegPromotoria Prom " & _
                        " inner join therapedic.dbo.catUsuarios Usuarios on prom.UsuAlta = usuarios.idusuario " & _
                        " where idPreRegProm = " & rowsSeleccionados(0).ToString

ImprimeContrato:
                    Dim Reporte As New RepContratoPromotoria
                    'ImprimeCR("", sql, Reporte, 2, Nothing, False)
                    PreviewCR(sql, Reporte)

                End If

            Next
        End If
    End Sub

    Private Sub bSend_Click(sender As System.Object, e As System.EventArgs) Handles bSend.Click
        Dim Destinatario As String
        Destinatario = InputBox("Favor de indicar el Correo del destinatario: ")
        If Destinatario <> "" Then
            Dim seleccionados As Integer() = Me.GridView1.GetSelectedRows
            If seleccionados.Length > 0 Then
                Dim rowsSeleccionados As DataRow
                Dim File = ""
                For Each row As Integer In seleccionados
                    rowsSeleccionados = Me.GridView1.GetDataRow(row)
                    Dim sqlEnvio = "Insert into logEnvioAdjuntos " & _
                        " Select 1, 'SELECT   Prom.Paterno,  Prom.Materno, Prom.Nombre, ((Sueldo/7.0)*30.4) as Sueldo,  therapedic.dbo.CantidadConLetra(((Sueldo/7.0)*30.4))SueldoLetra, FechaAlta, usuarios.nombre as Testigo FROM therapedic.dbo.PreRegPromotoria Prom inner join therapedic.dbo.catUsuarios Usuarios on prom.UsuAlta = usuarios.idusuario  where idPreRegProm = " & rowsSeleccionados(0).ToString & " ', " & _
                        rowsSeleccionados(0).ToString & ", '" & Usuario & "', getdate(), '" & Destinatario & "', '', NULL"
                    Dim CmdEnvio As New SqlCommand(sqlEnvio, Conexion01)
                    CmdEnvio.ExecuteNonQuery()
                    MsgBox("El contrato fue enviado a " & Destinatario)
                Next
            End If
        End If
    End Sub
End Class