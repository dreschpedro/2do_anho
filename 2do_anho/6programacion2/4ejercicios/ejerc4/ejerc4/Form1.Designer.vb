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
        Me.lbl_precio_neto = New System.Windows.Forms.Label()
        Me.lbl_pvp = New System.Windows.Forms.Label()
        Me.lbl_IVA = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_precio_neto
        '
        Me.lbl_precio_neto.AutoSize = True
        Me.lbl_precio_neto.Location = New System.Drawing.Point(45, 18)
        Me.lbl_precio_neto.Name = "lbl_precio_neto"
        Me.lbl_precio_neto.Size = New System.Drawing.Size(63, 13)
        Me.lbl_precio_neto.TabIndex = 0
        Me.lbl_precio_neto.Text = "Precio Neto"
        '
        'lbl_pvp
        '
        Me.lbl_pvp.AutoSize = True
        Me.lbl_pvp.Location = New System.Drawing.Point(45, 119)
        Me.lbl_pvp.Name = "lbl_pvp"
        Me.lbl_pvp.Size = New System.Drawing.Size(28, 13)
        Me.lbl_pvp.TabIndex = 1
        Me.lbl_pvp.Text = "PVP"
        '
        'lbl_IVA
        '
        Me.lbl_IVA.AutoSize = True
        Me.lbl_IVA.Location = New System.Drawing.Point(45, 63)
        Me.lbl_IVA.Name = "lbl_IVA"
        Me.lbl_IVA.Size = New System.Drawing.Size(62, 13)
        Me.lbl_IVA.TabIndex = 2
        Me.lbl_IVA.Text = "Importe IVA"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox2.Location = New System.Drawing.Point(130, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(130, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(77, 169)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(135, 33)
        Me.btn_calcular.TabIndex = 6
        Me.btn_calcular.Text = "Calculat PVP"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 218)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_IVA)
        Me.Controls.Add(Me.lbl_pvp)
        Me.Controls.Add(Me.lbl_precio_neto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_precio_neto As System.Windows.Forms.Label
    Friend WithEvents lbl_pvp As System.Windows.Forms.Label
    Friend WithEvents lbl_IVA As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Private WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
