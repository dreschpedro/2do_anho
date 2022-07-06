Imports System.ComponentModel

Public Class Form1

    Public tot, seminuevo, plancanje, usado, clasico, anio As Integer
    Public sequeda As Boolean


    'el array
    Public Structure lista
        Public dominio As String
        Public tipo As String
        Public marca As String
        Public color As String
        Public anio As Integer
    End Structure
    Public Const limite As Integer = 10
    Private vehiculos(limite) As lista
    Private encontrado As Integer = -1
    'el array


    Private Sub autoantiguedad()
        If sequeda = True Then
            If anio > 2011 Then
                seminuevo += 1
                lblsemi.Text = seminuevo.ToString
            ElseIf anio > 2000 And anio <= 2011 Then
                usado += 1
                lblusa.Text = usado.ToString
            ElseIf anio > 1990 And anio <= 2000 Then
                plancanje += 1
                lblcanje.Text = plancanje.ToString
            ElseIf anio <= 1990 Then
                clasico += 1
                lblclas.Text = clasico.ToString
            End If
            tot += 1
            Label16.Text = tot.ToString
        ElseIf sequeda = False Then
            If anio > 2011 Then
                seminuevo -= 1
                lblsemi.Text = seminuevo.ToString
            ElseIf anio > 2000 And anio <= 2011 Then
                usado -= 1
                lblusa.Text = usado.ToString
            ElseIf anio > 1990 And anio <= 2000 Then
                plancanje -= 1
                lblcanje.Text = plancanje.ToString
            ElseIf anio <= 1990 Then
                clasico -= 1
                lblclas.Text = clasico.ToString
            End If
            tot -= 1
            Label16.Text = tot.ToString
        End If

    End Sub

    Private Sub cargarlista()

        lstVehiculos.Items.Clear()

        Dim i As Integer
        For i = 0 To limite
            If vehiculos(i).dominio <> "" Then
                lstVehiculos.Items.Add(vehiculos(i).dominio.ToString)
            End If
        Next
    End Sub

    Private Sub limpiarForm()
        tbxAno.Text = ""
        tbxColor.Text = ""
        tbxMarca.Text = ""
        tbxDominio.Text = ""
        cbxTipo.Text = ""
        tbxDominio.Focus()
    End Sub

    Private Sub buscarVehiculo(ByVal idvehiculo As Integer)
        tbxAno.Text = vehiculos(idvehiculo).anio
        tbxColor.Text = vehiculos(idvehiculo).color
        tbxMarca.Text = vehiculos(idvehiculo).marca
        tbxDominio.Text = vehiculos(idvehiculo).dominio
        cbxTipo.Text = vehiculos(idvehiculo).tipo
    End Sub

    Private Sub lstVehiculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVehiculos.SelectedIndexChanged
        If lstVehiculos.SelectedIndex >= 0 Then
            encontrado = lstVehiculos.SelectedIndex
            Call buscarVehiculo(encontrado)
        Else Call limpiarForm()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If tbxAno.Text <> "" And tbxColor.Text <> "" And tbxMarca.Text <> "" And tbxDominio.Text <> "" And cbxTipo.Text <> "" Then
            anio = tbxAno.Text
            If anio > 2014 Then
                MsgBox("el auto es demasiado nuevo para nuestro bolsillo", Title:="Demasiado nuevo ya M'bae")
            ElseIf anio < 1970 Then
                MsgBox("mas viejo que Mirtha Legrand", Title:="Demasiado viejo")
            Else

                Dim ultimo As Integer = limite
                ultimo = lstVehiculos.Items.Count
                If ultimo <= limite Then
                    vehiculos(ultimo).anio = tbxAno.Text.ToString
                    vehiculos(ultimo).color = tbxColor.Text.ToString
                    vehiculos(ultimo).marca = tbxMarca.Text.ToString
                    vehiculos(ultimo).dominio = tbxDominio.Text.ToString
                    vehiculos(ultimo).tipo = cbxTipo.Text.ToString
                    sequeda = True

                    Call limpiarForm()
                    Call cargarlista()
                    Call autoantiguedad()

                Else MsgBox("No se puede cargar mas la agenda", MsgBoxStyle.Critical, "Agenda")
                End If
            End If
        Else MsgBox("Carga la agenda!", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If tbxAno.Text <> "" And tbxColor.Text <> "" And tbxMarca.Text <> "" And tbxDominio.Text <> "" And cbxTipo.Text <> "" Then
            If encontrado >= 0 Then
                vehiculos(encontrado).anio = tbxAno.Text.ToString
                anio = vehiculos(encontrado).anio
                vehiculos(encontrado).color = tbxColor.Text.ToString
                vehiculos(encontrado).marca = tbxMarca.Text.ToString
                vehiculos(encontrado).dominio = tbxDominio.Text.ToString
                vehiculos(encontrado).tipo = cbxTipo.Text.ToString
                sequeda = True
                Call limpiarForm()
                Call autoantiguedad()


            End If
        End If
    End Sub


    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If tbxAno.Text <> "" And tbxColor.Text <> "" And tbxMarca.Text <> "" And tbxDominio.Text <> "" And cbxTipo.Text <> "" Then
            If encontrado >= 0 Then
                vehiculos(encontrado).anio = 0
                vehiculos(encontrado).color = ""
                vehiculos(encontrado).marca = ""
                vehiculos(encontrado).dominio = ""
                vehiculos(encontrado).tipo = ""
                sequeda = False
                Call autoantiguedad()


                Dim i As Integer
                If encontrado < limite Then
                    For i = encontrado + 1 To limite
                        If vehiculos(i).dominio <> "" Then
                            vehiculos(i - 1).anio = tbxAno.Text.ToString
                            anio = vehiculos(i - 1).anio
                            vehiculos(i - 1).color = tbxColor.Text.ToString
                            vehiculos(i - 1).marca = tbxMarca.Text.ToString
                            vehiculos(i - 1).dominio = tbxDominio.Text.ToString
                            vehiculos(i - 1).tipo = cbxTipo.Text.ToString

                        End If
                        vehiculos(i).anio = 0
                        vehiculos(i).color = ""
                        vehiculos(i).marca = ""
                        vehiculos(i).dominio = ""
                        vehiculos(i).tipo = ""
                    Next
                End If
                Call cargarlista()
                Call limpiarForm()
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim i As Integer
        Dim bandera As Boolean

        For i = 0 To limite
            If tbxDominio.Text = vehiculos(i).dominio Then
                encontrado = i
                Call buscarVehiculo(encontrado)
                bandera = True
            End If
        Next
        If bandera = False Then MsgBox("no exite el vehiculo", MsgBoxStyle.Critical, "Error")

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Desea cerrar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = True
        Else
            End
        End If
    End Sub
End Class
