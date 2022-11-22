<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.lviewSocios = New System.Windows.Forms.ListView
        Me.colClave = New System.Windows.Forms.ColumnHeader
        Me.colNombre = New System.Windows.Forms.ColumnHeader
        Me.colDireccion = New System.Windows.Forms.ColumnHeader
        Me.colTelefono = New System.Windows.Forms.ColumnHeader
        Me.colCategoria = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtClaveSocio = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCategoria = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lviewSocios
        '
        Me.lviewSocios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colClave, Me.colNombre, Me.colDireccion, Me.colTelefono, Me.colCategoria})
        Me.lviewSocios.FullRowSelect = True
        Me.lviewSocios.Location = New System.Drawing.Point(12, 12)
        Me.lviewSocios.Name = "lviewSocios"
        Me.lviewSocios.Size = New System.Drawing.Size(513, 275)
        Me.lviewSocios.TabIndex = 1
        Me.lviewSocios.UseCompatibleStateImageBehavior = False
        Me.lviewSocios.View = System.Windows.Forms.View.Details
        '
        'colClave
        '
        Me.colClave.Text = "Clave"
        Me.colClave.Width = 55
        '
        'colNombre
        '
        Me.colNombre.Text = "Nombre y Apellido"
        Me.colNombre.Width = 150
        '
        'colDireccion
        '
        Me.colDireccion.Text = "Direccion"
        Me.colDireccion.Width = 120
        '
        'colTelefono
        '
        Me.colTelefono.Text = "Telefono"
        Me.colTelefono.Width = 100
        '
        'colCategoria
        '
        Me.colCategoria.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Clave"
        '
        'txtClaveSocio
        '
        Me.txtClaveSocio.Location = New System.Drawing.Point(165, 303)
        Me.txtClaveSocio.Name = "txtClaveSocio"
        Me.txtClaveSocio.Size = New System.Drawing.Size(186, 20)
        Me.txtClaveSocio.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(102, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(165, 381)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(186, 20)
        Me.txtTelefono.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Categoria"
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(165, 407)
        Me.txtCategoria.MaxLength = 1
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(186, 20)
        Me.txtCategoria.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Direccion"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(165, 355)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(186, 20)
        Me.txtDireccion.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(102, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(165, 329)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(186, 20)
        Me.txtNombre.TabIndex = 30
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 460)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtClaveSocio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lviewSocios)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lviewSocios As System.Windows.Forms.ListView
    Friend WithEvents colClave As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDireccion As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTelefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCategoria As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtClaveSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
End Class
