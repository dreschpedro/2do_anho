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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.horizontal = New System.Windows.Forms.NumericUpDown()
        Me.vertical = New System.Windows.Forms.NumericUpDown()
        Me.laPelota = New System.Windows.Forms.CheckBox()
        CType(Me.horizontal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vertical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Horizontal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 417)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vertical"
        '
        'horizontal
        '
        Me.horizontal.Location = New System.Drawing.Point(100, 415)
        Me.horizontal.Maximum = New Decimal(New Integer() {313, 0, 0, 0})
        Me.horizontal.Name = "horizontal"
        Me.horizontal.Size = New System.Drawing.Size(64, 23)
        Me.horizontal.TabIndex = 3
        '
        'vertical
        '
        Me.vertical.Location = New System.Drawing.Point(324, 415)
        Me.vertical.Maximum = New Decimal(New Integer() {330, 0, 0, 0})
        Me.vertical.Name = "vertical"
        Me.vertical.Size = New System.Drawing.Size(64, 23)
        Me.vertical.TabIndex = 4
        '
        'laPelota
        '
        Me.laPelota.Appearance = System.Windows.Forms.Appearance.Button
        Me.laPelota.BackColor = System.Drawing.SystemColors.Control
        Me.laPelota.BackgroundImage = CType(resources.GetObject("laPelota.BackgroundImage"), System.Drawing.Image)
        Me.laPelota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.laPelota.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.laPelota.FlatAppearance.BorderSize = 0
        Me.laPelota.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control
        Me.laPelota.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.laPelota.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.laPelota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.laPelota.Location = New System.Drawing.Point(12, 12)
        Me.laPelota.Name = "laPelota"
        Me.laPelota.Size = New System.Drawing.Size(104, 102)
        Me.laPelota.TabIndex = 5
        Me.laPelota.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(431, 450)
        Me.Controls.Add(Me.laPelota)
        Me.Controls.Add(Me.vertical)
        Me.Controls.Add(Me.horizontal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.horizontal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vertical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents horizontal As NumericUpDown
    Friend WithEvents vertical As NumericUpDown
    Friend WithEvents laPelota As CheckBox
End Class
