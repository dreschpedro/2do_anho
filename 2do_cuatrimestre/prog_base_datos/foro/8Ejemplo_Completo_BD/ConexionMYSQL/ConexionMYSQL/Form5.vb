'importo el espacio de datos odbc para conectar con BD
Imports MySql.Data.MySqlClient

Public Class Form5

    Sub CargarGrilla(ByVal cadena As String)
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
            Comando.CommandText = cadena

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el método ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'consulto si trajo registros
            If DReader.HasRows Then
                'limpio el list
                lviewSocios.Items.Clear()

                'utilizo el DataReader para "navegar" por los datos
                'cargo la grilla utilizando el DReader
                Dim LV As New ListViewItem

                Do While DReader.Read
                    LV = lviewSocios.Items.Add(DReader("clavesocio"))
                    LV.SubItems.Add(DReader("nombre"))
                    LV.SubItems.Add(DReader("direccion"))
                    LV.SubItems.Add(DReader("telefono"))
                    LV.SubItems.Add(DReader("categoria"))
                Loop
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

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarGrilla("select * from socio order by nombre;")
    End Sub

    Private Sub lviewSocios_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.LabelEditEventArgs) Handles lviewSocios.AfterLabelEdit

    End Sub

    Private Sub lviewSocios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lviewSocios.Click
        'MsgBox(lviewSocios.Items.Item(lviewSocios.FocusedItem.Index).SubItems(0).Text)
    End Sub

    Private Sub lviewSocios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lviewSocios.SelectedIndexChanged

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

            'obtengo el elemento seleccionado
            Dim Elemento As String

            Elemento = lviewSocios.Items.Item(lviewSocios.FocusedItem.Index).SubItems(1).Text

            'traigo datos desde el list
            'txtNombre.Text = lviewSocios.Items.Item(lviewSocios.FocusedItem.Index).SubItems(1).Text
            'txtDireccion.Text = lviewSocios.Items.Item(lviewSocios.FocusedItem.Index).SubItems(2).Text

            'cargo la sentencia para buscar un registro
            Comando.CommandText = "select * from socio where nombre = '" & Elemento & "' ;"

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
End Class