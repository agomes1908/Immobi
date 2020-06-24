<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttImoveis
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mbtSair = New System.Windows.Forms.Button()
        Me.mbtExcluir = New MetroFramework.Controls.MetroButton()
        Me.mbtAtualizar = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pbBorderLeft1 = New System.Windows.Forms.Panel()
        Me.pbBorderbotom1 = New System.Windows.Forms.Panel()
        Me.pbBorderRight1 = New System.Windows.Forms.Panel()
        Me.pbBorderTop1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mtbValorLocacao = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mtbValorAgua = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.mtbValorNet = New MetroFramework.Controls.MetroTextBox()
        Me.mtbValorLuz = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.nudbanho = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.nudSuite = New System.Windows.Forms.NumericUpDown()
        Me.nudDorm = New System.Windows.Forms.NumericUpDown()
        Me.nudVagas = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbFinalidade = New System.Windows.Forms.ComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.mtbEstado = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.mtbCidade = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.mtbBairro = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.mtbLogradouro = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.mtbComplemento = New MetroFramework.Controls.MetroTextBox()
        Me.cbbTipo = New System.Windows.Forms.ComboBox()
        Me.mtbCep = New MetroFramework.Controls.MetroTextBox()
        Me.mtbNum = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudbanho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSuite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDorm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVagas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mbtSair
        '
        Me.mbtSair.FlatAppearance.BorderSize = 0
        Me.mbtSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mbtSair.Image = Global.immobi.My.Resources.Resources.close___1511_1
        Me.mbtSair.Location = New System.Drawing.Point(672, 14)
        Me.mbtSair.Name = "mbtSair"
        Me.mbtSair.Size = New System.Drawing.Size(38, 32)
        Me.mbtSair.TabIndex = 167
        Me.mbtSair.UseVisualStyleBackColor = True
        '
        'mbtExcluir
        '
        Me.mbtExcluir.Location = New System.Drawing.Point(348, 479)
        Me.mbtExcluir.Name = "mbtExcluir"
        Me.mbtExcluir.Size = New System.Drawing.Size(133, 30)
        Me.mbtExcluir.TabIndex = 166
        Me.mbtExcluir.Text = "Excluir"
        Me.mbtExcluir.UseSelectable = True
        '
        'mbtAtualizar
        '
        Me.mbtAtualizar.Location = New System.Drawing.Point(187, 479)
        Me.mbtAtualizar.Name = "mbtAtualizar"
        Me.mbtAtualizar.Size = New System.Drawing.Size(133, 30)
        Me.mbtAtualizar.TabIndex = 165
        Me.mbtAtualizar.Text = "Atualizar"
        Me.mbtAtualizar.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 35)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Cadastro de Imóveis"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(5, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 525)
        Me.Panel2.TabIndex = 163
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 536)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(707, 1)
        Me.Panel4.TabIndex = 162
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(712, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 526)
        Me.Panel1.TabIndex = 161
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(708, 6)
        Me.Panel3.TabIndex = 160
        '
        'pbBorderLeft1
        '
        Me.pbBorderLeft1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderLeft1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbBorderLeft1.Location = New System.Drawing.Point(0, 5)
        Me.pbBorderLeft1.Name = "pbBorderLeft1"
        Me.pbBorderLeft1.Size = New System.Drawing.Size(5, 532)
        Me.pbBorderLeft1.TabIndex = 159
        '
        'pbBorderbotom1
        '
        Me.pbBorderbotom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderbotom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbBorderbotom1.Location = New System.Drawing.Point(0, 537)
        Me.pbBorderbotom1.Name = "pbBorderbotom1"
        Me.pbBorderbotom1.Size = New System.Drawing.Size(713, 5)
        Me.pbBorderbotom1.TabIndex = 158
        '
        'pbBorderRight1
        '
        Me.pbBorderRight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderRight1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbBorderRight1.Location = New System.Drawing.Point(713, 5)
        Me.pbBorderRight1.Name = "pbBorderRight1"
        Me.pbBorderRight1.Size = New System.Drawing.Size(5, 537)
        Me.pbBorderRight1.TabIndex = 157
        '
        'pbBorderTop1
        '
        Me.pbBorderTop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbBorderTop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbBorderTop1.Location = New System.Drawing.Point(0, 0)
        Me.pbBorderTop1.Name = "pbBorderTop1"
        Me.pbBorderTop1.Size = New System.Drawing.Size(718, 5)
        Me.pbBorderTop1.TabIndex = 156
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.mtbValorLocacao)
        Me.GroupBox3.Controls.Add(Me.MetroLabel2)
        Me.GroupBox3.Controls.Add(Me.MetroLabel3)
        Me.GroupBox3.Controls.Add(Me.MetroLabel4)
        Me.GroupBox3.Controls.Add(Me.mtbValorAgua)
        Me.GroupBox3.Controls.Add(Me.MetroLabel5)
        Me.GroupBox3.Controls.Add(Me.mtbValorNet)
        Me.GroupBox3.Controls.Add(Me.mtbValorLuz)
        Me.GroupBox3.Location = New System.Drawing.Point(349, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(333, 256)
        Me.GroupBox3.TabIndex = 208
        Me.GroupBox3.TabStop = False
        '
        'mtbValorLocacao
        '
        '
        '
        '
        Me.mtbValorLocacao.CustomButton.Image = Nothing
        Me.mtbValorLocacao.CustomButton.Location = New System.Drawing.Point(85, 1)
        Me.mtbValorLocacao.CustomButton.Name = ""
        Me.mtbValorLocacao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbValorLocacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbValorLocacao.CustomButton.TabIndex = 1
        Me.mtbValorLocacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbValorLocacao.CustomButton.UseSelectable = True
        Me.mtbValorLocacao.CustomButton.Visible = False
        Me.mtbValorLocacao.Lines = New String(-1) {}
        Me.mtbValorLocacao.Location = New System.Drawing.Point(153, 43)
        Me.mtbValorLocacao.MaxLength = 32767
        Me.mtbValorLocacao.Name = "mtbValorLocacao"
        Me.mtbValorLocacao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbValorLocacao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbValorLocacao.SelectedText = ""
        Me.mtbValorLocacao.SelectionLength = 0
        Me.mtbValorLocacao.SelectionStart = 0
        Me.mtbValorLocacao.ShortcutsEnabled = True
        Me.mtbValorLocacao.Size = New System.Drawing.Size(107, 23)
        Me.mtbValorLocacao.TabIndex = 184
        Me.mtbValorLocacao.UseSelectable = True
        Me.mtbValorLocacao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbValorLocacao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(74, 190)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Valor Água"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(86, 97)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Valor Luz"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(86, 145)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Valor Net"
        '
        'mtbValorAgua
        '
        '
        '
        '
        Me.mtbValorAgua.CustomButton.Image = Nothing
        Me.mtbValorAgua.CustomButton.Location = New System.Drawing.Point(85, 1)
        Me.mtbValorAgua.CustomButton.Name = ""
        Me.mtbValorAgua.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbValorAgua.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbValorAgua.CustomButton.TabIndex = 1
        Me.mtbValorAgua.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbValorAgua.CustomButton.UseSelectable = True
        Me.mtbValorAgua.CustomButton.Visible = False
        Me.mtbValorAgua.Lines = New String(-1) {}
        Me.mtbValorAgua.Location = New System.Drawing.Point(153, 190)
        Me.mtbValorAgua.MaxLength = 32767
        Me.mtbValorAgua.Name = "mtbValorAgua"
        Me.mtbValorAgua.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbValorAgua.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbValorAgua.SelectedText = ""
        Me.mtbValorAgua.SelectionLength = 0
        Me.mtbValorAgua.SelectionStart = 0
        Me.mtbValorAgua.ShortcutsEnabled = True
        Me.mtbValorAgua.Size = New System.Drawing.Size(107, 23)
        Me.mtbValorAgua.TabIndex = 187
        Me.mtbValorAgua.UseSelectable = True
        Me.mtbValorAgua.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbValorAgua.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(57, 47)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Valor Locação"
        '
        'mtbValorNet
        '
        '
        '
        '
        Me.mtbValorNet.CustomButton.Image = Nothing
        Me.mtbValorNet.CustomButton.Location = New System.Drawing.Point(85, 1)
        Me.mtbValorNet.CustomButton.Name = ""
        Me.mtbValorNet.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbValorNet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbValorNet.CustomButton.TabIndex = 1
        Me.mtbValorNet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbValorNet.CustomButton.UseSelectable = True
        Me.mtbValorNet.CustomButton.Visible = False
        Me.mtbValorNet.Lines = New String(-1) {}
        Me.mtbValorNet.Location = New System.Drawing.Point(153, 142)
        Me.mtbValorNet.MaxLength = 32767
        Me.mtbValorNet.Name = "mtbValorNet"
        Me.mtbValorNet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbValorNet.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbValorNet.SelectedText = ""
        Me.mtbValorNet.SelectionLength = 0
        Me.mtbValorNet.SelectionStart = 0
        Me.mtbValorNet.ShortcutsEnabled = True
        Me.mtbValorNet.Size = New System.Drawing.Size(107, 23)
        Me.mtbValorNet.TabIndex = 186
        Me.mtbValorNet.UseSelectable = True
        Me.mtbValorNet.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbValorNet.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtbValorLuz
        '
        '
        '
        '
        Me.mtbValorLuz.CustomButton.Image = Nothing
        Me.mtbValorLuz.CustomButton.Location = New System.Drawing.Point(85, 1)
        Me.mtbValorLuz.CustomButton.Name = ""
        Me.mtbValorLuz.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbValorLuz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbValorLuz.CustomButton.TabIndex = 1
        Me.mtbValorLuz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbValorLuz.CustomButton.UseSelectable = True
        Me.mtbValorLuz.CustomButton.Visible = False
        Me.mtbValorLuz.Lines = New String(-1) {}
        Me.mtbValorLuz.Location = New System.Drawing.Point(153, 94)
        Me.mtbValorLuz.MaxLength = 32767
        Me.mtbValorLuz.Name = "mtbValorLuz"
        Me.mtbValorLuz.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbValorLuz.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbValorLuz.SelectedText = ""
        Me.mtbValorLuz.SelectionLength = 0
        Me.mtbValorLuz.SelectionStart = 0
        Me.mtbValorLuz.ShortcutsEnabled = True
        Me.mtbValorLuz.Size = New System.Drawing.Size(107, 23)
        Me.mtbValorLuz.TabIndex = 185
        Me.mtbValorLuz.UseSelectable = True
        Me.mtbValorLuz.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbValorLuz.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MetroLabel9)
        Me.GroupBox2.Controls.Add(Me.MetroLabel6)
        Me.GroupBox2.Controls.Add(Me.MetroLabel7)
        Me.GroupBox2.Controls.Add(Me.nudbanho)
        Me.GroupBox2.Controls.Add(Me.MetroLabel8)
        Me.GroupBox2.Controls.Add(Me.nudSuite)
        Me.GroupBox2.Controls.Add(Me.nudDorm)
        Me.GroupBox2.Controls.Add(Me.nudVagas)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 119)
        Me.GroupBox2.TabIndex = 207
        Me.GroupBox2.TabStop = False
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(40, 36)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel9.TabIndex = 10
        Me.MetroLabel9.Text = "Dormitórios"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(58, 64)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel6.TabIndex = 7
        Me.MetroLabel6.Text = "Banheiro"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(185, 64)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel7.TabIndex = 8
        Me.MetroLabel7.Text = "Vagas"
        '
        'nudbanho
        '
        Me.nudbanho.Location = New System.Drawing.Point(125, 63)
        Me.nudbanho.Name = "nudbanho"
        Me.nudbanho.Size = New System.Drawing.Size(37, 20)
        Me.nudbanho.TabIndex = 199
        Me.nudbanho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(185, 36)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel8.TabIndex = 9
        Me.MetroLabel8.Text = "Suítes"
        '
        'nudSuite
        '
        Me.nudSuite.Location = New System.Drawing.Point(233, 35)
        Me.nudSuite.Name = "nudSuite"
        Me.nudSuite.Size = New System.Drawing.Size(37, 20)
        Me.nudSuite.TabIndex = 200
        Me.nudSuite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudDorm
        '
        Me.nudDorm.Location = New System.Drawing.Point(125, 36)
        Me.nudDorm.Name = "nudDorm"
        Me.nudDorm.Size = New System.Drawing.Size(37, 20)
        Me.nudDorm.TabIndex = 198
        Me.nudDorm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudVagas
        '
        Me.nudVagas.Location = New System.Drawing.Point(233, 64)
        Me.nudVagas.Name = "nudVagas"
        Me.nudVagas.Size = New System.Drawing.Size(37, 20)
        Me.nudVagas.TabIndex = 201
        Me.nudVagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.cbbFinalidade)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel10)
        Me.GroupBox1.Controls.Add(Me.MetroLabel11)
        Me.GroupBox1.Controls.Add(Me.MetroLabel12)
        Me.GroupBox1.Controls.Add(Me.MetroLabel13)
        Me.GroupBox1.Controls.Add(Me.mtbEstado)
        Me.GroupBox1.Controls.Add(Me.MetroLabel14)
        Me.GroupBox1.Controls.Add(Me.mtbCidade)
        Me.GroupBox1.Controls.Add(Me.MetroLabel15)
        Me.GroupBox1.Controls.Add(Me.mtbBairro)
        Me.GroupBox1.Controls.Add(Me.MetroLabel16)
        Me.GroupBox1.Controls.Add(Me.mtbLogradouro)
        Me.GroupBox1.Controls.Add(Me.MetroLabel17)
        Me.GroupBox1.Controls.Add(Me.mtbComplemento)
        Me.GroupBox1.Controls.Add(Me.cbbTipo)
        Me.GroupBox1.Controls.Add(Me.mtbCep)
        Me.GroupBox1.Controls.Add(Me.mtbNum)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(35, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 391)
        Me.GroupBox1.TabIndex = 206
        Me.GroupBox1.TabStop = False
        '
        'cbbFinalidade
        '
        Me.cbbFinalidade.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbFinalidade.ForeColor = System.Drawing.Color.Black
        Me.cbbFinalidade.FormattingEnabled = True
        Me.cbbFinalidade.Items.AddRange(New Object() {"Comercial", "Residencial", "Rural"})
        Me.cbbFinalidade.Location = New System.Drawing.Point(9, 44)
        Me.cbbFinalidade.Name = "cbbFinalidade"
        Me.cbbFinalidade.Size = New System.Drawing.Size(261, 24)
        Me.cbbFinalidade.TabIndex = 180
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(9, 22)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Finalidade"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(173, 319)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel10.TabIndex = 11
        Me.MetroLabel10.Text = "Estado"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(9, 319)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel11.TabIndex = 12
        Me.MetroLabel11.Text = "Cidade"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(9, 271)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel12.TabIndex = 13
        Me.MetroLabel12.Text = "Bairro"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(9, 223)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel13.TabIndex = 14
        Me.MetroLabel13.Text = "Logradouro"
        '
        'mtbEstado
        '
        '
        '
        '
        Me.mtbEstado.CustomButton.Image = Nothing
        Me.mtbEstado.CustomButton.Location = New System.Drawing.Point(75, 1)
        Me.mtbEstado.CustomButton.Name = ""
        Me.mtbEstado.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbEstado.CustomButton.TabIndex = 1
        Me.mtbEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbEstado.CustomButton.UseSelectable = True
        Me.mtbEstado.CustomButton.Visible = False
        Me.mtbEstado.Lines = New String(-1) {}
        Me.mtbEstado.Location = New System.Drawing.Point(173, 341)
        Me.mtbEstado.MaxLength = 32767
        Me.mtbEstado.Name = "mtbEstado"
        Me.mtbEstado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbEstado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbEstado.SelectedText = ""
        Me.mtbEstado.SelectionLength = 0
        Me.mtbEstado.SelectionStart = 0
        Me.mtbEstado.ShortcutsEnabled = True
        Me.mtbEstado.Size = New System.Drawing.Size(97, 23)
        Me.mtbEstado.TabIndex = 196
        Me.mtbEstado.UseSelectable = True
        Me.mtbEstado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbEstado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(9, 173)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel14.TabIndex = 15
        Me.MetroLabel14.Text = "Complemento"
        '
        'mtbCidade
        '
        '
        '
        '
        Me.mtbCidade.CustomButton.Image = Nothing
        Me.mtbCidade.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.mtbCidade.CustomButton.Name = ""
        Me.mtbCidade.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbCidade.CustomButton.TabIndex = 1
        Me.mtbCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbCidade.CustomButton.UseSelectable = True
        Me.mtbCidade.CustomButton.Visible = False
        Me.mtbCidade.Lines = New String(-1) {}
        Me.mtbCidade.Location = New System.Drawing.Point(9, 341)
        Me.mtbCidade.MaxLength = 32767
        Me.mtbCidade.Name = "mtbCidade"
        Me.mtbCidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbCidade.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbCidade.SelectedText = ""
        Me.mtbCidade.SelectionLength = 0
        Me.mtbCidade.SelectionStart = 0
        Me.mtbCidade.ShortcutsEnabled = True
        Me.mtbCidade.Size = New System.Drawing.Size(145, 23)
        Me.mtbCidade.TabIndex = 195
        Me.mtbCidade.UseSelectable = True
        Me.mtbCidade.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbCidade.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(159, 123)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel15.TabIndex = 16
        Me.MetroLabel15.Text = "Número"
        '
        'mtbBairro
        '
        '
        '
        '
        Me.mtbBairro.CustomButton.Image = Nothing
        Me.mtbBairro.CustomButton.Location = New System.Drawing.Point(239, 1)
        Me.mtbBairro.CustomButton.Name = ""
        Me.mtbBairro.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbBairro.CustomButton.TabIndex = 1
        Me.mtbBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbBairro.CustomButton.UseSelectable = True
        Me.mtbBairro.CustomButton.Visible = False
        Me.mtbBairro.Lines = New String(-1) {}
        Me.mtbBairro.Location = New System.Drawing.Point(9, 293)
        Me.mtbBairro.MaxLength = 32767
        Me.mtbBairro.Name = "mtbBairro"
        Me.mtbBairro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbBairro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbBairro.SelectedText = ""
        Me.mtbBairro.SelectionLength = 0
        Me.mtbBairro.SelectionStart = 0
        Me.mtbBairro.ShortcutsEnabled = True
        Me.mtbBairro.Size = New System.Drawing.Size(261, 23)
        Me.mtbBairro.TabIndex = 194
        Me.mtbBairro.UseSelectable = True
        Me.mtbBairro.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbBairro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(9, 123)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel16.TabIndex = 17
        Me.MetroLabel16.Text = "Cep"
        '
        'mtbLogradouro
        '
        '
        '
        '
        Me.mtbLogradouro.CustomButton.Image = Nothing
        Me.mtbLogradouro.CustomButton.Location = New System.Drawing.Point(239, 1)
        Me.mtbLogradouro.CustomButton.Name = ""
        Me.mtbLogradouro.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbLogradouro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbLogradouro.CustomButton.TabIndex = 1
        Me.mtbLogradouro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbLogradouro.CustomButton.UseSelectable = True
        Me.mtbLogradouro.CustomButton.Visible = False
        Me.mtbLogradouro.Lines = New String(-1) {}
        Me.mtbLogradouro.Location = New System.Drawing.Point(9, 245)
        Me.mtbLogradouro.MaxLength = 32767
        Me.mtbLogradouro.Name = "mtbLogradouro"
        Me.mtbLogradouro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbLogradouro.SelectedText = ""
        Me.mtbLogradouro.SelectionLength = 0
        Me.mtbLogradouro.SelectionStart = 0
        Me.mtbLogradouro.ShortcutsEnabled = True
        Me.mtbLogradouro.Size = New System.Drawing.Size(261, 23)
        Me.mtbLogradouro.TabIndex = 193
        Me.mtbLogradouro.UseSelectable = True
        Me.mtbLogradouro.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbLogradouro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(9, 74)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel17.TabIndex = 18
        Me.MetroLabel17.Text = "Tipo"
        '
        'mtbComplemento
        '
        '
        '
        '
        Me.mtbComplemento.CustomButton.Image = Nothing
        Me.mtbComplemento.CustomButton.Location = New System.Drawing.Point(239, 1)
        Me.mtbComplemento.CustomButton.Name = ""
        Me.mtbComplemento.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbComplemento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbComplemento.CustomButton.TabIndex = 1
        Me.mtbComplemento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbComplemento.CustomButton.UseSelectable = True
        Me.mtbComplemento.CustomButton.Visible = False
        Me.mtbComplemento.Lines = New String(-1) {}
        Me.mtbComplemento.Location = New System.Drawing.Point(9, 195)
        Me.mtbComplemento.MaxLength = 32767
        Me.mtbComplemento.Name = "mtbComplemento"
        Me.mtbComplemento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbComplemento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbComplemento.SelectedText = ""
        Me.mtbComplemento.SelectionLength = 0
        Me.mtbComplemento.SelectionStart = 0
        Me.mtbComplemento.ShortcutsEnabled = True
        Me.mtbComplemento.Size = New System.Drawing.Size(261, 23)
        Me.mtbComplemento.TabIndex = 192
        Me.mtbComplemento.UseSelectable = True
        Me.mtbComplemento.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbComplemento.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbbTipo
        '
        Me.cbbTipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbTipo.ForeColor = System.Drawing.Color.Black
        Me.cbbTipo.FormattingEnabled = True
        Me.cbbTipo.Items.AddRange(New Object() {"Apartamento", "Casa", "Kitnet", "Casa", "Comercial", "Sala Comercial"})
        Me.cbbTipo.Location = New System.Drawing.Point(9, 96)
        Me.cbbTipo.Name = "cbbTipo"
        Me.cbbTipo.Size = New System.Drawing.Size(261, 24)
        Me.cbbTipo.TabIndex = 181
        '
        'mtbCep
        '
        '
        '
        '
        Me.mtbCep.CustomButton.Image = Nothing
        Me.mtbCep.CustomButton.Location = New System.Drawing.Point(88, 1)
        Me.mtbCep.CustomButton.Name = ""
        Me.mtbCep.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbCep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbCep.CustomButton.TabIndex = 1
        Me.mtbCep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbCep.CustomButton.UseSelectable = True
        Me.mtbCep.CustomButton.Visible = False
        Me.mtbCep.Lines = New String(-1) {}
        Me.mtbCep.Location = New System.Drawing.Point(9, 147)
        Me.mtbCep.MaxLength = 32767
        Me.mtbCep.Name = "mtbCep"
        Me.mtbCep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbCep.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbCep.SelectedText = ""
        Me.mtbCep.SelectionLength = 0
        Me.mtbCep.SelectionStart = 0
        Me.mtbCep.ShortcutsEnabled = True
        Me.mtbCep.Size = New System.Drawing.Size(110, 23)
        Me.mtbCep.TabIndex = 182
        Me.mtbCep.UseSelectable = True
        Me.mtbCep.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbCep.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtbNum
        '
        Me.mtbNum.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.mtbNum.CustomButton.Image = Nothing
        Me.mtbNum.CustomButton.Location = New System.Drawing.Point(89, 1)
        Me.mtbNum.CustomButton.Name = ""
        Me.mtbNum.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbNum.CustomButton.TabIndex = 1
        Me.mtbNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbNum.CustomButton.UseSelectable = True
        Me.mtbNum.CustomButton.Visible = False
        Me.mtbNum.Lines = New String(-1) {}
        Me.mtbNum.Location = New System.Drawing.Point(159, 147)
        Me.mtbNum.MaxLength = 32767
        Me.mtbNum.Name = "mtbNum"
        Me.mtbNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbNum.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbNum.SelectedText = ""
        Me.mtbNum.SelectionLength = 0
        Me.mtbNum.SelectionStart = 0
        Me.mtbNum.ShortcutsEnabled = True
        Me.mtbNum.Size = New System.Drawing.Size(111, 23)
        Me.mtbNum.TabIndex = 183
        Me.mtbNum.UseSelectable = True
        Me.mtbNum.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbNum.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'AttImoveis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(718, 542)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mbtSair)
        Me.Controls.Add(Me.mbtExcluir)
        Me.Controls.Add(Me.mbtAtualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pbBorderLeft1)
        Me.Controls.Add(Me.pbBorderbotom1)
        Me.Controls.Add(Me.pbBorderRight1)
        Me.Controls.Add(Me.pbBorderTop1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttImoveis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttImoveis"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudbanho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSuite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDorm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVagas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mbtSair As Button
    Friend WithEvents mbtExcluir As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtAtualizar As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbBorderLeft1 As Panel
    Friend WithEvents pbBorderbotom1 As Panel
    Friend WithEvents pbBorderRight1 As Panel
    Friend WithEvents pbBorderTop1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mtbValorLocacao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbValorAgua As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbValorNet As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtbValorLuz As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents nudbanho As NumericUpDown
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents nudSuite As NumericUpDown
    Friend WithEvents nudDorm As NumericUpDown
    Friend WithEvents nudVagas As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbbFinalidade As ComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbEstado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbCidade As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbBairro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbLogradouro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbComplemento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbbTipo As ComboBox
    Friend WithEvents mtbCep As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtbNum As MetroFramework.Controls.MetroTextBox
End Class
