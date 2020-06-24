Public Class Favorecidos

    Private access As New Controller
    Public nome As String


    ''SHOWN
    Private Sub favorecidos_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        access.ExecuteQuerry("SELECT código as CÓDIGO, 
                            nome as NOME,
                            logradouro as LOGRADOURO,
                            numero as NÚMERO, 
                            bairro AS BAIRRO,
                            cidade AS CIDADE,
                            uf AS ESTADO,
                            telefone1 AS [TELEFONE 1],
                            telefone2 as [TELEFONE 2],
                            email as EMAIL
                            FROM favorecidos order by nome asc")

        mGridFavorecidos.DataSource = access.dt
        mlbTotfavorecidos.Text = access.dt.Rows.Count & " Favorecidos Encontrados"

        MetroTabControl1.SelectTab(1)
        mtbPesquisar.Focus()

    End Sub

    ''MUDANÇA DE PÁGINA 
    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged

        If MetroTabControl1.SelectedIndex = 0 Then
            mlbNomeTela.Text = "Cadastrar Novo Favorecido"
            mtbNome.Focus()
        Else
            mlbNomeTela.Text = "Listar Todos Favorecido"
            mtbPesquisar.Focus()
        End If


    End Sub

    ''PAGE CADASTRAR ----------------------------------------------------------------------------------------

    ''VALIDAÇÃO
    Private Function validaCampos() As Integer
        Dim dt As DataTable = New DataTable
        access.ExecuteQuerry("SELECT nome FROM favorecidos")
        dt = access.dt
        For Each row As DataRow In dt.Rows
            If mtbNome.Text = row("nome") Then
                If row("nome") <> nome Then
                    MetroFramework.MetroMessageBox.Show(Me, "O favorecido " & mtbNome.Text & " já existe na base de dados, verifique ! ",
                                                        "Impossível Cadastrar !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return 1
                End If
            End If
        Next
        If mtbNome.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo NOME FAVORECIDO é obrigatório, verifique por favor. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return 1
        End If
        Return 0
    End Function
    ''CRUD
    Private Sub insertNovoFavorecido()

        access.AddParam("@nome", mtbNome.Text)
        access.AddParam("@log", mtbLogradouro.Text)
        access.AddParam("@num", mtbNumero.Text)
        access.AddParam("@bairro", mtbBairro.Text)
        access.AddParam("@cidade", mtbCidade.Text)
        access.AddParam("@uf", mtbEstado.Text)
        access.AddParam("@tel1", mtbTel1.Text)
        access.AddParam("@tel2", mtbTel2.Text)
        access.AddParam("@email", mtbEmail.Text)
        access.AddParam("@dataCad", Today())

        access.ExecuteQuerry("INSERT INTO favorecidos 
                                (nome, logradouro, numero, bairro, cidade, uf, telefone1, telefone2, email, data_cadastro) 
                                VALUES(@nome, @log, @num, @bairro, @cidade, @uf, @tel1, @tel2, @email, @dataCad)")
    End Sub
    Private Sub mbtSalvar_Click(sender As Object, e As EventArgs) Handles mbtSalvar.Click
        If validaCampos() Then
            Exit Sub
        End If

        insertNovoFavorecido()
        MetroFramework.MetroMessageBox.Show(Me, "Favorecido  " & mtbNome.Text & " salvo com sucesso ! ",
                                                        "Sucesso ! ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Utils.LimparForm(Me)
    End Sub

    ''PAGE LISTAR  ----------------------------------------------------------------------------------------

    ''MGRID FAVORECIDOS
    Public Sub AtualizaRegistro()
        access.ExecuteQuerry("SELECT código as CÓDIGO, 
                            nome as NOME,
                            logradouro as LOGRADOURO,
                            numero as NÚMERO, 
                            bairro AS BAIRRO,
                            cidade AS CIDADE,
                            uf AS ESTADO,
                            telefone1 AS [TELEFONE 1],
                            telefone2 as [TELEFONE 2],
                            email as EMAIL
                            FROM favorecidos order by nome asc")

        mGridFavorecidos.DataSource = access.dt

        mlbTotfavorecidos.Text = access.dt.Rows.Count & " Favorecidos Encontrados"

    End Sub
    Public Sub pPesquisa()
        access.ExecuteQuerry("SELECT código as CÓDIGO, 
                            nome as NOME,
                            logradouro as LOGRADOURO,
                            numero as NÚMERO, 
                            bairro AS BAIRRO,
                            cidade AS CIDADE,
                            uf AS ESTADO,
                            telefone1 AS [TELEFONE 1],
                            telefone2 as [TELEFONE 2],
                            email as EMAIL
                            FROM favorecidos where 
                            nome like '%" & mtbPesquisar.Text & "%' 
                            or logradouro like '%" & mtbPesquisar.Text & "%'
                            or bairro like '%" & mtbPesquisar.Text & "%'
                            or cidade like '%" & mtbPesquisar.Text & "%' order by nome asc")
        mGridFavorecidos.DataSource = access.dt
        mlbTotfavorecidos.Text = access.dt.Rows.Count & " Favorecidos Encontrados"

    End Sub
    Private Sub mGridFavorecidos_DoubleClick(sender As Object, e As EventArgs) Handles mGridFavorecidos.DoubleClick
        Dim frm As New AttFavorecidos
        AddOwnedForm(frm)
        frm.inicializador = mGridFavorecidos.CurrentRow.Cells(0).Value
        frm.Show()
    End Sub

    ''TBPESQUISAR
    Private Sub mtbPesquisar_TextChanged(sender As Object, e As EventArgs) Handles mtbPesquisar.TextChanged
        pPesquisa()
    End Sub

    ''FORMAT
    Private Sub mGridFavorecidos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles mGridFavorecidos.CellFormatting
        With mGridFavorecidos

            .Columns("CÓDIGO").Width = 60
            .Columns("CÓDIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("NOME").Width = 230
            .Columns("NOME").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("LOGRADOURO").Width = 230
            .Columns("LOGRADOURO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("NÚMERO").Width = 60
            .Columns("NÚMERO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("BAIRRO").Width = 80
            .Columns("BAIRRO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("CIDADE").Width = 90
            .Columns("CIDADE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("ESTADO").Width = 60
            .Columns("ESTADO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("TELEFONE 1").Width = 100
            .Columns("TELEFONE 1").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("TELEFONE 2").Width = 100
            .Columns("TELEFONE 2").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("EMAIL").Width = 200
            .Columns("EMAIL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

End Class