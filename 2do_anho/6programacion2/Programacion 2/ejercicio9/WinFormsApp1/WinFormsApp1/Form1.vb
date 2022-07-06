Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim Bandera As Boolean
    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button9.Click, Button8.Click, Button4.Click, Button20.Click, Button2.Click, Button17.Click, Button16.Click, Button14.Click, Button10.Click
    '    Dim a As String
    '    mecopieEstoDeYoutube()
    '    If resul.Text = 0 Then
    '        resul.Text = sender.text
    '    Else
    '        a = sender.text
    '        resul.Text &= a
    '    End If
    'End Sub

    'Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
    '    If InStr(resul.Text, ".", CompareMethod.Text) = 0 Then
    '        resul.Text &= "."
    '    End If
    'End Sub

    'Private Sub Button22_Click(sender As Object, e As EventArgs) Handles sumar.Click, MyBase.Click, dividir.Click, restar.Click, multiplicar.Click
    '    operacacionProceso()
    '    Operacion = CStr(sender.text)
    'End Sub


    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click
        OperacionProceso()
        Operacion = ""
    End Sub

    Private Sub OperacionProceso()
        Bandera = True
        Valor2 = Val(resul.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            resul.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        resul.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        DeterminarConcatenar()
        resul.Text &= "1"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        DeterminarConcatenar()
        resul.Text &= "2"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        DeterminarConcatenar()
        resul.Text &= "3"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DeterminarConcatenar()
        resul.Text &= "4"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DeterminarConcatenar()
        resul.Text &= "5"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DeterminarConcatenar()
        resul.Text &= "6"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeterminarConcatenar()
        resul.Text &= "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeterminarConcatenar()
        resul.Text &= "8"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DeterminarConcatenar()
        resul.Text &= "9"
    End Sub

    Private Sub sumar_Click(sender As Object, e As EventArgs) Handles sumar.Click
        OperacionProceso()
        Operacion = "+"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        DeterminarConcatenar()
        If InStr(resul.Text, ".", CompareMethod.Text) = 0 Then
            resul.Text &= "."
        End If
    End Sub
    Public Sub DeterminarConcatenar()
        If Bandera = True Then
            resul.Text = ""
            Bandera = False
        ElseIf resul.Text = "0" Then
            resul.Text = ""
        End If
    End Sub

    Private Sub resul_TextChanged(sender As Object, e As EventArgs) Handles resul.TextChanged

    End Sub

    Private Sub restar_Click(sender As Object, e As EventArgs) Handles restar.Click
        OperacionProceso()
        Operacion = "-"
    End Sub

    Private Sub multiplicar_Click(sender As Object, e As EventArgs) Handles multiplicar.Click
        OperacionProceso()
        Operacion = "*"
    End Sub

    Private Sub dividir_Click(sender As Object, e As EventArgs) Handles dividir.Click
        OperacionProceso()
        Operacion = "/"
    End Sub
End Class
