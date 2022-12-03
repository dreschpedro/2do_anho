'importo el espacio de datos odbc para conectar con BD
Imports MySql.Data.MySqlClient

Public Class Form1

Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
Try
'para ganar velocidad conecto y desconecto de la base
Call conectar()
conexion.Open()
conexion.Close()
Catch ex As Exception
'si hay error muestro el mensaje
MsgBox(ex.Message)
conexion.Close()
End Try

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
'cargo el list
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
'cierro la conexion
conexion.Close()

Catch ex As Exception
'SI HAY UN ERROR MUESTRO EL MENSAJE
MsgBox(ex.Message)
conexion.Close()
End Try
End Sub
