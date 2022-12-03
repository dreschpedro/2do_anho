
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

Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
'primero controlo que esten los datos cargados
If Trim(txtClaveSocio.Text) = "" And Trim(txtNombre.Text) = "" And Trim(txtDireccion.Text) = "" And Trim(txtCategoria.Text) = "" And Trim(txtTelefono.Text) = "" Then
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
Comando.CommandText = "select * from socio where clavesocio = '" & Trim(txtClaveSocio.Text) & "';"
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
Comando.CommandText = "insert into socio values (" & Trim(txtClaveSocio.Text) & ",'" & Trim(txtNombre.Text) & "','" & Trim(txtDireccion.Text) & "','" & Trim(txtTelefono.Text) & "','" & Trim(txtCategoria.Text) & "');"
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