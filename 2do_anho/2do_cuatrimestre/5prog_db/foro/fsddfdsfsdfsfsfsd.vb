'primero controlo que esten los datos cargados
142
If Trim(txtClaveSocio.Text) = "" And Trim(txtNombre.Text) = "" And
Trim(txtDireccion.Text) = "" And Trim(txtCategoria.Text) = "" And
Trim(txtTelefono.Text) = "" Then
143
MsgBox("INGRESE LOS DATOS", MsgBoxStyle.Critical)
144
txtClaveSocio.Focus()
145
Exit Sub
146
End If
147
148
'agrego un registro a la tabla
149
Try
150
'conecto a la base
151
Call conectar()
152
conexion.Open()
153
154
'trabajo con los datos
155
'el objeto command permite ejecutar sentencias SQL
156
Dim Comando As New MySqlCommand
157
'conecto el objeto command
158
Comando.Connection = conexion
159
'configuro command para sentencia SQL
160
Comando.CommandType = CommandType.Text
161
-1-
Form1.vb
162
'PRIMERO CONTROLO QUE EL REGISTRO NO EXISTA
163
Comando.CommandText = "select * from socio where clavesocio = '" &
Trim(txtClaveSocio.Text) & "';"
164
'obtengo los datos y los devuelvo a un objeto DataReader
165
Dim DReader As MySqlDataReader
166
'el método ExecuteReader trae los datos de la BD
167
DReader = Comando.ExecuteReader
168
'si no encontro, entonces agrego
169
If DReader.HasRows Then
170
MsgBox("EL REGISTRO YA EXISTE", MsgBoxStyle.Critical)
171
'cierro el DataReader
172
DReader.Close()
173
Else
174
'cierro el DataReader
175
DReader.Close()
176
177
'cargo la sentencia para AGREGAR un registro
178
Comando.CommandText = "insert into socio values (" &
Trim(txtClaveSocio.Text) & ",'" & Trim(txtNombre.Text) & "','" &
Trim(txtDireccion.Text) & "','" & Trim(txtTelefono.Text) & "','" &
Trim(txtCategoria.Text) & "');"
179
'variable para recibir respuesta de ejecucion
180
Dim Resultado As Integer
181
'el método ExecuteNonQuery devuelve solo la cantidad de registros
afectados por la operacion
182
Resultado = Comando.ExecuteNonQuery
183
MsgBox("Registros Agregados: " & Resultado)
184
185
'cargo el list
186
Call CargarList()
187
Call LimpiarForm()
188
End If
189
'cierro la conexion
190
conexion.Close()
191
192
Catch ex As Exception
193
'SI HAY UN ERROR MUESTRO EL MENSAJE
194
MsgBox(ex.Message)
195
conexion.Close()
196
End Try