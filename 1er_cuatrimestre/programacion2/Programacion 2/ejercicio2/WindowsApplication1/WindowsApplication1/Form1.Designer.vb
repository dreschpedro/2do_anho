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
        Me.suma = New System.Windows.Forms.Button()
        Me.resta = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'suma
        '
        Me.suma.Location = New System.Drawing.Point(45, 163)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(75, 33)
        Me.suma.TabIndex = 0
        Me.suma.Text = "+"
        Me.suma.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.Location = New System.Drawing.Point(163, 163)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(75, 33)
        Me.resta.TabIndex = 1
        Me.resta.Text = "-"
        Me.resta.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(22, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 244)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.suma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents suma As System.Windows.Forms.Button
    Friend WithEvents resta As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
