<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttContas
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
        Me.mcbTipoConta = New MetroFramework.Controls.MetroComboBox()
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
        Me.SuspendLayout()
        '
        'mbtSair
        '
        Me.mbtSair.FlatAppearance.BorderSize = 0
        Me.mbtSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mbtSair.Image = Global.immobi.My.Resources.Resources.close___1511_1
        Me.mbtSair.Location = New System.Drawing.Point(538, 17)
        Me.mbtSair.Name = "mbtSair"
        Me.mbtSair.Size = New System.Drawing.Size(38, 32)
        Me.mbtSair.TabIndex = 119
        Me.mbtSair.UseVisualStyleBackColor = True
        '
        'mbtExcluir
        '
        Me.mbtExcluir.Location = New System.Drawing.Point(312, 308)
        Me.mbtExcluir.Name = "mbtExcluir"
        Me.mbtExcluir.Size = New System.Drawing.Size(133, 30)
        Me.mbtExcluir.TabIndex = 8
        Me.mbtExcluir.Text = "Excluir"
        Me.mbtExcluir.UseSelectable = True
        '
        'mbtAtualizar
        '
        Me.mbtAtualizar.Location = New System.Drawing.Point(151, 308)
        Me.mbtAtualizar.Name = "mbtAtualizar"
        Me.mbtAtualizar.Size = New System.Drawing.Size(133, 30)
        Me.mbtAtualizar.TabIndex = 7
        Me.mbtAtualizar.Text = "Atualizar"
        Me.mbtAtualizar.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 35)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Cadastro de Contas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(5, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 396)
        Me.Panel2.TabIndex = 105
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 407)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(577, 1)
        Me.Panel4.TabIndex = 104
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(582, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 397)
        Me.Panel1.TabIndex = 103
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(578, 6)
        Me.Panel3.TabIndex = 102
        '
        'pbBorderLeft1
        '
        Me.pbBorderLeft1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderLeft1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbBorderLeft1.Location = New System.Drawing.Point(0, 5)
        Me.pbBorderLeft1.Name = "pbBorderLeft1"
        Me.pbBorderLeft1.Size = New System.Drawing.Size(5, 403)
        Me.pbBorderLeft1.TabIndex = 101
        '
        'pbBorderbotom1
        '
        Me.pbBorderbotom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderbotom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbBorderbotom1.Location = New System.Drawing.Point(0, 408)
        Me.pbBorderbotom1.Name = "pbBorderbotom1"
        Me.pbBorderbotom1.Size = New System.Drawing.Size(583, 5)
        Me.pbBorderbotom1.TabIndex = 100
        '
        'pbBorderRight1
        '
        Me.pbBorderRight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderRight1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbBorderRight1.Location = New System.Drawing.Point(583, 5)
        Me.pbBorderRight1.Name = "pbBorderRight1"
        Me.pbBorderRight1.Size = New System.Drawing.Size(5, 408)
        Me.pbBorderRight1.TabIndex = 99
        '
        'pbBorderTop1
        '
        Me.pbBorderTop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbBorderTop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbBorderTop1.Location = New System.Drawing.Point(0, 0)
        Me.pbBorderTop1.Name = "pbBorderTop1"
        Me.pbBorderTop1.Size = New System.Drawing.Size(588, 5)
        Me.pbBorderTop1.TabIndex = 98
        '
        'mcbTipoConta
        '
        Me.mcbTipoConta.FormattingEnabled = True
        Me.mcbTipoConta.ItemHeight = 23
        Me.mcbTipoConta.Items.AddRange(New Object() {"Conta Corrente", "Poupança", "Caixinha"})
        Me.mcbTipoConta.Location = New System.Drawing.Point(226, 87)
        Me.mcbTipoConta.Name = "mcbTipoConta"
        Me.mcbTipoConta.Size = New System.Drawing.Size(213, 29)
        Me.mcbTipoConta.TabIndex = 1
        Me.mcbTipoConta.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(115, 93)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel9.TabIndex = 130
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
        Me.mtbDescricao.Location = New System.Drawing.Point(226, 209)
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
        Me.MetroLabel5.Location = New System.Drawing.Point(155, 209)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel5.TabIndex = 128
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
        Me.mtbInstituicao.Location = New System.Drawing.Point(226, 180)
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
        Me.MetroLabel2.Location = New System.Drawing.Point(151, 180)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel2.TabIndex = 126
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
        Me.mtbNConta.Location = New System.Drawing.Point(226, 151)
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
        Me.MetroLabel4.Location = New System.Drawing.Point(134, 151)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel4.TabIndex = 124
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
        Me.mtbAgencia.Location = New System.Drawing.Point(226, 122)
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
        Me.MetroLabel3.Location = New System.Drawing.Point(157, 122)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel3.TabIndex = 122
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
        Me.mtbSaldoInicial.Location = New System.Drawing.Point(226, 238)
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
        Me.MetroLabel10.Location = New System.Drawing.Point(135, 238)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(83, 19)
        Me.MetroLabel10.TabIndex = 120
        Me.MetroLabel10.Text = "Saldo Atual :"
        '
        'AttContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(588, 413)
        Me.Controls.Add(Me.mcbTipoConta)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.mtbDescricao)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.mtbInstituicao)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.mtbNConta)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.mtbAgencia)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.mtbSaldoInicial)
        Me.Controls.Add(Me.MetroLabel10)
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
        Me.Name = "AttContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AttContas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents mcbTipoConta As MetroFramework.Controls.MetroComboBox
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
End Class
