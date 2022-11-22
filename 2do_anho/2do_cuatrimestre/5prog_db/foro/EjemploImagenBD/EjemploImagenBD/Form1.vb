Option Strict Off

Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Form1

    Public Function ConvertImageFiletoBytes(ByVal ImageFilePath As String) As Byte()
        'funcion convierte la imagen a binario para guardar en la BD
        Dim _tempByte() As Byte = Nothing
        If String.IsNullOrEmpty(ImageFilePath) = True Then
            Throw New ArgumentNullException("La imagen no puede estar vacia", "ImageFilePath")
            Return Nothing
        End If
        Try
            Dim _fileInfo As New IO.FileInfo(ImageFilePath)
            Dim _NumBytes As Long = _fileInfo.Length
            Dim _FStream As New IO.FileStream(ImageFilePath, IO.FileMode.Open, IO.FileAccess.Read)
            Dim _BinaryReader As New IO.BinaryReader(_FStream)
            _tempByte = _BinaryReader.ReadBytes(Convert.ToInt32(_NumBytes))
            _fileInfo = Nothing
            _NumBytes = 0
            _FStream.Close()
            _FStream.Dispose()
            _BinaryReader.Close()
            Return _tempByte
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ConvertBytesToMemoryStream(ByVal ImageData As Byte()) As IO.MemoryStream
        Try
            If IsNothing(ImageData) = True Then
                Return Nothing
                'Throw New ArgumentNullException("La imagen no puede estar vacia", "ImageData")
            End If
            Return New System.IO.MemoryStream(ImageData)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ConvertImageFiletoMemoryStream(ByVal ImageFilePath As String) As IO.MemoryStream
        If String.IsNullOrEmpty(ImageFilePath) = True Then
            Return Nothing
            ' Throw New ArgumentNullException("ILa imagen no puede estar vacia", "ImageFilePath")
        End If
        Return ConvertBytesToMemoryStream(ConvertImageFiletoBytes(ImageFilePath))
    End Function

    Sub CargarList()
        Dim Conn As MySql.Data.MySqlClient.MySqlConnection
        Conn = New MySql.Data.MySqlClient.MySqlConnection

        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.ConnectionString = "server=localhost; user id=root; password=123456; database=biblioteca; port=3306;"
            Conn.Open()

            Dim Comando As New MySqlCommand

            'conecto el objeto command
            Comando.Connection = Conn

            'configuro command para sentencia SQL
            Comando.CommandType = CommandType.Text

            'cargo la sentencia
            Comando.CommandText = "select Id from imagenes;"

            'obtengo los datos y los devuelvo a un objeto DataReader
            Dim DReader As MySqlDataReader

            'el mÃ©todo ExecuteReader trae los datos de la BD
            DReader = Comando.ExecuteReader

            'consulto si trajo registros
            If DReader.HasRows Then
                'entonces cargo el list
                'limpio el list
                lstIDImg.Items.Clear()

                'utilizo el DataReader para "navegar" por los datos
                'cargo el list con el campo "nombre" utilizando el DReader
                Do While DReader.Read
                    lstIDImg.Items.Add(DReader("id"))
                Loop
            End If


            'cierro el DReader para poder ejecutar una nueva consulta SQL
            DReader.Close()
            'cierro la conexion
            Conn.Close()

        Catch ex As Exception
            'SI HAY UN ERROR MUESTRO EL MENSAJE
            MsgBox(ex.Message)
            Conn.Close()
        End Try
    End Sub

    Sub BuscarImagenBD(ByVal idImagen As Integer)
        Dim Conn As MySql.Data.MySqlClient.MySqlConnection
        Conn = New MySql.Data.MySqlClient.MySqlConnection

        Try
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.ConnectionString = "server=localhost; user id=root; password=123456; database=biblioteca; port=3306;"
            Conn.Open()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Connect")
        End Try

        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        adapter.SelectCommand = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM imagenes WHERE id= " & idImagen & ";", Conn)

        Dim Data As New DataTable
        Dim commandbuild As New MySql.Data.MySqlClient.MySqlCommandBuilder(adapter)
        adapter.Fill(Data)

        If Data.Rows.Count > 0 Then
            'cargo la imagen
            Dim lb() As Byte = Data.Rows(Data.Rows.Count - 1).Item("foto")
            Dim lstr As New System.IO.MemoryStream(lb)
            'cargo la imagen en el picture
            pbPicture.Image = Image.FromStream(lstr)
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()
        Else
            MsgBox("NO HAY IMAGEN")
        End If
    End Sub

    Private Sub btnCargarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarImagen.Click

        'busco una imagen cargada en la BD y la traigo
        If txtId.Text <> "" Then
            Call BuscarImagenBD(txtId.Text)

        End If
    End Sub

    Private Sub btnBuscarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarImagen.Click
        'abro la ventana de busqueda 
        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'cargo en el text el Path de la Imagen
            txtPathImg.Text = OpenFileDialog1.FileName
            'cargo la imagen en el picturebox 
            pbPicture.ImageLocation = txtPathImg.Text
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarList()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'guarda la imagen seleccionada en la BD
        If txtPathImg.Text <> "" Then

            'informo el path del archivo de imagen a la funcion
            Dim filename As String = txtPathImg.Text
            Dim FileSize As UInt32

            Dim Conn As MySql.Data.MySqlClient.MySqlConnection
            Conn = New MySql.Data.MySqlClient.MySqlConnection

            Try
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.ConnectionString = "server=localhost; user id=root; password=123456; database=biblioteca; port=3306;"
                Conn.Open()

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Connect")
            End Try

            Dim mstream As System.IO.MemoryStream = ConvertImageFiletoMemoryStream(filename)

            Dim arrImage() As Byte = ConvertImageFiletoBytes(filename)

            FileSize = mstream.Length

            Dim sqlcmd As New MySql.Data.MySqlClient.MySqlCommand
            Dim sql As String
            mstream.Close()

            sql = "insert into imagenes (foto, tam_archivo, nom_archivo) VALUES(@Archi, @TamArchi, @NomArchi)"


            Try

                With sqlcmd
                    .CommandText = sql
                    .Connection = Conn
                    .Parameters.AddWithValue("@NomArchi", filename)
                    .Parameters.AddWithValue("@TamArchi", FileSize)
                    .Parameters.AddWithValue("@Archi", arrImage)
                    .ExecuteNonQuery()
                End With

                'limpio imagen
                txtPathImg.Text = ""
                pbPicture.Image = Nothing

                'pbPicture.
                MsgBox("IMAGEN GUARDADA EN BD")
                Call CargarList()

                Conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub lstIDImg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstIDImg.SelectedIndexChanged
        'busco la imagen y cargo en el picture
        Call BuscarImagenBD(lstIDImg.SelectedItem)
    End Sub
End Class
