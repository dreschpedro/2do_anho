Public Class Form1
    'validacion de caracteres
    Private Sub txt_oper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_op1.KeyPress, txt_op2.KeyPress
        If ((Char.IsNumber(e.KeyChar)) Or (Char.IsSurrogate(e.KeyChar)) Or (Char.IsControl(e.KeyChar))) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    'mostar la operacion seleccionada en lbl_operacion
    Private Sub chk_oper_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_suma.CheckedChanged, chk_resta.CheckedChanged, chk_multi.CheckedChanged, chk_divi.CheckedChanged
        If sender.checked = True Then
            lbl_operacion.Text = sender.Text
        End If


        'cada posibilidad de marcado
        If (chk_suma.Checked = True) Then 'suma
            chk_resta.Enabled = False
            chk_multi.Enabled = False
            chk_divi.Enabled = False
        ElseIf (chk_resta.Checked = True) Then 'resta
            chk_suma.Enabled = False
            chk_multi.Enabled = False
            chk_divi.Enabled = False
        ElseIf (chk_multi.Checked = True) Then 'multiplicacion
            chk_resta.Enabled = False
            chk_suma.Enabled = False
            chk_divi.Enabled = False
        ElseIf (chk_divi.Checked = True) Then 'division
            chk_resta.Enabled = False
            chk_multi.Enabled = False
            chk_suma.Enabled = False
        Else
            chk_resta.Enabled = True
            chk_multi.Enabled = True
            chk_suma.Enabled = True
            chk_divi.Enabled = True
        End If

    End Sub

    Private Sub btn_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_calcular.Click
        If (txt_op1.Text = "") Or (txt_op2.Text = "") Then
            MsgBox("Hay algún campo vacío")                                 'valida que no esten vacios los campos
        Else                                                                'cada posibilidad de marcado
            If (chk_suma.Checked = True) Then                               'suma
                txt_rdo.Text = Val(txt_op1.Text) + Val(txt_op2.Text)
            ElseIf (chk_resta.Checked = True) Then                          'resta
                txt_rdo.Text = Val(txt_op1.Text) - Val(txt_op2.Text)
            ElseIf (chk_multi.Checked = True) Then                          'multiplicacion
                txt_rdo.Text = Val(txt_op1.Text) * Val(txt_op2.Text)
            ElseIf (chk_divi.Checked = True) Then                           'division
                txt_rdo.Text = Val(txt_op1.Text) / Val(txt_op2.Text)
            Else
                MsgBox("Debes elegir una operación")                        'valida que se elija una operacion
            End If
        End If
    End Sub
End Class
