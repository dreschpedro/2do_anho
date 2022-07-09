Public Class Form1

    Private Sub btn_menos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menos.Click
        lbl1.Left = lbl1.Left - 5
    End Sub

    Private Sub btn_mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mas.Click
        lbl1.Left = lbl1.Left + 5
    End Sub
End Class
