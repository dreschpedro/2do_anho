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
        Me.txtCadena = New System.Windows.Forms.TextBox()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtCadena2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCadena
        '
        Me.txtCadena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCadena.Location = New System.Drawing.Point(28, 23)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(474, 29)
        Me.txtCadena.TabIndex = 0
        Me.txtCadena.Text = "HOLA MUNDO LOCO SIGLO 20 CAMBALACHE#"
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(354, 70)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(79, 120)
        Me.btnConsulta.TabIndex = 1
        Me.btnConsulta.Text = "Consulta"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.ForeColor = System.Drawing.Color.White
        Me.lblResultado.Location = New System.Drawing.Point(12, 195)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(497, 42)
        Me.lblResultado.TabIndex = 2
        '
        'txtCadena2
        '
        Me.txtCadena2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCadena2.Location = New System.Drawing.Point(28, 86)
        Me.txtCadena2.Name = "txtCadena2"
        Me.txtCadena2.Size = New System.Drawing.Size(101, 29)
        Me.txtCadena2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cadena"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cadena2"
        '
        'txtParametro
        '
        Me.txtParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametro.Location = New System.Drawing.Point(27, 144)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(57, 29)
        Me.txtParametro.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Parametro"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 262)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCadena2)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.txtCadena)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCadena As System.Windows.Forms.TextBox
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents txtCadena2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtParametro As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
