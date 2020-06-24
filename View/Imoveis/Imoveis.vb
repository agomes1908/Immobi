Public Class Imoveis

    Dim access As New controller

    ''SHOWN
    Private Sub Imoveis_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CarregaAddImovel()
        mtabControlImoveis.SelectTab(0)

    End Sub

    ''PAGE CADASTRO IMOVEIS ------------------------------------------------------------------------------------------------------------

    ''VALIDACOES
    Public Function valida() As Integer
        If cbbFinalidade.Text.Length < 1 Then

            MetroFramework.MetroMessageBox.Show(Me, "Primeiro Selecione a finalidade do Imóvel. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbFinalidade.Focus()
            Return 1
        End If
        If cbbTipo.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Primeiro Selecione o tipo do Imóvel. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbTipo.Focus()
            Return 1
        End If
        If mtbNum.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Primeiro Selecione o número do Imóvel. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtbNum.Focus()
            Return 1
        End If
        If mtbLogradouro.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Primeiro Selecione o logradouro do Imóvel. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtbLogradouro.Focus()
            Return 1
        End If
        If mtbBairro.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Primeiro Selecione o bairro do Imóvel. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtbBairro.Focus()
            Return 1
        End If
        If mtbCidade.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Primeiro Selecione a cidade do Imóvel. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtbCidade.Focus()
            Return 1
        End If
        If mtbEstado.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Primeiro Selecione o estado do Imóvel. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtbEstado.Focus()
            Return 1
        End If
        If mtbValorLocacao.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Primeiro insira o valor de locação do Imóvel. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtbValorLocacao.Focus()
            Return 1
        End If
        Return 0
    End Function
    Private Sub mtbValorLocacao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbValorLocacao.KeyPress
        If e.KeyChar = Chr(46) Then e.KeyChar = Chr(44)
        If e.KeyChar = Chr(44) And InStr(mtbValorLocacao.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(44) Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    Private Sub mtbValorLuz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbValorLuz.KeyPress
        If e.KeyChar = Chr(46) Then e.KeyChar = Chr(44)
        If e.KeyChar = Chr(44) And InStr(mtbValorLuz.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(44) Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    Private Sub mtbValorNet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbValorNet.KeyPress
        If e.KeyChar = Chr(46) Then e.KeyChar = Chr(44)
        If e.KeyChar = Chr(44) And InStr(mtbValorNet.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(44) Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    Private Sub mtbValorAgua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbValorAgua.KeyPress
        If e.KeyChar = Chr(46) Then e.KeyChar = Chr(44)
        If e.KeyChar = Chr(44) And InStr(mtbValorAgua.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(44) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    ''CONTROLES
    Private Sub mbtSalvar_Click(sender As Object, e As EventArgs) Handles mbtSalvar.Click
        If valida() Then
            Exit Sub
        End If
        Utils.InsertImoveis(mtbLogradouro.Text, mtbNum.Text, mtbComplemento.Text, mtbBairro.Text, mtbCidade.Text,
                            mtbEstado.Text, cbbFinalidade.Text, cbbTipo.Text, nudDorm.Value, nudSuite.Value, nudbanho.Value,
                            nudVagas.Value, mtbValorLocacao.Text, mtbValorLuz.Text, mtbValorNet.Text,
                            mtbValorAgua.Text, False)

        Utils.LimparForm(Me)
        atualizarmGridImoveis()
        MetroFramework.MetroMessageBox.Show(Me, "Imóvel salvo com sucesso ! ",
                                                "Sucesso ! ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub mbtLimpar_Click(sender As Object, e As EventArgs) Handles mbtLimpar.Click
        Utils.LimparForm(Me)
    End Sub







    ''PAGE LISTAR IMOVEIS ------------------------------------------------------------------------------------------------------------

    ''ATUALIZAR MGRID
    Public Sub atualizarmGridImoveis()
        Dim querryy As String = "SELECT Código as CÓDIGO, 
                                finalidade as FINALIDADE,
                                tipo as TIPO,
                                logradouro as LOGRADOURO,
                                numero as NUM, 
                                complemento as COMPL,
                                bairro as BAIRRO, 
                                cidade as CIDADE, 
                                estado as UF,
                                dormitorios as DORM,
                                suites as SUITES,
                                banheiros as BANHO, 
                                vagas as VAGAS, 
                                valor_locacao as LOCAÇÃO,
                                valor_luz as [VALOR LUZ],
                                valor_internet as [VALOR NET],
                                valor_agua as [VALOR ÁGUA],
                                contrato as CONT 
                                From imoveis"


        If mtbPesquisar.Text.Length > 0 Then
            querryy = querryy & " where logradouro like '%" & mtbPesquisar.Text & "%' or bairro like '%" & mtbPesquisar.Text & "%'"
            querryy = querryy & "or complemento like '%" & mtbPesquisar.Text & "%' or cidade like '%" & mtbPesquisar.Text & "%' or Código like '%" & mtbPesquisar.Text & "%'"

        End If

        querryy = querryy & " ORDER BY contrato DESC"
        access.ExecuteQuerry(querryy)

        mGridimoveis.DataSource = access.dt

        Dim alugado As Integer
        Dim vago As Integer

        For Each row As DataRow In access.dt.Rows
            If row("CONT") = True Then
                alugado += 1
            Else
                vago += 1
            End If
        Next

        lbVagos.Text = vago
        lbAlugados.Text = alugado
        lbTot.Text = access.dt.Rows.Count

    End Sub
    Private Sub mtbPesquisar_TextChanged(sender As Object, e As EventArgs) Handles mtbPesquisar.TextChanged
        atualizarmGridImoveis()
    End Sub
    Private Sub mGridimoveis_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles mGridimoveis.CellFormatting

        With mGridimoveis

            .Columns("CÓDIGO").Width = 60
            .Columns("CÓDIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("FINALIDADE").Width = 80
            .Columns("FINALIDADE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("TIPO").Width = 80
            .Columns("TIPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("LOGRADOURO").Width = 200
            .Columns("LOGRADOURO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("NUM").Width = 60
            .Columns("NUM").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("COMPL").Width = 80
            .Columns("COMPL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("BAIRRO").Width = 100
            .Columns("BAIRRO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("CIDADE").Width = 80
            .Columns("CIDADE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("LOCAÇÃO").Width = 80
            .Columns("LOCAÇÃO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("LOCAÇÃO").DefaultCellStyle.Format = "C2"

            .Columns("VALOR LUZ").Width = 80
            .Columns("VALOR LUZ").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("VALOR LUZ").DefaultCellStyle.Format = "C2"

            .Columns("VALOR NET").Width = 80
            .Columns("VALOR NET").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("VALOR NET").DefaultCellStyle.Format = "C2"

            .Columns("VALOR ÁGUA").Width = 80
            .Columns("VALOR ÁGUA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("VALOR ÁGUA").DefaultCellStyle.Format = "C2"

            .Columns("UF").Visible = False
            .Columns("DORM").Visible = False
            .Columns("SUITES").Visible = False
            .Columns("BANHO").Visible = False
            .Columns("VAGAS").Visible = False
            .Columns("CONT").Visible = False

            For i As Integer = 0 To mGridimoveis.Rows.Count - 1 Step +1
                Dim val As Boolean
                val = mGridimoveis.Rows(i).Cells("CONT").Value

                If val Then
                    mGridimoveis.Rows(i).DefaultCellStyle.BackColor = Color.LavenderBlush
                    mGridimoveis.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                Else
                    mGridimoveis.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
                End If
            Next
        End With
    End Sub

    ''EVENTOS DATAGRID
    Private Sub mGridimoveis_DoubleClick(sender As Object, e As EventArgs) Handles mGridimoveis.DoubleClick
        Dim frm As New AttImoveis

        AddOwnedForm(frm)

        frm.Show()

        frm.inicializador = mGridimoveis.CurrentRow.Cells(0).Value
        frm.cbbFinalidade.Text = mGridimoveis.CurrentRow.Cells(1).Value
        frm.cbbTipo.Text = mGridimoveis.CurrentRow.Cells(2).Value
        frm.mtbLogradouro.Text = mGridimoveis.CurrentRow.Cells(3).Value
        frm.mtbNum.Text = mGridimoveis.CurrentRow.Cells(4).Value
        frm.mtbComplemento.Text = mGridimoveis.CurrentRow.Cells(5).Value
        frm.mtbBairro.Text = mGridimoveis.CurrentRow.Cells(6).Value
        frm.mtbCidade.Text = mGridimoveis.CurrentRow.Cells(7).Value
        frm.mtbEstado.Text = mGridimoveis.CurrentRow.Cells(8).Value

        frm.nudDorm.Value = mGridimoveis.CurrentRow.Cells(9).Value
        frm.nudSuite.Value = mGridimoveis.CurrentRow.Cells(10).Value
        frm.nudbanho.Value = mGridimoveis.CurrentRow.Cells(11).Value
        frm.nudVagas.Value = mGridimoveis.CurrentRow.Cells(12).Value

        frm.mtbValorLocacao.Text = mGridimoveis.CurrentRow.Cells(13).Value
        frm.mtbValorAgua.Text = mGridimoveis.CurrentRow.Cells(16).Value
        frm.mtbValorLuz.Text = mGridimoveis.CurrentRow.Cells(14).Value
        frm.mtbValorNet.Text = mGridimoveis.CurrentRow.Cells(15).Value

    End Sub







    ''PAGE CADASTRO CONTRATOS ------------------------------------------------------------------------------------------------------------
    Dim control As Boolean = False






    ''BOTOES ADD 
    Private Sub mbtSelecionaImovel_Click(sender As Object, e As EventArgs) Handles mbtSelecionaImovel.Click
        Dim frm As New SelecionarImovel
        AddOwnedForm(frm)
        frm.inicializador = 1
        frm.Show()
    End Sub

    ''CBB INQUILINOS
    Public Sub preencheCBBInquilinos()
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT * FROM favorecidos")
        dt = access.dt

        With cbbInquilinos
            .DataSource = dt
            .DisplayMember = "nome"
            .ValueMember = "Código"
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        cbbInquilinos.Text = ""
        'control = True
    End Sub

    ''EVENTOS DETALHES CONTRATO
    Public Function calculaValorContrato() As Double
        If control = True Then
            Exit Function
        End If
        Dim agua, luz, internet, desconto As Double
        If mcbAgua.Checked = True Then
            agua = CType(mtbValorAguaC.Text, Double)
        Else
            agua = 0
        End If

        If mcbLuz.Checked = True Then
            luz = CType(mtbValorLuzC.Text, Double)
        Else
            luz = 0
        End If

        If mcbInternet.Checked = True Then
            internet = CType(mtbValorNetC.Text, Double)
        Else
            internet = 0
        End If

        If mtbDesconto.Text.Length > 0 Then
            desconto = CType(mtbDesconto.Text, Double)
        Else
            desconto = 0
        End If

        Return internet + luz + agua + CType(mtbValorLocacaoC.Text, Double) - desconto
    End Function
    Private Sub cbLuz_CheckedChanged(sender As Object, e As EventArgs) Handles mcbLuz.CheckedChanged
        If mtbValorLocacaoC.Text.Length > 0 Then
            mlbValorTotalContrato.Text = calculaValorContrato()
            mlbValorTotalContrato.Text = String.Format("{0:c}", Double.Parse(mlbValorTotalContrato.Text))
        End If
    End Sub
    Private Sub cbInternet_CheckedChanged(sender As Object, e As EventArgs) Handles mcbInternet.CheckedChanged
        If mtbValorLocacaoC.Text.Length > 0 Then
            mlbValorTotalContrato.Text = calculaValorContrato()
            mlbValorTotalContrato.Text = String.Format("{0:c}", Double.Parse(mlbValorTotalContrato.Text))
        End If
    End Sub
    Private Sub cbAgua_CheckedChanged(sender As Object, e As EventArgs) Handles mcbAgua.CheckedChanged
        If mtbValorLocacaoC.Text.Length > 0 Then
            mlbValorTotalContrato.Text = calculaValorContrato()
            mlbValorTotalContrato.Text = String.Format("{0:c}", Double.Parse(mlbValorTotalContrato.Text))
        End If
    End Sub
    Private Sub tbDesconto_Leave(sender As Object, e As EventArgs) Handles mtbDesconto.Leave
        If mtbValorLocacaoC.Text.Length > 0 Then
            mlbValorTotalContrato.Text = calculaValorContrato()
            mlbValorTotalContrato.Text = String.Format("{0:c}", Double.Parse(mlbValorTotalContrato.Text))
        End If
    End Sub

    ''VALIDAÇÕES
    Private Sub mtbDesconto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbDesconto.KeyPress
        If e.KeyChar = Chr(46) Then e.KeyChar = Chr(44)
        If e.KeyChar = Chr(44) And InStr(mtbDesconto.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(44) Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    Public Function validaCampos() As Integer
        If mtbValorLocacaoC.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, " É obrigatório selecionar um imóvel !", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return 1
        End If
        If cbbInquilinos.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "É obrigatório selecionar um inquilino !", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbInquilinos.Focus()
            Return 1
        End If
        If numMesesContrato.Value < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Insira a quantidade de meses do contrato ! ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            numMesesContrato.Focus()
            Return 1
        End If
        If cbbDiaVencimento.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Insira o dia do vencimento do aluguel ", "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbDiaVencimento.Focus()
            Return 1
        End If
        Return 0
    End Function

    ''CONTROLES 
    Private Sub mbtInserirC_Click(sender As Object, e As EventArgs) Handles mbtInserirC.Click
        control = True
        If validaCampos() Then
            Exit Sub
        End If
        access.paramns.Clear()

        access.AddParam("@cod_imovel", mlbCodigoImovel.Text)
        access.AddParam("@cod_inquilino", cbbInquilinos.SelectedValue)
        access.AddParam("@data_inicio", mdtDataInicial.Text)
        access.AddParam("@status", True)
        access.AddParam("@meses", numMesesContrato.Value)
        access.AddParam("@dia_vencimento", cbbDiaVencimento.Text)

        access.AddParam("@luz_incluso", IIf(mcbLuz.Checked, True, False))
        access.AddParam("@internet_incluso", IIf(mcbInternet.Checked, True, False))
        access.AddParam("@agua_incluso", IIf(mcbAgua.Checked, True, False))

        access.AddParam("@valor_luz", IIf(mcbLuz.Checked, CType(mtbValorLuzC.Text, Double), 0))
        access.AddParam("@valor_internet", IIf(mcbInternet.Checked, CType(mtbValorNetC.Text, Double), 0))
        access.AddParam("@valor_agua", IIf(mcbAgua.Checked, CType(mtbValorAguaC.Text, Double), 0))

        access.AddParam("@descontos", IIf(mtbDesconto.Text.Length >= 1, mtbDesconto.Text, 0))
        access.AddParam("@valor", CType(mlbValorTotalContrato.Text, Double))


        'insere contrato
        access.ExecuteQuerry("INSERT INTO contratos (cod_imovel, cod_inquilino, data_inicio, 
                                                     status, meses, dia_vencimento, luz_incluso, internet_incluso,
                                                      agua_incluso, valor_luz, valor_internet, valor_agua, descontos, valor_contrato) 
                                                values             
                                                    (@cod_imovel,@cod_inquilino,@data_inicio,
                                                     @status, @meses, @dia_vencimento, @luz_incluso, @internet_incluso,
                                                      @agua_incluso, @valor_luz, @valor_internet, @valor_agua, @descontos, @valor_contrato)")

        'atualiza o imovel para alugado 
        access.ExecuteQuerry("UPDATE imoveis set contrato= " & True & " where Código= " & mlbCodigoImovel.Text)


        ''insere lançamentos
        For i As Integer = 0 To numMesesContrato.Value - 1
            access.paramns.Clear()
            access.AddParam("@cod_inquilino", cbbInquilinos.SelectedValue)
            access.AddParam("@descricao", "ref mes " & mdt1Pagamento.Value.AddMonths(i - 1).Month & "/" & mdt1Pagamento.Value.AddMonths(i - 1).Year)
            access.AddParam("@data_emissao", CType(mdtDataInicial.Text, Date))
            access.AddParam("@data_vencimento", CType(mdt1Pagamento.Text, Date).AddMonths(i))
            access.AddParam("@valor", CType(mlbValorTotalContrato.Text, Double))
            access.AddParam("@observacoes", "Imovel " & mlbCodigoImovel.Text)
            access.AddParam("@imovel", mlbCodigoImovel.Text)

            access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento, n_cheque,
                             valor, observacoes, imovel) 
                                values (1,2,2,@cod_inquilino,10,'Em Aberto',@descricao,
                            @data_emissao,  @data_vencimento, '-', @valor , @observacoes, @imovel)")
        Next



        MessageBox.Show("Novo Contrato inserido com sucesso !")
        preenchemgridContratos()
        Utils.LimparForm(Me)
        control = False
    End Sub
    Private Sub mbtLimparC_Click(sender As Object, e As EventArgs) Handles mbtLimparC.Click
        Utils.LimparForm(Me)
    End Sub




    ''PAGE LISTAR CONTRATOS ------------------------------------------------------------------------------------------------------------

    ''MGRID CONTRATOS
    Public Sub preenchemgridContratos()


        Dim queryC As String
        queryC = "SELECT 
                contratos.Código as [CÓD],
                contratos.cod_imovel as [CÓD IMÓVEL],
                favorecidos.nome AS INQUILINO,
                contratos.data_inicio as [DATA INICIO],
                contratos.data_final as [DATA FINAL],
                contratos.status AS STATUS,
                contratos.descontos AS [DESC], 
                contratos.meses AS MESES,
                contratos.valor_contrato AS [VALOR CONTRATO],
                contratos.dia_vencimento AS VENC
                FROM contratos INNER JOIN favorecidos ON contratos.cod_inquilino = favorecidos.Código "

        If mtbFiltrarContratos.Text.Length > 0 Then
            queryC = queryC & " where contratos.Código like '%" & mtbFiltrarContratos.Text & "%' or contratos.cod_imovel like '%" & mtbFiltrarContratos.Text & "%'"
            queryC = queryC & "or favorecidos.nome like '%" & mtbFiltrarContratos.Text & "%' "

        End If

        queryC = queryC & " order by contratos.status asc"
        access.ExecuteQuerry(queryC)


        mgridContratos.DataSource = access.dt

        Dim ativo As Integer = 0

        For Each row As DataRow In access.dt.Rows

            If row("STATUS") = True Then
                ativo += 1
            End If

        Next

        mlbAtivos.Text = ativo
        mlbInativos.Text = access.dt.Rows.Count - ativo
        mlbTotalContratos.Text = access.dt.Rows.Count

    End Sub
    Private Sub mtbFiltrarContratos_TextChanged(sender As Object, e As EventArgs) Handles mtbFiltrarContratos.TextChanged
        preenchemgridContratos()
    End Sub
    Private Sub btNovaCategoria_Click(sender As Object, e As EventArgs) Handles btNovaCategoria.Click
        Dim frm As New AddFavorecido
        AddOwnedForm(frm)
        frm.inicializado = 1
        frm.Show()
    End Sub
    Private Sub mgridContratos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles mgridContratos.CellFormatting
        With mgridContratos
            .Columns("CÓD").Width = 60
            .Columns("CÓD IMÓVEL").Width = 60
            .Columns("INQUILINO").Width = 360
            .Columns("DATA INICIO").Width = 115
            .Columns("DATA FINAL").Width = 110
            .Columns("STATUS").Width = 60
            .Columns("DESC").Width = 60
            .Columns("MESES").Width = 60
            .Columns("VALOR CONTRATO").Width = 100
            .Columns("VENC").Width = 60



            .Columns("VALOR CONTRATO").DefaultCellStyle.Format = "C2"
            .Columns("DESC").DefaultCellStyle.Format = "C2"

        End With
        For i As Integer = 0 To mgridContratos.Rows.Count - 1 Step +1
            Dim val As Boolean
            val = mgridContratos.Rows(i).Cells(5).Value

            If val Then
                mgridContratos.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            Else
                mgridContratos.Rows(i).DefaultCellStyle.BackColor = Color.LavenderBlush
                mgridContratos.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            End If
        Next
    End Sub
    Private Sub mgridContratos_DoubleClick(sender As Object, e As EventArgs) Handles mgridContratos.DoubleClick
        Dim frm As New AttContratos
        AddOwnedForm(frm)

        frm.cod_contrato = mgridContratos.CurrentRow.Cells(0).Value
        frm.cod_inquilino = retornaCodFavorecido(mgridContratos.CurrentRow.Cells(2).Value)
        frm.cod_imovel = mgridContratos.CurrentRow.Cells(1).Value
        frm.cod_imovel_inicial = mgridContratos.CurrentRow.Cells(1).Value
        frm.nome_inquilino = mgridContratos.CurrentRow.Cells(2).Value
        frm.mdtDataInicial.Text = mgridContratos.CurrentRow.Cells(3).Value
        frm.numMesesContrato.Value = mgridContratos.CurrentRow.Cells(7).Value
        frm.cbbDiaVencimento.Text = mgridContratos.CurrentRow.Cells(9).Value
        frm.mtbDesconto.Text = mgridContratos.CurrentRow.Cells(6).Value
        frm.edita = mgridContratos.CurrentRow.Cells(5).Value

        frm.Show()
    End Sub

    ''AUXILIAR
    Private Function retornaCodFavorecido(ByVal nome As String) As Integer
        access.ExecuteQuerry("SELECT * FROM favorecidos WHERE nome = '" & nome & "'")

        For Each row As DataRow In access.dt.Rows
            Return CType(row("Código"), Integer)
        Next
        Return 0
    End Function







    ''CARREGAMENTO TELAS 
    Public Sub CarregaAddImovel()
        mtbValorAgua.Text = 0
        mtbValorLocacao.Text = 0
        mtbValorLuz.Text = 0
        mtbValorNet.Text = 0
        mlbNomeTela.Text = "Cadastrar Novo Imóvel"
    End Sub
    Public Sub CarregaListaImovel()
        atualizarmGridImoveis()
        mlbNomeTela.Text = "Listar Imóveis"
    End Sub
    Sub CarregaAddContrato()
        mlbNomeTela.Text = "Cadastrar Novo Contrato"
        preencheCBBInquilinos()
        mtbEndereco.Enabled = False
        mtbComplementoC.Enabled = False
        mtbFinalidade.Enabled = False
        mtbTipo.Enabled = False
        mtbValorLuzC.Enabled = False
        mtbValorNetC.Enabled = False
        mtbValorLocacaoC.Enabled = False
        mtbValorAguaC.Enabled = False
    End Sub
    Sub CarregaListaContrato()
        mlbNomeTela.Text = "Listar Contratos"
        preenchemgridContratos()
    End Sub
    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mtabControlImoveis.SelectedIndexChanged
        Select Case mtabControlImoveis.SelectedIndex
            Case 0
                CarregaAddImovel()
            Case 1
                CarregaListaImovel()
            Case 2
                CarregaAddContrato()
            Case 3
                CarregaListaContrato()
        End Select
    End Sub


End Class