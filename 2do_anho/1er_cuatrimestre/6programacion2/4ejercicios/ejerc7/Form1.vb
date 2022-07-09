Public Class form1

    Dim simbol As String
    Public turno As Boolean

    Sub Ganador()
        If turno = False Then
            lbl_turno.Text = "Gano Jugador 2"
        Else
            lbl_turno.Text = "Gano Jugador 1"
        End If

        'mensaje
        If MsgBox("Queres jugar de nuevo?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.No Then
            End 'cierra el form
        Else
            'limpia todos los labels
            Label1.Text = " "
            Label2.Text = " "
            Label3.Text = " "
            Label4.Text = " "
            Label5.Text = " "
            Label6.Text = " "
            Label7.Text = " "
            Label8.Text = " "
            Label9.Text = " "
            lbl_turno.Text = "Turno Jugador 1"
        End If
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        turno = False
    End Sub


    Private Sub casilas_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click, Label8.Click, Label9.Click 'capturo el click de todos los botones

        simbol = sender.text

        If simbol = " " Then
            'depende del valor de la casilla
            If turno = False Then
                'turno del jugador 1
                simbol = "X"
                turno = True
                lbl_turno.Text = "Turno Jugador 2"
            Else
                'le toca al jugador 2
                simbol = "O"
                turno = False
                lbl_turno.Text = "Turno Jugador 1"
            End If
        End If
        sender.text = simbol

        '##################################################################################################                             
        '########################                CONTROL DE JUGADAS                 #######################
        '##################################################################################################

        'HORIZONTAL 1ER FILA

        If Label1.Text <> " " And (Label2.Text = Label1.Text) And (Label3.Text = Label1.Text) Then
            Call Ganador()

            'HORIZONTAL 2DA FILA
        ElseIf Label4.Text <> " " And (Label5.Text = Label4.Text) And (Label6.Text = Label4.Text) Then
            Call Ganador()

            'HORIZONTAL 3RA FILA
        ElseIf Label7.Text <> " " And (Label8.Text = Label7.Text) And (Label9.Text = Label7.Text) Then
            Call Ganador()

            'VERTICAL 1ER COLUMNA
        ElseIf Label1.Text <> " " And (Label4.Text = Label1.Text) And (Label7.Text = Label1.Text) Then
            Call Ganador()

            'VERTICAL 2DA COLUMNA
        ElseIf Label2.Text <> " " And (Label5.Text = Label2.Text) And (Label8.Text = Label2.Text) Then
            Call Ganador()

            'VERTICAL 3RA COLUMNA
        ElseIf Label3.Text <> " " And (Label6.Text = Label3.Text) And (Label9.Text = Label3.Text) Then
            Call Ganador()

            'DIAGONAL CAIDA A LA DERECHA (1 AL 9)
        ElseIf Label1.Text <> " " And (Label5.Text = Label1.Text) And (Label9.Text = Label1.Text) Then
            Call Ganador()

            'DIAGONAL CAIDA A LA DERECHA (3 AL 7)
        ElseIf Label3.Text <> " " And (Label5.Text = Label3.Text) And (Label7.Text = Label3.Text) Then
            Call Ganador()

        ElseIf (Label1.Text <> " ") And (Label2.Text <> " ") And (Label3.Text <> " ") And (Label4.Text <> " ") And (Label5.Text <> " ") And (Label6.Text <> " ") And (Label7.Text <> " ") And (Label8.Text <> " ") And (Label9.Text <> " ") Then
            'mensaje

            lbl_turno.Text = "No hay GANADOR!!"

            If MsgBox("Queres jugar de nuevo?", MsgBoxStyle.YesNo, "Atencion") = MsgBoxResult.No Then
                End 'cierra el form
            Else
                'limpia todos los labels
                Label1.Text = " "
                Label2.Text = " "
                Label3.Text = " "
                Label4.Text = " "
                Label5.Text = " "
                Label6.Text = " "
                Label7.Text = " "
                Label8.Text = " "
                Label9.Text = " "
                lbl_turno.Text = "Turno Jugador 1"
            End If

        End If 'FIN VERIFICACION

    End Sub

End Class
