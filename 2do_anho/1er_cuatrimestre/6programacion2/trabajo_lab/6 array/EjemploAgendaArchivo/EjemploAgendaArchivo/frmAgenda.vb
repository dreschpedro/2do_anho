'importo el espacio de nombres necesario
Imports System.IO

Public Class frmAgenda
    'declaro un vector ArrayList para trabajar
    Public Personas As New ArrayList
    'variable para dato encontrado
    Public Encontrado As String = ""

    Sub LeerArchivo()
        'subrutina para leer los datos del archivo de texto

        'controlo que exista el archivo
        If Not File.Exists("c:\agenda\agenda.txt") Then Exit Sub

        'abro el archivo
        Dim Lee As New StreamReader("c:\agenda\agenda.txt")

        'recorro y leo linea por linea
        Do While Not Lee.Peek = -1
            'cargo cada linea en el arraylist
            Personas.Add(Lee.ReadLine)
        Loop

        'cierro el archivo
        Lee.Close()
    End Sub

    Sub GrabarArchivo()
        'consulto que el ArrayList este cargado
        If Personas.Count > 0 Then

            'creo el archivo txt y escribo en archivo
            Dim Escribe As New StreamWriter("c:\agenda\agenda.txt")

            'recorro el ArrayList
            For Each Persona As String In Personas
                'grabo cada linea del arraylis
                Escribe.WriteLine(Persona)
            Next

            'cierro el archivo
            Escribe.Close()

            MsgBox("Archivo grabado correctamente", MsgBoxStyle.Exclamation)
        Else
            MsgBox("No hay contactos cargados!", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub

    Sub BuscarPersona(ByVal NombreBuscado As String)
        'subrutina para buscar una persona por el nombre en el arraylist y traer los datos
        If Personas.Count > 0 Then
            'defino variables de busqueda
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
                    'si encuentra guarda el valor en la variable
                    Encontrado = Persona.ToString
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
            'si no encuentra limpia la variable
            Encontrado = ""
        End If
    End Sub

    Sub CargarList()
        'SUBRUTINA extraigo los nombres del arraylist y los cargo en el list
        If Personas.Count > 0 Then
            'PRIMERO ORDENO EL ARRAY
            Personas.Sort()

            'LUEGO CARGO EL LIST
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

    Sub AgregarPersona()
        'agrego una persona al Arraylist
        Dim Datos As String
        Datos = txtNombre.Text + "," + txtTel.Text + "," + txtEmail.Text + ";"
        Personas.Add(Datos)
    End Sub

    'btn agregar
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'consulto que esten cargados todos los datos
        If txtNombre.Text <> "" And txtTel.Text <> "" And txtEmail.Text <> "" Then
            Call AgregarPersona()
            'cargo el list
            Call CargarList()
            'limpio el form
            Call LimpiarForm()
            txtNombre.Focus()
        Else
            MsgBox("Y los datos?", MsgBoxStyle.Question)
        End If
    End Sub
    'btn salir
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        'antes de salir pregunto si desea grabar

        If MsgBox("DESEA GRABAR EL ARCHIVO ANTES DE SALIR?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "CONSULTA") = MsgBoxResult.Ok Then
            Call GrabarArchivo()
        End If

        'DESPUES CIERRO
        End
    End Sub

    'btn mostrar
    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        'muestro el contenido en la consola
        If Personas.Count > 0 Then
            Debug.Print("----------")
            Debug.Print("AGENDA")
            Debug.Print("==========")
            Debug.Print("NRO:NOMBRE,TELEFONO,EMAIL")
            Debug.Print("-------------------------")
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
    'btn grabar
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Call GrabarArchivo()
    End Sub

    'form close 
    Private Sub frmAgenda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'pregunto si desea salir
        If MsgBox("Seguro va a salir?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmAgenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'primero traigo los datos del archivo
        Call LeerArchivo()

        'extraer nombres y cargar en list
        Call CargarList()
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
        'busco por nombre
        If txtNombre.Text <> "" Then
            Call BuscarPersona(txtNombre.Text)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        'primero debe haber buscado el elemento
        If Encontrado <> "" Then
            If MsgBox("Seguro va a ELIMINAR?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'elimino el valor
                Personas.Remove(Encontrado)
                'refresco
                Encontrado = ""
                Call LimpiarForm()
                Call CargarList()
            End If
        End If
    End Sub

    'btn modificar
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'primero debe haber buscado el elemento
        If Encontrado <> "" Then
            'consulto que esten cargados todos los datos
            If txtNombre.Text <> "" And txtTel.Text <> "" And txtEmail.Text <> "" Then
                'elimino el registro anterior
                If MsgBox("Seguro va a MODIFICAR?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    'elimino el REGISTRO MODIFICADO
                    Personas.Remove(Encontrado)
                    Encontrado = ""
                    'AGREGO NUEVO REGISTRO
                    Call AgregarPersona()
                    'cargo el list
                    Call CargarList()
                    'limpio el form
                    Call LimpiarForm()
                    txtNombre.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        'selecciono en el list el primero
        If lstContactos.Items.Count > 0 Then
            lstContactos.SetSelected(0, True)
            'busco la persona seleccionada a partir del nombre
            Call BuscarPersona(lstContactos.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        'selecciono en el list el ultimo
        If lstContactos.Items.Count > 0 Then
            lstContactos.SetSelected(lstContactos.Items.Count - 1, True)
            'busco la persona seleccionada a partir del nombre
            Call BuscarPersona(lstContactos.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        'selecciono en el list  el anterior al que esta seleccionado
        If lstContactos.Items.Count > 0 Then
            If lstContactos.SelectedIndex > 0 Then
                lstContactos.SetSelected(lstContactos.SelectedIndex - 1, True)
                'busco la persona seleccionada a partir del nombre
                Call BuscarPersona(lstContactos.SelectedItem.ToString)
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        'selecciono en el list el siguiente al que esta seleccionado
        If lstContactos.Items.Count > 0 Then
            If lstContactos.SelectedIndex < (lstContactos.Items.Count - 1) Then
                lstContactos.SetSelected(lstContactos.SelectedIndex + 1, True)
                'busco la persona seleccionada a partir del nombre
                Call BuscarPersona(lstContactos.SelectedItem.ToString)
            End If
        End If
    End Sub

End Class
