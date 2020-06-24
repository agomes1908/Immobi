Public Class MenuPrincipal

    'LOAD
    Private Sub MenuPrincipalMetro_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        'abrirFormPanel(New TelaInicial)
        mpnMenu.Focus()
    End Sub

    'CONTROLE FORMS
    Private Sub abrirFormPanel(ByVal formFilho As Object)

        If Me.mpnFormularios.Controls.Count > 0 Then 'verifica se já existe algo aberto no painel e fecha tudo 
            Me.mpnFormularios.Controls.RemoveAt(0)
        End If

        Dim ff As Form = TryCast(formFilho, Form) 'declara um variavel do tipo formulário que será igual ao formulário de entrada 

        ff.TopLevel = False
        ff.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        ff.Dock = DockStyle.Fill

        Me.mpnFormularios.Controls.Add(ff)
        Me.mpnFormularios.Tag = ff

        ff.Show()
    End Sub
    Public Sub Abrirfavorecido()
        abrirFormPanel(New Favorecidos)
    End Sub
    Public Sub AbrirContas()
        abrirFormPanel(New Contas)
    End Sub
    Public Sub AbrirCenCustos()
        abrirFormPanel(New CentroDeCustos)
    End Sub
    Public Sub AbrirPlanoContas()
        abrirFormPanel(New PlanoContas)
    End Sub


    ''MENU
    Private Sub MTileMenuCadastros_Click(sender As Object, e As EventArgs) Handles mTileMenuCadastros.Click
        Dim frm As New SubMenuCadastro
        AddOwnedForm(frm)
        frm.Show()
    End Sub

    Private Sub mTileMenuLancamentos_Click(sender As Object, e As EventArgs) Handles mTileMenuLancamentos.Click
        abrirFormPanel(New Lançamentos)
    End Sub

    Private Sub mTileMenuImoveis_Click(sender As Object, e As EventArgs) Handles mTileMenuImoveis.Click
        abrirFormPanel(New Imoveis)
    End Sub

    Private Sub mTileMenuRelatorios_Click(sender As Object, e As EventArgs) Handles mTileMenuRelatorios.Click
        abrirFormPanel(New Relatorios)
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) 
        abrirFormPanel(New TelaInicial)
    End Sub
End Class
