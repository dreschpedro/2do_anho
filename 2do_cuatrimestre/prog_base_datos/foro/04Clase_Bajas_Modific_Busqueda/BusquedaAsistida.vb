Sub CargarList(ByVal cadena As String)
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
'entonces cargo el list
'limpio el list
lstTemas.Items.Clear()

lstTemas.Visible = True

'utilizo el DataReader para "navegar" por los datos
'cargo el list con el campo "nombre" utilizando el DReader
Do While DReader.Read
lstTemas.Items.Add(DReader("nombre"))
Loop
Else
'si no encuentro nada
'limpio el list
lstTemas.Items.Clear()
lstTemas.Visible = False
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


Private Sub txtTema_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTema.TextChanged
'busco los temas segun lo ingresado
'armo la consulta y llamo a la subrutina
If txtTema.Text <> "" Then
' si escribio algo busco
Dim Consulta As String

Consulta = "select nombre from tema where nombre like '%" & txtTema.Text & "%' order by nombre;"

Call CargarList(Consulta)
Else
'si no cargo nada limpio el list
lstTemas.Items.Clear()
lstTemas.Visible = False
End If
End Sub