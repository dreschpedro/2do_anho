Public Class Form1
    Public a, b As Integer

    Private Sub vertical_ValueChanged(sender As Object, e As EventArgs) Handles vertical.ValueChanged

        b = vertical.Value
            laPelota.Left = b

    End Sub

    Private Sub horizontal_ValueChanged(sender As Object, e As EventArgs) Handles horizontal.ValueChanged

        a = horizontal.Value
            laPelota.Top = a

    End Sub
End Class
