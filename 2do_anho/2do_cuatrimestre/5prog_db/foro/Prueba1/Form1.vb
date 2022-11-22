Imports Telerik.Reporting
Imports Telerik.ReportViewer
Imports System.Drawing.Printing



Public Class Form1
    Private Sub btnImprimeGrilla_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnMostrarGrilla_Click(sender As Object, e As EventArgs) Handles btnMostrarGrilla.Click
        ReporteGrilla.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        CadenaReporte = "Select * from clientes where ciudad='" & Trim(txtFiltro.Text) & "';"

        FormReporteCliente.Show()
    End Sub
End Class
