Public Class Form1

    Dim a, b, c, d As Double

    'primeros
    Private Sub primeros_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles p_papa.CheckedChanged, p_papa.Click, p_sopa.Click, p_ensalada.Click
        If sender.Checked = True Then
            a = CDbl(sender.Text)
        End If
        lbl_importe.Text = a + b + c + d
    End Sub
    'segundos
    Private Sub segundos_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles s_poroto.CheckedChanged, s_fideo.Click, s_pastel.Click, s_poroto.Click
        If sender.Checked = True Then
            b = CDbl(sender.Text)
        End If
        lbl_importe.Text = a + b + c + d
    End Sub
    'postres
    Private Sub postres_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles t_choco.CheckedChanged, t_choco.Click, t_flan.Click, t_helado.Click
        If sender.Checked = True Then
            c = CDbl(sender.Text)
        End If
        lbl_importe.Text = a + b + c + d
    End Sub
    'bebidas
    Private Sub bebidas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles c_agua.CheckedChanged, c_agua.Click, c_cafe.Click, c_coca.Click
        If sender.Checked = True Then
            d = CDbl(sender.Text)
        End If
        lbl_importe.Text = a + b + c + d
    End Sub
    'boton cobrar
    Private Sub btn_cobrar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cobrar.Click
        lbl_devolver.Text = CDbl(txt_entrega.Text) - CDbl(lbl_importe.Text)
    End Sub

End Class
