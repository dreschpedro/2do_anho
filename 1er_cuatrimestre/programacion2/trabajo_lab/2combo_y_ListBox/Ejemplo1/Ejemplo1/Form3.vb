Public Class Form3

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If MessageBox.Show("Desea cerrar?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargo LBL con mensaje
        'lblMensaje.Text = Nombre.ToString

        'cargo listbox
        lstEquipos.Items.Add("Barcelona")
        lstEquipos.Items.Add("PSG")

        'cargo combo box
        cmbLiga.Items.Add("LFP")
        cmbLiga.Items.Add("Ligue1")

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'agrego elementos al listbox
        lstEquipos.Items.Add(txtEquipo.Text)

        'limpio el text box
        txtEquipo.Text = ""


    End Sub

    Private Sub lstEquipos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEquipos.SelectedIndexChanged

        'muestro el indice del elemento seleccionado
        lblIndice.Text = lstEquipos.SelectedIndex

        'muestro el nombre del elemento seleccionado
        lblNomEquipo.Text = lstEquipos.SelectedItem

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        'elimino el elemento seleccionado del list box

        If lstEquipos.SelectedIndex > -1 Then
            If MessageBox.Show("Desea Borrar? " + lstEquipos.SelectedItem, "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                lstEquipos.Items.RemoveAt(lstEquipos.SelectedIndex)
            End If

        Else
            MsgBox("SELECCIONA ALGO MASTER")
        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        ' vacio list box
        lstEquipos.Items.Clear()

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        ' muestro en ventana im=nmediato
        Debug.Print("Indice: " + lblIndice.Text)
        Debug.Print("Equipo: " + lblNomEquipo.Text)
        Debug.Print("********************************")

    End Sub

    Private Sub btnAgregarLiga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLiga.Click
        'agrego elementos al combo box
        cmbLiga.Items.Add(cmbLiga.Text)
    End Sub
End Class