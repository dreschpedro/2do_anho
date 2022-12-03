<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPuerto = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBD = New System.Windows.Forms.TextBox
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Clave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Servidor"
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(118, 141)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(186, 20)
        Me.txtClave.TabIndex = 11
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(118, 115)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(186, 20)
        Me.txtUsuario.TabIndex = 10
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(118, 15)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(186, 20)
        Me.txtServer.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Puerto"
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(118, 41)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(186, 20)
        Me.txtPuerto.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Base de Datos"
        '
        'txtBD
        '
        Me.txtBD.Location = New System.Drawing.Point(118, 67)
        Me.txtBD.Name = "txtBD"
        Me.txtBD.Size = New System.Drawing.Size(186, 20)
        Me.txtBD.TabIndex = 9
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(352, 63)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(107, 98)
        Me.btnGrabar.TabIndex = 17
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 186)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtServer)
        Me.Name = "Form2"
        Me.Text = "Datos de Conexion al Servidor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPuerto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBD As System.Windows.Forms.TextBox
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
End Class
