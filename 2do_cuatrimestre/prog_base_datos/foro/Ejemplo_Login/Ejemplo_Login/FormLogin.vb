Public Class FormLogin

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'invocado desde FormPrincipal
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'primero controlo que esten cargados los text
        If txtUsuario.Text = "" Or txtClave.Text = "" Then Exit Sub

        'ahora controlo que no sea el usuario administrador
        If txtUsuario.Text = "admin" And txtClave.Text = "1234" Then
            'ingreso como Admin
            'libero el form principal
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Exit Sub
        Else
            MsgBox("USUARIO/CLAVE INCORRECTO", vbCritical, "ERROR!")
            txtUsuario.Text = ""
            txtUsuario.Focus()
        End If
    End Sub
End Class