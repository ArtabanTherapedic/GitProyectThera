﻿Imports System.Data.SqlClient

Public Class PreNomAlm01
    Public ValorA = 0.0
    Public ValorB = 0.0
    Public ValorC = 0.0
    Public ValorD = 0.0
    Public ValorE = 0.0
    Public ValorF = 0.0
    Public ValorG = 0.0
    Public ValorH = 0.0
    Public ValorI = 0.0
    Public ValorJ = 0.0
    Public ValorK = 0.0
    Public ValorL = 0.0
    Public Suma = 0
    Public Tot = 0
    Public idRegNomina = ""
    Public NoEmpleado = ""
    Public Nuevo = True
    Const IDTipo = 6
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
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If Not IsNumeric(COMP.EditValue) Then COMP.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(CIMPORTE.EditValue)
    End Sub

    Private Sub PreNomAyuGral01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ValorA = 0
        ValorB = 0
        ValorC = 0
        ValorD = 0
        ValorE = 0
        ValorF = 0
        ValorG = 0
        ValorH = 0
        ValorI = 0
        ValorJ = 0
        ValorK = 0
        ValorL = 0
        Suma = 0
        Tot = 0
        'Dim sql = "SELECT CLAVE, VALOR  FROM PreNominaClv  where clave in ('HN', 'HE', '03', '04','HN2C','HN3C','1', '3','4', '5', 'HN1', 'HN0') ORDER BY CLAVE"
        Dim sql = "SELECT CLAVE, VALOR  FROM PreNominaClv  with(nolock) ORDER BY CLAVE"
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
        For x = 0 To dtNom.Rows.Count - 1
            Select Case dtNom.Rows(x)("CLAVE").ToString
                Case "HN"
                    ValorA = dtNom.Rows(x)("VALOR")
                Case "HE1"
                    ValorB = dtNom.Rows(x)("VALOR") 
                Case "HNC1"
                    ValorE = dtNom.Rows(x)("VALOR")
                Case "HE"
                    ValorF = dtNom.Rows(x)("VALOR") 
                Case "HN1"
                    ValorK = dtNom.Rows(x)("VALOR")
                Case "HNC"
                    ValorL = dtNom.Rows(x)("VALOR")
                Case "HEC"
                    ValorC = dtNom.Rows(x)("VALOR")
            End Select
        Next
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
        KD1A.EditValue = 0
        KD2A.EditValue = 0
        KD3A.EditValue = 0
        KD4A.EditValue = 0
        KD5A.EditValue = 0
        KD6A.EditValue = 0
        LD1A.EditValue = 0
        LD2A.EditValue = 0
        LD3A.EditValue = 0
        LD4A.EditValue = 0
        LD5A.EditValue = 0
        LD6A.EditValue = 0

        CD1A.EditValue = 0
        CD2A.EditValue = 0
        CD3A.EditValue = 0
        CD4A.EditValue = 0
        CD5A.EditValue = 0
        CD6A.EditValue = 0

        ADIAS.EditValue = 0
        BDIAS.EditValue = 0
        EDIAS.EditValue = 0
        FDIAS.EditValue = 0 
        KDIAS.EditValue = 0
        LD1A.EditValue = 0 
        AIMPORTE.EditValue = 0
        BIMPORTE.EditValue = 0
        EIMPORTE.EditValue = 0
        FIMPORTE.EditValue = 0 
        KIMPORTE.EditValue = 0
        LIMPORTE.EditValue = 0
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
                    Case "HE1"
                        BCLV.EditValue = dtPre.Rows(cont)("Clave")
                        ValorB = dtPre.Rows(cont)("Valor")
                        BD1A.EditValue = dtPre.Rows(cont)("D1A")
                        BD2A.EditValue = dtPre.Rows(cont)("D2A")
                        BD3A.EditValue = dtPre.Rows(cont)("D3A")
                        BD4A.EditValue = dtPre.Rows(cont)("D4A")
                        BD5A.EditValue = dtPre.Rows(cont)("D5A")
                        BD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HNC1"
                        ValorE = dtPre.Rows(cont)("Valor")
                        ED1A.EditValue = dtPre.Rows(cont)("D1A")
                        ED2A.EditValue = dtPre.Rows(cont)("D2A")
                        ED3A.EditValue = dtPre.Rows(cont)("D3A")
                        ED4A.EditValue = dtPre.Rows(cont)("D4A")
                        ED5A.EditValue = dtPre.Rows(cont)("D5A")
                        ED6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HE"
                        ValorF = dtPre.Rows(cont)("Valor")
                        FD1A.EditValue = dtPre.Rows(cont)("D1A")
                        FD2A.EditValue = dtPre.Rows(cont)("D2A")
                        FD3A.EditValue = dtPre.Rows(cont)("D3A")
                        FD4A.EditValue = dtPre.Rows(cont)("D4A")
                        FD5A.EditValue = dtPre.Rows(cont)("D5A")
                        FD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HN1"
                        ValorK = dtPre.Rows(cont)("Valor")
                        KD1A.EditValue = dtPre.Rows(cont)("D1A")
                        KD2A.EditValue = dtPre.Rows(cont)("D2A")
                        KD3A.EditValue = dtPre.Rows(cont)("D3A")
                        KD4A.EditValue = dtPre.Rows(cont)("D4A")
                        KD5A.EditValue = dtPre.Rows(cont)("D5A")
                        KD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HNC"
                        ValorL = dtPre.Rows(cont)("Valor")
                        LD1A.EditValue = dtPre.Rows(cont)("D1A")
                        LD2A.EditValue = dtPre.Rows(cont)("D2A")
                        LD3A.EditValue = dtPre.Rows(cont)("D3A")
                        LD4A.EditValue = dtPre.Rows(cont)("D4A")
                        LD5A.EditValue = dtPre.Rows(cont)("D5A")
                        LD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HEC"
                        ValorC = dtPre.Rows(cont)("Valor")
                        CD1A.EditValue = dtPre.Rows(cont)("D1A")
                        CD2A.EditValue = dtPre.Rows(cont)("D2A")
                        CD3A.EditValue = dtPre.Rows(cont)("D3A")
                        CD4A.EditValue = dtPre.Rows(cont)("D4A")
                        CD5A.EditValue = dtPre.Rows(cont)("D5A")
                        CD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "00"
                        COMP.EditValue = dtPre.Rows(cont)("Valor")
                        eObs.Text = dtPre.Rows(cont)("OBS")
                End Select
            Next
        End If

        Calcula = True
        CalculaA()
        CalculaB() 
        CalculaE()
        CalculaF()
        CalculaF() 
        CalculaK()
        CalculaL()
        CalculaC()
    End Sub

    Public Sub CalculaA()
        If Calcula = False Then Exit Sub
        Calcula = False
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
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(CIMPORTE.EditValue)
        Calcula = True
    End Sub
     
    Private Sub AD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AD1A.EditValueChanged, AD2A.EditValueChanged, AD3A.EditValueChanged, AD4A.EditValueChanged, AD5A.EditValueChanged, AD6A.EditValueChanged
        CalculaA()
    End Sub

    Public Sub CalculaB()
        If Calcula = False Then Exit Sub
        Calcula = False
        Suma = 0
        Tot = 0
        If Not IsNothing(BD1A.EditValue) Then
            If Not IsNumeric(BD1A.EditValue) Then BD1A.EditValue = 0
            If BD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD1A.EditValue
            End If
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
        Calcula = True
        BDIAS.EditValue = Suma
        BTOT.EditValue = Tot
        BIMPORTE.EditValue = CDbl(ValorB * Tot)
    End Sub

    Private Sub BD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles BD1A.EditValueChanged, BD2A.EditValueChanged, BD3A.EditValueChanged, BD4A.EditValueChanged, BD5A.EditValueChanged, BD6A.EditValueChanged
        CalculaB()
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        If Not IsNumeric(COMP.EditValue) Then COMP.EditValue = 0
        Dim SQLUP
        If Nuevo = True Then
            SQLUP = "Insert into PreNominaDtl " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HN', " & ValorA.ToString & ", " & AD1A.EditValue.ToString & ", 0, 0, " & _
                AD2A.EditValue.ToString & ", 0, 0, " & AD3A.EditValue.ToString & ", 0, 0, " & AD4A.EditValue.ToString & _
                ", 0, 0, " & AD5A.EditValue.ToString & ", 0, 0, " & AD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HE1', " & ValorB.ToString & ", " & BD1A.EditValue.ToString & ", 0, 0, " & _
                BD2A.EditValue.ToString & ", 0, 0, " & BD3A.EditValue.ToString & ", 0, 0, " & BD4A.EditValue.ToString & _
                ", 0, 0, " & BD5A.EditValue.ToString & ", 0, 0, " & BD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HNC1', " & ValorE.ToString & ", " & ED1A.EditValue.ToString & ", 0, 0, " & _
                ED2A.EditValue.ToString & ", 0, 0, " & ED3A.EditValue.ToString & ", 0, 0, " & ED4A.EditValue.ToString & _
                ", 0, 0, " & ED5A.EditValue.ToString & ", 0, 0, " & ED6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HE', " & ValorF.ToString & ", " & FD1A.EditValue.ToString & ", 0, 0, " & _
                FD2A.EditValue.ToString & ", 0, 0, " & FD3A.EditValue.ToString & ", 0, 0, " & FD4A.EditValue.ToString & _
                ", 0, 0, " & FD5A.EditValue.ToString & ", 0, 0, " & FD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                 "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HN1', " & ValorK.ToString & ", " & KD1A.EditValue.ToString & ", 0, 0, " & _
                KD2A.EditValue.ToString & ", 0, 0, " & KD3A.EditValue.ToString & ", 0, 0, " & KD4A.EditValue.ToString & _
                ", 0, 0, " & KD5A.EditValue.ToString & ", 0, 0, " & KD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HNC', " & ValorL.ToString & ", " & LD1A.EditValue.ToString & ", 0, 0, " & _
                LD2A.EditValue.ToString & ", 0, 0, " & LD3A.EditValue.ToString & ", 0, 0, " & LD4A.EditValue.ToString & _
                ", 0, 0, " & LD5A.EditValue.ToString & ", 0, 0, " & LD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HEC', " & ValorC.ToString & ", " & CD1A.EditValue.ToString & ", 0, 0, " & _
                CD2A.EditValue.ToString & ", 0, 0, " & CD3A.EditValue.ToString & ", 0, 0, " & CD4A.EditValue.ToString & _
                ", 0, 0, " & CD5A.EditValue.ToString & ", 0, 0, " & CD6A.EditValue.ToString & ", 0, 0, 0, 0, 0, '' " & _
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
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HE1' " & _
                 "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & ED1A.EditValue.ToString & ", D2A = " & ED2A.EditValue.ToString & ", D3A = " & ED3A.EditValue.ToString & _
                ", D4A = " & ED4A.EditValue.ToString & ", D5A = " & ED5A.EditValue.ToString & ", D6A = " & ED6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HNC1' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & FD1A.EditValue.ToString & ", D2A = " & FD2A.EditValue.ToString & ", D3A = " & FD3A.EditValue.ToString & _
                ", D4A = " & FD4A.EditValue.ToString & ", D5A = " & FD5A.EditValue.ToString & ", D6A = " & FD6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HE' " & _
                 "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & KD1A.EditValue.ToString & ", D2A = " & KD2A.EditValue.ToString & ", D3A = " & KD3A.EditValue.ToString & _
                ", D4A = " & KD4A.EditValue.ToString & ", D5A = " & KD5A.EditValue.ToString & ", D6A = " & KD6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN1' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & LD1A.EditValue.ToString & ", D2A = " & LD2A.EditValue.ToString & ", D3A = " & LD3A.EditValue.ToString & _
                ", D4A = " & LD4A.EditValue.ToString & ", D5A = " & LD5A.EditValue.ToString & ", D6A = " & LD6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HNC' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & CD1A.EditValue.ToString & ", D2A = " & CD2A.EditValue.ToString & ", D3A = " & CD3A.EditValue.ToString & _
                ", D4A = " & CD4A.EditValue.ToString & ", D5A = " & CD5A.EditValue.ToString & ", D6A = " & CD6A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HEC' " & _
                "  " & _
                " update PreNominaDtl set Valor = " & COMP.EditValue.ToString & ", OBS = '" & eObs.Text & "' " & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '00' "
        End If
        Dim Transac As SqlTransaction
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
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

    Private Sub ED1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ED1A.EditValueChanged, ED2A.EditValueChanged, ED3A.EditValueChanged, ED4A.EditValueChanged, ED5A.EditValueChanged, ED6A.EditValueChanged
        CalculaE()
    End Sub

    Private Sub CalculaE()
        If Calcula = False Then Exit Sub
        Calcula = False
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
        Calcula = True
        EDIAS.EditValue = Suma
        ETOT.EditValue = Tot
        EIMPORTE.EditValue = CDbl(ValorE * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(CIMPORTE.EditValue)
    End Sub

    Private Sub CalculaF()
        If Calcula = False Then Exit Sub
        Calcula = False
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
        Calcula = True
        FDIAS.EditValue = Suma
        FTOT.EditValue = Tot
        FIMPORTE.EditValue = CDbl(ValorF * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(CIMPORTE.EditValue)
    End Sub

    Private Sub Calculak()
        If Calcula = False Then Exit Sub
        Calcula = False
        Suma = 0
        Tot = 0
        If Not IsNothing(KD1A.EditValue) Then
            If Not IsNumeric(KD1A.EditValue) Then KD1A.EditValue = 0
            If KD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + KD1A.EditValue
            End If
        End If
        If Not IsNothing(KD2A.EditValue) Then
            If Not IsNumeric(KD2A.EditValue) Then KD2A.EditValue = 0
            If KD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + KD2A.EditValue
            End If
        End If
        If Not IsNothing(KD3A.EditValue) Then
            If Not IsNumeric(KD3A.EditValue) Then KD3A.EditValue = 0
            If KD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + KD3A.EditValue
            End If
        End If
        If Not IsNothing(KD4A.EditValue) Then
            If Not IsNumeric(KD4A.EditValue) Then KD4A.EditValue = 0
            If KD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + KD4A.EditValue
            End If
        End If
        If Not IsNothing(KD5A.EditValue) Then
            If Not IsNumeric(KD5A.EditValue) Then KD5A.EditValue = 0
            If KD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + KD5A.EditValue
            End If
        End If
        If Not IsNothing(KD6A.EditValue) Then
            If Not IsNumeric(KD6A.EditValue) Then KD6A.EditValue = 0
            If KD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + KD6A.EditValue
            End If
        End If
        Calcula = True
        KDIAS.EditValue = Suma
        KTOT.EditValue = Tot
        KIMPORTE.EditValue = CDbl(ValorK * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(CIMPORTE.EditValue)
    End Sub

    Private Sub CalculaL()
        If Calcula = False Then Exit Sub
        Calcula = False
        Suma = 0
        Tot = 0
        If Not IsNothing(LD1A.EditValue) Then
            If Not IsNumeric(LD1A.EditValue) Then LD1A.EditValue = 0
            If LD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + LD1A.EditValue
            End If
        End If
        If Not IsNothing(LD2A.EditValue) Then
            If Not IsNumeric(LD2A.EditValue) Then LD2A.EditValue = 0
            If LD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + LD2A.EditValue
            End If
        End If
        If Not IsNothing(LD3A.EditValue) Then
            If Not IsNumeric(LD3A.EditValue) Then LD3A.EditValue = 0
            If LD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + LD3A.EditValue
            End If
        End If
        If Not IsNothing(LD4A.EditValue) Then
            If Not IsNumeric(LD4A.EditValue) Then LD4A.EditValue = 0
            If LD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + LD4A.EditValue
            End If
        End If
        If Not IsNothing(LD5A.EditValue) Then
            If Not IsNumeric(LD5A.EditValue) Then LD5A.EditValue = 0
            If LD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + LD5A.EditValue
            End If
        End If
        If Not IsNothing(LD6A.EditValue) Then
            If Not IsNumeric(LD6A.EditValue) Then LD6A.EditValue = 0
            If LD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + LD6A.EditValue
            End If
        End If
        Calcula = True
        LDIAS.EditValue = Suma
        LTOT.EditValue = Tot
        LIMPORTE.EditValue = CDbl(ValorL * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(CIMPORTE.EditValue)
    End Sub

    Private Sub CalculaC()
        If Calcula = False Then Exit Sub
        Calcula = False
        Suma = 0
        Tot = 0
        If Not IsNothing(CD1A.EditValue) Then
            If Not IsNumeric(CD1A.EditValue) Then CD1A.EditValue = 0
            If CD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD1A.EditValue
            End If
        End If
        If Not IsNothing(CD2A.EditValue) Then
            If Not IsNumeric(CD2A.EditValue) Then CD2A.EditValue = 0
            If CD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD2A.EditValue
            End If
        End If
        If Not IsNothing(CD3A.EditValue) Then
            If Not IsNumeric(CD3A.EditValue) Then CD3A.EditValue = 0
            If CD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD3A.EditValue
            End If
        End If
        If Not IsNothing(CD4A.EditValue) Then
            If Not IsNumeric(CD4A.EditValue) Then CD4A.EditValue = 0
            If CD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD4A.EditValue
            End If
        End If
        If Not IsNothing(CD5A.EditValue) Then
            If Not IsNumeric(CD5A.EditValue) Then CD5A.EditValue = 0
            If CD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD5A.EditValue
            End If
        End If
        If Not IsNothing(CD6A.EditValue) Then
            If Not IsNumeric(CD6A.EditValue) Then CD6A.EditValue = 0
            If CD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + CD6A.EditValue
            End If
        End If
        Calcula = True
        CDIAS.EditValue = Suma
        CTOT.EditValue = Tot
        CIMPORTE.EditValue = CDbl(ValorC * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(CIMPORTE.EditValue)
    End Sub

    Private Sub FD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles FD1A.EditValueChanged, FD2A.EditValueChanged, FD3A.EditValueChanged, FD4A.EditValueChanged, FD5A.EditValueChanged, FD6A.EditValueChanged
        CalculaF()
    End Sub 

    Private Sub KD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles KD1A.EditValueChanged, KD2A.EditValueChanged, KD3A.EditValueChanged, KD4A.EditValueChanged, KD5A.EditValueChanged, KD6A.EditValueChanged
        Calculak()
    End Sub

    Private Sub LD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LD1A.EditValueChanged, LD2A.EditValueChanged, LD3A.EditValueChanged, LD4A.EditValueChanged, LD5A.EditValueChanged, LD6A.EditValueChanged
        CalculaL()
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

    Private Sub ECLV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ECLV.DoubleClick
        Calcula = False
        ED1A.EditValue = 8
        ED2A.EditValue = 8
        ED3A.EditValue = 8
        ED4A.EditValue = 8
        ED5A.EditValue = 8
        ED6A.EditValue = 8
        Calcula = True
        CalculaE()
    End Sub

    Private Sub FCLV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles FCLV.DoubleClick
        Calcula = False
        FD1A.EditValue = 8
        FD2A.EditValue = 8
        FD3A.EditValue = 8
        FD4A.EditValue = 8
        FD5A.EditValue = 8
        FD6A.EditValue = 8
        Calcula = True
        CalculaF()
    End Sub

    Private Sub KCLV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles KCLV.DoubleClick
        Calcula = False
        KD1A.EditValue = 8
        KD2A.EditValue = 8
        KD3A.EditValue = 8
        KD4A.EditValue = 8
        KD5A.EditValue = 8
        KD6A.EditValue = 8
        Calcula = True
        Calculak()
    End Sub

    Private Sub LCLV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles LCLV.DoubleClick
        Calcula = False
        LD1A.EditValue = 8
        LD2A.EditValue = 8
        LD3A.EditValue = 8
        LD4A.EditValue = 8
        LD5A.EditValue = 8
        LD6A.EditValue = 8
        Calcula = True
        CalculaL()
    End Sub

    Private Sub BCLV_DoubleClick(sender As System.Object, e As System.EventArgs) Handles BCLV.DoubleClick
        Calcula = False
        BD1A.EditValue = 8
        BD2A.EditValue = 8
        BD3A.EditValue = 8
        BD4A.EditValue = 8
        BD5A.EditValue = 8
        BD6A.EditValue = 8
        Calcula = True
        CalculaB()
    End Sub

    Private Sub CD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles CD1A.EditValueChanged, CD2A.EditValueChanged, CD3A.EditValueChanged, CD4A.EditValueChanged, CD5A.EditValueChanged, CD6A.EditValueChanged
        CalculaC()
    End Sub
End Class