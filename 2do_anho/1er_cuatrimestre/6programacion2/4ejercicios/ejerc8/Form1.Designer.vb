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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gpb_primeros = New System.Windows.Forms.GroupBox()
        Me.p_sopa = New System.Windows.Forms.RadioButton()
        Me.p_ensalada = New System.Windows.Forms.RadioButton()
        Me.p_papa = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gpb_segundos = New System.Windows.Forms.GroupBox()
        Me.s_pastel = New System.Windows.Forms.RadioButton()
        Me.s_fideo = New System.Windows.Forms.RadioButton()
        Me.s_poroto = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gpb_postres = New System.Windows.Forms.GroupBox()
        Me.t_helado = New System.Windows.Forms.RadioButton()
        Me.t_flan = New System.Windows.Forms.RadioButton()
        Me.t_choco = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gpb_bebidas = New System.Windows.Forms.GroupBox()
        Me.c_coca = New System.Windows.Forms.RadioButton()
        Me.c_cafe = New System.Windows.Forms.RadioButton()
        Me.c_agua = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl_importe = New System.Windows.Forms.Label()
        Me.btn_cobrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_entrega = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_devolver = New System.Windows.Forms.Label()
        Me.gpb_primeros.SuspendLayout()
        Me.gpb_segundos.SuspendLayout()
        Me.gpb_postres.SuspendLayout()
        Me.gpb_bebidas.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpb_primeros
        '
        Me.gpb_primeros.Controls.Add(Me.p_sopa)
        Me.gpb_primeros.Controls.Add(Me.p_ensalada)
        Me.gpb_primeros.Controls.Add(Me.p_papa)
        Me.gpb_primeros.Controls.Add(Me.Label6)
        Me.gpb_primeros.Controls.Add(Me.Label5)
        Me.gpb_primeros.Controls.Add(Me.Label4)
        Me.gpb_primeros.Location = New System.Drawing.Point(36, 16)
        Me.gpb_primeros.Name = "gpb_primeros"
        Me.gpb_primeros.Size = New System.Drawing.Size(345, 115)
        Me.gpb_primeros.TabIndex = 0
        Me.gpb_primeros.TabStop = False
        Me.gpb_primeros.Text = "Primeros"
        '
        'p_sopa
        '
        Me.p_sopa.Appearance = System.Windows.Forms.Appearance.Button
        Me.p_sopa.BackgroundImage = CType(resources.GetObject("p_sopa.BackgroundImage"), System.Drawing.Image)
        Me.p_sopa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.p_sopa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_sopa.ForeColor = System.Drawing.Color.White
        Me.p_sopa.Location = New System.Drawing.Point(227, 28)
        Me.p_sopa.Name = "p_sopa"
        Me.p_sopa.Size = New System.Drawing.Size(98, 80)
        Me.p_sopa.TabIndex = 13
        Me.p_sopa.TabStop = True
        Me.p_sopa.Text = "3"
        Me.p_sopa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.p_sopa.UseVisualStyleBackColor = True
        '
        'p_ensalada
        '
        Me.p_ensalada.Appearance = System.Windows.Forms.Appearance.Button
        Me.p_ensalada.BackgroundImage = CType(resources.GetObject("p_ensalada.BackgroundImage"), System.Drawing.Image)
        Me.p_ensalada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.p_ensalada.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_ensalada.ForeColor = System.Drawing.Color.White
        Me.p_ensalada.Location = New System.Drawing.Point(123, 29)
        Me.p_ensalada.Name = "p_ensalada"
        Me.p_ensalada.Size = New System.Drawing.Size(98, 80)
        Me.p_ensalada.TabIndex = 12
        Me.p_ensalada.TabStop = True
        Me.p_ensalada.Text = "2.5"
        Me.p_ensalada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.p_ensalada.UseVisualStyleBackColor = True
        '
        'p_papa
        '
        Me.p_papa.Appearance = System.Windows.Forms.Appearance.Button
        Me.p_papa.BackgroundImage = CType(resources.GetObject("p_papa.BackgroundImage"), System.Drawing.Image)
        Me.p_papa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.p_papa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_papa.ForeColor = System.Drawing.Color.White
        Me.p_papa.Location = New System.Drawing.Point(19, 28)
        Me.p_papa.Name = "p_papa"
        Me.p_papa.Size = New System.Drawing.Size(98, 80)
        Me.p_papa.TabIndex = 11
        Me.p_papa.TabStop = True
        Me.p_papa.Text = "5"
        Me.p_papa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.p_papa.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Sopa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ensalada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Papa frita"
        '
        'gpb_segundos
        '
        Me.gpb_segundos.Controls.Add(Me.s_pastel)
        Me.gpb_segundos.Controls.Add(Me.s_fideo)
        Me.gpb_segundos.Controls.Add(Me.s_poroto)
        Me.gpb_segundos.Controls.Add(Me.Label9)
        Me.gpb_segundos.Controls.Add(Me.Label8)
        Me.gpb_segundos.Controls.Add(Me.Label7)
        Me.gpb_segundos.Location = New System.Drawing.Point(36, 150)
        Me.gpb_segundos.Name = "gpb_segundos"
        Me.gpb_segundos.Size = New System.Drawing.Size(345, 115)
        Me.gpb_segundos.TabIndex = 1
        Me.gpb_segundos.TabStop = False
        Me.gpb_segundos.Text = "Segundos"
        '
        's_pastel
        '
        Me.s_pastel.Appearance = System.Windows.Forms.Appearance.Button
        Me.s_pastel.BackgroundImage = CType(resources.GetObject("s_pastel.BackgroundImage"), System.Drawing.Image)
        Me.s_pastel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.s_pastel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_pastel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.s_pastel.Location = New System.Drawing.Point(227, 29)
        Me.s_pastel.Name = "s_pastel"
        Me.s_pastel.Size = New System.Drawing.Size(98, 80)
        Me.s_pastel.TabIndex = 16
        Me.s_pastel.TabStop = True
        Me.s_pastel.Text = "1"
        Me.s_pastel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s_pastel.UseVisualStyleBackColor = True
        '
        's_fideo
        '
        Me.s_fideo.Appearance = System.Windows.Forms.Appearance.Button
        Me.s_fideo.BackgroundImage = CType(resources.GetObject("s_fideo.BackgroundImage"), System.Drawing.Image)
        Me.s_fideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.s_fideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_fideo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.s_fideo.Location = New System.Drawing.Point(123, 30)
        Me.s_fideo.Name = "s_fideo"
        Me.s_fideo.Size = New System.Drawing.Size(98, 80)
        Me.s_fideo.TabIndex = 15
        Me.s_fideo.TabStop = True
        Me.s_fideo.Text = "7"
        Me.s_fideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s_fideo.UseVisualStyleBackColor = True
        '
        's_poroto
        '
        Me.s_poroto.Appearance = System.Windows.Forms.Appearance.Button
        Me.s_poroto.BackgroundImage = CType(resources.GetObject("s_poroto.BackgroundImage"), System.Drawing.Image)
        Me.s_poroto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.s_poroto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_poroto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.s_poroto.Location = New System.Drawing.Point(19, 29)
        Me.s_poroto.Name = "s_poroto"
        Me.s_poroto.Size = New System.Drawing.Size(98, 80)
        Me.s_poroto.TabIndex = 14
        Me.s_poroto.TabStop = True
        Me.s_poroto.Text = "10"
        Me.s_poroto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.s_poroto.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(247, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Pastel papa"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(158, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fideos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Poroto"
        '
        'gpb_postres
        '
        Me.gpb_postres.Controls.Add(Me.t_helado)
        Me.gpb_postres.Controls.Add(Me.t_flan)
        Me.gpb_postres.Controls.Add(Me.t_choco)
        Me.gpb_postres.Controls.Add(Me.Label12)
        Me.gpb_postres.Controls.Add(Me.Label11)
        Me.gpb_postres.Controls.Add(Me.Label10)
        Me.gpb_postres.Location = New System.Drawing.Point(36, 284)
        Me.gpb_postres.Name = "gpb_postres"
        Me.gpb_postres.Size = New System.Drawing.Size(345, 115)
        Me.gpb_postres.TabIndex = 2
        Me.gpb_postres.TabStop = False
        Me.gpb_postres.Text = "Postres"
        '
        't_helado
        '
        Me.t_helado.Appearance = System.Windows.Forms.Appearance.Button
        Me.t_helado.BackgroundImage = CType(resources.GetObject("t_helado.BackgroundImage"), System.Drawing.Image)
        Me.t_helado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.t_helado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_helado.ForeColor = System.Drawing.Color.Cyan
        Me.t_helado.Location = New System.Drawing.Point(227, 27)
        Me.t_helado.Name = "t_helado"
        Me.t_helado.Size = New System.Drawing.Size(98, 80)
        Me.t_helado.TabIndex = 16
        Me.t_helado.TabStop = True
        Me.t_helado.Text = "10.3"
        Me.t_helado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t_helado.UseVisualStyleBackColor = True
        '
        't_flan
        '
        Me.t_flan.Appearance = System.Windows.Forms.Appearance.Button
        Me.t_flan.BackgroundImage = CType(resources.GetObject("t_flan.BackgroundImage"), System.Drawing.Image)
        Me.t_flan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.t_flan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_flan.ForeColor = System.Drawing.Color.Cyan
        Me.t_flan.Location = New System.Drawing.Point(123, 28)
        Me.t_flan.Name = "t_flan"
        Me.t_flan.Size = New System.Drawing.Size(98, 80)
        Me.t_flan.TabIndex = 15
        Me.t_flan.TabStop = True
        Me.t_flan.Text = "13.5"
        Me.t_flan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t_flan.UseVisualStyleBackColor = True
        '
        't_choco
        '
        Me.t_choco.Appearance = System.Windows.Forms.Appearance.Button
        Me.t_choco.BackgroundImage = CType(resources.GetObject("t_choco.BackgroundImage"), System.Drawing.Image)
        Me.t_choco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.t_choco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_choco.ForeColor = System.Drawing.Color.Cyan
        Me.t_choco.Location = New System.Drawing.Point(19, 27)
        Me.t_choco.Name = "t_choco"
        Me.t_choco.Size = New System.Drawing.Size(98, 80)
        Me.t_choco.TabIndex = 14
        Me.t_choco.TabStop = True
        Me.t_choco.Text = "15"
        Me.t_choco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.t_choco.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(260, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Helado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(157, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Flan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Chocolate"
        '
        'gpb_bebidas
        '
        Me.gpb_bebidas.Controls.Add(Me.c_coca)
        Me.gpb_bebidas.Controls.Add(Me.c_cafe)
        Me.gpb_bebidas.Controls.Add(Me.c_agua)
        Me.gpb_bebidas.Controls.Add(Me.Label15)
        Me.gpb_bebidas.Controls.Add(Me.Label14)
        Me.gpb_bebidas.Controls.Add(Me.Label13)
        Me.gpb_bebidas.Location = New System.Drawing.Point(36, 423)
        Me.gpb_bebidas.Name = "gpb_bebidas"
        Me.gpb_bebidas.Size = New System.Drawing.Size(345, 115)
        Me.gpb_bebidas.TabIndex = 3
        Me.gpb_bebidas.TabStop = False
        Me.gpb_bebidas.Text = "Bebidas"
        '
        'c_coca
        '
        Me.c_coca.Appearance = System.Windows.Forms.Appearance.Button
        Me.c_coca.BackgroundImage = CType(resources.GetObject("c_coca.BackgroundImage"), System.Drawing.Image)
        Me.c_coca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c_coca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_coca.ForeColor = System.Drawing.Color.Cyan
        Me.c_coca.Location = New System.Drawing.Point(227, 26)
        Me.c_coca.Name = "c_coca"
        Me.c_coca.Size = New System.Drawing.Size(98, 80)
        Me.c_coca.TabIndex = 16
        Me.c_coca.TabStop = True
        Me.c_coca.Text = "6"
        Me.c_coca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c_coca.UseVisualStyleBackColor = True
        '
        'c_cafe
        '
        Me.c_cafe.Appearance = System.Windows.Forms.Appearance.Button
        Me.c_cafe.BackgroundImage = CType(resources.GetObject("c_cafe.BackgroundImage"), System.Drawing.Image)
        Me.c_cafe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c_cafe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_cafe.ForeColor = System.Drawing.Color.Cyan
        Me.c_cafe.Location = New System.Drawing.Point(123, 27)
        Me.c_cafe.Name = "c_cafe"
        Me.c_cafe.Size = New System.Drawing.Size(98, 80)
        Me.c_cafe.TabIndex = 15
        Me.c_cafe.TabStop = True
        Me.c_cafe.Text = "2.5"
        Me.c_cafe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c_cafe.UseVisualStyleBackColor = True
        '
        'c_agua
        '
        Me.c_agua.Appearance = System.Windows.Forms.Appearance.Button
        Me.c_agua.BackgroundImage = CType(resources.GetObject("c_agua.BackgroundImage"), System.Drawing.Image)
        Me.c_agua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.c_agua.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_agua.ForeColor = System.Drawing.Color.Red
        Me.c_agua.Location = New System.Drawing.Point(19, 26)
        Me.c_agua.Name = "c_agua"
        Me.c_agua.Size = New System.Drawing.Size(98, 80)
        Me.c_agua.TabIndex = 14
        Me.c_agua.TabStop = True
        Me.c_agua.Text = "4"
        Me.c_agua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c_agua.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(261, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Coca"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(161, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Café"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(46, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Agua"
        '
        'lbl_importe
        '
        Me.lbl_importe.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_importe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_importe.Location = New System.Drawing.Point(466, 120)
        Me.lbl_importe.Name = "lbl_importe"
        Me.lbl_importe.Size = New System.Drawing.Size(192, 74)
        Me.lbl_importe.TabIndex = 4
        Me.lbl_importe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_cobrar
        '
        Me.btn_cobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_cobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cobrar.ForeColor = System.Drawing.Color.Blue
        Me.btn_cobrar.Location = New System.Drawing.Point(480, 336)
        Me.btn_cobrar.Name = "btn_cobrar"
        Me.btn_cobrar.Size = New System.Drawing.Size(155, 38)
        Me.btn_cobrar.TabIndex = 5
        Me.btn_cobrar.Text = "Cobrar"
        Me.btn_cobrar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(518, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Entrega"
        '
        'txt_entrega
        '
        Me.txt_entrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_entrega.Location = New System.Drawing.Point(480, 284)
        Me.txt_entrega.Multiline = True
        Me.txt_entrega.Name = "txt_entrega"
        Me.txt_entrega.Size = New System.Drawing.Size(155, 28)
        Me.txt_entrega.TabIndex = 7
        Me.txt_entrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(519, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Devolver"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(508, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 18)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Importe Total"
        '
        'lbl_devolver
        '
        Me.lbl_devolver.BackColor = System.Drawing.Color.Yellow
        Me.lbl_devolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_devolver.Location = New System.Drawing.Point(467, 453)
        Me.lbl_devolver.Name = "lbl_devolver"
        Me.lbl_devolver.Size = New System.Drawing.Size(188, 57)
        Me.lbl_devolver.TabIndex = 10
        Me.lbl_devolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 604)
        Me.Controls.Add(Me.lbl_devolver)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_entrega)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cobrar)
        Me.Controls.Add(Me.lbl_importe)
        Me.Controls.Add(Me.gpb_bebidas)
        Me.Controls.Add(Me.gpb_postres)
        Me.Controls.Add(Me.gpb_segundos)
        Me.Controls.Add(Me.gpb_primeros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gpb_primeros.ResumeLayout(False)
        Me.gpb_primeros.PerformLayout()
        Me.gpb_segundos.ResumeLayout(False)
        Me.gpb_segundos.PerformLayout()
        Me.gpb_postres.ResumeLayout(False)
        Me.gpb_postres.PerformLayout()
        Me.gpb_bebidas.ResumeLayout(False)
        Me.gpb_bebidas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpb_primeros As System.Windows.Forms.GroupBox
    Friend WithEvents gpb_segundos As System.Windows.Forms.GroupBox
    Friend WithEvents gpb_postres As System.Windows.Forms.GroupBox
    Friend WithEvents gpb_bebidas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_importe As System.Windows.Forms.Label
    Friend WithEvents btn_cobrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_entrega As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_devolver As System.Windows.Forms.Label
    Friend WithEvents p_papa As System.Windows.Forms.RadioButton
    Friend WithEvents p_sopa As System.Windows.Forms.RadioButton
    Friend WithEvents p_ensalada As System.Windows.Forms.RadioButton
    Friend WithEvents s_pastel As System.Windows.Forms.RadioButton
    Friend WithEvents s_fideo As System.Windows.Forms.RadioButton
    Friend WithEvents s_poroto As System.Windows.Forms.RadioButton
    Friend WithEvents t_helado As System.Windows.Forms.RadioButton
    Friend WithEvents t_flan As System.Windows.Forms.RadioButton
    Friend WithEvents t_choco As System.Windows.Forms.RadioButton
    Friend WithEvents c_coca As System.Windows.Forms.RadioButton
    Friend WithEvents c_cafe As System.Windows.Forms.RadioButton
    Friend WithEvents c_agua As System.Windows.Forms.RadioButton

End Class
