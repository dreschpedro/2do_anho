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
        Me.btncal = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.Label()
        Me.txtneto = New System.Windows.Forms.TextBox()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.txtpvp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btncal
        '
        Me.btncal.Location = New System.Drawing.Point(95, 191)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(111, 41)
        Me.btncal.TabIndex = 0
        Me.btncal.Text = "&Calcular PVP"
        Me.btncal.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Location = New System.Drawing.Point(32, 31)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(91, 20)
        Me.txt1.TabIndex = 1
        Me.txt1.Text = "Precio &Neto"
        '
        'txt2
        '
        Me.txt2.AutoSize = True
        Me.txt2.Location = New System.Drawing.Point(32, 75)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(95, 20)
        Me.txt2.TabIndex = 2
        Me.txt2.Text = "Importe &IVA"
        '
        'txt3
        '
        Me.txt3.AutoSize = True
        Me.txt3.Location = New System.Drawing.Point(32, 123)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(40, 20)
        Me.txt3.TabIndex = 3
        Me.txt3.Text = "&PVP"
        '
        'txtneto
        '
        Me.txtneto.Location = New System.Drawing.Point(145, 28)
        Me.txtneto.Name = "txtneto"
        Me.txtneto.Size = New System.Drawing.Size(100, 26)
        Me.txtneto.TabIndex = 4
        Me.txtneto.Text = "0,00"
        Me.txtneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtiva
        '
        Me.txtiva.Location = New System.Drawing.Point(145, 72)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(100, 26)
        Me.txtiva.TabIndex = 5
        Me.txtiva.Text = "0,00"
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpvp
        '
        Me.txtpvp.Location = New System.Drawing.Point(145, 120)
        Me.txtpvp.Name = "txtpvp"
        Me.txtpvp.ReadOnly = True
        Me.txtpvp.Size = New System.Drawing.Size(100, 26)
        Me.txtpvp.TabIndex = 6
        Me.txtpvp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 244)
        Me.Controls.Add(Me.txtpvp)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.txtneto)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btncal)
        Me.Name = "Form1"
        Me.Text = "Calculo PVP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncal As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.Label
    Friend WithEvents txtneto As System.Windows.Forms.TextBox
    Friend WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents txtpvp As System.Windows.Forms.TextBox

End Class
