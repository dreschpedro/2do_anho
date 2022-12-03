Public Class Form1

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        'para seleccionar impresora

        If OpcionImpresora.ShowDialog = 1 Then
            'defino impresora seleccionada
            HojaImpresion.PrinterSettings = OpcionImpresora.PrinterSettings
            'imprimie directamente
            HojaImpresion.Print()
        End If

    End Sub


    Private Sub HojaImpresion_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles HojaImpresion.PrintPage
        Try
            ' La fuente a usar
            Dim prFont As New Font("Arial", 15, FontStyle.Bold)

            ' la posiciÃ³n superior

            ''imprimimos el nombre del cliente
            'prFont = New Font("Arial", 25, FontStyle.Bold
            e.Graphics.DrawString("Nombre del Cliente", prFont, Brushes.Blue, 100, 100)
            e.Graphics.DrawString("hola mundo", prFont, Brushes.BlueViolet, 50, 50)

            ''imprimimos la fecha y hora
            prFont = New Font("Arial", 10, FontStyle.Regular)
            e.Graphics.DrawString(Date.Now.ToShortDateString.ToString & " - " & _
                                Date.Now.ToShortTimeString.ToString, prFont, Brushes.Black, 15, 385)

            ''imprimimos la referencia del pedido
            e.Graphics.DrawString("Referencia", prFont, Brushes.Black, 50, 520)
            prFont = New Font("Arial", 18, FontStyle.Bold)
            e.Graphics.DrawString("Nombre de la Referencia", prFont, Brushes.Black, 50, 555)

            ''imprimimos Pedido Ondupack y Pedido del cliente
            prFont = New Font("Arial", 22, FontStyle.Regular)
            e.Graphics.DrawString("Pedido", prFont, Brushes.Black, 50, 660)
            e.Graphics.DrawString("Palets", prFont, Brushes.Black, 250, 660)

            prFont = New Font("Arial", 24, FontStyle.Regular)
            e.Graphics.DrawString("19875", prFont, Brushes.Black, 50, 700)
            e.Graphics.DrawString("44", prFont, Brushes.Black, 250, 700)

            ''imprimimos Cajas X Palet y Cajas x Paquete
            prFont = New Font("Arial", 22, FontStyle.Regular)
            e.Graphics.DrawString("Cajas x Palet", prFont, Brushes.Black, 50, 760)
            e.Graphics.DrawString("Cajas x Paquete", prFont, Brushes.Black, 250, 760)

            prFont = New Font("Arial", 24, FontStyle.Regular)
            e.Graphics.DrawString("500", prFont, Brushes.Black, 50, 800)
            e.Graphics.DrawString("32", prFont, Brushes.Black, 250, 800)

            ''imprimimos el numero del Palet
            prFont = New Font("Arial", 24, FontStyle.Regular)
            e.Graphics.DrawString("Numero del Palet     45", prFont, Brushes.Black, 50, 880)
            ''indicamos que hemos llegado al final de la pagina
            'e.HasMorePages = False

            ''imprimir una imagen
            e.Graphics.DrawImage(PictureBox1.Image, 380, 335, 400, 100)

            e.Graphics.DrawString("Referencia", prFont, Brushes.Black, 390, 350)

            ''imprimir lineas
            e.Graphics.DrawLine(Pens.DarkRed, 50, 600, 600, 600)
            e.Graphics.DrawLine(Pens.PowderBlue, 100, 100, 300, 400)
            e.Graphics.DrawLine(Pens.Black, 50, 750, 600, 750)
            e.Graphics.DrawLine(Pens.Black, 50, 850, 600, 850)
            e.Graphics.DrawLine(Pens.Black, 50, 600, 50, 850)
            e.Graphics.DrawLine(Pens.Black, 250, 600, 250, 850)
            e.Graphics.DrawLine(Pens.Black, 600, 600, 600, 850)

            ''imprimir un rectangulo
            e.Graphics.DrawRectangle(Pens.Green, 90, 90, 250, 100)
            e.Graphics.DrawRectangle(Pens.BlueViolet, 50, 50, 100, 100)

            ''imprimir un circulo
            e.Graphics.DrawEllipse(Pens.Indigo, 350, 900, 300, 100)
            e.Graphics.DrawEllipse(Pens.Blue, 100, 100, 200, 200)

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "Administrador", _
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub btnVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVistaPrevia.Click
        'para una vista previa
        'selecciono PrintDocument generado
        VistaPrevia.Document = HojaImpresion
        'tamaño de ventana
        VistaPrevia.Width = 900
        VistaPrevia.Height = 700
        'vista previa
        VistaPrevia.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VistaPrevia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaPrevia.Load

    End Sub
End Class
