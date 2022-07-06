Public Class Form1
    Public Const a As Integer = 14
    Public fuente As Integer = 1
    Public colorcito As Integer = 1
    Public fondo As Integer = 1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "VAMOS ARGENTINA!!" & vbCrLf & "VAMOS ARGENTINA!!" & vbCrLf & "VAMOS ARGENTINA!!" & vbCrLf & "VAMOS ARGENTINA!!" & vbCrLf &
        "VAMOS ARGENTINA!!" & vbCrLf & "VAMOS ARGENTINA!!" & vbCrLf & "VAMOS ARGENTINA!!" & vbCrLf & "VAMOS ARGENTINA!!" & vbCrLf &
        "VAMOS ARGENTINA!!" & vbCrLf & "VAMOS ARGENTINA!!" & vbCrLf & "VAMOS ARGENTINA!!" & vbCrLf & "VAMOS ARGENTINA!!"
    End Sub

    Private Sub BtnFuente_Click(sender As Object, e As EventArgs) Handles btnFuente.Click
        fuente += 1
        CambiarFuente()

    End Sub

    Private Sub BtnFondo_Click(sender As Object, e As EventArgs) Handles btnFondo.Click
        fondo += 1
        ColorFondo()
    End Sub

    Private Sub BtnColorFuente_Click(sender As Object, e As EventArgs) Handles btnColorFuente.Click
        colorcito += 1
        Call ColoresFuentes()
    End Sub
    Public Sub ColoresFuentes()
        Select Case colorcito
            Case 1
                muestra.ForeColor = Color.Black
                Label1.ForeColor = muestra.ForeColor
            Case 2
                muestra.ForeColor = Color.Red
                Label1.ForeColor = muestra.ForeColor
            Case 3
                muestra.ForeColor = Color.Green
                Label1.ForeColor = muestra.ForeColor
            Case 4
                muestra.ForeColor = Color.Cyan
                Label1.ForeColor = muestra.ForeColor
            Case 5
                muestra.ForeColor = Color.Blue
                Label1.ForeColor = muestra.ForeColor
            Case 6
                muestra.ForeColor = Color.Fuchsia
                Label1.ForeColor = muestra.ForeColor
        End Select
        If colorcito = 7 Then
            colorcito = 0
        End If
    End Sub

    Public Sub CambiarFuente()
        Select Case fuente
            Case 1
                muestra.Font = New Font("Segoe UI", a)
                Label1.Font = muestra.Font
            Case 2
                muestra.Font = New Font("Stencil", a)
                Label1.Font = muestra.Font
            Case 3
                muestra.Font = New Font("Algerian", a)
                Label1.Font = muestra.Font
            Case 4
                muestra.Font = New Font("Showcard Gothic", a)
                Label1.Font = muestra.Font
            Case 5
                muestra.Font = New Font("Vladimir Script", a)
                Label1.Font = muestra.Font
            Case 6
                muestra.Font = New Font("Old English Text MT", a)
                Label1.Font = muestra.Font
        End Select
        If fuente = 7 Then
            fuente = 0
        End If
    End Sub

    Public Sub ColorFondo()

        Select Case fondo
            Case 1
                muestra.BackColor = Color.White
                Label1.BackColor = muestra.BackColor
            Case 2
                muestra.BackColor = Color.Yellow
                Label1.BackColor = muestra.BackColor
            Case 3
                muestra.BackColor = Color.Pink
                Label1.BackColor = muestra.BackColor
            Case 4
                muestra.BackColor = Color.Aqua
                Label1.BackColor = muestra.BackColor
            Case 5
                muestra.BackColor = Color.Gray
                Label1.BackColor = muestra.BackColor
            Case 6
                muestra.BackColor = Color.Magenta
                Label1.BackColor = muestra.BackColor
        End Select
        If fondo = 7 Then
            fondo = 0
        End If
    End Sub
End Class
