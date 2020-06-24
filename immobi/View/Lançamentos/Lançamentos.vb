Public Class Lançamentos
    Private Access As New Controller
    Public Abertura As Integer = 1  '' 1-add 0-editar
    Public cod_lanc As Integer
    Public cod_conta As Integer
    Dim eventsTbOrigem As Boolean = False
    Dim eventsTbDestino As Boolean = False



    ''SHOW
    Private Sub Lançamentos_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        mlbCodigoImovel1.Text = ""
        mlbCodigoImovel2.Text = ""
        MetroTabControl1.SelectTab(0)

        CarregaAddLancamentos()


        'preencheTV()



        'rbReceita.Checked = True
        'rbPago.Checked = True
        'tbSaldoAtual.Text = ""

        'If Abertura Then
        '    btApagar.Visible = False

        'Else
        '    Label13.Text = "Editar Lançamento"

        '    preencheEditar()
        '    GroupBox3.Enabled = False
        'End If

    End Sub

    ''ADD LANÇAMENTO -------------------------------------------------------------------------------------------------------------------------------

    ''CARREGA COMBOBOX
    Public Sub preencheCBBFavorecidos()
        Dim dt As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT * from favorecidos order by nome ASC")
        dt = Access.dt

        With cbbFavorecido
            .DataSource = dt
            .DisplayMember = "nome"
            .ValueMember = "Código"
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        cbbFavorecido.Text = ""
    End Sub
    Public Sub preencheCBBCenCusto()
        Dim dt As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT * FROM cenCusto")
        dt = Access.dt

        With cbbCentroCus
            .DataSource = dt
            .DisplayMember = "descricao"
            .ValueMember = "Código"
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        cbbCentroCus.Text = ""
    End Sub
    Public Sub preencheCBBCategoria()
        Dim dt As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT * FROM planoContas")
        dt = Access.dt

        With cbbCategoria
            .DataSource = dt
            .DisplayMember = "descricao"
            .ValueMember = "Código"
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        cbbCategoria.Text = ""
    End Sub
    Public Sub preencheCBBConta()
        Dim dt As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT Código, num_conta & ' - ' & descricao as d FROM conta")
        dt = Access.dt

        With cbbConta
            .DataSource = dt
            .DisplayMember = "d"
            .ValueMember = "Código"
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        cbbConta.Text = ""
    End Sub

    ''TREEVIEW
    Public Sub preencheTV()
        Dim dt As DataTable = New DataTable
        Dim nodePAI As Integer = 0
        Dim nodeFILHO As Integer = 0

        Access.ExecuteQuerry("SELECT * FROM planoContas")

        dt = Access.dt
        tvPlanoContas.Nodes.Clear()

        For Each rowN1 As DataRow In dt.Rows
            If rowN1("nivel") = 0 Then
                tvPlanoContas.Nodes.Add(rowN1("descricao"))
                For Each rowN2 As DataRow In dt.Rows
                    If rowN2("superior") = rowN1("código") And rowN2("nivel") = 1 Then
                        tvPlanoContas.Nodes(nodePAI).Nodes.Add(rowN2("descricao"))
                        For Each rowN3 As DataRow In dt.Rows
                            If rowN3("superior") = rowN2("código") And rowN3("nivel") = 2 Then
                                tvPlanoContas.Nodes(nodePAI).Nodes(nodeFILHO).Nodes.Add(rowN3("descricao"))
                            End If
                        Next
                        nodeFILHO += 1
                    End If
                Next
                nodePAI += 1
                nodeFILHO = 0
            End If
        Next
    End Sub
    Private Sub tvPlanoContas_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvPlanoContas.AfterSelect
        cbbCategoria.Text = e.Node.Text
    End Sub

    ''CHAMAR CADASTROS
    Private Sub mbtNovoFavorecido_Click(sender As Object, e As EventArgs) Handles mbtNovoFavorecido.Click
        Dim frm As New AddFavorecido
        AddOwnedForm(frm)
        frm.Show()
    End Sub
    Private Sub btNovaCategoria_Click(sender As Object, e As EventArgs) Handles btNovaCategoria.Click
        Dim frm As New AddPlanoContas
        AddOwnedForm(frm)
        frm.Show()
    End Sub
    Private Sub mbtReferenciarImovel_Click(sender As Object, e As EventArgs) Handles mbtReferenciarImovel.Click
        Dim frm As New SelecionarImovel
        AddOwnedForm(frm)
        frm.inicializador = 2
        frm.Show()
    End Sub

    ''RADIO BUTTON
    Private Sub mrbEmAberto_CheckedChanged(sender As Object, e As EventArgs)

        If mrbAberto.Checked = True Then
            mdtPagamento.Enabled = False
            mlbPagamento.Enabled = False
            mlbPagamento.ForeColor = Color.DarkGray
        ElseIf mrbPago.Checked = True Then
            mdtPagamento.Enabled = True
            mlbPagamento.Enabled = True
            mlbPagamento.ForeColor = Color.Black
        End If
    End Sub

    ''VALIDAÇOES
    Private Sub mtbValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbValor.KeyPress
        If e.KeyChar = Chr(46) Then e.KeyChar = Chr(44)
        If e.KeyChar = Chr(44) And InStr(mtbValor.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(44) Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    Private Function validaCampos() As Integer

        If mrbReceitas.Checked = False And mrbDespesas.Checked = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Selecione RECEITA ou DESPESA ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return 1
        End If
        If mrbPago.Checked = False And mrbAberto.Checked = False Then
            MetroFramework.MetroMessageBox.Show(Me, "Selecione PAGO ou EM ABERTO ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return 1
        End If
        If DateTime.Compare(mdtVencimento.Text, mdtEmissao.Text) < 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "A data de VENCIMENTO não pode ser anterior a data de EMISSÃO. Verifique ! ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return 1
        End If
        If DateTime.Compare(mdtPagamento.Text, mdtEmissao.Text) < 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "A data de PAGAMENTO não pode ser anterior a data de EMISSÃO. Verifique ! ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return 1
        End If
        If cbbFavorecido.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo FAVORECIDOS deve ser preenchido!", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbFavorecido.Focus()
            Return 1

        End If
        If cbbCategoria.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo CATEGORIA deve ser preenchido!", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbCategoria.Focus()
            Return 1
        End If
        If cbbConta.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo CONTA deve ser preenchido!", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbConta.Focus()
            Return 1
        End If
        If cbbCentroCus.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo CENTRO DE CUSTOS deve ser preenchido!", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbCentroCus.Focus()
            Return 1
        End If
        If mtbValor.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo VALOR deve ser preenchido!", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            mtbValor.Focus()
            Return 1
        End If

        Dim dt As DataTable = New DataTable
        Dim favor As Boolean = False
        Dim dta As DataTable = New DataTable
        Dim favora As Boolean = False

        Access.ExecuteQuerry("SELECT nome FROM favorecidos")
        dt = Access.dt
        For Each row As DataRow In dt.Rows
            If cbbFavorecido.Text = row("nome") Then
                favor = True
            End If
        Next
        If Not favor Then
            MetroFramework.MetroMessageBox.Show(Me, "Não Existe nenhum favorecido com esse nome, verifique!", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            cbbFavorecido.Focus()
            Return 1
        End If

        Access.ExecuteQuerry("SELECT descricao FROM planoContas")
        dta = Access.dt
        For Each row As DataRow In dta.Rows
            If cbbCategoria.Text = row("descricao") Then
                favora = True
            End If
        Next
        If Not favora Then
            MetroFramework.MetroMessageBox.Show(Me, "Não Existe nenhum Plano de contas com esse nome, verifique!", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbCategoria.Focus()
            Return 1
        End If

        If cbbCategoria.Text = "Aluguel" Then
            MetroFramework.MetroMessageBox.Show(Me, "Não é possível fazer um lançamento de aluguel manual, entre em contato com o suporte !", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 1
        End If

        Return 0
    End Function

    ''CRUD
    Private Sub mbtSalvar_Click(sender As Object, e As EventArgs) Handles mbtSalvar.Click
        If validaCampos() Then
            Exit Sub
        End If

        If Abertura Then
            If mrbReceitas.Checked = True And mrbPago.Checked = True Then
                insertReceitaPago()
            ElseIf mrbReceitas.Checked = True And mrbAberto.Checked = True Then
                insertReceitaAberto()
            End If
            If mrbDespesas.Checked = True And mrbPago.Checked = True Then
                insertDespesaPago()
            ElseIf mrbDespesas.Checked = True And mrbAberto.Checked = True Then
                insertDespesaAberto()
            End If
            If MetroFramework.MetroMessageBox.Show(Me, "Deseja Limpar o Formulário ? ",
                                                "Lançamento realizado com sucesso! ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Utils.LimparForm(Me)
                mlbCodigoImovel1.Text = ""
                mlbCodigoImovel2.Text = ""
            End If
        Else
                'If rbReceita.Checked = True And rbPago.Checked = True Then

                '    updateReceita(cod_lanc, 1, cbbCentroCus.SelectedValue, cbbConta.SelectedValue, cbbCliente.SelectedValue,
                '                        cbbCategoria.SelectedValue, "Pago", tbDescricao.Text, dtpEmissao.Value, dtpVencimento.Value, dtpPgto.Value,
                '                        tbCheque.Text, tbValor.Text, tbObservacoes.Text, IIf(lbCodigoImovel.Text.Length > 0, lbCodigoImovel.Text, 0))
                'ElseIf rbReceita.Checked = True And rbAberto.Checked = True Then

                '    updateReceita(cod_lanc, 1, cbbCentroCus.SelectedValue, cbbConta.SelectedValue, cbbCliente.SelectedValue,
                '                        cbbCategoria.SelectedValue, "Em Aberto", tbDescricao.Text, dtpEmissao.Value, dtpVencimento.Value, dtpPgto.Value,
                '                        tbCheque.Text, tbValor.Text, tbObservacoes.Text, IIf(lbCodigoImovel.Text.Length > 0, lbCodigoImovel.Text, 0))
                'End If
                'If rbDespesa.Checked = True And rbPago.Checked = True Then

                '    updateDespesa(cod_lanc, 2, cbbCentroCus.SelectedValue, cbbConta.SelectedValue, cbbCliente.SelectedValue,
                '                        cbbCategoria.SelectedValue, "Pago", tbDescricao.Text, dtpEmissao.Value, dtpVencimento.Value, dtpPgto.Value,
                '                        tbCheque.Text, tbValor.Text, tbObservacoes.Text, IIf(lbCodigoImovel.Text.Length > 0, lbCodigoImovel.Text, 0))
                'ElseIf rbDespesa.Checked = True And rbAberto.Checked = True Then

                '    updateDespesa(cod_lanc, 2, cbbCentroCus.SelectedValue, cbbConta.SelectedValue, cbbCliente.SelectedValue,
                '                        cbbCategoria.SelectedValue, "Em Aberto", tbDescricao.Text, dtpEmissao.Value, dtpVencimento.Value, dtpPgto.Value,
                '                        tbCheque.Text, tbValor.Text, tbObservacoes.Text, IIf(lbCodigoImovel.Text.Length > 0, lbCodigoImovel.Text, 0))
                'End If
                MessageBox.Show("Atualização realizada com sucesso!")
            Me.Close()
        End If

        If mrbPago.Checked Then
            Utils.atualizaSaldoAtualConta(cbbConta.SelectedValue)
        End If

    End Sub
    Private Sub mbtLimpar_Click(sender As Object, e As EventArgs) Handles mbtLimpar.Click
        Utils.LimparForm(Me)
    End Sub

    ''INSERT BANCO
    Public Sub insertReceitaPago()

        If mlbCodigoImovel1.Text.Length > 0 Then

            Access.AddParam("@cod_cenCusto", cbbCentroCus.SelectedValue)
            Access.AddParam("@cod_conta", cbbConta.SelectedValue)
            Access.AddParam("@cod_inquilino", cbbFavorecido.SelectedValue)
            Access.AddParam("@cod_planoContas", cbbCategoria.SelectedValue)
            Access.AddParam("@descricao", mtbDescricao.Text)
            Access.AddParam("@data_emissao", mdtEmissao.Text)
            Access.AddParam("@data_vencimento", mdtVencimento.Text)
            Access.AddParam("@data_pagamento", mdtPagamento.Text)
            Access.AddParam("@n_cheque", mtbNCheque.Text)
            Access.AddParam("@valor", mtbValor.Text)
            Access.AddParam("@observacoes", mtbObservacoes.Text)
            Access.AddParam("@imovel", mlbCodigoImovel2.Text)

            Access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento,
                            data_pagamento, n_cheque, valor, observacoes, imovel) 
                                values (1,@cod_cenCusto,@cod_conta,@cod_inquilino,@cod_planoContas,'Pago',@descricao,
                            @data_emissao,  @data_vencimento, @data_pagamento, @n_cheque, @valor , @observacoes, @imovel)")
        Else
            Access.AddParam("@cod_cenCusto", cbbCentroCus.SelectedValue)
            Access.AddParam("@cod_conta", cbbConta.SelectedValue)
            Access.AddParam("@cod_inquilino", cbbFavorecido.SelectedValue)
            Access.AddParam("@cod_planoContas", cbbCategoria.SelectedValue)
            Access.AddParam("@descricao", mtbDescricao.Text)
            Access.AddParam("@data_emissao", mdtEmissao.Text)
            Access.AddParam("@data_vencimento", mdtVencimento.Text)
            Access.AddParam("@data_pagamento", mdtPagamento.Text)
            Access.AddParam("@n_cheque", mtbNCheque.Text)
            Access.AddParam("@valor", mtbValor.Text)
            Access.AddParam("@observacoes", mtbObservacoes.Text)

            Access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento,
                            data_pagamento, n_cheque, valor, observacoes) 
                                values (1,@cod_cenCusto,@cod_conta,@cod_inquilino,@cod_planoContas,'Pago',@descricao,
                            @data_emissao,  @data_vencimento, @data_pagamento, @n_cheque, @valor , @observacoes)")
        End If
    End Sub
    Public Sub insertReceitaAberto()

        If mlbCodigoImovel1.Text.Length > 0 Then

            Access.AddParam("@cod_cenCusto", cbbCentroCus.SelectedValue)
            Access.AddParam("@cod_conta", cbbConta.SelectedValue)
            Access.AddParam("@cod_inquilino", cbbFavorecido.SelectedValue)
            Access.AddParam("@cod_planoContas", cbbCategoria.SelectedValue)
            Access.AddParam("@descricao", mtbDescricao.Text)
            Access.AddParam("@data_emissao", mdtEmissao.Text)
            Access.AddParam("@data_vencimento", mdtVencimento.Text)
            Access.AddParam("@n_cheque", mtbNCheque.Text)
            Access.AddParam("@valor", mtbValor.Text)
            Access.AddParam("@observacoes", mtbObservacoes.Text)
            Access.AddParam("@imovel", mlbCodigoImovel2.Text)

            Access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento,
                             n_cheque, valor, observacoes, imovel) 
                                values (1,@cod_cenCusto,@cod_conta,@cod_inquilino,@cod_planoContas,'Em Aberto',@descricao,
                            @data_emissao,  @data_vencimento, @n_cheque, @valor , @observacoes, @imovel)")
        Else
            Access.AddParam("@cod_cenCusto", cbbCentroCus.SelectedValue)
            Access.AddParam("@cod_conta", cbbConta.SelectedValue)
            Access.AddParam("@cod_inquilino", cbbFavorecido.SelectedValue)
            Access.AddParam("@cod_planoContas", cbbCategoria.SelectedValue)
            Access.AddParam("@descricao", mtbDescricao.Text)
            Access.AddParam("@data_emissao", mdtEmissao.Text)
            Access.AddParam("@data_vencimento", mdtVencimento.Text)
            Access.AddParam("@n_cheque", mtbNCheque.Text)
            Access.AddParam("@valor", mtbValor.Text)
            Access.AddParam("@observacoes", mtbObservacoes.Text)

            Access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento,
                             n_cheque, valor, observacoes) 
                                values (1,@cod_cenCusto,@cod_conta,@cod_inquilino,@cod_planoContas,'Em Aberto',@descricao,
                            @data_emissao,  @data_vencimento, @n_cheque, @valor , @observacoes)")
        End If
    End Sub
    Public Sub insertDespesaAberto()
        If mlbCodigoImovel1.Text.Length > 0 Then

            Access.AddParam("@cod_cenCusto", cbbCentroCus.SelectedValue)
            Access.AddParam("@cod_conta", cbbConta.SelectedValue)
            Access.AddParam("@cod_fornecedor", cbbFavorecido.SelectedValue)
            Access.AddParam("@cod_planoContas", cbbCategoria.SelectedValue)
            Access.AddParam("@descricao", mtbDescricao.Text)
            Access.AddParam("@data_emissao", mdtEmissao.Text)
            Access.AddParam("@data_vencimento", mdtVencimento.Text)
            Access.AddParam("@n_cheque", mtbNCheque.Text)
            Access.AddParam("@valor", mtbValor.Text)
            Access.AddParam("@observacoes", mtbObservacoes.Text)
            Access.AddParam("@imovel", mlbCodigoImovel2.Text)

            Access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento,
                             n_cheque, valor, observacoes, imovel) 
                                values (2,@cod_cenCusto,@cod_conta,@cod_fornecedor,@cod_planoContas,'Em Aberto',@descricao,
                            @data_emissao,  @data_vencimento, @n_cheque, @valor , @observacoes, @imovel)")
        Else
            Access.AddParam("@cod_cenCusto", cbbCentroCus.SelectedValue)
            Access.AddParam("@cod_conta", cbbConta.SelectedValue)
            Access.AddParam("@cod_fornecedor", cbbFavorecido.SelectedValue)
            Access.AddParam("@cod_planoContas", cbbCategoria.SelectedValue)
            Access.AddParam("@descricao", mtbDescricao.Text)
            Access.AddParam("@data_emissao", mdtEmissao.Text)
            Access.AddParam("@data_vencimento", mdtVencimento.Text)
            Access.AddParam("@n_cheque", mtbNCheque.Text)
            Access.AddParam("@valor", mtbValor.Text)
            Access.AddParam("@observacoes", mtbObservacoes.Text)

            Access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento,
                             n_cheque, valor, observacoes) 
                                values (2,@cod_cenCusto,@cod_conta,@cod_fornecedor,@cod_planoContas,'Em Aberto',@descricao,
                            @data_emissao,  @data_vencimento, @n_cheque, @valor , @observacoes)")
        End If
    End Sub
    Public Sub insertDespesaPago()
        If mlbCodigoImovel1.Text.Length > 0 Then

            Access.AddParam("@cod_cenCusto", cbbCentroCus.SelectedValue)
            Access.AddParam("@cod_conta", cbbConta.SelectedValue)
            Access.AddParam("@cod_fornecedor", cbbFavorecido.SelectedValue)
            Access.AddParam("@cod_planoContas", cbbCategoria.SelectedValue)
            Access.AddParam("@descricao", mtbDescricao.Text)
            Access.AddParam("@data_emissao", mdtEmissao.Text)
            Access.AddParam("@data_vencimento", mdtVencimento.Text)
            Access.AddParam("@data_pagamento", mdtPagamento.Text)
            Access.AddParam("@n_cheque", mtbNCheque.Text)
            Access.AddParam("@valor", mtbValor.Text)
            Access.AddParam("@observacoes", mtbObservacoes.Text)
            Access.AddParam("@imovel", mlbCodigoImovel2.Text)

            Access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento,
                            data_pagamento, n_cheque, valor, observacoes, imovel) 
                                values (2,@cod_cenCusto,@cod_conta,@cod_fornecedor,@cod_planoContas,'Pago',@descricao,
                            @data_emissao,  @data_vencimento, @data_pagamento, @n_cheque, @valor , @observacoes, @imovel)")
        Else
            Access.AddParam("@cod_cenCusto", cbbCentroCus.SelectedValue)
            Access.AddParam("@cod_conta", cbbConta.SelectedValue)
            Access.AddParam("@cod_fornecedor", cbbFavorecido.SelectedValue)
            Access.AddParam("@cod_planoContas", cbbCategoria.SelectedValue)
            Access.AddParam("@descricao", mtbDescricao.Text)
            Access.AddParam("@data_emissao", mdtEmissao.Text)
            Access.AddParam("@data_vencimento", mdtVencimento.Text)
            Access.AddParam("@data_pagamento", mdtPagamento.Text)
            Access.AddParam("@n_cheque", mtbNCheque.Text)
            Access.AddParam("@valor", mtbValor.Text)
            Access.AddParam("@observacoes", mtbObservacoes.Text)

            Access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento,
                            data_pagamento, n_cheque, valor, observacoes) 
                                values (2,@cod_cenCusto,@cod_conta,@cod_fornecedor,@cod_planoContas,'Pago',@descricao,
                            @data_emissao,  @data_vencimento, @data_pagamento, @n_cheque, @valor , @observacoes)")
        End If
    End Sub

    ''LISTAR LANÇAMENTO -------------------------------------------------------------------------------------------------------------------------------

    '' LBX CONTA 
    Public Sub preencheCLBXContas()
        Dim dta As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT Código, num_conta & ' - ' & descricao as d FROM conta")

        dta = Access.dt

        clbxContas.DataSource = dta
        clbxContas.DisplayMember = "d"
        clbxContas.ValueMember = "Código"

        '' MessageBox.Show(clbxContas.Items.Count)

        'For i As Integer = 0 To clbxContas.Items.Count - 1
        '    '' MessageBox.Show(clbxContas.Items(i).ToString)
        '    MessageBox.Show(clbxContas.che)

        'Next

    End Sub

    ''LBX CENTRO CUSTOS 
    Public Sub preencheCLBXCenCustos()
        Dim dtCC As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT * FROM cenCusto")

        dtCC = Access.dt

        clbxCenCustos.DataSource = dtCC
        clbxCenCustos.DisplayMember = "descricao"
        clbxCenCustos.ValueMember = "Código"

    End Sub

    ''LBX IMOVEIS 
    Public Sub preencheCLBXImoveis()
        Dim dtim As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT Código, Código & ' - ' & logradouro & ', ' & numero & ' ' & complemento & ' ' & bairro & ' ' & cidade as d FROM imoveis")

        dtim = Access.dt

        clbximoveis.DataSource = dtim
        clbximoveis.DisplayMember = "d"
        clbximoveis.ValueMember = "Código"

    End Sub

    ''MGRID PESQUISA LANÇAMENTOS
    Public Sub preencheDtvLancamentos()
        Dim query As String

        query = "SELECT 
                lancamentos.Código as CÓD,
                tipo_lanc.descricao as TIPO,
                cenCusto.descricao AS CCUS,
                conta.descricao as CONTA,
                favorecidos.nome AS FAVOR,
                planoContas.descricao AS PCONTA,
                lancamentos.cod_planoContas as CODPC,
                lancamentos.descricao AS DESCR,
                lancamentos.status AS STATUS, 
                lancamentos.data_emissao AS EMISSÃO,
                lancamentos.data_vencimento AS VENCIMENTO,
                lancamentos.data_pagamento AS PGTO,
                lancamentos.n_cheque AS CHEQUE,
                lancamentos.valor AS VALOR,
                lancamentos.observacoes AS OBS


                FROM 
                    ((((lancamentos 
                    INNER JOIN tipo_lanc on lancamentos.tipo_lancamento = tipo_lanc.Código)
                    INNER JOIN cenCusto on lancamentos.cod_cenCusto = cenCusto.Código)
                    INNER JOIN conta on lancamentos.cod_conta = conta.Código)
                    LEFT JOIN favorecidos on lancamentos.cod_favorecidos = favorecidos.Código)
                    LEFT JOIN planoContas on lancamentos.cod_planoContas = planoContas.Código"

        '' RADIOBUTTON RECEITA/PAGAMENTO
        If mrbPAAmbosP.Checked Then
            query &= " WHERE lancamentos.status in ('Pago','Em Aberto') "
        ElseIf mrbPagoP.Checked Then
            query &= " WHERE lancamentos.status='Pago' "
        Else
            query &= " WHERE lancamentos.status='Em Aberto' "
        End If

        '' RADIOBUTTON PAGOABERTO
        If mrbRDAmbosP.Checked Then
            query &= " AND tipo_lanc.descricao in ('Receita','Despesa')"
        ElseIf mrbReceitasP.Checked Then
            query &= " AND tipo_lanc.descricao='Receita'"
        Else
            query &= " AND tipo_lanc.descricao='Despesa'"
        End If

        'DATETIME
        If mdtpEmissaoInicial.Checked Then
            Access.AddParam("@datainicial", mdtpEmissaoInicial.Text)
            query &= " AND lancamentos.data_emissao >= @datainicial"
        End If
        If mdtpEmissaoFinal.Checked Then
            Access.AddParam("@datafinal", mdtpEmissaoFinal.Text)
            query &= " AND lancamentos.data_emissao <= @datafinal"
        End If

        If mdtpVencInicial.Checked Then
            Access.AddParam("@dataVencinicial", mdtpVencInicial.Text)
            query &= " AND lancamentos.data_vencimento >= @dataVencinicial"
        End If
        If mdtpVencFinal.Checked Then
            Access.AddParam("@dataVencfinal", mdtpVencFinal.Text)
            query &= " AND lancamentos.data_vencimento <= @dataVencfinal"
        End If

        If mdtpPgtoInicial.Checked Then
            Access.AddParam("@datapgtoinicial", mdtpPgtoInicial.Text)
            query &= " AND lancamentos.data_pagamento >= @datapgtoinicial"
        End If
        If mdtpPgtoFinal.Checked Then
            Access.AddParam("@datapgtoFinal", mdtpPgtoFinal.Text)
            query &= " AND lancamentos.data_pagamento <= @datapgtoFinal"
        End If

        ''CHECKEDLISTBOX CONTAS 
        Dim count As Integer = 0
        For Each item As DataRowView In clbxContas.CheckedItems
            If count > 0 Then
                query &= " OR lancamentos.cod_conta = " & item.Item(0)
            Else
                query &= " AND lancamentos.cod_conta = " & item.Item(0)
            End If
            count += 1
        Next

        'CHECKEDLISTBOX CENTRO DE CUSTOS  
        Dim countCC As Integer = 0
        For Each item As DataRowView In clbxCenCustos.CheckedItems
            If countCC > 0 Then
                query &= " OR lancamentos.cod_cenCusto = " & item.Item(0)
            Else
                query &= " AND lancamentos.cod_cenCusto = " & item.Item(0)
            End If
            countCC += 1
        Next

        ''TEXTBOX 
        If tbCheque.Text.Length > 0 Then
            query &= " AND lancamentos.n_cheque like '%" & tbCheque.Text & "%'"
        End If
        If tbObs.Text.Length > 0 Then
            query &= " AND lancamentos.observacoes like '%" & tbObs.Text & "%'"
        End If
        If tbDescricao.Text.Length > 0 Then
            query &= " AND lancamentos.descricao like '%" & tbDescricao.Text & "%'"
        End If

        If tbCodigo.Text.Length > 0 Then
            query &= " AND lancamentos.Código like '%" & tbCodigo.Text & "%'"
        End If

        If clbximoveis.CheckedItems.Count > 0 Then
            Dim countIM As Integer = 0
            query &= " AND lancamentos.imovel in ("
            For Each item As DataRowView In clbximoveis.CheckedItems
                If countIM = 0 Then
                    query &= item.Item(0)
                Else
                    query &= ", " & item.Item(0)
                End If
                countIM += 1
            Next
            query &= " )"
        End If
        ''query &= " AND lancamentos.imovel in (41)"

        query &= " ORDER BY lancamentos.Código ASC"

        Access.ExecuteQuerry(query)

        mGridLancamentos.DataSource = Access.dt
        lbTot.Text = Access.dt.Rows.Count


    End Sub
    Private Sub mGridLancamentos_DoubleClick(sender As Object, e As EventArgs) Handles mGridLancamentos.DoubleClick
        Dim frm As New SubMenuLançamentos
        AddOwnedForm(frm)
        If mGridLancamentos.CurrentRow.Cells("CHEQUE").Value IsNot DBNull.Value Then frm.tbNCheque.Text = mGridLancamentos.CurrentRow.Cells("CHEQUE").Value
        frm.cod_lancamento = mGridLancamentos.CurrentRow.Cells("CÓD").Value
        frm.status = mGridLancamentos.CurrentRow.Cells("STATUS").Value
        frm.Show()
    End Sub
    Private Sub mGridLancamentos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles mGridLancamentos.CellFormatting
        With mGridLancamentos
            .Columns("CÓD").Width = 35
            .Columns("FAVOR").Width = 200
            .Columns("PCONTA").Width = 150
            .Columns("DESCR").Width = 200
            .Columns("STATUS").Width = 70
            .Columns("EMISSÃO").Width = 70
            .Columns("VENCIMENTO").Width = 70
            .Columns("PGTO").Width = 70
            .Columns("CHEQUE").Width = 70
            .Columns("VALOR").Width = 70
            .Columns("OBS").Width = 140

            .Columns("CODPC").Visible = False
            .Columns("TIPO").Visible = False
            .Columns("CCUS").Visible = False
            .Columns("CONTA").Visible = False

            .Columns("EMISSÃO").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("VALOR").DefaultCellStyle.Format = "C2"


        End With
        For i As Integer = 0 To mGridLancamentos.Rows.Count - 1 Step +1
            Dim tipo As String
            tipo = mGridLancamentos.Rows(i).Cells("tipo").Value

            If tipo = "Despesa" Then
                mGridLancamentos.Rows(i).DefaultCellStyle.BackColor = Color.LavenderBlush
                mGridLancamentos.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            Else
                mGridLancamentos.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    ''CONTROLES 
    Public Sub mbtPesquisar_Click(sender As Object, e As EventArgs) Handles mbtPesquisar.Click
        preencheDtvLancamentos()
    End Sub
    Private Sub mbtLimpar2_Click(sender As Object, e As EventArgs) Handles mbtLimpar2.Click
        Utils.LimparForm(Me)
    End Sub

    ''DATE TIME EVENTS
    Public Sub UncheckDTs()
        mdtpEmissaoFinal.Checked = False
        mdtpEmissaoInicial.Checked = False
        mdtpPgtoInicial.Checked = False
        mdtpPgtoFinal.Checked = False
        mdtpVencInicial.Checked = False
        mdtpVencFinal.Checked = False
    End Sub
    'Public Sub UncheckCBs()
    '    mcbHoje.Checked = False
    '    mcbSemanaAtual.Checked = False
    '    mcbMesAtual.Checked = False
    '    mcbUltimoMes.Checked = False
    'End Sub
    'Private Sub mcbHoje_CheckedChanged(sender As Object, e As EventArgs)
    '    If mcbHoje.Checked = True Then
    '        UncheckDTs()
    '    End If
    'End Sub
    'Private Sub mcbSemanaAtual_CheckedChanged(sender As Object, e As EventArgs)
    '    If mcbSemanaAtual.Checked = True Then
    '        UncheckDTs()
    '    End If
    'End Sub
    'Private Sub mcbMesAtual_CheckedChanged(sender As Object, e As EventArgs)
    '    If mcbMesAtual.Checked = True Then
    '        UncheckDTs()
    '    End If
    'End Sub
    'Private Sub mcbUltimoMes_CheckedChanged(sender As Object, e As EventArgs)
    '    If mcbUltimoMes.Checked = True Then
    '        UncheckDTs()
    '    End If
    'End Sub
    'Private Sub mdtpEmissaoInicial_ValueChanged(sender As Object, e As EventArgs) Handles mdtpEmissaoInicial.ValueChanged
    '    UncheckCBs()
    'End Sub
    'Private Sub mdtpEmissaoFinal_ValueChanged(sender As Object, e As EventArgs) Handles mdtpEmissaoFinal.ValueChanged
    '    UncheckCBs()

    'End Sub
    'Private Sub mdtpPgtoInicial_ValueChanged(sender As Object, e As EventArgs) Handles mdtpPgtoInicial.ValueChanged
    '    UncheckCBs()

    'End Sub
    'Private Sub mdtpPgtoFinal_ValueChanged(sender As Object, e As EventArgs) Handles mdtpPgtoFinal.ValueChanged
    '    UncheckCBs()

    'End Sub
    'Private Sub mdtpVencInicial_ValueChanged(sender As Object, e As EventArgs) Handles mdtpVencInicial.ValueChanged
    '    UncheckCBs()

    'End Sub
    'Private Sub mdtpVencFinal_ValueChanged(sender As Object, e As EventArgs) Handles mdtpVencFinal.ValueChanged
    '    UncheckCBs()

    'End Sub



    ''ADD TRANSFERENCIA -------------------------------------------------------------------------------------------------------------------------------

    ''CARREGAMENTO CBB
    Public Sub preencheCBBcOrigem()
        Dim dt As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT Código, num_conta & ' - ' & descricao as d FROM conta")
        dt = Access.dt

        With cbbContaOrigem
            .DataSource = dt
            .DisplayMember = "d"
            .ValueMember = "Código"
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        cbbContaOrigem.Text = ""
        eventsTbOrigem = True
    End Sub
    Public Sub preencheCBBcDestino()
        Dim dt As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT Código, num_conta & ' - ' & descricao as d FROM conta")
        dt = Access.dt

        With cbbContaDestino
            .DataSource = dt
            .DisplayMember = "d"
            .ValueMember = "Código"
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        cbbContaDestino.Text = ""
        eventsTbDestino = True
    End Sub

    ''AUXILIARES 
    Public Sub attSaldoAtualOrigem()

        Dim dt As DataTable = New DataTable
        Access.ExecuteQuerry("SELECT saldo_atual FROM conta where Código= " & cbbContaOrigem.SelectedValue)
        dt = Access.dt

        If cbbContaOrigem.Text <> "" Then
            For Each row As DataRow In dt.Rows
                mtbSAOrigem.Text = row("saldo_atual")
                mtbSAOrigem.Text = String.Format("{0:c}", Double.Parse(mtbSAOrigem.Text))
                If CType(mtbSAOrigem.Text, Double) < 0 Then
                    mtbSAOrigem.ForeColor = Color.Red
                Else
                    mtbSAOrigem.ForeColor = Color.Black
                End If
            Next

        End If
    End Sub
    Public Sub attSaldoAtualDestino()

        Dim dt As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT saldo_atual FROM conta where Código= " & cbbContaDestino.SelectedValue)
        dt = Access.dt
        If cbbContaDestino.Text <> "" Then
            For Each row As DataRow In dt.Rows
                mtbSADestino.Text = row("saldo_atual")
                mtbSADestino.Text = String.Format("{0:c}", Double.Parse(mtbSADestino.Text))
                If CType(mtbSADestino.Text, Double) < 0 Then
                    mtbSADestino.ForeColor = Color.Red
                Else
                    mtbSADestino.ForeColor = Color.Black
                End If
            Next
        End If
        If mtbValorT.Text.Count > 0 Then
            attSaldoPrevistoOrigem()
        End If
    End Sub
    Public Sub attSaldoPrevistoOrigem()
        If mtbValorT.Text.Count > 0 Then

            mtbSPOrigem.Text = CType(mtbSAOrigem.Text, Double) - CType(mtbValorT.Text, Double)
            mtbSPOrigem.Text = String.Format("{0:c}", Double.Parse(mtbSPOrigem.Text))
            If CType(mtbSPOrigem.Text, Double) < 0 Then
                mtbSPOrigem.ForeColor = Color.Red
            Else
                mtbSPOrigem.ForeColor = Color.Black
            End If

        End If
    End Sub
    Public Sub attSaldoPrevistoDestino()
        If mtbValorT.Text.Count > 0 Then
            mtbSPDestino.Text = CType(mtbSADestino.Text, Double) + CType(mtbValorT.Text, Double)
            mtbSPDestino.Text = String.Format("{0:c}", Double.Parse(mtbSPDestino.Text))
            If CType(mtbSPDestino.Text, Double) < 0 Then
                mtbSPDestino.ForeColor = Color.Red
            Else
                mtbSPDestino.ForeColor = Color.Black
            End If
        End If
    End Sub
    ''EVENTOS CBB
    Private Sub cbbContaOrigem_TextChanged(sender As Object, e As EventArgs) Handles cbbContaOrigem.TextChanged
        If eventsTbOrigem Then
            attSaldoAtualOrigem()
            attSaldoPrevistoOrigem()
        End If
    End Sub
    Private Sub cbbContaDestino_TextChanged(sender As Object, e As EventArgs) Handles cbbContaDestino.TextChanged
        If eventsTbDestino Then
            attSaldoAtualDestino()
            attSaldoPrevistoDestino()
        End If
    End Sub

    ''EVENTOS TB
    Private Sub tbValor_Leave(sender As Object, e As EventArgs) Handles mtbValorT.Leave
        If cbbContaOrigem.Text <> "" Then
            attSaldoPrevistoOrigem()
        End If
        If cbbContaDestino.Text <> "" Then
            attSaldoPrevistoDestino()
        End If

    End Sub

    ''VALIDAÇÕES
    Public Function validaCamposT() As Integer

        If mtbValorT.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo VALOR deve ser preenchido! ",
                                                        "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtbValorT.Focus()
            Return 1
        End If
        If cbbContaOrigem.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo Conta de Origem deve ser preenchido! ",
                                                        "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbContaOrigem.Focus()
            Return 1
        End If
        If cbbContaDestino.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo Conta de Destino deve ser preenchido! ",
                                                        "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbContaDestino.Focus()
            Return 1
        End If

        Return 0
    End Function
    Private Sub mtbValorT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbValorT.KeyPress
        If e.KeyChar = Chr(46) Then e.KeyChar = Chr(44)
        If e.KeyChar = Chr(44) And InStr(mtbValorT.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(44) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    ''CONTROLES
    Private Sub btInserir_Click(sender As Object, e As EventArgs) Handles mbtInserir.Click
        If validaCamposT() Then
            Exit Sub
        End If

        Access.paramns.Clear()

        Access.AddParam("@cod_cOrigem", cbbContaOrigem.SelectedValue)
        Access.AddParam("@con_cDestino", cbbContaDestino.SelectedValue)
        Access.AddParam("@valor", CType(mtbValorT.Text, Double))
        Access.AddParam("@n_cheque", mtbNum_chequeT.Text)
        Access.AddParam("@data", mdtData.Text)
        Access.AddParam("@observacoes", mtbObservacoesT.Text)

        Access.ExecuteQuerry("INSERT INTO transferencias (cod_cOrigem,con_cDestino,valor,n_cheque,data, observacoes)
                              VALUES (@cod_cOrigem,@con_cDestino,@valor,@n_cheque,@data,@observacoes)")


        Utils.atualizaSaldoAtualConta(cbbContaOrigem.SelectedValue)
        Utils.atualizaSaldoAtualConta(cbbContaDestino.SelectedValue)
        eventsTbOrigem = False
        eventsTbDestino = False
        Utils.LimparForm(Me)


        MetroFramework.MetroMessageBox.Show(Me, "Transferência realizada com sucesso! ",
                                            "Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    ''LISTAR TRANSFERENCIA -------------------------------------------------------------------------------------------------------------------------------

    ''MGRID TRANSFERENCIAS
    Public Sub carregaMgridTransferencias()

        Access.ExecuteQuerry("SELECT 
                t.Código as CÓDIGO,
                C1.num_conta & ' - ' & c1.descricao as ORIGEM,
                C2.num_conta & ' - ' & c2.descricao as DESTINO,
                t.valor AS VALOR,
                t.n_cheque as CHEQUE,
                t.data AS DATA

                FROM 
                    (transferencias as t
                    INNER JOIN conta as c1 on t.cod_cOrigem = c1.Código)
                    INNER JOIN conta as c2 on t.con_cDestino = c2.Código")
        mGridTransferencias.DataSource = Access.dt
        lbTot.Text = Access.dt.Rows.Count
    End Sub
    Private Sub mGridTransferencias_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles mGridTransferencias.CellFormatting
        With mGridTransferencias
            .Columns("CÓDIGO").Width = 65
            .Columns("ORIGEM").Width = 300
            .Columns("DESTINO").Width = 300
            .Columns("VALOR").Width = 130
            .Columns("CHEQUE").Width = 180
            .Columns("DATA").Width = 100

            .Columns("DATA").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("VALOR").DefaultCellStyle.Format = "C2"
        End With
    End Sub
    Private Sub mGridTransferencias_DoubleClick(sender As Object, e As EventArgs) Handles mGridTransferencias.DoubleClick
        Dim frm As New AttTransferencias
        AddOwnedForm(frm)
        frm.cod_trans = mGridTransferencias.CurrentRow.Cells("CÓDIGO").Value
        frm.Show()
    End Sub





    ''CARREGAMENTO TELAS 
    Public Sub CarregaAddLancamentos()
        preencheCBBFavorecidos()
        preencheCBBCenCusto()
        preencheCBBCategoria()
        preencheCBBConta()
        preencheTV()
        mlbNomeTela.Text = "Adicionar Lançamentos"

    End Sub
    Public Sub CarregaListaLancamentos()
        mlbNomeTela.Text = "Listar Lançamentos"
        preencheCLBXCenCustos()
        preencheCLBXContas()
        preencheCLBXImoveis()
        lbTot.Text = ""



    End Sub
    Sub CarregaAddTransferencias()
        preencheCBBcOrigem()
        preencheCBBcDestino()
    End Sub
    Sub CarregaListaTransferencias()
        carregaMgridTransferencias()

    End Sub
    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged
        Select Case MetroTabControl1.SelectedIndex
            Case 0
                CarregaAddLancamentos()
            Case 1
                CarregaListaLancamentos()
            Case 2
                CarregaAddTransferencias()
            Case 3
                CarregaListaTransferencias()
        End Select
    End Sub
    Public Sub abrirEditar(ByVal codigo_lancamento)
        Dim frm As New AttLançamentos
        AddOwnedForm(frm)
        frm.codigo_lancamento = codigo_lancamento
        frm.Show()
    End Sub


End Class