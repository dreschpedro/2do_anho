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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtFechaUsuario = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFechaConvertida = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnConversion = New System.Windows.Forms.Button
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Listado1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Listado2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFechaUsuario
        '
        Me.txtFechaUsuario.Location = New System.Drawing.Point(196, 88)
        Me.txtFechaUsuario.Name = "txtFechaUsuario"
        Me.txtFechaUsuario.Size = New System.Drawing.Size(196, 20)
        Me.txtFechaUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese fecha"
        '
        'lblFechaConvertida
        '
        Me.lblFechaConvertida.AutoSize = True
        Me.lblFechaConvertida.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaConvertida.Location = New System.Drawing.Point(193, 207)
        Me.lblFechaConvertida.Name = "lblFechaConvertida"
        Me.lblFechaConvertida.Size = New System.Drawing.Size(0, 24)
        Me.lblFechaConvertida.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Conversion de Fecha"
        '
        'btnConversion
        '
        Me.btnConversion.Location = New System.Drawing.Point(408, 120)
        Me.btnConversion.Name = "btnConversion"
        Me.btnConversion.Size = New System.Drawing.Size(94, 96)
        Me.btnConversion.TabIndex = 4
        Me.btnConversion.Text = "Convertir"
        Me.btnConversion.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(247, 139)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(124, 20)
        Me.dtpFecha.TabIndex = 5
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(393, 273)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(82, 39)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem, Me.ToolStripComboBox1, Me.ToolStripTextBox1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(522, 25)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Listado1ToolStripMenuItem, Me.Listado2ToolStripMenuItem})
        Me.ImprimirToolStripMenuItem.Image = CType(resources.GetObject("ImprimirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(73, 21)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'Listado1ToolStripMenuItem
        '
        Me.Listado1ToolStripMenuItem.Name = "Listado1ToolStripMenuItem"
        Me.Listado1ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.Listado1ToolStripMenuItem.Text = "Listado1"
        '
        'Listado2ToolStripMenuItem
        '
        Me.Listado2ToolStripMenuItem.Name = "Listado2ToolStripMenuItem"
        Me.Listado2ToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.Listado2ToolStripMenuItem.Text = "Listado2"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Uno", "Dos", "Tres"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 21)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 53)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 383)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnConversion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFechaConvertida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFechaUsuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFechaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFechaConvertida As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConversion As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Listado1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Listado2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
