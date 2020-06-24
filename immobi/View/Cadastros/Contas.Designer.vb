<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contas
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
        Me.MtcContas = New MetroFramework.Controls.MetroTabControl()
        Me.PageCadastrar = New MetroFramework.Controls.MetroTabPage()
        Me.mcbTipoConta = New MetroFramework.Controls.MetroComboBox()
        Me.mbtSalvar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.mtbDescricao = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.mtbInstituicao = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mtbNConta = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mtbAgencia = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mtbSaldoInicial = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.PageListar = New MetroFramework.Controls.MetroTabPage()
        Me.mlbTotfavorecidos = New MetroFramework.Controls.MetroLabel()
        Me.mGridContas = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel1.SuspendLayout()
        Me.MtcContas.SuspendLayout()
        Me.PageCadastrar.SuspendLayout()
        Me.PageListar.SuspendLayout()
        CType(Me.mGridContas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroPanel1.Size = New System.Drawing.Size(1263, 40)
        Me.MetroPanel1.TabIndex = 1
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
        Me.mlbNomeTela.Size = New System.Drawing.Size(179, 25)
        Me.mlbNomeTela.TabIndex = 2
        Me.mlbNomeTela.Text = "Cadastrar Nova Conta"
        '
        'MtcContas
        '
        Me.MtcContas.Controls.Add(Me.PageCadastrar)
        Me.MtcContas.Controls.Add(Me.PageListar)
        Me.MtcContas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MtcContas.Location = New System.Drawing.Point(0, 40)
        Me.MtcContas.Name = "MtcContas"
        Me.MtcContas.SelectedIndex = 1
        Me.MtcContas.Size = New System.Drawing.Size(1263, 847)
        Me.MtcContas.TabIndex = 3
        Me.MtcContas.UseSelectable = True
        '
        'PageCadastrar
        '
        Me.PageCadastrar.Controls.Add(Me.mcbTipoConta)
        Me.PageCadastrar.Controls.Add(Me.mbtSalvar)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel9)
        Me.PageCadastrar.Controls.Add(Me.mtbDescricao)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel5)
        Me.PageCadastrar.Controls.Add(Me.mtbInstituicao)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel2)
        Me.PageCadastrar.Controls.Add(Me.mtbNConta)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel4)
        Me.PageCadastrar.Controls.Add(Me.mtbAgencia)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel3)
        Me.PageCadastrar.Controls.Add(Me.mtbSaldoInicial)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel10)
        Me.PageCadastrar.HorizontalScrollbarBarColor = True
        Me.PageCadastrar.HorizontalScrollbarHighlightOnWheel = False
        Me.PageCadastrar.HorizontalScrollbarSize = 10
        Me.PageCadastrar.Location = New System.Drawing.Point(4, 38)
        Me.PageCadastrar.Name = "PageCadastrar"
        Me.PageCadastrar.Size = New System.Drawing.Size(1255, 805)
        Me.PageCadastrar.TabIndex = 0
        Me.PageCadastrar.Text = "Cadastrar"
        Me.PageCadastrar.UseVisualStyleBackColor = True
        Me.PageCadastrar.VerticalScrollbarBarColor = True
        Me.PageCadastrar.VerticalScrollbarHighlightOnWheel = False
        Me.PageCadastrar.VerticalScrollbarSize = 10
        '
        'mcbTipoConta
        '
        Me.mcbTipoConta.FormattingEnabled = True
        Me.mcbTipoConta.ItemHeight = 23
        Me.mcbTipoConta.Items.AddRange(New Object() {"Conta Corrente", "Poupança", "Caixinha"})
        Me.mcbTipoConta.Location = New System.Drawing.Point(147, 37)
        Me.mcbTipoConta.Name = "mcbTipoConta"
        Me.mcbTipoConta.Size = New System.Drawing.Size(213, 29)
        Me.mcbTipoConta.TabIndex = 1
        Me.mcbTipoConta.UseSelectable = True
        '
        'mbtSalvar
        '
        Me.mbtSalvar.Location = New System.Drawing.Point(147, 235)
        Me.mbtSalvar.Name = "mbtSalvar"
        Me.mbtSalvar.Size = New System.Drawing.Size(187, 30)
        Me.mbtSalvar.TabIndex = 7
        Me.mbtSalvar.Text = "Salvar"
        Me.mbtSalvar.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(36, 43)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel9.TabIndex = 44
        Me.MetroLabel9.Text = "Tipo de Contas :"
        '
        'mtbDescricao
        '
        '
        '
        '
        Me.mtbDescricao.CustomButton.Image = Nothing
        Me.mtbDescricao.CustomButton.Location = New System.Drawing.Point(191, 1)
        Me.mtbDescricao.CustomButton.Name = ""
        Me.mtbDescricao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbDescricao.CustomButton.TabIndex = 1
        Me.mtbDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbDescricao.CustomButton.UseSelectable = True
        Me.mtbDescricao.CustomButton.Visible = False
        Me.mtbDescricao.Lines = New String(-1) {}
        Me.mtbDescricao.Location = New System.Drawing.Point(147, 159)
        Me.mtbDescricao.MaxLength = 32767
        Me.mtbDescricao.Name = "mtbDescricao"
        Me.mtbDescricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbDescricao.SelectedText = ""
        Me.mtbDescricao.SelectionLength = 0
        Me.mtbDescricao.SelectionStart = 0
        Me.mtbDescricao.ShortcutsEnabled = True
        Me.mtbDescricao.ShowClearButton = True
        Me.mtbDescricao.Size = New System.Drawing.Size(213, 23)
        Me.mtbDescricao.TabIndex = 5
        Me.mtbDescricao.UseSelectable = True
        Me.mtbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbDescricao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(76, 159)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel5.TabIndex = 36
        Me.MetroLabel5.Text = "Descrição"
        '
        'mtbInstituicao
        '
        '
        '
        '
        Me.mtbInstituicao.CustomButton.Image = Nothing
        Me.mtbInstituicao.CustomButton.Location = New System.Drawing.Point(191, 1)
        Me.mtbInstituicao.CustomButton.Name = ""
        Me.mtbInstituicao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbInstituicao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbInstituicao.CustomButton.TabIndex = 1
        Me.mtbInstituicao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbInstituicao.CustomButton.UseSelectable = True
        Me.mtbInstituicao.CustomButton.Visible = False
        Me.mtbInstituicao.Lines = New String(-1) {}
        Me.mtbInstituicao.Location = New System.Drawing.Point(147, 130)
        Me.mtbInstituicao.MaxLength = 32767
        Me.mtbInstituicao.Name = "mtbInstituicao"
        Me.mtbInstituicao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbInstituicao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbInstituicao.SelectedText = ""
        Me.mtbInstituicao.SelectionLength = 0
        Me.mtbInstituicao.SelectionStart = 0
        Me.mtbInstituicao.ShortcutsEnabled = True
        Me.mtbInstituicao.ShowClearButton = True
        Me.mtbInstituicao.Size = New System.Drawing.Size(213, 23)
        Me.mtbInstituicao.TabIndex = 4
        Me.mtbInstituicao.UseSelectable = True
        Me.mtbInstituicao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbInstituicao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(72, 130)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel2.TabIndex = 34
        Me.MetroLabel2.Text = "Instituição:"
        '
        'mtbNConta
        '
        '
        '
        '
        Me.mtbNConta.CustomButton.Image = Nothing
        Me.mtbNConta.CustomButton.Location = New System.Drawing.Point(95, 1)
        Me.mtbNConta.CustomButton.Name = ""
        Me.mtbNConta.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbNConta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbNConta.CustomButton.TabIndex = 1
        Me.mtbNConta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbNConta.CustomButton.UseSelectable = True
        Me.mtbNConta.CustomButton.Visible = False
        Me.mtbNConta.Lines = New String(-1) {}
        Me.mtbNConta.Location = New System.Drawing.Point(147, 101)
        Me.mtbNConta.MaxLength = 32767
        Me.mtbNConta.Name = "mtbNConta"
        Me.mtbNConta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbNConta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbNConta.SelectedText = ""
        Me.mtbNConta.SelectionLength = 0
        Me.mtbNConta.SelectionStart = 0
        Me.mtbNConta.ShortcutsEnabled = True
        Me.mtbNConta.ShowClearButton = True
        Me.mtbNConta.Size = New System.Drawing.Size(117, 23)
        Me.mtbNConta.TabIndex = 3
        Me.mtbNConta.UseSelectable = True
        Me.mtbNConta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbNConta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(55, 101)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel4.TabIndex = 32
        Me.MetroLabel4.Text = "Nº da Conta:"
        '
        'mtbAgencia
        '
        '
        '
        '
        Me.mtbAgencia.CustomButton.Image = Nothing
        Me.mtbAgencia.CustomButton.Location = New System.Drawing.Point(95, 1)
        Me.mtbAgencia.CustomButton.Name = ""
        Me.mtbAgencia.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbAgencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbAgencia.CustomButton.TabIndex = 1
        Me.mtbAgencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbAgencia.CustomButton.UseSelectable = True
        Me.mtbAgencia.CustomButton.Visible = False
        Me.mtbAgencia.Lines = New String(-1) {}
        Me.mtbAgencia.Location = New System.Drawing.Point(147, 72)
        Me.mtbAgencia.MaxLength = 32767
        Me.mtbAgencia.Name = "mtbAgencia"
        Me.mtbAgencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbAgencia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbAgencia.SelectedText = ""
        Me.mtbAgencia.SelectionLength = 0
        Me.mtbAgencia.SelectionStart = 0
        Me.mtbAgencia.ShortcutsEnabled = True
        Me.mtbAgencia.ShowClearButton = True
        Me.mtbAgencia.Size = New System.Drawing.Size(117, 23)
        Me.mtbAgencia.TabIndex = 2
        Me.mtbAgencia.UseSelectable = True
        Me.mtbAgencia.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbAgencia.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(78, 72)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel3.TabIndex = 30
        Me.MetroLabel3.Text = "Agência :"
        '
        'mtbSaldoInicial
        '
        '
        '
        '
        Me.mtbSaldoInicial.CustomButton.Image = Nothing
        Me.mtbSaldoInicial.CustomButton.Location = New System.Drawing.Point(95, 1)
        Me.mtbSaldoInicial.CustomButton.Name = ""
        Me.mtbSaldoInicial.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbSaldoInicial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbSaldoInicial.CustomButton.TabIndex = 1
        Me.mtbSaldoInicial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbSaldoInicial.CustomButton.UseSelectable = True
        Me.mtbSaldoInicial.CustomButton.Visible = False
        Me.mtbSaldoInicial.Lines = New String(-1) {}
        Me.mtbSaldoInicial.Location = New System.Drawing.Point(147, 188)
        Me.mtbSaldoInicial.MaxLength = 32767
        Me.mtbSaldoInicial.Name = "mtbSaldoInicial"
        Me.mtbSaldoInicial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbSaldoInicial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbSaldoInicial.SelectedText = ""
        Me.mtbSaldoInicial.SelectionLength = 0
        Me.mtbSaldoInicial.SelectionStart = 0
        Me.mtbSaldoInicial.ShortcutsEnabled = True
        Me.mtbSaldoInicial.ShowClearButton = True
        Me.mtbSaldoInicial.Size = New System.Drawing.Size(117, 23)
        Me.mtbSaldoInicial.TabIndex = 6
        Me.mtbSaldoInicial.UseSelectable = True
        Me.mtbSaldoInicial.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbSaldoInicial.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(56, 188)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel10.TabIndex = 28
        Me.MetroLabel10.Text = "Saldo Inicial :"
        '
        'PageListar
        '
        Me.PageListar.Controls.Add(Me.mlbTotfavorecidos)
        Me.PageListar.Controls.Add(Me.mGridContas)
        Me.PageListar.HorizontalScrollbarBarColor = True
        Me.PageListar.HorizontalScrollbarHighlightOnWheel = False
        Me.PageListar.HorizontalScrollbarSize = 10
        Me.PageListar.Location = New System.Drawing.Point(4, 38)
        Me.PageListar.Name = "PageListar"
        Me.PageListar.Size = New System.Drawing.Size(1255, 805)
        Me.PageListar.TabIndex = 1
        Me.PageListar.Text = "Listar"
        Me.PageListar.VerticalScrollbarBarColor = True
        Me.PageListar.VerticalScrollbarHighlightOnWheel = False
        Me.PageListar.VerticalScrollbarSize = 10
        '
        'mlbTotfavorecidos
        '
        Me.mlbTotfavorecidos.AutoSize = True
        Me.mlbTotfavorecidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.mlbTotfavorecidos.Location = New System.Drawing.Point(768, 9)
        Me.mlbTotfavorecidos.Name = "mlbTotfavorecidos"
        Me.mlbTotfavorecidos.Size = New System.Drawing.Size(172, 19)
        Me.mlbTotfavorecidos.TabIndex = 5
        Me.mlbTotfavorecidos.Text = "53 Favorecidos Encontrados"
        Me.mlbTotfavorecidos.UseCustomForeColor = True
        '
        'mGridContas
        '
        Me.mGridContas.AllowUserToAddRows = False
        Me.mGridContas.AllowUserToDeleteRows = False
        Me.mGridContas.AllowUserToResizeRows = False
        Me.mGridContas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mGridContas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mGridContas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mGridContas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mGridContas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.mGridContas.ColumnHeadersHeight = 25
        Me.mGridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mGridContas.DefaultCellStyle = DataGridViewCellStyle2
        Me.mGridContas.EnableHeadersVisualStyles = False
        Me.mGridContas.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mGridContas.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mGridContas.Location = New System.Drawing.Point(3, 31)
        Me.mGridContas.Name = "mGridContas"
        Me.mGridContas.ReadOnly = True
        Me.mGridContas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mGridContas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.mGridContas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mGridContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mGridContas.Size = New System.Drawing.Size(1043, 606)
        Me.mGridContas.TabIndex = 2
        '
        'Contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1263, 887)
        Me.Controls.Add(Me.MtcContas)
        Me.Controls.Add(Me.MetroPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Contas"
        Me.Text = "Contas"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MtcContas.ResumeLayout(False)
        Me.PageCadastrar.ResumeLayout(False)
        Me.PageCadastrar.PerformLayout()
        Me.PageListar.ResumeLayout(False)
        Me.PageListar.PerformLayout()
        CType(Me.mGridContas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlbNomeTela As MetroFramework.Controls.MetroLabel
    Friend WithEvents MtcContas As MetroFramework.Controls.MetroTabControl
    Friend WithEvents PageCadastrar As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mcbTipoConta As MetroFramework.Controls.MetroComboBox
    Friend WithEvents mbtSalvar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbDescricao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbInstituicao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbNConta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbAgencia As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbSaldoInicial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PageListar As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mlbTotfavorecidos As MetroFramework.Controls.MetroLabel
    Friend WithEvents mGridContas As MetroFramework.Controls.MetroGrid
End Class
