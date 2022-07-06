Public Class Form1
    Public iva, iva2, neto, pvp As Single
    Public por As Single = 0.21
    Const zero As Single = 0.1


    Private Sub chkIva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIva.CheckedChanged
        If True Then
            por = CSng(txtiva.Text) * zero
        End If
    End Sub

    Private Sub txtneto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtneto.TextChanged
        neto = CSng(txtneto.Text)
        iva = neto * por
        txtiva.Text = iva
    End Sub

    Private Sub txtiva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtiva.TextChanged

        If chkIva.Checked = False Then
            iva = CSng(txtiva.Text)
            neto = (iva * 100) / 21
            txtneto.Text = neto
        ElseIf neto > 1 Then
            iva = CSng(txtiva.Text)
            iva = (iva / 100) * neto
        End If

    End Sub

    Private Sub btncal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncal.Click
        'calculo y imprimo PVP
        pvp = neto + iva
        txtpvp.Text = pvp
    End Sub


End Class
