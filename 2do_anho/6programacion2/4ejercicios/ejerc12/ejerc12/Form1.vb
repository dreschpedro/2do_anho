Public Class Form1
    'Estructura de tipo registro
    Private Structure agenda
        Public dominio As String
        Public anio As Integer
        Public color As String
        Public marca As String
        Public tipo As String
    End Structure

    Public anio As Integer

    'limite de autos a cargar
    Public Const limite As Integer = 2

    'declaro el array de tipo registro
    Private flota(limite) As agenda

    'variable para contacto encontrado
    Private encontrado As Integer = -1

    '######################################################################################
    '#######                       SUBRUTINAS                         #####################
    '######################################################################################

    'Form Closing
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Desea cerrar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    'FORM load
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmb_tipo.DropDownStyle = ComboBoxStyle.DropDownList 'despliega opciones del combobox TIPO
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

        btn_salir.BackColor = Color.PowderBlue
        btn_limpiar.BackColor = Color.LightSalmon
        'se agregan opciones al combo box
        cmb_tipo.Items.Add("Pick Up")
        cmb_tipo.Items.Add("Crossover")
        cmb_tipo.Items.Add("SUV")
        cmb_tipo.Items.Add("Coupé")
        cmb_tipo.Items.Add("Sedán")
    End Sub

    'cargar list
    Sub cargar_list()

        If flota.Count > 0 Then

            'lst_vehiculos.Sorted()

            lst_vehiculos.Items.Clear() 'limpio el listo para cargarlo de nuevo ---> engaña pichanga

            Dim i As Integer
            For i = 0 To limite
                If flota(i).dominio <> "" Then 'si hay algo en el campo dominio
                    lst_vehiculos.Items.Add(flota(i).dominio.ToString) 'agrega el campo dominio
                End If
            Next
        End If
        
    End Sub

    'limpiar form
    Sub limpiar_form()
        txt_dominio.Text = ""
        txt_anio.Text = ""
        txt_color.Text = ""
        txt_marca.Text = ""
        cmb_tipo.SelectedIndex = -1
        txt_dominio.Focus()
    End Sub

    'buscar auto
    Sub buscar_auto(ByVal id_auto As Integer)
        'se busca el contacto y se muestran los datos
        txt_dominio.Text = flota(id_auto).dominio
        cmb_tipo.Text = flota(id_auto).tipo
        txt_color.Text = flota(id_auto).color
        txt_marca.Text = flota(id_auto).marca
        txt_anio.Text = flota(id_auto).anio
    End Sub

    'antiguedad auto
    Sub antig()
        If lst_vehiculos.Items.Count > 0 Then 'si hay elementos en el list
            'Select Case 
            '    Case 1980
            'lbl_clasico.Text = lbl_clasico.Text + 1

            'End Select
        End If
    End Sub

    '###########################################################################################
    '###############                       BOTONES                             #################
    '###########################################################################################

    'BTN salir
    Private Sub btn_salir_Click(sender As System.Object, e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    'btn limpiar
    Private Sub btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles btn_limpiar.Click
        Call limpiar_form()
    End Sub

    'btn agregar
    Private Sub btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar.Click
        If (txt_dominio.Text <> "") And (txt_anio.Text <> "") And (cmb_tipo.SelectedIndex <> -1) And (txt_marca.Text <> "") And (txt_color.Text <> "") Then

            Dim ultimo As Integer ' defino cual es ultimo item cargado
            ultimo = lst_vehiculos.Items.Count

            If ultimo <= limite Then ' si es menor al limite, cargo
                flota(ultimo).dominio = txt_dominio.Text.ToString
                flota(ultimo).anio = Val(txt_anio.Text).ToString
                flota(ultimo).color = txt_color.Text.ToString
                flota(ultimo).marca = txt_marca.Text.ToString
                flota(ultimo).tipo = cmb_tipo.Text.ToString

                Call antig()
                Call limpiar_form()

                Call cargar_list()

            Else
                MsgBox("No puede cargar mas contactos", MsgBoxStyle.Critical, "Atencion")
            End If
        Else
            MsgBox("Ingrese todos los datos!", MsgBoxStyle.Information, "Atención")
        End If

    End Sub

    'btn modificar
    Private Sub btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles btn_modificar.Click

        If (lst_vehiculos.SelectedIndex <> -1) Then 'si se selecciono un auto

            If (txt_dominio.Text <> "") And (txt_anio.Text <> "") And (cmb_tipo.SelectedIndex <> -1) And (txt_marca.Text <> "") And (txt_color.Text <> "") Then
                'si no estan vacios los campos

                If encontrado >= 0 Then 'si hay un indice valido seleccionado, si es -1, no hay nada seleccionado
                    flota(encontrado).dominio = txt_dominio.Text.ToString
                    flota(encontrado).anio = txt_anio.Text.ToString
                    flota(encontrado).color = txt_color.Text.ToString
                    flota(encontrado).marca = txt_marca.Text.ToString
                    flota(encontrado).tipo = cmb_tipo.Text.ToString
                    
                    Call limpiar_form() 'limpia el form
                    Call cargar_list()
                End If
            End If
        End If
    End Sub

    'btn eliminar
    Private Sub btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles btn_eliminar.Click

        If (lst_vehiculos.SelectedIndex <> -1) Then
            'primero debe haber seleccionado el auto en el List o haberlo Buscado

            'si hay un indice valido seleccionado, si es -1, no hay nada seleccionado
            If encontrado >= 0 Then
                'vacio el vector selecionado
                flota(encontrado).dominio = ""
                flota(encontrado).anio = 0
                flota(encontrado).color = ""
                flota(encontrado).marca = ""
                flota(encontrado).tipo = ""


                'reaordeno el vector
                Dim i As Integer

                If encontrado < limite Then 'en otras palabras, si el indice seleccionado no es el último

                    For i = encontrado + 1 To limite
                        If (flota(i).dominio <> "") Then 'si el indice posterior al selecionado tiene datos cargados
                            'cargo los datos del siguiente indice al indice que elimine
                            flota(i - 1).dominio = flota(i).dominio.ToString
                            flota(i - 1).anio = flota(i).anio.ToString
                            flota(i - 1).color = flota(i).color.ToString
                            flota(i - 1).marca = flota(i).marca.ToString
                            flota(i - 1).tipo = flota(i).tipo.ToString
                        End If

                        'vacio los campos
                        flota(i).dominio = ""
                        flota(i).anio = 0
                        flota(i).color = ""
                        flota(i).marca = ""
                        flota(i).tipo = ""
                    Next
                End If

                Call cargar_list()
                Call limpiar_form()

            End If
        End If
    End Sub

    'btn buscar
    Private Sub btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles btn_buscar.Click
        If lst_vehiculos.Items.Count > 0 Then 'verifico que el list este cargado

            Dim dato_buscado As String
            dato_buscado = txt_dominio.Text

            If dato_buscado <> "" Then 'busco por el dominio

                Dim i As Integer
                Dim bandera As Boolean = False

                For i = 0 To limite
                    If dato_buscado = flota(i).dominio Then 'si hay algun dominio (i) guardado igual al list
                        encontrado = i                      'guarda la posicion
                        Call buscar_auto(encontrado)        'busca los datos de ese domicio
                        bandera = True                      'el enano levanta la bandera para dejar de buscar
                    End If
                Next
                If bandera = False Then
                    MsgBox("no existe el contacto", MsgBoxStyle.Information, "ATENCIÓN") 'si no hay ningun auto con ese codigo
                End If
            Else
                MsgBox("Ingresá el codigo en el campo Dominio", MsgBoxStyle.Information, "ATENCIÓN") 'si no esta cargado el campo Dominio
            End If
        Else
            MsgBox("Tenes que ingresar autos para poder buscar", MsgBoxStyle.Information, "ATENCIÓN") 'Si no hay ningun auto cargado
        End If
    End Sub

    '###########################################################################################
    '###############                       MOSTRAR                             #################
    '###########################################################################################

    'LISTBOX - índice selecionado
    Private Sub lst_vehiculos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lst_vehiculos.SelectedIndexChanged
        If lst_vehiculos.SelectedIndex >= 0 Then
            encontrado = lst_vehiculos.SelectedIndex
            Call buscar_auto(encontrado)
        Else
            Call limpiar_form()
        End If
    End Sub

End Class