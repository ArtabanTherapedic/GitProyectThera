Public Class Accesos 

    Private Sub Accesos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tAccesos.Nodes.Add("Configuracion").Name = "Mod1"
        tAccesos.Nodes.Item(0).Nodes.Add("Reporte de Salas").Name = "1000"
        tAccesos.Nodes.Item(0).Nodes.Add("Reporte de costuras").Name = "2000"
    End Sub
End Class