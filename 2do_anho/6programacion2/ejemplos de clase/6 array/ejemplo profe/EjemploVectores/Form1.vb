Public Class Form1

    'DECLARO UNA ESTRUCTURA
    Private Structure Datos
        Public Nombre As String
        Public Edad As Integer
        Public Telefono As String
    End Structure

    Private Const CANT = 5
    Private Lista(CANT) As String
    Private Cont As Integer = 0

    'crear un vector del tipo STRUCTURE
    Private AGENDA(CANT) As Datos


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'PRIMERO PREGUNTO SI EL VECTOR ESTA COMPLETO
        If Cont = CANT Then
            MsgBox("LISTA LLENA")
        Else
            'guardo el nombre en la structura
            'AGENDA(Cont).Nombre = TextBox1.Text

            Lista(Cont) = TextBox1.Text
            TextBox1.Text = ""
            TextBox1.Focus()
            Cont = Cont + 1
        End If

    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        ' si esta todo cargado muestro en list
        If Cont = CANT Then
            Dim I As Integer
            'recorro el array
            For I = 0 To CANT - 1
                ListBox1.Items.Add(Lista(I).ToString)
                'ListBox1.Items.Add(AGENDA(I).Nombre.ToString)
            Next
        Else
            MsgBox("FALTAN CARGAR ELEMENTOS", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim Posicion As Integer

        'busca en un array y devuelve la posicion del objeto
        Posicion = Array.IndexOf(Lista, TextBox1.Text)

        'si devuelve -1 no existe
        If Posicion >= 0 Then
            MsgBox("El elemento esta en posicion: " & Posicion)
        Else
            MsgBox("NO EXISTE")
        End If

    End Sub

    Private Sub btnOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
        'ordeno la lista
        Array.Sort(Lista)

        'limpio el list
        ListBox1.Items.Clear()

        'cargo nuevamente
        'UBOUND DEVUELVE EL LIMITE SUPERIOR DE UN ARRAY
        For I = 1 To UBound(Lista)
            ListBox1.Items.Add(Lista(I).ToString)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
