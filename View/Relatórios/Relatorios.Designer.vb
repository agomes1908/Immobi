<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Relatorios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.mlbNomeTela = New MetroFramework.Controls.MetroLabel()
        Me.gbplanoCon = New System.Windows.Forms.GroupBox()
        Me.tvPlanoContas = New System.Windows.Forms.TreeView()
        Me.gbFavorecidos = New System.Windows.Forms.GroupBox()
        Me.lbxFavorecidosChecked = New System.Windows.Forms.ListBox()
        Me.tbPesquisaFavorecido = New System.Windows.Forms.TextBox()
        Me.lbxFavorecidos = New System.Windows.Forms.ListBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.mtbCheque = New MetroFramework.Controls.MetroTextBox()
        Me.mtbObs = New MetroFramework.Controls.MetroTextBox()
        Me.mtbDescricao = New MetroFramework.Controls.MetroTextBox()
        Me.metroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mrbAmbos2 = New MetroFramework.Controls.MetroRadioButton()
        Me.mrbAberto = New MetroFramework.Controls.MetroRadioButton()
        Me.mrbPago = New MetroFramework.Controls.MetroRadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.clbxCenCustos = New System.Windows.Forms.CheckedListBox()
        Me.gbContas = New System.Windows.Forms.GroupBox()
        Me.clbxContas = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.mrbAmbos = New MetroFramework.Controls.MetroRadioButton()
        Me.mrbReceita = New MetroFramework.Controls.MetroRadioButton()
        Me.mrbDespesa = New MetroFramework.Controls.MetroRadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.mdtpVencInicial = New MetroFramework.Controls.MetroDateTime()
        Me.mdtpVencFinal = New MetroFramework.Controls.MetroDateTime()
        Me.mdtpPgtoFinal = New MetroFramework.Controls.MetroDateTime()
        Me.mdtpPgtoInicial = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mbtGeraRelatorio = New MetroFramework.Controls.MetroButton()
        Me.mbtImprimeRelatorio = New MetroFramework.Controls.MetroButton()
        Me.mGridRelatorios = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.lbValorTotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.lbTot = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.gbplanoCon.SuspendLayout()
        Me.gbFavorecidos.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.gbContas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.mGridRelatorios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.mlbNomeTela)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1350, 40)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'mlbNomeTela
        '
        Me.mlbNomeTela.AutoSize = True
        Me.mlbNomeTela.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.mlbNomeTela.Location = New System.Drawing.Point(0, 12)
        Me.mlbNomeTela.Name = "mlbNomeTela"
        Me.mlbNomeTela.Size = New System.Drawing.Size(86, 25)
        Me.mlbNomeTela.TabIndex = 2
        Me.mlbNomeTela.Text = "Relatórios"
        '
        'gbplanoCon
        '
        Me.gbplanoCon.Controls.Add(Me.tvPlanoContas)
        Me.gbplanoCon.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbplanoCon.Location = New System.Drawing.Point(866, 46)
        Me.gbplanoCon.Name = "gbplanoCon"
        Me.gbplanoCon.Size = New System.Drawing.Size(287, 154)
        Me.gbplanoCon.TabIndex = 90
        Me.gbplanoCon.TabStop = False
        Me.gbplanoCon.Text = "Plano Contas"
        '
        'tvPlanoContas
        '
        Me.tvPlanoContas.Location = New System.Drawing.Point(6, 19)
        Me.tvPlanoContas.Name = "tvPlanoContas"
        Me.tvPlanoContas.Size = New System.Drawing.Size(275, 128)
        Me.tvPlanoContas.TabIndex = 41
        '
        'gbFavorecidos
        '
        Me.gbFavorecidos.Controls.Add(Me.lbxFavorecidosChecked)
        Me.gbFavorecidos.Controls.Add(Me.tbPesquisaFavorecido)
        Me.gbFavorecidos.Controls.Add(Me.lbxFavorecidos)
        Me.gbFavorecidos.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFavorecidos.Location = New System.Drawing.Point(514, 46)
        Me.gbFavorecidos.Name = "gbFavorecidos"
        Me.gbFavorecidos.Size = New System.Drawing.Size(346, 154)
        Me.gbFavorecidos.TabIndex = 89
        Me.gbFavorecidos.TabStop = False
        Me.gbFavorecidos.Text = "Favorecidos"
        '
        'lbxFavorecidosChecked
        '
        Me.lbxFavorecidosChecked.FormattingEnabled = True
        Me.lbxFavorecidosChecked.ItemHeight = 16
        Me.lbxFavorecidosChecked.Location = New System.Drawing.Point(176, 47)
        Me.lbxFavorecidosChecked.Name = "lbxFavorecidosChecked"
        Me.lbxFavorecidosChecked.Size = New System.Drawing.Size(160, 100)
        Me.lbxFavorecidosChecked.Sorted = True
        Me.lbxFavorecidosChecked.TabIndex = 51
        '
        'tbPesquisaFavorecido
        '
        Me.tbPesquisaFavorecido.Location = New System.Drawing.Point(6, 19)
        Me.tbPesquisaFavorecido.Name = "tbPesquisaFavorecido"
        Me.tbPesquisaFavorecido.Size = New System.Drawing.Size(330, 24)
        Me.tbPesquisaFavorecido.TabIndex = 50
        '
        'lbxFavorecidos
        '
        Me.lbxFavorecidos.FormattingEnabled = True
        Me.lbxFavorecidos.ItemHeight = 16
        Me.lbxFavorecidos.Location = New System.Drawing.Point(6, 47)
        Me.lbxFavorecidos.Name = "lbxFavorecidos"
        Me.lbxFavorecidos.Size = New System.Drawing.Size(160, 100)
        Me.lbxFavorecidos.Sorted = True
        Me.lbxFavorecidos.TabIndex = 48
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.MetroLabel7)
        Me.GroupBox8.Controls.Add(Me.mtbCheque)
        Me.GroupBox8.Controls.Add(Me.mtbObs)
        Me.GroupBox8.Controls.Add(Me.mtbDescricao)
        Me.GroupBox8.Controls.Add(Me.metroLabel5)
        Me.GroupBox8.Controls.Add(Me.MetroLabel6)
        Me.GroupBox8.Location = New System.Drawing.Point(638, 206)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(290, 61)
        Me.GroupBox8.TabIndex = 85
        Me.GroupBox8.TabStop = False
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(206, 7)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel7.TabIndex = 93
        Me.MetroLabel7.Text = "Cheque"
        '
        'mtbCheque
        '
        '
        '
        '
        Me.mtbCheque.CustomButton.Image = Nothing
        Me.mtbCheque.CustomButton.Location = New System.Drawing.Point(56, 1)
        Me.mtbCheque.CustomButton.Name = ""
        Me.mtbCheque.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbCheque.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbCheque.CustomButton.TabIndex = 1
        Me.mtbCheque.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbCheque.CustomButton.UseSelectable = True
        Me.mtbCheque.CustomButton.Visible = False
        Me.mtbCheque.Lines = New String(-1) {}
        Me.mtbCheque.Location = New System.Drawing.Point(206, 29)
        Me.mtbCheque.MaxLength = 32767
        Me.mtbCheque.Name = "mtbCheque"
        Me.mtbCheque.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbCheque.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbCheque.SelectedText = ""
        Me.mtbCheque.SelectionLength = 0
        Me.mtbCheque.SelectionStart = 0
        Me.mtbCheque.ShortcutsEnabled = True
        Me.mtbCheque.Size = New System.Drawing.Size(78, 23)
        Me.mtbCheque.TabIndex = 96
        Me.mtbCheque.UseSelectable = True
        Me.mtbCheque.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbCheque.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtbObs
        '
        '
        '
        '
        Me.mtbObs.CustomButton.Image = Nothing
        Me.mtbObs.CustomButton.Location = New System.Drawing.Point(72, 1)
        Me.mtbObs.CustomButton.Name = ""
        Me.mtbObs.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbObs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbObs.CustomButton.TabIndex = 1
        Me.mtbObs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbObs.CustomButton.UseSelectable = True
        Me.mtbObs.CustomButton.Visible = False
        Me.mtbObs.Lines = New String(-1) {}
        Me.mtbObs.Location = New System.Drawing.Point(6, 29)
        Me.mtbObs.MaxLength = 32767
        Me.mtbObs.Name = "mtbObs"
        Me.mtbObs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbObs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbObs.SelectedText = ""
        Me.mtbObs.SelectionLength = 0
        Me.mtbObs.SelectionStart = 0
        Me.mtbObs.ShortcutsEnabled = True
        Me.mtbObs.Size = New System.Drawing.Size(94, 23)
        Me.mtbObs.TabIndex = 94
        Me.mtbObs.UseSelectable = True
        Me.mtbObs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbObs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mtbDescricao
        '
        '
        '
        '
        Me.mtbDescricao.CustomButton.Image = Nothing
        Me.mtbDescricao.CustomButton.Location = New System.Drawing.Point(72, 1)
        Me.mtbDescricao.CustomButton.Name = ""
        Me.mtbDescricao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbDescricao.CustomButton.TabIndex = 1
        Me.mtbDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbDescricao.CustomButton.UseSelectable = True
        Me.mtbDescricao.CustomButton.Visible = False
        Me.mtbDescricao.Lines = New String(-1) {}
        Me.mtbDescricao.Location = New System.Drawing.Point(106, 29)
        Me.mtbDescricao.MaxLength = 32767
        Me.mtbDescricao.Name = "mtbDescricao"
        Me.mtbDescricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbDescricao.SelectedText = ""
        Me.mtbDescricao.SelectionLength = 0
        Me.mtbDescricao.SelectionStart = 0
        Me.mtbDescricao.ShortcutsEnabled = True
        Me.mtbDescricao.Size = New System.Drawing.Size(94, 23)
        Me.mtbDescricao.TabIndex = 95
        Me.mtbDescricao.UseSelectable = True
        Me.mtbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbDescricao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'metroLabel5
        '
        Me.metroLabel5.AutoSize = True
        Me.metroLabel5.Location = New System.Drawing.Point(6, 7)
        Me.metroLabel5.Name = "metroLabel5"
        Me.metroLabel5.Size = New System.Drawing.Size(80, 19)
        Me.metroLabel5.TabIndex = 91
        Me.metroLabel5.Text = "Observação"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(104, 7)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel6.TabIndex = 92
        Me.MetroLabel6.Text = "Descrição"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mrbAmbos2)
        Me.GroupBox1.Controls.Add(Me.mrbAberto)
        Me.GroupBox1.Controls.Add(Me.mrbPago)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 49)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'mrbAmbos2
        '
        Me.mrbAmbos2.AutoSize = True
        Me.mrbAmbos2.Location = New System.Drawing.Point(143, 19)
        Me.mrbAmbos2.Name = "mrbAmbos2"
        Me.mrbAmbos2.Size = New System.Drawing.Size(61, 15)
        Me.mrbAmbos2.TabIndex = 93
        Me.mrbAmbos2.Text = "Ambos"
        Me.mrbAmbos2.UseSelectable = True
        '
        'mrbAberto
        '
        Me.mrbAberto.AutoSize = True
        Me.mrbAberto.Location = New System.Drawing.Point(71, 19)
        Me.mrbAberto.Name = "mrbAberto"
        Me.mrbAberto.Size = New System.Drawing.Size(59, 15)
        Me.mrbAberto.TabIndex = 92
        Me.mrbAberto.Text = "Aberto"
        Me.mrbAberto.UseSelectable = True
        '
        'mrbPago
        '
        Me.mrbPago.AutoSize = True
        Me.mrbPago.Location = New System.Drawing.Point(4, 19)
        Me.mrbPago.Name = "mrbPago"
        Me.mrbPago.Size = New System.Drawing.Size(50, 15)
        Me.mrbPago.TabIndex = 91
        Me.mrbPago.Text = "Pago"
        Me.mrbPago.UseSelectable = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.clbxCenCustos)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(956, 206)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(197, 61)
        Me.GroupBox7.TabIndex = 88
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Centro de Custos"
        '
        'clbxCenCustos
        '
        Me.clbxCenCustos.CheckOnClick = True
        Me.clbxCenCustos.FormattingEnabled = True
        Me.clbxCenCustos.Location = New System.Drawing.Point(6, 19)
        Me.clbxCenCustos.Name = "clbxCenCustos"
        Me.clbxCenCustos.Size = New System.Drawing.Size(185, 42)
        Me.clbxCenCustos.TabIndex = 49
        '
        'gbContas
        '
        Me.gbContas.Controls.Add(Me.clbxContas)
        Me.gbContas.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContas.Location = New System.Drawing.Point(223, 46)
        Me.gbContas.Name = "gbContas"
        Me.gbContas.Size = New System.Drawing.Size(285, 94)
        Me.gbContas.TabIndex = 87
        Me.gbContas.TabStop = False
        Me.gbContas.Text = "Contas"
        '
        'clbxContas
        '
        Me.clbxContas.CheckOnClick = True
        Me.clbxContas.FormattingEnabled = True
        Me.clbxContas.Location = New System.Drawing.Point(6, 16)
        Me.clbxContas.Name = "clbxContas"
        Me.clbxContas.Size = New System.Drawing.Size(273, 61)
        Me.clbxContas.TabIndex = 49
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mrbAmbos)
        Me.GroupBox3.Controls.Add(Me.mrbReceita)
        Me.GroupBox3.Controls.Add(Me.mrbDespesa)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 43)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        '
        'mrbAmbos
        '
        Me.mrbAmbos.AutoSize = True
        Me.mrbAmbos.Location = New System.Drawing.Point(143, 16)
        Me.mrbAmbos.Name = "mrbAmbos"
        Me.mrbAmbos.Size = New System.Drawing.Size(61, 15)
        Me.mrbAmbos.TabIndex = 93
        Me.mrbAmbos.Text = "Ambos"
        Me.mrbAmbos.UseSelectable = True
        '
        'mrbReceita
        '
        Me.mrbReceita.AutoSize = True
        Me.mrbReceita.Location = New System.Drawing.Point(4, 16)
        Me.mrbReceita.Name = "mrbReceita"
        Me.mrbReceita.Size = New System.Drawing.Size(61, 15)
        Me.mrbReceita.TabIndex = 91
        Me.mrbReceita.Text = "Receita"
        Me.mrbReceita.UseSelectable = True
        '
        'mrbDespesa
        '
        Me.mrbDespesa.AutoSize = True
        Me.mrbDespesa.Location = New System.Drawing.Point(71, 16)
        Me.mrbDespesa.Name = "mrbDespesa"
        Me.mrbDespesa.Size = New System.Drawing.Size(66, 15)
        Me.mrbDespesa.TabIndex = 92
        Me.mrbDespesa.Text = "Despesa"
        Me.mrbDespesa.UseSelectable = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.mdtpVencInicial)
        Me.GroupBox4.Controls.Add(Me.mdtpVencFinal)
        Me.GroupBox4.Controls.Add(Me.mdtpPgtoFinal)
        Me.GroupBox4.Controls.Add(Me.mdtpPgtoInicial)
        Me.GroupBox4.Controls.Add(Me.MetroLabel1)
        Me.GroupBox4.Controls.Add(Me.MetroLabel2)
        Me.GroupBox4.Controls.Add(Me.MetroLabel3)
        Me.GroupBox4.Controls.Add(Me.MetroLabel4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(398, 92)
        Me.GroupBox4.TabIndex = 86
        Me.GroupBox4.TabStop = False
        '
        'mdtpVencInicial
        '
        Me.mdtpVencInicial.Checked = False
        Me.mdtpVencInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdtpVencInicial.Location = New System.Drawing.Point(88, 15)
        Me.mdtpVencInicial.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtpVencInicial.Name = "mdtpVencInicial"
        Me.mdtpVencInicial.ShowCheckBox = True
        Me.mdtpVencInicial.Size = New System.Drawing.Size(124, 29)
        Me.mdtpVencInicial.TabIndex = 95
        '
        'mdtpVencFinal
        '
        Me.mdtpVencFinal.Checked = False
        Me.mdtpVencFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdtpVencFinal.Location = New System.Drawing.Point(253, 15)
        Me.mdtpVencFinal.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtpVencFinal.Name = "mdtpVencFinal"
        Me.mdtpVencFinal.ShowCheckBox = True
        Me.mdtpVencFinal.Size = New System.Drawing.Size(124, 29)
        Me.mdtpVencFinal.TabIndex = 98
        '
        'mdtpPgtoFinal
        '
        Me.mdtpPgtoFinal.Checked = False
        Me.mdtpPgtoFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdtpPgtoFinal.Location = New System.Drawing.Point(253, 52)
        Me.mdtpPgtoFinal.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtpPgtoFinal.Name = "mdtpPgtoFinal"
        Me.mdtpPgtoFinal.ShowCheckBox = True
        Me.mdtpPgtoFinal.Size = New System.Drawing.Size(124, 29)
        Me.mdtpPgtoFinal.TabIndex = 97
        '
        'mdtpPgtoInicial
        '
        Me.mdtpPgtoInicial.Checked = False
        Me.mdtpPgtoInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mdtpPgtoInicial.Location = New System.Drawing.Point(88, 52)
        Me.mdtpPgtoInicial.MinimumSize = New System.Drawing.Size(0, 29)
        Me.mdtpPgtoInicial.Name = "mdtpPgtoInicial"
        Me.mdtpPgtoInicial.ShowCheckBox = True
        Me.mdtpPgtoInicial.Size = New System.Drawing.Size(124, 29)
        Me.mdtpPgtoInicial.TabIndex = 96
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(9, 20)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel1.TabIndex = 91
        Me.MetroLabel1.Text = "Data Venc.:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 55)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel2.TabIndex = 92
        Me.MetroLabel2.Text = "Data Pgto:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(218, 20)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel3.TabIndex = 93
        Me.MetroLabel3.Text = "Até"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(218, 56)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel4.TabIndex = 94
        Me.MetroLabel4.Text = "Até"
        '
        'mbtGeraRelatorio
        '
        Me.mbtGeraRelatorio.Location = New System.Drawing.Point(416, 225)
        Me.mbtGeraRelatorio.Name = "mbtGeraRelatorio"
        Me.mbtGeraRelatorio.Size = New System.Drawing.Size(98, 30)
        Me.mbtGeraRelatorio.TabIndex = 91
        Me.mbtGeraRelatorio.Text = "Gera Relatório"
        Me.mbtGeraRelatorio.UseSelectable = True
        '
        'mbtImprimeRelatorio
        '
        Me.mbtImprimeRelatorio.Location = New System.Drawing.Point(520, 225)
        Me.mbtImprimeRelatorio.Name = "mbtImprimeRelatorio"
        Me.mbtImprimeRelatorio.Size = New System.Drawing.Size(102, 30)
        Me.mbtImprimeRelatorio.TabIndex = 92
        Me.mbtImprimeRelatorio.Text = "Imprime relatório"
        Me.mbtImprimeRelatorio.UseSelectable = True
        '
        'mGridRelatorios
        '
        Me.mGridRelatorios.AllowUserToAddRows = False
        Me.mGridRelatorios.AllowUserToDeleteRows = False
        Me.mGridRelatorios.AllowUserToResizeRows = False
        Me.mGridRelatorios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mGridRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mGridRelatorios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mGridRelatorios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mGridRelatorios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.mGridRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mGridRelatorios.DefaultCellStyle = DataGridViewCellStyle2
        Me.mGridRelatorios.EnableHeadersVisualStyles = False
        Me.mGridRelatorios.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mGridRelatorios.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mGridRelatorios.Location = New System.Drawing.Point(21, 273)
        Me.mGridRelatorios.Name = "mGridRelatorios"
        Me.mGridRelatorios.ReadOnly = True
        Me.mGridRelatorios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mGridRelatorios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.mGridRelatorios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mGridRelatorios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mGridRelatorios.Size = New System.Drawing.Size(1218, 322)
        Me.mGridRelatorios.TabIndex = 93
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroPanel3.Controls.Add(Me.lbValorTotal)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel3.Controls.Add(Me.lbTot)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel20)
        Me.MetroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(0, 827)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(1350, 20)
        Me.MetroPanel3.TabIndex = 94
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'lbValorTotal
        '
        Me.lbValorTotal.AutoSize = True
        Me.lbValorTotal.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbValorTotal.ForeColor = System.Drawing.Color.White
        Me.lbValorTotal.Location = New System.Drawing.Point(708, 2)
        Me.lbValorTotal.Name = "lbValorTotal"
        Me.lbValorTotal.Size = New System.Drawing.Size(17, 15)
        Me.lbValorTotal.TabIndex = 10
        Me.lbValorTotal.Text = "xx"
        Me.lbValorTotal.UseCustomBackColor = True
        Me.lbValorTotal.UseCustomForeColor = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.ForeColor = System.Drawing.Color.White
        Me.MetroLabel8.Location = New System.Drawing.Point(638, 2)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(64, 15)
        Me.MetroLabel8.TabIndex = 9
        Me.MetroLabel8.Text = "Valor Total :"
        Me.MetroLabel8.UseCustomBackColor = True
        Me.MetroLabel8.UseCustomForeColor = True
        '
        'lbTot
        '
        Me.lbTot.AutoSize = True
        Me.lbTot.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbTot.ForeColor = System.Drawing.Color.White
        Me.lbTot.Location = New System.Drawing.Point(198, 2)
        Me.lbTot.Name = "lbTot"
        Me.lbTot.Size = New System.Drawing.Size(17, 15)
        Me.lbTot.TabIndex = 8
        Me.lbTot.Text = "xx"
        Me.lbTot.UseCustomBackColor = True
        Me.lbTot.UseCustomForeColor = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel20.ForeColor = System.Drawing.Color.White
        Me.MetroLabel20.Location = New System.Drawing.Point(8, 2)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(187, 15)
        Me.MetroLabel20.TabIndex = 2
        Me.MetroLabel20.Text = "Número de Registros Encontrados :"
        Me.MetroLabel20.UseCustomBackColor = True
        Me.MetroLabel20.UseCustomForeColor = True
        '
        'Relatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 847)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.mGridRelatorios)
        Me.Controls.Add(Me.mbtImprimeRelatorio)
        Me.Controls.Add(Me.mbtGeraRelatorio)
        Me.Controls.Add(Me.gbplanoCon)
        Me.Controls.Add(Me.gbFavorecidos)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.gbContas)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MetroPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Relatorios"
        Me.Text = "Relatorios"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.gbplanoCon.ResumeLayout(False)
        Me.gbFavorecidos.ResumeLayout(False)
        Me.gbFavorecidos.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.gbContas.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.mGridRelatorios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlbNomeTela As MetroFramework.Controls.MetroLabel
    Friend WithEvents gbplanoCon As GroupBox
    Friend WithEvents tvPlanoContas As TreeView
    Friend WithEvents gbFavorecidos As GroupBox
    Friend WithEvents lbxFavorecidosChecked As ListBox
    Friend WithEvents tbPesquisaFavorecido As TextBox
    Friend WithEvents lbxFavorecidos As ListBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbCheque As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtbObs As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mtbDescricao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents metroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mrbAmbos2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mrbAberto As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mrbPago As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents clbxCenCustos As CheckedListBox
    Friend WithEvents gbContas As GroupBox
    Friend WithEvents clbxContas As CheckedListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents mrbAmbos As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mrbReceita As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mrbDespesa As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents mdtpVencInicial As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mdtpVencFinal As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mdtpPgtoFinal As MetroFramework.Controls.MetroDateTime
    Friend WithEvents mdtpPgtoInicial As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mbtGeraRelatorio As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtImprimeRelatorio As MetroFramework.Controls.MetroButton
    Friend WithEvents mGridRelatorios As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents lbValorTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbTot As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
End Class
