Partial Class ReporteClientes

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector1 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim DescendantSelector2 As Telerik.Reporting.Drawing.DescendantSelector = New Telerik.Reporting.Drawing.DescendantSelector()
        Me.DetailSection1 = New Telerik.Reporting.DetailSection()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.PageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.PageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'DetailSection1
        '
        Me.DetailSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.5R)
        Me.DetailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.DetailSection1.Name = "DetailSection1"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Prueba1.My.MySettings.neptuno2"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        'Me.SqlDataSource1.SelectCommand = "select * from clientes where ciudad='Londres';"
        Me.SqlDataSource1.SelectCommand = CadenaReporte
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.0R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.0R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.0R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.0R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.0R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.5R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox6)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox7)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox8)
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox9)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox10)
        TableGroup1.Name = "idcliente"
        TableGroup1.ReportItem = Me.TextBox1
        TableGroup2.Name = "nombrecontacto"
        TableGroup2.ReportItem = Me.TextBox2
        TableGroup3.Name = "cargocontacto"
        TableGroup3.ReportItem = Me.TextBox3
        TableGroup4.Name = "ciudad"
        TableGroup4.ReportItem = Me.TextBox4
        TableGroup5.Name = "fax"
        TableGroup5.ReportItem = Me.TextBox5
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.ColumnGroups.Add(TableGroup4)
        Me.Table1.ColumnGroups.Add(TableGroup5)
        Me.Table1.DataSource = Me.SqlDataSource1
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.Table1.Name = "Table1"
        TableGroup6.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup6.Name = "detail"
        Me.Table1.RowGroups.Add(TableGroup6)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.0R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.Table1.StyleName = "Solstice.TableNormal"
        '
        'TextBox1
        '
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox1.StyleName = "Solstice.TableHeader"
        Me.TextBox1.Value = "idcliente"
        '
        'TextBox2
        '
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox2.StyleName = "Solstice.TableHeader"
        Me.TextBox2.Value = "nombrecontacto"
        '
        'TextBox3
        '
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox3.StyleName = "Solstice.TableHeader"
        Me.TextBox3.Value = "cargocontacto"
        '
        'TextBox4
        '
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox4.StyleName = "Solstice.TableHeader"
        Me.TextBox4.Value = "ciudad"
        '
        'TextBox5
        '
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox5.StyleName = "Solstice.TableHeader"
        Me.TextBox5.Value = "fax"
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox6.StyleName = "Solstice.TableBody"
        Me.TextBox6.Value = "= Fields.idcliente"
        '
        'TextBox7
        '
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox7.StyleName = "Solstice.TableBody"
        Me.TextBox7.Value = "= Fields.nombrecontacto"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox8.StyleName = "Solstice.TableBody"
        Me.TextBox8.Value = "= Fields.cargocontacto"
        '
        'TextBox9
        '
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox9.StyleName = "Solstice.TableBody"
        Me.TextBox9.Value = "= Fields.ciudad"
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox10.StyleName = "Solstice.TableBody"
        Me.TextBox10.Value = "= Fields.fax"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "ReportNameTextBox"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.0R), Telerik.Reporting.Drawing.Unit.Cm(2.0R))
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Segoe UI"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox11.Value = "Listado de Clientes"
        '
        'PageHeaderSection1
        '
        Me.PageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.5R)
        Me.PageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox11})
        Me.PageHeaderSection1.Name = "PageHeaderSection1"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.0R), Telerik.Reporting.Drawing.Unit.Cm(1.5R))
        Me.TextBox12.Name = "ReportPageNumberTextBox"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox12.Style.Font.Name = "Segoe UI"
        Me.TextBox12.Value = "Page: {PageNumber}"
        '
        'PageFooterSection1
        '
        Me.PageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.5R)
        Me.PageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox12})
        Me.PageFooterSection1.Name = "PageFooterSection1"
        '
        'ReporteClientes
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.DetailSection1, Me.PageHeaderSection1, Me.PageFooterSection1})
        Me.Name = "ReporteClientes"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.Table), "Solstice.TableNormal")})
        StyleRule2.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(20, Byte), Integer))
        StyleRule2.Style.Font.Name = "Gill Sans MT"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Solstice.TableBody")})
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector1})
        StyleRule3.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(20, Byte), Integer))
        StyleRule3.Style.Font.Name = "Gill Sans MT"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        DescendantSelector2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.Table)), New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.ReportItem), "Solstice.TableHeader")})
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {DescendantSelector2})
        StyleRule4.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(28, Byte), Integer))
        StyleRule4.Style.BorderColor.Default = System.Drawing.Color.Black
        StyleRule4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        StyleRule4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Pixel(1.0R)
        StyleRule4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(201, Byte), Integer))
        StyleRule4.Style.Font.Name = "Gill Sans MT"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(17.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents DetailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents PageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents PageFooterSection1 As Telerik.Reporting.PageFooterSection
End Class