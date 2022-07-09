Public Class Form1
    Public valor As Integer = 20

    Private Sub btn_menos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menos.Click
        valor = valor - 5
        lbl1.Size = New Size(valor, valor)
        lbl1.Left = lbl1.Left - 15
    End Sub

    Private Sub btn_mas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mas.Click
        valor = valor + 5
        lbl1.Size = New Size(valor, valor)
        lbl1.Left = lbl1.Left + 15
    End Sub
End Class
