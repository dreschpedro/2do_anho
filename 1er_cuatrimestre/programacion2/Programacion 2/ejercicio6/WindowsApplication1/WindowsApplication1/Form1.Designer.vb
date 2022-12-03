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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.suma = New System.Windows.Forms.CheckBox()
        Me.resta = New System.Windows.Forms.CheckBox()
        Me.mul = New System.Windows.Forms.CheckBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.divi = New System.Windows.Forms.CheckBox()
        Me.ope = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operando 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operando 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Resultado"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(29, 55)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(100, 20)
        Me.tb1.TabIndex = 3
        Me.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(184, 55)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(100, 20)
        Me.tb2.TabIndex = 4
        Me.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resultado
        '
        Me.resultado.Location = New System.Drawing.Point(359, 55)
        Me.resultado.Name = "resultado"
        Me.resultado.ReadOnly = True
        Me.resultado.Size = New System.Drawing.Size(100, 20)
        Me.resultado.TabIndex = 5
        Me.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'suma
        '
        Me.suma.AutoSize = True
        Me.suma.Checked = True
        Me.suma.CheckState = System.Windows.Forms.CheckState.Checked
        Me.suma.Location = New System.Drawing.Point(46, 106)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(32, 17)
        Me.suma.TabIndex = 6
        Me.suma.Text = "+"
        Me.suma.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.AutoSize = True
        Me.resta.Location = New System.Drawing.Point(133, 106)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(29, 17)
        Me.resta.TabIndex = 7
        Me.resta.Text = "-"
        Me.resta.UseVisualStyleBackColor = True
        '
        'mul
        '
        Me.mul.AutoSize = True
        Me.mul.Location = New System.Drawing.Point(221, 106)
        Me.mul.Name = "mul"
        Me.mul.Size = New System.Drawing.Size(30, 17)
        Me.mul.TabIndex = 8
        Me.mul.Text = "*"
        Me.mul.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(415, 106)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 9
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'divi
        '
        Me.divi.AutoSize = True
        Me.divi.Location = New System.Drawing.Point(309, 106)
        Me.divi.Name = "divi"
        Me.divi.Size = New System.Drawing.Size(31, 17)
        Me.divi.TabIndex = 10
        Me.divi.Text = "/"
        Me.divi.UseVisualStyleBackColor = True
        '
        'ope
        '
        Me.ope.AutoSize = True
        Me.ope.Location = New System.Drawing.Point(149, 58)
        Me.ope.Name = "ope"
        Me.ope.Size = New System.Drawing.Size(13, 13)
        Me.ope.TabIndex = 11
        Me.ope.Text = "+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 145)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ope)
        Me.Controls.Add(Me.divi)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.mul)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.suma)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "MiniCalculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb1 As System.Windows.Forms.TextBox
    Friend WithEvents tb2 As System.Windows.Forms.TextBox
    Friend WithEvents resultado As System.Windows.Forms.TextBox
    Friend WithEvents suma As System.Windows.Forms.CheckBox
    Friend WithEvents resta As System.Windows.Forms.CheckBox
    Friend WithEvents mul As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents divi As System.Windows.Forms.CheckBox
    Friend WithEvents ope As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
