<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Editor = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.muestra = New System.Windows.Forms.Label()
        Me.btnFondo = New System.Windows.Forms.Button()
        Me.btnColorFuente = New System.Windows.Forms.Button()
        Me.btnFuente = New System.Windows.Forms.Button()
        Me.Editor.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Editor
        '
        Me.Editor.Controls.Add(Me.TabPage1)
        Me.Editor.Controls.Add(Me.TabPage2)
        Me.Editor.Location = New System.Drawing.Point(12, 12)
        Me.Editor.Name = "Editor"
        Me.Editor.SelectedIndex = 0
        Me.Editor.Size = New System.Drawing.Size(776, 426)
        Me.Editor.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 398)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Editor"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(768, 398)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " & vbCrLf &"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.btnFondo)
        Me.TabPage2.Controls.Add(Me.btnColorFuente)
        Me.TabPage2.Controls.Add(Me.btnFuente)
        Me.TabPage2.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 398)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Configuraión"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.muestra)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(375, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 138)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Muestra"
        '
        'muestra
        '
        Me.muestra.AutoSize = True
        Me.muestra.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.muestra.ForeColor = System.Drawing.Color.Black
        Me.muestra.Location = New System.Drawing.Point(86, 67)
        Me.muestra.Name = "muestra"
        Me.muestra.Size = New System.Drawing.Size(24, 25)
        Me.muestra.TabIndex = 0
        Me.muestra.Text = "A"
        '
        'btnFondo
        '
        Me.btnFondo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFondo.Location = New System.Drawing.Point(62, 251)
        Me.btnFondo.Name = "btnFondo"
        Me.btnFondo.Size = New System.Drawing.Size(115, 46)
        Me.btnFondo.TabIndex = 2
        Me.btnFondo.Text = "Color de Fondo"
        Me.btnFondo.UseVisualStyleBackColor = True
        '
        'btnColorFuente
        '
        Me.btnColorFuente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnColorFuente.Location = New System.Drawing.Point(62, 182)
        Me.btnColorFuente.Name = "btnColorFuente"
        Me.btnColorFuente.Size = New System.Drawing.Size(115, 46)
        Me.btnColorFuente.TabIndex = 1
        Me.btnColorFuente.Text = "Color de Fuente"
        Me.btnColorFuente.UseVisualStyleBackColor = True
        '
        'btnFuente
        '
        Me.btnFuente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFuente.Location = New System.Drawing.Point(62, 113)
        Me.btnFuente.Name = "btnFuente"
        Me.btnFuente.Size = New System.Drawing.Size(115, 46)
        Me.btnFuente.TabIndex = 0
        Me.btnFuente.Text = "Fuente"
        Me.btnFuente.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Editor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Editor.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Editor As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents muestra As Label
    Friend WithEvents btnFondo As Button
    Friend WithEvents btnColorFuente As Button
    Friend WithEvents btnFuente As Button
End Class
