Public Class Form1
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing 'Cierre de FORMULARIO
        If MessageBox.Show("Quiere Cerrar?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click 'btn_salir ---> Cierra el Formulario
        Me.Close() 'aparece el aviso de cuando se presiona la 'X'
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 'cuando carga el formulario
        cmb_pais.Items.Add("Argentina")
        cmb_pais.Items.Add("Brasil")
        cmb_pais.Items.Add("Paraguay")
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress 'TXT Nombre
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsPunctuation(e.KeyChar))) Then 'no permite numeros o puntuacion --> (),.-*/[]
            e.Handled = True
        ElseIf ((Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then 'permite letras o borrar
            e.Handled = False
        End If

    End Sub

    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click 'btn_nuevo --> limpia los campos
        txt_nombre.Clear()
        cmb_pais.Text = ""
        lst_pcia.Items.Clear()
    End Sub


    Private Sub cmb_pais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_pais.SelectedIndexChanged 'FILTRO PAISES
        If cmb_pais.SelectedItem = "Argentina" Then 'mostrar solor Pcias correspondientes al pais correxto
            lst_pcia.Items.Clear()
            lst_pcia.Items.Add("Misiones")
            lst_pcia.Items.Add("Corrientes")
            lst_pcia.Items.Add("Buenos Aires")
        ElseIf cmb_pais.SelectedItem = "Brasil" Then
            lst_pcia.Items.Clear()
            lst_pcia.Items.Add("Rio de Janeiro")
            lst_pcia.Items.Add("Sao Paulo")
            lst_pcia.Items.Add("Santa Catalina")
        ElseIf cmb_pais.SelectedItem = "Paraguay" Then
            lst_pcia.Items.Clear()
            lst_pcia.Items.Add("Encarnación")
            lst_pcia.Items.Add("Cuidad del Este")
            lst_pcia.Items.Add("Asunción")
        End If
    End Sub

    Private Sub btn_imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click 'IMPRIMIR

        If ((cmb_pais.Text = "") Or (txt_nombre.Text = "") Or (lst_pcia.SelectedIndex = -1)) Then 'Validar que este seleccionado
            MsgBox("Te falto un campo", MsgBoxStyle.Exclamation, "Atencion")
        End If

        '########### IMPRESION #############
        Debug.Print("Nombre: " + txt_nombre.Text)
        Debug.Print("Pais: " + cmb_pais.SelectedItem)
        Debug.Print("Pcia./ Estado: " + lst_pcia.Text)
        Debug.Print("*********************************")

    End Sub

End Class
