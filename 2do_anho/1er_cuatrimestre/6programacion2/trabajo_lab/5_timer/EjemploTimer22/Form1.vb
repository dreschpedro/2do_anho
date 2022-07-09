Public Class Form1

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim HORA As String

        'HORA = Now.ToString

        'lblReloj.Text = HORA.Substring(11, 8)

        lblReloj.Text = Now.ToString("HH:MM:ss")



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'muestro hora pc
        lblReloj.Text = Now.ToString("HH:MM:ss")

        'avanzo num y progress bar
        num1.Value = num1.Value + 1

        If ProgressBar1.Value < 98 Then ProgressBar1.Value = ProgressBar1.Value + 3

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'habilito o deshabiliot timer1
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'habilito o deshabiliot timer1
        If Timer2.Enabled = False Then
            Timer2.Enabled = True
        Else
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'muevo picture box
        'PictureBox1.Height = PictureBox1.Height - 10
        PictureBox1.Left = PictureBox1.Left + 10
        PictureBox1.Top = PictureBox1.Top - 5
    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'cargo imagen al PictureBox desde el disco
        PictureBox1.Image = Image.FromFile(txtDirImagen.Text)
    End Sub
End Class
