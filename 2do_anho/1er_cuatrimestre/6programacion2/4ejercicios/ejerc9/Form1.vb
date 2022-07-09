Public Class Form1

    Public operacion As Integer
    Public num1, num2 As Double
    'form load
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        txt_screen.TextAlign = HorizontalAlignment.Right
    End Sub
    'numero, suprimir, borrar y puntuacion
    Private Sub txt_screen_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_screen.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsControl(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsPunctuation(e.KeyChar))) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    'BTN limpiar
    Private Sub btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles btn_limpiar.Click
        txt_screen.Clear()
    End Sub
    'BTN borrar
    Private Sub btn_borrar_Click(sender As System.Object, e As System.EventArgs) Handles btn_borrar.Click
        If txt_screen.Text.Length > 0 Then
            txt_screen.Text = txt_screen.Text.Remove(txt_screen.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub numeros_Click(sender As System.Object, e As System.EventArgs) Handles btn_0.Click, btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click
        Dim b As Button = sender

        If (txt_screen.Text = "0") Then
            txt_screen.Text = ""
            txt_screen.Text = b.Text
        ElseIf (b.Text = ".") Then
            If (Not txt_screen.Text.Contains(".")) Then
                txt_screen.Text = txt_screen.Text + b.Text
            End If
        Else
            txt_screen.Text = txt_screen.Text + b.Text
        End If
    End Sub

    Private Sub operacion_Click(sender As System.Object, e As System.EventArgs) Handles btnDiv.Click, btnMas.Click, btnMenos.Click, btnMult.Click
        
    End Sub
End Class
