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
        Me.lbl_op1 = New System.Windows.Forms.Label()
        Me.lbl_igual = New System.Windows.Forms.Label()
        Me.lbl_operacion = New System.Windows.Forms.Label()
        Me.lbl_Rdo = New System.Windows.Forms.Label()
        Me.lbl_op2 = New System.Windows.Forms.Label()
        Me.chk_suma = New System.Windows.Forms.CheckBox()
        Me.chk_resta = New System.Windows.Forms.CheckBox()
        Me.chk_multi = New System.Windows.Forms.CheckBox()
        Me.chk_divi = New System.Windows.Forms.CheckBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.txt_op1 = New System.Windows.Forms.TextBox()
        Me.txt_op2 = New System.Windows.Forms.TextBox()
        Me.txt_rdo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_op1
        '
        Me.lbl_op1.AutoSize = True
        Me.lbl_op1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_op1.Location = New System.Drawing.Point(27, 29)
        Me.lbl_op1.Name = "lbl_op1"
        Me.lbl_op1.Size = New System.Drawing.Size(76, 16)
        Me.lbl_op1.TabIndex = 0
        Me.lbl_op1.Text = "Operador 1"
        '
        'lbl_igual
        '
        Me.lbl_igual.AutoSize = True
        Me.lbl_igual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_igual.Location = New System.Drawing.Point(252, 55)
        Me.lbl_igual.Name = "lbl_igual"
        Me.lbl_igual.Size = New System.Drawing.Size(18, 18)
        Me.lbl_igual.TabIndex = 3
        Me.lbl_igual.Text = "="
        '
        'lbl_operacion
        '
        Me.lbl_operacion.AutoSize = True
        Me.lbl_operacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_operacion.Location = New System.Drawing.Point(123, 55)
        Me.lbl_operacion.Name = "lbl_operacion"
        Me.lbl_operacion.Size = New System.Drawing.Size(11, 13)
        Me.lbl_operacion.TabIndex = 4
        Me.lbl_operacion.Text = "."
        '
        'lbl_Rdo
        '
        Me.lbl_Rdo.AutoSize = True
        Me.lbl_Rdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Rdo.Location = New System.Drawing.Point(294, 29)
        Me.lbl_Rdo.Name = "lbl_Rdo"
        Me.lbl_Rdo.Size = New System.Drawing.Size(70, 16)
        Me.lbl_Rdo.TabIndex = 5
        Me.lbl_Rdo.Text = "Resultado"
        '
        'lbl_op2
        '
        Me.lbl_op2.AutoSize = True
        Me.lbl_op2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_op2.Location = New System.Drawing.Point(166, 29)
        Me.lbl_op2.Name = "lbl_op2"
        Me.lbl_op2.Size = New System.Drawing.Size(79, 16)
        Me.lbl_op2.TabIndex = 6
        Me.lbl_op2.Text = "Operando 2"
        '
        'chk_suma
        '
        Me.chk_suma.AutoSize = True
        Me.chk_suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_suma.Location = New System.Drawing.Point(29, 112)
        Me.chk_suma.Name = "chk_suma"
        Me.chk_suma.Size = New System.Drawing.Size(37, 22)
        Me.chk_suma.TabIndex = 7
        Me.chk_suma.Text = "+"
        Me.chk_suma.UseVisualStyleBackColor = True
        '
        'chk_resta
        '
        Me.chk_resta.AutoSize = True
        Me.chk_resta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_resta.Location = New System.Drawing.Point(81, 108)
        Me.chk_resta.Name = "chk_resta"
        Me.chk_resta.Size = New System.Drawing.Size(39, 29)
        Me.chk_resta.TabIndex = 8
        Me.chk_resta.Text = "-"
        Me.chk_resta.UseVisualStyleBackColor = True
        '
        'chk_multi
        '
        Me.chk_multi.AutoSize = True
        Me.chk_multi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_multi.Location = New System.Drawing.Point(137, 112)
        Me.chk_multi.Name = "chk_multi"
        Me.chk_multi.Size = New System.Drawing.Size(35, 22)
        Me.chk_multi.TabIndex = 9
        Me.chk_multi.Text = "x"
        Me.chk_multi.UseVisualStyleBackColor = True
        '
        'chk_divi
        '
        Me.chk_divi.AutoSize = True
        Me.chk_divi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_divi.Location = New System.Drawing.Point(202, 114)
        Me.chk_divi.Name = "chk_divi"
        Me.chk_divi.Size = New System.Drawing.Size(38, 19)
        Me.chk_divi.TabIndex = 10
        Me.chk_divi.Text = "%"
        Me.chk_divi.UseVisualStyleBackColor = True
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calcular.Location = New System.Drawing.Point(273, 103)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(100, 36)
        Me.btn_calcular.TabIndex = 11
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'txt_op1
        '
        Me.txt_op1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_op1.Location = New System.Drawing.Point(12, 50)
        Me.txt_op1.Name = "txt_op1"
        Me.txt_op1.Size = New System.Drawing.Size(100, 22)
        Me.txt_op1.TabIndex = 12
        '
        'txt_op2
        '
        Me.txt_op2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_op2.Location = New System.Drawing.Point(146, 50)
        Me.txt_op2.Name = "txt_op2"
        Me.txt_op2.Size = New System.Drawing.Size(100, 22)
        Me.txt_op2.TabIndex = 13
        '
        'txt_rdo
        '
        Me.txt_rdo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_rdo.Enabled = False
        Me.txt_rdo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rdo.Location = New System.Drawing.Point(273, 50)
        Me.txt_rdo.Name = "txt_rdo"
        Me.txt_rdo.Size = New System.Drawing.Size(100, 22)
        Me.txt_rdo.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 156)
        Me.Controls.Add(Me.txt_rdo)
        Me.Controls.Add(Me.txt_op2)
        Me.Controls.Add(Me.txt_op1)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.chk_divi)
        Me.Controls.Add(Me.chk_multi)
        Me.Controls.Add(Me.chk_resta)
        Me.Controls.Add(Me.chk_suma)
        Me.Controls.Add(Me.lbl_op2)
        Me.Controls.Add(Me.lbl_Rdo)
        Me.Controls.Add(Me.lbl_operacion)
        Me.Controls.Add(Me.lbl_igual)
        Me.Controls.Add(Me.lbl_op1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_op1 As System.Windows.Forms.Label
    Friend WithEvents lbl_igual As System.Windows.Forms.Label
    Friend WithEvents lbl_operacion As System.Windows.Forms.Label
    Friend WithEvents lbl_Rdo As System.Windows.Forms.Label
    Friend WithEvents lbl_op2 As System.Windows.Forms.Label
    Friend WithEvents chk_suma As System.Windows.Forms.CheckBox
    Friend WithEvents chk_resta As System.Windows.Forms.CheckBox
    Friend WithEvents chk_multi As System.Windows.Forms.CheckBox
    Friend WithEvents chk_divi As System.Windows.Forms.CheckBox
    Friend WithEvents btn_calcular As System.Windows.Forms.Button
    Friend WithEvents txt_op1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_op2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_rdo As System.Windows.Forms.TextBox

End Class
