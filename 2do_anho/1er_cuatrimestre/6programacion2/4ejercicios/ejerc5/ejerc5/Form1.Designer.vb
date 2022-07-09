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
        Me.chk_iva_pje = New System.Windows.Forms.CheckBox()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_iva = New System.Windows.Forms.Label()
        Me.lbl_pvp = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_pvp = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_borrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chk_iva_pje
        '
        Me.chk_iva_pje.AutoSize = True
        Me.chk_iva_pje.Location = New System.Drawing.Point(91, 17)
        Me.chk_iva_pje.Name = "chk_iva_pje"
        Me.chk_iva_pje.Size = New System.Drawing.Size(110, 17)
        Me.chk_iva_pje.TabIndex = 0
        Me.chk_iva_pje.Text = "Iva en Porcentaje"
        Me.chk_iva_pje.UseVisualStyleBackColor = True
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(34, 72)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(63, 13)
        Me.lbl_precio.TabIndex = 1
        Me.lbl_precio.Text = "Precio Neto"
        '
        'lbl_iva
        '
        Me.lbl_iva.AutoSize = True
        Me.lbl_iva.Location = New System.Drawing.Point(69, 104)
        Me.lbl_iva.Name = "lbl_iva"
        Me.lbl_iva.Size = New System.Drawing.Size(24, 13)
        Me.lbl_iva.TabIndex = 2
        Me.lbl_iva.Text = "IVA"
        '
        'lbl_pvp
        '
        Me.lbl_pvp.AutoSize = True
        Me.lbl_pvp.Location = New System.Drawing.Point(64, 140)
        Me.lbl_pvp.Name = "lbl_pvp"
        Me.lbl_pvp.Size = New System.Drawing.Size(28, 13)
        Me.lbl_pvp.TabIndex = 3
        Me.lbl_pvp.Text = "PVP"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(116, 68)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio.TabIndex = 5
        '
        'txt_iva
        '
        Me.txt_iva.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_iva.Enabled = False
        Me.txt_iva.Location = New System.Drawing.Point(116, 101)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(100, 20)
        Me.txt_iva.TabIndex = 6
        Me.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_pvp
        '
        Me.txt_pvp.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_pvp.Enabled = False
        Me.txt_pvp.Location = New System.Drawing.Point(116, 137)
        Me.txt_pvp.Name = "txt_pvp"
        Me.txt_pvp.Size = New System.Drawing.Size(100, 20)
        Me.txt_pvp.TabIndex = 7
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(80, 200)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_calcular.TabIndex = 8
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'btn_borrar
        '
        Me.btn_borrar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_borrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_borrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_borrar.Location = New System.Drawing.Point(197, 226)
        Me.btn_borrar.Name = "btn_borrar"
        Me.btn_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrar.TabIndex = 9
        Me.btn_borrar.Text = "Borrar"
        Me.btn_borrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_borrar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_pvp)
        Me.Controls.Add(Me.txt_iva)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.lbl_pvp)
        Me.Controls.Add(Me.lbl_iva)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.chk_iva_pje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_iva_pje As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_precio As System.Windows.Forms.Label
    Friend WithEvents lbl_iva As System.Windows.Forms.Label
    Friend WithEvents lbl_pvp As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents txt_pvp As System.Windows.Forms.TextBox
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents btn_borrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
