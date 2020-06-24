<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttContratos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pbBorderLeft1 = New System.Windows.Forms.Panel()
        Me.pbBorderRight1 = New System.Windows.Forms.Panel()
        Me.pbBorderTop1 = New System.Windows.Forms.Panel()
        Me.pbBorderbotom1 = New System.Windows.Forms.Panel()
        Me.gbDetalhesContrato = New System.Windows.Forms.GroupBox()
        Me.mlbValorTotalContrato = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel35 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel34 = New MetroFramework.Controls.MetroLabel()
        Me.mcbAgua = New MetroFramework.Controls.MetroCheckBox()
        Me.mtbDesconto = New MetroFramework.Controls.MetroTextBox()
        Me.mcbLuz = New MetroFramework.Controls.MetroCheckBox()
        Me.mcbInternet = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel33 = New MetroFramework.Controls.MetroLabel()
        Me.numMesesContrato = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel32 = New MetroFramework.Controls.MetroLabel()
        Me.cbbDiaVencimento = New System.Windows.Forms.ComboBox()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.mdt1Pagamento = New MetroFramework.Controls.MetroDateTime()
        Me.mdtDataInicial = New MetroFramework.Controls.MetroDateTime()
        Me.gbinquilino = New System.Windows.Forms.GroupBox()
        Me.btNovaCategoria = New System.Windows.Forms.Button()
        Me.cbbInquilinos = New System.Windows.Forms.ComboBox()
        Me.gbImoveis = New System.Windows.Forms.GroupBox()
        Me.mlbCodigoImovel = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel37 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.mtbValorLocacaoC = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel28 = New MetroFramework.Controls.MetroLabel()
        Me.mtbValorAguaC = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel27 = New MetroFramework.Controls.MetroLabel()
        Me.mtbValorLuzC = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.mtbValorNetC = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.mtbTipo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.mtbFinalidade = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.mtbComplementoC = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.mtbEndereco = New MetroFramework.Controls.MetroTextBox()
        Me.mbtSelecionaImovel = New MetroFramework.Controls.MetroButton()
        Me.mbtEditarContrato = New MetroFramework.Controls.MetroButton()
        Me.mbtrenovarCotnrato = New MetroFramework.Controls.MetroButton()
        Me.mbtExcluirContrato = New MetroFramework.Controls.MetroButton()
        Me.mbtFinalizarContrato = New MetroFramework.Controls.MetroButton()
        Me.gbDetalhesContrato.SuspendLayout()
        CType(Me.numMesesContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbinquilino.SuspendLayout()
        Me.gbImoveis.SuspendLayout()
        Me.SuspendLayout()
        '
        'mbtSair
        '
        Me.mbtSair.FlatAppearance.BorderSize = 0
        Me.mbtSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mbtSair.Image = Global.immobi.My.Resources.Resources.close___1511_1
        Me.mbtSair.Location = New System.Drawing.Point(744, 17)
        Me.mbtSair.Name = "mbtSair"
        Me.mbtSair.Size = New System.Drawing.Size(38, 32)
        Me.mbtSair.TabIndex = 220
        Me.mbtSair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 35)
        Me.Label1.TabIndex = 217
        Me.Label1.Text = "Editar Contrato"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(5, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 597)
        Me.Panel2.TabIndex = 216
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 608)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(783, 1)
        Me.Panel4.TabIndex = 215
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(788, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 598)
        Me.Panel1.TabIndex = 214
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 6)
        Me.Panel3.TabIndex = 213
        '
        'pbBorderLeft1
        '
        Me.pbBorderLeft1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderLeft1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbBorderLeft1.Location = New System.Drawing.Point(0, 5)
        Me.pbBorderLeft1.Name = "pbBorderLeft1"
        Me.pbBorderLeft1.Size = New System.Drawing.Size(5, 604)
        Me.pbBorderLeft1.TabIndex = 212
        '
        'pbBorderRight1
        '
        Me.pbBorderRight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderRight1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbBorderRight1.Location = New System.Drawing.Point(789, 5)
        Me.pbBorderRight1.Name = "pbBorderRight1"
        Me.pbBorderRight1.Size = New System.Drawing.Size(5, 604)
        Me.pbBorderRight1.TabIndex = 210
        '
        'pbBorderTop1
        '
        Me.pbBorderTop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbBorderTop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbBorderTop1.Location = New System.Drawing.Point(0, 0)
        Me.pbBorderTop1.Name = "pbBorderTop1"
        Me.pbBorderTop1.Size = New System.Drawing.Size(794, 5)
        Me.pbBorderTop1.TabIndex = 209
        '
        'pbBorderbotom1
        '
        Me.pbBorderbotom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderbotom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbBorderbotom1.Location = New System.Drawing.Point(0, 609)
        Me.pbBorderbotom1.Name = "pbBorderbotom1"
        Me.pbBorderbotom1.Size = New System.Drawing.Size(794, 5)
        Me.pbBorderbotom1.TabIndex = 211
        '
        'gbDetalhesContrato
        '
        Me.gbDetalhesContrato.BackColor = System.Drawing.Color.White
        Me.gbDetalhesContrato.Controls.Add(Me.mlbValorTotalContrato)
        Me.gbDetalhesContrato.Controls.Add(Me.MetroLabel35)
        Me.gbDetalhesContrato.Controls.Add(Me.MetroLabel34)
        Me.gbDetalhesContrato.Controls.Add(Me.mcbAgua)
        Me.gbDetalhesContrato.Controls.Add(Me.mtbDesconto)
        Me.gbDetalhesContrato.Controls.Add(Me.mcbLuz)
        Me.gbDetalhesContrato.Controls.Add(Me.mcbInternet)
        Me.gbDetalhesContrato.Controls.Add(Me.MetroLabel33)
        Me.gbDetalhesContrato.Controls.Add(Me.numMesesContrato)
        Me.gbDetalhesContrato.Controls.Add(Me.MetroLabel32)
        Me.gbDetalhesContrato.Controls.Add(Me.cbbDiaVencimento)
        Me.gbDetalhesContrato.Controls.Add(Me.MetroLabel31)
        Me.gbDetalhesContrato.Controls.Add(Me.MetroLabel30)
        Me.gbDetalhesContrato.Controls.Add(Me.mdt1Pagamento)
        Me.gbDetalhesContrato.Controls.Add(Me.mdtDataInicial)
        Me.gbDetalhesContrato.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetalhesContrato.Location = New System.Drawing.Point(399, 203)
        Me.gbDetalhesContrato.Name = "gbDetalhesContrato"
        Me.gbDetalhesContrato.Size = New System.Drawing.Size(341, 317)
        Me.gbDetalhesContrato.TabIndex = 223
        Me.gbDetalhesContrato.TabStop = False
        Me.gbDetalhesContrato.Text = "Detalhes do Contrato"
        '
        'mlbValorTotalContrato
        '
        Me.mlbValorTotalContrato.AutoSize = True
        Me.mlbValorTotalContrato.Location = New System.Drawing.Point(260, 281)
        Me.mlbValorTotalContrato.Name = "mlbValorTotalContrato"
        Me.mlbValorTotalContrato.Size = New System.Drawing.Size(16, 19)
        Me.mlbValorTotalContrato.TabIndex = 44
        Me.mlbValorTotalContrato.Text = "0"
        '
        'MetroLabel35
        '
        Me.MetroLabel35.AutoSize = True
        Me.MetroLabel35.Location = New System.Drawing.Point(109, 281)
        Me.MetroLabel35.Name = "MetroLabel35"
        Me.MetroLabel35.Size = New System.Drawing.Size(145, 19)
        Me.MetroLabel35.TabIndex = 43
        Me.MetroLabel35.Text = "Valor Total do Contrato"
        '
        'MetroLabel34
        '
        Me.MetroLabel34.AutoSize = True
        Me.MetroLabel34.Location = New System.Drawing.Point(31, 257)
        Me.MetroLabel34.Name = "MetroLabel34"
        Me.MetroLabel34.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel34.TabIndex = 18
        Me.MetroLabel34.Text = "Desconto"
        '
        'mcbAgua
        '
        Me.mcbAgua.AutoSize = True
        Me.mcbAgua.Location = New System.Drawing.Point(259, 204)
        Me.mcbAgua.Name = "mcbAgua"
        Me.mcbAgua.Size = New System.Drawing.Size(51, 15)
        Me.mcbAgua.TabIndex = 42
        Me.mcbAgua.Text = "Água"
        Me.mcbAgua.UseSelectable = True
        '
        'mtbDesconto
        '
        '
        '
        '
        Me.mtbDesconto.CustomButton.Image = Nothing
        Me.mtbDesconto.CustomButton.Location = New System.Drawing.Point(50, 1)
        Me.mtbDesconto.CustomButton.Name = ""
        Me.mtbDesconto.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbDesconto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbDesconto.CustomButton.TabIndex = 1
        Me.mtbDesconto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbDesconto.CustomButton.UseSelectable = True
        Me.mtbDesconto.CustomButton.Visible = False
        Me.mtbDesconto.Lines = New String(-1) {}
        Me.mtbDesconto.Location = New System.Drawing.Point(31, 281)
        Me.mtbDesconto.MaxLength = 32767
        Me.mtbDesconto.Name = "mtbDesconto"
        Me.mtbDesconto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbDesconto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbDesconto.SelectedText = ""
        Me.mtbDesconto.SelectionLength = 0
        Me.mtbDesconto.SelectionStart = 0
        Me.mtbDesconto.ShortcutsEnabled = True
        Me.mtbDesconto.Size = New System.Drawing.Size(72, 23)
        Me.mtbDesconto.TabIndex = 17
        Me.mtbDesconto.UseSelectable = True
        Me.mtbDesconto.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbDesconto.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mcbLuz
        '
        Me.mcbLuz.AutoSize = True
        Me.mcbLuz.Location = New System.Drawing.Point(259, 162)
        Me.mcbLuz.Name = "mcbLuz"
        Me.mcbLuz.Size = New System.Drawing.Size(41, 15)
        Me.mcbLuz.TabIndex = 41
        Me.mcbLuz.Text = "Luz"
        Me.mcbLuz.UseSelectable = True
        '
        'mcbInternet
        '
        Me.mcbInternet.AutoSize = True
        Me.mcbInternet.Location = New System.Drawing.Point(259, 183)
        Me.mcbInternet.Name = "mcbInternet"
        Me.mcbInternet.Size = New System.Drawing.Size(64, 15)
        Me.mcbInternet.TabIndex = 40
        Me.mcbInternet.Text = "Internet"
        Me.mcbInternet.UseSelectable = True
        '
        'MetroLabel33
        '
        Me.MetroLabel33.AutoSize = True
        Me.MetroLabel33.Location = New System.Drawing.Point(129, 159)
        Me.MetroLabel33.Name = "MetroLabel33"
        Me.MetroLabel33.Size = New System.Drawing.Size(101, 19)
        Me.MetroLabel33.TabIndex = 39
        Me.MetroLabel33.Text = "Meses Contrato"
        '
        'numMesesContrato
        '
        Me.numMesesContrato.Location = New System.Drawing.Point(156, 183)
        Me.numMesesContrato.Name = "numMesesContrato"
        Me.numMesesContrato.Size = New System.Drawing.Size(50, 27)
        Me.numMesesContrato.TabIndex = 38
        Me.numMesesContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MetroLabel32
        '
        Me.MetroLabel32.AutoSize = True
        Me.MetroLabel32.Location = New System.Drawing.Point(20, 160)
        Me.MetroLabel32.Name = "MetroLabel32"
        Me.MetroLabel32.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel32.TabIndex = 37
        Me.MetroLabel32.Text = "Dia Vencimento"
        '
        'cbbDiaVencimento
        '
        Me.cbbDiaVencimento.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbDiaVencimento.FormattingEnabled = True
        Me.cbbDiaVencimento.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cbbDiaVencimento.Location = New System.Drawing.Point(50, 185)
        Me.cbbDiaVencimento.Name = "cbbDiaVencimento"
        Me.cbbDiaVencimento.Size = New System.Drawing.Size(44, 24)
        Me.cbbDiaVencimento.TabIndex = 36
        '
        'MetroLabel31
        '
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.Location = New System.Drawing.Point(180, 58)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel31.TabIndex = 18
        Me.MetroLabel31.Text = "Data 1º Pgto"
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.Location = New System.Drawing.Point(54, 58)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel30.TabIndex = 17
        Me.MetroLabel30.Text = "Data Inicial"
        '
        'mdt1Pagamento
        '
        Me.mdt1Pagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdt1Pagamento.Location = New System.Drawing.Point(180, 80)
        Me.mdt1Pagamento.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdt1Pagamento.Name = "mdt1Pagamento"
        Me.mdt1Pagamento.Size = New System.Drawing.Size(106, 29)
        Me.mdt1Pagamento.TabIndex = 1
        '
        'mdtDataInicial
        '
        Me.mdtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdtDataInicial.Location = New System.Drawing.Point(54, 80)
        Me.mdtDataInicial.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtDataInicial.Name = "mdtDataInicial"
        Me.mdtDataInicial.Size = New System.Drawing.Size(106, 29)
        Me.mdtDataInicial.TabIndex = 0
        '
        'gbinquilino
        '
        Me.gbinquilino.BackColor = System.Drawing.Color.White
        Me.gbinquilino.Controls.Add(Me.btNovaCategoria)
        Me.gbinquilino.Controls.Add(Me.cbbInquilinos)
        Me.gbinquilino.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbinquilino.Location = New System.Drawing.Point(399, 66)
        Me.gbinquilino.Name = "gbinquilino"
        Me.gbinquilino.Size = New System.Drawing.Size(341, 117)
        Me.gbinquilino.TabIndex = 222
        Me.gbinquilino.TabStop = False
        Me.gbinquilino.Text = "Inquilino"
        '
        'btNovaCategoria
        '
        Me.btNovaCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btNovaCategoria.FlatAppearance.BorderSize = 0
        Me.btNovaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovaCategoria.Image = Global.immobi.My.Resources.Resources.plus_mini___1523_
        Me.btNovaCategoria.Location = New System.Drawing.Point(281, 54)
        Me.btNovaCategoria.Name = "btNovaCategoria"
        Me.btNovaCategoria.Size = New System.Drawing.Size(24, 24)
        Me.btNovaCategoria.TabIndex = 150
        Me.btNovaCategoria.UseVisualStyleBackColor = False
        '
        'cbbInquilinos
        '
        Me.cbbInquilinos.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbInquilinos.FormattingEnabled = True
        Me.cbbInquilinos.Location = New System.Drawing.Point(29, 54)
        Me.cbbInquilinos.Name = "cbbInquilinos"
        Me.cbbInquilinos.Size = New System.Drawing.Size(246, 24)
        Me.cbbInquilinos.TabIndex = 1
        '
        'gbImoveis
        '
        Me.gbImoveis.BackColor = System.Drawing.Color.White
        Me.gbImoveis.Controls.Add(Me.mlbCodigoImovel)
        Me.gbImoveis.Controls.Add(Me.MetroLabel37)
        Me.gbImoveis.Controls.Add(Me.MetroLabel29)
        Me.gbImoveis.Controls.Add(Me.mtbValorLocacaoC)
        Me.gbImoveis.Controls.Add(Me.MetroLabel28)
        Me.gbImoveis.Controls.Add(Me.mtbValorAguaC)
        Me.gbImoveis.Controls.Add(Me.MetroLabel27)
        Me.gbImoveis.Controls.Add(Me.mtbValorLuzC)
        Me.gbImoveis.Controls.Add(Me.MetroLabel26)
        Me.gbImoveis.Controls.Add(Me.mtbValorNetC)
        Me.gbImoveis.Controls.Add(Me.MetroLabel25)
        Me.gbImoveis.Controls.Add(Me.mtbTipo)
        Me.gbImoveis.Controls.Add(Me.MetroLabel23)
        Me.gbImoveis.Controls.Add(Me.mtbFinalidade)
        Me.gbImoveis.Controls.Add(Me.MetroLabel22)
        Me.gbImoveis.Controls.Add(Me.mtbComplementoC)
        Me.gbImoveis.Controls.Add(Me.MetroLabel20)
        Me.gbImoveis.Controls.Add(Me.mtbEndereco)
        Me.gbImoveis.Controls.Add(Me.mbtSelecionaImovel)
        Me.gbImoveis.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbImoveis.Location = New System.Drawing.Point(35, 66)
        Me.gbImoveis.Name = "gbImoveis"
        Me.gbImoveis.Size = New System.Drawing.Size(341, 454)
        Me.gbImoveis.TabIndex = 221
        Me.gbImoveis.TabStop = False
        Me.gbImoveis.Text = "Imóvel"
        '
        'mlbCodigoImovel
        '
        Me.mlbCodigoImovel.AutoSize = True
        Me.mlbCodigoImovel.Location = New System.Drawing.Point(288, 42)
        Me.mlbCodigoImovel.Name = "mlbCodigoImovel"
        Me.mlbCodigoImovel.Size = New System.Drawing.Size(16, 19)
        Me.mlbCodigoImovel.TabIndex = 18
        Me.mlbCodigoImovel.Text = "0"
        '
        'MetroLabel37
        '
        Me.MetroLabel37.AutoSize = True
        Me.MetroLabel37.Location = New System.Drawing.Point(154, 42)
        Me.MetroLabel37.Name = "MetroLabel37"
        Me.MetroLabel37.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel37.TabIndex = 17
        Me.MetroLabel37.Text = "Código do Imóvel"
        '
        'MetroLabel29
        '
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.Location = New System.Drawing.Point(97, 372)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel29.TabIndex = 16
        Me.MetroLabel29.Text = "Valor Locação"
        '
        'mtbValorLocacaoC
        '
        '
        '
        '
        Me.mtbValorLocacaoC.CustomButton.Image = Nothing
        Me.mtbValorLocacaoC.CustomButton.Location = New System.Drawing.Point(97, 1)
        Me.mtbValorLocacaoC.CustomButton.Name = ""
        Me.mtbValorLocacaoC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbValorLocacaoC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbValorLocacaoC.CustomButton.TabIndex = 1
        Me.mtbValorLocacaoC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbValorLocacaoC.CustomButton.UseSelectable = True
        Me.mtbValorLocacaoC.CustomButton.Visible = False
        Me.mtbValorLocacaoC.Enabled = False
        Me.mtbValorLocacaoC.Lines = New String(-1) {}
        Me.mtbValorLocacaoC.Location = New System.Drawing.Point(97, 394)
        Me.mtbValorLocacaoC.MaxLength = 32767
        Me.mtbValorLocacaoC.Name = "mtbValorLocacaoC"
        Me.mtbValorLocacaoC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbValorLocacaoC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbValorLocacaoC.SelectedText = ""
        Me.mtbValorLocacaoC.SelectionLength = 0
        Me.mtbValorLocacaoC.SelectionStart = 0
        Me.mtbValorLocacaoC.ShortcutsEnabled = True
        Me.mtbValorLocacaoC.Size = New System.Drawing.Size(119, 23)
        Me.mtbValorLocacaoC.TabIndex = 15
        Me.mtbValorLocacaoC.UseSelectable = True
        Me.mtbValorLocacaoC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbValorLocacaoC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel28
        '
        Me.MetroLabel28.AutoSize = True
        Me.MetroLabel28.Location = New System.Drawing.Point(218, 298)
        Me.MetroLabel28.Name = "MetroLabel28"
        Me.MetroLabel28.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel28.TabIndex = 14
        Me.MetroLabel28.Text = "Valor Água"
        '
        'mtbValorAguaC
        '
        '
        '
        '
        Me.mtbValorAguaC.CustomButton.Image = Nothing
        Me.mtbValorAguaC.CustomButton.Location = New System.Drawing.Point(64, 1)
        Me.mtbValorAguaC.CustomButton.Name = ""
        Me.mtbValorAguaC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbValorAguaC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbValorAguaC.CustomButton.TabIndex = 1
        Me.mtbValorAguaC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbValorAguaC.CustomButton.UseSelectable = True
        Me.mtbValorAguaC.CustomButton.Visible = False
        Me.mtbValorAguaC.Enabled = False
        Me.mtbValorAguaC.Lines = New String(-1) {}
        Me.mtbValorAguaC.Location = New System.Drawing.Point(218, 320)
        Me.mtbValorAguaC.MaxLength = 32767
        Me.mtbValorAguaC.Name = "mtbValorAguaC"
        Me.mtbValorAguaC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbValorAguaC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbValorAguaC.SelectedText = ""
        Me.mtbValorAguaC.SelectionLength = 0
        Me.mtbValorAguaC.SelectionStart = 0
        Me.mtbValorAguaC.ShortcutsEnabled = True
        Me.mtbValorAguaC.Size = New System.Drawing.Size(86, 23)
        Me.mtbValorAguaC.TabIndex = 13
        Me.mtbValorAguaC.UseSelectable = True
        Me.mtbValorAguaC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbValorAguaC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel27
        '
        Me.MetroLabel27.AutoSize = True
        Me.MetroLabel27.Location = New System.Drawing.Point(114, 298)
        Me.MetroLabel27.Name = "MetroLabel27"
        Me.MetroLabel27.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel27.TabIndex = 12
        Me.MetroLabel27.Text = "Valor Luz"
        '
        'mtbValorLuzC
        '
        '
        '
        '
        Me.mtbValorLuzC.CustomButton.Image = Nothing
        Me.mtbValorLuzC.CustomButton.Location = New System.Drawing.Point(64, 1)
        Me.mtbValorLuzC.CustomButton.Name = ""
        Me.mtbValorLuzC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbValorLuzC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbValorLuzC.CustomButton.TabIndex = 1
        Me.mtbValorLuzC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbValorLuzC.CustomButton.UseSelectable = True
        Me.mtbValorLuzC.CustomButton.Visible = False
        Me.mtbValorLuzC.Enabled = False
        Me.mtbValorLuzC.Lines = New String(-1) {}
        Me.mtbValorLuzC.Location = New System.Drawing.Point(114, 320)
        Me.mtbValorLuzC.MaxLength = 32767
        Me.mtbValorLuzC.Name = "mtbValorLuzC"
        Me.mtbValorLuzC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbValorLuzC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbValorLuzC.SelectedText = ""
        Me.mtbValorLuzC.SelectionLength = 0
        Me.mtbValorLuzC.SelectionStart = 0
        Me.mtbValorLuzC.ShortcutsEnabled = True
        Me.mtbValorLuzC.Size = New System.Drawing.Size(86, 23)
        Me.mtbValorLuzC.TabIndex = 11
        Me.mtbValorLuzC.UseSelectable = True
        Me.mtbValorLuzC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbValorLuzC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel26
        '
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.Location = New System.Drawing.Point(15, 298)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel26.TabIndex = 10
        Me.MetroLabel26.Text = "Valor Internet"
        '
        'mtbValorNetC
        '
        '
        '
        '
        Me.mtbValorNetC.CustomButton.Image = Nothing
        Me.mtbValorNetC.CustomButton.Location = New System.Drawing.Point(64, 1)
        Me.mtbValorNetC.CustomButton.Name = ""
        Me.mtbValorNetC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbValorNetC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbValorNetC.CustomButton.TabIndex = 1
        Me.mtbValorNetC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbValorNetC.CustomButton.UseSelectable = True
        Me.mtbValorNetC.CustomButton.Visible = False
        Me.mtbValorNetC.Enabled = False
        Me.mtbValorNetC.Lines = New String(-1) {}
        Me.mtbValorNetC.Location = New System.Drawing.Point(15, 320)
        Me.mtbValorNetC.MaxLength = 32767
        Me.mtbValorNetC.Name = "mtbValorNetC"
        Me.mtbValorNetC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbValorNetC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbValorNetC.SelectedText = ""
        Me.mtbValorNetC.SelectionLength = 0
        Me.mtbValorNetC.SelectionStart = 0
        Me.mtbValorNetC.ShortcutsEnabled = True
        Me.mtbValorNetC.Size = New System.Drawing.Size(86, 23)
        Me.mtbValorNetC.TabIndex = 9
        Me.mtbValorNetC.UseSelectable = True
        Me.mtbValorNetC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbValorNetC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel25
        '
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.Location = New System.Drawing.Point(15, 247)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel25.TabIndex = 8
        Me.MetroLabel25.Text = "Tipo"
        '
        'mtbTipo
        '
        '
        '
        '
        Me.mtbTipo.CustomButton.Image = Nothing
        Me.mtbTipo.CustomButton.Location = New System.Drawing.Point(170, 1)
        Me.mtbTipo.CustomButton.Name = ""
        Me.mtbTipo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbTipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbTipo.CustomButton.TabIndex = 1
        Me.mtbTipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbTipo.CustomButton.UseSelectable = True
        Me.mtbTipo.CustomButton.Visible = False
        Me.mtbTipo.Enabled = False
        Me.mtbTipo.Lines = New String(-1) {}
        Me.mtbTipo.Location = New System.Drawing.Point(15, 269)
        Me.mtbTipo.MaxLength = 32767
        Me.mtbTipo.Name = "mtbTipo"
        Me.mtbTipo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbTipo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbTipo.SelectedText = ""
        Me.mtbTipo.SelectionLength = 0
        Me.mtbTipo.SelectionStart = 0
        Me.mtbTipo.ShortcutsEnabled = True
        Me.mtbTipo.Size = New System.Drawing.Size(192, 23)
        Me.mtbTipo.TabIndex = 7
        Me.mtbTipo.UseSelectable = True
        Me.mtbTipo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbTipo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.Location = New System.Drawing.Point(15, 195)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel23.TabIndex = 6
        Me.MetroLabel23.Text = "Finalidade"
        '
        'mtbFinalidade
        '
        '
        '
        '
        Me.mtbFinalidade.CustomButton.Image = Nothing
        Me.mtbFinalidade.CustomButton.Location = New System.Drawing.Point(170, 1)
        Me.mtbFinalidade.CustomButton.Name = ""
        Me.mtbFinalidade.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbFinalidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbFinalidade.CustomButton.TabIndex = 1
        Me.mtbFinalidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbFinalidade.CustomButton.UseSelectable = True
        Me.mtbFinalidade.CustomButton.Visible = False
        Me.mtbFinalidade.Enabled = False
        Me.mtbFinalidade.Lines = New String(-1) {}
        Me.mtbFinalidade.Location = New System.Drawing.Point(15, 217)
        Me.mtbFinalidade.MaxLength = 32767
        Me.mtbFinalidade.Name = "mtbFinalidade"
        Me.mtbFinalidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbFinalidade.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbFinalidade.SelectedText = ""
        Me.mtbFinalidade.SelectionLength = 0
        Me.mtbFinalidade.SelectionStart = 0
        Me.mtbFinalidade.ShortcutsEnabled = True
        Me.mtbFinalidade.Size = New System.Drawing.Size(192, 23)
        Me.mtbFinalidade.TabIndex = 5
        Me.mtbFinalidade.UseSelectable = True
        Me.mtbFinalidade.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbFinalidade.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.Location = New System.Drawing.Point(15, 137)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel22.TabIndex = 4
        Me.MetroLabel22.Text = "Complemento"
        '
        'mtbComplementoC
        '
        '
        '
        '
        Me.mtbComplementoC.CustomButton.Image = Nothing
        Me.mtbComplementoC.CustomButton.Location = New System.Drawing.Point(170, 1)
        Me.mtbComplementoC.CustomButton.Name = ""
        Me.mtbComplementoC.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbComplementoC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbComplementoC.CustomButton.TabIndex = 1
        Me.mtbComplementoC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbComplementoC.CustomButton.UseSelectable = True
        Me.mtbComplementoC.CustomButton.Visible = False
        Me.mtbComplementoC.Enabled = False
        Me.mtbComplementoC.Lines = New String(-1) {}
        Me.mtbComplementoC.Location = New System.Drawing.Point(15, 159)
        Me.mtbComplementoC.MaxLength = 32767
        Me.mtbComplementoC.Name = "mtbComplementoC"
        Me.mtbComplementoC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbComplementoC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbComplementoC.SelectedText = ""
        Me.mtbComplementoC.SelectionLength = 0
        Me.mtbComplementoC.SelectionStart = 0
        Me.mtbComplementoC.ShortcutsEnabled = True
        Me.mtbComplementoC.Size = New System.Drawing.Size(192, 23)
        Me.mtbComplementoC.TabIndex = 3
        Me.mtbComplementoC.UseSelectable = True
        Me.mtbComplementoC.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbComplementoC.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(15, 85)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel20.TabIndex = 2
        Me.MetroLabel20.Text = "Endereço"
        '
        'mtbEndereco
        '
        '
        '
        '
        Me.mtbEndereco.CustomButton.Image = Nothing
        Me.mtbEndereco.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.mtbEndereco.CustomButton.Name = ""
        Me.mtbEndereco.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbEndereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbEndereco.CustomButton.TabIndex = 1
        Me.mtbEndereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbEndereco.CustomButton.UseSelectable = True
        Me.mtbEndereco.CustomButton.Visible = False
        Me.mtbEndereco.Enabled = False
        Me.mtbEndereco.Lines = New String(-1) {}
        Me.mtbEndereco.Location = New System.Drawing.Point(15, 107)
        Me.mtbEndereco.MaxLength = 32767
        Me.mtbEndereco.Name = "mtbEndereco"
        Me.mtbEndereco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbEndereco.SelectedText = ""
        Me.mtbEndereco.SelectionLength = 0
        Me.mtbEndereco.SelectionStart = 0
        Me.mtbEndereco.ShortcutsEnabled = True
        Me.mtbEndereco.Size = New System.Drawing.Size(308, 23)
        Me.mtbEndereco.TabIndex = 1
        Me.mtbEndereco.UseSelectable = True
        Me.mtbEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbEndereco.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mbtSelecionaImovel
        '
        Me.mbtSelecionaImovel.Location = New System.Drawing.Point(16, 38)
        Me.mbtSelecionaImovel.Name = "mbtSelecionaImovel"
        Me.mbtSelecionaImovel.Size = New System.Drawing.Size(114, 23)
        Me.mbtSelecionaImovel.TabIndex = 0
        Me.mbtSelecionaImovel.Text = "Selecionar Imóvel"
        Me.mbtSelecionaImovel.UseSelectable = True
        '
        'mbtEditarContrato
        '
        Me.mbtEditarContrato.Location = New System.Drawing.Point(209, 553)
        Me.mbtEditarContrato.Name = "mbtEditarContrato"
        Me.mbtEditarContrato.Size = New System.Drawing.Size(117, 23)
        Me.mbtEditarContrato.TabIndex = 224
        Me.mbtEditarContrato.Text = "Editar Contrato"
        Me.mbtEditarContrato.UseSelectable = True
        '
        'mbtrenovarCotnrato
        '
        Me.mbtrenovarCotnrato.Location = New System.Drawing.Point(332, 553)
        Me.mbtrenovarCotnrato.Name = "mbtrenovarCotnrato"
        Me.mbtrenovarCotnrato.Size = New System.Drawing.Size(117, 23)
        Me.mbtrenovarCotnrato.TabIndex = 225
        Me.mbtrenovarCotnrato.Text = "Renovar Contrato"
        Me.mbtrenovarCotnrato.UseSelectable = True
        '
        'mbtExcluirContrato
        '
        Me.mbtExcluirContrato.Location = New System.Drawing.Point(455, 553)
        Me.mbtExcluirContrato.Name = "mbtExcluirContrato"
        Me.mbtExcluirContrato.Size = New System.Drawing.Size(117, 23)
        Me.mbtExcluirContrato.TabIndex = 226
        Me.mbtExcluirContrato.Text = "Excluir Contrato"
        Me.mbtExcluirContrato.UseSelectable = True
        '
        'mbtFinalizarContrato
        '
        Me.mbtFinalizarContrato.Location = New System.Drawing.Point(332, 553)
        Me.mbtFinalizarContrato.Name = "mbtFinalizarContrato"
        Me.mbtFinalizarContrato.Size = New System.Drawing.Size(117, 23)
        Me.mbtFinalizarContrato.TabIndex = 227
        Me.mbtFinalizarContrato.Text = "Finalizar Contrato"
        Me.mbtFinalizarContrato.UseSelectable = True
        '
        'AttContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 614)
        Me.Controls.Add(Me.mbtFinalizarContrato)
        Me.Controls.Add(Me.mbtExcluirContrato)
        Me.Controls.Add(Me.mbtrenovarCotnrato)
        Me.Controls.Add(Me.mbtEditarContrato)
        Me.Controls.Add(Me.gbDetalhesContrato)
        Me.Controls.Add(Me.gbinquilino)
        Me.Controls.Add(Me.gbImoveis)
        Me.Controls.Add(Me.mbtSair)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pbBorderLeft1)
        Me.Controls.Add(Me.pbBorderRight1)
        Me.Controls.Add(Me.pbBorderTop1)
        Me.Controls.Add(Me.pbBorderbotom1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttContratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttContratos"
        Me.gbDetalhesContrato.ResumeLayout(False)
        Me.gbDetalhesContrato.PerformLayout()
        CType(Me.numMesesContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbinquilino.ResumeLayout(False)
        Me.gbImoveis.ResumeLayout(False)
        Me.gbImoveis.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mbtSair As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbBorderLeft1 As Panel
    Friend WithEvents pbBorderRight1 As Panel
    Friend WithEvents pbBorderTop1 As Panel
    Friend WithEvents pbBorderbotom1 As Panel
    Friend WithEvents gbDetalhesContrato As GroupBox
    Friend WithEvents mlbValorTotalContrato As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel35 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel34 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mcbAgua As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mtbDesconto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mcbLuz As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents mcbInternet As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel33 As MetroFramework.Controls.MetroLabel
    Friend WithEvents numMesesContrato As NumericUpDown
    Friend WithEvents MetroLabel32 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbbDiaVencimento As ComboBox
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mdt1Pagamento As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mdtDataInicial As MetroFramework.Controls.MetroDateTime
    Friend WithEvents gbinquilino As GroupBox
    Friend WithEvents btNovaCategoria As Button
    Friend WithEvents cbbInquilinos As ComboBox
    Friend WithEvents gbImoveis As GroupBox
    Friend WithEvents mlbCodigoImovel As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel37 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbValorLocacaoC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel28 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbValorAguaC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel27 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbValorLuzC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbValorNetC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbTipo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbFinalidade As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbComplementoC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbEndereco As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mbtSelecionaImovel As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtEditarContrato As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtrenovarCotnrato As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtExcluirContrato As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtFinalizarContrato As MetroFramework.Controls.MetroButton
End Class
