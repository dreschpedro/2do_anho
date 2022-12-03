
Private Sub btnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModif.Click
'primero controlo que esten los datos cargados
If Trim(txtClaveSocio.Text) = "" And Trim(txtNombre.Text) = "" And Trim(txtDireccion.Text) = "" And Trim(txtCategoria.Text) = "" And Trim(txtTelefono.Text) = "" Then
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
Comando.CommandText = "update socio set nombre='" & Trim(txtNombre.Text) & "',direccion='" & Trim(txtDireccion.Text) & "',telefono='" & Trim(txtTelefono.Text) & "',categoria='" & Trim(txtCategoria.Text) & "' where clavesocio = " & Trim(txtClaveSocio.Text) & ";"
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
MsgBox(ex.Message)
conexion.Close()
End Try
End Sub


Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
'primero controlo que esten los datos cargados
If Trim(txtClaveSocio.Text) = "" And Trim(txtNombre.Text) = "" And Trim(txtDireccion.Text) = "" And Trim(txtCategoria.Text) = "" And Trim(txtTelefono.Text) = "" Then
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