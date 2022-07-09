Public Class Form1
    Dim a, b, c, d, platita As Double

    Private Sub h20_50_CheckedChanged(sender As Object, e As EventArgs) Handles h20_50.CheckedChanged, vino4.Click, RadioButton2.Click, h20_50.Click, coca1.Click
        If sender.Checked = True Then d = CDbl(sender.Text)
        total.Text = a + b + c + d
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        platita = CDbl(entrega.Text)
        devolver.Text = platita - CDbl(total.Text)
    End Sub

    Private Sub bananita1_CheckedChanged(sender As Object, e As EventArgs) Handles bananita1.CheckedChanged, RadioButton1.Click, hotcoffe1.Click, helado1_50.Click, bananita1.Click
        If sender.Checked = True Then c = CDbl(sender.Text)
        total.Text = a + b + c + d
    End Sub

    Private Sub ensalada2_CheckedChanged(sender As Object, e As EventArgs) Handles ensalada2.CheckedChanged, sopa3.Click, ensaladafrut2_50.Click, ensalada2.Click, tacaño.Click
        If sender.Checked = True Then a = CDbl(sender.Text)
        total.Text = a + b + c + d
    End Sub
    Private Sub fideito2_50_CheckedChanged(sender As Object, e As EventArgs) Handles fideito2_50.CheckedChanged, RadioButton4.Click, pescado3_50.Click, fideito2_50.Click, carnesita3_30.Click
        If sender.Checked = True Then b = CDbl(sender.Text)
        total.Text = a + b + c + d
    End Sub

End Class
