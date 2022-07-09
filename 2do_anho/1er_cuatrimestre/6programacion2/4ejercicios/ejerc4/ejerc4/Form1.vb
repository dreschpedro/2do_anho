Public Class Form1

    Private Sub txt_precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio.KeyPress
        'permitir solo numeros >> txt_precio
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'numeros, Supr y backspace
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite ingresar letras
        End If
    End Sub

    Private Sub txt_iva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pvp.KeyPress
        'permitir solo numeros >> txt_iva
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'numeros, Supr y backspace
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite ingresar letras
        End If
    End Sub

    Private Sub txt_pvp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pvp.KeyPress
        'permitir solo numeros >> txt_pvp
        If ((Char.IsNumber(e.KeyChar))) Then 'numeros
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite ingresar letras
        End If
    End Sub

    'boton borrar ---> limpia todos los campos
    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        txt_precio.Clear()
        txt_pvp.Clear()
    End Sub

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        If txt_precio.Text = "" Then
            MsgBox("Debe ingresar un valor")
        Else
            txt_pvp.Text = (Val(txt_precio.Text) * 0.21) + Val(txt_precio.Text)
        End If
    End Sub

    Private Sub btn_copiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copiar.Click
        My.Computer.Clipboard.SetText(Val(txt_pvp.Text)) 'copiar el resultado --> PVP
    End Sub
End Class
