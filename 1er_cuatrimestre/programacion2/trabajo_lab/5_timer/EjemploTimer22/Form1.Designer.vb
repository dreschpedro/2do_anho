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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.NumericUpDown()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtDirImagen = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(69, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblReloj
        '
        Me.lblReloj.AutoSize = True
        Me.lblReloj.BackColor = System.Drawing.Color.Black
        Me.lblReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloj.ForeColor = System.Drawing.Color.Lime
        Me.lblReloj.Location = New System.Drawing.Point(181, 16)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(72, 24)
        Me.lblReloj.TabIndex = 1
        Me.lblReloj.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(294, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ACTIVA/DESACTIVA RELOJ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(46, 247)
        Me.num1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(66, 26)
        Me.num1.TabIndex = 3
        Me.num1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 363)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(478, 34)
        Me.ProgressBar1.TabIndex = 4
        '
        'Timer2
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(294, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "MUEVE IMAGEN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(350, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 47)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "CAMBIAR IMAGEN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtDirImagen
        '
        Me.txtDirImagen.Location = New System.Drawing.Point(88, 42)
        Me.txtDirImagen.Name = "txtDirImagen"
        Me.txtDirImagen.Size = New System.Drawing.Size(356, 20)
        Me.txtDirImagen.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 400)
        Me.Controls.Add(Me.txtDirImagen)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblReloj)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblReloj As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents num1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtDirImagen As System.Windows.Forms.TextBox

End Class
