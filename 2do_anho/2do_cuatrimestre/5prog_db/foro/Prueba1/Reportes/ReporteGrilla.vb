Public Class ReporteGrilla
    Private Sub ReporteGrilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Reporte As New Report1


        rptSocios.Report = Reporte


        rptSocios.RefreshReport()


    End Sub
End Class