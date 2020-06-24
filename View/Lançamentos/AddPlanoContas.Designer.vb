<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPlanoContas
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
        Me.pbBorderbotom1 = New System.Windows.Forms.Panel()
        Me.pbBorderRight1 = New System.Windows.Forms.Panel()
        Me.pbBorderTop1 = New System.Windows.Forms.Panel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.mbtInserir = New MetroFramework.Controls.MetroButton()
        Me.mtbNovoNode = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.mbtExcluir = New MetroFramework.Controls.MetroButton()
        Me.mbtAtualizar = New MetroFramework.Controls.MetroButton()
        Me.mbtEditar = New MetroFramework.Controls.MetroButton()
        Me.mtbDescricao = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tvPlanoContas = New System.Windows.Forms.TreeView()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'mbtSair
        '
        Me.mbtSair.FlatAppearance.BorderSize = 0
        Me.mbtSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mbtSair.Image = Global.immobi.My.Resources.Resources.close___1511_1
        Me.mbtSair.Location = New System.Drawing.Point(786, 17)
        Me.mbtSair.Name = "mbtSair"
        Me.mbtSair.Size = New System.Drawing.Size(38, 32)
        Me.mbtSair.TabIndex = 150
        Me.mbtSair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 35)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Cadastro de Plano de Contas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(5, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 509)
        Me.Panel2.TabIndex = 136
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 520)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(825, 1)
        Me.Panel4.TabIndex = 135
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(830, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 510)
        Me.Panel1.TabIndex = 134
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(826, 6)
        Me.Panel3.TabIndex = 133
        '
        'pbBorderLeft1
        '
        Me.pbBorderLeft1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderLeft1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbBorderLeft1.Location = New System.Drawing.Point(0, 5)
        Me.pbBorderLeft1.Name = "pbBorderLeft1"
        Me.pbBorderLeft1.Size = New System.Drawing.Size(5, 516)
        Me.pbBorderLeft1.TabIndex = 132
        '
        'pbBorderbotom1
        '
        Me.pbBorderbotom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderbotom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbBorderbotom1.Location = New System.Drawing.Point(0, 521)
        Me.pbBorderbotom1.Name = "pbBorderbotom1"
        Me.pbBorderbotom1.Size = New System.Drawing.Size(831, 5)
        Me.pbBorderbotom1.TabIndex = 131
        '
        'pbBorderRight1
        '
        Me.pbBorderRight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderRight1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbBorderRight1.Location = New System.Drawing.Point(831, 5)
        Me.pbBorderRight1.Name = "pbBorderRight1"
        Me.pbBorderRight1.Size = New System.Drawing.Size(5, 521)
        Me.pbBorderRight1.TabIndex = 130
        '
        'pbBorderTop1
        '
        Me.pbBorderTop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbBorderTop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbBorderTop1.Location = New System.Drawing.Point(0, 0)
        Me.pbBorderTop1.Name = "pbBorderTop1"
        Me.pbBorderTop1.Size = New System.Drawing.Size(836, 5)
        Me.pbBorderTop1.TabIndex = 129
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(496, 300)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(308, 3)
        Me.MetroPanel3.TabIndex = 160
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'mbtInserir
        '
        Me.mbtInserir.Location = New System.Drawing.Point(726, 371)
        Me.mbtInserir.Name = "mbtInserir"
        Me.mbtInserir.Size = New System.Drawing.Size(77, 23)
        Me.mbtInserir.TabIndex = 159
        Me.mbtInserir.Text = "Inserir"
        Me.mbtInserir.UseSelectable = True
        '
        'mtbNovoNode
        '
        '
        '
        '
        Me.mtbNovoNode.CustomButton.Image = Nothing
        Me.mtbNovoNode.CustomButton.Location = New System.Drawing.Point(202, 1)
        Me.mtbNovoNode.CustomButton.Name = ""
        Me.mtbNovoNode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbNovoNode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbNovoNode.CustomButton.TabIndex = 1
        Me.mtbNovoNode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbNovoNode.CustomButton.UseSelectable = True
        Me.mtbNovoNode.CustomButton.Visible = False
        Me.mtbNovoNode.Lines = New String(-1) {}
        Me.mtbNovoNode.Location = New System.Drawing.Point(496, 371)
        Me.mtbNovoNode.MaxLength = 32767
        Me.mtbNovoNode.Name = "mtbNovoNode"
        Me.mtbNovoNode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbNovoNode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbNovoNode.SelectedText = ""
        Me.mtbNovoNode.SelectionLength = 0
        Me.mtbNovoNode.SelectionStart = 0
        Me.mtbNovoNode.ShortcutsEnabled = True
        Me.mtbNovoNode.Size = New System.Drawing.Size(224, 23)
        Me.mtbNovoNode.TabIndex = 158
        Me.mtbNovoNode.UseSelectable = True
        Me.mtbNovoNode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbNovoNode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(496, 349)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel3.TabIndex = 157
        Me.MetroLabel3.Text = "Inserir Novo Abaixo"
        '
        'mbtExcluir
        '
        Me.mbtExcluir.Location = New System.Drawing.Point(579, 219)
        Me.mbtExcluir.Name = "mbtExcluir"
        Me.mbtExcluir.Size = New System.Drawing.Size(77, 23)
        Me.mbtExcluir.TabIndex = 156
        Me.mbtExcluir.Text = "Excluir"
        Me.mbtExcluir.UseSelectable = True
        '
        'mbtAtualizar
        '
        Me.mbtAtualizar.Location = New System.Drawing.Point(496, 219)
        Me.mbtAtualizar.Name = "mbtAtualizar"
        Me.mbtAtualizar.Size = New System.Drawing.Size(77, 23)
        Me.mbtAtualizar.TabIndex = 155
        Me.mbtAtualizar.Text = "Atualizar"
        Me.mbtAtualizar.UseSelectable = True
        '
        'mbtEditar
        '
        Me.mbtEditar.Location = New System.Drawing.Point(726, 190)
        Me.mbtEditar.Name = "mbtEditar"
        Me.mbtEditar.Size = New System.Drawing.Size(77, 23)
        Me.mbtEditar.TabIndex = 154
        Me.mbtEditar.Text = "Editar"
        Me.mbtEditar.UseSelectable = True
        '
        'mtbDescricao
        '
        '
        '
        '
        Me.mtbDescricao.CustomButton.Image = Nothing
        Me.mtbDescricao.CustomButton.Location = New System.Drawing.Point(202, 1)
        Me.mtbDescricao.CustomButton.Name = ""
        Me.mtbDescricao.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbDescricao.CustomButton.TabIndex = 1
        Me.mtbDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbDescricao.CustomButton.UseSelectable = True
        Me.mtbDescricao.CustomButton.Visible = False
        Me.mtbDescricao.Lines = New String(-1) {}
        Me.mtbDescricao.Location = New System.Drawing.Point(496, 190)
        Me.mtbDescricao.MaxLength = 32767
        Me.mtbDescricao.Name = "mtbDescricao"
        Me.mtbDescricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbDescricao.SelectedText = ""
        Me.mtbDescricao.SelectionLength = 0
        Me.mtbDescricao.SelectionStart = 0
        Me.mtbDescricao.ShortcutsEnabled = True
        Me.mtbDescricao.Size = New System.Drawing.Size(224, 23)
        Me.mtbDescricao.TabIndex = 153
        Me.mtbDescricao.UseSelectable = True
        Me.mtbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbDescricao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(496, 168)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel1.TabIndex = 152
        Me.MetroLabel1.Text = "Descrição"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel5.Controls.Add(Me.tvPlanoContas)
        Me.Panel5.Location = New System.Drawing.Point(35, 100)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(416, 383)
        Me.Panel5.TabIndex = 151
        '
        'tvPlanoContas
        '
        Me.tvPlanoContas.BackColor = System.Drawing.Color.White
        Me.tvPlanoContas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvPlanoContas.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvPlanoContas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tvPlanoContas.HideSelection = False
        Me.tvPlanoContas.Indent = 29
        Me.tvPlanoContas.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.tvPlanoContas.Location = New System.Drawing.Point(6, 6)
        Me.tvPlanoContas.Name = "tvPlanoContas"
        Me.tvPlanoContas.PathSeparator = "|"
        Me.tvPlanoContas.ShowNodeToolTips = True
        Me.tvPlanoContas.Size = New System.Drawing.Size(403, 370)
        Me.tvPlanoContas.TabIndex = 4
        '
        'AddPlanoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(836, 526)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.mbtInserir)
        Me.Controls.Add(Me.mtbNovoNode)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.mbtExcluir)
        Me.Controls.Add(Me.mbtAtualizar)
        Me.Controls.Add(Me.mbtEditar)
        Me.Controls.Add(Me.mtbDescricao)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.mbtSair)
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
        Me.Name = "AddPlanoContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddPlanoContas"
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mbtSair As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbBorderLeft1 As Panel
    Friend WithEvents pbBorderbotom1 As Panel
    Friend WithEvents pbBorderRight1 As Panel
    Friend WithEvents pbBorderTop1 As Panel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mbtInserir As MetroFramework.Controls.MetroButton
    Friend WithEvents mtbNovoNode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mbtExcluir As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtAtualizar As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtEditar As MetroFramework.Controls.MetroButton
    Friend WithEvents mtbDescricao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents tvPlanoContas As TreeView
End Class
