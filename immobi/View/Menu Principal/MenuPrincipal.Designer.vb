<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits MetroFramework.Forms.MetroForm

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
        Me.mpnMenu = New MetroFramework.Controls.MetroPanel()
        Me.mTileMenuRelatorios = New MetroFramework.Controls.MetroTile()
        Me.mTileMenuLancamentos = New MetroFramework.Controls.MetroTile()
        Me.mTileMenuImoveis = New MetroFramework.Controls.MetroTile()
        Me.mTileMenuCadastros = New MetroFramework.Controls.MetroTile()
        Me.mpnFormularios = New MetroFramework.Controls.MetroPanel()
        Me.mpnMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mpnMenu
        '
        Me.mpnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.mpnMenu.Controls.Add(Me.mTileMenuRelatorios)
        Me.mpnMenu.Controls.Add(Me.mTileMenuLancamentos)
        Me.mpnMenu.Controls.Add(Me.mTileMenuImoveis)
        Me.mpnMenu.Controls.Add(Me.mTileMenuCadastros)
        Me.mpnMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.mpnMenu.HorizontalScrollbarBarColor = True
        Me.mpnMenu.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnMenu.HorizontalScrollbarSize = 10
        Me.mpnMenu.Location = New System.Drawing.Point(20, 60)
        Me.mpnMenu.Name = "mpnMenu"
        Me.mpnMenu.Size = New System.Drawing.Size(1310, 46)
        Me.mpnMenu.TabIndex = 0
        Me.mpnMenu.UseCustomBackColor = True
        Me.mpnMenu.VerticalScrollbarBarColor = True
        Me.mpnMenu.VerticalScrollbarHighlightOnWheel = False
        Me.mpnMenu.VerticalScrollbarSize = 10
        '
        'mTileMenuRelatorios
        '
        Me.mTileMenuRelatorios.ActiveControl = Nothing
        Me.mTileMenuRelatorios.Location = New System.Drawing.Point(498, 0)
        Me.mTileMenuRelatorios.Name = "mTileMenuRelatorios"
        Me.mTileMenuRelatorios.Size = New System.Drawing.Size(123, 44)
        Me.mTileMenuRelatorios.TabIndex = 9
        Me.mTileMenuRelatorios.Text = "Relatórios"
        Me.mTileMenuRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mTileMenuRelatorios.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mTileMenuRelatorios.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mTileMenuRelatorios.UseSelectable = True
        '
        'mTileMenuLancamentos
        '
        Me.mTileMenuLancamentos.ActiveControl = Nothing
        Me.mTileMenuLancamentos.Location = New System.Drawing.Point(135, 1)
        Me.mTileMenuLancamentos.Name = "mTileMenuLancamentos"
        Me.mTileMenuLancamentos.Size = New System.Drawing.Size(171, 44)
        Me.mTileMenuLancamentos.TabIndex = 7
        Me.mTileMenuLancamentos.Text = "Entradas e Saídas"
        Me.mTileMenuLancamentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mTileMenuLancamentos.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mTileMenuLancamentos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mTileMenuLancamentos.UseSelectable = True
        '
        'mTileMenuImoveis
        '
        Me.mTileMenuImoveis.ActiveControl = Nothing
        Me.mTileMenuImoveis.Location = New System.Drawing.Point(304, 0)
        Me.mTileMenuImoveis.Name = "mTileMenuImoveis"
        Me.mTileMenuImoveis.Size = New System.Drawing.Size(195, 44)
        Me.mTileMenuImoveis.TabIndex = 8
        Me.mTileMenuImoveis.Text = "Imóveis e Contratos"
        Me.mTileMenuImoveis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mTileMenuImoveis.TileImage = Global.immobi.My.Resources.Resources.home___1391_1
        Me.mTileMenuImoveis.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mTileMenuImoveis.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mTileMenuImoveis.UseSelectable = True
        '
        'mTileMenuCadastros
        '
        Me.mTileMenuCadastros.ActiveControl = Nothing
        Me.mTileMenuCadastros.Location = New System.Drawing.Point(9, 1)
        Me.mTileMenuCadastros.Name = "mTileMenuCadastros"
        Me.mTileMenuCadastros.Size = New System.Drawing.Size(112, 44)
        Me.mTileMenuCadastros.TabIndex = 6
        Me.mTileMenuCadastros.Text = "Cadastros"
        Me.mTileMenuCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.mTileMenuCadastros.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mTileMenuCadastros.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mTileMenuCadastros.UseSelectable = True
        '
        'mpnFormularios
        '
        Me.mpnFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mpnFormularios.HorizontalScrollbarBarColor = True
        Me.mpnFormularios.HorizontalScrollbarHighlightOnWheel = False
        Me.mpnFormularios.HorizontalScrollbarSize = 10
        Me.mpnFormularios.Location = New System.Drawing.Point(20, 106)
        Me.mpnFormularios.Name = "mpnFormularios"
        Me.mpnFormularios.Size = New System.Drawing.Size(1310, 834)
        Me.mpnFormularios.TabIndex = 1
        Me.mpnFormularios.VerticalScrollbarBarColor = True
        Me.mpnFormularios.VerticalScrollbarHighlightOnWheel = False
        Me.mpnFormularios.VerticalScrollbarSize = 10
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 960)
        Me.Controls.Add(Me.mpnFormularios)
        Me.Controls.Add(Me.mpnMenu)
        Me.Name = "MenuPrincipal"
        Me.Text = "Sobreira Imóveis"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.mpnMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mpnMenu As MetroFramework.Controls.MetroPanel
    Friend WithEvents mTileMenuRelatorios As MetroFramework.Controls.MetroTile
    Friend WithEvents mTileMenuLancamentos As MetroFramework.Controls.MetroTile
    Friend WithEvents mTileMenuImoveis As MetroFramework.Controls.MetroTile
    Friend WithEvents mTileMenuCadastros As MetroFramework.Controls.MetroTile
    Friend WithEvents mpnFormularios As MetroFramework.Controls.MetroPanel
End Class
