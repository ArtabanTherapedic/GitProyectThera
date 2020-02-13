Imports System.Data.SqlClient

Public Class PreNomLDoss01
    Public ValorA = 0.0
    Public ValorB = 0.0
    Public ValorE = 0.0
    Public ValorF = 0.0
    Public Suma = 0
    Public Tot = 0
    Public idRegNomina = ""
    Public NoEmpleado = ""
    Public Nuevo = True
    Const IDTipo = 4
    Public Calcula = False
    Private Sub COMP_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles COMP.EditValueChanged, AIMPORTE.EditValueChanged, BIMPORTE.EditValueChanged
        If Calcula = False Then Exit Sub
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If IsNothing(AIMPORTE.EditValue) Then AIMPORTE.EditValue = 0
        If IsNothing(BIMPORTE.EditValue) Then BIMPORTE.EditValue = 0
        'Exit Sub
        If CStr(AIMPORTE.EditValue) = "" Then AIMPORTE.EditValue = 0
        If CStr(BIMPORTE.EditValue) = "" Then BIMPORTE.EditValue = 0

        If CStr(EIMPORTE.EditValue) = "" Then EIMPORTE.EditValue = 0
        If CStr(FIMPORTE.EditValue) = "" Then FIMPORTE.EditValue = 0

        If CStr(COMP.EditValue) = "" Then COMP.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue)
    End Sub

    Private Sub PreNomAyuGral01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ValorA = 0
        ValorB = 0
        ValorE = 0
        ValorF = 0
        Suma = 0
        Tot = 0
        Dim sql = "SELECT CLAVE, VALOR  FROM PreNominaClv  where clave in ( 'HN', 'HE', 'HN1', 'HE1') ORDER BY CLAVE"
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
        ValorE = dtNom.Rows(1)("VALOR")
        ValorA = dtNom.Rows(2)("VALOR")
        ValorF = dtNom.Rows(3)("VALOR")
        sql = "SELECT idRegNomina, NoEmpleado, idPuesto, Clave, Valor, D1A, D1B, D1C, D2A, D2B, D2C, D3A, D3B, D3C, D4A, D4B, D4C, D5A, D5B, D5C, D6A, D6B, D6C, D7A, D7B, D7C, OBS " & _
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

        ED1A.EditValue = 0
        ED2A.EditValue = 0
        ED3A.EditValue = 0
        ED4A.EditValue = 0
        ED5A.EditValue = 0
        ED6A.EditValue = 0

        FD1A.EditValue = 0
        FD2A.EditValue = 0
        FD3A.EditValue = 0
        FD4A.EditValue = 0
        FD5A.EditValue = 0
        FD6A.EditValue = 0

        ADIAS.EditValue = 0
        BDIAS.EditValue = 0
        ACLV.EditValue = dtNom.Rows(2)("CLAVE")
        BCLV.EditValue = dtNom.Rows(0)("CLAVE")
        AIMPORTE.EditValue = 0
        BIMPORTE.EditValue = 0

        EDIAS.EditValue = 0
        FDIAS.EditValue = 0
        ECLV.EditValue = dtNom.Rows(1)("CLAVE")
        FCLV.EditValue = dtNom.Rows(3)("CLAVE")

        EDIAS.EditValue = 0
        EIMPORTE.EditValue = 0
        FIMPORTE.EditValue = 0

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
                    Case "HN1"
                        ECLV.EditValue = dtPre.Rows(cont)("Clave")
                        ValorE = dtPre.Rows(cont)("Valor")
                        ED1A.EditValue = dtPre.Rows(cont)("D1A")
                        ED2A.EditValue = dtPre.Rows(cont)("D2A")
                        ED3A.EditValue = dtPre.Rows(cont)("D3A")
                        ED4A.EditValue = dtPre.Rows(cont)("D4A")
                        ED5A.EditValue = dtPre.Rows(cont)("D5A")
                        ED6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HE1"
                        FCLV.EditValue = dtPre.Rows(cont)("Clave")
                        ValorF = dtPre.Rows(cont)("Valor")
                        FD1A.EditValue = dtPre.Rows(cont)("D1A")
                        FD2A.EditValue = dtPre.Rows(cont)("D2A")
                        FD3A.EditValue = dtPre.Rows(cont)("D3A")
                        FD4A.EditValue = dtPre.Rows(cont)("D4A")
                        FD5A.EditValue = dtPre.Rows(cont)("D5A")
                        FD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "00"
                        COMP.EditValue = dtPre.Rows(cont)("Valor")
                End Select
            Next
            Calcula = True
            CalculaA()
            CalculaB()
            CalculaC()
            CalculaD()
            CalculaE()
            CalculaF()
        End If
        Calcula = True
    End Sub

    Public Sub CalculaA()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(AD1A.EditValue) Then
            If Not IsNumeric(AD1A.EditValue) Then AD1A.EditValue = 0
            If AD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD1A.EditValue
            End If
        End If
        If Not IsNothing(AD2A.EditValue) Then
            If Not IsNumeric(AD2A.EditValue) Then AD2A.EditValue = 0
            If AD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD2A.EditValue
            End If
        End If
        If Not IsNothing(AD3A.EditValue) Then
            If Not IsNumeric(AD3A.EditValue) Then AD3A.EditValue = 0
            If AD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD3A.EditValue
            End If
        End If
        If Not IsNothing(AD4A.EditValue) Then
            If Not IsNumeric(AD4A.EditValue) Then AD4A.EditValue = 0
            If AD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD4A.EditValue
            End If
        End If
        If Not IsNothing(AD5A.EditValue) Then
            If Not IsNumeric(AD5A.EditValue) Then AD5A.EditValue = 0
            If AD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD5A.EditValue
            End If
        End If
        If Not IsNothing(AD6A.EditValue) Then
            If Not IsNumeric(AD6A.EditValue) Then AD6A.EditValue = 0
            If AD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD6A.EditValue
            End If
        End If
        ADIAS.EditValue = Suma
        ATOT.EditValue = Tot
        AIMPORTE.EditValue = CDbl(ValorA * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue)
    End Sub

    Public Sub CalculaE()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(ED1A.EditValue) Then
            If Not IsNumeric(ED1A.EditValue) Then ED1A.EditValue = 0
            If ED1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ED1A.EditValue
            End If
        End If
        If Not IsNothing(ED2A.EditValue) Then
            If Not IsNumeric(ED2A.EditValue) Then ED2A.EditValue = 0
            If ED2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ED2A.EditValue
            End If
        End If
        If Not IsNothing(ED3A.EditValue) Then
            If Not IsNumeric(ED3A.EditValue) Then ED3A.EditValue = 0
            If ED3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ED3A.EditValue
            End If
        End If
        If Not IsNothing(ED4A.EditValue) Then
            If Not IsNumeric(ED4A.EditValue) Then ED4A.EditValue = 0
            If ED4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ED4A.EditValue
            End If
        End If
        If Not IsNothing(ED5A.EditValue) Then
            If Not IsNumeric(ED5A.EditValue) Then ED5A.EditValue = 0
            If ED5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ED5A.EditValue
            End If
        End If
        If Not IsNothing(ED6A.EditValue) Then
            If Not IsNumeric(ED6A.EditValue) Then ED6A.EditValue = 0
            If ED6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ED6A.EditValue
            End If
        End If
        EDIAS.EditValue = Suma
        ETOT.EditValue = Tot
        EIMPORTE.EditValue = CDbl(ValorE * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue)
    End Sub

    Public Sub CalculaF()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(FD1A.EditValue) Then
            If Not IsNumeric(FD1A.EditValue) Then FD1A.EditValue = 0
            If FD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + FD1A.EditValue
            End If
        End If
        If Not IsNothing(FD2A.EditValue) Then
            If Not IsNumeric(FD2A.EditValue) Then FD2A.EditValue = 0
            If FD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + FD2A.EditValue
            End If
        End If
        If Not IsNothing(FD3A.EditValue) Then
            If Not IsNumeric(FD3A.EditValue) Then FD3A.EditValue = 0
            If FD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + FD3A.EditValue
            End If
        End If
        If Not IsNothing(FD4A.EditValue) Then
            If Not IsNumeric(FD4A.EditValue) Then FD4A.EditValue = 0
            If FD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + FD4A.EditValue
            End If
        End If
        If Not IsNothing(FD5A.EditValue) Then
            If Not IsNumeric(FD5A.EditValue) Then FD5A.EditValue = 0
            If FD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + FD5A.EditValue
            End If
        End If
        If Not IsNothing(FD6A.EditValue) Then
            If Not IsNumeric(FD6A.EditValue) Then FD6A.EditValue = 0
            If FD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + FD6A.EditValue
            End If
        End If
        FDIAS.EditValue = Suma
        FTOT.EditValue = Tot
        FIMPORTE.EditValue = CDbl(ValorF * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue)
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
            If IsNumeric(DD1A.EditValue) Then
                If DD1A.EditValue > 0 Then
                    Suma = Suma + 1
                    Tot = Tot + DD1A.EditValue
                End If
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
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue)
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
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue)
    End Sub
    Private Sub AD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AD1A.EditValueChanged, AD2A.EditValueChanged, AD3A.EditValueChanged, AD4A.EditValueChanged, AD5A.EditValueChanged, AD6A.EditValueChanged
        CalculaA()
    End Sub

    Public Sub CalculaB()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(BD1A.EditValue) Then
            If Not IsNumeric(BD1A.EditValue) Then BD1A.EditValue = 0
            If BD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD1A.EditValue
            End If

            'End If
        End If
        If Not IsNothing(BD2A.EditValue) Then
            If Not IsNumeric(BD2A.EditValue) Then BD2A.EditValue = 0
            If BD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD2A.EditValue
            End If
        End If
        If Not IsNothing(BD3A.EditValue) Then
            If Not IsNumeric(BD3A.EditValue) Then BD3A.EditValue = 0
            If BD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD3A.EditValue
            End If
        End If
        If Not IsNothing(BD4A.EditValue) Then
            If Not IsNumeric(BD4A.EditValue) Then BD4A.EditValue = 0
            If BD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD4A.EditValue
            End If
        End If
        If Not IsNothing(BD5A.EditValue) Then
            If Not IsNumeric(BD5A.EditValue) Then BD5A.EditValue = 0
            If BD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD5A.EditValue
            End If
        End If
        If Not IsNothing(BD6A.EditValue) Then
            If Not IsNumeric(BD6A.EditValue) Then BD6A.EditValue = 0
            If BD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD6A.EditValue
            End If
        End If
        BDIAS.EditValue = Suma
        BTOT.EditValue = Tot
        BIMPORTE.EditValue = CDbl(ValorB * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue)
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
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HN1', " & ValorE.ToString & ", " & ED1A.EditValue.ToString & ", 0, 0, " & _
                ED2A.EditValue.ToString & ", 0, 0, " & ED3A.EditValue.ToString & ", 0, 0, " & ED4A.EditValue.ToString & _
                ", 0, 0, " & ED5A.EditValue.ToString & ", 0, 0, " & ED6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HE1', " & ValorF.ToString & ", " & FD1A.EditValue.ToString & ", 0, 0, " & _
                FD2A.EditValue.ToString & ", 0, 0, " & FD3A.EditValue.ToString & ", 0, 0, " & FD4A.EditValue.ToString & _
                ", 0, 0, " & FD5A.EditValue.ToString & ", 0, 0, " & FD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '00', " & COMP.EditValue & ", 0, 0, 0, 0, 0, 0, 0, 0, 0, " & _
                "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '" & eObs.Text & "' "
            '"Union all " & _
            '"Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '01', 0, " & CD1A.EditValue.ToString & ", 0, 0, " & _
            'CD2A.EditValue.ToString & ", 0, 0, " & CD3A.EditValue.ToString & ", 0, 0, " & CD4A.EditValue.ToString & _
            '", 0, 0, " & CD5A.EditValue.ToString & ", 0, 0, " & CD6A.EditValue.ToString & ", 0, 0, 0, 0, 0 " & _
            '"Union all " & _
            '"Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '02', 0, " & DD1A.EditValue.ToString & ", 0, 0, " & _
            'DD2A.EditValue.ToString & ", 0, 0, " & DD3A.EditValue.ToString & ", 0, 0, " & DD4A.EditValue.ToString & _
            '", 0, 0, " & DD5A.EditValue.ToString & ", 0, 0, " & DD6A.EditValue.ToString & ", 0, 0, 0, 0, 0 " & _
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
                " D1A = " & ED1A.EditValue.ToString & ", D2A = " & ED2A.EditValue.ToString & ", D3A = " & ED3A.EditValue.ToString & _
                ", D4A = " & ED4A.EditValue.ToString & ", D5A = " & ED5A.EditValue.ToString & ", D6A = " & ED6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN1' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & FD1A.EditValue.ToString & ", D2A = " & FD2A.EditValue.ToString & ", D3A = " & FD3A.EditValue.ToString & _
                ", D4A = " & FD4A.EditValue.ToString & ", D5A = " & FD5A.EditValue.ToString & ", D6A = " & FD6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HE1' " & _
                "  " & _
                " update PreNominaDtl set Valor = " & COMP.EditValue.ToString & ", OBS = '" & eObs.Text & "' " & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '00' "
            '"  " & _
            '   " update PreNominaDtl set " & _
            '   " D1A = " & CD1A.EditValue.ToString & ", D2A = " & CD2A.EditValue.ToString & ", D3A = " & CD3A.EditValue.ToString & _
            '   ", D4A = " & CD4A.EditValue.ToString & ", D5A = " & CD5A.EditValue.ToString & ", D6A = " & CD6A.EditValue.ToString & _
            '   " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '01' " & _
            '   "  " & _
            '   " update PreNominaDtl set " & _
            '   " D1A = " & DD1A.EditValue.ToString & ", D2A = " & DD2A.EditValue.ToString & ", D3A = " & DD3A.EditValue.ToString & _
            '   ", D4A = " & DD4A.EditValue.ToString & ", D5A = " & DD5A.EditValue.ToString & ", D6A = " & DD6A.EditValue.ToString & _
            '   " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '02' " & _
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

    Private Sub ED1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ED1A.EditValueChanged, ED2A.EditValueChanged, ED3A.EditValueChanged, ED4A.EditValueChanged, ED5A.EditValueChanged, ED6A.EditValueChanged
        CalculaE()
    End Sub

    Private Sub FD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles FD1A.EditValueChanged, FD2A.EditValueChanged, FD3A.EditValueChanged, FD4A.EditValueChanged, FD5A.EditValueChanged, FD6A.EditValueChanged
        CalculaF()
    End Sub
End Class