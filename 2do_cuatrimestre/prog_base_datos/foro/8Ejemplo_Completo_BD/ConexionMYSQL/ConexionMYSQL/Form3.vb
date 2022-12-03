'importo el espacio de datos odbc para conectar con BD
Imports MySql.Data.MySqlClient

Public Class Form3

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

    Private Sub Form3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargarGrilla("select * from socio order by nombre;")
    End Sub

    Private Sub lviewSocios_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lviewSocios.ColumnClick
        Dim consulta As String

        'depende la columna que hace click ordena la lista
        Select Case e.Column
            Case 0
                consulta = "select * from socio order by clavesocio;"
            Case 1
                consulta = "select * from socio order by nombre;"
            Case 2
                consulta = "select * from socio order by direccion;"
            Case 3
                consulta = "select * from socio order by telefono;"
            Case 4
                consulta = "select * from socio order by categoria;"
        End Select

        Call CargarGrilla(consulta)
    End Sub

    Private Sub lviewSocios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lviewSocios.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        PrintForm1.Print()
    End Sub
End Class