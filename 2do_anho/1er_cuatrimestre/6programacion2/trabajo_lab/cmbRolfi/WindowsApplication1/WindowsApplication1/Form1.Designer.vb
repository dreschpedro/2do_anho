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
        Me.pais = New System.Windows.Forms.ComboBox()
        Me.estados = New System.Windows.Forms.ListBox()
        Me.textb = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado/ Provincia"
        '
        'pais
        '
        Me.pais.FormattingEnabled = True
        Me.pais.Items.AddRange(New Object() {"Paraguay", "Argentina", "Uruguay"})
        Me.pais.Location = New System.Drawing.Point(108, 73)
        Me.pais.Name = "pais"
        Me.pais.Size = New System.Drawing.Size(163, 28)
        Me.pais.TabIndex = 3
        '
        'estados
        '
        Me.estados.FormattingEnabled = True
        Me.estados.ItemHeight = 20
        Me.estados.Location = New System.Drawing.Point(75, 247)
        Me.estados.Name = "estados"
        Me.estados.Size = New System.Drawing.Size(196, 184)
        Me.estados.TabIndex = 4
        '
        'textb
        '
        Me.textb.Location = New System.Drawing.Point(108, 24)
        Me.textb.Name = "textb"
        Me.textb.Size = New System.Drawing.Size(163, 26)
        Me.textb.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 56)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(296, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 58)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(296, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 57)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textb)
        Me.Controls.Add(Me.estados)
        Me.Controls.Add(Me.pais)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pais As System.Windows.Forms.ComboBox
    Friend WithEvents estados As System.Windows.Forms.ListBox
    Friend WithEvents textb As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
