
Imports System.IO
Public Class Form1
    Public listaDePrecios As New ArrayList
    Public stock As New ArrayList
    Public sequeda As Boolean
    Public laptops As New ArrayList
    Public Encontrado As String = ""

    Sub listarPrecios()
        Dim Datos2 As String
        Datos2 = txtMarca.Text.ToString + "=  $" + txtPrecio.Text + " (los precios varian segun la cara del cliente)"
        listaDePrecios.Add(Datos2)
    End Sub
    Sub listarFaltaDeStock()
        Dim Datos2 As String
        If Val(txtActualStock.Text) < Val(txtstockMin.Text) Then
            Datos2 = "falta stock de: " + txtMarca.Text + "= " + txtCodigo.Text
            stock.Add(Datos2)
        End If
    End Sub
    'Sub LeerArchivo()  VI EN LA CONSIGNA QUE NO PEDIA ESTO, PERO LO DEJO POR LAS DUDAS.
    '    If Not File.Exists("c:\Laptops\Laptops.txt") Then Exit Sub
    '    Dim Lee As New StreamReader("c:\Laptops\Laptops.txt")
    '    Do While Not Lee.Peek = -1
    '        laptops.Add(Lee.ReadLine)
    '    Loop
    '    Lee.Close()
    'End Sub

    Sub GrabarArchivo()
        If laptops.Count > 0 Then

            Dim Escribe As New StreamWriter("c:\Laptops\Laptops.txt")
            For Each Laptop As String In laptops
                Escribe.WriteLine(Laptop)
            Next
            Escribe.Close()

            Dim Escribestock As New StreamWriter("c:\Laptops\FaltaEsteStock.txt")
            For Each faltante As String In stock
                Escribestock.WriteLine(faltante)
            Next
            Escribestock.Close()

            Dim EscribePrecios As New StreamWriter("c:\Laptops\ListaDePrecios.txt")
            For Each precio As String In listaDePrecios
                EscribePrecios.WriteLine(precio)
            Next
            EscribePrecios.Close()
            MsgBox("Archivo grabado correctamente", MsgBoxStyle.Exclamation)

        Else
            MsgBox("No hay productos cargados!", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub
    Private Sub categorizacion(ByVal bandera As Boolean)
        Dim valor As Integer
        valor = Val(txtPrecio.Text)
        If bandera = True Then
            Select Case valor
                Case 1 To 12000
                    totCashEconomica.Text = Val(totCashEconomica.Text) + (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    totEconomica.Text = Val(totEconomica.Text) + Val(txtActualStock.Text)
                Case 12001 To 20000
                    totCashIntermedia.Text = Val(totCashIntermedia.Text) + (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    totIntermedia.Text = Val(totIntermedia) + Val(txtActualStock.Text)
                Case 20001 To 30000
                    totCashAvanzada.Text = Val(totCashAvanzada.Text) + (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    TotAvanzada.Text = Val(TotAvanzada.Text) + Val(txtActualStock.Text)
                Case 30001 To 40000
                    totCashUltGeneracion.Text = Val(totCashUltGeneracion.Text) + (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    totUltGeneracion.Text = Val(totUltGeneracion.Text) + Val(txtActualStock.Text)
                Case 40001 To 9999999
                    totCashGamer.Text = Val(totCashGamer.Text) + (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    totGamer.Text = Val(totGamer.Text) + Val(txtActualStock.Text)
            End Select
            totTotal.Text = Val(totGamer.Text) + Val(totUltGeneracion.Text) + Val(TotAvanzada.Text) + Val(totIntermedia.Text) + Val(totEconomica.Text)
            totCash.Text = Val(totCashGamer.Text) + Val(totCashUltGeneracion.Text) + Val(totCashAvanzada.Text) + Val(totCashIntermedia.Text) + Val(totCashEconomica.Text)

        ElseIf bandera = False Then
            Select Case valor
                Case 1 To 12000
                    totCashEconomica.Text = Val(totCashEconomica.Text) - (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    totEconomica.Text = Val(totEconomica.Text) - Val(txtActualStock.Text)
                Case 12001 To 20000
                    totCashIntermedia.Text = Val(totCashIntermedia.Text) - (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    totIntermedia.Text = Val(totIntermedia) - Val(txtActualStock.Text)
                Case 20001 To 30000
                    totCashAvanzada.Text = Val(totCashAvanzada.Text) - (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    TotAvanzada.Text = Val(TotAvanzada.Text) - Val(txtActualStock.Text)
                Case 30001 To 40000
                    totCashUltGeneracion.Text = Val(totCashUltGeneracion.Text) - (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    totUltGeneracion.Text = Val(totUltGeneracion.Text) - Val(txtActualStock.Text)
                Case 40001 To 9999999
                    totCashGamer.Text = Val(totCashGamer.Text) - (Val(txtPrecio.Text) * Val(txtActualStock.Text))
                    totGamer.Text = Val(totGamer.Text) - Val(txtActualStock.Text)
            End Select
            totTotal.Text = Val(totGamer.Text) + Val(totUltGeneracion.Text) + Val(TotAvanzada.Text) + Val(totIntermedia.Text) + Val(totEconomica.Text)
            totCash.Text = Val(totCashGamer.Text) + Val(totCashUltGeneracion.Text) + Val(totCashAvanzada.Text) + Val(totCashIntermedia.Text) + Val(totCashEconomica.Text)
        End If


    End Sub
    Sub BuscarLaptop(ByVal equipoBuscado As String)
        If laptops.Count > 0 Then
            Dim Dato As String
            Dim Caracteres As Integer
            Dim Posicion, posicion2 As Integer

            For Each laptop As String In laptops
                Posicion = laptop.IndexOf(",")
                Dato = laptop.Substring(0, Posicion)
                If Dato = equipoBuscado Then
                    Encontrado = laptop.ToString
                    txtCodigo.Text = Dato
                    Posicion = laptop.IndexOf(",")
                    posicion2 = laptop.IndexOf("!")
                    Caracteres = (posicion2) - (Posicion + 1)
                    Dato = laptop.Substring(Posicion + 1, Caracteres)
                    txtMarca.Text = Dato
                    Posicion = laptop.IndexOf("!")
                    posicion2 = laptop.IndexOf("@")
                    Caracteres = (posicion2) - (Posicion + 1)
                    Dato = laptop.Substring(Posicion + 1, Caracteres)
                    txtModelo.Text = Dato
                    Posicion = laptop.IndexOf("@")
                    posicion2 = laptop.IndexOf("#")
                    Caracteres = (posicion2) - (Posicion + 1)
                    Dato = laptop.Substring(Posicion + 1, Caracteres)
                    txtProcesador.Text = Dato
                    Posicion = laptop.IndexOf("#")
                    posicion2 = laptop.IndexOf("$")
                    Caracteres = (posicion2) - (Posicion + 1)
                    Dato = laptop.Substring(Posicion + 1, Caracteres)
                    txtPantalla.Text = Dato
                    Posicion = laptop.IndexOf("$")
                    posicion2 = laptop.IndexOf("%")
                    Caracteres = (posicion2) - (Posicion + 1)
                    Dato = laptop.Substring(Posicion + 1, Caracteres)
                    txtRam.Text = Dato
                    Posicion = laptop.IndexOf("%")
                    posicion2 = laptop.IndexOf("/")
                    Caracteres = (posicion2) - (Posicion + 1)
                    Dato = laptop.Substring(Posicion + 1, Caracteres)
                    txtDisco.Text = Dato
                    Posicion = laptop.IndexOf("%")
                    posicion2 = laptop.IndexOf("/")
                    Caracteres = (posicion2) - (Posicion + 1)
                    Dato = laptop.Substring(Posicion + 1, Caracteres)
                    txtActualStock.Text = Dato.ToString
                    Posicion = laptop.IndexOf("/")
                    posicion2 = laptop.IndexOf("*")
                    Caracteres = (posicion2) - (Posicion + 1)
                    Dato = laptop.Substring(Posicion + 1, Caracteres)
                    txtstockMin.Text = Dato.ToString
                    Posicion = laptop.IndexOf("*")
                    posicion2 = laptop.IndexOf(";")
                    Caracteres = (posicion2) - (Posicion + 1)
                    Dato = laptop.Substring(Posicion + 1, Caracteres)
                    txtPrecio.Text = Dato.ToString

                End If
            Next
        Else
            MsgBox("Equipo no encontrado", MsgBoxStyle.Critical)
            Encontrado = ""
        End If
    End Sub

    Sub CargarLista()
        If laptops.Count >= 0 Then
            laptops.Sort()
            LstLaptops.Items.Clear()
            Dim codigo As String
            For Each laptop As String In laptops
                codigo = laptop.Substring(0, laptop.IndexOf(","))
                LstLaptops.Items.Add(codigo.ToString)
            Next
        End If
    End Sub

    Sub LimpiarForm()
        txtCodigo.Text = ""
        txtMarca.Text = ""
        txtModelo.Text = ""
        txtProcesador.Text = ""
        txtPantalla.Text = ""
        txtRam.Text = ""
        txtDisco.Text = ""
        txtActualStock.Text = ""
        txtstockMin.Text = ""
        txtPrecio.Text = ""
        txtCodigo.Focus()

    End Sub

    Sub AgregarLaptop()
        Dim Datos As String
        Datos = txtCodigo.Text + "," + txtMarca.Text + "!" + txtProcesador.Text + "@" + txtPantalla.Text + "#" + txtRam.Text + "$" + txtDisco.Text + "%" + txtActualStock.Text + "/" + txtstockMin.Text + "*" + txtPrecio.Text + ";"
        laptops.Add(Datos)
    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtCodigo.Text <> "" And txtMarca.Text <> "" And txtProcesador.Text <> "" And txtPantalla.Text <> "" And txtRam.Text <> "" And txtDisco.Text <> "" And txtActualStock.Text <> "" And txtstockMin.Text <> "" And txtPrecio.Text <> "" And Val(txtPrecio.Text) > 0 And Val(txtPrecio.Text) < 50000 Then
            Call listarFaltaDeStock()
            Call listarPrecios()
            Call AgregarLaptop()
            Call CargarLista()
            sequeda = True
            Call categorizacion(sequeda)
            Call LimpiarForm()
            txtCodigo.Focus()
        Else
            MsgBox("Datos erroneos o nulos", MsgBoxStyle.Question)
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        If MsgBox("DESEA GRABAR EL ARCHIVO ANTES DE SALIR?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "CONSULTA") = MsgBoxResult.Ok Then
            Call GrabarArchivo()
        End If

        End
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Call GrabarArchivo()
    End Sub

    Private Sub frmAgenda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Seguro va a salir?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    'Private Sub frmAgenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    Call LeerArchivo()
    '    Call CargarLista()
    'End Sub

    Private Sub lstContactos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstLaptops.SelectedIndexChanged
        Call BuscarLaptop(LstLaptops.SelectedItem.ToString)
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtCodigo.Text <> "" Then
            Call BuscarLaptop(txtCodigo.Text)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If Encontrado <> "" Then
            If MsgBox("Seguro va a ELIMINAR?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                laptops.Remove(Encontrado)
                Encontrado = ""
                sequeda = False
                Call categorizacion(sequeda)
                Call LimpiarForm()
                Call CargarLista()
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Encontrado <> "" Then
            If txtCodigo.Text <> "" And txtMarca.Text <> "" And txtProcesador.Text <> "" And txtPantalla.Text <> "" And txtRam.Text <> "" And txtDisco.Text <> "" And txtActualStock.Text <> "" And txtstockMin.Text <> "" And txtPrecio.Text <> "" And Val(txtPrecio.Text) > 0 And Val(txtPrecio.Text) < 50000 Then
                If MsgBox("Seguro va a MODIFICAR?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    laptops.Remove(Encontrado)
                    Encontrado = ""
                    Call AgregarLaptop()
                    Call CargarLista()
                    sequeda = True
                    Call categorizacion(sequeda)
                    If Val(txtActualStock.Text) < Val(txtstockMin.Text) Then
                        Call listarFaltaDeStock()
                    End If
                    Call LimpiarForm()
                    txtCodigo.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        If LstLaptops.Items.Count > 0 Then
            LstLaptops.SetSelected(0, True)
            Call BuscarLaptop(LstLaptops.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        If LstLaptops.Items.Count > 0 Then
            LstLaptops.SetSelected(LstLaptops.Items.Count - 1, True)
            Call BuscarLaptop(LstLaptops.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If LstLaptops.Items.Count > 0 Then
            If LstLaptops.SelectedIndex > 0 Then
                LstLaptops.SetSelected(LstLaptops.SelectedIndex - 1, True)
                Call BuscarLaptop(LstLaptops.SelectedItem.ToString)
            End If
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If LstLaptops.Items.Count > 0 Then
            If LstLaptops.SelectedIndex < (LstLaptops.Items.Count - 1) Then
                LstLaptops.SetSelected(LstLaptops.SelectedIndex + 1, True)
                Call BuscarLaptop(LstLaptops.SelectedItem.ToString)
            End If
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtActualStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtActualStock.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtstockMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtstockMin.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
End Class
