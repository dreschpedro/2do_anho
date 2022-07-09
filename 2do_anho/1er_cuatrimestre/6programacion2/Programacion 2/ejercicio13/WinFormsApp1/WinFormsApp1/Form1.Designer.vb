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
        Me.lbclientes = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDeuda = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PromPeq = New System.Windows.Forms.Label()
        Me.promMedio = New System.Windows.Forms.Label()
        Me.PromImport = New System.Windows.Forms.Label()
        Me.PromGran = New System.Windows.Forms.Label()
        Me.promPrefer = New System.Windows.Forms.Label()
        Me.totPeq = New System.Windows.Forms.Label()
        Me.totMedio = New System.Windows.Forms.Label()
        Me.totImport = New System.Windows.Forms.Label()
        Me.totGrande = New System.Windows.Forms.Label()
        Me.totPreferido = New System.Windows.Forms.Label()
        Me.cantPeque = New System.Windows.Forms.Label()
        Me.cantMedio = New System.Windows.Forms.Label()
        Me.cantImport = New System.Windows.Forms.Label()
        Me.cantGran = New System.Windows.Forms.Label()
        Me.cantPreferencial = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.categoria = New System.Windows.Forms.Label()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbclientes
        '
        Me.lbclientes.FormattingEnabled = True
        Me.lbclientes.ItemHeight = 15
        Me.lbclientes.Location = New System.Drawing.Point(12, 55)
        Me.lbclientes.Name = "lbclientes"
        Me.lbclientes.Size = New System.Drawing.Size(142, 334)
        Me.lbclientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clientes:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(355, 79)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(355, 177)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(355, 222)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(355, 128)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(485, 418)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(310, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Telefono:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Deuda:"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(237, 79)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(100, 23)
        Me.txtdni.TabIndex = 11
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(237, 128)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 23)
        Me.txtNombre.TabIndex = 12
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(237, 173)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 23)
        Me.txtTelefono.TabIndex = 13
        '
        'txtDeuda
        '
        Me.txtDeuda.Location = New System.Drawing.Point(237, 224)
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.Size = New System.Drawing.Size(100, 23)
        Me.txtDeuda.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.PromPeq)
        Me.GroupBox1.Controls.Add(Me.promMedio)
        Me.GroupBox1.Controls.Add(Me.PromImport)
        Me.GroupBox1.Controls.Add(Me.PromGran)
        Me.GroupBox1.Controls.Add(Me.promPrefer)
        Me.GroupBox1.Controls.Add(Me.totPeq)
        Me.GroupBox1.Controls.Add(Me.totMedio)
        Me.GroupBox1.Controls.Add(Me.totImport)
        Me.GroupBox1.Controls.Add(Me.totGrande)
        Me.GroupBox1.Controls.Add(Me.totPreferido)
        Me.GroupBox1.Controls.Add(Me.cantPeque)
        Me.GroupBox1.Controls.Add(Me.cantMedio)
        Me.GroupBox1.Controls.Add(Me.cantImport)
        Me.GroupBox1.Controls.Add(Me.cantGran)
        Me.GroupBox1.Controls.Add(Me.cantPreferencial)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(436, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 354)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de Clientes"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(82, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 15)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Tot clientes"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(254, 21)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 15)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Prom. Deuda"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(167, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 15)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Deuda total"
        '
        'PromPeq
        '
        Me.PromPeq.AutoSize = True
        Me.PromPeq.BackColor = System.Drawing.Color.White
        Me.PromPeq.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PromPeq.ForeColor = System.Drawing.Color.Red
        Me.PromPeq.Location = New System.Drawing.Point(283, 279)
        Me.PromPeq.Name = "PromPeq"
        Me.PromPeq.Size = New System.Drawing.Size(18, 20)
        Me.PromPeq.TabIndex = 19
        Me.PromPeq.Text = "0"
        '
        'promMedio
        '
        Me.promMedio.AutoSize = True
        Me.promMedio.BackColor = System.Drawing.Color.White
        Me.promMedio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.promMedio.ForeColor = System.Drawing.Color.Red
        Me.promMedio.Location = New System.Drawing.Point(283, 214)
        Me.promMedio.Name = "promMedio"
        Me.promMedio.Size = New System.Drawing.Size(18, 20)
        Me.promMedio.TabIndex = 18
        Me.promMedio.Text = "0"
        '
        'PromImport
        '
        Me.PromImport.AutoSize = True
        Me.PromImport.BackColor = System.Drawing.Color.White
        Me.PromImport.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PromImport.ForeColor = System.Drawing.Color.Red
        Me.PromImport.Location = New System.Drawing.Point(283, 164)
        Me.PromImport.Name = "PromImport"
        Me.PromImport.Size = New System.Drawing.Size(18, 20)
        Me.PromImport.TabIndex = 17
        Me.PromImport.Text = "0"
        '
        'PromGran
        '
        Me.PromGran.AutoSize = True
        Me.PromGran.BackColor = System.Drawing.Color.White
        Me.PromGran.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PromGran.ForeColor = System.Drawing.Color.Red
        Me.PromGran.Location = New System.Drawing.Point(283, 113)
        Me.PromGran.Name = "PromGran"
        Me.PromGran.Size = New System.Drawing.Size(18, 20)
        Me.PromGran.TabIndex = 16
        Me.PromGran.Text = "0"
        '
        'promPrefer
        '
        Me.promPrefer.AutoSize = True
        Me.promPrefer.BackColor = System.Drawing.Color.White
        Me.promPrefer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.promPrefer.ForeColor = System.Drawing.Color.Red
        Me.promPrefer.Location = New System.Drawing.Point(283, 60)
        Me.promPrefer.Name = "promPrefer"
        Me.promPrefer.Size = New System.Drawing.Size(18, 20)
        Me.promPrefer.TabIndex = 15
        Me.promPrefer.Text = "0"
        '
        'totPeq
        '
        Me.totPeq.AutoSize = True
        Me.totPeq.BackColor = System.Drawing.Color.White
        Me.totPeq.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totPeq.ForeColor = System.Drawing.Color.Red
        Me.totPeq.Location = New System.Drawing.Point(195, 279)
        Me.totPeq.Name = "totPeq"
        Me.totPeq.Size = New System.Drawing.Size(18, 20)
        Me.totPeq.TabIndex = 14
        Me.totPeq.Text = "0"
        '
        'totMedio
        '
        Me.totMedio.AutoSize = True
        Me.totMedio.BackColor = System.Drawing.Color.White
        Me.totMedio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totMedio.ForeColor = System.Drawing.Color.Red
        Me.totMedio.Location = New System.Drawing.Point(195, 213)
        Me.totMedio.Name = "totMedio"
        Me.totMedio.Size = New System.Drawing.Size(18, 20)
        Me.totMedio.TabIndex = 13
        Me.totMedio.Text = "0"
        '
        'totImport
        '
        Me.totImport.AutoSize = True
        Me.totImport.BackColor = System.Drawing.Color.White
        Me.totImport.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totImport.ForeColor = System.Drawing.Color.Red
        Me.totImport.Location = New System.Drawing.Point(195, 163)
        Me.totImport.Name = "totImport"
        Me.totImport.Size = New System.Drawing.Size(18, 20)
        Me.totImport.TabIndex = 12
        Me.totImport.Text = "0"
        '
        'totGrande
        '
        Me.totGrande.AutoSize = True
        Me.totGrande.BackColor = System.Drawing.Color.White
        Me.totGrande.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totGrande.ForeColor = System.Drawing.Color.Red
        Me.totGrande.Location = New System.Drawing.Point(195, 112)
        Me.totGrande.Name = "totGrande"
        Me.totGrande.Size = New System.Drawing.Size(18, 20)
        Me.totGrande.TabIndex = 11
        Me.totGrande.Text = "0"
        '
        'totPreferido
        '
        Me.totPreferido.AutoSize = True
        Me.totPreferido.BackColor = System.Drawing.Color.White
        Me.totPreferido.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totPreferido.ForeColor = System.Drawing.Color.Red
        Me.totPreferido.Location = New System.Drawing.Point(195, 60)
        Me.totPreferido.Name = "totPreferido"
        Me.totPreferido.Size = New System.Drawing.Size(18, 20)
        Me.totPreferido.TabIndex = 10
        Me.totPreferido.Text = "0"
        '
        'cantPeque
        '
        Me.cantPeque.AutoSize = True
        Me.cantPeque.BackColor = System.Drawing.Color.White
        Me.cantPeque.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cantPeque.ForeColor = System.Drawing.Color.Red
        Me.cantPeque.Location = New System.Drawing.Point(111, 279)
        Me.cantPeque.Name = "cantPeque"
        Me.cantPeque.Size = New System.Drawing.Size(18, 20)
        Me.cantPeque.TabIndex = 9
        Me.cantPeque.Text = "0"
        '
        'cantMedio
        '
        Me.cantMedio.AutoSize = True
        Me.cantMedio.BackColor = System.Drawing.Color.White
        Me.cantMedio.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cantMedio.ForeColor = System.Drawing.Color.Red
        Me.cantMedio.Location = New System.Drawing.Point(111, 214)
        Me.cantMedio.Name = "cantMedio"
        Me.cantMedio.Size = New System.Drawing.Size(18, 20)
        Me.cantMedio.TabIndex = 8
        Me.cantMedio.Text = "0"
        '
        'cantImport
        '
        Me.cantImport.AutoSize = True
        Me.cantImport.BackColor = System.Drawing.Color.White
        Me.cantImport.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cantImport.ForeColor = System.Drawing.Color.Red
        Me.cantImport.Location = New System.Drawing.Point(111, 164)
        Me.cantImport.Name = "cantImport"
        Me.cantImport.Size = New System.Drawing.Size(18, 20)
        Me.cantImport.TabIndex = 7
        Me.cantImport.Text = "0"
        '
        'cantGran
        '
        Me.cantGran.AutoSize = True
        Me.cantGran.BackColor = System.Drawing.Color.White
        Me.cantGran.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cantGran.ForeColor = System.Drawing.Color.Red
        Me.cantGran.Location = New System.Drawing.Point(111, 113)
        Me.cantGran.Name = "cantGran"
        Me.cantGran.Size = New System.Drawing.Size(18, 20)
        Me.cantGran.TabIndex = 6
        Me.cantGran.Text = "0"
        '
        'cantPreferencial
        '
        Me.cantPreferencial.AutoSize = True
        Me.cantPreferencial.BackColor = System.Drawing.Color.White
        Me.cantPreferencial.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cantPreferencial.ForeColor = System.Drawing.Color.Red
        Me.cantPreferencial.Location = New System.Drawing.Point(111, 60)
        Me.cantPreferencial.Name = "cantPreferencial"
        Me.cantPreferencial.Size = New System.Drawing.Size(18, 20)
        Me.cantPreferencial.TabIndex = 5
        Me.cantPreferencial.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Pequeño:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Mediano:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Importante:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Gran Cliente:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Preferencial:"
        '
        'categoria
        '
        Me.categoria.AutoSize = True
        Me.categoria.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.categoria.ForeColor = System.Drawing.Color.Red
        Me.categoria.Location = New System.Drawing.Point(253, 9)
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(0, 27)
        Me.categoria.TabIndex = 18
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(86, 424)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(68, 23)
        Me.btnAnterior.TabIndex = 19
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(12, 395)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(68, 23)
        Me.btnPrimero.TabIndex = 20
        Me.btnPrimero.Text = "Primero"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(86, 395)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(68, 23)
        Me.btnUltimo.TabIndex = 21
        Me.btnUltimo.Text = "Ultimo"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguete
        '
        Me.btnSiguete.Location = New System.Drawing.Point(12, 424)
        Me.btnSiguete.Name = "btnSiguete"
        Me.btnSiguete.Size = New System.Drawing.Size(68, 23)
        Me.btnSiguete.TabIndex = 22
        Me.btnSiguete.Text = "Siguente"
        Me.btnSiguete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSiguete)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.categoria)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDeuda)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbclientes)
        Me.Name = "Form1"
        Me.Text = "Registro de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbclientes As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdni As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDeuda As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cantPeque As Label
    Friend WithEvents cantMedio As Label
    Friend WithEvents cantImport As Label
    Friend WithEvents cantGran As Label
    Friend WithEvents cantPreferencial As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents categoria As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PromPeq As Label
    Friend WithEvents promMedio As Label
    Friend WithEvents PromImport As Label
    Friend WithEvents PromGran As Label
    Friend WithEvents promPrefer As Label
    Friend WithEvents totPeq As Label
    Friend WithEvents totMedio As Label
    Friend WithEvents totImport As Label
    Friend WithEvents totGrande As Label
    Friend WithEvents totPreferido As Label
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguete As Button
End Class
