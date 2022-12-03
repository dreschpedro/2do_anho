<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TypeReportSource1 As Telerik.Reporting.TypeReportSource = New Telerik.Reporting.TypeReportSource()
        Me.ReportViewer1 = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        TypeReportSource1.TypeName = "Prueba1.ReporteClientes, Prueba1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        Me.ReportViewer1.ReportSource = TypeReportSource1
        Me.ReportViewer1.EnableAccessibility = True
        Me.ReportViewer1.Size = New System.Drawing.Size(900, 700)
        Me.ReportViewer1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormReporteCliente"
        Me.Text = "Report Viewer Form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Telerik.ReportViewer.WinForms.ReportViewer

End Class
