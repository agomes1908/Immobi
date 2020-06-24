<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Favorecidos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.mlbNomeTela = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.PageCadastrar = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.mbtSalvar = New MetroFramework.Controls.MetroButton()
        Me.mtbNome = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.mtbEstado = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.mtbCidade = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.mtbNumero = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.mtbLogradouro = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.mtbEmail = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.mtbTel2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.mtbTel1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mtbBairro = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.PageListar = New MetroFramework.Controls.MetroTabPage()
        Me.mlbTotfavorecidos = New MetroFramework.Controls.MetroLabel()
        Me.mtbPesquisar = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.mGridFavorecidos = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.PageCadastrar.SuspendLayout()
        Me.PageListar.SuspendLayout()
        CType(Me.mGridFavorecidos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroPanel1.TabIndex = 0
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
        Me.mlbNomeTela.Size = New System.Drawing.Size(216, 25)
        Me.mlbNomeTela.TabIndex = 2
        Me.mlbNomeTela.Text = "Cadastrar Novo Favorecido"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroTabControl1)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 40)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(1350, 760)
        Me.MetroPanel2.TabIndex = 1
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.PageCadastrar)
        Me.MetroTabControl1.Controls.Add(Me.PageListar)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1350, 760)
        Me.MetroTabControl1.TabIndex = 2
        Me.MetroTabControl1.UseSelectable = True
        '
        'PageCadastrar
        '
        Me.PageCadastrar.Controls.Add(Me.MetroPanel3)
        Me.PageCadastrar.Controls.Add(Me.mbtSalvar)
        Me.PageCadastrar.Controls.Add(Me.mtbNome)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel9)
        Me.PageCadastrar.Controls.Add(Me.mtbEstado)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel7)
        Me.PageCadastrar.Controls.Add(Me.mtbCidade)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel8)
        Me.PageCadastrar.Controls.Add(Me.mtbNumero)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel6)
        Me.PageCadastrar.Controls.Add(Me.mtbLogradouro)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel5)
        Me.PageCadastrar.Controls.Add(Me.mtbEmail)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel2)
        Me.PageCadastrar.Controls.Add(Me.mtbTel2)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel4)
        Me.PageCadastrar.Controls.Add(Me.mtbTel1)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel3)
        Me.PageCadastrar.Controls.Add(Me.mtbBairro)
        Me.PageCadastrar.Controls.Add(Me.MetroLabel10)
        Me.PageCadastrar.HorizontalScrollbarBarColor = True
        Me.PageCadastrar.HorizontalScrollbarHighlightOnWheel = False
        Me.PageCadastrar.HorizontalScrollbarSize = 10
        Me.PageCadastrar.Location = New System.Drawing.Point(4, 38)
        Me.PageCadastrar.Name = "PageCadastrar"
        Me.PageCadastrar.Size = New System.Drawing.Size(1342, 718)
        Me.PageCadastrar.TabIndex = 0
        Me.PageCadastrar.Text = "Cadastrar"
        Me.PageCadastrar.UseVisualStyleBackColor = True
        Me.PageCadastrar.VerticalScrollbarBarColor = True
        Me.PageCadastrar.VerticalScrollbarHighlightOnWheel = False
        Me.PageCadastrar.VerticalScrollbarSize = 10
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(96, 181)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(297, 3)
        Me.MetroPanel3.TabIndex = 47
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'mbtSalvar
        '
        Me.mbtSalvar.Location = New System.Drawing.Point(139, 330)
        Me.mbtSalvar.Name = "mbtSalvar"
        Me.mbtSalvar.Size = New System.Drawing.Size(187, 30)
        Me.mbtSalvar.TabIndex = 10
        Me.mbtSalvar.Text = "Salvar"
        Me.mbtSalvar.UseSelectable = True
        '
        'mtbNome
        '
        '
        '
        '
        Me.mtbNome.CustomButton.Image = Nothing
        Me.mtbNome.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.mtbNome.CustomButton.Name = ""
        Me.mtbNome.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbNome.CustomButton.TabIndex = 1
        Me.mtbNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbNome.CustomButton.UseSelectable = True
        Me.mtbNome.CustomButton.Visible = False
        Me.mtbNome.Lines = New String(-1) {}
        Me.mtbNome.Location = New System.Drawing.Point(96, 43)
        Me.mtbNome.MaxLength = 32767
        Me.mtbNome.Name = "mtbNome"
        Me.mtbNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbNome.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbNome.SelectedText = ""
        Me.mtbNome.SelectionLength = 0
        Me.mtbNome.SelectionStart = 0
        Me.mtbNome.ShortcutsEnabled = True
        Me.mtbNome.ShowClearButton = True
        Me.mtbNome.Size = New System.Drawing.Size(187, 23)
        Me.mtbNome.TabIndex = 1
        Me.mtbNome.UseSelectable = True
        Me.mtbNome.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbNome.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(36, 43)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(53, 19)
        Me.MetroLabel9.TabIndex = 44
        Me.MetroLabel9.Text = "Nome :"
        '
        'mtbEstado
        '
        '
        '
        '
        Me.mtbEstado.CustomButton.Image = Nothing
        Me.mtbEstado.CustomButton.Location = New System.Drawing.Point(67, 1)
        Me.mtbEstado.CustomButton.Name = ""
        Me.mtbEstado.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbEstado.CustomButton.TabIndex = 1
        Me.mtbEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbEstado.CustomButton.UseSelectable = True
        Me.mtbEstado.CustomButton.Visible = False
        Me.mtbEstado.Lines = New String(-1) {}
        Me.mtbEstado.Location = New System.Drawing.Point(301, 264)
        Me.mtbEstado.MaxLength = 32767
        Me.mtbEstado.Name = "mtbEstado"
        Me.mtbEstado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbEstado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbEstado.SelectedText = ""
        Me.mtbEstado.SelectionLength = 0
        Me.mtbEstado.SelectionStart = 0
        Me.mtbEstado.ShortcutsEnabled = True
        Me.mtbEstado.ShowClearButton = True
        Me.mtbEstado.Size = New System.Drawing.Size(89, 23)
        Me.mtbEstado.TabIndex = 9
        Me.mtbEstado.UseSelectable = True
        Me.mtbEstado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbEstado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(240, 264)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel7.TabIndex = 42
        Me.MetroLabel7.Text = "Estado :"
        '
        'mtbCidade
        '
        '
        '
        '
        Me.mtbCidade.CustomButton.Image = Nothing
        Me.mtbCidade.CustomButton.Location = New System.Drawing.Point(93, 1)
        Me.mtbCidade.CustomButton.Name = ""
        Me.mtbCidade.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbCidade.CustomButton.TabIndex = 1
        Me.mtbCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbCidade.CustomButton.UseSelectable = True
        Me.mtbCidade.CustomButton.Visible = False
        Me.mtbCidade.Lines = New String(-1) {}
        Me.mtbCidade.Location = New System.Drawing.Point(96, 264)
        Me.mtbCidade.MaxLength = 32767
        Me.mtbCidade.Name = "mtbCidade"
        Me.mtbCidade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbCidade.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbCidade.SelectedText = ""
        Me.mtbCidade.SelectionLength = 0
        Me.mtbCidade.SelectionStart = 0
        Me.mtbCidade.ShortcutsEnabled = True
        Me.mtbCidade.ShowClearButton = True
        Me.mtbCidade.Size = New System.Drawing.Size(115, 23)
        Me.mtbCidade.TabIndex = 8
        Me.mtbCidade.UseSelectable = True
        Me.mtbCidade.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbCidade.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(31, 264)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel8.TabIndex = 40
        Me.MetroLabel8.Text = "Cidade :"
        '
        'mtbNumero
        '
        '
        '
        '
        Me.mtbNumero.CustomButton.Image = Nothing
        Me.mtbNumero.CustomButton.Location = New System.Drawing.Point(67, 1)
        Me.mtbNumero.CustomButton.Name = ""
        Me.mtbNumero.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbNumero.CustomButton.TabIndex = 1
        Me.mtbNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbNumero.CustomButton.UseSelectable = True
        Me.mtbNumero.CustomButton.Visible = False
        Me.mtbNumero.Lines = New String(-1) {}
        Me.mtbNumero.Location = New System.Drawing.Point(301, 235)
        Me.mtbNumero.MaxLength = 32767
        Me.mtbNumero.Name = "mtbNumero"
        Me.mtbNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbNumero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbNumero.SelectedText = ""
        Me.mtbNumero.SelectionLength = 0
        Me.mtbNumero.SelectionStart = 0
        Me.mtbNumero.ShortcutsEnabled = True
        Me.mtbNumero.ShowClearButton = True
        Me.mtbNumero.Size = New System.Drawing.Size(89, 23)
        Me.mtbNumero.TabIndex = 7
        Me.mtbNumero.UseSelectable = True
        Me.mtbNumero.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbNumero.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(230, 235)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel6.TabIndex = 38
        Me.MetroLabel6.Text = "Número :"
        '
        'mtbLogradouro
        '
        '
        '
        '
        Me.mtbLogradouro.CustomButton.Image = Nothing
        Me.mtbLogradouro.CustomButton.Location = New System.Drawing.Point(272, 1)
        Me.mtbLogradouro.CustomButton.Name = ""
        Me.mtbLogradouro.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbLogradouro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbLogradouro.CustomButton.TabIndex = 1
        Me.mtbLogradouro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbLogradouro.CustomButton.UseSelectable = True
        Me.mtbLogradouro.CustomButton.Visible = False
        Me.mtbLogradouro.Lines = New String(-1) {}
        Me.mtbLogradouro.Location = New System.Drawing.Point(96, 206)
        Me.mtbLogradouro.MaxLength = 32767
        Me.mtbLogradouro.Name = "mtbLogradouro"
        Me.mtbLogradouro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbLogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbLogradouro.SelectedText = ""
        Me.mtbLogradouro.SelectionLength = 0
        Me.mtbLogradouro.SelectionStart = 0
        Me.mtbLogradouro.ShortcutsEnabled = True
        Me.mtbLogradouro.ShowClearButton = True
        Me.mtbLogradouro.Size = New System.Drawing.Size(294, 23)
        Me.mtbLogradouro.TabIndex = 5
        Me.mtbLogradouro.UseSelectable = True
        Me.mtbLogradouro.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbLogradouro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(4, 206)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel5.TabIndex = 36
        Me.MetroLabel5.Text = "Logradouro :"
        '
        'mtbEmail
        '
        '
        '
        '
        Me.mtbEmail.CustomButton.Image = Nothing
        Me.mtbEmail.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.mtbEmail.CustomButton.Name = ""
        Me.mtbEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbEmail.CustomButton.TabIndex = 1
        Me.mtbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbEmail.CustomButton.UseSelectable = True
        Me.mtbEmail.CustomButton.Visible = False
        Me.mtbEmail.Lines = New String(-1) {}
        Me.mtbEmail.Location = New System.Drawing.Point(96, 130)
        Me.mtbEmail.MaxLength = 32767
        Me.mtbEmail.Name = "mtbEmail"
        Me.mtbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbEmail.SelectedText = ""
        Me.mtbEmail.SelectionLength = 0
        Me.mtbEmail.SelectionStart = 0
        Me.mtbEmail.ShortcutsEnabled = True
        Me.mtbEmail.ShowClearButton = True
        Me.mtbEmail.Size = New System.Drawing.Size(230, 23)
        Me.mtbEmail.TabIndex = 4
        Me.mtbEmail.UseSelectable = True
        Me.mtbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(42, 130)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel2.TabIndex = 34
        Me.MetroLabel2.Text = "Email :"
        '
        'mtbTel2
        '
        '
        '
        '
        Me.mtbTel2.CustomButton.Image = Nothing
        Me.mtbTel2.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.mtbTel2.CustomButton.Name = ""
        Me.mtbTel2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbTel2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbTel2.CustomButton.TabIndex = 1
        Me.mtbTel2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbTel2.CustomButton.UseSelectable = True
        Me.mtbTel2.CustomButton.Visible = False
        Me.mtbTel2.Lines = New String(-1) {}
        Me.mtbTel2.Location = New System.Drawing.Point(96, 101)
        Me.mtbTel2.MaxLength = 32767
        Me.mtbTel2.Name = "mtbTel2"
        Me.mtbTel2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbTel2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbTel2.SelectedText = ""
        Me.mtbTel2.SelectionLength = 0
        Me.mtbTel2.SelectionStart = 0
        Me.mtbTel2.ShortcutsEnabled = True
        Me.mtbTel2.ShowClearButton = True
        Me.mtbTel2.Size = New System.Drawing.Size(187, 23)
        Me.mtbTel2.TabIndex = 3
        Me.mtbTel2.UseSelectable = True
        Me.mtbTel2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbTel2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(15, 105)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel4.TabIndex = 32
        Me.MetroLabel4.Text = "Telefone 2 :"
        '
        'mtbTel1
        '
        '
        '
        '
        Me.mtbTel1.CustomButton.Image = Nothing
        Me.mtbTel1.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.mtbTel1.CustomButton.Name = ""
        Me.mtbTel1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbTel1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbTel1.CustomButton.TabIndex = 1
        Me.mtbTel1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbTel1.CustomButton.UseSelectable = True
        Me.mtbTel1.CustomButton.Visible = False
        Me.mtbTel1.Lines = New String(-1) {}
        Me.mtbTel1.Location = New System.Drawing.Point(96, 72)
        Me.mtbTel1.MaxLength = 32767
        Me.mtbTel1.Name = "mtbTel1"
        Me.mtbTel1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbTel1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbTel1.SelectedText = ""
        Me.mtbTel1.SelectionLength = 0
        Me.mtbTel1.SelectionStart = 0
        Me.mtbTel1.ShortcutsEnabled = True
        Me.mtbTel1.ShowClearButton = True
        Me.mtbTel1.Size = New System.Drawing.Size(187, 23)
        Me.mtbTel1.TabIndex = 2
        Me.mtbTel1.UseSelectable = True
        Me.mtbTel1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbTel1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 72)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel3.TabIndex = 30
        Me.MetroLabel3.Text = "Telefone 1 :"
        '
        'mtbBairro
        '
        '
        '
        '
        Me.mtbBairro.CustomButton.Image = Nothing
        Me.mtbBairro.CustomButton.Location = New System.Drawing.Point(93, 1)
        Me.mtbBairro.CustomButton.Name = ""
        Me.mtbBairro.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbBairro.CustomButton.TabIndex = 1
        Me.mtbBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbBairro.CustomButton.UseSelectable = True
        Me.mtbBairro.CustomButton.Visible = False
        Me.mtbBairro.Lines = New String(-1) {}
        Me.mtbBairro.Location = New System.Drawing.Point(96, 235)
        Me.mtbBairro.MaxLength = 32767
        Me.mtbBairro.Name = "mtbBairro"
        Me.mtbBairro.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbBairro.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbBairro.SelectedText = ""
        Me.mtbBairro.SelectionLength = 0
        Me.mtbBairro.SelectionStart = 0
        Me.mtbBairro.ShortcutsEnabled = True
        Me.mtbBairro.ShowClearButton = True
        Me.mtbBairro.Size = New System.Drawing.Size(115, 23)
        Me.mtbBairro.TabIndex = 6
        Me.mtbBairro.UseSelectable = True
        Me.mtbBairro.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbBairro.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(37, 235)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel10.TabIndex = 28
        Me.MetroLabel10.Text = "Bairro :"
        '
        'PageListar
        '
        Me.PageListar.Controls.Add(Me.mlbTotfavorecidos)
        Me.PageListar.Controls.Add(Me.mtbPesquisar)
        Me.PageListar.Controls.Add(Me.MetroLabel11)
        Me.PageListar.Controls.Add(Me.mGridFavorecidos)
        Me.PageListar.HorizontalScrollbarBarColor = True
        Me.PageListar.HorizontalScrollbarHighlightOnWheel = False
        Me.PageListar.HorizontalScrollbarSize = 10
        Me.PageListar.Location = New System.Drawing.Point(4, 38)
        Me.PageListar.Name = "PageListar"
        Me.PageListar.Size = New System.Drawing.Size(1342, 718)
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
        Me.mlbTotfavorecidos.Location = New System.Drawing.Point(1072, 40)
        Me.mlbTotfavorecidos.Name = "mlbTotfavorecidos"
        Me.mlbTotfavorecidos.Size = New System.Drawing.Size(172, 19)
        Me.mlbTotfavorecidos.TabIndex = 5
        Me.mlbTotfavorecidos.Text = "53 Favorecidos Encontrados"
        Me.mlbTotfavorecidos.UseCustomForeColor = True
        '
        'mtbPesquisar
        '
        '
        '
        '
        Me.mtbPesquisar.CustomButton.Image = Nothing
        Me.mtbPesquisar.CustomButton.Location = New System.Drawing.Point(312, 1)
        Me.mtbPesquisar.CustomButton.Name = ""
        Me.mtbPesquisar.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbPesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbPesquisar.CustomButton.TabIndex = 1
        Me.mtbPesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbPesquisar.CustomButton.UseSelectable = True
        Me.mtbPesquisar.CustomButton.Visible = False
        Me.mtbPesquisar.Lines = New String(-1) {}
        Me.mtbPesquisar.Location = New System.Drawing.Point(109, 20)
        Me.mtbPesquisar.MaxLength = 32767
        Me.mtbPesquisar.Name = "mtbPesquisar"
        Me.mtbPesquisar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbPesquisar.PromptText = "Filtrar por Nome, Rua, Bairro ou Cidade"
        Me.mtbPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbPesquisar.SelectedText = ""
        Me.mtbPesquisar.SelectionLength = 0
        Me.mtbPesquisar.SelectionStart = 0
        Me.mtbPesquisar.ShortcutsEnabled = True
        Me.mtbPesquisar.Size = New System.Drawing.Size(334, 23)
        Me.mtbPesquisar.TabIndex = 4
        Me.mtbPesquisar.UseSelectable = True
        Me.mtbPesquisar.WaterMark = "Filtrar por Nome, Rua, Bairro ou Cidade"
        Me.mtbPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbPesquisar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(8, 20)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel11.TabIndex = 3
        Me.MetroLabel11.Text = "Filtrar por :"
        '
        'mGridFavorecidos
        '
        Me.mGridFavorecidos.AllowUserToAddRows = False
        Me.mGridFavorecidos.AllowUserToDeleteRows = False
        Me.mGridFavorecidos.AllowUserToResizeRows = False
        Me.mGridFavorecidos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mGridFavorecidos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mGridFavorecidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mGridFavorecidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mGridFavorecidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.mGridFavorecidos.ColumnHeadersHeight = 25
        Me.mGridFavorecidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mGridFavorecidos.DefaultCellStyle = DataGridViewCellStyle2
        Me.mGridFavorecidos.EnableHeadersVisualStyles = False
        Me.mGridFavorecidos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mGridFavorecidos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mGridFavorecidos.Location = New System.Drawing.Point(8, 62)
        Me.mGridFavorecidos.Name = "mGridFavorecidos"
        Me.mGridFavorecidos.ReadOnly = True
        Me.mGridFavorecidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mGridFavorecidos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.mGridFavorecidos.RowHeadersWidth = 35
        Me.mGridFavorecidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.mGridFavorecidos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.mGridFavorecidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mGridFavorecidos.Size = New System.Drawing.Size(1265, 597)
        Me.mGridFavorecidos.TabIndex = 2
        '
        'Favorecidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 800)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Favorecidos"
        Me.Text = "favorecidos"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.PageCadastrar.ResumeLayout(False)
        Me.PageCadastrar.PerformLayout()
        Me.PageListar.ResumeLayout(False)
        Me.PageListar.PerformLayout()
        CType(Me.mGridFavorecidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlbNomeTela As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents PageCadastrar As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PageListar As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mGridFavorecidos As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mbtSalvar As MetroFramework.Controls.MetroButton
    Friend WithEvents mtbNome As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbEstado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbCidade As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbNumero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbLogradouro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbTel2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbTel1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbBairro As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbPesquisar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mlbTotfavorecidos As MetroFramework.Controls.MetroLabel
End Class
