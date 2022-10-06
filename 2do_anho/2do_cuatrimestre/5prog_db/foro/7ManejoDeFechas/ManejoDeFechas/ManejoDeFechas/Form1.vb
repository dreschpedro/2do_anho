'Imports System
'Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Form1

    Private Sub btnConversion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConversion.Click
        'CONTROLO QUE LA FECHA SEA CORRECTA
        'LUEGO CONVIERTO A FORMATO INGLES

        Dim Fecha As Date

        'Fecha = Date.Now
        'Debug.Print(Fecha.ToShortDateString)

        'CONTROL DE FECHA CORRECTA
        If IsDate(txtFecha.Text) Then
            'CONVIERTO A FORMATO FECHA (DATE)
            Fecha = CDate(txtFecha.Text)

            'CARGO FECHA EN EL DTPICKER
            dtpFecha.Value = Fecha

            'Label1.Text = Fecha.ToShortDateString
            'Fecha = Format(CDate(TextBox1.Text), "yyyy-MM-dd")
            'Label1.Text = Convert.ToDateTime(TextBox1.Text).ToString("yyyy-MM-dd")
            'Label1.Text = DateTime.ParseExact(Convert.ToDateTime(TextBox1.Text).ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture)

            'MUESTRO LA FECHA CONVERTIDA A FORMATO INGLES
            lblFecha.Text = dtpFecha.Value.ToString("yyyy-MM-dd")
        Else
            MsgBox("fecha erronea")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFechaSistema.Text = Date.Now.ToShortDateString

    End Sub

    Private Sub btnCapturaRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapturaRango.Click
        'CARGO EN LOS TEXT LA FECHA SELECCIONADA
        txtInicio.Text = MonthCalendar1.SelectionStart.ToShortDateString
        txtFin.Text = MonthCalendar1.SelectionEnd.ToShortDateString
    End Sub

    Private Sub btnSelecRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecRango.Click
        'MARCO EL RANGO EN EL MONTHCALENDAR
        MonthCalendar1.SelectionStart = txtInicio.Text
        MonthCalendar1.SelectionEnd = txtFin.Text
    End Sub

    Private Sub btnGuardarBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarBD.Click

        'GUARDO LA FECHA EN LA BASE DE DATOS

        Dim conexion As New MySqlConnection()

        Try
            conexion.ConnectionString = "server=localhost; user id=root; password=123456; database=biblio; port=3306;"
            conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "insert into authors (author,year_born,FechaNac) values ('Prueba',2019,'" & dtpFecha.Value.ToString("yyyy-MM-dd") & "');"

            Dim Resultado As Integer
            Resultado = Comando.ExecuteNonQuery

            MsgBox("Registros Agregados: " & Resultado)

            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub

    Private Sub btnTraer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraer.Click

        'TRAIGO LA FECHA DE LA BASE DE DATOS

        Dim conexion As New MySqlConnection()

        Try
            conexion.ConnectionString = "server=localhost; user id=root; password=123456; database=biblio; port=3306;"
            conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = conexion
            Comando.CommandType = CommandType.Text
            'Comando.CommandText = "insert into authors (author,year_born,FechaNac) values ('Prueba',2019,'" & dtpFecha.Value.ToString("yyyy-MM-dd") & "');"

            'traigo el ultimo registro ("dd/MM/yyyy")
            Comando.CommandText = "select * from authors order by au_id DESC LIMIT 1;"

            Dim DReader As MySqlDataReader
            DReader = Comando.ExecuteReader

            If DReader.HasRows Then
                DReader.Read()
                lblFecha.Text = Format(DReader("FechaNac"), "dd/MM/yyyy")
            Else
                MsgBox("SIN DATOS")
            End If

            'cierro el DReader para poder ejecutar una nueva consulta SQL
            DReader.Close()

            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
End Class
