'importo el espacio de datos odbc para conectar con BD
Imports MySql.Data.MySqlClient


Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'pruebo conexion a la base de datos
        Call conectar()

        Call CargarList()
    End Sub

    Sub CargarList()
        'cargo el list con los nombres
        Try
            'conecto a la base
            Call conectar()
            conexion.Open()

            'trabajo con los datos

            'el objeto command permite ejecutar sentencias SQL
            Dim Comando As New MySqlCommand

            'conecto el objeto command
            Comando.Connection = conexion

            'configuro command para sentencia SQL
            Comando.CommandType = CommandType.Text

            'cargo la sentencia
            Comando.CommandText = "select * from socio order by nombre;"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'consulto si trajo registros
            If DReader.HasRows Then
                'entonces cargo el list
                'limpio el list
                ListBox1.Items.Clear()

                'utilizo el DataReader para "navegar" por los datos
                'cargo el list con el campo "nombre" utilizando el DReader
                Do While DReader.Read
                    ListBox1.Items.Add(DReader("nombre"))
                Loop
            End If

            'cierro el DReader para poder ejecutar una nueva consulta SQL
            DReader.Close()


            'nueva consulta SQL
            'cuento la cantidad de registros
            Comando.CommandText = "select COUNT(clavesocio) as Total from socio;"

            'el método ExecuteScalar trae un valor unico de la tabla
            'convierto a String (para mostrar en el label) y muestro el valor
            lblTotal.Text = Convert.ToString(Comando.ExecuteScalar())

            'cierro el DReader
            'DReader.Close()

            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Sub LimpiarForm()
        'limpio los textbox
        txtClaveSocio.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtCategoria.Text = ""
        txtTelefono.Text = ""
        txtClaveSocio.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call CargarList()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try

            'conecto a la base
            Call conectar()
            conexion.Open()

            'trabajo con los datos

            'el objeto command permite ejecutar sentencias SQL
            Dim Comando As New MySqlCommand

            'conecto el objeto command
            Comando.Connection = conexion

            'configuro command para sentencia SQL
            Comando.CommandType = CommandType.Text

            'cargo la sentencia para buscar un registro
            Comando.CommandText = "select * from socio where nombre = '" & ListBox1.SelectedItem.ToString & "' ;"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'consulto si trajo registros
            If DReader.HasRows Then
                'utilizo el DataReader para "mostrar" por los datos
                DReader.Read()
                txtClaveSocio.Text = DReader("clavesocio")
                txtNombre.Text = DReader("nombre")
                txtDireccion.Text = DReader("direccion")
                txtCategoria.Text = DReader("categoria")
                txtTelefono.Text = DReader("telefono")
            Else
                MsgBox("El Socio no existe")
            End If

            'cierro el DReader para poder ejecutar una nueva consulta SQL
            DReader.Close()

            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub


    Private Sub btnBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBD.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'para imprimir directamente
        'HojaImpresion.Print()

        'para una vista previa
        'cargo el documeno de impresion
        VistaPrevia.Document = HojaImpresion
        VistaPrevia.ShowDialog()

    End Sub

    Private Sub HojaImpresion_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles HojaImpresion.PrintPage
        Try

            'conecto a la base
            Call conectar()
            conexion.Open()

            'trabajo con los datos

            'el objeto command permite ejecutar sentencias SQL
            Dim Comando As New MySqlCommand

            'conecto el objeto command
            Comando.Connection = conexion

            'configuro command para sentencia SQL
            Comando.CommandType = CommandType.Text

            'cargo la sentencia para buscar un registro
            Comando.CommandText = "select * from socio where nombre = '" & ListBox1.SelectedItem.ToString & "' ;"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            ' La fuente a usar
            Dim prFont As New Font("Arial", 15, FontStyle.Italic)

            'consulto si trajo registros
            If DReader.HasRows Then
                'utilizo el DataReader para "mostrar" por los datos
                DReader.Read()
                e.Graphics.DrawString(DReader("clavesocio"), prFont, Brushes.Black, 50, 300)
                e.Graphics.DrawString(DReader("nombre"), prFont, Brushes.Black, 100, 350)
                e.Graphics.DrawString(DReader("direccion"), prFont, Brushes.Black, 150, 400)
                e.Graphics.DrawString(DReader("categoria"), prFont, Brushes.Black, 200, 450)
                e.Graphics.DrawString(DReader("telefono"), prFont, Brushes.Black, 250, 500)
            End If

            DReader.Close()








            

            ' la posición superior

            ''imprimimos la fecha y hora
            'prFont = New Font("Arial", 20, FontStyle.Regular)
            'e.Graphics.DrawString(Date.Now.ToShortDateString.ToString & " " & _
            '                    Date.Now.ToShortTimeString.ToString, prFont, Brushes.Black, 15, 385)

            ''imprimimos el nombre del cliente
            'prFont = New Font("Arial", 25, FontStyle.Strikeout)

            'e.Graphics.DrawString("Nombre del Cliente", prFont, Brushes.Blue, 50, 100)

            ''imprimimos la referencia del pedido
            'e.Graphics.DrawString("Referencia", prFont, Brushes.Black, 50, 520)
            'prFont = New Font("Arial", 18, FontStyle.Bold)
            'e.Graphics.DrawString("Nombre de la Referencia", prFont, Brushes.Black, 50, 555)

            ''imprimimos Pedido Ondupack y Pedido del cliente
            'prFont = New Font("Arial", 22, FontStyle.Regular)
            'e.Graphics.DrawString("Pedido", prFont, Brushes.Black, 50, 660)
            'e.Graphics.DrawString("Palets", prFont, Brushes.Black, 250, 660)

            'prFont = New Font("Arial", 24, FontStyle.Regular)
            'e.Graphics.DrawString("19875", prFont, Brushes.Black, 50, 700)
            'e.Graphics.DrawString("44", prFont, Brushes.Black, 250, 700)

            ''imprimimos Cajas X Palet y Cajas x Paquete
            'prFont = New Font("Arial", 22, FontStyle.Regular)
            'e.Graphics.DrawString("Cajas x Palet", prFont, Brushes.Black, 50, 760)
            'e.Graphics.DrawString("Cajas x Paquete", prFont, Brushes.Black, 250, 760)

            'prFont = New Font("Arial", 24, FontStyle.Regular)
            'e.Graphics.DrawString("500", prFont, Brushes.Black, 50, 800)
            'e.Graphics.DrawString("32", prFont, Brushes.Black, 250, 800)

            ''imprimimos el numero del Palet
            'prFont = New Font("Arial", 24, FontStyle.Regular)
            'e.Graphics.DrawString("Número del Palet     45", prFont, Brushes.Black, 50, 880)
            ''indicamos que hemos llegado al final de la pagina
            'e.HasMorePages = False

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "Administrador", _
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call LimpiarForm()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'primero controlo que esten los datos cargados
        If txtClaveSocio.Text = "" Or txtNombre.Text = "" Or txtDireccion.Text = "" Then
            MsgBox("INGRESE LOS DATOS", MsgBoxStyle.Critical)
            txtClaveSocio.Focus()
            Exit Sub
        End If

        'agrego un registro a la tabla
        Try
            'conecto a la base
            Call conectar()
            conexion.Open()

            'trabajo con los datos

            'el objeto command permite ejecutar sentencias SQL
            Dim Comando As New MySqlCommand

            'conecto el objeto command
            Comando.Connection = conexion

            'configuro command para sentencia SQL
            Comando.CommandType = CommandType.Text

            'PRIMERO CONTROLO QUE EL REGISTRO NO EXISTA
            Comando.CommandText = "select * from socio where clavesocio = '" & txtClaveSocio.Text & "';"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si no encontro, entonces agrego
            If DReader.HasRows Then
                MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)
                'cierro el DataReader
                DReader.Close()
            Else
                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para AGREGAR un registro
                Comando.CommandText = "insert into socio (clavesocio,nombre,direccion,telefono,categoria) values (" & txtClaveSocio.Text & ",'" & Trim(txtNombre.Text) & "','" & txtDireccion.Text & "','" & txtTelefono.Text & "','" & Trim(txtCategoria.Text) & "');"

                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer

                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Agregados: " & Resultado)

                'cargo el list
                Call CargarList()
                Call LimpiarForm()
            End If


            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModif.Click
        'primero controlo que esten los datos cargados
        If txtClaveSocio.Text = "" And txtNombre.Text = "" And txtDireccion.Text = "" And txtCategoria.Text = "" And txtTelefono.Text = "" Then
            MsgBox("SELECCIONE REGISTRO A MODIFICAR", MsgBoxStyle.Critical)
            ListBox1.Focus()
            Exit Sub
        End If

        'modifico un registro de la tabla
        Try
            'conecto a la base
            Call conectar()
            conexion.Open()

            'trabajo con los datos

            'el objeto command permite ejecutar sentencias SQL
            Dim Comando As New MySqlCommand

            'conecto el objeto command
            Comando.Connection = conexion

            'configuro command para sentencia SQL
            Comando.CommandType = CommandType.Text

            'PRIMERO CONTROLO QUE EL REGISTRO EXISTA
            Comando.CommandText = "select * from socio where clavesocio = '" & Trim(txtClaveSocio.Text) & "';"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si encontro, entonces modifico
            If DReader.HasRows Then
                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para MODIFICAR un registro
                Comando.CommandText = "update socio set nombre='" & txtNombre.Text & "',direccion='" & txtDireccion.Text & "',telefono='" & txtTelefono.Text & "',categoria='" & Trim(txtCategoria.Text) & "' where clavesocio = " & txtClaveSocio.Text & ";"

                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer

                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Modificados: " & Resultado)

                'cargo el list
                Call CargarList()
                Call LimpiarForm()

            Else
                MsgBox("EL REGISTRO NO EXISTE", MsgBoxStyle.Critical)
                'cierro el DataReader
                DReader.Close()
            End If


            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            'MsgBox("ERROR DE BASE DE DATOS", vbCritical)
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        'primero controlo que esten los datos cargados
        If txtClaveSocio.Text = "" And txtNombre.Text = "" And txtDireccion.Text = "" And txtCategoria.Text = "" And txtTelefono.Text = "" Then
            MsgBox("SELECCIONE REGISTRO A ELIMINAR", MsgBoxStyle.Critical)
            ListBox1.Focus()
            Exit Sub
        End If

        'elimino un registro de la tabla
        Try
            'conecto a la base
            Call conectar()
            conexion.Open()

            'trabajo con los datos

            'el objeto command permite ejecutar sentencias SQL
            Dim Comando As New MySqlCommand

            'conecto el objeto command
            Comando.Connection = conexion

            'configuro command para sentencia SQL
            Comando.CommandType = CommandType.Text

            'PRIMERO CONTROLO QUE EL REGISTRO EXISTA
            Comando.CommandText = "select * from socio where clavesocio = " & Trim(txtClaveSocio.Text) & ";"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'si encontro, entonces ELIMINO
            If DReader.HasRows Then
                'cierro el DataReader
                DReader.Close()

                'cargo la sentencia para ELIMINAR un registro
                Comando.CommandText = "delete from socio where clavesocio = " & Trim(txtClaveSocio.Text) & ";"

                'variable para recibir respuesta de ejecucion
                Dim Resultado As Integer

                'el método ExecuteNonQuery devuelve solo la cantidad de registros afectados por la operacion
                Resultado = Comando.ExecuteNonQuery

                MsgBox("Registros Eliminados: " & Resultado)

                'cargo el list
                Call CargarList()
                Call LimpiarForm()

            Else
                MsgBox("EL REGISTRO NO EXISTE", MsgBoxStyle.Critical)
                'cierro el DataReader
                DReader.Close()
            End If

            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnTema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTema.Click
        frmTemas.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form5.Show()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

    End Sub
End Class
