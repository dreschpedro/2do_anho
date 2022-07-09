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
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_pais = New System.Windows.Forms.Label()
        Me.lbl_pcia = New System.Windows.Forms.Label()
        Me.cmb_pais = New System.Windows.Forms.ComboBox()
        Me.lst_pcia = New System.Windows.Forms.ListBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_imprimir.Location = New System.Drawing.Point(12, 305)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(113, 38)
        Me.btn_imprimir.TabIndex = 0
        Me.btn_imprimir.Text = "Imprimir"
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo.Location = New System.Drawing.Point(332, 140)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(113, 55)
        Me.btn_nuevo.TabIndex = 1
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_salir.Location = New System.Drawing.Point(332, 305)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(113, 38)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(50, 35)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(62, 18)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "Nombre"
        '
        'lbl_pais
        '
        Me.lbl_pais.AutoSize = True
        Me.lbl_pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pais.Location = New System.Drawing.Point(50, 75)
        Me.lbl_pais.Name = "lbl_pais"
        Me.lbl_pais.Size = New System.Drawing.Size(37, 18)
        Me.lbl_pais.TabIndex = 4
        Me.lbl_pais.Text = "Pais"
        '
        'lbl_pcia
        '
        Me.lbl_pcia.AutoSize = True
        Me.lbl_pcia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pcia.Location = New System.Drawing.Point(50, 119)
        Me.lbl_pcia.Name = "lbl_pcia"
        Me.lbl_pcia.Size = New System.Drawing.Size(120, 18)
        Me.lbl_pcia.TabIndex = 5
        Me.lbl_pcia.Text = "Estado/Provincia"
        Me.lbl_pcia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_pais
        '
        Me.cmb_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pais.FormattingEnabled = True
        Me.cmb_pais.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmb_pais.Location = New System.Drawing.Point(118, 72)
        Me.cmb_pais.Name = "cmb_pais"
        Me.cmb_pais.Size = New System.Drawing.Size(181, 21)
        Me.cmb_pais.Sorted = True
        Me.cmb_pais.TabIndex = 6
        '
        'lst_pcia
        '
        Me.lst_pcia.FormattingEnabled = True
        Me.lst_pcia.Location = New System.Drawing.Point(118, 140)
        Me.lst_pcia.Name = "lst_pcia"
        Me.lst_pcia.Size = New System.Drawing.Size(181, 121)
        Me.lst_pcia.TabIndex = 7
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(118, 35)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(181, 20)
        Me.txt_nombre.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 355)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lst_pcia)
        Me.Controls.Add(Me.cmb_pais)
        Me.Controls.Add(Me.lbl_pcia)
        Me.Controls.Add(Me.lbl_pais)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_imprimir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_pais As System.Windows.Forms.Label
    Friend WithEvents lbl_pcia As System.Windows.Forms.Label
    Friend WithEvents lst_pcia As System.Windows.Forms.ListBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents cmb_pais As System.Windows.Forms.ComboBox

End Class
