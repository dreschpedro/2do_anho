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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lstVehiculos = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblclas = New System.Windows.Forms.Label()
        Me.lblcanje = New System.Windows.Forms.Label()
        Me.lblusa = New System.Windows.Forms.Label()
        Me.lblsemi = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbxDominio = New System.Windows.Forms.TextBox()
        Me.tbxColor = New System.Windows.Forms.TextBox()
        Me.tbxAno = New System.Windows.Forms.TextBox()
        Me.tbxMarca = New System.Windows.Forms.TextBox()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(29, 34)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(57, 15)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Vehiculos"
        '
        'lstVehiculos
        '
        Me.lstVehiculos.FormattingEnabled = True
        Me.lstVehiculos.ItemHeight = 15
        Me.lstVehiculos.Location = New System.Drawing.Point(12, 52)
        Me.lstVehiculos.Name = "lstVehiculos"
        Me.lstVehiculos.Size = New System.Drawing.Size(106, 304)
        Me.lstVehiculos.TabIndex = 1
        Me.lstVehiculos.Tag = "encontrado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dominio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Marca"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Año"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(392, 55)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(392, 101)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(392, 146)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(392, 199)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(392, 243)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblclas)
        Me.GroupBox1.Controls.Add(Me.lblcanje)
        Me.GroupBox1.Controls.Add(Me.lblusa)
        Me.GroupBox1.Controls.Add(Me.lblsemi)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(523, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 159)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'lblclas
        '
        Me.lblclas.AutoSize = True
        Me.lblclas.BackColor = System.Drawing.Color.White
        Me.lblclas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblclas.Location = New System.Drawing.Point(132, 124)
        Me.lblclas.Name = "lblclas"
        Me.lblclas.Size = New System.Drawing.Size(15, 17)
        Me.lblclas.TabIndex = 21
        Me.lblclas.Text = "0"
        '
        'lblcanje
        '
        Me.lblcanje.AutoSize = True
        Me.lblcanje.BackColor = System.Drawing.Color.White
        Me.lblcanje.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblcanje.Location = New System.Drawing.Point(132, 91)
        Me.lblcanje.Name = "lblcanje"
        Me.lblcanje.Size = New System.Drawing.Size(15, 17)
        Me.lblcanje.TabIndex = 20
        Me.lblcanje.Text = "0"
        '
        'lblusa
        '
        Me.lblusa.AutoSize = True
        Me.lblusa.BackColor = System.Drawing.Color.White
        Me.lblusa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblusa.Location = New System.Drawing.Point(132, 54)
        Me.lblusa.Name = "lblusa"
        Me.lblusa.Size = New System.Drawing.Size(15, 17)
        Me.lblusa.TabIndex = 19
        Me.lblusa.Text = "0"
        '
        'lblsemi
        '
        Me.lblsemi.AutoSize = True
        Me.lblsemi.BackColor = System.Drawing.Color.White
        Me.lblsemi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblsemi.Location = New System.Drawing.Point(132, 19)
        Me.lblsemi.Name = "lblsemi"
        Me.lblsemi.Size = New System.Drawing.Size(15, 17)
        Me.lblsemi.TabIndex = 18
        Me.lblsemi.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Semi nuevo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Usados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Plan Canje"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 15)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Clásico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(523, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total de Vehiculos"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(655, 297)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 21)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "0"
        '
        'tbxDominio
        '
        Me.tbxDominio.Location = New System.Drawing.Point(245, 55)
        Me.tbxDominio.Name = "tbxDominio"
        Me.tbxDominio.Size = New System.Drawing.Size(100, 23)
        Me.tbxDominio.TabIndex = 24
        '
        'tbxColor
        '
        Me.tbxColor.Location = New System.Drawing.Point(245, 195)
        Me.tbxColor.Name = "tbxColor"
        Me.tbxColor.Size = New System.Drawing.Size(100, 23)
        Me.tbxColor.TabIndex = 25
        '
        'tbxAno
        '
        Me.tbxAno.Location = New System.Drawing.Point(245, 243)
        Me.tbxAno.Name = "tbxAno"
        Me.tbxAno.Size = New System.Drawing.Size(100, 23)
        Me.tbxAno.TabIndex = 26
        '
        'tbxMarca
        '
        Me.tbxMarca.Location = New System.Drawing.Point(245, 146)
        Me.tbxMarca.Name = "tbxMarca"
        Me.tbxMarca.Size = New System.Drawing.Size(100, 23)
        Me.tbxMarca.TabIndex = 27
        '
        'cbxTipo
        '
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Auto", "Utilitario", "Camioneta"})
        Me.cbxTipo.Location = New System.Drawing.Point(245, 105)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(100, 23)
        Me.cbxTipo.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbxTipo)
        Me.Controls.Add(Me.tbxMarca)
        Me.Controls.Add(Me.tbxAno)
        Me.Controls.Add(Me.tbxColor)
        Me.Controls.Add(Me.tbxDominio)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstVehiculos)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Form1"
        Me.Text = "Registro de Vehiculos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents lstVehiculos As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblclas As Label
    Friend WithEvents lblcanje As Label
    Friend WithEvents lblusa As Label
    Friend WithEvents lblsemi As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tbxDominio As TextBox
    Friend WithEvents tbxColor As TextBox
    Friend WithEvents tbxAno As TextBox
    Friend WithEvents tbxMarca As TextBox
    Friend WithEvents cbxTipo As ComboBox
End Class
