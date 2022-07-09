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
        Me.btnAbrirForm2 = New System.Windows.Forms.Button()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnForm3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMostrarClave = New System.Windows.Forms.Button()
        Me.lblVerClave = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAbrirForm2
        '
        Me.btnAbrirForm2.Location = New System.Drawing.Point(293, 161)
        Me.btnAbrirForm2.Name = "btnAbrirForm2"
        Me.btnAbrirForm2.Size = New System.Drawing.Size(90, 69)
        Me.btnAbrirForm2.TabIndex = 0
        Me.btnAbrirForm2.Text = "Form 2"
        Me.btnAbrirForm2.UseVisualStyleBackColor = True
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(85, 38)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(194, 20)
        Me.txtDNI.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(293, 236)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(90, 38)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(295, 282)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 34)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnForm3
        '
        Me.btnForm3.Location = New System.Drawing.Point(166, 161)
        Me.btnForm3.Name = "btnForm3"
        Me.btnForm3.Size = New System.Drawing.Size(112, 68)
        Me.btnForm3.TabIndex = 4
        Me.btnForm3.Text = "Form3"
        Me.btnForm3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "NOMBRE"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(85, 78)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(194, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(85, 111)
        Me.txtClave.MaxLength = 8
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(81, 20)
        Me.txtClave.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CLAVE"
        '
        'btnMostrarClave
        '
        Me.btnMostrarClave.Location = New System.Drawing.Point(183, 109)
        Me.btnMostrarClave.Name = "btnMostrarClave"
        Me.btnMostrarClave.Size = New System.Drawing.Size(24, 21)
        Me.btnMostrarClave.TabIndex = 10
        Me.btnMostrarClave.Text = "P"
        Me.btnMostrarClave.UseVisualStyleBackColor = True
        '
        'lblVerClave
        '
        Me.lblVerClave.AutoSize = True
        Me.lblVerClave.BackColor = System.Drawing.Color.Cyan
        Me.lblVerClave.Location = New System.Drawing.Point(225, 113)
        Me.lblVerClave.Name = "lblVerClave"
        Me.lblVerClave.Size = New System.Drawing.Size(33, 13)
        Me.lblVerClave.TabIndex = 9
        Me.lblVerClave.Text = "PWD"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 338)
        Me.Controls.Add(Me.btnMostrarClave)
        Me.Controls.Add(Me.lblVerClave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnForm3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.btnAbrirForm2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAbrirForm2 As System.Windows.Forms.Button
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnForm3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnMostrarClave As System.Windows.Forms.Button
    Friend WithEvents lblVerClave As System.Windows.Forms.Label

End Class
