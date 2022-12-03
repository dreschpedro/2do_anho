Public Class Form1

    Private Sub btnConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConversion.Click
        'validar fecha
        If IsDate(txtFechaUsuario.Text) Then
            MsgBox("FECHA CORRECTA")

            'voy a convertir a formato presentacion
            Dim Fecha As Date

            Fecha = CDate(txtFechaUsuario.Text)

            lblFechaConvertida.Text = Fecha.ToShortDateString

            'dtpFecha.Value = Fecha

        Else
            MsgBox("FECHA INCORRECTA")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtFechaUsuario.Text = Date.Now.ToShortDateString1
        dtpFecha.Value = Date.Now
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'imprime formulario
        PrintForm1.Print()

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click

    End Sub

    Private Sub Listado1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Listado1ToolStripMenuItem.Click
        PrintForm1.Print()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
