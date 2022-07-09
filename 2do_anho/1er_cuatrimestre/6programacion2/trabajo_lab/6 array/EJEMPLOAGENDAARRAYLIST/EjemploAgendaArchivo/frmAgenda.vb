Public Class frmAgenda
    'declaro un vector ArrayList para trabajar
    Public Personas As New ArrayList

    Sub BuscarPersona(ByVal NombreBuscado As String)
        'subrutina para buscar una persona en el arraylist y traer los datos
        If Personas.Count > 0 Then
            Dim Dato As String
            Dim Caracteres As Integer
            Dim Posicion As Integer
            'recorro el ArrayList
            For Each Persona As String In Personas
                'extraigo cada nombre
                Posicion = Persona.IndexOf(",")
                Dato = Persona.Substring(0, Posicion)
                'si coincide traigo el resto de los datos
                If Dato = NombreBuscado Then
                    'cargo el nombre
                    txtNombre.Text = Dato
                    'extraigo telefono
                    'cantidad de caracteres a extraer
                    Caracteres = Persona.LastIndexOf(",") - (Posicion + 1)
                    'extraigo cadena
                    Dato = Persona.Substring(Posicion + 1, Caracteres)
                    txtTel.Text = Dato
                    'extraigo mail
                    'cantidad de caracteres a extraer
                    Caracteres = Persona.Length - (Persona.LastIndexOf(",") + 2)
                    'extraigo cadena
                    Dato = Persona.Substring(Persona.LastIndexOf(",") + 1, Caracteres)
                    txtEmail.Text = Dato

                End If
            Next
        Else
            MsgBox("Contacto no encontrado", MsgBoxStyle.Critical)
        End If
    End Sub

    Sub CargarList()
        'SUBRUTINA extraigo los nombres del arraylist y los cargo en el list
        If Personas.Count > 0 Then
            lstContactos.Items.Clear()
            Dim Nombre As String
            'recorro el ArrayList
            For Each Persona As String In Personas
                'extraigo cada nombre
                Nombre = Persona.Substring(0, Persona.IndexOf(","))
                'cargo en el list
                lstContactos.Items.Add(Nombre.ToString)
            Next
        End If
    End Sub

    Sub LimpiarForm()
        txtNombre.Text = ""
        txtTel.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'consulto que esten cargados todos los datos
        If txtNombre.Text <> "" And txtTel.Text <> "" And txtEmail.Text <> "" Then
            'agrego una persona al Arraylist
            Dim Datos As String
            Datos = txtNombre.Text + "," + txtTel.Text + "," + txtEmail.Text + ";"
            Personas.Add(Datos)
            'cargo el list
            Call CargarList()
            'limpio el form
            Call LimpiarForm()
            txtNombre.Focus()
        Else
            MsgBox("Y los datos?", MsgBoxStyle.Question)
        End If
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        'muestro el contenido en la consola
        If Personas.Count > 0 Then
            Debug.Print("----------")
            Dim i As Integer
            'recorro el ArrayList
            For Each Persona As String In Personas
                i += 1
                Debug.Print(i & ":" & Persona)
            Next
        Else
            Debug.Print("No hay personas en la lista")
        End If
    End Sub

    Private Sub lstContactos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstContactos.SelectedIndexChanged
        'busco la persona seleccionada a partir del nombre
        Call BuscarPersona(lstContactos.SelectedItem.ToString)
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        'vacio el form
        Call LimpiarForm()
    End Sub

 
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Call BuscarPersona(txtNombre.Text)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click

    End Sub
End Class
