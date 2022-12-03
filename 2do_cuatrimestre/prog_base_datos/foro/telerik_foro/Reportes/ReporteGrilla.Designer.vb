<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteGrilla
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
        Me.rptSocios = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rptSocios
        '
        Me.rptSocios.AccessibilityKeyMap = Nothing
        Me.rptSocios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptSocios.Location = New System.Drawing.Point(0, 0)
        Me.rptSocios.Name = "rptSocios"
        Me.rptSocios.Size = New System.Drawing.Size(800, 450)
        Me.rptSocios.TabIndex = 0
        '
        'ReporteGrilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rptSocios)
        Me.Name = "ReporteGrilla"
        Me.Text = "ReporteGrilla"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rptSocios As Telerik.ReportViewer.WinForms.ReportViewer
End Class
