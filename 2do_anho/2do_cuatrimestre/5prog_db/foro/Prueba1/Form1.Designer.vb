<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMostrarGrilla = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnMostrarGrilla
        '
        Me.btnMostrarGrilla.Location = New System.Drawing.Point(422, 91)
        Me.btnMostrarGrilla.Name = "btnMostrarGrilla"
        Me.btnMostrarGrilla.Size = New System.Drawing.Size(119, 67)
        Me.btnMostrarGrilla.TabIndex = 0
        Me.btnMostrarGrilla.Text = "Mostrar Grilla 1"
        Me.btnMostrarGrilla.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(422, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 67)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Mostrar Grilla 2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(122, 102)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(184, 20)
        Me.txtFiltro.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 461)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMostrarGrilla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMostrarGrilla As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFiltro As TextBox
End Class
