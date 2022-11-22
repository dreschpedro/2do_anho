<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lviewSocios = New System.Windows.Forms.ListView()
        Me.colClave = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCategoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.SuspendLayout()
        '
        'lviewSocios
        '
        Me.lviewSocios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colClave, Me.colNombre, Me.colDireccion, Me.colTelefono, Me.colCategoria})
        Me.lviewSocios.Location = New System.Drawing.Point(0, 24)
        Me.lviewSocios.Name = "lviewSocios"
        Me.lviewSocios.Size = New System.Drawing.Size(513, 275)
        Me.lviewSocios.TabIndex = 0
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTADO DE SOCIOS"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 302)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lviewSocios)
        Me.Name = "Form3"
        Me.Text = "Form3"
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
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
