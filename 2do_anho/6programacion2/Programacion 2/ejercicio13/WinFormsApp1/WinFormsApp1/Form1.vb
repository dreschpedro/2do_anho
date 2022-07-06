Imports System.ComponentModel

Public Class Form1

    Public Structure lista
        Public dni As String
        Public nombre As String
        Public telefono As String
        Public deuda As Integer
    End Structure
    Public cant, totP, totM, totI, totG, totPr, peque, medio, import, grande, preferido As Integer
    Public promP, promM, promI, promG, promPr As Object
    Public sequeda As Boolean
    Public limite As Integer = 20
    Public deudores(limite) As lista
    Public encontrado As Integer = -1

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtDeuda.Text <> "" And txtdni.Text <> "" And txtNombre.Text <> "" And txtTelefono.Text <> "" Then
            cant = Val(txtDeuda.Text)
            If cant < 0 Then
                MsgBox("la casa siempre gana", MsgBoxStyle.Critical, "valor de deuda irreal")
            Else

                Dim posicion As Integer
                posicion = lbclientes.Items.Count()

                If posicion <= limite Then
                    deudores(posicion).dni = txtdni.Text
                    deudores(posicion).nombre = txtNombre.Text
                    deudores(posicion).telefono = txtTelefono.Text
                    deudores(posicion).deuda = Val(txtDeuda.Text)
                    sequeda = True
                    Call catCliente(sequeda)
                    Call cargarLista()
                    Call limpiarForm()
                Else MsgBox("te quedaste sin solvencia para usurar a la gente", MsgBoxStyle.Critical, "se la fugaron toda")
                End If

            End If
        Else MsgBox("datos erroneos o nulos", MsgBoxStyle.Critical, "error pelotude")
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtDeuda.Text <> "" And txtdni.Text <> "" And txtNombre.Text <> "" And txtTelefono.Text <> "" Then
            If encontrado >= 0 Then
                deudores(encontrado).nombre = txtNombre.Text.ToString
                deudores(encontrado).telefono = txtTelefono.Text.ToString
                deudores(encontrado).deuda = Val(txtDeuda.Text)
                sequeda = True
                Call catCliente(sequeda)
                Call limpiarForm()

            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtdni.Text <> "" Then
            Dim i As Integer
            Dim bandera As Boolean = False
            For i = 0 To limite
                If txtdni.Text = deudores(i).dni Then
                    encontrado = i
                    Call buscarCliente(encontrado)
                    bandera = True

                End If
            Next
            If bandera = False Then MsgBox("cliente no encontrado", MsgBoxStyle.Critical, "ERROR")
        ElseIf txtdni.Text = "" Then
            MsgBox("ingrese un DNI", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtDeuda.Text <> "" And txtdni.Text <> "" And txtNombre.Text <> "" And txtTelefono.Text <> "" Then
            If encontrado >= 0 Then
                deudores(encontrado).dni = ""
                deudores(encontrado).nombre = ""
                deudores(encontrado).telefono = ""
                deudores(encontrado).deuda = 0
                sequeda = False
                Call catCliente(sequeda)
            End If

            Dim i As Integer
            If encontrado < limite Then
                For i = encontrado + 1 To limite
                    If deudores(i).dni <> "" Then
                        deudores(i - 1).dni = deudores(i).dni.ToString
                        deudores(i - 1).nombre = deudores(i).nombre.ToString
                        deudores(i - 1).telefono = deudores(i).telefono.ToString
                        deudores(i - 1).deuda = deudores(i).deuda.ToString
                    End If
                    deudores(encontrado).dni = ""
                    deudores(encontrado).nombre = ""
                    deudores(encontrado).telefono = ""
                    deudores(encontrado).deuda = 0
                Next

            End If
            Call cargarLista()
            Call limpiarForm()
        End If
    End Sub

    Private Sub lbclientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbclientes.SelectedIndexChanged
        If lbclientes.SelectedIndex >= 0 Then
            encontrado = lbclientes.SelectedIndex
            Call buscarCliente(encontrado)
            cant = deudores(encontrado).deuda
            Call categorizacion(cant)
        ElseIf lbclientes.SelectedIndex = -1 Then
            Call limpiarForm()
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        If lbclientes.Items.Count > 0 Then
            lbclientes.SetSelected(0, True)
            Call buscarCliente(lbclientes.SelectedIndex)
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If lbclientes.Items.Count > 0 Then
            lbclientes.SetSelected(lbclientes.Items.Count - 1, True)
            Call buscarCliente(lbclientes.SelectedIndex)
        End If
    End Sub

    Private Sub btnSiguete_Click(sender As Object, e As EventArgs) Handles btnSiguete.Click
        If lbclientes.Items.Count > 0 Then
            If lbclientes.SelectedIndex < (lbclientes.Items.Count - 1) Then
                lbclientes.SetSelected(lbclientes.SelectedIndex + 1, True)
                Call buscarCliente(lbclientes.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If lbclientes.Items.Count > 0 Then
            If lbclientes.SelectedIndex > 0 Then
                lbclientes.SetSelected(lbclientes.SelectedIndex - 1, True)
                Call buscarCliente(lbclientes.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As CancelEventArgs) Handles btnSalir.Click
        End

    End Sub

    Private Sub catCliente(ByVal sumaOResta As Boolean)

        If sequeda = True Then
            Select Case cant
                Case 0 To 20000
                    peque += 1
                    cantPeque.Text = peque.ToString
                    totP += cant
                    totPeq.Text = totP.ToString
                    promP = totP / peque
                    promP = Fix(promP)
                    PromPeq.Text = promP.ToString
                Case 20001 To 40000
                    medio += 1
                    cantMedio.Text = medio.ToString
                    totM += cant
                    totMedio.Text = totM.ToString
                    promM = totM / medio
                    promM = Fix(promM)
                    promMedio.Text = promM.ToString
                Case 40001 To 60000
                    import += 1
                    cantImport.Text = import.ToString
                    totI += cant
                    totImport.Text = totI.ToString
                    promI = totI / import
                    promI = Fix(promI)
                    PromImport.Text = promI.ToString
                Case 60001 To 80000
                    grande += 1
                    cantGran.Text = grande.ToString
                    totG += cant
                    totGrande.Text = totG.ToString
                    promG = totG / grande
                    promG = Fix(promG)
                    PromGran.Text = promG.ToString
                Case 80000 To 99999999
                    preferido += 1
                    cantPreferencial.Text = preferido.ToString
                    totPr += cant
                    totPreferido.Text = totPr.ToString
                    promPr = totPr / preferido
                    promPr = Fix(promPr)
                    Promprefer.Text = promPr.ToString
            End Select

        ElseIf sequeda = False Then
            Select Case cant
                Case 0 To 20000
                    peque -= 1
                    cantPeque.Text = peque.ToString
                    totP -= cant
                    totPeq.Text = totP.ToString
                    promP = totP / peque
                    promP = Fix(promP)
                    PromPeq.Text = promP.ToString
                Case 20001 To 40000
                    medio -= 1
                    cantMedio.Text = medio.ToString
                    totM -= cant
                    totMedio.Text = totM.ToString
                    promM = totM / medio
                    promM = Fix(promM)
                    promMedio.Text = promM.ToString
                Case 40001 To 60000
                    import -= 1
                    cantImport.Text = import.ToString
                    totI -= cant
                    totImport.Text = totI.ToString
                    promI = totI / import
                    promI = Fix(promI)
                    PromImport.Text = promI.ToString
                Case 60001 To 80000
                    grande -= 1
                    cantGran.Text = grande.ToString
                    totG -= cant
                    totGrande.Text = totG.ToString
                    promG = totG / grande
                    promG = Fix(promG)
                    PromGran.Text = promG.ToString
                Case 80000 To 99999999
                    preferido -= 1
                    cantPreferencial.Text = preferido.ToString
                    totPr -= cant
                    totPreferido.Text = totPr.ToString
                    promPr = totPr / preferido
                    promPr = Fix(promPr)
                    promPrefer.Text = promPr.ToString
            End Select
        End If

    End Sub
    Private Sub categorizacion(ByVal cantseleccion As Integer)
        Select Case cant
            Case 0 To 20000
                categoria.Text = "PEQUEÑO"
            Case 20001 To 40000
                categoria.Text = "MEDIANO"
            Case 40001 To 60000
                categoria.Text = "IMPORTANTE"
            Case 60001 To 80000
                categoria.Text = "GRAN CLIENTE"
            Case 80000 To 99999999
                categoria.Text = "PREFERENCIAL"
        End Select
    End Sub

    Private Sub limpiarForm()
        txtDeuda.Text = ""
        txtdni.Text = ""
        txtNombre.Text = ""
        txtTelefono.Text = ""
        categoria.Text = ""
        txtdni.Focus()
    End Sub

    Private Sub buscarCliente(ByVal idcliente As Integer)
        txtDeuda.Text = deudores(idcliente).deuda
        txtdni.Text = deudores(idcliente).dni
        txtNombre.Text = deudores(idcliente).nombre
        txtTelefono.Text = deudores(idcliente).telefono
        txtdni.Focus()
    End Sub

    Private Sub cargarLista()
        lbclientes.Items.Clear()
        Dim i As Integer
        For i = 0 To limite
            If deudores(i).dni <> "" Then
                lbclientes.Items.Add(deudores(i).dni.ToString)
            End If
        Next

    End Sub

    Private Sub txtDeuda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeuda.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'numeros, Supr y backspace
            e.Handled = False 'no se controla
        Else
            e.Handled = True 'no permite ingresar letras
        End If

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Desea cerrar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            End
        End If
    End Sub
End Class
