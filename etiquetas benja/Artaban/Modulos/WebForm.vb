Public Class WebForm
    Dim Pagina As String
    Private Sub WebForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Pagina = "<html><body>""Hello World!""</body></html>"
        Cargahtml()
        TextBox1.Text = Pagina
        TextBox1.Visible = False
        ' MsgBox(Pagina)

        WebBrowser1.ScriptErrorsSuppressed = True
        With WebBrowser1
            .Navigate("about:blank")
            .Document.OpenNew(True)
            .Document.Write(Pagina)
        End With
    End Sub

    Private Sub Cargahtml()
        Pagina = " <!DOCTYPE html>" & Chr(13) & _
            " <html lang=""es"">" & Chr(13) & _
            "<head>" & Chr(13) & _
             "<meta http-equiv=""Content-Type"" content=""text/html; charset=windows-1252"">" & Chr(13) & _
            "<title>Ejemplos de gr&#225;ficos usando Chart.js</title>" & Chr(13) & _
            "<meta name =""author"" content =""Norfi Carrodeguas"">" & Chr(13) & _
            "</head>" & Chr(13) & _
            "<body>  	  " & Chr(13) & _
            "<h1>Ejemplos de gr&#225;ficos usando Chart.js</h1><br>" & Chr(13) & _
            "<script src=""file:///C:/Users/Public/Documents/Programas/Chartjs/Chart.js""> </script>" & Chr(13) & _
            "<div id=""canvas-holder"">" & Chr(13) & _
            "<canvas id=""chart-area"" width=""300"" height=""300""></canvas>" & Chr(13) & _
            "<canvas id=""chart-area2"" width=""300"" height=""300""></canvas>" & Chr(13) & _
            "<canvas id=""chart-area3"" width=""600"" height=""300""></canvas>" & Chr(13) & _
            "<canvas id=""chart-area4"" width=""600"" height=""300""></canvas>" & Chr(13) & _
            "</div>" & Chr(13) & _
            "<script> " & Chr(13) & _
            "var pieData = [{value: 40,color:""#0b82e7"",highlight: ""#0c62ab"",label: ""Google Chrome""}," & Chr(13) & _
            "				{" & Chr(13) & _
            "					value: 16," & Chr(13) & _
            "					color: ""#e3e860""," & Chr(13) & _
            "					highlight: ""#a9ad47""," & Chr(13) & _
            "					label: ""Android""" & Chr(13) & _
            "				}," & Chr(13) & _
            "				{" & Chr(13) & _
            "					value: 11," & Chr(13) & _
            "					color: ""#eb5d82""," & Chr(13) & _
            "					highlight: ""#b74865""," & Chr(13) & _
            "					label: ""Firefox""" & Chr(13) & _
            "				}," & Chr(13) & _
            "				{" & Chr(13) & _
            "					value: 10," & Chr(13) & _
            "					color: ""#5ae85a""," & Chr(13) & _
            "					highlight: ""#42a642""," & Chr(13) & _
            "					label: ""Internet Explorer""" & Chr(13) & _
            "				}," & Chr(13) & _
            "				{" & Chr(13) & _
            "					value: 8.6," & Chr(13) & _
            "					color: ""#e965db""," & Chr(13) & _
            "					highlight: ""#a6429b""," & Chr(13) & _
            "					label: ""Safari""" & Chr(13) & _
            "				}" & Chr(13) & _
            "			];" & Chr(13) & _
            "	var barChartData = {" & Chr(13) & _
            "		labels : [""Enero"",""Febrero"",""Marzo"",""Abril"",""Mayo"",""Junio"",""Julio""]," & Chr(13) & _
            "		datasets : [" & Chr(13) & _
            "			{" & Chr(13) & _
            "				fillColor : ""#6b9dfa""," & Chr(13) & _
            "				strokeColor : ""#ffffff""," & Chr(13) & _
            "				highlightFill: ""#1864f2""," & Chr(13) & _
            "				highlightStroke: ""#ffffff""," & Chr(13) & _
            "				data : [90,30,10,80,15,5,15]" & Chr(13) & _
            "			}," & Chr(13) & _
            "			{" & Chr(13) & _
            "				fillColor : ""#e9e225""," & Chr(13) & _
            "				strokeColor : ""#ffffff""," & Chr(13) & _
            "				highlightFill: ""#ee7f49""," & Chr(13) & _
            "				highlightStroke: ""#ffffff""," & Chr(13) & _
            "				data : [40,50,70,40,85,55,15]" & Chr(13) & _
            "			}" & Chr(13) & _
            "		]" & Chr(13) & _
            "	}	" & Chr(13) & _
            "		var lineChartData = {" & Chr(13) & _
            "			labels : [""Enero"",""Febrero"",""Marzo"",""Abril"",""Mayo"",""Junio"",""Julio""]," & Chr(13) & _
            "			datasets : [" & Chr(13) & _
            "				{" & Chr(13) & _
            "					label: ""Primera serie de datos""," & Chr(13) & _
            "					fillColor : ""rgba(220,220,220,0.2)""," & Chr(13) & _
            "					strokeColor : ""#6b9dfa""," & Chr(13) & _
            "					pointColor : ""#1e45d7""," & Chr(13) & _
            "					pointStrokeColor : ""#fff""," & Chr(13) & _
            "					pointHighlightFill : ""#fff""," & Chr(13) & _
            "					pointHighlightStroke : ""rgba(220,220,220,1)""," & Chr(13) & _
            "					data : [90,30,10,80,15,5,15]" & Chr(13) & _
            "				}," & Chr(13) & _
            "				{" & Chr(13) & _
            "					label: ""Segunda serie de datos""," & Chr(13) & _
            "					fillColor : ""rgba(151,187,205,0.2)""," & Chr(13) & _
            "					strokeColor : ""#e9e225""," & Chr(13) & _
            "					pointColor : ""#faab12""," & Chr(13) & _
            "					pointStrokeColor : ""#fff""," & Chr(13) & _
            "					pointHighlightFill : ""#fff""," & Chr(13) & _
            "					pointHighlightStroke : ""rgba(151,187,205,1)""," & Chr(13) & _
            "					data : [40,50,70,40,85,55,15]" & Chr(13) & _
            "				}" & Chr(13) & _
            "			]" & Chr(13) & _
            "		}" & Chr(13) & _
            "var ctx = document.getElementById(""chart-area"").getContext(""2d"");" & Chr(13) & _
            "var ctx2 = document.getElementById(""chart-area2"").getContext(""2d"");" & Chr(13) & _
            "var ctx3 = document.getElementById(""chart-area3"").getContext(""2d"");" & Chr(13) & _
            "var ctx4 = document.getElementById(""chart-area4"").getContext(""2d"");" & Chr(13) & _
            "window.myPie = new Chart(ctx).Pie(pieData);	" & Chr(13) & _
            "window.myPie = new Chart(ctx2).Doughnut(pieData);				" & Chr(13) & _
            "window.myPie = new Chart(ctx3).Bar(barChartData, {responsive:true});" & Chr(13) & _
            "window.myPie = new Chart(ctx4).Line(lineChartData, {responsive:true});" & Chr(13) & _
            "</script> " & Chr(13) & _
            "</body>" & Chr(13) & _
            "</html>"

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class