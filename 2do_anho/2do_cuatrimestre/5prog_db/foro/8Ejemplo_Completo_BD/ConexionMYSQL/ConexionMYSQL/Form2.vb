'importo el espacio de datos odbc para conectar con BD
Imports MySql.Data.MySqlClient

Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'uso try para controlar errores
        Try
            'TRAIGO LOS DATOS ACTUALES DE LA CONEXIÓN
            Dim cadena As String
            Dim PosicionIgual As Integer
            Dim PosicionPunto As Integer
            Dim Caracteres As Integer

            'traigo la string de conexion de la configuracion del sistema
            cadena = My.Settings.ConexionString

            'cargo en los textBox
            'busco el servidor
            PosicionIgual = cadena.IndexOf("=") + 1
            PosicionPunto = cadena.IndexOf(";")
            Caracteres = PosicionPunto - PosicionIgual
            txtServer.Text = cadena.Substring(PosicionIgual, Caracteres)

            'busco el usuario
            PosicionIgual = cadena.IndexOf("=", PosicionIgual) + 1
            PosicionPunto = cadena.IndexOf(";", PosicionPunto + 1)
            Caracteres = PosicionPunto - PosicionIgual
            txtUsuario.Text = cadena.Substring(PosicionIgual, Caracteres)

            'busco la clave
            PosicionIgual = cadena.IndexOf("=", PosicionIgual) + 1
            PosicionPunto = cadena.IndexOf(";", PosicionPunto + 1)
            Caracteres = PosicionPunto - PosicionIgual
            txtClave.Text = cadena.Substring(PosicionIgual, Caracteres)

            'busco la Base de Datos
            PosicionIgual = cadena.IndexOf("=", PosicionIgual) + 1
            PosicionPunto = cadena.IndexOf(";", PosicionPunto + 1)
            Caracteres = PosicionPunto - PosicionIgual
            txtBD.Text = cadena.Substring(PosicionIgual, Caracteres)

            'busco el puerto de conexion
            PosicionIgual = cadena.IndexOf("=", PosicionIgual) + 1
            PosicionPunto = cadena.IndexOf(";", PosicionPunto + 1)
            Caracteres = PosicionPunto - PosicionIgual
            txtPuerto.Text = cadena.Substring(PosicionIgual, Caracteres)


            'ASI GURADO LA CONFIGURACION DEL SISTEMA EN TIEMPO DE EJECUCION
            'My.Settings.Prueba = txtUsuario.Text
            'My.Settings.Save()

        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

        'uso try para controlar errores
        Try

            Dim Cadena As String

            'armo la cadena de conexion
            Cadena = "server=" & txtServer.Text & "; user id=" & txtUsuario.Text & "; password=" & txtClave.Text & "; database=" & txtBD.Text & "; port=" & txtPuerto.Text & ";"

            'PRUEBO la conexion
            conexion = New MySqlConnection()
            conexion.ConnectionString = Cadena
            conexion.Open()
            conexion.Close()

            'grabo en las propiedades del sistema
            My.Settings.ConexionString = Cadena
            My.Settings.Save()

            MsgBox("CONEXION EXITOSA!", MsgBoxStyle.Information)

        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
        End Try
    End Sub
End Class