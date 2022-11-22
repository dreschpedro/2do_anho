<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemas
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
        Me.lstTemas = New System.Windows.Forms.ListBox()
        Me.txtTema = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstTemas
        '
        Me.lstTemas.FormattingEnabled = True
        Me.lstTemas.Location = New System.Drawing.Point(22, 47)
        Me.lstTemas.Name = "lstTemas"
        Me.lstTemas.Size = New System.Drawing.Size(247, 82)
        Me.lstTemas.TabIndex = 0
        Me.lstTemas.Visible = False
        '
        'txtTema
        '
        Me.txtTema.Location = New System.Drawing.Point(22, 21)
        Me.txtTema.Name = "txtTema"
        Me.txtTema.Size = New System.Drawing.Size(247, 20)
        Me.txtTema.TabIndex = 0
        '
        'frmTemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 273)
        Me.Controls.Add(Me.txtTema)
        Me.Controls.Add(Me.lstTemas)
        Me.Name = "frmTemas"
        Me.Text = "Buscador de Temas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTemas As System.Windows.Forms.ListBox
    Friend WithEvents txtTema As System.Windows.Forms.TextBox
End Class
