<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelecionarImovel
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
        Me.mGridimoveis = New MetroFramework.Controls.MetroGrid()
        Me.mtbPesquisar = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        CType(Me.mGridimoveis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mbtSair
        '
        Me.mbtSair.FlatAppearance.BorderSize = 0
        Me.mbtSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mbtSair.Image = Global.immobi.My.Resources.Resources.close___1511_1
        Me.mbtSair.Location = New System.Drawing.Point(1101, 17)
        Me.mbtSair.Name = "mbtSair"
        Me.mbtSair.Size = New System.Drawing.Size(38, 32)
        Me.mbtSair.TabIndex = 167
        Me.mbtSair.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 35)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Selecionar Imóvel"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(5, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 578)
        Me.Panel2.TabIndex = 163
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 589)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1140, 1)
        Me.Panel4.TabIndex = 162
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1145, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 579)
        Me.Panel1.TabIndex = 161
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1141, 6)
        Me.Panel3.TabIndex = 160
        '
        'pbBorderLeft1
        '
        Me.pbBorderLeft1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderLeft1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbBorderLeft1.Location = New System.Drawing.Point(0, 5)
        Me.pbBorderLeft1.Name = "pbBorderLeft1"
        Me.pbBorderLeft1.Size = New System.Drawing.Size(5, 585)
        Me.pbBorderLeft1.TabIndex = 159
        '
        'pbBorderbotom1
        '
        Me.pbBorderbotom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderbotom1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbBorderbotom1.Location = New System.Drawing.Point(0, 590)
        Me.pbBorderbotom1.Name = "pbBorderbotom1"
        Me.pbBorderbotom1.Size = New System.Drawing.Size(1146, 5)
        Me.pbBorderbotom1.TabIndex = 158
        '
        'pbBorderRight1
        '
        Me.pbBorderRight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderRight1.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbBorderRight1.Location = New System.Drawing.Point(1146, 5)
        Me.pbBorderRight1.Name = "pbBorderRight1"
        Me.pbBorderRight1.Size = New System.Drawing.Size(5, 590)
        Me.pbBorderRight1.TabIndex = 157
        '
        'pbBorderTop1
        '
        Me.pbBorderTop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbBorderTop1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pbBorderTop1.Location = New System.Drawing.Point(0, 0)
        Me.pbBorderTop1.Name = "pbBorderTop1"
        Me.pbBorderTop1.Size = New System.Drawing.Size(1151, 5)
        Me.pbBorderTop1.TabIndex = 156
        '
        'mGridimoveis
        '
        Me.mGridimoveis.AllowUserToAddRows = False
        Me.mGridimoveis.AllowUserToDeleteRows = False
        Me.mGridimoveis.AllowUserToResizeRows = False
        Me.mGridimoveis.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mGridimoveis.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mGridimoveis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.mGridimoveis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mGridimoveis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.mGridimoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.mGridimoveis.DefaultCellStyle = DataGridViewCellStyle2
        Me.mGridimoveis.EnableHeadersVisualStyles = False
        Me.mGridimoveis.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.mGridimoveis.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mGridimoveis.Location = New System.Drawing.Point(11, 105)
        Me.mGridimoveis.Name = "mGridimoveis"
        Me.mGridimoveis.ReadOnly = True
        Me.mGridimoveis.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mGridimoveis.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.mGridimoveis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mGridimoveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mGridimoveis.Size = New System.Drawing.Size(1128, 478)
        Me.mGridimoveis.TabIndex = 168
        '
        'mtbPesquisar
        '
        '
        '
        '
        Me.mtbPesquisar.CustomButton.Image = Nothing
        Me.mtbPesquisar.CustomButton.Location = New System.Drawing.Point(254, 1)
        Me.mtbPesquisar.CustomButton.Name = ""
        Me.mtbPesquisar.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.mtbPesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.mtbPesquisar.CustomButton.TabIndex = 1
        Me.mtbPesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.mtbPesquisar.CustomButton.UseSelectable = True
        Me.mtbPesquisar.CustomButton.Visible = False
        Me.mtbPesquisar.Lines = New String(-1) {}
        Me.mtbPesquisar.Location = New System.Drawing.Point(98, 76)
        Me.mtbPesquisar.MaxLength = 32767
        Me.mtbPesquisar.Name = "mtbPesquisar"
        Me.mtbPesquisar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mtbPesquisar.PromptText = "Filtrar por Código,  Rua, Bairro, Complemento ou Cidade"
        Me.mtbPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mtbPesquisar.SelectedText = ""
        Me.mtbPesquisar.SelectionLength = 0
        Me.mtbPesquisar.SelectionStart = 0
        Me.mtbPesquisar.ShortcutsEnabled = True
        Me.mtbPesquisar.ShowClearButton = True
        Me.mtbPesquisar.Size = New System.Drawing.Size(276, 23)
        Me.mtbPesquisar.TabIndex = 170
        Me.mtbPesquisar.UseSelectable = True
        Me.mtbPesquisar.WaterMark = "Filtrar por Código,  Rua, Bairro, Complemento ou Cidade"
        Me.mtbPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.mtbPesquisar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(17, 76)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel19.TabIndex = 169
        Me.MetroLabel19.Text = "Filtrar por :"
        '
        'SelecionarImovel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1151, 595)
        Me.Controls.Add(Me.mtbPesquisar)
        Me.Controls.Add(Me.MetroLabel19)
        Me.Controls.Add(Me.mGridimoveis)
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
        Me.Name = "SelecionarImovel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SelecionarImovel"
        CType(Me.mGridimoveis, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents mGridimoveis As MetroFramework.Controls.MetroGrid
    Friend WithEvents mtbPesquisar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
End Class
