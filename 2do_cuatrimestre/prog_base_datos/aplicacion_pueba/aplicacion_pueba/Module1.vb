Imports MySql.Data.MySqlClient

Module Module1

    Friend conexion As MySqlConnection

    Sub conectar()
        'uso try para controlar errores
        Try
            'genero la conexion
            conexion = New MySqlConnection()

            Dim cadena As String
            'traigo la string de conexion de un archivo txt
            'My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\conexion.txt")
            cadena = "server=localhost; user id=root; password=123456; database=biblioteca; port=3306;"

            'traigo la string de conexion de la configuracion del sistema
            'cadena = My.Settings.ConexionString
            conexion.ConnectionString = cadena

            'pruebo la conexion
            conexion.Open()
            'cierro la conexion
            conexion.Close()

        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

End Module