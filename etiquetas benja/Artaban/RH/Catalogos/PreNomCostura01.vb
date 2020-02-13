Imports System.Data.SqlClient

Public Class PreNomCostura01
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
    Public ValorM = 0.0
    Public ValorN = 0.0
    Public ValorO = 0.0
    Public Suma = 0
    Public Tot = 0
    Public idRegNomina = ""
    Public NoEmpleado = ""
    Public Nuevo = True
    Const IDTipo = 3
    Public Calcula = False
    Private Sub CalculoDiario()
        Dim SumaV As Double
        Dim SumaD As Double
        SumaD = 0
        SumaV = 0
        If CD1A.EditValue - 270 > 0 Then
            SumaV = ((CD1A.EditValue - 270) / 30) * ValorC
        Else
            SumaV = 0
        End If
        If DD1A.EditValue - 400 > 0 Then
            SumaD = ((DD1A.EditValue - 400) / 30) * ValorD
        Else
            SumaD = 0
        End If
        Diario1.EditValue = (AD1A.EditValue * ValorA) + (BD1A.EditValue * ValorB) + SumaV + SumaD + (ED1A.EditValue * ValorE) + (FD1A.EditValue * ValorF) + (GD1A.EditValue * ValorG) + (HD1A.EditValue * ValorH) + (ID1A.EditValue * ValorI) + (JD1A.EditValue * ValorJ) + (KD1A.EditValue * ValorK) + (LD1A.EditValue * ValorL) + (MD1A.EditValue) + (ND1A.EditValue * ValorN) + (OD1A.EditValue * ValorO)

        SumaD = 0
        SumaV = 0
        If CD2A.EditValue - 270 > 0 Then
            SumaV = ((CD2A.EditValue - 270) / 30) * ValorC
        Else
            SumaV = 0
        End If
        If DD2A.EditValue - 400 > 0 Then
            SumaD = ((DD2A.EditValue - 400) / 30) * ValorD
        Else
            SumaD = 0
        End If
        Diario2.EditValue = (AD2A.EditValue * ValorA) + (BD2A.EditValue * ValorB) + SumaV + SumaD + (ED2A.EditValue * ValorE) + (FD2A.EditValue * ValorF) + (GD2A.EditValue * ValorG) + (HD2A.EditValue * ValorH) + (ID2A.EditValue * ValorI) + (JD2A.EditValue * ValorJ) + (KD2A.EditValue * ValorK) + (LD2A.EditValue * ValorL) + (MD2A.EditValue) + (ND2A.EditValue * ValorN) + (OD2A.EditValue * ValorO)

        SumaD = 0
        SumaV = 0
        If CD3A.EditValue - 270 > 0 Then
            SumaV = ((CD3A.EditValue - 270) / 30) * ValorC
        Else
            SumaV = 0
        End If
        If DD3A.EditValue - 400 > 0 Then
            SumaD = ((DD3A.EditValue - 400) / 30) * ValorD
        Else
            SumaD = 0
        End If
        Diario3.EditValue = (AD3A.EditValue * ValorA) + (BD3A.EditValue * ValorB) + SumaV + SumaD + (ED3A.EditValue * ValorE) + (FD3A.EditValue * ValorF) + (GD3A.EditValue * ValorG) + (HD3A.EditValue * ValorH) + (ID3A.EditValue * ValorI) + (JD3A.EditValue * ValorJ) + (KD3A.EditValue * ValorK) + (LD3A.EditValue * ValorL) + (MD3A.EditValue) + (ND3A.EditValue * ValorN) + (OD3A.EditValue * ValorO)

        SumaD = 0
        SumaV = 0
        If CD4A.EditValue - 270 > 0 Then
            SumaV = ((CD4A.EditValue - 270) / 30) * ValorC
        Else
            SumaV = 0
        End If
        If DD4A.EditValue - 400 > 0 Then
            SumaD = ((DD4A.EditValue - 400) / 30) * ValorD
        Else
            SumaD = 0
        End If
        Diario4.EditValue = (AD4A.EditValue * ValorA) + (BD4A.EditValue * ValorB) + SumaV + SumaD + (ED4A.EditValue * ValorE) + (FD4A.EditValue * ValorF) + (GD4A.EditValue * ValorG) + (HD4A.EditValue * ValorH) + (ID4A.EditValue * ValorI) + (JD4A.EditValue * ValorJ) + (KD4A.EditValue * ValorK) + (LD4A.EditValue * ValorL) + (MD4A.EditValue) + (ND4A.EditValue * ValorN) + (OD4A.EditValue * ValorO)

        SumaD = 0
        SumaV = 0
        If CD5A.EditValue - 270 > 0 Then
            SumaV = ((CD5A.EditValue - 270) / 30) * ValorC
        Else
            SumaV = 0
        End If
        If DD5A.EditValue - 400 > 0 Then
            SumaD = ((DD5A.EditValue - 400) / 30) * ValorD
        Else
            SumaD = 0
        End If
        Diario5.EditValue = (AD5A.EditValue * ValorA) + (BD5A.EditValue * ValorB) + SumaV + SumaD + (ED5A.EditValue * ValorE) + (FD5A.EditValue * ValorF) + (GD5A.EditValue * ValorG) + (HD5A.EditValue * ValorH) + (ID5A.EditValue * ValorI) + (JD5A.EditValue * ValorJ) + (KD5A.EditValue * ValorK) + (LD5A.EditValue * ValorL) + (MD5A.EditValue) + (ND5A.EditValue * ValorN) + (OD5A.EditValue * ValorO)

        SumaD = 0
        SumaV = 0
        If CD6A.EditValue - 270 > 0 Then
            SumaV = ((CD6A.EditValue - 270) / 30) * ValorC
        Else
            SumaV = 0
        End If
        If DD6A.EditValue - 400 > 0 Then
            SumaD = ((DD6A.EditValue - 400) / 30) * ValorD
        Else
            SumaD = 0
        End If
        Diario6.EditValue = (AD6A.EditValue * ValorA) + (BD6A.EditValue * ValorB) + SumaV + SumaD + (ED6A.EditValue * ValorE) + (FD6A.EditValue * ValorF) + (GD6A.EditValue * ValorG) + (HD6A.EditValue * ValorH) + (ID6A.EditValue * ValorI) + (JD6A.EditValue * ValorJ) + (KD6A.EditValue * ValorK) + (LD6A.EditValue * ValorL) + (MD6A.EditValue) + (ND6A.EditValue * ValorN) + (OD6A.EditValue * ValorO)

        SumaD = 0
        SumaV = 0
        If CD7A.EditValue - 270 > 0 Then
            SumaV = ((CD7A.EditValue - 270) / 30) * ValorC
        Else
            SumaV = 0
        End If
        If DD7A.EditValue - 400 > 0 Then
            SumaD = ((DD7A.EditValue - 400) / 30) * ValorD
        Else
            SumaD = 0
        End If
        Diario7.EditValue = (AD7A.EditValue * ValorA) + (BD7A.EditValue * ValorB) + SumaV + SumaD + (ED7A.EditValue * ValorE) + (FD7A.EditValue * ValorF) + (GD7A.EditValue * ValorG) + (HD7A.EditValue * ValorH) + (ID7A.EditValue * ValorI) + (JD7A.EditValue * ValorJ) + (KD7A.EditValue * ValorK) + (LD7A.EditValue * ValorL) + (MD7A.EditValue) + (ND7A.EditValue * ValorN) + (OD7A.EditValue * ValorO)
    End Sub
    Private Sub COMP_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles COMP.EditValueChanged, AIMPORTE.EditValueChanged, BIMPORTE.EditValueChanged
        If Calcula = False Then Exit Sub
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If IsNothing(AIMPORTE.EditValue) Then AIMPORTE.EditValue = 0
        If IsNothing(BIMPORTE.EditValue) Then BIMPORTE.EditValue = 0
        'Exit Sub
        If CStr(AIMPORTE.EditValue) = "" Then AIMPORTE.EditValue = 0
        If CStr(BIMPORTE.EditValue) = "" Then BIMPORTE.EditValue = 0
        If CStr(COMP.EditValue) = "" Then COMP.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
    End Sub

    Private Sub PreNomAyuGral01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ValorA = 0.0
        ValorB = 0.0
        ValorC = 0.0
        ValorD = 0.0
        ValorE = 0.0
        ValorF = 0.0
        ValorG = 0.0
        ValorH = 0.0
        ValorI = 0.0
        ValorJ = 0.0
        ValorK = 0.0
        ValorL = 0.0
        Suma = 0
        Tot = 0
        Dim sql = "SELECT CLAVE, VALOR  FROM PreNominaClv  where clave in ('HN', 'HE', '03', '04','HN2C','HN3C','1', '3','4', '5', 'HN1', 'HN0','05','06','HE1') ORDER BY CLAVE"
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
                Case "HE"
                    ValorB = dtNom.Rows(x)("VALOR")
                Case "03"
                    ValorC = dtNom.Rows(x)("VALOR")
                Case "04"
                    ValorD = dtNom.Rows(x)("VALOR")
                Case "HN2C"
                    ValorE = dtNom.Rows(x)("VALOR")
                Case "HN3C"
                    ValorF = dtNom.Rows(x)("VALOR")
                Case "1"
                    ValorG = dtNom.Rows(x)("VALOR")
                Case "3"
                    ValorH = dtNom.Rows(x)("VALOR")
                Case "4"
                    ValorI = dtNom.Rows(x)("VALOR")
                Case "5"
                    ValorJ = dtNom.Rows(x)("VALOR")
                Case "HN0"
                    ValorK = dtNom.Rows(x)("VALOR")
                Case "HN1"
                    ValorL = dtNom.Rows(x)("VALOR")
                Case "05"
                    ValorM = dtNom.Rows(x)("VALOR")
                Case "06"
                    ValorN = dtNom.Rows(x)("VALOR")
                Case "HE1"
                    ValorO = dtNom.Rows(x)("VALOR")
            End Select
        Next 
        sql = "SELECT idRegNomina, NoEmpleado, idPuesto, Clave, Valor, D1A, D1B, D1C, D2A, D2B, D2C, D3A, D3B, D3C, D4A, D4B, D4C, D5A, D5B, D5C, D6A, D6B, D6C, D7A, D7B, D7C, isnull(Obs,'') as OBS " & _
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
        AD7A.EditValue = 0
        BD1A.EditValue = 0
        BD2A.EditValue = 0
        BD3A.EditValue = 0
        BD4A.EditValue = 0
        BD5A.EditValue = 0
        BD6A.EditValue = 0
        BD7A.EditValue = 0
        CD1A.EditValue = 0
        CD2A.EditValue = 0
        CD3A.EditValue = 0
        CD4A.EditValue = 0
        CD5A.EditValue = 0
        CD6A.EditValue = 0
        CD7A.EditValue = 0
        DD1A.EditValue = 0
        DD2A.EditValue = 0
        DD3A.EditValue = 0
        DD4A.EditValue = 0
        DD5A.EditValue = 0
        DD6A.EditValue = 0
        DD7A.EditValue = 0
        ED1A.EditValue = 0
        ED2A.EditValue = 0
        ED3A.EditValue = 0
        ED4A.EditValue = 0
        ED5A.EditValue = 0
        ED6A.EditValue = 0
        ED7A.EditValue = 0
        FD1A.EditValue = 0
        FD2A.EditValue = 0
        FD3A.EditValue = 0
        FD4A.EditValue = 0
        FD5A.EditValue = 0
        FD6A.EditValue = 0
        FD7A.EditValue = 0
        GD1A.EditValue = 0
        GD2A.EditValue = 0
        GD3A.EditValue = 0
        GD4A.EditValue = 0
        GD5A.EditValue = 0
        GD6A.EditValue = 0
        GD7A.EditValue = 0
        HD1A.EditValue = 0
        HD2A.EditValue = 0
        HD3A.EditValue = 0
        HD4A.EditValue = 0
        HD5A.EditValue = 0
        HD6A.EditValue = 0
        HD7A.EditValue = 0
        ID1A.EditValue = 0
        ID2A.EditValue = 0
        ID3A.EditValue = 0
        ID4A.EditValue = 0
        ID5A.EditValue = 0
        ID6A.EditValue = 0
        ID7A.EditValue = 0
        JD1A.EditValue = 0
        JD2A.EditValue = 0
        JD3A.EditValue = 0
        JD4A.EditValue = 0
        JD5A.EditValue = 0
        JD6A.EditValue = 0
        JD7A.EditValue = 0
        KD1A.EditValue = 0
        KD2A.EditValue = 0
        KD3A.EditValue = 0
        KD4A.EditValue = 0
        KD5A.EditValue = 0
        KD6A.EditValue = 0
        KD7A.EditValue = 0
        LD1A.EditValue = 0
        LD2A.EditValue = 0
        LD3A.EditValue = 0
        LD4A.EditValue = 0
        LD5A.EditValue = 0
        LD6A.EditValue = 0
        LD7A.EditValue = 0
        MD1A.EditValue = 0
        MD2A.EditValue = 0
        MD3A.EditValue = 0
        MD4A.EditValue = 0
        MD5A.EditValue = 0
        MD6A.EditValue = 0
        MD7A.EditValue = 0
        ND1A.EditValue = 0
        ND2A.EditValue = 0
        ND3A.EditValue = 0
        ND4A.EditValue = 0
        ND5A.EditValue = 0
        ND6A.EditValue = 0
        ND7A.EditValue = 0

        OD1A.EditValue = 0
        OD2A.EditValue = 0
        OD3A.EditValue = 0
        OD4A.EditValue = 0
        OD5A.EditValue = 0
        OD6A.EditValue = 0
        OD7A.EditValue = 0

        ADIAS.EditValue = 0
        BDIAS.EditValue = 0
        EDIAS.EditValue = 0
        FDIAS.EditValue = 0
        GDIAS.EditValue = 0
        HDIAS.EditValue = 0
        IDIAS.EditValue = 0
        JDIAS.EditValue = 0
        KDIAS.EditValue = 0
        LD1A.EditValue = 0
        LDIAS.EditValue = 0
        ODIAS.EditValue = 0
        'ACLV.EditValue = 0
        'BCLV.EditValue = 0
        AIMPORTE.EditValue = 0
        BIMPORTE.EditValue = 0
        EIMPORTE.EditValue = 0
        FIMPORTE.EditValue = 0
        GIMPORTE.EditValue = 0
        HIMPORTE.EditValue = 0
        IIMPORTE.EditValue = 0
        JIMPORTE.EditValue = 0
        KIMPORTE.EditValue = 0
        LIMPORTE.EditValue = 0
        OIMPORTE.EditValue = 0
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
                        AD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "HE"
                        BCLV.EditValue = dtPre.Rows(cont)("Clave")
                        ValorB = dtPre.Rows(cont)("Valor")
                        BD1A.EditValue = dtPre.Rows(cont)("D1A")
                        BD2A.EditValue = dtPre.Rows(cont)("D2A")
                        BD3A.EditValue = dtPre.Rows(cont)("D3A")
                        BD4A.EditValue = dtPre.Rows(cont)("D4A")
                        BD5A.EditValue = dtPre.Rows(cont)("D5A")
                        BD6A.EditValue = dtPre.Rows(cont)("D6A")
                        BD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "03"
                        ValorC = dtPre.Rows(cont)("Valor")
                        CD1A.EditValue = dtPre.Rows(cont)("D1A")
                        CD2A.EditValue = dtPre.Rows(cont)("D2A")
                        CD3A.EditValue = dtPre.Rows(cont)("D3A")
                        CD4A.EditValue = dtPre.Rows(cont)("D4A")
                        CD5A.EditValue = dtPre.Rows(cont)("D5A")
                        CD6A.EditValue = dtPre.Rows(cont)("D6A")
                        CD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "04"
                        ValorD = dtPre.Rows(cont)("Valor")
                        DD1A.EditValue = dtPre.Rows(cont)("D1A")
                        DD2A.EditValue = dtPre.Rows(cont)("D2A")
                        DD3A.EditValue = dtPre.Rows(cont)("D3A")
                        DD4A.EditValue = dtPre.Rows(cont)("D4A")
                        DD5A.EditValue = dtPre.Rows(cont)("D5A")
                        DD6A.EditValue = dtPre.Rows(cont)("D6A")
                        DD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "HN2C"
                        ValorE = dtPre.Rows(cont)("Valor")
                        ED1A.EditValue = dtPre.Rows(cont)("D1A")
                        ED2A.EditValue = dtPre.Rows(cont)("D2A")
                        ED3A.EditValue = dtPre.Rows(cont)("D3A")
                        ED4A.EditValue = dtPre.Rows(cont)("D4A")
                        ED5A.EditValue = dtPre.Rows(cont)("D5A")
                        ED6A.EditValue = dtPre.Rows(cont)("D6A")
                        ED7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "HN3C"
                        ValorF = dtPre.Rows(cont)("Valor")
                        FD1A.EditValue = dtPre.Rows(cont)("D1A")
                        FD2A.EditValue = dtPre.Rows(cont)("D2A")
                        FD3A.EditValue = dtPre.Rows(cont)("D3A")
                        FD4A.EditValue = dtPre.Rows(cont)("D4A")
                        FD5A.EditValue = dtPre.Rows(cont)("D5A")
                        FD6A.EditValue = dtPre.Rows(cont)("D6A")
                        FD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "1"
                        ValorG = dtPre.Rows(cont)("Valor")
                        GD1A.EditValue = dtPre.Rows(cont)("D1A")
                        GD2A.EditValue = dtPre.Rows(cont)("D2A")
                        GD3A.EditValue = dtPre.Rows(cont)("D3A")
                        GD4A.EditValue = dtPre.Rows(cont)("D4A")
                        GD5A.EditValue = dtPre.Rows(cont)("D5A")
                        GD6A.EditValue = dtPre.Rows(cont)("D6A")
                        GD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "3"
                        ValorH = dtPre.Rows(cont)("Valor")
                        HD1A.EditValue = dtPre.Rows(cont)("D1A")
                        HD2A.EditValue = dtPre.Rows(cont)("D2A")
                        HD3A.EditValue = dtPre.Rows(cont)("D3A")
                        HD4A.EditValue = dtPre.Rows(cont)("D4A")
                        HD5A.EditValue = dtPre.Rows(cont)("D5A")
                        HD6A.EditValue = dtPre.Rows(cont)("D6A")
                        HD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "4"
                        ValorI = dtPre.Rows(cont)("Valor")
                        ID1A.EditValue = dtPre.Rows(cont)("D1A")
                        ID2A.EditValue = dtPre.Rows(cont)("D2A")
                        ID3A.EditValue = dtPre.Rows(cont)("D3A")
                        ID4A.EditValue = dtPre.Rows(cont)("D4A")
                        ID5A.EditValue = dtPre.Rows(cont)("D5A")
                        ID6A.EditValue = dtPre.Rows(cont)("D6A")
                        ID7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "5"
                        ValorJ = dtPre.Rows(cont)("Valor")
                        JD1A.EditValue = dtPre.Rows(cont)("D1A")
                        JD2A.EditValue = dtPre.Rows(cont)("D2A")
                        JD3A.EditValue = dtPre.Rows(cont)("D3A")
                        JD4A.EditValue = dtPre.Rows(cont)("D4A")
                        JD5A.EditValue = dtPre.Rows(cont)("D5A")
                        JD6A.EditValue = dtPre.Rows(cont)("D6A")
                        JD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "HN0"
                        ValorK = dtPre.Rows(cont)("Valor")
                        KD1A.EditValue = dtPre.Rows(cont)("D1A")
                        KD2A.EditValue = dtPre.Rows(cont)("D2A")
                        KD3A.EditValue = dtPre.Rows(cont)("D3A")
                        KD4A.EditValue = dtPre.Rows(cont)("D4A")
                        KD5A.EditValue = dtPre.Rows(cont)("D5A")
                        KD6A.EditValue = dtPre.Rows(cont)("D6A")
                    Case "HN1"
                        ValorL = dtPre.Rows(cont)("Valor")
                        LD1A.EditValue = dtPre.Rows(cont)("D1A")
                        LD2A.EditValue = dtPre.Rows(cont)("D2A")
                        LD3A.EditValue = dtPre.Rows(cont)("D3A")
                        LD4A.EditValue = dtPre.Rows(cont)("D4A")
                        LD5A.EditValue = dtPre.Rows(cont)("D5A")
                        LD6A.EditValue = dtPre.Rows(cont)("D6A")
                        LD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "05"
                        ValorM = dtPre.Rows(cont)("Valor")
                        MD1A.EditValue = dtPre.Rows(cont)("D1A")
                        MD2A.EditValue = dtPre.Rows(cont)("D2A")
                        MD3A.EditValue = dtPre.Rows(cont)("D3A")
                        MD4A.EditValue = dtPre.Rows(cont)("D4A")
                        MD5A.EditValue = dtPre.Rows(cont)("D5A")
                        MD6A.EditValue = dtPre.Rows(cont)("D6A")
                        MD7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "06"
                        ValorN = dtPre.Rows(cont)("Valor")
                        ND1A.EditValue = dtPre.Rows(cont)("D1A")
                        ND2A.EditValue = dtPre.Rows(cont)("D2A")
                        ND3A.EditValue = dtPre.Rows(cont)("D3A")
                        ND4A.EditValue = dtPre.Rows(cont)("D4A")
                        ND5A.EditValue = dtPre.Rows(cont)("D5A")
                        ND6A.EditValue = dtPre.Rows(cont)("D6A")
                        ND7A.EditValue = dtPre.Rows(cont)("D7A")
                    Case "HE1"
                        ValorO = dtPre.Rows(cont)("Valor")
                        OD1A.EditValue = dtPre.Rows(cont)("D1A")
                        OD2A.EditValue = dtPre.Rows(cont)("D2A")
                        OD3A.EditValue = dtPre.Rows(cont)("D3A")
                        OD4A.EditValue = dtPre.Rows(cont)("D4A")
                        OD5A.EditValue = dtPre.Rows(cont)("D5A")
                        OD6A.EditValue = dtPre.Rows(cont)("D6A")
                        OD7A.EditValue = dtPre.Rows(cont)("D7A")
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
        'CalculaD()
        CalculaE()
        CalculaF()
        CalculaG()
        CalculaH()
        CalculaI() 
        CalculaJ()
        CalculaK()
        CalculaL()
        CalculaO()
        'CalculaM()
        'CalculaN()
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
        If Not IsNothing(AD7A.EditValue) Then
            If Not IsNumeric(AD7A.EditValue) Then AD7A.EditValue = 0
            If AD7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + AD7A.EditValue
            End If
        End If
        ADIAS.EditValue = Suma
        ATOT.EditValue = Tot
        AIMPORTE.EditValue = CDbl(ValorA * Tot)
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If Not IsNumeric(COMP.EditValue) Then COMP.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Public Sub CalculaO()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(OD1A.EditValue) Then
            If Not IsNumeric(OD1A.EditValue) Then OD1A.EditValue = 0
            If OD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + OD1A.EditValue
            End If
        End If
        If Not IsNothing(OD2A.EditValue) Then
            If Not IsNumeric(OD2A.EditValue) Then OD2A.EditValue = 0
            If OD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + OD2A.EditValue
            End If
        End If
        If Not IsNothing(OD3A.EditValue) Then
            If Not IsNumeric(OD3A.EditValue) Then OD3A.EditValue = 0
            If OD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + OD3A.EditValue
            End If
        End If
        If Not IsNothing(OD4A.EditValue) Then
            If Not IsNumeric(OD4A.EditValue) Then OD4A.EditValue = 0
            If OD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + OD4A.EditValue
            End If
        End If
        If Not IsNothing(OD5A.EditValue) Then
            If Not IsNumeric(OD5A.EditValue) Then OD5A.EditValue = 0
            If OD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + OD5A.EditValue
            End If
        End If
        If Not IsNothing(OD6A.EditValue) Then
            If Not IsNumeric(OD6A.EditValue) Then OD6A.EditValue = 0
            If OD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + OD6A.EditValue
            End If
        End If
        If Not IsNothing(OD7A.EditValue) Then
            If Not IsNumeric(OD7A.EditValue) Then OD7A.EditValue = 0
            If OD7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + OD7A.EditValue
            End If
        End If
        ODIAS.EditValue = Suma
        OTOT.EditValue = Tot
        OIMPORTE.EditValue = CDbl(ValorO * Tot)
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If Not IsNumeric(COMP.EditValue) Then COMP.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Private Sub CD1A_EditValueChanged(Sender As System.Object, e As System.EventArgs) Handles CD1A.EditValueChanged, CD2A.EditValueChanged, CD3A.EditValueChanged, CD4A.EditValueChanged, CD5A.EditValueChanged, CD6A.EditValueChanged, CD7A.EditValueChanged
        CalculaC()
    End Sub

    Private Sub DD1A_EditValueChanged(Sender As System.Object, e As System.EventArgs) Handles DD1A.EditValueChanged, DD2A.EditValueChanged, DD3A.EditValueChanged, DD4A.EditValueChanged, DD5A.EditValueChanged, DD6A.EditValueChanged, DD7A.EditValueChanged
        CalculaD()
    End Sub

    Private Sub CalculaD()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(DD1A.EditValue) Then
            If DD1A.EditValue - 400 > 0 Then
                Suma = ((DD1A.EditValue - 400) / 30) * ValorD
                Tot = Tot + Suma
                'Else
                '    DD1A.EditValue = 0
            End If
        End If
        If Not IsNothing(DD2A.EditValue) Then
            If DD2A.EditValue - 400 > 0 Then
                Suma = ((DD2A.EditValue - 400) / 30) * ValorD
                Tot = Tot + Suma
                'Else
                '    DD2A.EditValue = 0
            End If
        End If
        If Not IsNothing(DD3A.EditValue) Then
            If DD3A.EditValue - 400 > 0 Then
                Suma = ((DD3A.EditValue - 400) / 30) * ValorD
                Tot = Tot + Suma
                'Else
                '    DD3A.EditValue = 0
            End If
        End If
        If Not IsNothing(DD4A.EditValue) Then
            If DD4A.EditValue - 400 > 0 Then
                Suma = ((DD4A.EditValue - 400) / 30) * ValorD
                Tot = Tot + Suma
                'Else
                '    DD4A.EditValue = 0
            End If
        End If
        If Not IsNothing(DD5A.EditValue) Then
            If DD5A.EditValue - 400 > 0 Then
                Suma = ((DD5A.EditValue - 400) / 30) * ValorD
                Tot = Tot + Suma
                'Else
                '    DD5A.EditValue = 0
            End If
        End If
        If Not IsNothing(DD6A.EditValue) Then
            If DD6A.EditValue - 400 > 0 Then
                Suma = ((DD6A.EditValue - 400) / 30) * ValorD
                Tot = Tot + Suma
                'Else
                '    DD6A.EditValue = 0
            End If
        End If
        If Not IsNothing(DD7A.EditValue) Then
            If DD7A.EditValue - 400 > 0 Then
                Suma = ((DD7A.EditValue - 400) / 30) * ValorD
                Tot = Tot + Suma
                'Else
                '    DD7A.EditValue = 0
            End If
        End If
        COMP.EditValue = Tot
        CalculoDiario()
    End Sub

    Private Sub CalculaC()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(CD1A.EditValue) Then
            If CD1A.EditValue - 270 > 0 Then
                Suma = ((CD1A.EditValue - 270) / 30) * ValorC
                Tot = Tot + Suma
                'Else
                '    DD1A.EditValue = 0
            End If
        End If
        If Not IsNothing(CD2A.EditValue) Then
            If CD2A.EditValue - 270 > 0 Then
                Suma = ((CD2A.EditValue - 270) / 30) * ValorC
                Tot = Tot + Suma
                'Else
                '    DD2A.EditValue = 0
            End If
        End If
        If Not IsNothing(CD3A.EditValue) Then
            If CD3A.EditValue - 270 > 0 Then
                Suma = ((CD3A.EditValue - 270) / 30) * ValorC
                Tot = Tot + Suma
                'Else
                '    DD3A.EditValue = 0
            End If
        End If
        If Not IsNothing(CD4A.EditValue) Then
            If CD4A.EditValue - 270 > 0 Then
                Suma = ((CD4A.EditValue - 270) / 30) * ValorC
                Tot = Tot + Suma
                'Else
                '    DD4A.EditValue = 0
            End If
        End If
        If Not IsNothing(CD5A.EditValue) Then
            If CD5A.EditValue - 270 > 0 Then
                Suma = ((CD5A.EditValue - 270) / 30) * ValorC
                Tot = Tot + Suma
                'Else
                '    DD5A.EditValue = 0
            End If
        End If
        If Not IsNothing(CD6A.EditValue) Then
            If CD6A.EditValue - 270 > 0 Then
                Suma = ((CD6A.EditValue - 270) / 30) * ValorC
                Tot = Tot + Suma
                'Else
                '    DD6A.EditValue = 0
            End If
        End If
        If Not IsNothing(CD7A.EditValue) Then
            If CD7A.EditValue - 270 > 0 Then
                Suma = ((CD7A.EditValue - 270) / 30) * ValorC
                Tot = Tot + Suma
                'Else
                '    DD7A.EditValue = 0
            End If
        End If
        If Tot <> 0 Then
            COMP.EditValue = Tot
        Else
            If (CD1A.EditValue + CD2A.EditValue + CD3A.EditValue + CD4A.EditValue + CD5A.EditValue + CD6A.EditValue) > 0 Then COMP.EditValue = 0
        End If
        CalculoDiario()
    End Sub

    Private Sub AD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles AD1A.EditValueChanged, AD2A.EditValueChanged, AD3A.EditValueChanged, AD4A.EditValueChanged, AD5A.EditValueChanged, AD6A.EditValueChanged, AD7A.EditValueChanged
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
        If Not IsNothing(BD7A.EditValue) Then
            If Not IsNumeric(BD7A.EditValue) Then BD7A.EditValue = 0
            If BD7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + BD7A.EditValue
            End If
        End If
        BDIAS.EditValue = Suma
        BTOT.EditValue = Tot
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If Not IsNumeric(COMP.EditValue) Then COMP.EditValue = 0
        BIMPORTE.EditValue = CDbl(ValorB * Tot)
        CalculoDiario()
    End Sub

    Private Sub BD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles BD1A.EditValueChanged, BD2A.EditValueChanged, BD3A.EditValueChanged, BD4A.EditValueChanged, BD5A.EditValueChanged, BD6A.EditValueChanged, BD7A.EditValueChanged
        CalculaB()
    End Sub

    Private Sub bGuardar_Click(sender As System.Object, e As System.EventArgs) Handles bGuardar.Click
        Dim SQLUP
        If Nuevo = True Then
            SQLUP = "Insert into PreNominaDtl " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HN', " & ValorA.ToString & ", " & AD1A.EditValue.ToString & ", 0, 0, " & _
                AD2A.EditValue.ToString & ", 0, 0, " & AD3A.EditValue.ToString & ", 0, 0, " & AD4A.EditValue.ToString & _
                ", 0, 0, " & AD5A.EditValue.ToString & ", 0, 0, " & AD6A.EditValue.ToString & ", 0, 0, " & AD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HE', " & ValorB.ToString & ", " & BD1A.EditValue.ToString & ", 0, 0, " & _
                BD2A.EditValue.ToString & ", 0, 0, " & BD3A.EditValue.ToString & ", 0, 0, " & BD4A.EditValue.ToString & _
                ", 0, 0, " & BD5A.EditValue.ToString & ", 0, 0, " & BD6A.EditValue.ToString & ", 0, 0, " & BD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '03', " & ValorC.ToString & ", " & CD1A.EditValue.ToString & ", 0, 0, " & _
                CD2A.EditValue.ToString & ", 0, 0, " & CD3A.EditValue.ToString & ", 0, 0, " & CD4A.EditValue.ToString & _
                ", 0, 0, " & CD5A.EditValue.ToString & ", 0, 0, " & CD6A.EditValue.ToString & ", 0, 0, " & CD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '04', " & ValorD.ToString & ", " & DD1A.EditValue.ToString & ", 0, 0, " & _
                DD2A.EditValue.ToString & ", 0, 0, " & DD3A.EditValue.ToString & ", 0, 0, " & DD4A.EditValue.ToString & _
                ", 0, 0, " & DD5A.EditValue.ToString & ", 0, 0, " & DD6A.EditValue.ToString & ", 0, 0, " & DD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HN2C', " & ValorE.ToString & ", " & ED1A.EditValue.ToString & ", 0, 0, " & _
                ED2A.EditValue.ToString & ", 0, 0, " & ED3A.EditValue.ToString & ", 0, 0, " & ED4A.EditValue.ToString & _
                ", 0, 0, " & ED5A.EditValue.ToString & ", 0, 0, " & ED6A.EditValue.ToString & ", 0, 0, " & ED7A.EditValue.ToString & ", 0, 0,''  " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HN3C', " & ValorF.ToString & ", " & FD1A.EditValue.ToString & ", 0, 0, " & _
                FD2A.EditValue.ToString & ", 0, 0, " & FD3A.EditValue.ToString & ", 0, 0, " & FD4A.EditValue.ToString & _
                ", 0, 0, " & FD5A.EditValue.ToString & ", 0, 0, " & FD6A.EditValue.ToString & ", 0, 0, " & FD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '1', " & ValorG.ToString & ", " & GD1A.EditValue.ToString & ", 0, 0, " & _
                GD2A.EditValue.ToString & ", 0, 0, " & GD3A.EditValue.ToString & ", 0, 0, " & GD4A.EditValue.ToString & _
                ", 0, 0, " & GD5A.EditValue.ToString & ", 0, 0, " & GD6A.EditValue.ToString & ", 0, 0, " & GD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '3', " & ValorH.ToString & ", " & HD1A.EditValue.ToString & ", 0, 0, " & _
                HD2A.EditValue.ToString & ", 0, 0, " & HD3A.EditValue.ToString & ", 0, 0, " & HD4A.EditValue.ToString & _
                ", 0, 0, " & HD5A.EditValue.ToString & ", 0, 0, " & HD6A.EditValue.ToString & ", 0, 0, " & HD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '4', " & ValorI.ToString & ", " & ID1A.EditValue.ToString & ", 0, 0, " & _
                ID2A.EditValue.ToString & ", 0, 0, " & ID3A.EditValue.ToString & ", 0, 0, " & ID4A.EditValue.ToString & _
                ", 0, 0, " & ID5A.EditValue.ToString & ", 0, 0, " & ID6A.EditValue.ToString & ", 0, 0, " & ID7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '5', " & ValorJ.ToString & ", " & JD1A.EditValue.ToString & ", 0, 0, " & _
                JD2A.EditValue.ToString & ", 0, 0, " & JD3A.EditValue.ToString & ", 0, 0, " & JD4A.EditValue.ToString & _
                ", 0, 0, " & JD5A.EditValue.ToString & ", 0, 0, " & JD6A.EditValue.ToString & ", 0, 0, " & JD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HN0', " & ValorK.ToString & ", " & KD1A.EditValue.ToString & ", 0, 0, " & _
                KD2A.EditValue.ToString & ", 0, 0, " & KD3A.EditValue.ToString & ", 0, 0, " & KD4A.EditValue.ToString & _
                ", 0, 0, " & KD5A.EditValue.ToString & ", 0, 0, " & KD6A.EditValue.ToString & ", 0, 0, " & KD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HN1', " & ValorL.ToString & ", " & LD1A.EditValue.ToString & ", 0, 0, " & _
                LD2A.EditValue.ToString & ", 0, 0, " & LD3A.EditValue.ToString & ", 0, 0, " & LD4A.EditValue.ToString & _
                ", 0, 0, " & LD5A.EditValue.ToString & ", 0, 0, " & LD6A.EditValue.ToString & ", 0, 0, " & LD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '05', " & ValorM.ToString & ", " & MD1A.EditValue.ToString & ", 0, 0, " & _
                MD2A.EditValue.ToString & ", 0, 0, " & MD3A.EditValue.ToString & ", 0, 0, " & MD4A.EditValue.ToString & _
                ", 0, 0, " & MD5A.EditValue.ToString & ", 0, 0, " & MD6A.EditValue.ToString & ", 0, 0, " & MD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '06', " & ValorN.ToString & ", " & ND1A.EditValue.ToString & ", 0, 0, " & _
                ND2A.EditValue.ToString & ", 0, 0, " & ND3A.EditValue.ToString & ", 0, 0, " & ND4A.EditValue.ToString & _
                ", 0, 0, " & ND5A.EditValue.ToString & ", 0, 0, " & ND6A.EditValue.ToString & ", 0, 0, " & ND7A.EditValue.ToString & ", 0, 0,'' " & _
                 "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', 'HE1', " & ValorO.ToString & ", " & OD1A.EditValue.ToString & ", 0, 0, " & _
                OD2A.EditValue.ToString & ", 0, 0, " & OD3A.EditValue.ToString & ", 0, 0, " & OD4A.EditValue.ToString & _
                ", 0, 0, " & OD5A.EditValue.ToString & ", 0, 0, " & OD6A.EditValue.ToString & ", 0, 0, " & OD7A.EditValue.ToString & ", 0, 0,'' " & _
                "Union all " & _
                "Select " & idRegNomina & ", " & NoEmpleado & ", '" & IDTipo & "', '00', " & COMP.EditValue & ", 0, 0, 0, 0, 0, 0, 0, 0, 0, " & _
                "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, '" & eObs.Text & "'"
        Else
            SQLUP = " update PreNominaDtl set " & _
                " D1A = " & AD1A.EditValue.ToString & ", D2A = " & AD2A.EditValue.ToString & ", D3A = " & AD3A.EditValue.ToString & _
                ", D4A = " & AD4A.EditValue.ToString & ", D5A = " & AD5A.EditValue.ToString & ", D6A = " & AD6A.EditValue.ToString & ", D7A = " & AD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & BD1A.EditValue.ToString & ", D2A = " & BD2A.EditValue.ToString & ", D3A = " & BD3A.EditValue.ToString & _
                ", D4A = " & BD4A.EditValue.ToString & ", D5A = " & BD5A.EditValue.ToString & ", D6A = " & BD6A.EditValue.ToString & ", D7A = " & BD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HE' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & CD1A.EditValue.ToString & ", D2A = " & CD2A.EditValue.ToString & ", D3A = " & CD3A.EditValue.ToString & _
                ", D4A = " & CD4A.EditValue.ToString & ", D5A = " & CD5A.EditValue.ToString & ", D6A = " & CD6A.EditValue.ToString & ", D7A = " & CD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '03' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & DD1A.EditValue.ToString & ", D2A = " & DD2A.EditValue.ToString & ", D3A = " & DD3A.EditValue.ToString & _
                ", D4A = " & DD4A.EditValue.ToString & ", D5A = " & DD5A.EditValue.ToString & ", D6A = " & DD6A.EditValue.ToString & ", D7A = " & DD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '04' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & ED1A.EditValue.ToString & ", D2A = " & ED2A.EditValue.ToString & ", D3A = " & ED3A.EditValue.ToString & _
                ", D4A = " & ED4A.EditValue.ToString & ", D5A = " & ED5A.EditValue.ToString & ", D6A = " & ED6A.EditValue.ToString & ", D7A = " & ED7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN2C' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & FD1A.EditValue.ToString & ", D2A = " & FD2A.EditValue.ToString & ", D3A = " & FD3A.EditValue.ToString & _
                ", D4A = " & FD4A.EditValue.ToString & ", D5A = " & FD5A.EditValue.ToString & ", D6A = " & FD6A.EditValue.ToString & ", D7A = " & FD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN3C' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & GD1A.EditValue.ToString & ", D2A = " & GD2A.EditValue.ToString & ", D3A = " & GD3A.EditValue.ToString & _
                ", D4A = " & GD4A.EditValue.ToString & ", D5A = " & GD5A.EditValue.ToString & ", D6A = " & GD6A.EditValue.ToString & ", D7A = " & GD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '1' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & HD1A.EditValue.ToString & ", D2A = " & HD2A.EditValue.ToString & ", D3A = " & HD3A.EditValue.ToString & _
                ", D4A = " & HD4A.EditValue.ToString & ", D5A = " & HD5A.EditValue.ToString & ", D6A = " & HD6A.EditValue.ToString & ", D7A = " & HD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '3' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & ID1A.EditValue.ToString & ", D2A = " & ID2A.EditValue.ToString & ", D3A = " & ID3A.EditValue.ToString & _
                ", D4A = " & ID4A.EditValue.ToString & ", D5A = " & ID5A.EditValue.ToString & ", D6A = " & ID6A.EditValue.ToString & ", D7A = " & ID7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '4' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & JD1A.EditValue.ToString & ", D2A = " & JD2A.EditValue.ToString & ", D3A = " & JD3A.EditValue.ToString & _
                ", D4A = " & JD4A.EditValue.ToString & ", D5A = " & JD5A.EditValue.ToString & ", D6A = " & JD6A.EditValue.ToString & ", D7A = " & JD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '5' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & KD1A.EditValue.ToString & ", D2A = " & KD2A.EditValue.ToString & ", D3A = " & KD3A.EditValue.ToString & _
                ", D4A = " & KD4A.EditValue.ToString & ", D5A = " & KD5A.EditValue.ToString & ", D6A = " & KD6A.EditValue.ToString & ", D7A = " & KD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN0' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & LD1A.EditValue.ToString & ", D2A = " & LD2A.EditValue.ToString & ", D3A = " & LD3A.EditValue.ToString & _
                ", D4A = " & LD4A.EditValue.ToString & ", D5A = " & LD5A.EditValue.ToString & ", D6A = " & LD6A.EditValue.ToString & ", D7A = " & LD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HN1' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & MD1A.EditValue.ToString & ", D2A = " & MD2A.EditValue.ToString & ", D3A = " & MD3A.EditValue.ToString & _
                ", D4A = " & MD4A.EditValue.ToString & ", D5A = " & MD5A.EditValue.ToString & ", D6A = " & MD6A.EditValue.ToString & ", D7A = " & MD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '05' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & ND1A.EditValue.ToString & ", D2A = " & ND2A.EditValue.ToString & ", D3A = " & ND3A.EditValue.ToString & _
                ", D4A = " & ND4A.EditValue.ToString & ", D5A = " & ND5A.EditValue.ToString & ", D6A = " & ND6A.EditValue.ToString & ", D7A = " & ND7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = '06' " & _
                "  " & _
                " update PreNominaDtl set " & _
                " D1A = " & OD1A.EditValue.ToString & ", D2A = " & OD2A.EditValue.ToString & ", D3A = " & OD3A.EditValue.ToString & _
                ", D4A = " & OD4A.EditValue.ToString & ", D5A = " & OD5A.EditValue.ToString & ", D6A = " & OD6A.EditValue.ToString & ", D7A = " & OD7A.EditValue.ToString & _
                " where idRegNomina = " & idRegNomina & " and NoEmpleado = " & NoEmpleado & " and Clave = 'HE1' " & _
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
            Nuevo = False
            MsgBox("Registro Guardado con éxito.")
        Catch ex As Exception
            Transac.Rollback()
            MsgBox(" Ocurrio un error al gardar la información" + ex.Message, MsgBoxStyle.Critical, Empresa & "")
            Exit Sub
        End Try
    End Sub

    Private Sub ED1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ED1A.EditValueChanged, ED2A.EditValueChanged, ED3A.EditValueChanged, ED4A.EditValueChanged, ED5A.EditValueChanged, ED6A.EditValueChanged, ED7A.EditValueChanged
        CalculaE()
    End Sub

    Private Sub CalculaE()
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
        If Not IsNothing(ED7A.EditValue) Then
            If Not IsNumeric(ED7A.EditValue) Then ED7A.EditValue = 0
            If ED7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ED7A.EditValue
            End If
        End If
        EDIAS.EditValue = Suma
        ETOT.EditValue = Tot
        EIMPORTE.EditValue = CDbl(ValorE * Tot)
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If Not IsNumeric(COMP.EditValue) Then COMP.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Private Sub CalculaF()
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
        If Not IsNothing(FD7A.EditValue) Then
            If Not IsNumeric(FD7A.EditValue) Then FD7A.EditValue = 0
            If FD7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + FD7A.EditValue
            End If
        End If
        FDIAS.EditValue = Suma
        FTOT.EDitValue = Tot
        FIMPORTE.EditValue = CDbl(ValorF * Tot)
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If Not IsNumeric(COMP.EditValue) Then COMP.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Private Sub CalculaG()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(GD1A.EditValue) Then
            If GD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + GD1A.EditValue
            End If
        End If
        If Not IsNothing(GD2A.EditValue) Then
            If GD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + GD2A.EditValue
            End If
        End If
        If Not IsNothing(GD3A.EditValue) Then
            If GD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + GD3A.EditValue
            End If
        End If
        If Not IsNothing(GD4A.EditValue) Then
            If GD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + GD4A.EditValue
            End If
        End If
        If Not IsNothing(GD5A.EditValue) Then
            If GD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + GD5A.EditValue
            End If
        End If
        If Not IsNothing(GD6A.EditValue) Then
            If GD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + GD6A.EditValue
            End If
        End If
        If Not IsNothing(GD7A.EditValue) Then
            If GD7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + GD7A.EditValue
            End If
        End If
        GDIAS.EditValue = Suma
        GTOT.EditValue = Tot
        GIMPORTE.EditValue = CDbl(ValorG * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Private Sub CalculaH()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(HD1A.EditValue) Then
            If HD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + HD1A.EditValue
            End If
        End If
        If Not IsNothing(HD2A.EditValue) Then
            If HD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + HD2A.EditValue
            End If
        End If
        If Not IsNothing(HD3A.EditValue) Then
            If HD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + HD3A.EditValue
            End If
        End If
        If Not IsNothing(HD4A.EditValue) Then
            If HD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + HD4A.EditValue
            End If
        End If
        If Not IsNothing(HD5A.EditValue) Then
            If HD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + HD5A.EditValue
            End If
        End If
        If Not IsNothing(HD6A.EditValue) Then
            If HD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + HD6A.EditValue
            End If
        End If
        If Not IsNothing(HD7A.EditValue) Then
            If HD7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + HD7A.EditValue
            End If
        End If
        HDIAS.EditValue = Suma
        HTOT.EditValue = Tot
        HIMPORTE.EditValue = CDbl(ValorH * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Private Sub CalculaI()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(ID1A.EditValue) Then
            If ID1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ID1A.EditValue
            End If
        End If
        If Not IsNothing(ID2A.EditValue) Then
            If ID2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ID2A.EditValue
            End If
        End If
        If Not IsNothing(ID3A.EditValue) Then
            If ID3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ID3A.EditValue
            End If
        End If
        If Not IsNothing(ID4A.EditValue) Then
            If ID4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ID4A.EditValue
            End If
        End If
        If Not IsNothing(ID5A.EditValue) Then
            If ID5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ID5A.EditValue
            End If
        End If
        If Not IsNothing(ID6A.EditValue) Then
            If ID6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ID6A.EditValue
            End If
        End If
        If Not IsNothing(ID7A.EditValue) Then
            If ID7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + ID7A.EditValue
            End If
        End If
        IDIAS.EditValue = Suma
        ITOT.EditValue = Tot
        IIMPORTE.EditValue = CDbl(ValorI * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Private Sub CalculaJ()
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(JD1A.EditValue) Then
            If JD1A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + JD1A.EditValue
            End If
        End If
        If Not IsNothing(JD2A.EditValue) Then
            If JD2A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + JD2A.EditValue
            End If
        End If
        If Not IsNothing(JD3A.EditValue) Then
            If JD3A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + JD3A.EditValue
            End If
        End If
        If Not IsNothing(JD4A.EditValue) Then
            If JD4A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + JD4A.EditValue
            End If
        End If
        If Not IsNothing(JD5A.EditValue) Then
            If JD5A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + JD5A.EditValue
            End If
        End If
        If Not IsNothing(JD6A.EditValue) Then
            If JD6A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + JD6A.EditValue
            End If
        End If
        If Not IsNothing(JD7A.EditValue) Then
            If JD7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + JD7A.EditValue
            End If
        End If
        JDIAS.EditValue = Suma
        JTOT.EditValue = Tot
        JIMPORTE.EditValue = CDbl(ValorJ * Tot)
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Private Sub Calculak()
        If Calcula = False Then Exit Sub
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
        If Not IsNothing(KD7A.EditValue) Then
            If Not IsNumeric(KD7A.EditValue) Then KD7A.EditValue = 0
            If KD7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + KD7A.EditValue
            End If
        End If
        KDIAS.EditValue = Suma
        KTOT.EditValue = Tot
        KIMPORTE.EditValue = CDbl(ValorK * Tot)
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If Not IsNumeric(COMP.EditValue) Then COMP.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Private Sub CalculaL()
        If Calcula = False Then Exit Sub
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
        If Not IsNothing(LD7A.EditValue) Then
            If Not IsNumeric(LD7A.EditValue) Then LD7A.EditValue = 0
            If LD7A.EditValue > 0 Then
                Suma = Suma + 1
                Tot = Tot + LD7A.EditValue
            End If
        End If
        LDIAS.EditValue = Suma
        LTOT.EditValue = Tot
        LIMPORTE.EditValue = CDbl(ValorL * Tot)
        If IsNothing(COMP.EditValue) Then COMP.EditValue = 0
        If Not IsNumeric(LD1A.EditValue) Then LD1A.EditValue = 0
        eTotal.EditValue = CDbl(COMP.EditValue) + CDbl(AIMPORTE.EditValue) + CDbl(BIMPORTE.EditValue) + CDbl(EIMPORTE.EditValue) + CDbl(FIMPORTE.EditValue) + CDbl(GIMPORTE.EditValue) + CDbl(HIMPORTE.EditValue) + CDbl(IIMPORTE.EditValue) + CDbl(JIMPORTE.EditValue) + CDbl(KIMPORTE.EditValue) + CDbl(LIMPORTE.EditValue) + CDbl(OIMPORTE.EditValue)
        CalculoDiario()
    End Sub

    Private Sub FD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles FD1A.EditValueChanged, FD2A.EditValueChanged, FD3A.EditValueChanged, FD4A.EditValueChanged, FD5A.EditValueChanged, FD6A.EditValueChanged, FD7A.EditValueChanged
        CalculaF()
    End Sub

    Private Sub GD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles GD1A.EditValueChanged, GD2A.EditValueChanged, GD3A.EditValueChanged, GD4A.EditValueChanged, GD5A.EditValueChanged, GD6A.EditValueChanged, GD7A.EditValueChanged
        CalculaG()
    End Sub

    Private Sub HD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles HD1A.EditValueChanged, HD2A.EditValueChanged, HD3A.EditValueChanged, HD4A.EditValueChanged, HD5A.EditValueChanged, HD6A.EditValueChanged, HD7A.EditValueChanged
        CalculaH()
    End Sub

    Private Sub ID1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ID1A.EditValueChanged, ID2A.EditValueChanged, ID3A.EditValueChanged, ID4A.EditValueChanged, ID5A.EditValueChanged, ID6A.EditValueChanged, ID7A.EditValueChanged
        CalculaI()
    End Sub

    Private Sub JD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles JD1A.EditValueChanged, JD2A.EditValueChanged, JD3A.EditValueChanged, JD4A.EditValueChanged, JD5A.EditValueChanged, JD6A.EditValueChanged, JD7A.EditValueChanged
        CalculaJ()
    End Sub

    Private Sub KD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles KD1A.EditValueChanged, KD2A.EditValueChanged, KD3A.EditValueChanged, KD4A.EditValueChanged, KD5A.EditValueChanged, KD6A.EditValueChanged, KD7A.EditValueChanged
        Calculak()
    End Sub

    Private Sub LD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles LD1A.EditValueChanged, LD2A.EditValueChanged, LD3A.EditValueChanged, LD4A.EditValueChanged, LD5A.EditValueChanged, LD6A.EditValueChanged, LD7A.EditValueChanged
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
        AD7A.EditValue = 8
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
        ED7A.EditValue = 8
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
        FD7A.EditValue = 8
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
        KD7A.EditValue = 8
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
        LD7A.EditValue = 8
        Calcula = True
        CalculaL()
    End Sub

    Private Sub MD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles MD1A.EditValueChanged, MD2A.EditValueChanged, MD3A.EditValueChanged, MD4A.EditValueChanged, MD5A.EditValueChanged, MD6A.EditValueChanged, MD7A.EditValueChanged
        CalculaM()
    End Sub

    Private Sub ND1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles ND1A.EditValueChanged, ND2A.EditValueChanged, ND3A.EditValueChanged, ND4A.EditValueChanged, ND5A.EditValueChanged, ND6A.EditValueChanged, ND7A.EditValueChanged
        CalculaN()
    End Sub

    Private Sub CalculaM() Handles MD1A.EditValueChanged, MD2A.EditValueChanged, MD3A.EditValueChanged, MD4A.EditValueChanged, MD5A.EditValueChanged, MD6A.EditValueChanged
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(MD1A.EditValue) Then
            If MD1A.EditValue > 0 Then
                Suma = MD1A.EditValue
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(MD2A.EditValue) Then
            If MD2A.EditValue > 0 Then
                Suma = MD2A.EditValue
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(MD3A.EditValue) Then
            If MD3A.EditValue > 0 Then
                Suma = MD3A.EditValue
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(MD4A.EditValue) Then
            If MD4A.EditValue > 0 Then
                Suma = MD4A.EditValue
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(MD5A.EditValue) Then
            If MD5A.EditValue > 0 Then
                Suma = MD5A.EditValue
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(MD6A.EditValue) Then
            If MD6A.EditValue > 0 Then
                Suma = MD6A.EditValue
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(MD7A.EditValue) Then
            If MD7A.EditValue > 0 Then
                Suma = MD7A.EditValue
                Tot = Tot + Suma
            End If
        End If
        COMP.EditValue = Tot
        CalculoDiario()
    End Sub

    Private Sub CalculaN() Handles ND1A.EditValueChanged, ND2A.EditValueChanged, ND3A.EditValueChanged, ND4A.EditValueChanged, ND5A.EditValueChanged, ND6A.EditValueChanged
        If Calcula = False Then Exit Sub
        Suma = 0
        Tot = 0
        If Not IsNothing(ND1A.EditValue) Then
            If ND1A.EditValue > 0 Then
                Suma = ND1A.EditValue * ValorN
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(ND2A.EditValue) Then
            If ND2A.EditValue > 0 Then
                Suma = ND2A.EditValue * ValorN
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(ND3A.EditValue) Then
            If ND3A.EditValue > 0 Then
                Suma = ND3A.EditValue * ValorN
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(ND4A.EditValue) Then
            If ND4A.EditValue > 0 Then
                Suma = ND4A.EditValue * ValorN
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(ND5A.EditValue) Then
            If ND5A.EditValue > 0 Then
                Suma = ND5A.EditValue * ValorN
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(ND6A.EditValue) Then
            If ND6A.EditValue > 0 Then
                Suma = ND6A.EditValue * ValorN
                Tot = Tot + Suma
            End If
        End If
        If Not IsNothing(ND7A.EditValue) Then
            If ND7A.EditValue > 0 Then
                Suma = ND7A.EditValue * ValorN
                Tot = Tot + Suma
            End If
        End If
        COMP.EditValue = Tot
        CalculoDiario()
    End Sub

    Private Sub OD1A_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles OD1A.EditValueChanged, OD2A.EditValueChanged, OD3A.EditValueChanged, OD4A.EditValueChanged, OD5A.EditValueChanged, OD6A.EditValueChanged, OD7A.EditValueChanged
        CalculaO()
    End Sub
End Class