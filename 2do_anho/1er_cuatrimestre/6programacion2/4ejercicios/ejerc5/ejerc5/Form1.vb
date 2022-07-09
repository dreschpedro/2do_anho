Public Class Form1
    'validar caracteres
    Private Sub txt_precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'validar caracteres
    Private Sub txt_iva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_iva.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'boton BORRAR
    Private Sub btn_borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrar.Click
        txt_iva.Clear()
        txt_precio.Clear()
        txt_pvp.Clear()

        If (chk_iva_pje.Checked = True) Then
            txt_iva.Text = ""
        Else
            txt_iva.Text = 21
        End If
    End Sub
    'carcar FORM con txt_iva.Text = 21
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_iva.Text = 21
    End Sub

    Private Sub chk_iva_pje_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_iva_pje.Click
        If (chk_iva_pje.Checked = True) Then 'si esta marcado
            txt_iva.Enabled = True
            txt_iva.Clear()
        Else                                 'si NO esta marcado
            txt_iva.Enabled = False
            txt_iva.Text = 21
        End If
    End Sub

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        If (chk_iva_pje.Checked = False) Then
            txt_pvp.Text = (Val(txt_precio.Text) * 0.21) + (Val(txt_precio.Text))
        Else
            txt_pvp.Text = ((Val(txt_precio.Text) * Val(txt_iva.Text)) / 100) + (Val(txt_precio.Text))
        End If
    End Sub

End Class
