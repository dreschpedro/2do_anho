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
        Me.grpEstCiv = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.chkLibros = New System.Windows.Forms.CheckBox()
        Me.chkMusica = New System.Windows.Forms.CheckBox()
        Me.chkJuegos = New System.Windows.Forms.CheckBox()
        Me.chkPeliculas = New System.Windows.Forms.CheckBox()
        Me.chkDeportes = New System.Windows.Forms.CheckBox()
        Me.radMasculino = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radFemenino = New System.Windows.Forms.RadioButton()
        Me.radOtro = New System.Windows.Forms.RadioButton()
        Me.radCasado = New System.Windows.Forms.RadioButton()
        Me.radSoltero = New System.Windows.Forms.RadioButton()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.radViudo = New System.Windows.Forms.RadioButton()
        Me.radDivorsiado = New System.Windows.Forms.RadioButton()
        Me.grpEstCiv.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpEstCiv
        '
        Me.grpEstCiv.Controls.Add(Me.radDivorsiado)
        Me.grpEstCiv.Controls.Add(Me.radViudo)
        Me.grpEstCiv.Controls.Add(Me.radSoltero)
        Me.grpEstCiv.Controls.Add(Me.radCasado)
        Me.grpEstCiv.Location = New System.Drawing.Point(245, 108)
        Me.grpEstCiv.Name = "grpEstCiv"
        Me.grpEstCiv.Size = New System.Drawing.Size(160, 152)
        Me.grpEstCiv.TabIndex = 1
        Me.grpEstCiv.TabStop = False
        Me.grpEstCiv.Text = "Estado Civil"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(33, 319)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(109, 29)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'chkLibros
        '
        Me.chkLibros.AutoSize = True
        Me.chkLibros.Location = New System.Drawing.Point(28, 131)
        Me.chkLibros.Name = "chkLibros"
        Me.chkLibros.Size = New System.Drawing.Size(54, 17)
        Me.chkLibros.TabIndex = 9
        Me.chkLibros.Text = "Libros"
        Me.chkLibros.UseVisualStyleBackColor = True
        '
        'chkMusica
        '
        Me.chkMusica.AutoSize = True
        Me.chkMusica.Location = New System.Drawing.Point(28, 108)
        Me.chkMusica.Name = "chkMusica"
        Me.chkMusica.Size = New System.Drawing.Size(60, 17)
        Me.chkMusica.TabIndex = 8
        Me.chkMusica.Text = "Musica"
        Me.chkMusica.UseVisualStyleBackColor = True
        '
        'chkJuegos
        '
        Me.chkJuegos.AutoSize = True
        Me.chkJuegos.Location = New System.Drawing.Point(28, 82)
        Me.chkJuegos.Name = "chkJuegos"
        Me.chkJuegos.Size = New System.Drawing.Size(60, 17)
        Me.chkJuegos.TabIndex = 7
        Me.chkJuegos.Text = "Juegos"
        Me.chkJuegos.UseVisualStyleBackColor = True
        '
        'chkPeliculas
        '
        Me.chkPeliculas.AutoSize = True
        Me.chkPeliculas.Location = New System.Drawing.Point(28, 59)
        Me.chkPeliculas.Name = "chkPeliculas"
        Me.chkPeliculas.Size = New System.Drawing.Size(68, 17)
        Me.chkPeliculas.TabIndex = 6
        Me.chkPeliculas.Text = "Peliculas"
        Me.chkPeliculas.UseVisualStyleBackColor = True
        '
        'chkDeportes
        '
        Me.chkDeportes.AutoSize = True
        Me.chkDeportes.Location = New System.Drawing.Point(28, 34)
        Me.chkDeportes.Name = "chkDeportes"
        Me.chkDeportes.Size = New System.Drawing.Size(69, 17)
        Me.chkDeportes.TabIndex = 5
        Me.chkDeportes.Text = "Deportes"
        Me.chkDeportes.UseVisualStyleBackColor = True
        '
        'radMasculino
        '
        Me.radMasculino.AutoSize = True
        Me.radMasculino.Location = New System.Drawing.Point(33, 211)
        Me.radMasculino.Name = "radMasculino"
        Me.radMasculino.Size = New System.Drawing.Size(73, 17)
        Me.radMasculino.TabIndex = 10
        Me.radMasculino.TabStop = True
        Me.radMasculino.Text = "Masculino"
        Me.radMasculino.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "HOBBIES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "GENERO"
        '
        'radFemenino
        '
        Me.radFemenino.AutoSize = True
        Me.radFemenino.Location = New System.Drawing.Point(33, 234)
        Me.radFemenino.Name = "radFemenino"
        Me.radFemenino.Size = New System.Drawing.Size(71, 17)
        Me.radFemenino.TabIndex = 13
        Me.radFemenino.TabStop = True
        Me.radFemenino.Text = "Femenino"
        Me.radFemenino.UseVisualStyleBackColor = True
        '
        'radOtro
        '
        Me.radOtro.AutoSize = True
        Me.radOtro.Location = New System.Drawing.Point(33, 257)
        Me.radOtro.Name = "radOtro"
        Me.radOtro.Size = New System.Drawing.Size(45, 17)
        Me.radOtro.TabIndex = 14
        Me.radOtro.TabStop = True
        Me.radOtro.Text = "Otro"
        Me.radOtro.UseVisualStyleBackColor = True
        '
        'radCasado
        '
        Me.radCasado.AutoSize = True
        Me.radCasado.Location = New System.Drawing.Point(20, 31)
        Me.radCasado.Name = "radCasado"
        Me.radCasado.Size = New System.Drawing.Size(61, 17)
        Me.radCasado.TabIndex = 0
        Me.radCasado.TabStop = True
        Me.radCasado.Text = "Casado"
        Me.radCasado.UseVisualStyleBackColor = True
        '
        'radSoltero
        '
        Me.radSoltero.AutoSize = True
        Me.radSoltero.Location = New System.Drawing.Point(21, 57)
        Me.radSoltero.Name = "radSoltero"
        Me.radSoltero.Size = New System.Drawing.Size(58, 17)
        Me.radSoltero.TabIndex = 1
        Me.radSoltero.TabStop = True
        Me.radSoltero.Text = "Soltero"
        Me.radSoltero.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(213, 59)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.lblMensaje.TabIndex = 15
        '
        'radViudo
        '
        Me.radViudo.AutoSize = True
        Me.radViudo.Location = New System.Drawing.Point(20, 80)
        Me.radViudo.Name = "radViudo"
        Me.radViudo.Size = New System.Drawing.Size(52, 17)
        Me.radViudo.TabIndex = 2
        Me.radViudo.TabStop = True
        Me.radViudo.Text = "Viudo"
        Me.radViudo.UseVisualStyleBackColor = True
        '
        'radDivorsiado
        '
        Me.radDivorsiado.AutoSize = True
        Me.radDivorsiado.Location = New System.Drawing.Point(21, 105)
        Me.radDivorsiado.Name = "radDivorsiado"
        Me.radDivorsiado.Size = New System.Drawing.Size(75, 17)
        Me.radDivorsiado.TabIndex = 3
        Me.radDivorsiado.TabStop = True
        Me.radDivorsiado.Text = "Divorsiado"
        Me.radDivorsiado.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 360)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.radOtro)
        Me.Controls.Add(Me.radFemenino)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radMasculino)
        Me.Controls.Add(Me.chkLibros)
        Me.Controls.Add(Me.chkMusica)
        Me.Controls.Add(Me.chkJuegos)
        Me.Controls.Add(Me.chkPeliculas)
        Me.Controls.Add(Me.chkDeportes)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.grpEstCiv)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpEstCiv.ResumeLayout(False)
        Me.grpEstCiv.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpEstCiv As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents chkLibros As System.Windows.Forms.CheckBox
    Friend WithEvents chkMusica As System.Windows.Forms.CheckBox
    Friend WithEvents chkJuegos As System.Windows.Forms.CheckBox
    Friend WithEvents chkPeliculas As System.Windows.Forms.CheckBox
    Friend WithEvents chkDeportes As System.Windows.Forms.CheckBox
    Friend WithEvents radMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents radOtro As System.Windows.Forms.RadioButton
    Friend WithEvents radSoltero As System.Windows.Forms.RadioButton
    Friend WithEvents radCasado As System.Windows.Forms.RadioButton
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents radDivorsiado As System.Windows.Forms.RadioButton
    Friend WithEvents radViudo As System.Windows.Forms.RadioButton

End Class
