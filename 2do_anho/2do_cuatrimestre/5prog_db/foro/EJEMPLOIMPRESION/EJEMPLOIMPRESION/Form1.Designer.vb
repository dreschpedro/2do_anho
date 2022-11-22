<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.OpcionImpresora = New System.Windows.Forms.PrintDialog()
        Me.HojaImpresion = New System.Drawing.Printing.PrintDocument()
        Me.VistaPrevia = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnVistaPrevia = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(351, 185)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(120, 49)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'OpcionImpresora
        '
        Me.OpcionImpresora.UseEXDialog = True
        '
        'HojaImpresion
        '
        '
        'VistaPrevia
        '
        Me.VistaPrevia.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.VistaPrevia.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.VistaPrevia.ClientSize = New System.Drawing.Size(400, 300)
        Me.VistaPrevia.Enabled = True
        Me.VistaPrevia.Icon = CType(resources.GetObject("VistaPrevia.Icon"), System.Drawing.Icon)
        Me.VistaPrevia.Name = "PrintPreviewDialog1"
        Me.VistaPrevia.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.BanderaPosadas
        Me.PictureBox1.Location = New System.Drawing.Point(21, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnVistaPrevia
        '
        Me.btnVistaPrevia.Location = New System.Drawing.Point(351, 107)
        Me.btnVistaPrevia.Name = "btnVistaPrevia"
        Me.btnVistaPrevia.Size = New System.Drawing.Size(120, 49)
        Me.btnVistaPrevia.TabIndex = 2
        Me.btnVistaPrevia.Text = "Vista Previa"
        Me.btnVistaPrevia.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 397)
        Me.Controls.Add(Me.btnVistaPrevia)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents HojaImpresion As System.Drawing.Printing.PrintDocument
    Friend WithEvents VistaPrevia As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnVistaPrevia As System.Windows.Forms.Button
    Friend WithEvents OpcionImpresora As System.Windows.Forms.PrintDialog

End Class
