Public Class AttLançamentos

    Dim access As New Controller
    Dim x, y As Integer
    Dim NewPoint As New Point
    Public codigo_lancamento As Integer



    ''SHOWN
    Private Sub AttLançamentos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        preencheCBBFavorecidos()
        preencheCBBCenCusto()
        preencheCBBCategoria()
        preencheCBBConta()
        preencheTV()
        mlbCodigoImovel1.Text = ""
        mlbCodigoImovel2.Text = ""
        preencheEditar()
    End Sub

    ''CARREGA COMBOBOX
    Public Sub preencheCBBFavorecidos()
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT * from favorecidos order by nome ASC")
        dt = access.dt

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

        access.ExecuteQuerry("SELECT * FROM cenCusto")
        dt = access.dt

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

        access.ExecuteQuerry("SELECT * FROM planoContas")
        dt = access.dt

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

        access.ExecuteQuerry("SELECT Código, num_conta & ' - ' & descricao as d FROM conta")
        dt = access.dt

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

        access.ExecuteQuerry("SELECT * FROM planoContas")

        dt = access.dt
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
        frm.inicializador = 3
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

        access.ExecuteQuerry("SELECT nome FROM favorecidos")
        dt = access.dt
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

        access.ExecuteQuerry("SELECT descricao FROM planoContas")
        dta = access.dt
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

        Return 0
    End Function

    ''PREENCHER FORM 
    Private Sub preencheEditar()
        Dim a As Integer = 1
        access.AddParam("@codigo", codigo_lancamento)

        Dim query As String = "SELECT 
                lancamentos.Código as CÓD,
                tipo_lanc.descricao as TIPO,
                cenCusto.descricao AS CCUS,
                conta.num_conta & ' - ' & conta.descricao as CONTA,
                favorecidos.nome AS FAVOR,
                planoContas.descricao AS PCONTA,
                lancamentos.descricao AS DESCR,
                lancamentos.status AS STATUS, 
                lancamentos.data_emissao AS EMISSÃO,
                lancamentos.data_vencimento AS VENCIMENTO,
                lancamentos.data_pagamento AS PGTO,
                lancamentos.n_cheque AS CHEQUE,
                lancamentos.valor AS VALOR,
                lancamentos.observacoes AS OBS,
                lancamentos.imovel as IMOVEL

                FROM 
                    ((((lancamentos 
                    INNER JOIN tipo_lanc on lancamentos.tipo_lancamento = tipo_lanc.Código)
                    INNER JOIN cenCusto on lancamentos.cod_cenCusto = cenCusto.Código)
                    INNER JOIN conta on lancamentos.cod_conta = conta.Código)
                    LEFT JOIN favorecidos on lancamentos.cod_favorecidos = favorecidos.Código)
                    LEFT JOIN planoContas on lancamentos.cod_planoContas = planoContas.Código

                WHERE
                    lancamentos.Código = @codigo"

        access.ExecuteQuerry(query)

        If access.dt.Rows.Count > 0 Then
            Dim dt As DataTable = New DataTable

            dt = access.dt

            For Each row As DataRow In access.dt.Rows
                If row("TIPO") = "Receita" Then
                    mrbReceitas.Checked = True
                    cbbFavorecido.Text = row("FAVOR")
                    mtbValor.Text = row("VALOR")
                Else
                    mrbDespesas.Checked = True
                    cbbFavorecido.Text = row("FAVOR")
                    mtbValor.Text = row("VALOR")
                End If

                If row("STATUS") = "Pago" Then
                    mrbPago.Checked = True
                    mdtPagamento.Value = row("PGTO")
                Else
                    mrbAberto.Checked = True
                End If
                cbbCategoria.Text = row("PCONTA")
                mtbDescricao.Text = row("DESCR")
                mtbObservacoes.Text = row("OBS")
                mdtEmissao.Value = row("EMISSÃO")
                mdtVencimento.Value = row("VENCIMENTO")
                mtbNCheque.Text = IIf(row("CHEQUE") Is DBNull.Value, "-", row("CHEQUE"))
                cbbConta.Text = row("CONTA")
                cbbCentroCus.Text = row("CCUS")
                If Object.ReferenceEquals(row("IMOVEL").GetType(), a.GetType()) Then
                    preencherImovel(row("IMOVEL"))
                End If
            Next

        Else
            MessageBox.Show("ERRO CONTATE O ADMIM DO SISTEMA")
            Me.Close()
        End If

    End Sub
    Public Sub preencherImovel(ByVal cod As Integer)
        access.ExecuteQuerry("SELECT * FROM imoveis WHERE Código = " & cod)

        For Each row As DataRow In access.dt.Rows
            mlbCodigoImovel2.Text = row("Código")
            mtbEndereco.Text = row("logradouro") & ", " & row("bairro") & " - " & row("cidade")
            mtbNum.Text = row("numero")
            mtbComplemento.Text = row("complemento")
        Next
        mlbCodigoImovel1.Text = "Código Imóvel"
    End Sub

    ''CONTROLES
    Private Sub mbtSalvar_Click(sender As Object, e As EventArgs) Handles mbtSalvar.Click
        If validaCampos() Then
            Exit Sub
        End If

        If mrbReceitas.Checked = True And mrbPago.Checked = True Then

            updateReceita(codigo_lancamento, 1, cbbCentroCus.SelectedValue, cbbConta.SelectedValue, cbbFavorecido.SelectedValue,
                                cbbCategoria.SelectedValue, "Pago", mtbDescricao.Text, mdtEmissao.Value, mdtVencimento.Value, mdtPagamento.Value,
                                mtbNCheque.Text, mtbValor.Text, mtbObservacoes.Text, IIf(mlbCodigoImovel2.Text.Length > 0, mlbCodigoImovel2.Text, 0))
        ElseIf mrbReceitas.Checked = True And mrbAberto.Checked = True Then

            updateReceitaAberto(codigo_lancamento, 1, cbbCentroCus.SelectedValue, cbbConta.SelectedValue, cbbFavorecido.SelectedValue,
                                cbbCategoria.SelectedValue, "Em Aberto", mtbDescricao.Text, mdtEmissao.Value, mdtVencimento.Value,
                                mtbNCheque.Text, mtbValor.Text, mtbObservacoes.Text, IIf(mlbCodigoImovel2.Text.Length > 0, mlbCodigoImovel2.Text, 0))
        End If
        If mrbDespesas.Checked = True And mrbPago.Checked = True Then

            updateDespesa(codigo_lancamento, 2, cbbCentroCus.SelectedValue, cbbConta.SelectedValue, cbbFavorecido.SelectedValue,
                                cbbCategoria.SelectedValue, "Pago", mtbDescricao.Text, mdtEmissao.Value, mdtVencimento.Value, mdtPagamento.Value,
                                mtbNCheque.Text, mtbValor.Text, mtbObservacoes.Text, IIf(mlbCodigoImovel2.Text.Length > 0, mlbCodigoImovel2.Text, 0))
        ElseIf mrbDespesas.Checked = True And mrbAberto.Checked = True Then

            updateDespesaAberto(codigo_lancamento, 2, cbbCentroCus.SelectedValue, cbbConta.SelectedValue, cbbFavorecido.SelectedValue,
                                cbbCategoria.SelectedValue, "Em Aberto", mtbDescricao.Text, mdtEmissao.Value, mdtVencimento.Value,
                                mtbNCheque.Text, mtbValor.Text, mtbObservacoes.Text, IIf(mlbCodigoImovel2.Text.Length > 0, mlbCodigoImovel2.Text, 0))
        End If

        If mrbPago.Checked Then
            Utils.atualizaSaldoAtualConta(cbbConta.SelectedValue)
        End If
        Dim frm As Lançamentos = CType(Owner, Lançamentos)
        frm.preencheDtvLancamentos()
        Me.Close()
    End Sub
    Private Sub btApagar_Click(sender As Object, e As EventArgs) Handles mbtApagar.Click
        If MetroFramework.MetroMessageBox.Show(Me, "Você tem certeza que deseja remover esse Lançamento ?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

            access.AddParam("@Código", codigo_lancamento)
            access.ExecuteQuerry("DELETE FROM lancamentos where Código = @Código")
            Utils.atualizaSaldoAtualConta(cbbConta.SelectedValue)
            Dim frm As Lançamentos = CType(Owner, Lançamentos)
            frm.preencheDtvLancamentos()
            Me.Close()
        End If

    End Sub
    Private Sub updateReceita(ByVal Código As Integer, ByVal tipo_lancamento As Integer, ByVal cod_cenCusto As Integer,
                                    ByVal cod_conta As Integer, ByVal cod_favorecido As Integer, ByVal cod_planoContas As Integer,
                                    ByVal status As String, ByVal descricao As String, ByVal data_emissao As Date,
                                    ByVal data_vencimento As Date, ByVal data_pgto As Date, ByVal n_cheque As String, ByVal valor As Double,
                                    ByVal observacoes As String, ByVal cod_imovel As Integer)
        If mlbCodigoImovel2.Text.Length > 0 Then

            access.AddParam("@Código", Código)
            access.ExecuteQuerry("UPDATE lancamentos SET 
                                tipo_lancamento = '" & tipo_lancamento & "', 
                                cod_cenCusto = '" & cod_cenCusto & "',  
                                cod_conta = '" & cod_conta & "',  
                                cod_favorecidos = '" & cod_favorecido & "',  
                                cod_planoContas = '" & cod_planoContas & "',  
                                status = '" & status & "',  
                                descricao = '" & descricao & "',  
                                data_emissao = '" & data_emissao & "',  
                                data_vencimento = '" & data_vencimento & "',  
                                data_pagamento = '" & data_pgto & "',  
                                n_cheque = '" & n_cheque & "',  
                                valor = '" & valor & "',  
                                observacoes = '" & observacoes & "',
                                imovel = '" & cod_imovel & "'" &
                                " where Código = @Código")
        Else
            access.AddParam("@Código", Código)
            access.ExecuteQuerry("UPDATE lancamentos SET 
                                tipo_lancamento = '" & tipo_lancamento & "', 
                                cod_cenCusto = '" & cod_cenCusto & "',  
                                cod_conta = '" & cod_conta & "',  
                                cod_favorecidos = '" & cod_favorecido & "',  
                                cod_planoContas = '" & cod_planoContas & "',  
                                status = '" & status & "',  
                                descricao = '" & descricao & "',  
                                data_emissao = '" & data_emissao & "',  
                                data_vencimento = '" & data_vencimento & "',  
                                data_pagamento = '" & data_pgto & "',  
                                n_cheque = '" & n_cheque & "',  
                                valor = '" & valor & "',  
                                observacoes = '" & observacoes & "'" &
                                " where Código = @Código")
        End If

    End Sub
    Private Sub updateDespesa(ByVal Código As Integer, ByVal tipo_lancamento As Integer, ByVal cod_cenCusto As Integer,
                                ByVal cod_conta As Integer, ByVal cod_favorecido As Integer, ByVal cod_planoContas As Integer,
                                ByVal status As String, ByVal descricao As String, ByVal data_emissao As Date,
                                ByVal data_vencimento As Date, ByVal data_pgto As Date, ByVal n_cheque As String, ByVal valor As Double,
                                ByVal observacoes As String, ByVal cod_imovel As Integer)

        If mlbCodigoImovel2.Text.Length > 0 Then
            access.AddParam("@Código", Código)
            access.ExecuteQuerry("UPDATE lancamentos SET 
                                tipo_lancamento = '" & tipo_lancamento & "', 
                                cod_cenCusto = '" & cod_cenCusto & "',  
                                cod_conta = '" & cod_conta & "',  
                                cod_favorecidos = '" & cod_favorecido & "',  
                                cod_planoContas = '" & cod_planoContas & "',  
                                status = '" & status & "',   
                                descricao = '" & descricao & "',  
                                data_emissao = '" & data_emissao & "',  
                                data_vencimento = '" & data_vencimento & "',  
                                data_pagamento = '" & data_pgto & "',  
                                n_cheque = '" & n_cheque & "',  
                                valor = '" & valor & "',  
                                observacoes = '" & observacoes & "',
                                imovel = '" & cod_imovel & "'" &
                                    " where Código = @Código")
        Else
            access.AddParam("@Código", Código)
            access.ExecuteQuerry("UPDATE lancamentos SET 
                                tipo_lancamento = '" & tipo_lancamento & "', 
                                cod_cenCusto = '" & cod_cenCusto & "',  
                                cod_conta = '" & cod_conta & "',  
                                cod_favorecidos = '" & cod_favorecido & "',  
                                cod_planoContas = '" & cod_planoContas & "',  
                                status = '" & status & "',   
                                descricao = '" & descricao & "',  
                                data_emissao = '" & data_emissao & "',  
                                data_vencimento = '" & data_vencimento & "',  
                                data_pagamento = '" & data_pgto & "',  
                                n_cheque = '" & n_cheque & "',  
                                valor = '" & valor & "',  
                                observacoes = '" & observacoes & "'" &
                                    " where Código = @Código")
        End If

    End Sub

    Private Sub updateDespesaAberto(ByVal Código As Integer, ByVal tipo_lancamento As Integer, ByVal cod_cenCusto As Integer,
                                ByVal cod_conta As Integer, ByVal cod_favorecido As Integer, ByVal cod_planoContas As Integer,
                                ByVal status As String, ByVal descricao As String, ByVal data_emissao As Date,
                                ByVal data_vencimento As Date, ByVal n_cheque As String, ByVal valor As Double,
                                ByVal observacoes As String, ByVal cod_imovel As Integer)

        If mlbCodigoImovel2.Text.Length > 0 Then
            access.AddParam("@Código", Código)
            access.ExecuteQuerry("UPDATE lancamentos SET 
                                tipo_lancamento = '" & tipo_lancamento & "', 
                                cod_cenCusto = '" & cod_cenCusto & "',  
                                cod_conta = '" & cod_conta & "',  
                                cod_favorecidos = '" & cod_favorecido & "',  
                                cod_planoContas = '" & cod_planoContas & "',  
                                status = '" & status & "',   
                                descricao = '" & descricao & "',  
                                data_emissao = '" & data_emissao & "',   
                                data_vencimento = '" & data_vencimento & "',   
                                n_cheque = '" & n_cheque & "',  
                                valor = '" & valor & "',  
                                observacoes = '" & observacoes & "',
                                imovel = '" & cod_imovel & "'" &
                                    " where Código = @Código")
        Else
            access.AddParam("@Código", Código)
            access.ExecuteQuerry("UPDATE lancamentos SET 
                                tipo_lancamento = '" & tipo_lancamento & "', 
                                cod_cenCusto = '" & cod_cenCusto & "',  
                                cod_conta = '" & cod_conta & "',  
                                cod_favorecidos = '" & cod_favorecido & "',  
                                cod_planoContas = '" & cod_planoContas & "',  
                                status = '" & status & "',   
                                descricao = '" & descricao & "',  
                                data_emissao = '" & data_emissao & "',   
                                data_vencimento = '" & data_vencimento & "',   
                                n_cheque = '" & n_cheque & "',  
                                valor = '" & valor & "',  
                                observacoes = '" & observacoes & "'" &
                                    " where Código = @Código")
        End If
        access.AddParam("@Código", Código)
        access.ExecuteQuerry("UPDATE lancamentos SET data_pagamento = NULL where Código = @Código")
    End Sub

    Private Sub updateReceitaAberto(ByVal Código As Integer, ByVal tipo_lancamento As Integer, ByVal cod_cenCusto As Integer,
                                    ByVal cod_conta As Integer, ByVal cod_favorecido As Integer, ByVal cod_planoContas As Integer,
                                    ByVal status As String, ByVal descricao As String, ByVal data_emissao As Date,
                                    ByVal data_vencimento As Date, ByVal n_cheque As String, ByVal valor As Double,
                                    ByVal observacoes As String, ByVal cod_imovel As Integer)
        If mlbCodigoImovel2.Text.Length > 0 Then

            access.AddParam("@Código", Código)
            access.ExecuteQuerry("UPDATE lancamentos SET 
                                tipo_lancamento = '" & tipo_lancamento & "', 
                                cod_cenCusto = '" & cod_cenCusto & "',  
                                cod_conta = '" & cod_conta & "',  
                                cod_favorecidos = '" & cod_favorecido & "',  
                                cod_planoContas = '" & cod_planoContas & "',  
                                status = '" & status & "',  
                                descricao = '" & descricao & "',  
                                data_emissao = '" & data_emissao & "',  
                                data_vencimento = '" & data_vencimento & "',  
                                n_cheque = '" & n_cheque & "',  
                                valor = '" & valor & "',  
                                observacoes = '" & observacoes & "',
                                imovel = '" & cod_imovel & "'" &
                                " where Código = @Código")
        Else
            access.AddParam("@Código", Código)
            access.ExecuteQuerry("UPDATE lancamentos SET 
                                tipo_lancamento = '" & tipo_lancamento & "', 
                                cod_cenCusto = '" & cod_cenCusto & "',  
                                cod_conta = '" & cod_conta & "',  
                                cod_favorecidos = '" & cod_favorecido & "',  
                                cod_planoContas = '" & cod_planoContas & "',  
                                status = '" & status & "',  
                                descricao = '" & descricao & "',  
                                data_emissao = '" & data_emissao & "',  
                                data_vencimento = '" & data_vencimento & "',   
                                n_cheque = '" & n_cheque & "',  
                                valor = '" & valor & "',  
                                observacoes = '" & observacoes & "'" &
                                " where Código = @Código")
        End If

        access.AddParam("@Código", Código)
        access.ExecuteQuerry("UPDATE lancamentos SET data_pagamento = NULL where Código = @Código")

    End Sub

    ''MOVIMENTO
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= x
            NewPoint.Y -= y
            Me.Location = NewPoint
            Application.DoEvents()

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub mbtSair_Click(sender As Object, e As EventArgs) Handles mbtApagar.Click
        Me.Close()
    End Sub


End Class