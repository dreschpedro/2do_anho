Public Class Form1
    Public var As Integer = 12
    Public cont As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suma.Click
        If cont <= 14 Then
            TextBox1.Left = TextBox1.Left + 10
            cont += 1
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resta.Click
        If cont >= 1 Then
            TextBox1.Left = TextBox1.Left - 10
            cont -= 1
        End If
    End Sub
End Class
