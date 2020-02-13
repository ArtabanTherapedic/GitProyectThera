Imports System.Data.SqlClient

Public Class PreNomPegado01
    Public valores(50) As String
    Public Claves(50) As String 
    Public Suma = 0
    Public Tot = 0
    Public idRegNomina = ""
    Public NoEmpleado = ""
    Public Nuevo = True
    Const IDTipo = 2
    Public Calcula = False
    Private Sub COMP_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles COMP.EditValueChanged
        If Calcula = False Then Exit Sub
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If IsNothing(e1IMPORTE.EditValue) Then e1IMPORTE.EditValue = 0
        If IsNothing(e2IMPORTE.EditValue) Then e2IMPORTE.EditValue = 0
        'Exit Sub
        If CStr(e1IMPORTE.EditValue) = "" Then e1IMPORTE.EditValue = 0
        If CStr(e2IMPORTE.EditValue) = "" Then e2IMPORTE.EditValue = 0
        If CStr(COMP.EditValue) = "" Then COMP.EditValue = 0
        eTotalD.EditValue = e1IMPORTE.EditValue + e2IMPORTE.EditValue + e3Importe.EditValue + e4Importe.EditValue + e5Importe.EditValue + e6Importe.EditValue + e7Importe.EditValue + e8Importe.EditValue + e9Importe.EditValue + e10Importe.EditValue
        eTotal.EditValue = eTotalD.EditValue + e11Importe.EditValue + e12Importe.EditValue + COMP.EditValue

    End Sub

    Private Sub PreNomAyuGral01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load 
        Suma = 0
        Tot = 0
        Dim sql = "SELECT CLAVE, VALOR  FROM PreNominaClv  where clave in ('15','16','17','18','45','46','47','48','41','42','HN','HE')"
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
                    valores(1) = dtNom.Rows(x)("VALOR")
                    Claves(1) = dtNom.Rows(x)("CLAVE")
                Case "16"
                    valores(2) = dtNom.Rows(x)("VALOR")
                    Claves(2) = dtNom.Rows(x)("CLAVE")
                Case "17"
                    valores(3) = dtNom.Rows(x)("VALOR")
                    Claves(3) = dtNom.Rows(x)("CLAVE")
                Case "18"
                    valores(4) = dtNom.Rows(x)("VALOR")
                    Claves(4) = dtNom.Rows(x)("CLAVE")
                Case "45"
                    valores(5) = dtNom.Rows(x)("VALOR")
                    Claves(5) = dtNom.Rows(x)("CLAVE")
                Case "46"
                    valores(6) = dtNom.Rows(x)("VALOR")
                    Claves(6) = dtNom.Rows(x)("CLAVE")
                Case "47"
                    valores(7) = dtNom.Rows(x)("VALOR")
                    Claves(7) = dtNom.Rows(x)("CLAVE")
                Case "48"
                    valores(8) = dtNom.Rows(x)("VALOR")
                    Claves(8) = dtNom.Rows(x)("CLAVE")
                Case "41"
                    valores(9) = dtNom.Rows(x)("VALOR")
                    Claves(9) = dtNom.Rows(x)("CLAVE")
                Case "42"
                    valores(10) = dtNom.Rows(x)("VALOR")
                    Claves(10) = dtNom.Rows(x)("CLAVE")
                Case "HN"
                    valores(11) = dtNom.Rows(x)("VALOR")
                    Claves(11) = dtNom.Rows(x)("CLAVE")
                Case "HE"
                    valores(12) = dtNom.Rows(x)("VALOR")
                    Claves(12) = dtNom.Rows(x)("CLAVE")
            End Select
        Next
        sql = "SELECT idRegNomina, NoEmpleado, idPuesto, Clave, Valor, D1A, D1B, D1C, D2A, D2B, D2C, D3A, D3B, D3C, D4A, D4B, D4C, D5A, D5B, D5C, D6A, D6B, D6C, D7A, D7B, D7C, OBS " & _
            " FROM PreNominaDtl WITH (nolock) where idRegNomina = " & idRegNomina & " and noEmpleado = '" & NoEmpleado & "'"
        Dim dtPre As New DataTable
        Dim daPre As New SqlDataAdapter
        Dim cmdPre As New SqlCommand(sql, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        daPre.SelectCommand = cmdPre
        daPre.Fill(dtPre)
        e1D1A.EditValue = 0
        e1D2A.EditValue = 0
        e1D3A.EditValue = 0
        e1D4A.EditValue = 0
        e1D5A.EditValue = 0
        e1D6A.EditValue = 0
        e2D1A.EditValue = 0
        e2D2A.EditValue = 0
        e2D3A.EditValue = 0
        e2D4A.EditValue = 0
        e2D5A.EditValue = 0
        e2D6A.EditValue = 0
        e3D1A.EditValue = 0
        e3D2A.EditValue = 0
        e3D3A.EditValue = 0
        e3D4A.EditValue = 0
        e3D5A.EditValue = 0
        e3D6A.EditValue = 0
        e4D1A.EditValue = 0
        e4D2A.EditValue = 0
        e4D3A.EditValue = 0
        e4D4A.EditValue = 0
        e4D5A.EditValue = 0
        e4D6A.EditValue = 0
        e5D1A.EditValue = 0
        e5D2A.EditValue = 0
        e5D3A.EditValue = 0
        e5D4A.EditValue = 0
        e5D5A.EditValue = 0
        e5D6A.EditValue = 0
        e6D1A.EditValue = 0
        e6D2A.EditValue = 0
        e6D3A.EditValue = 0
        e6D4A.EditValue = 0
        e6D5A.EditValue = 0
        e6D6A.EditValue = 0
        e7D1A.EditValue = 0
        e7D2A.EditValue = 0
        e7D3A.EditValue = 0
        e7D4A.EditValue = 0
        e7D5A.EditValue = 0
        e7D6A.EditValue = 0
        e8D1A.EditValue = 0
        e8D2A.EditValue = 0
        e8D3A.EditValue = 0
        e8D4A.EditValue = 0
        e8D5A.EditValue = 0
        e8D6A.EditValue = 0
        e9D1A.EditValue = 0
        e9D2A.EditValue = 0
        e9D3A.EditValue = 0
        e9D4A.EditValue = 0
        e9D5A.EditValue = 0
        e9D6A.EditValue = 0
        e10D1A.EditValue = 0
        e10D2A.EditValue = 0
        e10D3A.EditValue = 0
        e10D4A.EditValue = 0
        e10D5A.EditValue = 0
        e10D6A.EditValue = 0
        e11D1A.EditValue = 0
        e11D2A.EditValue = 0
        e11D3A.EditValue = 0
        e11D4A.EditValue = 0
        e11D5A.EditValue = 0
        e11D6A.EditValue = 0
        e12D1A.EditValue = 0
        e12D2A.EditValue = 0
        e12D3A.EditValue = 0
        e12D4A.EditValue = 0
        e12D5A.EditValue = 0
        e12D6A.EditValue = 0
        e1IMPORTE.EditValue = 0
        e2IMPORTE.EditValue = 0
        e3Importe.EditValue = 0
        e4Importe.EditValue = 0
        e5Importe.EditValue = 0
        e6Importe.EditValue = 0
        e7Importe.EditValue = 0
        e8Importe.EditValue = 0
        e9Importe.EditValue = 0
        e10Importe.EditValue = 0
        e11Importe.EditValue = 0
        e12Importe.EditValue = 0
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
                        e1CLV.EditValue = dtPre.Rows(cont)("Clave")
                        valores(1) = dtPre.Rows(cont)("Valor")
                        Claves(1) = dtPre.Rows(cont)("CLAVE")
                        e1D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e1D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e1D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e1D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e1D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e1D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "16"
                        e2CLV.EditValue = dtPre.Rows(cont)("Clave")
                        valores(2) = dtPre.Rows(cont)("Valor")
                        Claves(2) = dtPre.Rows(cont)("CLAVE")
                        e2D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e2D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e2D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e2D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e2D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e2D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "17"
                        e3Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(3) = dtPre.Rows(cont)("Valor")
                        Claves(3) = dtPre.Rows(cont)("CLAVE")
                        e3D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e3D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e3D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e3D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e3D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e3D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "18"
                        e4Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(4) = dtPre.Rows(cont)("Valor")
                        Claves(4) = dtPre.Rows(cont)("CLAVE")
                        e4D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e4D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e4D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e4D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e4D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e4D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "45"
                        e5Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(5) = dtPre.Rows(cont)("Valor")
                        Claves(5) = dtPre.Rows(cont)("CLAVE")
                        e5D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e5D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e5D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e5D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e5D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e5D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "46"
                        e6Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(6) = dtPre.Rows(cont)("Valor")
                        Claves(6) = dtPre.Rows(cont)("CLAVE")
                        e6D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e6D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e6D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e6D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e6D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e6D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "47" 
                        e7Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(7) = dtPre.Rows(cont)("Valor")
                        Claves(7) = dtPre.Rows(cont)("CLAVE")
                        e7D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e7D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e7D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e7D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e7D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e7D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "48"
                        e8Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(8) = dtPre.Rows(cont)("Valor")
                        Claves(8) = dtPre.Rows(cont)("CLAVE")
                        e8D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e8D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e8D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e8D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e8D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e8D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "41"
                        e9Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(9) = dtPre.Rows(cont)("Valor")
                        Claves(9) = dtPre.Rows(cont)("CLAVE")
                        e9D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e9D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e9D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e9D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e9D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e9D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "42"
                        e10Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(10) = dtPre.Rows(cont)("Valor")
                        Claves(10) = dtPre.Rows(cont)("CLAVE")
                        e10D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e10D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e10D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e10D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e10D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e10D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HN"
                        e11Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(11) = dtPre.Rows(cont)("Valor")
                        Claves(11) = dtPre.Rows(cont)("CLAVE")
                        e11D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e11D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e11D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e11D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e11D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e11D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HE"
                        e12Clv.EditValue = dtPre.Rows(cont)("Clave")
                        valores(12) = dtPre.Rows(cont)("Valor")
                        Claves(12) = dtPre.Rows(cont)("CLAVE")
                        e12D1A.EditValue = dtPre.Rows(cont)("D1A")
                        e12D2A.EditValue = dtPre.Rows(cont)("D2A")
                        e12D3A.EditValue = dtPre.Rows(cont)("D3A")
                        e12D4A.EditValue = dtPre.Rows(cont)("D4A")
                        e12D5A.EditValue = dtPre.Rows(cont)("D5A")
                        e12D6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "00"
                        COMP.EditValue = dtPre.Rows(cont)("Valor")
                        eObs.Text = dtPre.Rows(cont)("OBS")
                End Select
            Next
            'CalculaA()
            'CalculaB()
        End If
        Calcula = True
        For x = 1 To 12
            Calcular(x)
        Next
    End Sub

    Public Sub Calcular(ByVal ID As String)
        If Calcula = False Then Exit Sub
        If valores(ID) = "" Then Exit Sub
        Dim strCtrl = ""

        Suma = 0
        Tot = 0
        For X = 1 To 6 'Dias 
            strCtrl = "e" & ID & "D" & X.ToString & "A"
            For Each ctrl1 As Control In Me.Panel1.Controls
                If TypeOf (ctrl1) Is DevExpress.XtraEditors.TextEdit Then
                    If ctrl1.Name.ToString = strCtrl Then
                        If CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue > 0 Then

                            Suma = Suma + 1
                            Tot = Tot + CType(ctrl1, DevExpress.XtraEditors.TextEdit).EditValue
                        End If

                    End If
                End If
            Next
        Next
        Select Case ID
            Case 1
                e1DIAS.EditValue = Suma
                e1TOT.EditValue = Tot
                'e1IMPORTE.EditValue = Tot * CDbl(Valor1)
                e1IMPORTE.EditValue = Tot * CDbl(valores(ID))
            Case 2
                e2DIAS.EditValue = Suma
                e2TOT.EditValue = Tot
                'e2IMPORTE.EditValue = Tot * CDbl(Valor2)
                e2IMPORTE.EditValue = Tot * CDbl(valores(ID))
            Case 3
                e3Dias.EditValue = Suma
                e3Tot.EditValue = Tot
                'e3Importe.EditValue = Tot * CDbl(Valor3)
                e3Importe.EditValue = Tot * CDbl(valores(ID))
            Case 4
                e4Dias.EditValue = Suma
                e4Tot.EditValue = Tot
                'e4Importe.EditValue = Tot * CDbl(Valor4)
                e4Importe.EditValue = Tot * CDbl(valores(ID))
            Case 5
                e5Dias.EditValue = Suma
                e5Tot.EditValue = Tot
                'e5Importe.EditValue = Tot * CDbl(Valor5)
                e5Importe.EditValue = Tot * CDbl(valores(ID))
            Case 6
                e6Dias.EditValue = Suma
                e6Tot.EditValue = Tot
                'e6Importe.EditValue = Tot * CDbl(Valor6)
                e6Importe.EditValue = Tot * CDbl(valores(ID))
            Case 7
                e7Dias.EditValue = Suma
                e7Tot.EditValue = Tot
                'e7Importe.EditValue = Tot * CDbl(Valor7)
                e7Importe.EditValue = Tot * CDbl(valores(ID))
            Case 8
                e8Dias.EditValue = Suma
                e8Tot.EditValue = Tot
                'e8Importe.EditValue = Tot * CDbl(Valor8)
                e8Importe.EditValue = Tot * CDbl(valores(ID))
            Case 9
                e9Dias.EditValue = Suma
                e9Tot.EditValue = Tot
                'e9Importe.EditValue = Tot * CDbl(Valor9)
                e9Importe.EditValue = Tot * CDbl(valores(ID))
            Case 10
                e10Dias.EditValue = Suma
                e10Tot.EditValue = Tot
                'e10Importe.EditValue = Tot * CDbl(Valor10)
                e10Importe.EditValue = Tot * CDbl(valores(ID))
            Case 11
                e11Dias.EditValue = Suma
                e11Tot.EditValue = Tot
                'e11Importe.EditValue = Tot * CDbl(Valor11)
                e11Importe.EditValue = Tot * CDbl(valores(ID))
            Case 12
                e12Dias.EditValue = Suma
                e12Tot.EditValue = Tot
                'e12Importe.EditValue = Tot * CDbl(Valor12)
                e12Importe.EditValue = Tot * CDbl(valores(ID))
        End Select
        eTotalD.EditValue = e1IMPORTE.EditValue + e2IMPORTE.EditValue + e3Importe.EditValue + e4Importe.EditValue + e5Importe.EditValue + e6Importe.EditValue + e7Importe.EditValue + e8Importe.EditValue + e9Importe.EditValue + e10Importe.EditValue
        eTotal.EditValue = eTotalD.EditValue + e11Importe.EditValue + e12Importe.EditValue + COMP.EditValue
    End Sub

    Private Sub a3_EditValueChanged(Sender As System.Object, e As System.EventArgs) Handles e3D6A.EditValueChanged, e3D5A.EditValueChanged, e3D4A.EditValueChanged, e3D3A.EditValueChanged, e3D2A.EditValueChanged, e3D1A.EditValueChanged
        Calcular(3)
    End Sub

    Private Sub a4_EditValueChanged(Sender As System.Object, e As System.EventArgs) Handles e4D6A.EditValueChanged, e4D5A.EditValueChanged, e4D4A.EditValueChanged, e4D3A.EditValueChanged, e4D2A.EditValueChanged, e4D1A.EditValueChanged
        Calcular(4)
    End Sub

    Private Sub a1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e1D1A.EditValueChanged, e1D6A.EditValueChanged, e1D5A.EditValueChanged, e1D4A.EditValueChanged, e1D3A.EditValueChanged, e1D2A.EditValueChanged, e1D1A.EditValueChanged
        Calcular(1)
    End Sub

    Private Sub a5_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e5D6A.EditValueChanged, e5D5A.EditValueChanged, e5D4A.EditValueChanged, e5D3A.EditValueChanged, e5D2A.EditValueChanged, e5D1A.EditValueChanged
        Calcular(5)
    End Sub

    Private Sub a6_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e6D6A.EditValueChanged, e6D5A.EditValueChanged, e6D4A.EditValueChanged, e6D3A.EditValueChanged, e6D2A.EditValueChanged, e6D1A.EditValueChanged
        Calcular(6)
    End Sub

    Private Sub a7_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e7D6A.EditValueChanged, e7D5A.EditValueChanged, e7D4A.EditValueChanged, e7D3A.EditValueChanged, e7D2A.EditValueChanged, e7D1A.EditValueChanged
        Calcular(7)
    End Sub

    Private Sub a8_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e8D6A.EditValueChanged, e8D5A.EditValueChanged, e8D4A.EditValueChanged, e8D3A.EditValueChanged, e8D2A.EditValueChanged, e8D1A.EditValueChanged
        Calcular(8)
    End Sub

    Private Sub a9_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e9D6A.EditValueChanged, e9D5A.EditValueChanged, e9D4A.EditValueChanged, e9D3A.EditValueChanged, e9D2A.EditValueChanged, e9D1A.EditValueChanged
        Calcular(9)
    End Sub

    Private Sub a10_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e10D6A.EditValueChanged, e10D5A.EditValueChanged, e10D4A.EditValueChanged, e10D3A.EditValueChanged, e10D2A.EditValueChanged, e10D1A.EditValueChanged
        Calcular(10)
    End Sub

    Private Sub a11_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e11D6A.EditValueChanged, e11D5A.EditValueChanged, e11D4A.EditValueChanged, e11D3A.EditValueChanged, e11D2A.EditValueChanged, e11D1A.EditValueChanged
        Calcular(11)
    End Sub

    Private Sub a12_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e12D6A.EditValueChanged, e12D5A.EditValueChanged, e12D4A.EditValueChanged, e12D3A.EditValueChanged, e12D2A.EditValueChanged, e12D1A.EditValueChanged
        Calcular(12)
    End Sub

    Private Sub BD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles e2D1A.EditValueChanged, e2D6A.EditValueChanged, e2D5A.EditValueChanged, e2D4A.EditValueChanged, e2D3A.EditValueChanged, e2D2A.EditValueChanged
        Calcular(2)
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        Dim SQLUP 
        If Nuevo = True Then
            SQLUP = "Insert into PreNominaDtl "
            For x = 1 To 12 
                'im CtrValor = Controls.Find("valor" & x.ToString, True)
                Dim CtrD1 = Me.Controls.Find("e" & x.ToString & "D1A", True)
                Dim CtrD2 = Me.Controls.Find("e" & x.ToString & "D2A", True)
                Dim CtrD3 = Me.Controls.Find("e" & x.ToString & "D3A", True)
                Dim CtrD4 = Me.Controls.Find("e" & x.ToString & "D4A", True)
                Dim CtrD5 = Me.Controls.Find("e" & x.ToString & "D5A", True)
                Dim CtrD6 = Me.Controls.Find("e" & x.ToString & "D6A", True)
                SQLUP = SQLUP & "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '" & Claves(x) & "', " & valores(x) & _
                    ", " & CType(CtrD1(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", 0, 0, " & _
                CType(CtrD2(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", 0, 0, " & _
                CType(CtrD3(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", 0, 0, " & _
                CType(CtrD4(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", 0, 0, " & _
                CType(CtrD5(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", 0, 0, " & _
                CType(CtrD6(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & ", 0, 0, 0, 0, 0, '' "
                If x < 12 Then SQLUP = SQLUP & "Union all "
            Next
            SQLUP = SQLUP & " Union all Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '00', " & COMP.EditValue & ", 0, 0, 0, 0, 0, 0, 0, 0, 0, " & _
                "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '" & eObs.Text & "'"
        Else
            SQLUP = ""
            For x = 1 To 12
                Dim CtrValor = Me.Controls.Find("Valor" & x.ToString, True)
                Dim CtrD1 = Me.Controls.Find("e" & x.ToString & "D1A", True)
                Dim CtrD2 = Me.Controls.Find("e" & x.ToString & "D2A", True)
                Dim CtrD3 = Me.Controls.Find("e" & x.ToString & "D3A", True)
                Dim CtrD4 = Me.Controls.Find("e" & x.ToString & "D4A", True)
                Dim CtrD5 = Me.Controls.Find("e" & x.ToString & "D5A", True)
                Dim CtrD6 = Me.Controls.Find("e" & x.ToString & "D6A", True)
                SQLUP = SQLUP & _
                    "  update PreNominaDtl set " & _
                    " D1A = " & CType(CtrD1(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D2A = " & CType(CtrD2(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D3A = " & CType(CtrD3(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D4A = " & CType(CtrD4(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D5A = " & CType(CtrD5(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString & _
                    ", D6A = " & CType(CtrD1(0), DevExpress.XtraEditors.TextEdit).EditValue.ToString
                Select Case x
                    Case 1
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '15' "
                    Case 2
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '16' "
                    Case 3
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '17' "
                    Case 4
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '18' "
                    Case 5
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '45' "
                    Case 6
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '46' "
                    Case 7
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '47' "
                    Case 8
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '48' "
                    Case 9
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '41' "
                    Case 10
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '42' "
                    Case 11
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN' "
                    Case 12
                        SQLUP = SQLUP & " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HE' "
                End Select
            Next
            SQLUP = SQLUP & " update PreNominaDtl set Valor = " & COMP.EditValue.ToString & ", OBS = '" & eObs.Text & "' " & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '00' "
            'MsgBox(SQLUP)
            ' Exit Sub
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

    Private Sub e11Clv_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles e11Clv.MouseDoubleClick
        Calcula = False
        e11D1A.EditValue = 8
        e11D2A.EditValue = 8
        e11D3A.EditValue = 8
        e11D4A.EditValue = 8
        e11D5A.EditValue = 8
        e11D6A.EditValue = 8
        Calcula = True
        Calcular(11)
    End Sub
End Class