Public Class Form1

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Debug.Print("***********************")

        'imrimo genero
        For Each rad As RadioButton In Me.Controls.OfType(Of RadioButton)()
            If rad.Checked = True Then
                Debug.Print(rad.Text)
            End If
        Next

        'imprimo estado civil
        For Each radeciv As RadioButton In grpEstCiv.Controls.OfType(Of RadioButton)()
            If radeciv.Checked = True Then
                Debug.Print(radeciv.Text)
            End If
        Next

        'si el hobie esta tildado imprimo
        For Each chk As CheckBox In Me.Controls.OfType(Of CheckBox)()
            'si esta seleccionado imprimo
            If chk.Checked = True Then
                Debug.Print(chk.Text)
            End If
        Next

    End Sub

    Private Sub chkDeportes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDeportes.CheckedChanged
 
    End Sub

    Private Sub chkHobbies_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDeportes.CheckedChanged, chkJuegos.CheckedChanged, chkLibros.CheckedChanged, chkMusica.CheckedChanged, chkPeliculas.CheckedChanged
        If sender.checked = True Then
            lblMensaje.Text = sender.Text
        Else
            lblMensaje.Text = ""
        End If
    End Sub

End Class
