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
        Me.btnConversion = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnCapturaRango = New System.Windows.Forms.Button()
        Me.txtInicio = New System.Windows.Forms.TextBox()
        Me.txtFin = New System.Windows.Forms.TextBox()
        Me.btnSelecRango = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardarBD = New System.Windows.Forms.Button()
        Me.btnTraer = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblFechaSistema = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConversion
        '
        Me.btnConversion.Location = New System.Drawing.Point(257, 12)
        Me.btnConversion.Name = "btnConversion"
        Me.btnConversion.Size = New System.Drawing.Size(171, 41)
        Me.btnConversion.TabIndex = 0
        Me.btnConversion.Text = "Control + Conversion"
        Me.btnConversion.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(56, 12)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(153, 20)
        Me.txtFecha.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(66, 57)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Yellow
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFecha.Location = New System.Drawing.Point(81, 100)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(80, 24)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "FECHA"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.AnnuallyBoldedDates = New Date() {New Date(2019, 10, 12, 0, 0, 0, 0), New Date(2019, 12, 8, 0, 0, 0, 0)}
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 189)
        Me.MonthCalendar1.MonthlyBoldedDates = New Date() {New Date(2019, 11, 1, 0, 0, 0, 0), New Date(2019, 11, 8, 0, 0, 0, 0)}
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'btnCapturaRango
        '
        Me.btnCapturaRango.Location = New System.Drawing.Point(47, 364)
        Me.btnCapturaRango.Name = "btnCapturaRango"
        Me.btnCapturaRango.Size = New System.Drawing.Size(128, 27)
        Me.btnCapturaRango.TabIndex = 5
        Me.btnCapturaRango.Text = "Captura Month"
        Me.btnCapturaRango.UseVisualStyleBackColor = True
        '
        'txtInicio
        '
        Me.txtInicio.Location = New System.Drawing.Point(214, 261)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.Size = New System.Drawing.Size(100, 20)
        Me.txtInicio.TabIndex = 6
        '
        'txtFin
        '
        Me.txtFin.Location = New System.Drawing.Point(214, 303)
        Me.txtFin.Name = "txtFin"
        Me.txtFin.Size = New System.Drawing.Size(100, 20)
        Me.txtFin.TabIndex = 7
        '
        'btnSelecRango
        '
        Me.btnSelecRango.Location = New System.Drawing.Point(200, 364)
        Me.btnSelecRango.Name = "btnSelecRango"
        Me.btnSelecRango.Size = New System.Drawing.Size(128, 27)
        Me.btnSelecRango.TabIndex = 8
        Me.btnSelecRango.Text = "Selecciona Month"
        Me.btnSelecRango.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Inicio Rango"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fin Rango"
        '
        'btnGuardarBD
        '
        Me.btnGuardarBD.Location = New System.Drawing.Point(257, 68)
        Me.btnGuardarBD.Name = "btnGuardarBD"
        Me.btnGuardarBD.Size = New System.Drawing.Size(165, 31)
        Me.btnGuardarBD.TabIndex = 11
        Me.btnGuardarBD.Text = "Guardar en BD"
        Me.btnGuardarBD.UseVisualStyleBackColor = True
        '
        'btnTraer
        '
        Me.btnTraer.Location = New System.Drawing.Point(257, 118)
        Me.btnTraer.Name = "btnTraer"
        Me.btnTraer.Size = New System.Drawing.Size(165, 31)
        Me.btnTraer.TabIndex = 12
        Me.btnTraer.Text = "Traer de BD"
        Me.btnTraer.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(447, 404)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 15
        Me.LineShape1.X2 = 427
        Me.LineShape1.Y1 = 175
        Me.LineShape1.Y2 = 175
        '
        'lblFechaSistema
        '
        Me.lblFechaSistema.AutoSize = True
        Me.lblFechaSistema.BackColor = System.Drawing.Color.Yellow
        Me.lblFechaSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaSistema.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFechaSistema.Location = New System.Drawing.Point(234, 189)
        Me.lblFechaSistema.Name = "lblFechaSistema"
        Me.lblFechaSistema.Size = New System.Drawing.Size(80, 24)
        Me.lblFechaSistema.TabIndex = 14
        Me.lblFechaSistema.Text = "FECHA"
        Me.lblFechaSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 404)
        Me.Controls.Add(Me.lblFechaSistema)
        Me.Controls.Add(Me.btnTraer)
        Me.Controls.Add(Me.btnGuardarBD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSelecRango)
        Me.Controls.Add(Me.txtFin)
        Me.Controls.Add(Me.txtInicio)
        Me.Controls.Add(Me.btnCapturaRango)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.btnConversion)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConversion As System.Windows.Forms.Button
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnCapturaRango As System.Windows.Forms.Button
    Friend WithEvents txtInicio As System.Windows.Forms.TextBox
    Friend WithEvents txtFin As System.Windows.Forms.TextBox
    Friend WithEvents btnSelecRango As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarBD As System.Windows.Forms.Button
    Friend WithEvents btnTraer As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblFechaSistema As System.Windows.Forms.Label

End Class
