Public Class Form1
    Public Structure arrai
        Public codigo As String
        Public nombre As String
        Public superficie As Double
    End Structure

    Public limite As Integer = 9

    Public encontrado As Integer

    Public vector(limite) As arrai


    Sub buscar(ByVal id_ciudad As Integer)
        txt_codigo.Text = vector(id_ciudad).codigo
        txt_nombre.Text = vector(id_ciudad).nombre
        txt_superficie.Text = vector(id_ciudad).superficie
    End Sub

    Sub cargarlist()
        lst_cuidades.Items.Clear()

        Dim i As Integer

        For i = 0 To limite
            If vector(i).codigo <> "" Then
                lst_cuidades.Items.Add(vector(i).codigo.ToString)
            End If
        Next
    End Sub

    Sub limpiarForm()
        txt_codigo.Text = ""
        txt_nombre.Text = ""
        txt_superficie.Text = ""
    End Sub

    'INDICE SELECCIONADO
    Private Sub lst_cuidades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lst_cuidades.SelectedIndexChanged
        If lst_cuidades.SelectedIndex >= 0 Then
            encontrado = lst_cuidades.SelectedIndex
            Call buscar(encontrado)

        Else
            Call limpiarForm()
        End If
    End Sub



    'BOTON AGREGAR
    Private Sub btn_agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_agregar.Click
        If (txt_codigo.Text <> "") And (txt_nombre.Text <> "") And (txt_superficie.Text <> "") Then
            Dim posicion As Integer
            posicion = lst_cuidades.Items.Count()

            If Val(txt_superficie.Text) > 0 And Val(txt_superficie.Text) <= 2000 Then

                If posicion <= limite Then
                    vector(posicion).codigo = txt_codigo.Text
                    vector(posicion).nombre = txt_nombre.Text
                    vector(posicion).superficie = Val(txt_superficie.Text)

                    'case de superficie
                    Dim valor As Integer
                    valor = Val(txt_superficie.Text)


                    Select Case valor
                        Case 0 To 10
                            tot_pueblo.Text = Val(tot_pueblo.Text) + 1
                        Case 11 To 100
                            tot_localidad.Text = Val(tot_localidad.Text) + 1
                        Case 101 To 1000
                            tot_cuidad.Text = Val(tot_cuidad.Text) + 1
                        Case 1001 To 2000
                            tot_metro.Text = Val(tot_metro.Text) + 1
                    End Select
                


                tot_total.Text = Val(tot_pueblo.Text) + Val(tot_localidad.Text) + Val(tot_cuidad.Text) + Val(tot_metro.Text)



                Call limpiarForm()
                Call cargarlist()
                End If

            Else 'si es menor a cero o mayor a 2000
                MsgBox("Ese valor no esta permitido")
            End If

        Else 'si los campos txt estan vacios
            MsgBox("Tenes que cargar los campos", MsgBoxStyle.Information)
        End If
    End Sub

    'BOTON BUSCAR
    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click

        If lst_cuidades.Items.Count > 0 Then

            If txt_codigo.Text <> "" Then
                Dim i As Integer
                Dim bandera As Boolean

                For i = 0 To limite
                    If txt_codigo.Text = vector(i).codigo Then
                        encontrado = i
                        Call buscar(encontrado)
                        bandera = True
                    End If
                Next

                If bandera = False Then
                    MsgBox("No se encontro esa Cuidad", MsgBoxStyle.Information)
                End If

            Else
                MsgBox("Tenes que cargar el Codigo", MsgBoxStyle.Critical)
            End If
        Else 'si el list esta vacio
            MsgBox("No agregaste cuidades aun", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        Call limpiarForm()
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

End Class
