Imports System.Data
Imports System.Data.Odbc
Imports System.IO
Public Class RepCompras01

    Private Sub bGenerar_Click(sender As System.Object, e As System.EventArgs) Handles bGenerar.Click
        Dim sBase As String = TxTFic.Text
        Dim sSelect As String = "SELECT * FROM " & TxtSelect.Text
        Dim sConn As String

        sConn = "Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" & _
                System.IO.Path.GetDirectoryName(sBase) & ";"
        sConn = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.IO.Path.GetDirectoryName(sBase) & _
            " ;Extended Properties=dBASE IV;User ID=;Password="
        Using dbConn As New System.Data.Odbc.OdbcConnection(sConn)
            Try
                dbConn.Open()
                Dim da As New System.Data.Odbc.OdbcDataAdapter(sSelect, dbConn)
                Dim dt As New DataTable
                da.Fill(dt)
                grdRep01.DataSource = dt
                dbConn.Close()
            Catch ex As Exception
                MessageBox.Show("Error al abrir la base de datos" & vbCrLf & ex.Message)
                Exit Sub
            End Try
        End Using
    End Sub

    Private Sub RepCompras01_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMain.Visible = True
    End Sub

    Private Sub sbEmpresa_Click(sender As System.Object, e As System.EventArgs) Handles sbEmpresa.Click
        Dim oFD As New OpenFileDialog
        With oFD
            .Filter = "Ficheros DBF (*.dbf)|*.dbf|Todos (*.*)|*.*"
            .FileName = TxTFic.Text
            If .ShowDialog = DialogResult.OK Then
                TxTFic.Text = .FileName
                ' El nombre del fichero
                TxtSelect.Text = System.IO.Path.GetFileNameWithoutExtension(TxTFic.Text)
                'sbEmpresa_Click(Nothing, Nothing)
            End If
        End With
    End Sub
End Class