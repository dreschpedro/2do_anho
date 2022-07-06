Public Class Form1

    Public con As Integer = 1



    Private Sub btn0x0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0x0.Click, btn2x2.Click, btn2x1.Click, btn2x0.Click, btn1x2.Click, btn1x1.Click, btn1x0.Click, btn0x2.Click, btn0x1.Click

        If con Mod 2 = 0 Then
            sender.Text = "O"
            con = con + 1
            sender.Enabled = False
        Else
            sender.Text = "X"
            con = con + 1
            sender.Enabled = False
        End If


        'X
        If btn0x0.Text = "X" And btn0x1.Text = "X" And btn0x2.Text = "X" Then
            MessageBox.Show("GANO EL JUGADOR 1", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn1x0.Text = "X" And btn1x1.Text = "X" And btn1x2.Text = "X" Then
            MessageBox.Show("GANO EL JUGADOR 1", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn2x0.Text = "X" And btn2x1.Text = "X" And btn2x2.Text = "X" Then
            MessageBox.Show("GANO EL JUGADOR 1", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



        ElseIf btn0x0.Text = "X" And btn1x0.Text = "X" And btn2x0.Text = "X" Then
            MessageBox.Show("GANO EL JUGADOR 1", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn0x1.Text = "X" And btn1x1.Text = "X" And btn1x2.Text = "X" Then
            MessageBox.Show("GANO EL JUGADOR 1", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn0x2.Text = "X" And btn1x2.Text = "X" And btn2x2.Text = "X" Then
            MessageBox.Show("GANO EL JUGADOR 1", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        ElseIf btn0x0.Text = "X" And btn1x1.Text = "X" And btn2x2.Text = "X" Then
            MessageBox.Show("GANO EL JUGADOR 1", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn0x2.Text = "X" And btn1x1.Text = "X" And btn2x0.Text = "X" Then
            MessageBox.Show("GANO EL JUGADOR 1", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'X

            'O
        ElseIf btn0x0.Text = "O" And btn0x1.Text = "O" And btn0x2.Text = "O" Then
            MessageBox.Show("GANO EL JUGADOR 2", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn1x0.Text = "O" And btn1x1.Text = "O" And btn1x2.Text = "O" Then
            MessageBox.Show("GANO EL JUGADOR 2", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn2x0.Text = "O" And btn2x1.Text = "O" And btn2x2.Text = "O" Then
            MessageBox.Show("GANO EL JUGADOR 2", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



        ElseIf btn0x0.Text = "O" And btn1x0.Text = "O" And btn2x0.Text = "O" Then
            MessageBox.Show("GANO EL JUGADOR 2", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn0x1.Text = "O" And btn1x1.Text = "O" And btn2x1.Text = "O" Then
            MessageBox.Show("GANO EL JUGADOR 2", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn0x2.Text = "O" And btn1x2.Text = "O" And btn2x2.Text = "O" Then
            MessageBox.Show("GANO EL JUGADOR 2", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        ElseIf btn0x0.Text = "O" And btn1x1.Text = "O" And btn2x2.Text = "O" Then
            MessageBox.Show("GANO EL JUGADOR 2", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf btn0x2.Text = "O" And btn1x1.Text = "O" And btn2x0.Text = "O" Then
            MessageBox.Show("GANO EL JUGADOR 2", "GANADOR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'O

            'EMPATE
        ElseIf con = 10 Then
            MessageBox.Show("NI UNO FUE CAPAZ DE GANAR", "EMPATE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
