Public Class Form1

    'declaro la Estructura de Datos tipo Registro
    Private Structure Agenda
        Public Nombre As String
        Public Telefono As String
        Public localidad As String
        Public CodPos As String
    End Structure

    'declaro la constante para la cantidad de contactos
    Public Const LIMITE As Integer = 5

    'declaro un Vector de tipo Registro
    Private Personas(LIMITE) As Agenda

    'variable para Contacto Encontrado
    Private Encontrado As Integer = -1

    Private Sub CargarList()
        'cargo el list con los nombres
        lstNombres.Items.Clear()

        Dim I As Integer
        For I = 0 To LIMITE
            'recorro el Vector
            If Personas(I).Nombre <> "" Then
                lstNombres.Items.Add(Personas(I).Nombre.ToString)
            End If
        Next

    End Sub

    Private Sub LimpiarForm()
        'LIMPIO EL FORMULARIO
        txtNombre.Text = ""
        txtTelefono.Text = ""
        txtLocalidad.Text = ""
        txtCodPos.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub BuscarContacto(ByVal idContacto As Integer)
        'busco el contacto y muestro los datos
        txtNombre.Text = Personas(idContacto).Nombre
        txtTelefono.Text = Personas(idContacto).Telefono
        txtLocalidad.Text = Personas(idContacto).localidad
        txtCodPos.Text = Personas(idContacto).CodPos
    End Sub

    Private Sub lstNombres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstNombres.SelectedIndexChanged
        'si selecciono un elemento busco los datos y muestro
        If lstNombres.SelectedIndex >= 0 Then
            Encontrado = lstNombres.SelectedIndex
            Call BuscarContacto(Encontrado)
        Else
            Call LimpiarForm()
        End If

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'agrego un Elemento al vector

        'controlo que esten los datos cargados
        If txtNombre.Text <> "" And txtTelefono.Text <> "" And txtLocalidad.Text <> "" And txtCodPos.Text <> "" Then
            'defino cual es el ultimo cargado
            Dim Ultimo As Integer
            Ultimo = lstNombres.Items.Count

            If Ultimo <= LIMITE Then
                'cargo el elemento
                Personas(Ultimo).Nombre = txtNombre.Text.ToString
                Personas(Ultimo).Telefono = txtTelefono.Text.ToString
                Personas(Ultimo).localidad = txtLocalidad.Text.ToString
                Personas(Ultimo).CodPos = txtCodPos.Text.ToString

                'limpio los text
                Call LimpiarForm()

                'refresco el list
                Call CargarList()
            Else
                MsgBox("NO PUEDE CARGAR MAS CONTACTOS", MsgBoxStyle.Critical, "Agenda")
            End If
        Else
            MsgBox("INGRESE TODOS LOS DATOS!", MsgBoxStyle.Critical, "Agenda")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click

        'muestro el contenido del vector en la ventana inmediato
        Dim I As Integer
        Debug.Print("AGENDA")
        Debug.Print("=====")

        'recorro el vector
        For I = 0 To LIMITE
            'recorro el Vector
            If Personas(I).Nombre <> "" Then
                Debug.Print(I.ToString + " - " + Personas(I).Nombre.ToString + " / " + Personas(I).Telefono.ToString + " / " + Personas(I).localidad.ToString + " / " + Personas(I).CodPos.ToString)
            End If
        Next
    End Sub
 
    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Call LimpiarForm()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'BUSCO UN CONTACTO POR NUMERO DE TELEFONO
        If txtTelefono.Text <> "" Then
            'recorro el vector
            Dim I As Integer

            Dim Bandera As Boolean = False

            For I = 0 To LIMITE
                If txtTelefono.Text = Personas(I).Telefono Then
                    'si encuentro busco los datos
                    Encontrado = I
                    Call BuscarContacto(Encontrado)
                    Bandera = True
                End If
            Next
            If Bandera = False Then MsgBox("NO EXISTE EL CONTACTO", MsgBoxStyle.Information, "Agenda")
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'MODIFICO LOS DATOS DEL CONTACTO EXISTENTE

        If (lstNombres.SelectedIndex <> -1) Then
            If txtNombre.Text <> "" And txtTelefono.Text <> "" And txtLocalidad.Text <> "" And txtCodPos.Text <> "" Then
                'primero debe haber seleccionado el Contacto en el List o haberlo Buscado
                If Encontrado >= 0 Then
                    'no permite modificar nombre
                    Personas(Encontrado).Telefono = txtTelefono.Text.ToString
                    Personas(Encontrado).localidad = txtLocalidad.Text.ToString
                    Personas(Encontrado).CodPos = txtCodPos.Text.ToString
                    Call LimpiarForm()
                    Call CargarList()
                End If
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        'ELIMINO EL CONTACTO SELECCIONADO
        If txtNombre.Text <> "" And txtTelefono.Text <> "" And txtLocalidad.Text <> "" And txtCodPos.Text <> "" Then
            'primero debe haber seleccionado el Contacto en el List o haberlo Buscado
            If Encontrado >= 0 Then
                'vacio el contacto
                Personas(Encontrado).Nombre = ""
                Personas(Encontrado).Telefono = ""
                Personas(Encontrado).localidad = ""
                Personas(Encontrado).CodPos = ""

                'reordeno el vector
                Dim I As Integer
                If Encontrado < LIMITE Then
                    For I = Encontrado + 1 To LIMITE
                        If Personas(I).Nombre <> "" Then
                            Personas(I - 1).Nombre = Personas(I).Nombre.ToString
                            Personas(I - 1).Telefono = Personas(I).Telefono.ToString
                            Personas(I - 1).localidad = Personas(I).localidad.ToString
                            Personas(I - 1).CodPos = Personas(I).CodPos.ToString
                        End If
                        Personas(I).Nombre = ""
                        Personas(I).Telefono = ""
                        Personas(I).localidad = ""
                        Personas(I).CodPos = ""
                    Next
                End If

                Call CargarList()

                Call LimpiarForm()
            End If
        End If

    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        'selecciono en el list el primero
        If lstNombres.Items.Count > 0 Then
            lstNombres.SetSelected(0, True)
            'buscar el nombre a partir del List
            Call BuscarContacto(lstNombres.SelectedIndex)
        End If
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        'selecciono en el list el ultimo
        If lstNombres.Items.Count > 0 Then
            lstNombres.SetSelected(lstNombres.Items.Count - 1, True)
            'buscar el nombre a partir del List
            Call BuscarContacto(lstNombres.SelectedIndex)
        End If
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        'selecciono en el list  el anterior al que esta seleccionado
        If lstNombres.Items.Count > 0 Then
            If lstNombres.SelectedIndex > 0 Then
                lstNombres.SetSelected(lstNombres.SelectedIndex - 1, True)
                'buscar el nombre a partir del List
                Call BuscarContacto(lstNombres.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        'selecciono en el list el siguiente al que esta seleccionado
        If lstNombres.Items.Count > 0 Then
            If lstNombres.SelectedIndex < (lstNombres.Items.Count - 1) Then
                lstNombres.SetSelected(lstNombres.SelectedIndex + 1, True)
                'buscar el nombre a partir del List
                Call BuscarContacto(lstNombres.SelectedIndex)
            End If
        End If
    End Sub

End Class
