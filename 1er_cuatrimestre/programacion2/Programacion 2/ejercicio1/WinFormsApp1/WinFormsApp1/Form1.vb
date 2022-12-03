Public Class Form1
    Public val As Integer = 20
    Public cont As Integer = 0

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menos.Click
        If cont >= 1 Then
            val = val - 30
            TextBox1.Size = New Size(val, 26)
            cont -= 1
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If cont <= 10 Then
            val = val + 30
            TextBox1.Size = New Size(val, 26)
            cont += 1
        End If
    End Sub
End Class
