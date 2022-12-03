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
        Me.lbl_iva = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_pvp = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.btn_copiar = New System.Windows.Forms.Button()
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
        'lbl_iva
        '
        Me.lbl_iva.AutoSize = True
        Me.lbl_iva.Location = New System.Drawing.Point(45, 63)
        Me.lbl_iva.Name = "lbl_iva"
        Me.lbl_iva.Size = New System.Drawing.Size(62, 13)
        Me.lbl_iva.TabIndex = 2
        Me.lbl_iva.Text = "Importe IVA"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(130, 16)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 3
        '
        'txt_iva
        '
        Me.txt_iva.BackColor = System.Drawing.SystemColors.Info
        Me.txt_iva.Enabled = False
        Me.txt_iva.Location = New System.Drawing.Point(130, 59)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(100, 20)
        Me.txt_iva.TabIndex = 4
        Me.txt_iva.Text = "21 %"
        Me.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_pvp
        '
        Me.txt_pvp.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_pvp.Enabled = False
        Me.txt_pvp.Location = New System.Drawing.Point(130, 117)
        Me.txt_pvp.Name = "txt_pvp"
        Me.txt_pvp.Size = New System.Drawing.Size(100, 20)
        Me.txt_pvp.TabIndex = 5
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(64, 173)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(108, 33)
        Me.btn_calcular.TabIndex = 6
        Me.btn_calcular.Text = "Calculat PVP"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.ForeColor = System.Drawing.SystemColors.Info
        Me.btn_borrar.Location = New System.Drawing.Point(196, 178)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(61, 22)
        Me.btn_borrar.TabIndex = 8
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = False
        '
        'btn_copiar
        '
        Me.btn_copiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_copiar.Location = New System.Drawing.Point(169, 145)
        Me.btn_copiar.Name = "btn_copiar"
        Me.btn_copiar.Size = New System.Drawing.Size(103, 22)
        Me.btn_copiar.TabIndex = 9
        Me.btn_copiar.Text = "Copiar Resultado"
        Me.btn_copiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 218)
        Me.Controls.Add(Me.btn_copiar)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_pvp)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.lbl_iva)
        Me.Controls.Add(Me.lbl_pvp)
        Me.Controls.Add(Me.lbl_precio_neto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_precio_neto As System.Windows.Forms.Label
    Friend WithEvents lbl_pvp As System.Windows.Forms.Label
    Friend WithEvents lbl_iva As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents txt_pvp As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Private WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_copiar As System.Windows.Forms.Button

End Class
