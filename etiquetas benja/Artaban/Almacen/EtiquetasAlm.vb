
Imports System.Math
Imports System.Data.SqlClient

Public Class EtiquetasAlm
    Public Tipo As Integer '1:MP Therapedic, 2: PT Espumas, 3:MP Therapedic Reimpresion
    Dim SQL = ""

    Private Sub EtiquetaMP_Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        MsgBox(Now)
        obtener_impresoras(cbImpresora)
        lbIUM.Text = ""
        Select Case Tipo
            Case 1 'MP Therapedic 
                BarCode1.Visible = False
                SQL = " select PartNum, PartDescription, IUM  from pilot.erp.part with(nolock)" & _
                " where company = 'ARTABAN2' and classid not in('','COL','ACE','JUE','BA','ENC','COB','EDR','FUN','FIB','PRO','SAB','TOA') " & _
                " and inactive = 0  ORDER BY ClassID, PartDescription "
                Me.Text = "Generar etiquetas de Materia Prima"
                CargaCombo(cbArticulo, SQL, "PartNum", "PartDescription")
            Case 2 'PT Espumas
                SQL = " select PartNum, PartDescription, IUM from pilot.erp.part with(nolock) " & _
                " where company = 'ARTABAN5' and classid = 'ES' and inactive = 0  ORDER BY PartDescription "
                Me.Text = "Generar etiquetas de Producto Terminado"

                CargaCombo(cbArticulo, SQL, "PartNum", "PartDescription")
            Case 3 'MP Therapedic Reimpresion
                BarCode1.Visible = False
                SQL = "select MP.Consecutivo,MP.PartNum as codigo,p.PartDescription as Descripcion,MP.Cantidad,IUM from Therapedic.dbo.EtiquetasMP mp with(nolock) " & _
                "left join pilot.erp.part p with(nolock)on p.PartNum=mp.PartNum COLLATE Modern_Spanish_CI_AS and p.Company='artaban2'"
                Me.Text = "Re Impresion de Materia Prima"
                CargaCombo(cbArticulo, SQL, "Consecutivo", "Consecutivo")
                cbIDArticulo.Visible = False
                LabelControl4.Visible = False
                LabelControl3.Visible = False
                eNoEtiquetas.Visible = False
                bImprimeP.Visible = False
                BarCode1.Visible = False
                BarCode1.Text = "190412000051000"
                LabelControl1.Text = "CODIGO DE BARRAS"
                'cbIDArticulo.Width = 325
        End Select

        cbIDArticulo.Properties.DataSource = cbArticulo.Properties.DataSource
        cbIDArticulo.Properties.ValueMember = cbArticulo.Properties.DisplayMember
        cbIDArticulo.Properties.DisplayMember = cbArticulo.Properties.ValueMember
    End Sub

    Private Sub EtiquetasAlm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMain.Visible = True
    End Sub

    Private Sub bGenerar_Click_1(sender As System.Object, e As System.EventArgs) Handles bGenerar.Click

        Dim Cantidad As Double = BarCode1.Text.Substring(BarCode1.Text.Length - 9, 9)
        Dim idArt = cbIDArticulo.Text
        Dim Articulo = cbArticulo.Text
        Dim IUM = lbIUM.Text


        'MsgBox(Articulo & " ," & eCantidad.Text.ToString)
        'MsgBox("IdArt: " & idArt & Chr(13) & "Articulo: " & Articulo & Chr(13) & "Cantidad: " & Cantidad & Chr(13) & "IUM: " & IUM)
        Dim SQL = "Select '*" & BarCode1.Text & "*' as CB, '" & idArt & "' as idArticulo, '" & Replace(Articulo, "'", "''") & "' as Articulo, " & Cantidad.ToString & " as Cantidad, '" & _
            IUM & "' as IUM, '" & Usuario & "' as idUsuario, '" & Now & "' as FechaImp"

        Dim RPT
        Select Case Tipo
            Case 1
                For x = 1 To eNoEtiquetas.Value
                    RPT = New EtMPTHQR
                    Dim cmd As New SqlCommand("SpGenEtiquetasMP", Conexion01)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@Opc", SqlDbType.Int).Value = 1 '1 = Genera Etiqueta MP
                    cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = idArt
                    cmd.Parameters.Add("@Cantidad", SqlDbType.Float).Value = Cantidad
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
                    cmd.Parameters.Add("@NEtiqueta", SqlDbType.VarChar, 50)
                    cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
                    cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
                    cmd.Parameters("@NEtiqueta").Direction = ParameterDirection.Output
                    cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
                    cmd.Parameters("@Msj").Direction = ParameterDirection.Output
                    If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                    cmd.ExecuteNonQuery()
                    If cmd.Parameters("@Resultado").Value.ToString = "1" Then
                        MsgBox(cmd.Parameters("@Msj").Value.ToString)
                        Exit Sub
                    End If
                    SQL = "Select '*" & cmd.Parameters("@NEtiqueta").Value.ToString & "*' as CB, '" & idArt & "' as idArticulo, '" & Replace(Articulo, "'", "''") & "' as Articulo, " & Cantidad.ToString & " as Cantidad, '" & _
                    IUM & "' as IUM, '" & Usuario & "' as idUsuario, '" & cmd.Parameters("@Msj").Value.ToString & "' as FechaImp"


                    If ImprimeCR(cbImpresora.Text, SQL, RPT, 1, Nothing, False) = False Then
                        MsgBox("Ocurrio un error al imprimir las etiquetas. Favor de informar al Administrador del sistema.")
                        Exit Sub
                    End If
                Next
                Exit Sub
            Case 2
                RPT = New ETPTEsp
            Case 3  'Reimpresion MP
                If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                Dim cmd As New SqlCommand("SpGenEtiquetasMPRE", Conexion01)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@CodBar", SqlDbType.BigInt).Value = Articulo
                cmd.Parameters.Add("@Cantidad", SqlDbType.Float).Value = Cantidad
                cmd.Parameters.Add("@fImpresion", SqlDbType.DateTime).Value = Now
                cmd.Parameters.Add("@UsuImpresion", SqlDbType.VarChar, 50).Value = Usuario
                cmd.ExecuteNonQuery()
                SQL = "select top 1 CONCAT('*',mp.Consecutivo,'*') as CB, mp.Partnum as idArticulo, p.PartDescription as Articulo," & eCantidad.Text.ToString & "as Cantidad,'" & IUM & " ' as IUM, '" & Usuario & "' as idUsuario, '" & Now & "' as FechaImp from therapedic.dbo.EtiquetasMP mp left join pilot.erp.part p with(nolock)on p.PartNum=mp.PartNum COLLATE Modern_Spanish_CI_AS and p.Company='artaban2' where mp.consecutivo=" & Articulo & ""
                RPT = New EtMPTHQR
                If ImprimeCR(cbImpresora.Text, SQL, RPT, 1, Nothing, False) = False Then
                    MsgBox("Ocurrio un error al imprimir las etiquetas. Favor de informar al Administrador del sistema3.")
                End If
                Exit Sub

        End Select


        If ImprimeCR(cbImpresora.Text, SQL, RPT, eNoEtiquetas.Value, Nothing, False) = False Then
            MsgBox("Ocurrio un error al imprimir las etiquetas. Favor de informar al Administrador del sistema.")
        End If
        ' MsgBox(SQL) 
    End Sub

    Private Sub eCantidad_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles eCantidad.KeyDown
        If Tipo = 1 Or Tipo = 3 Then Exit Sub
        If IsNumeric(eCantidad.Text) Then
            BarCode1.Text = cbArticulo.EditValue & ceros(eCantidad.Text, 7)
            BarCode1.Visible = True
        Else
            BarCode1.Visible = False
        End If
    End Sub

    Private Sub eCantidad_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles eCantidad.KeyUp
        If e.KeyCode = Keys.Enter Then Exit Sub
        RevisaCantidad()
    End Sub

    Private Sub cbArticulo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbArticulo.EditValueChanged

        lbIUM.Text = (cbIDArticulo.GetColumnValue("IUM"))
        If Tipo = 3 Then
            eCantidad.Text = (cbArticulo.GetColumnValue("Cantidad"))
            ' cbIDArticulo.Text = (cbIDArticulo.GetColumnValue("Partnum"))
            BarCode1.Visible = False
        Else
            eCantidad.Text = ""
            cbIDArticulo.EditValue = cbArticulo.Text
            RevisaCantidad()
            End If

    End Sub

    Private Sub RevisaCantidad()
        If IsNumeric(eCantidad.Text) Then
            If CDec(eCantidad.Text) > 999999.99 Then
                BarCode1.Visible = False
                bGenerar.Enabled = False
                bImprimeP.Enabled = False
                MsgBox("La Cantidad es superior a la que se puede ingresar (999999.99), Favor de verificar la información.")
                Exit Sub
            End If
            BarCode1.Text = cbArticulo.EditValue & ceros(Format(CDec(Round(Convert.ToDouble(eCantidad.Text), 2).ToString), "#.00"), 9)
            If Tipo <> 1 Then BarCode1.Visible = True
            bGenerar.Enabled = True
            bImprimeP.Enabled = True
        Else
            bGenerar.Enabled = False
            bImprimeP.Enabled = False
            BarCode1.Visible = False
        End If
    End Sub

    Private Sub cbIDArticulo_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles cbIDArticulo.EditValueChanged
        'RevisaCantidad()
        'lbIUM.Text = (cbArticulo.GetColumnValue("IUM"))
        'eCantidad.Text = ""
        cbArticulo.EditValue = cbIDArticulo.Text
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles bImprimeP.Click
        eNoEtiquetas.Value = 1
        Dim Cantidad As Double = BarCode1.Text.Substring(BarCode1.Text.Length - 9, 9)
        Dim idArt = cbIDArticulo.Text
        Dim Articulo = cbArticulo.Text
        Dim IUM = lbIUM.Text
        'MsgBox("IdArt: " & idArt & Chr(13) & "Articulo: " & Articulo & Chr(13) & "Cantidad: " & Cantidad & Chr(13) & "IUM: " & IUM)
        Dim SQL = "Select '*" & BarCode1.Text & "*' as CB, '" & idArt & "' as idArticulo, '" & Replace(Articulo, "'", "''") & "' as Articulo, " & Cantidad.ToString & " as Cantidad, '" & _
            IUM & "' as IUM, '" & Usuario & "' as idUsuario, '" & Now & "' as FechaImp"
        Dim RPT
        Select Case Tipo
            Case 1
                For x = 1 To eNoEtiquetas.Value
                    RPT = New EtMPTHQR
                    Dim cmd As New SqlCommand("SpGenEtiquetasMP", Conexion01)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@Opc", SqlDbType.Int).Value = 1 '1 = Genera Etiqueta MP
                    cmd.Parameters.Add("@SKU", SqlDbType.VarChar, 15).Value = idArt
                    cmd.Parameters.Add("@Cantidad", SqlDbType.Float).Value = Cantidad
                    cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = Usuario
                    cmd.Parameters.Add("@NEtiqueta", SqlDbType.VarChar, 50)
                    cmd.Parameters.Add("@Resultado", SqlDbType.VarChar, 1)
                    cmd.Parameters.Add("@Msj", SqlDbType.VarChar, 8000)
                    cmd.Parameters("@NEtiqueta").Direction = ParameterDirection.Output
                    cmd.Parameters("@Resultado").Direction = ParameterDirection.Output
                    cmd.Parameters("@Msj").Direction = ParameterDirection.Output
                    If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
                    cmd.ExecuteNonQuery()
                    If cmd.Parameters("@Resultado").Value.ToString = "1" Then
                        MsgBox(cmd.Parameters("@Msj").Value.ToString)
                        Exit Sub
                    End If
                    SQL = "Select '*" & cmd.Parameters("@NEtiqueta").Value.ToString & "*' as CB, '" & idArt & "' as idArticulo, '" & Replace(Articulo, "'", "''") & "' as Articulo, " & Cantidad.ToString & " as Cantidad, '" & _
                    IUM & "' as IUM, '" & Usuario & "' as idUsuario, '" & cmd.Parameters("@Msj").Value.ToString & "' as FechaImp"
                    PreviewCR(SQL, RPT)
                    'If ImprimeCR(cbImpresora.Text, SQL, RPT, 1, Nothing, False) = False Then
                    '    MsgBox("Ocurrio un error al imprimir las etiquetas. Favor de informar al Administrador del sistema.")
                    '    Exit Sub
                Next
                Exit Sub
            Case 2
                RPT = New ETPTEsp
            Case 3
                RPT = New EtMPTHQR
        End Select
        If ImprimeCR(cbImpresora.Text, SQL, RPT, eNoEtiquetas.Value, Nothing, False) = False Then
            MsgBox("Ocurrio un error al imprimir las etiquetas. Favor de informar al Administrador del sistema.")
        End If
    End Sub

    Private Sub BarCode1_Click(sender As System.Object, e As System.EventArgs) Handles BarCode1.Click

    End Sub
End Class