Imports System.Data.SqlClient

Public Class BKpPreNomArm01
    Public valores(50) As String
    Public Claves(50) As String
    Public Suma = 0.0
    Public Tot = 0.0
    Public idRegNomina = ""
    Public NoEmpleado = ""
    Public Nuevo = True
    Const IDTipo = 7
    Public Calcula = False
    Private Sub COMP_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles COMP.EditValueChanged
        If Calcula = False Then Exit Sub
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If IsNothing(e4Importe.EditValue) Then e4Importe.EditValue = 0
        If IsNothing(e1Importe.EditValue) Then e1Importe.EditValue = 0
        'Exit Sub
        If CStr(e4Importe.EditValue) = "" Then e4Importe.EditValue = 0
        If CStr(e1Importe.EditValue) = "" Then e1Importe.EditValue = 0
        If CStr(COMP.EditValue) = "" Then COMP.EditValue = 0
        eTotalD.EditValue = e4Importe.EditValue + e1Importe.EditValue + e2Importe.EditValue + e3Importe.EditValue + e14Importe.EditValue + e15Importe.EditValue + e16Importe.EditValue + e17Importe.EditValue + e10Importe.EditValue + e11Importe.EditValue
        eTotal.EditValue = eTotalD.EditValue + e18Importe.EditValue + e19Importe.EditValue + COMP.EditValue
    End Sub

    Private Sub PreNomAyuGral01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Calcula = False
        Suma = 0
        Tot = 0
        Dim sql = "SELECT CLAVE, VALOR  FROM PreNominaClv  where clave in ('15', '16','17','18','21','22','25','26','27','28','29','30','31','44','45','46','47','48','HN','HE', 'PT','RC','HN1','HE1','HN3')"
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
            'valores(x + 1) = dtNom.Rows(x)("VALOR")
            Select Case dtNom.Rows(x)("CLAVE")
                Case "15"
                    valores(0) = dtNom.Rows(x)("VALOR")
                    Claves(0) = dtNom.Rows(x)("CLAVE")
                Case "16"
                    valores(1) = dtNom.Rows(x)("VALOR")
                    Claves(1) = dtNom.Rows(x)("CLAVE")
                Case "17"
                    valores(2) = dtNom.Rows(x)("VALOR")
                    Claves(2) = dtNom.Rows(x)("CLAVE")
                Case "18"
                    valores(3) = dtNom.Rows(x)("VALOR")
                    Claves(3) = dtNom.Rows(x)("CLAVE")
                Case "21"
                    valores(4) = dtNom.Rows(x)("VALOR")
                    Claves(4) = dtNom.Rows(x)("CLAVE")
                Case "22"
                    valores(5) = dtNom.Rows(x)("VALOR")
                    Claves(5) = dtNom.Rows(x)("CLAVE")
                Case "25"
                    valores(6) = dtNom.Rows(x)("VALOR")
                    Claves(6) = dtNom.Rows(x)("CLAVE")
                Case "26"
                    valores(7) = dtNom.Rows(x)("VALOR")
                    Claves(7) = dtNom.Rows(x)("CLAVE")
                Case "27"
                    valores(8) = dtNom.Rows(x)("VALOR")
                    Claves(8) = dtNom.Rows(x)("CLAVE")
                Case "28"
                    valores(9) = dtNom.Rows(x)("VALOR")
                    Claves(9) = dtNom.Rows(x)("CLAVE")
                Case "29"
                    valores(10) = dtNom.Rows(x)("VALOR")
                    Claves(10) = dtNom.Rows(x)("CLAVE")
                Case "30"
                    valores(11) = dtNom.Rows(x)("VALOR")
                    Claves(11) = dtNom.Rows(x)("CLAVE")
                Case "31"
                    valores(12) = dtNom.Rows(x)("VALOR")
                    Claves(12) = dtNom.Rows(x)("CLAVE")
                    'Case "32"
                    '    valores(13) = dtNom.Rows(x)("VALOR")
                    '    Claves(13) = dtNom.Rows(x)("CLAVE")
                    'Case "35"
                    '    valores(14) = dtNom.Rows(x)("VALOR")
                    '    Claves(14) = dtNom.Rows(x)("CLAVE")
                Case "44"
                    valores(13) = dtNom.Rows(x)("VALOR")
                    Claves(13) = dtNom.Rows(x)("CLAVE")
                Case "45"
                    valores(14) = dtNom.Rows(x)("VALOR")
                    Claves(14) = dtNom.Rows(x)("CLAVE")
                Case "46"
                    valores(15) = dtNom.Rows(x)("VALOR")
                    Claves(15) = dtNom.Rows(x)("CLAVE")
                Case "47"
                    valores(16) = dtNom.Rows(x)("VALOR")
                    Claves(16) = dtNom.Rows(x)("CLAVE")
                Case "48"
                    valores(17) = dtNom.Rows(x)("VALOR")
                    Claves(17) = dtNom.Rows(x)("CLAVE")
                Case "HN"
                    valores(18) = dtNom.Rows(x)("VALOR")
                    Claves(18) = dtNom.Rows(x)("CLAVE")
                Case "HE"
                    valores(19) = dtNom.Rows(x)("VALOR")
                    Claves(19) = dtNom.Rows(x)("CLAVE")
                Case "PT" 'Pegado de Tinas
                    valores(20) = dtNom.Rows(x)("VALOR")
                    Claves(20) = dtNom.Rows(x)("CLAVE")
                Case "RC" 'Reparacion de colchones
                    valores(21) = dtNom.Rows(x)("VALOR")
                    Claves(21) = dtNom.Rows(x)("CLAVE")
                Case "HN1"
                    valores(22) = dtNom.Rows(x)("VALOR")
                    Claves(22) = dtNom.Rows(x)("CLAVE")
                Case "HN3"
                    valores(23) = dtNom.Rows(x)("VALOR")
                    Claves(23) = dtNom.Rows(x)("CLAVE")
                Case "HE1"
                    valores(24) = dtNom.Rows(x)("VALOR")
                    Claves(24) = dtNom.Rows(x)("CLAVE")
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
        e0D1.EditValue = 0
        e0D2.EditValue = 0
        e0D3.EditValue = 0
        e0D4.EditValue = 0
        e0D5.EditValue = 0
        e0D6.EditValue = 0
        e1D1.EditValue = 0
        e1D2.EditValue = 0
        e1D3.EditValue = 0
        e1D4.EditValue = 0
        e1D5.EditValue = 0
        e1D6.EditValue = 0
        e2D1.EditValue = 0
        e2D2.EditValue = 0
        e2D3.EditValue = 0
        e2D4.EditValue = 0
        e2D5.EditValue = 0
        e2D6.EditValue = 0
        e3D1.EditValue = 0
        e3D2.EditValue = 0
        e3D3.EditValue = 0
        e3D4.EditValue = 0
        e3D5.EditValue = 0
        e3D6.EditValue = 0
        e4D1.EditValue = 0
        e4D2.EditValue = 0
        e4D3.EditValue = 0
        e4D4.EditValue = 0
        e4D5.EditValue = 0
        e4D6.EditValue = 0
        e5D1.EditValue = 0
        e5D2.EditValue = 0
        e5D3.EditValue = 0
        e5D4.EditValue = 0
        e5D5.EditValue = 0
        e5D6.EditValue = 0
        e6D1.EditValue = 0
        e6D2.EditValue = 0
        e6D3.EditValue = 0
        e6D4.EditValue = 0
        e6D5.EditValue = 0
        e6D6.EditValue = 0
        e7D1.EditValue = 0
        e7D2.EditValue = 0
        e7D3.EditValue = 0
        e7D4.EditValue = 0
        e7D5.EditValue = 0
        e7D6.EditValue = 0
        e8D1.EditValue = 0
        e8D2.EditValue = 0
        e8D3.EditValue = 0
        e8D4.EditValue = 0
        e8D5.EditValue = 0
        e8D6.EditValue = 0
        e9D1.EditValue = 0
        e9D2.EditValue = 0
        e9D3.EditValue = 0
        e9D4.EditValue = 0
        e9D5.EditValue = 0
        e9D6.EditValue = 0
        e10D1.EditValue = 0
        e10D2.EditValue = 0
        e10D3.EditValue = 0
        e10D4.EditValue = 0
        e10D5.EditValue = 0
        e10D6.EditValue = 0
        e11D1.EditValue = 0
        e11D2.EditValue = 0
        e11D3.EditValue = 0
        e11D4.EditValue = 0
        e11D5.EditValue = 0
        e11D6.EditValue = 0
        e12D1.EditValue = 0
        e12D2.EditValue = 0
        e12D3.EditValue = 0
        e12D4.EditValue = 0
        e12D5.EditValue = 0
        e12D6.EditValue = 0
        'e13D1.EditValue = 0
        'e13D2.EditValue = 0
        'e13D3.EditValue = 0
        'e13D4.EditValue = 0
        'e13D5.EditValue = 0
        'e13D6.EditValue = 0
        'e14D1.EditValue = 0
        'e14D2.EditValue = 0
        'e14D3.EditValue = 0
        'e14D4.EditValue = 0
        'e14D5.EditValue = 0
        'e14D6.EditValue = 0
        e13D1.EditValue = 0
        e13D2.EditValue = 0
        e13D3.EditValue = 0
        e13D4.EditValue = 0
        e13D5.EditValue = 0
        e13D6.EditValue = 0
        e14D1.EditValue = 0
        e14D2.EditValue = 0
        e14D3.EditValue = 0
        e14D4.EditValue = 0
        e14D5.EditValue = 0
        e14D6.EditValue = 0
        e15D1.EditValue = 0
        e15D2.EditValue = 0
        e15D3.EditValue = 0
        e15D4.EditValue = 0
        e15D5.EditValue = 0
        e15D6.EditValue = 0
        e16D1.EditValue = 0
        e16D2.EditValue = 0
        e16D3.EditValue = 0
        e16D4.EditValue = 0
        e16D5.EditValue = 0
        e16D6.EditValue = 0
        e17D1.EditValue = 0
        e17D2.EditValue = 0
        e17D3.EditValue = 0
        e17D4.EditValue = 0
        e17D5.EditValue = 0
        e17D6.EditValue = 0
        e18D1.EditValue = 0
        e18D2.EditValue = 0
        e18D3.EditValue = 0
        e18D4.EditValue = 0
        e18D5.EditValue = 0
        e18D6.EditValue = 0
        e19D1.EditValue = 0
        e19D2.EditValue = 0
        e19D3.EditValue = 0
        e19D4.EditValue = 0
        e19D5.EditValue = 0
        e19D6.EditValue = 0
        e20D1.EditValue = 0
        e20D2.EditValue = 0
        e20D3.EditValue = 0
        e20D4.EditValue = 0
        e20D5.EditValue = 0
        e20D6.EditValue = 0
        e21D1.EditValue = 0
        e21D2.EditValue = 0
        e21D3.EditValue = 0
        e21D4.EditValue = 0
        e21D5.EditValue = 0
        e21D6.EditValue = 0
        e22D1.EditValue = 0
        e22D2.EditValue = 0
        e22D3.EditValue = 0
        e22D4.EditValue = 0
        e22D5.EditValue = 0
        e22D6.EditValue = 0
        e23D1.EditValue = 0
        e23D2.EditValue = 0
        e23D3.EditValue = 0
        e23D4.EditValue = 0
        e23D5.EditValue = 0
        e23D6.EditValue = 0
        e24D1.EditValue = 0
        e24D2.EditValue = 0
        e24D3.EditValue = 0
        e24D4.EditValue = 0
        e24D5.EditValue = 0
        e24D6.EditValue = 0
        e0Importe.EditValue = 0
        e4Importe.EditValue = 0
        e1Importe.EditValue = 0
        e2Importe.EditValue = 0
        e3Importe.EditValue = 0
        e14Importe.EditValue = 0
        e15Importe.EditValue = 0
        e16Importe.EditValue = 0
        e17Importe.EditValue = 0
        e10Importe.EditValue = 0
        e11Importe.EditValue = 0
        e18Importe.EditValue = 0
        e19Importe.EditValue = 0
        'e13Importe.EditValue = 0
        'e14Importe.EditValue = 0
        e13Importe.EditValue = 0
        e14Importe.EditValue = 0
        e15Importe.EditValue = 0
        e16Importe.EditValue = 0
        e17Importe.EditValue = 0
        e18Importe.EditValue = 0
        e19Importe.EditValue = 0
        e20Importe.EditValue = 0
        e21Importe.EditValue = 0
        e22Importe.EditValue = 0
        e23Importe.EditValue = 0
        e24Importe.EditValue = 0
        e20Tot.EditValue = 0
        e20TotD1.EditValue = 0
        e20TotD2.EditValue = 0
        e20TotD3.EditValue = 0
        e20TotD4.EditValue = 0
        e20TotD5.EditValue = 0
        e20TotD6.EditValue = 0
        e21Tot.EditValue = 0
        e21TotD1.EditValue = 0
        e21TotD2.EditValue = 0
        e21TotD3.EditValue = 0
        e21TotD4.EditValue = 0
        e21TotD5.EditValue = 0
        e21TotD6.EditValue = 0
        e22Tot.EditValue = 0
        e23Tot.EditValue = 0
        e24Tot.EditValue = 0
        eTotal.EditValue = 0
        eTotalD.EditValue = 0
        COMP.EditValue = 0
        If dtPre.Rows.Count > 0 Then
            Nuevo = False
            Dim cont = 0
            For cont = 0 To dtPre.Rows.Count - 1
                'valores(cont + 1) = dtPre.Rows(cont)("Valor")
                Select Case dtPre.Rows(cont)("Clave")
                    Case "15"
                        e0Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(0) = dtPre.Rows(cont)("Valor")
                        Claves(0) = dtPre.Rows(cont)("CLAVE")
                        e0D1.EditValue = dtPre.Rows(cont)("D1A")
                        e0D2.EditValue = dtPre.Rows(cont)("D2A")
                        e0D3.EditValue = dtPre.Rows(cont)("D3A")
                        e0D4.EditValue = dtPre.Rows(cont)("D4A")
                        e0D5.EditValue = dtPre.Rows(cont)("D5A")
                        e0D6.EditValue = dtPre.Rows(cont)("D6A")
                        e0D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e0D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e0D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e0D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e0D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e0D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e0D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e0D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e0D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e0D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e0D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e0D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "16"
                        e1Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(1) = dtPre.Rows(cont)("Valor")
                        Claves(1) = dtPre.Rows(cont)("CLAVE")
                        e1D1.EditValue = dtPre.Rows(cont)("D1A")
                        e1D2.EditValue = dtPre.Rows(cont)("D2A")
                        e1D3.EditValue = dtPre.Rows(cont)("D3A")
                        e1D4.EditValue = dtPre.Rows(cont)("D4A")
                        e1D5.EditValue = dtPre.Rows(cont)("D5A")
                        e1D6.EditValue = dtPre.Rows(cont)("D6A")
                        e1D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e1D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e1D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e1D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e1D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e1D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e1D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e1D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e1D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e1D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e1D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e1D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "17"
                        e2Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(2) = dtPre.Rows(cont)("Valor")
                        Claves(2) = dtPre.Rows(cont)("CLAVE")
                        e2D1.EditValue = dtPre.Rows(cont)("D1A")
                        e2D2.EditValue = dtPre.Rows(cont)("D2A")
                        e2D3.EditValue = dtPre.Rows(cont)("D3A")
                        e2D4.EditValue = dtPre.Rows(cont)("D4A")
                        e2D5.EditValue = dtPre.Rows(cont)("D5A")
                        e2D6.EditValue = dtPre.Rows(cont)("D6A")
                        e2D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e2D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e2D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e2D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e2D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e2D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e2D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e2D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e2D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e2D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e2D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e2D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "18"
                        e3Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(3) = dtPre.Rows(cont)("Valor")
                        Claves(3) = dtPre.Rows(cont)("CLAVE")
                        e3D1.EditValue = dtPre.Rows(cont)("D1A")
                        e3D2.EditValue = dtPre.Rows(cont)("D2A")
                        e3D3.EditValue = dtPre.Rows(cont)("D3A")
                        e3D4.EditValue = dtPre.Rows(cont)("D4A")
                        e3D5.EditValue = dtPre.Rows(cont)("D5A")
                        e3D6.EditValue = dtPre.Rows(cont)("D6A")
                        e3D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e3D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e3D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e3D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e3D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e3D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e3D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e3D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e3D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e3D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e3D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e3D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "21"
                        e4Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(4) = dtPre.Rows(cont)("Valor")
                        Claves(4) = dtPre.Rows(cont)("CLAVE")
                        e4D1.EditValue = dtPre.Rows(cont)("D1A")
                        e4D2.EditValue = dtPre.Rows(cont)("D2A")
                        e4D3.EditValue = dtPre.Rows(cont)("D3A")
                        e4D4.EditValue = dtPre.Rows(cont)("D4A")
                        e4D5.EditValue = dtPre.Rows(cont)("D5A")
                        e4D6.EditValue = dtPre.Rows(cont)("D6A")
                        e4D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e4D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e4D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e4D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e4D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e4D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e4D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e4D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e4D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e4D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e4D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e4D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "22"
                        e5Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(5) = dtPre.Rows(cont)("Valor")
                        Claves(5) = dtPre.Rows(cont)("CLAVE")
                        e5D1.EditValue = dtPre.Rows(cont)("D1A")
                        e5D2.EditValue = dtPre.Rows(cont)("D2A")
                        e5D3.EditValue = dtPre.Rows(cont)("D3A")
                        e5D4.EditValue = dtPre.Rows(cont)("D4A")
                        e5D5.EditValue = dtPre.Rows(cont)("D5A")
                        e5D6.EditValue = dtPre.Rows(cont)("D6A")
                        e5D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e5D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e5D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e5D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e5D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e5D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e5D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e5D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e5D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e5D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e5D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e5D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "25"
                        e6Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(6) = dtPre.Rows(cont)("Valor")
                        Claves(6) = dtPre.Rows(cont)("CLAVE")
                        e6D1.EditValue = dtPre.Rows(cont)("D1A")
                        e6D2.EditValue = dtPre.Rows(cont)("D2A")
                        e6D3.EditValue = dtPre.Rows(cont)("D3A")
                        e6D4.EditValue = dtPre.Rows(cont)("D4A")
                        e6D5.EditValue = dtPre.Rows(cont)("D5A")
                        e6D6.EditValue = dtPre.Rows(cont)("D6A")
                        e6D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e6D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e6D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e6D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e6D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e6D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e6D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e6D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e6D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e6D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e6D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e6D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "26"
                        e7Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(7) = dtPre.Rows(cont)("Valor")
                        Claves(7) = dtPre.Rows(cont)("CLAVE")
                        e7D1.EditValue = dtPre.Rows(cont)("D1A")
                        e7D2.EditValue = dtPre.Rows(cont)("D2A")
                        e7D3.EditValue = dtPre.Rows(cont)("D3A")
                        e7D4.EditValue = dtPre.Rows(cont)("D4A")
                        e7D5.EditValue = dtPre.Rows(cont)("D5A")
                        e7D6.EditValue = dtPre.Rows(cont)("D6A")
                        e7D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e7D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e7D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e7D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e7D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e7D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e7D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e7D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e7D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e7D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e7D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e7D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "27"
                        e8Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(8) = dtPre.Rows(cont)("Valor")
                        Claves(8) = dtPre.Rows(cont)("CLAVE")
                        e8D1.EditValue = dtPre.Rows(cont)("D1A")
                        e8D2.EditValue = dtPre.Rows(cont)("D2A")
                        e8D3.EditValue = dtPre.Rows(cont)("D3A")
                        e8D4.EditValue = dtPre.Rows(cont)("D4A")
                        e8D5.EditValue = dtPre.Rows(cont)("D5A")
                        e8D6.EditValue = dtPre.Rows(cont)("D6A")
                        e8D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e8D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e8D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e8D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e8D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e8D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e8D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e8D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e8D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e8D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e8D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e8D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "28"
                        e9Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(9) = dtPre.Rows(cont)("Valor")
                        Claves(9) = dtPre.Rows(cont)("CLAVE")
                        e9D1.EditValue = dtPre.Rows(cont)("D1A")
                        e9D2.EditValue = dtPre.Rows(cont)("D2A")
                        e9D3.EditValue = dtPre.Rows(cont)("D3A")
                        e9D4.EditValue = dtPre.Rows(cont)("D4A")
                        e9D5.EditValue = dtPre.Rows(cont)("D5A")
                        e9D6.EditValue = dtPre.Rows(cont)("D6A")
                        e9D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e9D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e9D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e9D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e9D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e9D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e9D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e9D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e9D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e9D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e9D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e9D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "29"
                        e10Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(10) = dtPre.Rows(cont)("Valor")
                        Claves(10) = dtPre.Rows(cont)("CLAVE")
                        e10D1.EditValue = dtPre.Rows(cont)("D1A")
                        e10D2.EditValue = dtPre.Rows(cont)("D2A")
                        e10D3.EditValue = dtPre.Rows(cont)("D3A")
                        e10D4.EditValue = dtPre.Rows(cont)("D4A")
                        e10D5.EditValue = dtPre.Rows(cont)("D5A")
                        e10D6.EditValue = dtPre.Rows(cont)("D6A")
                        e10D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e10D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e10D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e10D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e10D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e10D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e10D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e10D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e10D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e10D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e10D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e10D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "30"
                        e11Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(11) = dtPre.Rows(cont)("Valor")
                        Claves(11) = dtPre.Rows(cont)("CLAVE")
                        e11D1.EditValue = dtPre.Rows(cont)("D1A")
                        e11D2.EditValue = dtPre.Rows(cont)("D2A")
                        e11D3.EditValue = dtPre.Rows(cont)("D3A")
                        e11D4.EditValue = dtPre.Rows(cont)("D4A")
                        e11D5.EditValue = dtPre.Rows(cont)("D5A")
                        e11D6.EditValue = dtPre.Rows(cont)("D6A")
                        e11D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e11D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e11D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e11D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e11D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e11D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e11D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e11D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e11D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e11D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e11D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e11D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "31"
                        e12Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(12) = dtPre.Rows(cont)("Valor")
                        Claves(12) = dtPre.Rows(cont)("CLAVE")
                        e12D1.EditValue = dtPre.Rows(cont)("D1A")
                        e12D2.EditValue = dtPre.Rows(cont)("D2A")
                        e12D3.EditValue = dtPre.Rows(cont)("D3A")
                        e12D4.EditValue = dtPre.Rows(cont)("D4A")
                        e12D5.EditValue = dtPre.Rows(cont)("D5A")
                        e12D6.EditValue = dtPre.Rows(cont)("D6A")
                        e12D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e12D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e12D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e12D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e12D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e12D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e12D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e12D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e12D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e12D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e12D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e12D6C.EditValue = dtPre.Rows(cont)("D6C")
                        'Case "32"
                        '    e13Clv.EditValue = dtPre.Rows(cont)("Clave")
                        '    valores(13) = dtPre.Rows(cont)("Valor")
                        '    Claves(13) = dtNom.Rows(cont)("CLAVE")
                        '    e13D1.EditValue = dtPre.Rows(cont)("D1A")
                        '    e13D2.EditValue = dtPre.Rows(cont)("D2A")
                        '    e13D3.EditValue = dtPre.Rows(cont)("D3A")
                        '    e13D4.EditValue = dtPre.Rows(cont)("D4A")
                        '    e13D5.EditValue = dtPre.Rows(cont)("D5A")
                        '    e13D6.EditValue = dtPre.Rows(cont)("D6A")
                        'Case "35"
                        '    e14Clv.EditValue = dtPre.Rows(cont)("Clave")
                        '    valores(14) = dtPre.Rows(cont)("Valor")
                        '    Claves(14) = dtNom.Rows(cont)("CLAVE")
                        '    e14D1.EditValue = dtPre.Rows(cont)("D1A")
                        '    e14D2.EditValue = dtPre.Rows(cont)("D2A")
                        '    e14D3.EditValue = dtPre.Rows(cont)("D3A")
                        '    e14D4.EditValue = dtPre.Rows(cont)("D4A")
                        '    e14D5.EditValue = dtPre.Rows(cont)("D5A")
                        '    e14D6.EditValue = dtPre.Rows(cont)("D6A")
                    Case "44"
                        e13Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(13) = dtPre.Rows(cont)("Valor")
                        Claves(13) = dtPre.Rows(cont)("CLAVE")
                        e13D1.EditValue = dtPre.Rows(cont)("D1A")
                        e13D2.EditValue = dtPre.Rows(cont)("D2A")
                        e13D3.EditValue = dtPre.Rows(cont)("D3A")
                        e13D4.EditValue = dtPre.Rows(cont)("D4A")
                        e13D5.EditValue = dtPre.Rows(cont)("D5A")
                        e13D6.EditValue = dtPre.Rows(cont)("D6A")
                        e13D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e13D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e13D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e13D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e13D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e13D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e13D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e13D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e13D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e13D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e13D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e13D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "45"
                        e14Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(14) = dtPre.Rows(cont)("Valor")
                        Claves(14) = dtPre.Rows(cont)("CLAVE")
                        e14D1.EditValue = dtPre.Rows(cont)("D1A")
                        e14D2.EditValue = dtPre.Rows(cont)("D2A")
                        e14D3.EditValue = dtPre.Rows(cont)("D3A")
                        e14D4.EditValue = dtPre.Rows(cont)("D4A")
                        e14D5.EditValue = dtPre.Rows(cont)("D5A")
                        e14D6.EditValue = dtPre.Rows(cont)("D6A")
                        e14D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e14D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e14D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e14D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e14D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e14D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e14D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e14D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e14D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e14D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e14D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e14D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "46"
                        e15Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(15) = dtPre.Rows(cont)("Valor")
                        Claves(15) = dtPre.Rows(cont)("CLAVE")
                        e15D1.EditValue = dtPre.Rows(cont)("D1A")
                        e15D2.EditValue = dtPre.Rows(cont)("D2A")
                        e15D3.EditValue = dtPre.Rows(cont)("D3A")
                        e15D4.EditValue = dtPre.Rows(cont)("D4A")
                        e15D5.EditValue = dtPre.Rows(cont)("D5A")
                        e15D6.EditValue = dtPre.Rows(cont)("D6A")
                        e15D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e15D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e15D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e15D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e15D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e15D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e15D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e15D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e15D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e15D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e15D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e15D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "47"
                        e16Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(16) = dtPre.Rows(cont)("Valor")
                        Claves(16) = dtPre.Rows(cont)("CLAVE")
                        e16D1.EditValue = dtPre.Rows(cont)("D1A")
                        e16D2.EditValue = dtPre.Rows(cont)("D2A")
                        e16D3.EditValue = dtPre.Rows(cont)("D3A")
                        e16D4.EditValue = dtPre.Rows(cont)("D4A")
                        e16D5.EditValue = dtPre.Rows(cont)("D5A")
                        e16D6.EditValue = dtPre.Rows(cont)("D6A")
                        e16D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e16D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e16D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e16D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e16D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e16D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e16D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e16D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e16D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e16D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e16D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e16D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "48"
                        e17Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(17) = dtPre.Rows(cont)("Valor")
                        Claves(17) = dtPre.Rows(cont)("CLAVE")
                        e17D1.EditValue = dtPre.Rows(cont)("D1A")
                        e17D2.EditValue = dtPre.Rows(cont)("D2A")
                        e17D3.EditValue = dtPre.Rows(cont)("D3A")
                        e17D4.EditValue = dtPre.Rows(cont)("D4A")
                        e17D5.EditValue = dtPre.Rows(cont)("D5A")
                        e17D6.EditValue = dtPre.Rows(cont)("D6A")
                        e17D1B.EditValue = dtPre.Rows(cont)("D1B")
                        e17D2B.EditValue = dtPre.Rows(cont)("D2B")
                        e17D3B.EditValue = dtPre.Rows(cont)("D3B")
                        e17D4B.EditValue = dtPre.Rows(cont)("D4B")
                        e17D5B.EditValue = dtPre.Rows(cont)("D5B")
                        e17D6B.EditValue = dtPre.Rows(cont)("D6B")
                        e17D1C.EditValue = dtPre.Rows(cont)("D1C")
                        e17D2C.EditValue = dtPre.Rows(cont)("D2C")
                        e17D3C.EditValue = dtPre.Rows(cont)("D3C")
                        e17D4C.EditValue = dtPre.Rows(cont)("D4C")
                        e17D5C.EditValue = dtPre.Rows(cont)("D5C")
                        e17D6C.EditValue = dtPre.Rows(cont)("D6C")
                    Case "HN"
                        e18Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(18) = dtPre.Rows(cont)("Valor")
                        Claves(18) = dtPre.Rows(cont)("CLAVE")
                        e18D1.EditValue = dtPre.Rows(cont)("D1A")
                        e18D2.EditValue = dtPre.Rows(cont)("D2A")
                        e18D3.EditValue = dtPre.Rows(cont)("D3A")
                        e18D4.EditValue = dtPre.Rows(cont)("D4A")
                        e18D5.EditValue = dtPre.Rows(cont)("D5A")
                        e18D6.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HE"
                        e19Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(19) = dtPre.Rows(cont)("Valor")
                        Claves(19) = dtPre.Rows(cont)("CLAVE")
                        e19D1.EditValue = dtPre.Rows(cont)("D1A")
                        e19D2.EditValue = dtPre.Rows(cont)("D2A")
                        e19D3.EditValue = dtPre.Rows(cont)("D3A")
                        e19D4.EditValue = dtPre.Rows(cont)("D4A")
                        e19D5.EditValue = dtPre.Rows(cont)("D5A")
                        e19D6.EditValue = dtPre.Rows(cont)("D6A")
                    Case "00"
                        COMP.EditValue = dtPre.Rows(cont)("Valor")
                        eObs.Text = dtPre.Rows(cont)("OBS")
                    Case "PT"
                        valores(20) = dtPre.Rows(cont)("Valor")
                        Claves(20) = dtPre.Rows(cont)("CLAVE")
                        e20D1.EditValue = dtPre.Rows(cont)("D1A")
                        e20D2.EditValue = dtPre.Rows(cont)("D2A")
                        e20D3.EditValue = dtPre.Rows(cont)("D3A")
                        e20D4.EditValue = dtPre.Rows(cont)("D4A")
                        e20D5.EditValue = dtPre.Rows(cont)("D5A")
                        e20D6.EditValue = dtPre.Rows(cont)("D6A")
                    Case "RC"
                        valores(21) = dtPre.Rows(cont)("Valor")
                        Claves(21) = dtPre.Rows(cont)("CLAVE")
                        e21D1.EditValue = dtPre.Rows(cont)("D1A")
                        e21D2.EditValue = dtPre.Rows(cont)("D2A")
                        e21D3.EditValue = dtPre.Rows(cont)("D3A")
                        e21D4.EditValue = dtPre.Rows(cont)("D4A")
                        e21D5.EditValue = dtPre.Rows(cont)("D5A")
                        e21D6.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HN1"
                        valores(22) = dtPre.Rows(cont)("Valor")
                        Claves(22) = dtPre.Rows(cont)("CLAVE")
                        e22D1.EditValue = dtPre.Rows(cont)("D1A")
                        e22D2.EditValue = dtPre.Rows(cont)("D2A")
                        e22D3.EditValue = dtPre.Rows(cont)("D3A")
                        e22D4.EditValue = dtPre.Rows(cont)("D4A")
                        e22D5.EditValue = dtPre.Rows(cont)("D5A")
                        e22D6.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HN3"
                        valores(23) = dtPre.Rows(cont)("Valor")
                        Claves(23) = dtPre.Rows(cont)("CLAVE")
                        e23D1.EditValue = dtPre.Rows(cont)("D1A")
                        e23D2.EditValue = dtPre.Rows(cont)("D2A")
                        e23D3.EditValue = dtPre.Rows(cont)("D3A")
                        e23D4.EditValue = dtPre.Rows(cont)("D4A")
                        e23D5.EditValue = dtPre.Rows(cont)("D5A")
                        e23D6.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HE1"
                        valores(24) = dtPre.Rows(cont)("Valor")
                        Claves(24) = dtPre.Rows(cont)("CLAVE")
                        e24D1.EditValue = dtPre.Rows(cont)("D1A")
                        e24D2.EditValue = dtPre.Rows(cont)("D2A")
                        e24D3.EditValue = dtPre.Rows(cont)("D3A")
                        e24D4.EditValue = dtPre.Rows(cont)("D4A")
                        e24D5.EditValue = dtPre.Rows(cont)("D5A")
                        e24D6.EditValue = dtPre.Rows(cont)("D6A")
                End Select
            Next
            'CalculaA()
            'CalculaB()
        End If
        Calcula = True
        For x = 0 To 24
            Calcular(x)
        Next
    End Sub

    Public Sub Calcular(ByVal ID As String)

        If Calcula = False Then Exit Sub
        If valores(ID) = "" Then Exit Sub

        Dim strCtrl = ""
        Dim strCtrl2 = ""
        Dim strCtrl3 = ""
        Dim SubT = 0.0
        Dim Div = 0.0
        Dim Destajo = 0.0
        Suma = 0
        Tot = 0
        For X = 1 To 6 'Dias 
            strCtrl = "e" & ID & "D" & X.ToString '& "A"
            strCtrl2 = strCtrl
            SubT = 0
            For y = 1 To 3 'ABC
                Select Case y
                    Case 1
                        strCtrl = strCtrl2
                        If ID > 5 And ID < 13 Then
                            Div = 2
                        Else
                            Div = 1
                        End If
                    Case 2
                        strCtrl = strCtrl2 & "B"
                        If ID > 5 And ID < 13 Then Div = 4 Else Div = 1
                        'Div = 2
                    Case 3
                        strCtrl = strCtrl2 & "C"
                        Div = 1
                End Select
                Try
                    For Each ctrl1 As Control In Me.Panel1.Controls
                        If TypeOf (ctrl1) Is DevExpress.XtraEditors.TextEdit Then
                            'MsgBox(ctrl1.Name)
                            If ctrl1.Name.ToString = strCtrl Then
                                If CType(ctrl1, DevExpress.XtraEditors.TextEdit).Text = "" Then CType(ctrl1, DevExpress.XtraEditors.TextEdit).Text = "0"
                                If CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue > 0 Then Suma = Suma + 1
                                If CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue > 0 Then
                                    Tot = Tot + CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue / Div
                                    SubT = SubT + CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue / Div
                                End If
                                strCtrl3 = "e" & ID & "TotD" & X
                                For Each ctrl2 As Control In Me.Panel1.Controls
                                    If TypeOf (ctrl2) Is DevExpress.XtraEditors.TextEdit Then
                                        If ctrl2.Name.ToString = strCtrl3 Then
                                            CType(ctrl2, DevExpress.XtraEditors.TextEdit).EditValue = SubT
                                            ' Exit Sub
                                        End If
                                    End If
                                Next

                            End If
                        End If
                    Next
                Catch ex As Exception
                    Tot = Tot + 0
                    SubT = SubT + 0
                End Try
            Next
        Next
        strCtrl = "e" & ID & "Dias"
        For Each ctrl1 As Control In Me.Panel1.Controls
            If TypeOf (ctrl1) Is DevExpress.XtraEditors.TextEdit Then
                If ctrl1.Name.ToString = strCtrl Then
                    CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue = Suma
                End If
            End If
        Next
        strCtrl = "e" & ID & "Tot"
        For Each ctrl1 As Control In Me.Panel1.Controls
            If TypeOf (ctrl1) Is DevExpress.XtraEditors.TextEdit Then
                If ctrl1.Name.ToString = strCtrl Then
                    CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue = Tot
                End If
            End If
        Next
        strCtrl = "e" & ID & "Importe"
        For Each ctrl1 As Control In Me.Panel1.Controls
            If TypeOf (ctrl1) Is DevExpress.XtraEditors.TextEdit Then
                If ctrl1.Name.ToString = strCtrl Then
                    CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue = Tot * CDbl(valores(ID))
                End If
            End If
        Next
        Destajo = 0
        For X = 0 To 17 'Dias 
            strCtrl = "e" & X & "Importe"
            For Each ctrl1 As Control In Me.Panel1.Controls
                If TypeOf (ctrl1) Is DevExpress.XtraEditors.TextEdit Then
                    If ctrl1.Name.ToString = strCtrl Then
                        If CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue > 0 Then
                            Destajo = Destajo + CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue
                        End If
                    End If
                End If
            Next
        Next

        If ID = 20 Then
            If Not IsNumeric(e20D1.EditValue) Then e20D1.EditValue = 0
            If Not IsNumeric(e20D2.EditValue) Then e20D2.EditValue = 0
            If Not IsNumeric(e20D3.EditValue) Then e20D3.EditValue = 0
            If Not IsNumeric(e20D4.EditValue) Then e20D4.EditValue = 0
            If Not IsNumeric(e20D5.EditValue) Then e20D5.EditValue = 0
            If Not IsNumeric(e20D6.EditValue) Then e20D6.EditValue = 0
            e20Importe.EditValue = e20D1.EditValue + e20D2.EditValue + e20D3.EditValue + e20D4.EditValue + e20D5.EditValue + e20D6.EditValue
            'Exit Sub
        End If
        If ID = 21 Then

            Try
                e21TotD1.EditValue = e21D1.EditValue * valores(21)
            Catch ex As Exception
                e21TotD1.EditValue = 0
                e21D1.EditValue = 0
            End Try
            Try
                e21TotD2.EditValue = e21D2.EditValue * valores(21)
            Catch ex As Exception
                e21TotD2.EditValue = 0
                e21D2.EditValue = 0
            End Try

            Try
                e21TotD3.EditValue = e21D3.EditValue * valores(21)
            Catch ex As Exception
                e21TotD3.EditValue = 0
                e21D3.EditValue = 0
            End Try
            Try
                e21TotD4.EditValue = e21D4.EditValue * valores(21)
            Catch ex As Exception
                e21TotD4.EditValue = 0
                e21D4.EditValue = 0
            End Try
            Try
                e21TotD5.EditValue = e21D5.EditValue * valores(21)
            Catch ex As Exception
                e21TotD5.EditValue = 0
                e21D5.EditValue = 0
            End Try
            Try
                e21TotD6.EditValue = e21D6.EditValue * valores(21)
            Catch ex As Exception
                e21TotD6.EditValue = 0
                e21D6.EditValue = 0
            End Try
            e21Tot.EditValue = e21D1.EditValue + e21D2.EditValue + e21D3.EditValue + e21D4.EditValue + e21D5.EditValue + e21D6.EditValue
            e21Importe.EditValue = e21TotD1.EditValue + e21TotD2.EditValue + e21TotD3.EditValue + e21TotD4.EditValue + e21TotD5.EditValue + e21TotD6.EditValue
            'Exit Sub
        End If
        eTotDD1.EditValue = e0TotD1.EditValue + e1TotD1.EditValue + e2TotD1.EditValue + e3TotD1.EditValue + e4TotD1.EditValue + e5TotD1.EditValue + e6TotD1.EditValue + e7TotD1.EditValue + e8TotD1.EditValue + e9TotD1.EditValue + e10TotD1.EditValue + e11TotD1.EditValue + e12TotD1.EditValue + e13TotD1.EditValue + e14TotD1.EditValue + e15TotD1.EditValue + e16TotD1.EditValue + e17TotD1.EditValue + e20TotD1.EditValue + e21TotD1.EditValue
        eTotDD2.EditValue = e0TotD2.EditValue + e1TotD2.EditValue + e2TotD2.EditValue + e3TotD2.EditValue + e4TotD2.EditValue + e5TotD2.EditValue + e6TotD2.EditValue + e7TotD2.EditValue + e8TotD2.EditValue + e9TotD2.EditValue + e10TotD2.EditValue + e11TotD2.EditValue + e12TotD2.EditValue + e13TotD2.EditValue + e14TotD2.EditValue + e15TotD2.EditValue + e16TotD2.EditValue + e17TotD2.EditValue + e20TotD2.EditValue + e21TotD2.EditValue
        eTotDD3.EditValue = e0TotD3.EditValue + e1TotD3.EditValue + e2TotD3.EditValue + e3TotD3.EditValue + e4TotD3.EditValue + e5TotD3.EditValue + e6TotD3.EditValue + e7TotD3.EditValue + e8TotD3.EditValue + e9TotD3.EditValue + e10TotD3.EditValue + e11TotD3.EditValue + e12TotD3.EditValue + e13TotD3.EditValue + e14TotD3.EditValue + e15TotD3.EditValue + e16TotD3.EditValue + e17TotD3.EditValue + e20TotD3.EditValue + e21TotD3.EditValue
        eTotDD4.EditValue = e0TotD4.EditValue + e1TotD4.EditValue + e2TotD4.EditValue + e3TotD4.EditValue + e4TotD4.EditValue + e5TotD4.EditValue + e6TotD4.EditValue + e7TotD4.EditValue + e8TotD4.EditValue + e9TotD4.EditValue + e10TotD4.EditValue + e11TotD4.EditValue + e12TotD4.EditValue + e13TotD4.EditValue + e14TotD4.EditValue + e15TotD4.EditValue + e16TotD4.EditValue + e17TotD4.EditValue + e20TotD4.EditValue + e21TotD4.EditValue
        eTotDD5.EditValue = e0TotD5.EditValue + e1TotD5.EditValue + e2TotD5.EditValue + e3TotD5.EditValue + e4TotD5.EditValue + e5TotD5.EditValue + e6TotD5.EditValue + e7TotD5.EditValue + e8TotD5.EditValue + e9TotD5.EditValue + e10TotD5.EditValue + e11TotD5.EditValue + e12TotD5.EditValue + e13TotD5.EditValue + e14TotD5.EditValue + e15TotD5.EditValue + e16TotD5.EditValue + e17TotD5.EditValue + e20TotD5.EditValue + e21TotD5.EditValue
        eTotDD6.EditValue = e0TotD6.EditValue + e1TotD6.EditValue + e2TotD6.EditValue + e3TotD6.EditValue + e4TotD6.EditValue + e5TotD6.EditValue + e6TotD6.EditValue + e7TotD6.EditValue + e8TotD6.EditValue + e9TotD6.EditValue + e10TotD6.EditValue + e11TotD6.EditValue + e12TotD6.EditValue + e13TotD6.EditValue + e14TotD6.EditValue + e15TotD6.EditValue + e16TotD6.EditValue + e17TotD6.EditValue + e20TotD6.EditValue + e21TotD6.EditValue
        eTotalD.EditValue = Destajo + e20Importe.EditValue + e21Importe.EditValue
        eTotal.EditValue = eTotalD.EditValue + e18Importe.EditValue + e19Importe.EditValue + COMP.EditValue

    End Sub

    Private Sub Calcula0(Sender As System.Object, e As System.EventArgs) Handles e0D1.EditValueChanged, e0D2.EditValueChanged, e0D3.EditValueChanged, e0D4.EditValueChanged, e0D5.EditValueChanged, e0D6.EditValueChanged,
                                                                                 e0D1B.EditValueChanged, e0D2B.EditValueChanged, e0D3B.EditValueChanged, e0D4B.EditValueChanged, e0D5B.EditValueChanged, e0D6B.EditValueChanged,
                                                                                 e0D1C.EditValueChanged, e0D2C.EditValueChanged, e0D3C.EditValueChanged, e0D4C.EditValueChanged, e0D5C.EditValueChanged, e0D6C.EditValueChanged
        Calcular(0)
    End Sub

    Private Sub Calcula1(Sender As System.Object, e As System.EventArgs) Handles e1D1.EditValueChanged, e1D2.EditValueChanged, e1D3.EditValueChanged, e1D4.EditValueChanged, e1D5.EditValueChanged, e1D6.EditValueChanged,
                                                                                 e1D1B.EditValueChanged, e1D2B.EditValueChanged, e1D3B.EditValueChanged, e1D4B.EditValueChanged, e1D5B.EditValueChanged, e1D6B.EditValueChanged,
                                                                                 e1D1C.EditValueChanged, e1D2C.EditValueChanged, e1D3C.EditValueChanged, e1D4C.EditValueChanged, e1D5C.EditValueChanged, e1D6C.EditValueChanged
        Calcular(1)
    End Sub

    Private Sub Calcula2(Sender As System.Object, e As System.EventArgs) Handles e2D1.EditValueChanged, e2D2.EditValueChanged, e2D3.EditValueChanged, e2D4.EditValueChanged, e2D5.EditValueChanged, e2D6.EditValueChanged,
                                                                                 e2D1B.EditValueChanged, e2D2B.EditValueChanged, e2D3B.EditValueChanged, e2D4B.EditValueChanged, e2D5B.EditValueChanged, e2D6B.EditValueChanged,
                                                                                 e2D1C.EditValueChanged, e2D2C.EditValueChanged, e2D3C.EditValueChanged, e2D4C.EditValueChanged, e2D5C.EditValueChanged, e2D6C.EditValueChanged
        Calcular(2)
    End Sub

    Private Sub Calcula3(Sender As System.Object, e As System.EventArgs) Handles e3D1.EditValueChanged, e3D2.EditValueChanged, e3D3.EditValueChanged, e3D4.EditValueChanged, e3D5.EditValueChanged, e3D6.EditValueChanged,
                                                                                 e3D1B.EditValueChanged, e3D2B.EditValueChanged, e3D3B.EditValueChanged, e3D4B.EditValueChanged, e3D5B.EditValueChanged, e3D6B.EditValueChanged,
                                                                                 e3D1C.EditValueChanged, e3D2C.EditValueChanged, e3D3C.EditValueChanged, e3D4C.EditValueChanged, e3D5C.EditValueChanged, e3D6C.EditValueChanged
        Calcular(3)
    End Sub

    Private Sub Calcula4(Sender As System.Object, e As System.EventArgs) Handles e4D1.EditValueChanged, e4D2.EditValueChanged, e4D3.EditValueChanged, e4D4.EditValueChanged, e4D5.EditValueChanged, e4D6.EditValueChanged,
                                                                                 e4D1B.EditValueChanged, e4D2B.EditValueChanged, e4D3B.EditValueChanged, e4D4B.EditValueChanged, e4D5B.EditValueChanged, e4D6B.EditValueChanged,
                                                                                 e4D1C.EditValueChanged, e4D2C.EditValueChanged, e4D3C.EditValueChanged, e4D4C.EditValueChanged, e4D5C.EditValueChanged, e4D6C.EditValueChanged
        Calcular(4)
    End Sub

    Private Sub Calcula5(Sender As System.Object, e As System.EventArgs) Handles e5D1.EditValueChanged, e5D2.EditValueChanged, e5D3.EditValueChanged, e5D4.EditValueChanged, e5D5.EditValueChanged, e5D6.EditValueChanged,
                                                                                 e5D1B.EditValueChanged, e5D2B.EditValueChanged, e5D3B.EditValueChanged, e5D4B.EditValueChanged, e5D5B.EditValueChanged, e5D6B.EditValueChanged,
                                                                                 e5D1C.EditValueChanged, e5D2C.EditValueChanged, e5D3C.EditValueChanged, e5D4C.EditValueChanged, e5D5C.EditValueChanged, e5D6C.EditValueChanged
        Calcular(5)
    End Sub

    Private Sub Calcula6(Sender As System.Object, e As System.EventArgs) Handles e6D1.EditValueChanged, e6D2.EditValueChanged, e6D3.EditValueChanged, e6D4.EditValueChanged, e6D5.EditValueChanged, e6D6.EditValueChanged,
                                                                                 e6D1B.EditValueChanged, e6D2B.EditValueChanged, e6D3B.EditValueChanged, e6D4B.EditValueChanged, e6D5B.EditValueChanged, e6D6B.EditValueChanged,
                                                                                 e6D1C.EditValueChanged, e6D2C.EditValueChanged, e6D3C.EditValueChanged, e6D4C.EditValueChanged, e6D5C.EditValueChanged, e6D6C.EditValueChanged
        Calcular(6)
    End Sub

    Private Sub Calcula7(Sender As System.Object, e As System.EventArgs) Handles e7D1.EditValueChanged, e7D2.EditValueChanged, e7D3.EditValueChanged, e7D4.EditValueChanged, e7D5.EditValueChanged, e7D6.EditValueChanged,
                                                                                 e7D1B.EditValueChanged, e7D2B.EditValueChanged, e7D3B.EditValueChanged, e7D4B.EditValueChanged, e7D5B.EditValueChanged, e7D6B.EditValueChanged,
                                                                                 e7D1C.EditValueChanged, e7D2C.EditValueChanged, e7D3C.EditValueChanged, e7D4C.EditValueChanged, e7D5C.EditValueChanged, e7D6C.EditValueChanged
        Calcular(7)
    End Sub

    Private Sub Calcula8(Sender As System.Object, e As System.EventArgs) Handles e8D1.EditValueChanged, e8D2.EditValueChanged, e8D3.EditValueChanged, e8D4.EditValueChanged, e8D5.EditValueChanged, e8D6.EditValueChanged,
                                                                                 e8D1B.EditValueChanged, e8D2B.EditValueChanged, e8D3B.EditValueChanged, e8D4B.EditValueChanged, e8D5B.EditValueChanged, e8D6B.EditValueChanged,
                                                                                 e8D1C.EditValueChanged, e8D2C.EditValueChanged, e8D3C.EditValueChanged, e8D4C.EditValueChanged, e8D5C.EditValueChanged, e8D6C.EditValueChanged
        Calcular(8)
    End Sub

    Private Sub Calcula9(Sender As System.Object, e As System.EventArgs) Handles e9D1.EditValueChanged, e9D2.EditValueChanged, e9D3.EditValueChanged, e9D4.EditValueChanged, e9D5.EditValueChanged, e9D6.EditValueChanged,
                                                                                 e9D1B.EditValueChanged, e9D2B.EditValueChanged, e9D3B.EditValueChanged, e9D4B.EditValueChanged, e9D5B.EditValueChanged, e9D6B.EditValueChanged,
                                                                                 e9D1C.EditValueChanged, e9D2C.EditValueChanged, e9D3C.EditValueChanged, e9D4C.EditValueChanged, e9D5C.EditValueChanged, e9D6C.EditValueChanged
        Calcular(9)
    End Sub

    Private Sub Calcula10(Sender As System.Object, e As System.EventArgs) Handles e10D1.EditValueChanged, e10D2.EditValueChanged, e10D3.EditValueChanged, e10D4.EditValueChanged, e10D5.EditValueChanged, e10D6.EditValueChanged,
                                                                                  e10D1B.EditValueChanged, e10D2B.EditValueChanged, e10D3B.EditValueChanged, e10D4B.EditValueChanged, e10D5B.EditValueChanged, e10D6B.EditValueChanged,
                                                                                  e10D1C.EditValueChanged, e10D2C.EditValueChanged, e10D3C.EditValueChanged, e10D4C.EditValueChanged, e10D5C.EditValueChanged, e10D6C.EditValueChanged
        Calcular(10)
    End Sub

    Private Sub Calcula11(Sender As System.Object, e As System.EventArgs) Handles e11D1.EditValueChanged, e11D2.EditValueChanged, e11D3.EditValueChanged, e11D4.EditValueChanged, e11D5.EditValueChanged, e11D6.EditValueChanged,
                                                                                  e11D1B.EditValueChanged, e11D2B.EditValueChanged, e11D3B.EditValueChanged, e11D4B.EditValueChanged, e11D5B.EditValueChanged, e11D6B.EditValueChanged,
                                                                                  e11D1C.EditValueChanged, e11D2C.EditValueChanged, e11D3C.EditValueChanged, e11D4C.EditValueChanged, e11D5C.EditValueChanged, e11D6C.EditValueChanged
        Calcular(11)
    End Sub

    Private Sub Calcula12(Sender As System.Object, e As System.EventArgs) Handles e12D1.EditValueChanged, e12D2.EditValueChanged, e12D3.EditValueChanged, e12D4.EditValueChanged, e12D5.EditValueChanged, e12D6.EditValueChanged,
                                                                                  e12D1B.EditValueChanged, e12D2B.EditValueChanged, e12D3B.EditValueChanged, e12D4B.EditValueChanged, e12D5B.EditValueChanged, e12D6B.EditValueChanged,
                                                                                  e12D1C.EditValueChanged, e12D2C.EditValueChanged, e12D3C.EditValueChanged, e12D4C.EditValueChanged, e12D5C.EditValueChanged, e12D6C.EditValueChanged
        Calcular(12)
    End Sub

    Private Sub Calcula13(Sender As System.Object, e As System.EventArgs) Handles e13D1.EditValueChanged, e13D2.EditValueChanged, e13D3.EditValueChanged, e13D4.EditValueChanged, e13D5.EditValueChanged, e13D6.EditValueChanged,
                                                                                  e13D1B.EditValueChanged, e13D2B.EditValueChanged, e13D3B.EditValueChanged, e13D4B.EditValueChanged, e13D5B.EditValueChanged, e13D6B.EditValueChanged,
                                                                                  e13D1C.EditValueChanged, e13D2C.EditValueChanged, e13D3C.EditValueChanged, e13D4C.EditValueChanged, e13D5C.EditValueChanged, e13D6C.EditValueChanged
        Calcular(13)
    End Sub

    Private Sub Calcula14(Sender As System.Object, e As System.EventArgs) Handles e14D1.EditValueChanged, e14D2.EditValueChanged, e14D3.EditValueChanged, e14D4.EditValueChanged, e14D5.EditValueChanged, e14D6.EditValueChanged,
                                                                                  e14D1B.EditValueChanged, e14D2B.EditValueChanged, e14D3B.EditValueChanged, e14D4B.EditValueChanged, e14D5B.EditValueChanged, e14D6B.EditValueChanged,
                                                                                  e14D1C.EditValueChanged, e14D2C.EditValueChanged, e14D3C.EditValueChanged, e14D4C.EditValueChanged, e14D5C.EditValueChanged, e14D6C.EditValueChanged
        Calcular(14)
    End Sub

    Private Sub Calcula15(Sender As System.Object, e As System.EventArgs) Handles e15D1.EditValueChanged, e15D2.EditValueChanged, e15D3.EditValueChanged, e15D4.EditValueChanged, e15D5.EditValueChanged, e15D6.EditValueChanged,
                                                                                  e15D1B.EditValueChanged, e15D2B.EditValueChanged, e15D3B.EditValueChanged, e15D4B.EditValueChanged, e15D5B.EditValueChanged, e15D6B.EditValueChanged,
                                                                                  e15D1C.EditValueChanged, e15D2C.EditValueChanged, e15D3C.EditValueChanged, e15D4C.EditValueChanged, e15D5C.EditValueChanged, e15D6C.EditValueChanged
        Calcular(15)
    End Sub

    Private Sub Calcula16(Sender As System.Object, e As System.EventArgs) Handles e16D1.EditValueChanged, e16D2.EditValueChanged, e16D3.EditValueChanged, e16D4.EditValueChanged, e16D5.EditValueChanged, e16D6.EditValueChanged,
                                                                                  e16D1B.EditValueChanged, e16D2B.EditValueChanged, e16D3B.EditValueChanged, e16D4B.EditValueChanged, e16D5B.EditValueChanged, e16D6B.EditValueChanged,
                                                                                  e16D1C.EditValueChanged, e16D2C.EditValueChanged, e16D3C.EditValueChanged, e16D4C.EditValueChanged, e16D5C.EditValueChanged, e16D6C.EditValueChanged
        Calcular(16)
    End Sub

    Private Sub Calcula17(Sender As System.Object, e As System.EventArgs) Handles e17D1.EditValueChanged, e17D2.EditValueChanged, e17D3.EditValueChanged, e17D4.EditValueChanged, e17D5.EditValueChanged, e17D6.EditValueChanged,
                                                                                  e17D1B.EditValueChanged, e17D2B.EditValueChanged, e17D3B.EditValueChanged, e17D4B.EditValueChanged, e17D5B.EditValueChanged, e17D6B.EditValueChanged,
                                                                                  e17D1C.EditValueChanged, e17D2C.EditValueChanged, e17D3C.EditValueChanged, e17D4C.EditValueChanged, e17D5C.EditValueChanged, e17D6C.EditValueChanged
        Calcular(17)
    End Sub

    Private Sub Calcula18(Sender As System.Object, e As System.EventArgs) Handles e18D1.EditValueChanged, e18D2.EditValueChanged, e18D3.EditValueChanged, e18D4.EditValueChanged, e18D5.EditValueChanged, e18D6.EditValueChanged
        Calcular(18)
    End Sub

    Private Sub Calcula19(Sender As System.Object, e As System.EventArgs) Handles e19D1.EditValueChanged, e19D2.EditValueChanged, e19D3.EditValueChanged, e19D4.EditValueChanged, e19D5.EditValueChanged, e19D6.EditValueChanged
        Calcular(19)
    End Sub

    Private Sub Calcula22(Sender As System.Object, e As System.EventArgs) Handles e22D1.EditValueChanged, e22D2.EditValueChanged, e22D3.EditValueChanged, e22D4.EditValueChanged, e22D5.EditValueChanged, e22D6.EditValueChanged
        Calcular(22)
    End Sub
    Private Sub Calcula23(Sender As System.Object, e As System.EventArgs) Handles e23D1.EditValueChanged, e23D2.EditValueChanged, e23D3.EditValueChanged, e23D4.EditValueChanged, e23D5.EditValueChanged, e23D6.EditValueChanged
        Calcular(23)
    End Sub
    Private Sub Calcula24(Sender As System.Object, e As System.EventArgs) Handles e24D1.EditValueChanged, e24D2.EditValueChanged, e24D3.EditValueChanged, e24D4.EditValueChanged, e24D5.EditValueChanged, e24D6.EditValueChanged
        Calcular(24)
    End Sub

    'Private Sub Calcula20(Sender As System.Object, e As System.EventArgs) Handles e20D1.EditValueChanged, e20D2.EditValueChanged, e20D3.EditValueChanged, e20D4.EditValueChanged, e20D5.EditValueChanged, e20D6.EditValueChanged
    '    Calcular(20)
    'End Sub

    'Private Sub Calcula21(Sender As System.Object, e As System.EventArgs) Handles e21D1.EditValueChanged, e21D2.EditValueChanged, e21D3.EditValueChanged, e21D4.EditValueChanged, e21D5.EditValueChanged, e21D6.EditValueChanged
    '    Calcular(21)
    'End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        Dim SQLUP
        If Nuevo = True Then
            SQLUP = "Insert into PreNominaDtl "
            For x = 0 To 24
                'im CtrValor = Controls.Find("valor" & x.ToString, True)
                Dim CtrD1 = Me.Controls.Find("e" & x.ToString & "D1", True)
                Dim CtrD2 = Me.Controls.Find("e" & x.ToString & "D2", True)
                Dim CtrD3 = Me.Controls.Find("e" & x.ToString & "D3", True)
                Dim CtrD4 = Me.Controls.Find("e" & x.ToString & "D4", True)
                Dim CtrD5 = Me.Controls.Find("e" & x.ToString & "D5", True)
                Dim CtrD6 = Me.Controls.Find("e" & x.ToString & "D6", True)
                'If x <= 17 Then
                Dim CtrD1B = Me.Controls.Find("e" & x.ToString & "D1B", True)
                Dim CtrD2B = Me.Controls.Find("e" & x.ToString & "D2B", True)
                Dim CtrD3B = Me.Controls.Find("e" & x.ToString & "D3B", True)
                Dim CtrD4B = Me.Controls.Find("e" & x.ToString & "D4B", True)
                Dim CtrD5B = Me.Controls.Find("e" & x.ToString & "D5B", True)
                Dim CtrD6B = Me.Controls.Find("e" & x.ToString & "D6B", True)
                Dim CtrD1C = Me.Controls.Find("e" & x.ToString & "D1C", True)
                Dim CtrD2C = Me.Controls.Find("e" & x.ToString & "D2C", True)
                Dim CtrD3C = Me.Controls.Find("e" & x.ToString & "D3C", True)
                Dim CtrD4C = Me.Controls.Find("e" & x.ToString & "D4C", True)
                Dim CtrD5C = Me.Controls.Find("e" & x.ToString & "D5C", True)
                Dim CtrD6C = Me.Controls.Find("e" & x.ToString & "D6C", True)
                'End If
                SQLUP = SQLUP & "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '" & Claves(x) & "', " & valores(x) & _
                    ", " & _
                CType(CtrD1(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD1B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD1C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                SQLUP = SQLUP & CType(CtrD2(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD2B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD2C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                SQLUP = SQLUP & CType(CtrD3(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD3B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD3C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                SQLUP = SQLUP & CType(CtrD4(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD4B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD4C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                SQLUP = SQLUP & CType(CtrD5(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD5B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD5C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                SQLUP = SQLUP & CType(CtrD6(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD6B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", " Else SQLUP = SQLUP & "0, "
                If x <= 17 Then SQLUP = SQLUP & CType(CtrD6C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString Else SQLUP = SQLUP & "0 "
                SQLUP = SQLUP & ", 0, 0, 0, '' "
                If x < 24 Then SQLUP = SQLUP & "Union all "
            Next
            SQLUP = SQLUP & " Union all Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '00', " & COMP.EditValue & ", 0, 0, 0, 0, 0, 0, 0, 0, 0, " & _
                "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '" & eObs.Text & "'"
        Else
            SQLUP = ""
            For x = 0 To 24
                Dim CtrValor = Me.Controls.Find("Valor" & x.ToString, True)
                Dim CtrD1 = Me.Controls.Find("e" & x.ToString & "D1", True)
                Dim CtrD2 = Me.Controls.Find("e" & x.ToString & "D2", True)
                Dim CtrD3 = Me.Controls.Find("e" & x.ToString & "D3", True)
                Dim CtrD4 = Me.Controls.Find("e" & x.ToString & "D4", True)
                Dim CtrD5 = Me.Controls.Find("e" & x.ToString & "D5", True)
                Dim CtrD6 = Me.Controls.Find("e" & x.ToString & "D6", True)
                'If x <= 17 Then
                Dim CtrD1B = Me.Controls.Find("e" & x.ToString & "D1B", True)
                Dim CtrD2B = Me.Controls.Find("e" & x.ToString & "D2B", True)
                Dim CtrD3B = Me.Controls.Find("e" & x.ToString & "D3B", True)
                Dim CtrD4B = Me.Controls.Find("e" & x.ToString & "D4B", True)
                Dim CtrD5B = Me.Controls.Find("e" & x.ToString & "D5B", True)
                Dim CtrD6B = Me.Controls.Find("e" & x.ToString & "D6B", True)
                Dim CtrD1C = Me.Controls.Find("e" & x.ToString & "D1C", True)
                Dim CtrD2C = Me.Controls.Find("e" & x.ToString & "D2C", True)
                Dim CtrD3C = Me.Controls.Find("e" & x.ToString & "D3C", True)
                Dim CtrD4C = Me.Controls.Find("e" & x.ToString & "D4C", True)
                Dim CtrD5C = Me.Controls.Find("e" & x.ToString & "D5C", True)
                Dim CtrD6C = Me.Controls.Find("e" & x.ToString & "D6C", True)
                '  End If
                SQLUP = SQLUP & _
                    "  update PreNominaDtl set " & _
                    " D1A = " & CType(CtrD1(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D2A = " & CType(CtrD2(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D3A = " & CType(CtrD3(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D4A = " & CType(CtrD4(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D5A = " & CType(CtrD5(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D6A = " & CType(CtrD6(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString
                If x <= 17 Then
                    SQLUP = SQLUP & _
                    ", D1B = " & CType(CtrD1B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D2B = " & CType(CtrD2B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D3B = " & CType(CtrD3B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D4B = " & CType(CtrD4B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D5B = " & CType(CtrD5B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D6B = " & CType(CtrD6B(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D1C = " & CType(CtrD1C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D2C = " & CType(CtrD2C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D3C = " & CType(CtrD3C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D4C = " & CType(CtrD4C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D5C = " & CType(CtrD5C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D6C = " & CType(CtrD6C(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString
                End If
                Select Case x
                    Case 0
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '15' "
                    Case 1
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '16' "
                    Case 2
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '17' "
                    Case 3
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '18' "
                    Case 4
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '21' "
                    Case 5
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '22' "
                    Case 6
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '25' "
                    Case 7
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '26' "
                    Case 8
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '27' "
                    Case 9
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '28' "
                    Case 10
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '29' "
                    Case 11
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '30' "
                    Case 12
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '31' "
                        'Case 13
                        '    SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '32' "
                        'Case 14
                        '    SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '36' "
                    Case 13
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '44' "
                    Case 14
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '45' "
                    Case 15
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '46' "
                    Case 16
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '47' "
                    Case 17
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '48' "
                    Case 18
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN' "
                    Case 19
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HE' "
                    Case 20
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'PT' "
                    Case 21
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'RC' "
                    Case 22
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN1' "
                    Case 23
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN3' "
                    Case 24
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HE1' "
                End Select
            Next
            SQLUP = SQLUP & " update PreNominaDtl set Valor = " & COMP.EditValue.ToString & ", OBS = '" & eObs.Text & "' " & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '00' "
            'MsgBox(SQLUP)
            ' Exit Sub
        End If
        'Exit Sub
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

    Private Sub e18Clv_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles e18Clv.MouseDoubleClick, e18Clv.Properties.DoubleClick
        Calcula = False
        If e18D1.EditValue = 8 Then
            e18D1.EditValue = 0
            e18D2.EditValue = 0
            e18D3.EditValue = 0
            e18D4.EditValue = 0
            e18D5.EditValue = 0
            e18D6.EditValue = 0
        Else
            e18D1.EditValue = 8
            e18D2.EditValue = 8
            e18D3.EditValue = 8
            e18D4.EditValue = 8
            e18D5.EditValue = 8
            e18D6.EditValue = 8
        End If
        Calcula = True
        Calcular(18)
    End Sub
    'Private Sub e19Clv_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles e19Clv.MouseDoubleClick
    '    Calcula = False
    '    e19D1.EditValue = 8
    '    e19D2.EditValue = 8
    '    e19D3.EditValue = 8
    '    e19D4.EditValue = 8
    '    e19D5.EditValue = 8
    '    e19D6.EditValue = 8
    '    Calcula = True
    '    Calcular(19)
    'End Sub

    Private Sub e21D1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e21D1.EditValueChanged, e21D2.EditValueChanged, e21D3.EditValueChanged, e21D4.EditValueChanged, e21D5.EditValueChanged, e21D6.EditValueChanged
        Calcular(21)
    End Sub

    Private Sub e20D1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e20D1.EditValueChanged, e20D2.EditValueChanged, e20D3.EditValueChanged, e20D4.EditValueChanged, e20D5.EditValueChanged, e20D6.EditValueChanged
        Calcular(20)
    End Sub
End Class