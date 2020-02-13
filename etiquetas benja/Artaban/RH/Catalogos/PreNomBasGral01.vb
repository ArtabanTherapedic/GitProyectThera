Imports System.Data.SqlClient

Public Class PreNomBasGral01
    Public ValorA = 0.0
    Public ValorB = 0.0
    Public Suma = 0
    Public Tot = 0
    Public idRegNomina = ""
    Public NoEmpleado = ""
    Public Nuevo = True
    Const IDTipo = 1
    Public Calcula = False
    Private Sub COMP_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles COMP.EditValueChanged, AIMPORTE.EditValueChanged, BIMPORTE.EditValueChanged
        If Calcula = False Then Exit Sub
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If IsNothing(AIMPORTE.EditValue) Then AIMPORTE.EditValue = 0
        If IsNothing(BIMPORTE.EditValue) Then BIMPORTE.EditValue = 0
        'Exit Sub
        If CStr(AIMPORTE.EditValue) = "" Then AIMPORTE.EditValue = 0
        If CStr(BIMPORTE.EditValue) = "" Then BIMPORTE.EditValue = 0
        If CStr(COMP.EditValue) = "" Then COMP.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue)
    End Sub

    Private Sub PreNomAyuGral01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ValorA = 0
        ValorB = 0
        Suma = 0
        Tot = 0
        Dim sql = "SELECT CLAVE, VALOR  FROM PreNominaClv  where clave in ( 'HN', 'HE') ORDER BY CLAVE"
        Dim dtNom As New DataTable
        Dim daNom As New SqlDataAdapter
        Dim cmdNom As New SqlCommand(sql, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daNom.SelectCommand = cmdNom
        daNom.Fill(dtNom)
        If dtNom.Rows.Count = 0 Then
            MsgBox("Ocurrio un error al obtener la informacion de claves, favor de verificar con el administrador del sistema.")
            Me.Close()
            Exit Sub
        End If
        ValorB = dtNom.Rows(0)("VALOR")
        ValorA = dtNom.Rows(1)("VALOR")
        sql = "SELECT idRegNomina, NoEmpleado, idPuesto, Clave, Valor, D1A, D1B, D1C, D2A, D2B, D2C, D3A, D3B, D3C, D4A, D4B, D4C, D5A, D5B, D5C, D6A, D6B, D6C, D7A, D7B, D7C, OBS" & _
            " FROM PreNominaDtl WITH (nolock) where idRegNomina = " & idRegNomina & " and noEmpleado = '" & NoEmpleado & "'"
        Dim dtPre As New DataTable
        Dim daPre As New SqlDataAdapter
        Dim cmdPre As New SqlCommand(sql, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daPre.SelectCommand = cmdPre
        daPre.Fill(dtPre)
        AD1A.EditValue = 0
        AD2A.EditValue = 0
        AD3A.EditValue = 0
        AD4A.EditValue = 0
        AD5A.EditValue = 0
        AD6A.EditValue = 0
        BD1A.EditValue = 0
        BD2A.EditValue = 0
        BD3A.EditValue = 0
        BD4A.EditValue = 0
        BD5A.EditValue = 0
        BD6A.EditValue = 0
        CD1A.EditValue = 0
        CD2A.EditValue = 0
        CD3A.EditValue = 0
        CD4A.EditValue = 0
        CD5A.EditValue = 0
        CD6A.EditValue = 0
        DD1A.EditValue = 0
        DD2A.EditValue = 0
        DD3A.EditValue = 0
        DD4A.EditValue = 0
        DD5A.EditValue = 0
        DD6A.EditValue = 0
        ADIAS.EditValue = 0
        BDIAS.EditValue = 0
        'ACLV.EditValue = 0
        'BCLV.EditValue = 0
        AIMPORTE.EditValue = 0
        BIMPORTE.EditValue = 0
        eTotal.EditValue = 0
        COMP.EditValue = 0
        If dtPre.Rows.Count > 0 Then
            Nuevo = False
            Dim cont = 0
            For cont = 0 To dtPre.Rows.Count - 1
                Select Case dtPre.Rows(cont)("Clave")
                    Case "HN"
                        ACLV.EditValue = dtPre.Rows(cont)("Clave")
                        ValorA = dtPre.Rows(cont)("Valor")
                        AD1A.EditValue = dtPre.Rows(cont)("D1A")
                        AD2A.EditValue = dtPre.Rows(cont)("D2A")
                        AD3A.EditValue = dtPre.Rows(cont)("D3A")
                        AD4A.EditValue = dtPre.Rows(cont)("D4A")
                        AD5A.EditValue = dtPre.Rows(cont)("D5A")
                        AD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HE"
                        BCLV.EditValue = dtPre.Rows(cont)("Clave")
                        ValorB = dtPre.Rows(cont)("Valor")
                        BD1A.EditValue = dtPre.Rows(cont)("D1A")
                        BD2A.EditValue = dtPre.Rows(cont)("D2A")
                        BD3A.EditValue = dtPre.Rows(cont)("D3A")
                        BD4A.EditValue = dtPre.Rows(cont)("D4A")
                        BD5A.EditValue = dtPre.Rows(cont)("D5A")
                        BD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "01"
                        CD1A.EditValue = dtPre.Rows(cont)("D1A")
                        CD2A.EditValue = dtPre.Rows(cont)("D2A")
                        CD3A.EditValue = dtPre.Rows(cont)("D3A")
                        CD4A.EditValue = dtPre.Rows(cont)("D4A")
                        CD5A.EditValue = dtPre.Rows(cont)("D5A")
                        CD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "02"
                        DD1A.EditValue = dtPre.Rows(cont)("D1A")
                        DD2A.EditValue = dtPre.Rows(cont)("D2A")
                        DD3A.EditValue = dtPre.Rows(cont)("D3A")
                        DD4A.EditValue = dtPre.Rows(cont)("D4A")
                        DD5A.EditValue = dtPre.Rows(cont)("D5A")
                        DD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "00"
                        COMP.EditValue = dtPre.Rows(cont)("Valor")
                        eObs.Text = dtPre.Rows(cont)("OBS")
                End Select
            Next
        End If

        Calcula = True
        CalculaA()
        CalculaB()
        CalculaC()
        CalculaD()
    End Sub

    Public Sub CalculaA()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(AD1A.EditValue) Then
            If AD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD1A.EditValue
            End If
        End If
        If Not IsNothing(AD2A.EditValue) Then
            If AD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD2A.EditValue
            End If
        End If
        If Not IsNothing(AD3A.EditValue) Then
            If AD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD3A.EditValue
            End If
        End If
        If Not IsNothing(AD4A.EditValue) Then
            If AD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD4A.EditValue
            End If
        End If
        If Not IsNothing(AD5A.EditValue) Then
            If AD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD5A.EditValue
            End If
        End If
        If Not IsNothing(AD6A.EditValue) Then
            If AD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD6A.EditValue
            End If
        End If
        ADIAS.EditValue = Suma
        ATOT.EditValue = Tot
        AIMPORTE.EditValue = CDbl(ValorA * Tot)
    End Sub

    Private Sub CD1A_EditValueChanged(Sender As System.Object, e As System.EventArgs) Handles CD1A.EditValueChanged, CD2A.EditValueChanged, CD3A.EditValueChanged, CD4A.EditValueChanged, CD5A.EditValueChanged, CD6A.EditValueChanged
        CalculaC()
    End Sub

    Private Sub DD1A_EditValueChanged(Sender As System.Object, e As System.EventArgs) Handles DD1A.EditValueChanged, DD2A.EditValueChanged, DD3A.EditValueChanged, DD4A.EditValueChanged, DD5A.EditValueChanged, DD6A.EditValueChanged
        CalculaD()
    End Sub


    Private Sub CalculaD()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(DD1A.EditValue) Then
            If DD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + DD1A.EditValue
            End If
        End If
        If Not IsNothing(DD2A.EditValue) Then
            If DD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + DD2A.EditValue
            End If
        End If
        If Not IsNothing(DD3A.EditValue) Then
            If DD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + DD3A.EditValue
            End If
        End If
        If Not IsNothing(DD4A.EditValue) Then
            If DD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + DD4A.EditValue
            End If
        End If
        If Not IsNothing(DD5A.EditValue) Then
            If DD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + DD5A.EditValue
            End If
        End If
        If Not IsNothing(DD6A.EditValue) Then
            If DD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + DD6A.EditValue
            End If
        End If
        If Tot > 0 Then COMP.EditValue = Tot
    End Sub

    Private Sub CalculaC()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(CD1A.EditValue) Then
            If CD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD1A.EditValue
            End If
        End If
        If Not IsNothing(CD2A.EditValue) Then
            If CD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD2A.EditValue
            End If
        End If
        If Not IsNothing(CD3A.EditValue) Then
            If CD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD3A.EditValue
            End If
        End If
        If Not IsNothing(CD4A.EditValue) Then
            If CD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD4A.EditValue
            End If
        End If
        If Not IsNothing(CD5A.EditValue) Then
            If CD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD5A.EditValue
            End If
        End If
        If Not IsNothing(CD6A.EditValue) Then
            If CD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD6A.EditValue
            End If
        End If
        If Tot > 0 Then COMP.EditValue = Tot * 2.5
    End Sub
    Private Sub AD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AD1A.EditValueChanged, AD2A.EditValueChanged, AD3A.EditValueChanged, AD4A.EditValueChanged, AD5A.EditValueChanged, AD6A.EditValueChanged
        CalculaA()
    End Sub

    Public Sub CalculaB()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(BD1A.EditValue) Then
            If BD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD1A.EditValue
            End If
        End If
        If Not IsNothing(BD2A.EditValue) Then
            If BD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD2A.EditValue
            End If
        End If
        If Not IsNothing(BD3A.EditValue) Then
            If BD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD3A.EditValue
            End If
        End If
        If Not IsNothing(BD4A.EditValue) Then
            If BD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD4A.EditValue
            End If
        End If
        If Not IsNothing(BD5A.EditValue) Then
            If BD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD5A.EditValue
            End If
        End If
        If Not IsNothing(BD6A.EditValue) Then
            If BD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD6A.EditValue
            End If
        End If
        BDIAS.EditValue = Suma
        BTOT.EditValue = Tot
        BIMPORTE.EditValue = CDbl(ValorB * Tot)
    End Sub

    Private Sub BD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles BD1A.EditValueChanged, BD2A.EditValueChanged, BD3A.EditValueChanged, BD4A.EditValueChanged, BD5A.EditValueChanged, BD6A.EditValueChanged
        CalculaB()
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        Dim SQLUP
        If Nuevo = True Then
            SQLUP = "Insert into PreNominaDtl " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HN', " & ValorA.ToString & ", " & AD1A.EditValue.ToString & ", 0, 0, " & _
                AD2A.EditValue.ToString & ", 0, 0, " & AD3A.EditValue.ToString & ", 0, 0, " & AD4A.EditValue.ToString & _
                ", 0, 0, " & AD5A.EditValue.ToString & ", 0, 0, " & AD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HE', " & ValorB.ToString & ", " & BD1A.EditValue.ToString & ", 0, 0, " & _
                BD2A.EditValue.ToString & ", 0, 0, " & BD3A.EditValue.ToString & ", 0, 0, " & BD4A.EditValue.ToString & _
                ", 0, 0, " & BD5A.EditValue.ToString & ", 0, 0, " & BD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '01', 0, " & CD1A.EditValue.ToString & ", 0, 0, " & _
                CD2A.EditValue.ToString & ", 0, 0, " & CD3A.EditValue.ToString & ", 0, 0, " & CD4A.EditValue.ToString & _
                ", 0, 0, " & CD5A.EditValue.ToString & ", 0, 0, " & CD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '02', 0, " & DD1A.EditValue.ToString & ", 0, 0, " & _
                DD2A.EditValue.ToString & ", 0, 0, " & DD3A.EditValue.ToString & ", 0, 0, " & DD4A.EditValue.ToString & _
                ", 0, 0, " & DD5A.EditValue.ToString & ", 0, 0, " & DD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '00', " & COMP.EditValue & ", 0, 0, 0, 0, 0, 0, 0, 0, 0, " & _
                "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '" & eObs.Text & "' "
        Else
            SQLUP = " update PreNominaDtl set " & _
                " D1A = " & AD1A.EditValue.ToString & ", D2A = " & AD2A.EditValue.ToString & ", D3A = " & AD3A.EditValue.ToString & _
                ", D4A = " & AD4A.EditValue.ToString & ", D5A = " & AD5A.EditValue.ToString & ", D6A = " & AD6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & BD1A.EditValue.ToString & ", D2A = " & BD2A.EditValue.ToString & ", D3A = " & BD3A.EditValue.ToString & _
                ", D4A = " & BD4A.EditValue.ToString & ", D5A = " & BD5A.EditValue.ToString & ", D6A = " & BD6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HE' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & CD1A.EditValue.ToString & ", D2A = " & CD2A.EditValue.ToString & ", D3A = " & CD3A.EditValue.ToString & _
                ", D4A = " & CD4A.EditValue.ToString & ", D5A = " & CD5A.EditValue.ToString & ", D6A = " & CD6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '01' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & DD1A.EditValue.ToString & ", D2A = " & DD2A.EditValue.ToString & ", D3A = " & DD3A.EditValue.ToString & _
                ", D4A = " & DD4A.EditValue.ToString & ", D5A = " & DD5A.EditValue.ToString & ", D6A = " & DD6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '02' " & _
                "  " & _
                " update PreNominaDtl set Valor = " & COMP.EditValue.ToString & ", OBS = '" & eObs.Text & "' " & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '00' "
        End If
        Dim Transac As SqlTransaction
        Transac = Conexion01.BeginTransaction
        Try
            If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
            Dim cmd As New SqlCommand(SQLUP, Conexion01)
            cmd.Transaction = Transac
            cmd.ExecuteNonQuery()
            Transac.Commit()
            If Nuevo = True Then Nuevo = False
            MsgBox("Registro Guardado con éxito.")
        Catch ex As Exception
            Transac.Rollback()
            MsgBox(" Ocurrio un error al gardar la información" + ex.Message, MsgBoxStyle.Critical, Empresa & "")
            Exit Sub
        End Try
    End Sub

    Private Sub ACLV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ACLV.DoubleClick
        Calcula = False
        AD1A.EditValue = 8
        AD2A.EditValue = 8
        AD3A.EditValue = 8
        AD4A.EditValue = 8
        AD5A.EditValue = 8
        AD6A.EditValue = 8
        Calcula = True
        CalculaA()
    End Sub
End Class