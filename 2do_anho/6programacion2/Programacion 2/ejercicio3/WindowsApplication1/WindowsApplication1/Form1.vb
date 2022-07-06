Public Class Form1
    Public val As Integer = 20
    Public val1 As Integer = 20
    Public cont As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menos.Click
        If cont > 0 Then
            val1 = val1 - 3
            val = val - 3
            Label1.Top = Label1.Top + 2
            Label1.Left = Label1.Left - 10
            Label1.Size = New Size(val, val1)
            cont -= 1
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mas.Click
        If cont <= 15 Then
            val1 = val1 + 3
            val = val + 3
            Label1.Top = Label1.Top - 2
            Label1.Left = Label1.Left + 10
            Label1.Size = New Size(val, val1)
            cont += 1
        End If
    End Sub

End Class
