Public Class Form1

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Dim Cadena, Cadena2 As String
        Dim Parametro As Integer

        'txtCadena.Text = "HOLA MUNDO"

        Cadena = txtCadena.Text
        Cadena2 = txtCadena2.Text
        Parametro = Val(txtParametro.Text)


        'BUSCAR CADENA
        'lblResultado.Text = Cadena.IndexOf(Cadena2, Parametro)

        'BUSCA ULTIMA APARICION DE UNA CADENA
        'lblResultado.Text = Cadena.LastIndexOf(Cadena2)

        'CANTIDAD DE CARACTERES
        'lblResultado.Text = Cadena2.Length

        'DEVOLVER CARACTER DE LA CADENA
        'If Parametro < Cadena.Length Then
        '    lblResultado.Text = Cadena.Chars(Parametro)
        'Else
        '    lblResultado.Text = "VALOR FUERA DE RANGO"
        'End If

        'REEMPLAZAR UNA CADENA POR OTRA
        'lblResultado.Text = Cadena.Replace("LOCO", Cadena2)

        'COMPROBAR CON QUE COMIENZA
        'If Cadena.StartsWith(Cadena2) Then
        '    lblResultado.Text = "ENCONTRE"
        'Else
        '    lblResultado.Text = ""
        'End If

        'COMPROBAR CON QUE TERMINA
        'If Cadena.EndsWith(Cadena2) Then
        '    lblResultado.Text = "ENCONTRE"
        'Else
        '    lblResultado.Text = "NO ENCONTRE"
        'End If

        'INSERTAR UNA CADENA
        'lblResultado.Text = Cadena.Insert(Parametro, Cadena2)

        'ELIMINA PARTE DE LA CADENA
        'lblResultado.Text = Cadena.Remove(Parametro, Val(Cadena2))
        'lblResultado.Text = Cadena.Remove(Parametro, Cadena2.Length)

        'CONVIERTE A MINUSCULA
        'lblResultado.Text = Cadena.ToLower


        'CONVIERTE A MAYUSCULA
        'lblResultado.Text = Cadena.ToUpper

        'ELIMINA ESPACIOS
        'lblResultado.Text = Cadena.Trim

        'ELIMINA OTROS CARACTERES
        'lblResultado.Text = Cadena.Trim(" ", "!", "-", "?", "#")

        'ALINEA A LA IZQUIERDA
        'lblResultado.Text = Cadena.PadLeft(20)

        'ALINEA A LA DERECHA
        'lblResultado.Text = Cadena.PadRight(10)

        'EXTRAE CADENA
        'lblResultado.Text = Cadena.Substring(Parametro, Val(Cadena2))
        'lblResultado.Text = Cadena.Substring(Parametro, Cadena2.Length)


        ''EJEMPLO COMBINACION DE FUNCIONES
        'BUSCAR CADENA  DESCONOCIDA Y EXTRAER EL RESTO DE LA CADENA
        'lblResultado.Text = Cadena.Substring(Cadena.IndexOf(Cadena2), (Cadena.Length - Cadena.IndexOf(Cadena2)))

    End Sub

    Private Sub txtCadena_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCadena.TextChanged

    End Sub
End Class
