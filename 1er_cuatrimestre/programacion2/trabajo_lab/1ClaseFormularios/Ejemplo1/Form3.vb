Public Class Form3

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show("Desea cerrar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMensaje.Text = Nombre.ToString
    End Sub
End Class