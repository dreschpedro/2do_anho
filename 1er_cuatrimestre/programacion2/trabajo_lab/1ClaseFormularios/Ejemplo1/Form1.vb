Public Class Form1


    Private Sub btnAbrirForm2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirForm2.Click
        Form2.Show()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'CODIGO PARA VALIDAR EL CIERRE DE UN FORMULARIO 1
        If MessageBox.Show("Desea cerrar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnForm3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForm3.Click
        Nombre = "HOLA " + txtNombre.Text.ToString + " DNI: " + txtDNI.Text.ToString

        Form3.Show()
    End Sub
End Class
