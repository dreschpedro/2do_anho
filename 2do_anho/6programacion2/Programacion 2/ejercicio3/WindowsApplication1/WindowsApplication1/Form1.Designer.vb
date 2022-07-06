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
        Me.menos = New System.Windows.Forms.Button()
        Me.mas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'menos
        '
        Me.menos.Location = New System.Drawing.Point(16, 277)
        Me.menos.Name = "menos"
        Me.menos.Size = New System.Drawing.Size(161, 51)
        Me.menos.TabIndex = 1
        Me.menos.Text = "-"
        Me.menos.UseVisualStyleBackColor = True
        '
        'mas
        '
        Me.mas.Location = New System.Drawing.Point(198, 277)
        Me.mas.Name = "mas"
        Me.mas.Size = New System.Drawing.Size(169, 51)
        Me.mas.TabIndex = 2
        Me.mas.Text = "+"
        Me.mas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 19)
        Me.Label1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 340)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mas)
        Me.Controls.Add(Me.menos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents menos As System.Windows.Forms.Button
    Friend WithEvents mas As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
