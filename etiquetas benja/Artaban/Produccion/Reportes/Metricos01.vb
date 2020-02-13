Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Drawing.Imaging

Public Class Metricos01

    Private Sub Metricos01_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FI.Text = DateAdd(DateInterval.Day, -Microsoft.VisualBasic.Weekday(Now, vbUseSystemDayOfWeek) + 2, (Now)).ToString.Substring(0, 10)
        FF.Text = DateAdd(DateInterval.Day, -Microsoft.VisualBasic.Weekday(Now, vbUseSystemDayOfWeek) + 8, (Now)).ToString.Substring(0, 10)
        lSemana.Text = "Semana " + ((DateDiff(DateInterval.WeekOfYear, CDate(FI.Text), New DateTime(CDate(FI.Text).Year, 1, 1)) * -1)).ToString
        CargaGraficas()
    End Sub
    Private Sub CargaGrafica1()
        Dim dt01 As New System.Data.DataTable
        Dim da01 As New SqlDataAdapter
        Dim SQLArmado = "exec spRepMetricosProd 1, '" + FI.Text + "', '" + FF.Text + "'"
        Dim cmdGrid As New SqlCommand(SQLArmado, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da01.SelectCommand = cmdGrid
        da01.Fill(dt01)
        Grafica01.Series(0).DataSource = dt01
        Grafica01.Series(0).ArgumentDataMember = "Dia"
        Grafica01.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica01.Series(0).ValueDataMembers.AddRange(New String() {"Surtido"})
        Grafica01.Series(1).DataSource = dt01
        Grafica01.Series(1).ArgumentDataMember = "Dia"
        Grafica01.Series(1).ValueScaleType = ScaleType.Numerical
        Grafica01.Series(1).ValueDataMembers.AddRange(New String() {"Tapizado"})
        Grafica01.Series(2).DataSource = dt01
        Grafica01.Series(2).ArgumentDataMember = "Dia"
        Grafica01.Series(2).ValueScaleType = ScaleType.Numerical
        Grafica01.Series(2).ValueDataMembers.AddRange(New String() {"PromedioSurtido"})
        Grafica01.Series(3).DataSource = dt01
        Grafica01.Series(3).ArgumentDataMember = "Dia"
        Grafica01.Series(3).ValueScaleType = ScaleType.Numerical
        Grafica01.Series(3).ValueDataMembers.AddRange(New String() {"PromedioTapizado"})
    End Sub

    Private Sub CargaGrafica2()
        Dim dt02 As New System.Data.DataTable
        Dim da02 As New SqlDataAdapter
        Dim SQLCostura = "exec spRepMetricosProd 2, '" + FI.Text + "', '" + FF.Text + "'"
        Dim cmdCostura As New SqlCommand(SQLCostura, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da02.SelectCommand = cmdCostura
        da02.Fill(dt02)
        Grafica02.Series(0).DataSource = dt02
        Grafica02.Series(0).ArgumentDataMember = "Dia"
        Grafica02.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica02.Series(0).ValueDataMembers.AddRange(New String() {"Surtido"})
        Grafica02.Series(1).DataSource = dt02
        Grafica02.Series(1).ArgumentDataMember = "Dia"
        Grafica02.Series(1).ValueScaleType = ScaleType.Numerical
        Grafica02.Series(1).ValueDataMembers.AddRange(New String() {"Costura"})
        Grafica02.Series(2).DataSource = dt02
        Grafica02.Series(2).ArgumentDataMember = "Dia"
        Grafica02.Series(2).ValueScaleType = ScaleType.Numerical
        Grafica02.Series(2).ValueDataMembers.AddRange(New String() {"PromedioSurtido"})
        Grafica02.Series(3).DataSource = dt02
        Grafica02.Series(3).ArgumentDataMember = "Dia"
        Grafica02.Series(3).ValueScaleType = ScaleType.Numerical
        Grafica02.Series(3).ValueDataMembers.AddRange(New String() {"PromedioCostura"})
    End Sub

    Private Sub CargaGrafica3()
        Dim dt03 As New System.Data.DataTable
        Dim da03 As New SqlDataAdapter
        Dim SQLCorte = "exec spRepMetricosProd 3, '" + FI.Text + "', '" + FF.Text + "'"
        Dim CMDCorte As New SqlCommand(SQLCorte, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da03.SelectCommand = CMDCorte
        da03.Fill(dt03)
        Grafica03.Series(0).DataSource = dt03
        Grafica03.Series(0).ArgumentDataMember = "Dia"
        Grafica03.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica03.Series(0).ValueDataMembers.AddRange(New String() {"Corte"})
    End Sub

    Private Sub CargaGrafica4() 'Corte de Piel
        Dim dt03 As New System.Data.DataTable
        Dim da03 As New SqlDataAdapter
        Dim SQLCorte = "exec spRepMetricosProd 4, '" + FI.Text + "', '" + FF.Text + "'"
        Dim CMDCorte As New SqlCommand(SQLCorte, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da03.SelectCommand = CMDCorte
        da03.Fill(dt03)
        Grafica04.Series(0).DataSource = dt03
        Grafica04.Series(0).ArgumentDataMember = "Dia"
        Grafica04.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica04.Series(0).ValueDataMembers.AddRange(New String() {"Corte"})
    End Sub

    Private Sub CargaGrafica5()
        Dim dt05 As New System.Data.DataTable
        Dim da05 As New SqlDataAdapter
        Dim SQLHab = "exec spRepMetricosProd 5, '" + FI.Text + "', '" + FF.Text + "'"
        Dim CMDHab As New SqlCommand(SQLHab, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da05.SelectCommand = CMDHab
        da05.Fill(dt05)
        Grafica05.Series(0).DataSource = dt05
        Grafica05.Series(0).ArgumentDataMember = "Dia"
        Grafica05.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica05.Series(0).ValueDataMembers.AddRange(New String() {"Corte"})
    End Sub

    Private Sub CargaGrafica6()
        Dim dt06 As New System.Data.DataTable
        Dim da06 As New SqlDataAdapter
        Dim SQLArm = "exec spRepMetricosProd 6, '" + FI.Text + "', '" + FF.Text + "'"
        Dim CMDArm As New SqlCommand(SQLArm, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da06.SelectCommand = CMDArm
        da06.Fill(dt06)
        Grafica06.Series(0).DataSource = dt06
        Grafica06.Series(0).ArgumentDataMember = "Dia"
        Grafica06.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica06.Series(0).ValueDataMembers.AddRange(New String() {"Corte"})
    End Sub

    Private Sub CargaGrafica7()
        Dim dt07 As New System.Data.DataTable
        Dim da07 As New SqlDataAdapter
        Dim SQLLlenado = "exec spRepMetricosProd 7, '" + FI.Text + "', '" + FF.Text + "'"
        Dim CMDArmado As New SqlCommand(SQLLlenado, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da07.SelectCommand = CMDArmado
        da07.Fill(dt07)
        Grafica07.Series(0).DataSource = dt07
        Grafica07.Series(0).ArgumentDataMember = "Dia"
        Grafica07.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica07.Series(0).ValueDataMembers.AddRange(New String() {"Corte"})
    End Sub

    Private Sub CargaGrafica8()
        Dim dt08 As New System.Data.DataTable
        Dim da08 As New SqlDataAdapter
        Dim SQLEnf = "exec spRepMetricosProd 8, '" + FI.Text + "', '" + FF.Text + "'"
        Dim CMDEnf As New SqlCommand(SQLEnf, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da08.SelectCommand = CMDEnf
        da08.Fill(dt08)
        Grafica08.Series(0).DataSource = dt08
        Grafica08.Series(0).ArgumentDataMember = "Dia"
        Grafica08.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica08.Series(0).ValueDataMembers.AddRange(New String() {"Corte"})
    End Sub

    Private Sub CargaGrafica9()
        Dim dt09 As New System.Data.DataTable
        Dim da09 As New SqlDataAdapter
        Dim SQLEnc = "exec spRepMetricosProd 9, '" + FI.Text + "', '" + FF.Text + "'"
        Dim CMDEnc As New SqlCommand(SQLEnc, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da09.SelectCommand = CMDEnc
        da09.Fill(dt09)
        Grafica09.Series(0).DataSource = dt09
        Grafica09.Series(0).ArgumentDataMember = "Dia"
        Grafica09.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica09.Series(0).ValueDataMembers.AddRange(New String() {"Corte"})
    End Sub

    Private Sub CargaGrafica10()
        Dim dt10 As New System.Data.DataTable
        Dim da10 As New SqlDataAdapter
        Dim SQLEng = "exec spRepMetricosProd 10, '" + FI.Text + "', '" + FF.Text + "'"
        Dim CMDEng As New SqlCommand(SQLEng, Conexion01)
        If Conexion01.State = ConnectionState.Closed Then Conexion01.Open()
        da10.SelectCommand = CMDEng
        da10.Fill(dt10)
        Grafica10.Series(0).DataSource = dt10
        Grafica10.Series(0).ArgumentDataMember = "Dia"
        Grafica10.Series(0).ValueScaleType = ScaleType.Numerical
        Grafica10.Series(0).ValueDataMembers.AddRange(New String() {"Corte"})
    End Sub

    Private Sub Metricos01_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        FrmMain.Visible = True
    End Sub

    Private Sub Metricos01_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        AjustaGraficos()
    End Sub

    Private Sub AjustaGraficos()
        lFecha.Left = (Me.Width / 2) - 10
        FI.Left = (Me.Width / 2) - FI.Width - 10
        FF.Left = (Me.Width / 2)
        bBack.Left = FI.Left - bBack.Width
        bNext.Left = FF.Left + FF.Width
        Grafica01.Width = (Me.Width - 60) / 2
        Grafica01.Height = (Me.Height - 100) / 2

        Grafica02.Left = (Me.Width / 2)
        Grafica02.Width = (Me.Width - 60) / 2
        Grafica02.Height = (Me.Height - 100) / 2

        Grafica03.Top = (Me.Height / 2) - 40
        Grafica03.Width = (Me.Width - 90) / 4
        Grafica03.Height = ((Me.Height - 100) / 4) - 5

        Grafica04.Top = (Me.Height / 2) - 40
        Grafica04.Left = (Me.Width / 4) + 3
        Grafica04.Width = (Me.Width - 90) / 4
        Grafica04.Height = ((Me.Height - 100) / 4) - 5

        Grafica05.Top = (Me.Height / 2) - 40
        Grafica05.Left = (Me.Width / 2)
        Grafica05.Width = (Me.Width - 90) / 4
        Grafica05.Height = ((Me.Height - 100) / 4) - 5

        Grafica06.Top = (Me.Height / 2) - 40
        Grafica06.Left = (Grafica02.Width / 2) + Grafica02.Left + 8
        Grafica06.Width = (Me.Width - 90) / 4
        Grafica06.Height = ((Me.Height - 100) / 4) - 5

        Grafica07.Top = ((Me.Height / 4) * 3) - 55
        Grafica07.Left = Grafica03.Left
        Grafica07.Width = (Me.Width - 90) / 4
        Grafica07.Height = ((Me.Height - 100) / 4) - 5

        Grafica08.Top = ((Me.Height / 4) * 3) - 55
        Grafica08.Left = Grafica04.Left
        Grafica08.Width = (Me.Width - 90) / 4
        Grafica08.Height = ((Me.Height - 100) / 4) - 5

        Grafica09.Top = ((Me.Height / 4) * 3) - 55
        Grafica09.Left = (Me.Width / 2)
        Grafica09.Width = (Me.Width - 90) / 4
        Grafica09.Height = ((Me.Height - 100) / 4) - 5

        Grafica10.Top = ((Me.Height / 4) * 3) - 55
        Grafica10.Left = (Grafica02.Width / 2) + Grafica02.Left + 8
        Grafica10.Width = (Me.Width - 90) / 4
        Grafica10.Height = ((Me.Height - 100) / 4) - 5
    End Sub

    Private Sub bBack_Click(sender As System.Object, e As System.EventArgs) Handles bBack.Click
        FI.Text = DateAdd(DateInterval.Day, -7, CDate(FI.Text)).ToString.Substring(0, 10)
        FF.Text = DateAdd(DateInterval.Day, -7, CDate(FF.Text)).ToString.Substring(0, 10)
        lSemana.Text = "Semana " + ((DateDiff(DateInterval.WeekOfYear, CDate(FI.Text), New DateTime(CDate(FI.Text).Year, 1, 1)) * -1)).ToString
        CargaGraficas()
    End Sub

    Private Sub bNext_Click(sender As System.Object, e As System.EventArgs) Handles bNext.Click
        FI.Text = DateAdd(DateInterval.Day, 7, CDate(FI.Text)).ToString.Substring(0, 10)
        FF.Text = DateAdd(DateInterval.Day, 7, CDate(FF.Text)).ToString.Substring(0, 10)
        lSemana.Text = "Semana " + ((DateDiff(DateInterval.WeekOfYear, CDate(FI.Text), New DateTime(CDate(FI.Text).Year, 1, 1)) * -1)).ToString
        CargaGraficas()
    End Sub

    Private Sub tCarga_Tick(sender As System.Object, e As System.EventArgs) Handles tCarga.Tick
        CargaGraficas()
    End Sub

    Private Sub CargaGraficas()
        CargaGrafica1()
        CargaGrafica2()
        CargaGrafica3()
        CargaGrafica4()
        CargaGrafica5()
        CargaGrafica6()
        CargaGrafica7()
        CargaGrafica8()
        CargaGrafica9()
        CargaGrafica10()
    End Sub


    Private Sub GraficasView(ByVal Valor As Boolean)
        Grafica01.Visible = Valor
        Grafica02.Visible = Valor
        Grafica03.Visible = Valor
        Grafica04.Visible = Valor
        Grafica05.Visible = Valor
        Grafica06.Visible = Valor
        Grafica07.Visible = Valor
        Grafica08.Visible = Valor
        Grafica09.Visible = Valor
        Grafica10.Visible = Valor
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Select Case True
            Case Grafica01.Focused
                CopiaGrafica(Grafica01)
            Case Grafica02.Focused
                CopiaGrafica(Grafica02)
            Case Grafica03.Focused
                CopiaGrafica(Grafica03)
            Case Grafica04.Focused
                CopiaGrafica(Grafica04)
            Case Grafica05.Focused
                CopiaGrafica(Grafica05)
            Case Grafica06.Focused
                CopiaGrafica(Grafica06)
            Case Grafica07.Focused
                CopiaGrafica(Grafica07)
            Case Grafica08.Focused
                CopiaGrafica(Grafica08)
            Case Grafica09.Focused
                CopiaGrafica(Grafica09)
            Case Grafica10.Focused
                CopiaGrafica(Grafica10)
        End Select
    End Sub

    Private Sub CopiaGrafica(ByVal Grafica As DevExpress.XtraCharts.ChartControl)
        Dim ms As New MemoryStream()
        Try
            Grafica.ExportToImage(ms, ImageFormat.Png)
            ms.Seek(0, SeekOrigin.Begin)
            Dim mf As New Bitmap(ms)
            Clipboard.SetImage(mf)
        Finally
            ms.Close()
        End Try
    End Sub

    Private Sub ZoomGrafica(ByVal Grafica As DevExpress.XtraCharts.ChartControl)
        If Grafica.Dock = DockStyle.Fill Then
            Grafica.Dock = DockStyle.None
            GraficasView(True)
        Else
            GraficasView(False)
            Grafica.Visible = True
            Grafica.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem2.Click, Grafica01.DoubleClick, Grafica02.DoubleClick, Grafica03.DoubleClick, Grafica04.DoubleClick, Grafica05.DoubleClick, Grafica06.DoubleClick, Grafica07.DoubleClick, Grafica08.DoubleClick, Grafica09.DoubleClick, Grafica10.DoubleClick
        Select Case True
            Case Grafica01.Focused
                ZoomGrafica(Grafica01)
            Case Grafica02.Focused
                ZoomGrafica(Grafica02)
            Case Grafica03.Focused
                ZoomGrafica(Grafica03)
            Case Grafica04.Focused
                ZoomGrafica(Grafica04)
            Case Grafica05.Focused
                ZoomGrafica(Grafica05)
            Case Grafica06.Focused
                ZoomGrafica(Grafica06)
            Case Grafica07.Focused
                ZoomGrafica(Grafica07)
            Case Grafica08.Focused
                ZoomGrafica(Grafica08)
            Case Grafica09.Focused
                ZoomGrafica(Grafica09)
            Case Grafica10.Focused
                ZoomGrafica(Grafica10)
        End Select
    End Sub

    Private Sub CopiarTodoAPortapapelesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopiarTodoAPortapapelesToolStripMenuItem.Click
        Dim bmWb As New Bitmap(pBack.Width, pBack.Height)
        Dim Rec As System.Drawing.Rectangle = pBack.ClientRectangle
        'Rec.Height = Rec.Height + 100
        Dim g As Graphics = Graphics.FromImage(bmWb)
        pBack.DrawToBitmap(bmWb, Rec)
        Clipboard.SetImage(bmWb)
        g.Dispose()
    End Sub
End Class