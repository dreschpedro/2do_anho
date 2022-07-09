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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btn_menos = New System.Windows.Forms.Button()
        Me.btn_mas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl1.Location = New System.Drawing.Point(23, 29)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(12, 14)
        Me.lbl1.TabIndex = 0
        '
        'btn_menos
        '
        Me.btn_menos.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menos.Location = New System.Drawing.Point(153, 244)
        Me.btn_menos.Name = "btn_menos"
        Me.btn_menos.Size = New System.Drawing.Size(136, 65)
        Me.btn_menos.TabIndex = 1
        Me.btn_menos.Text = "-"
        Me.btn_menos.UseVisualStyleBackColor = True
        '
        'btn_mas
        '
        Me.btn_mas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mas.Location = New System.Drawing.Point(331, 244)
        Me.btn_mas.Name = "btn_mas"
        Me.btn_mas.Size = New System.Drawing.Size(135, 65)
        Me.btn_mas.TabIndex = 2
        Me.btn_mas.Text = "+"
        Me.btn_mas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 325)
        Me.Controls.Add(Me.btn_mas)
        Me.Controls.Add(Me.btn_menos)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btn_menos As System.Windows.Forms.Button
    Friend WithEvents btn_mas As System.Windows.Forms.Button

End Class
