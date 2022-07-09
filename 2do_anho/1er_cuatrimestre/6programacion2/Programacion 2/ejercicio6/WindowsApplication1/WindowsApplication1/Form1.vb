Public Class Form1
    Public a, b, resul As Single

    Private Sub tb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb1.TextChanged
        a = CSng(tb1.Text)
    End Sub

    Private Sub tb2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb2.TextChanged
        b = CSng(tb2.Text)
    End Sub


    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        If suma.Checked = True Then
            resul = a + b
            resultado.Text = CStr(resul)
        ElseIf resta.Checked = True Then
            resul = a - b
            resultado.Text = CStr(resul)
        ElseIf mul.Checked = True Then
            resul = a * b
            resultado.Text = CStr(resul)
        ElseIf divi.Checked = True Then
            resul = a / b
            resultado.Text = CStr(resul)
        End If
    End Sub

    Private Sub suma_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suma.CheckedChanged
        If suma.Checked = True Then
            ope.Text = suma.Text
            resta.Checked = False
            mul.Checked = False
            divi.Checked = False
        End If
    End Sub

    Private Sub resta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resta.CheckedChanged
        If resta.Checked = True Then
            ope.Text = resta.Text
            suma.Checked = False
            mul.Checked = False
            divi.Checked = False
        End If
    End Sub

    Private Sub mul_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mul.CheckedChanged
        If mul.Checked = True Then
            ope.Text = mul.Text
            resta.Checked = False
            suma.Checked = False
            divi.Checked = False
        End If
    End Sub

    Private Sub divi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divi.CheckedChanged
        If divi.Checked = True Then
            ope.Text = divi.Text
            resta.Checked = False
            mul.Checked = False
            suma.Checked = False
        End If
    End Sub
End Class
