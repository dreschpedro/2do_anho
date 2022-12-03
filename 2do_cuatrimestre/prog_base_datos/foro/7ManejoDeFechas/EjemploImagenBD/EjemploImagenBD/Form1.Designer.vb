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
        Me.btnCargarImagen = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtPathImg = New System.Windows.Forms.TextBox
        Me.pbPicture = New System.Windows.Forms.PictureBox
        Me.btnBuscarImagen = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.lstIDImg = New System.Windows.Forms.ListBox
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.Location = New System.Drawing.Point(320, 352)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(110, 41)
        Me.btnCargarImagen.TabIndex = 0
        Me.btnCargarImagen.Text = "Cargar Imagen desde BD"
        Me.btnCargarImagen.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtPathImg
        '
        Me.txtPathImg.Location = New System.Drawing.Point(39, 41)
        Me.txtPathImg.Name = "txtPathImg"
        Me.txtPathImg.Size = New System.Drawing.Size(391, 20)
        Me.txtPathImg.TabIndex = 1
        '
        'pbPicture
        '
        Me.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPicture.Location = New System.Drawing.Point(149, 98)
        Me.pbPicture.Name = "pbPicture"
        Me.pbPicture.Size = New System.Drawing.Size(281, 215)
        Me.pbPicture.TabIndex = 2
        Me.pbPicture.TabStop = False
        '
        'btnBuscarImagen
        '
        Me.btnBuscarImagen.Location = New System.Drawing.Point(453, 41)
        Me.btnBuscarImagen.Name = "btnBuscarImagen"
        Me.btnBuscarImagen.Size = New System.Drawing.Size(110, 41)
        Me.btnBuscarImagen.TabIndex = 3
        Me.btnBuscarImagen.Text = "Buscar Imagen"
        Me.btnBuscarImagen.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(453, 154)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 41)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar Imagen en BD"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PATH DE IMAGEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ID REGISTRO"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(151, 363)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(126, 20)
        Me.txtId.TabIndex = 6
        '
        'lstIDImg
        '
        Me.lstIDImg.FormattingEnabled = True
        Me.lstIDImg.Location = New System.Drawing.Point(34, 97)
        Me.lstIDImg.Name = "lstIDImg"
        Me.lstIDImg.Size = New System.Drawing.Size(90, 212)
        Me.lstIDImg.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 409)
        Me.Controls.Add(Me.lstIDImg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnBuscarImagen)
        Me.Controls.Add(Me.pbPicture)
        Me.Controls.Add(Me.txtPathImg)
        Me.Controls.Add(Me.btnCargarImagen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCargarImagen As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtPathImg As System.Windows.Forms.TextBox
    Friend WithEvents pbPicture As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscarImagen As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents lstIDImg As System.Windows.Forms.ListBox

End Class
