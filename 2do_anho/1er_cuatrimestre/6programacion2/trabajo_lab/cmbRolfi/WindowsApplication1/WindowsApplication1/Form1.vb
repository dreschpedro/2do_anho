Public Class Form1
    'Friend Argentina As String = "Argentina"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MessageBox.Show("¿Desea cerrar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub


    Private Sub estados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles estados.SelectedIndexChanged

    End Sub

    Private Sub pais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pais.SelectedIndexChanged
        If pais.SelectedItem = "Argentina" Then
            estados.Items.Clear()
            estados.Items.Add("Misiones")
            estados.Items.Add("Corrientes")
            estados.Items.Add("Formosa")
        ElseIf pais.SelectedItem = "Paraguay" Then
            estados.Items.Clear()
            estados.Items.Add("Itapua")
            estados.Items.Add("San Pedro")
            estados.Items.Add("Concepcion")
        ElseIf pais.SelectedItem = "Uruguay" Then
            estados.Items.Clear()
            estados.Items.Add("Artigas")
            estados.Items.Add("Salto")
            estados.Items.Add("Rio Negro")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Debug.Print("NOMBRE: " + textb.Text)
        Debug.Print("PAIS: " + pais.SelectedItem)
        Debug.Print("ESTADO/PROVINCIA: " + estados.SelectedItem)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        estados.Items.Clear()
        textb.Text = " "
        pais.Text = " "
    End Sub

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show("¿Desea cerrar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub
End Class
