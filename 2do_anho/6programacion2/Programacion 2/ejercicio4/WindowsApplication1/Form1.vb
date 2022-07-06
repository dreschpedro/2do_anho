Public Class Form1
    Public iva, neto, pvp As Single
    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        iva = neto * 0.21
        pvp = neto + iva
        txtpvp.Text = pvp
    End Sub

    Private Sub txtneto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtneto.TextChanged
        neto = txtneto.Text
        iva = neto * 0.21
        txtiva.Text = iva
    End Sub

    Private Sub txtiva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtiva.TextChanged
        iva = txtiva.Text
        neto = (iva * 100) / 21
        txtneto.Text = neto
    End Sub
End Class
