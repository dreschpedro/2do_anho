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
        Me.chkIva = New System.Windows.Forms.CheckBox()
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
        Me.btncal.Location = New System.Drawing.Point(95, 201)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(81, 33)
        Me.btncal.TabIndex = 0
        Me.btncal.Text = "Calcular PVP"
        Me.btncal.UseVisualStyleBackColor = True
        '
        'chkIva
        '
        Me.chkIva.AutoSize = True
        Me.chkIva.Location = New System.Drawing.Point(95, 13)
        Me.chkIva.Name = "chkIva"
        Me.chkIva.Size = New System.Drawing.Size(111, 17)
        Me.chkIva.TabIndex = 1
        Me.chkIva.Text = "IVA en porcentaje"
        Me.chkIva.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Location = New System.Drawing.Point(30, 54)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(63, 13)
        Me.txt1.TabIndex = 2
        Me.txt1.Text = "Precio Neto"
        '
        'txt2
        '
        Me.txt2.AutoSize = True
        Me.txt2.Location = New System.Drawing.Point(30, 86)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(24, 13)
        Me.txt2.TabIndex = 3
        Me.txt2.Text = "IVA"
        '
        'txt3
        '
        Me.txt3.AutoSize = True
        Me.txt3.Location = New System.Drawing.Point(30, 119)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(28, 13)
        Me.txt3.TabIndex = 4
        Me.txt3.Text = "PVP"
        '
        'txtneto
        '
        Me.txtneto.Location = New System.Drawing.Point(138, 51)
        Me.txtneto.Name = "txtneto"
        Me.txtneto.Size = New System.Drawing.Size(100, 20)
        Me.txtneto.TabIndex = 5
        Me.txtneto.Text = "0"
        Me.txtneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtiva
        '
        Me.txtiva.Location = New System.Drawing.Point(138, 83)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(100, 20)
        Me.txtiva.TabIndex = 6
        Me.txtiva.Text = "0"
        Me.txtiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpvp
        '
        Me.txtpvp.Location = New System.Drawing.Point(138, 116)
        Me.txtpvp.Name = "txtpvp"
        Me.txtpvp.ReadOnly = True
        Me.txtpvp.Size = New System.Drawing.Size(100, 20)
        Me.txtpvp.TabIndex = 7
        Me.txtpvp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtpvp)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.txtneto)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.chkIva)
        Me.Controls.Add(Me.btncal)
        Me.Name = "Form1"
        Me.Text = "Calcular PVP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncal As System.Windows.Forms.Button
    Friend WithEvents chkIva As System.Windows.Forms.CheckBox
    Friend WithEvents txt1 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.Label
    Friend WithEvents txtneto As System.Windows.Forms.TextBox
    Friend WithEvents txtiva As System.Windows.Forms.TextBox
    Friend WithEvents txtpvp As System.Windows.Forms.TextBox

End Class
