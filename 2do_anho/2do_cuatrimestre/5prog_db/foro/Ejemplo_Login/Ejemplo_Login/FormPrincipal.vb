Public Class FormPrincipal

    Private Sub FormPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'invoco al login
        Dim login As New FormLogin

        Dim result As DialogResult = login.ShowDialog()

        If (result <> Windows.Forms.DialogResult.OK) Then

            Me.Close()

        End If


    End Sub
End Class
