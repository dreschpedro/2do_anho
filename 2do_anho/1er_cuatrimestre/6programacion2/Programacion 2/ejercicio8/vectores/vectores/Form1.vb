Public Class Form1

    'declaro una estructura
    Private Structure datos
        Public nombre As String
    End Structure

    Private Const cant = 5
    Private lista(cant) As String
    Private cont As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlAgregar.Click
        If cont = cant Then
            MsgBox("lista llena")
        Else
            lista(cont) = TextBox1.Text
            TextBox1.Text = ""
            TextBox1.Focus()
            cont = cont + 1
        End If

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If cont = cant Then
            For i = 0 To cant - 1
                ListBox1.Items.Add(lista(i).ToString)
            Next
        Else
            MsgBox("faltan cargar elementos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim posicion As Integer
        posicion = Array.IndexOf(lista, TextBox1.Text)
        If posicion >= 0 Then
            MsgBox("el elemento selecionado esta en la posicion: " & posicion)
        Else
            MsgBox("no existe")
        End If
    End Sub

    Private Sub btnOrdenar_Click(sender As Object, e As EventArgs) Handles btnOrdenar.Click
        Array.Sort(lista)
        ListBox1.Items.Clear()
        For i = 1 To UBound(lista)
            ListBox1.Items.Add(lista(i).ToString)
        Next

    End Sub
End Class
