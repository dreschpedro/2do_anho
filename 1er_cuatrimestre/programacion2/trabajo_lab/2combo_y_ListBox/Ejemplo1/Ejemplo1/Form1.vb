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

        'CODIGO PARA VALIDAR EL CIERRE DE UN FORMULARIO
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

    Private Sub btnMostrarClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarClave.Click

    End Sub

    Private Sub btnMostrarClave_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMostrarClave.MouseDown
        txtClave.PasswordChar = ""
    End Sub

    Private Sub btnMostrarClave_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMostrarClave.MouseUp
        txtClave.PasswordChar = "*"
    End Sub

    Private Sub lblVerClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVerClave.Click

    End Sub

    Private Sub lblVerClave_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblVerClave.MouseHover
        'muestro la clave
        txtClave.PasswordChar = ""
    End Sub

    Private Sub lblVerClave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblVerClave.MouseLeave
        'oculto la clave
        txtClave.PasswordChar = "*"
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        'voy a permitir solo numeros
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSurrogate(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDNI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNI.TextChanged

    End Sub
End Class
