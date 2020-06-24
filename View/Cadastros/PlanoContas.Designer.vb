<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlanoContas
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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.mlbNomeTela = New MetroFramework.Controls.MetroLabel()
        Me.tvPlanoContas = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.mtbDescricao = New MetroFramework.Controls.MetroTextBox()
        Me.mbtEditar = New MetroFramework.Controls.MetroButton()
        Me.mbtAtualizar = New MetroFramework.Controls.MetroButton()
        Me.mbtExcluir = New MetroFramework.Controls.MetroButton()
        Me.mbtInserir = New MetroFramework.Controls.MetroButton()
        Me.mtbNovoNode = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.MetroPanel1.Size = New System.Drawing.Size(1274, 40)
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
        Me.mlbNomeTela.Size = New System.Drawing.Size(136, 25)
        Me.mlbNomeTela.TabIndex = 2
        Me.mlbNomeTela.Text = "Plano de Contas"
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
        Me.tvPlanoContas.Size = New System.Drawing.Size(480, 630)
        Me.tvPlanoContas.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.tvPlanoContas)
        Me.Panel1.Location = New System.Drawing.Point(23, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 642)
        Me.Panel1.TabIndex = 5
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(566, 71)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Descrição"
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
        Me.mtbDescricao.Location = New System.Drawing.Point(566, 93)
        Me.mtbDescricao.MaxLength = 32767
        Me.mtbDescricao.Name = "mtbDescricao"
        Me.mtbDescricao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbDescricao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbDescricao.SelectedText = ""
        Me.mtbDescricao.SelectionLength = 0
        Me.mtbDescricao.SelectionStart = 0
        Me.mtbDescricao.ShortcutsEnabled = True
        Me.mtbDescricao.Size = New System.Drawing.Size(224, 23)
        Me.mtbDescricao.TabIndex = 7
        Me.mtbDescricao.UseSelectable = True
        Me.mtbDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbDescricao.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mbtEditar
        '
        Me.mbtEditar.Location = New System.Drawing.Point(796, 93)
        Me.mbtEditar.Name = "mbtEditar"
        Me.mbtEditar.Size = New System.Drawing.Size(77, 23)
        Me.mbtEditar.TabIndex = 8
        Me.mbtEditar.Text = "Editar"
        Me.mbtEditar.UseSelectable = True
        '
        'mbtAtualizar
        '
        Me.mbtAtualizar.Location = New System.Drawing.Point(566, 122)
        Me.mbtAtualizar.Name = "mbtAtualizar"
        Me.mbtAtualizar.Size = New System.Drawing.Size(77, 23)
        Me.mbtAtualizar.TabIndex = 9
        Me.mbtAtualizar.Text = "Atualizar"
        Me.mbtAtualizar.UseSelectable = True
        '
        'mbtExcluir
        '
        Me.mbtExcluir.Location = New System.Drawing.Point(649, 122)
        Me.mbtExcluir.Name = "mbtExcluir"
        Me.mbtExcluir.Size = New System.Drawing.Size(77, 23)
        Me.mbtExcluir.TabIndex = 10
        Me.mbtExcluir.Text = "Excluir"
        Me.mbtExcluir.UseSelectable = True
        '
        'mbtInserir
        '
        Me.mbtInserir.Location = New System.Drawing.Point(796, 274)
        Me.mbtInserir.Name = "mbtInserir"
        Me.mbtInserir.Size = New System.Drawing.Size(77, 23)
        Me.mbtInserir.TabIndex = 15
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
        Me.mtbNovoNode.Location = New System.Drawing.Point(566, 274)
        Me.mtbNovoNode.MaxLength = 32767
        Me.mtbNovoNode.Name = "mtbNovoNode"
        Me.mtbNovoNode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbNovoNode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbNovoNode.SelectedText = ""
        Me.mtbNovoNode.SelectionLength = 0
        Me.mtbNovoNode.SelectionStart = 0
        Me.mtbNovoNode.ShortcutsEnabled = True
        Me.mtbNovoNode.Size = New System.Drawing.Size(224, 23)
        Me.mtbNovoNode.TabIndex = 14
        Me.mtbNovoNode.UseSelectable = True
        Me.mtbNovoNode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbNovoNode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(566, 252)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel3.TabIndex = 13
        Me.MetroLabel3.Text = "Inserir Novo Abaixo"
        '
        'MetroPanel3
        '
        Me.MetroPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(566, 203)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(308, 3)
        Me.MetroPanel3.TabIndex = 48
        Me.MetroPanel3.UseCustomBackColor = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'PlanoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1274, 884)
        Me.Controls.Add(Me.MetroPanel3)
        Me.Controls.Add(Me.mbtInserir)
        Me.Controls.Add(Me.mtbNovoNode)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.mbtExcluir)
        Me.Controls.Add(Me.mbtAtualizar)
        Me.Controls.Add(Me.mbtEditar)
        Me.Controls.Add(Me.mtbDescricao)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PlanoContas"
        Me.Text = "PlanoContas"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents mlbNomeTela As MetroFramework.Controls.MetroLabel
    Friend WithEvents tvPlanoContas As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents mtbDescricao As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mbtEditar As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtAtualizar As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtExcluir As MetroFramework.Controls.MetroButton
    Friend WithEvents mbtInserir As MetroFramework.Controls.MetroButton
    Friend WithEvents mtbNovoNode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
End Class
