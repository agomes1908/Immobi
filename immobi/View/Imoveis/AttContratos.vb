Public Class AttContratos
    Dim x, y As Integer
    Dim NewPoint As New Point

    Public cod_contrato As Integer
    Public cod_imovel As Integer
    Public cod_inquilino As Integer
    Public nome_inquilino As String
    Dim access As New Controller
    Dim controle As Boolean = False
    Public cod_imovel_inicial As Integer
    Public edita As Boolean
    Dim desc As Double

    ''SHOWN
    Private Sub AttContratos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        preencheCBBInquilinos()
        preencheDadosImoveis(cod_imovel)
        preencheDadosContrato(cod_contrato)

        If edita = True Then
            mbtEditarContrato.Enabled = False
            mbtExcluirContrato.Enabled = False
            mbtrenovarCotnrato.Visible = False
            mbtFinalizarContrato.Visible = True

            gbImoveis.Enabled = False
            gbDetalhesContrato.Enabled = False
            gbinquilino.Enabled = False
        Else
            mbtrenovarCotnrato.Visible = True
            mbtFinalizarContrato.Visible = False
            mtbDesconto.Enabled = True
        End If
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
        cbbInquilinos.Text = nome_inquilino

    End Sub

    ''GROUP BOX IMOVEIS
    Public Sub preencheDadosImoveis(ByVal cod_imovel As Integer)
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT * FROM imoveis where Código = " & cod_imovel)

        dt = access.dt

        For Each row As DataRow In dt.Rows

            mlbCodigoImovel.Text = row("Código")
            mtbEndereco.Text = row("logradouro") & " " &
                                  row("numero") & ", " &
                                  row("bairro") & " - " &
                                  row("cidade") & "/" & row("estado")
            mtbFinalidade.Text = row("finalidade")
            mtbTipo.Text = row("tipo")
            mtbComplementoC.Text = row("complemento")

            mtbValorAguaC.Text = row("valor_agua")
            mtbValorNetC.Text = row("valor_internet")
            mtbValorLuzC.Text = row("valor_luz")
            mtbValorLocacaoC.Text = row("valor_locacao")

            mtbValorAguaC.Text = String.Format("{0:c}", Double.Parse(mtbValorAguaC.Text))
            mtbValorNetC.Text = String.Format("{0:c}", Double.Parse(mtbValorNetC.Text))
            mtbValorLuzC.Text = String.Format("{0:c}", Double.Parse(mtbValorLuzC.Text))
            mtbValorLocacaoC.Text = String.Format("{0:c}", Double.Parse(mtbValorLocacaoC.Text))

        Next
    End Sub

    ''GROUP BOX DETALHES CONTRATO 
    Public Sub preencheDadosContrato(ByVal cod_contrato As Integer)

        access.ExecuteQuerry("SELECT * from contratos where Código = " & cod_contrato)

        For Each row As DataRow In access.dt.Rows

            mdtDataInicial.Value = row("data_inicio")
            cbbDiaVencimento.Text = row("dia_vencimento")
            numMesesContrato.Value = row("meses")

            If row("luz_incluso") = True Then
                mcbLuz.Checked = True
            End If
            If row("internet_incluso") = True Then
                mcbInternet.Checked = True
            End If
            If row("agua_incluso") = True Then
                mcbAgua.Checked = True
            End If

            mtbDesconto.Text = row("descontos")

            mlbValorTotalContrato.Text = row("valor_contrato")
            mlbValorTotalContrato.Text = String.Format("{0:c}", Double.Parse(mlbValorTotalContrato.Text))

        Next



    End Sub

    ''BOTOES ADD 
    Private Sub mbtSelecionaImovel_Click(sender As Object, e As EventArgs) Handles mbtSelecionaImovel.Click
        Dim frm As New SelecionarImovel
        AddOwnedForm(frm)
        frm.inicializador = 4
        frm.Show()
    End Sub

    ''EVENTOS DETALHES CONTRATO
    Public Function calculaValorContrato() As Double

        If controle = True Then
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
    Private Sub btEditaContrato_Click(sender As Object, e As EventArgs) Handles mbtEditarContrato.Click
        Dim frm As Imoveis = CType(Owner, Imoveis)

        If mlbCodigoImovel.Text <> cod_imovel_inicial Then
            access.ExecuteQuerry("UPDATE imoveis SET contrato = false WHERE  Código = " & cod_imovel_inicial)
            access.ExecuteQuerry("UPDATE imoveis SET contrato = true WHERE  Código = " & mlbCodigoImovel.Text)
        End If

        access.paramns.Clear()

        access.AddParam("@cod_imovel", mlbCodigoImovel.Text)
        access.AddParam("@cod_inquilino", cbbInquilinos.SelectedValue)
        access.AddParam("@data_inicio", mdtDataInicial.Value)
        access.AddParam("@meses", numMesesContrato.Value)
        access.AddParam("@dia_vencimento", cbbDiaVencimento.Text)

        access.AddParam("@luz_incluso", IIf(mcbLuz.Checked, True, False))
        access.AddParam("@internet_incluso", IIf(mcbInternet.Checked, True, False))
        access.AddParam("@agua_incluso", IIf(mcbAgua.Checked, True, False))

        access.AddParam("@valor_luz", IIf(mcbLuz.Checked, CType(mtbValorLuzC.Text, Double), 0))
        access.AddParam("@valor_internet", IIf(mcbInternet.Checked, CType(mtbValorNetC.Text, Double), 0))
        access.AddParam("@valor_agua", IIf(mcbAgua.Checked, CType(mtbValorAguaC.Text, Double), 0))

        access.AddParam("@descontos", IIf(mtbDesconto.Text.Length >= 1, mtbDesconto.Text, 0))

        access.AddParam("@valor_contrato", calculaValorContrato())

        access.ExecuteQuerry("UPDATE contratos 
                            SET     
                                cod_imovel = @cod_imovel,
                                cod_inquilino = @cod_inquilino,
                                data_inicio = @data_inicio,
                                meses = @meses,
                                dia_vencimento = @dia_vencimento,
                                luz_incluso = @luz_incluso,
                                internet_incluso = @internet_incluso,
                                agua_incluso = @agua_incluso,
                                valor_luz = @valor_luz,
                                valor_internet = @valor_internet,
                                valor_agua = @valor_agua,
                                descontos = @descontos,
                                valor_contrato = @valor_contrato

                            WHERE

                                Código = " & cod_contrato)


        MessageBox.Show("Contrato Atualizado com sucesso !")

        frm.preenchemgridContratos()
        Me.Close()
    End Sub
    Private Sub btFinalizaContrato_Click(sender As Object, e As EventArgs) Handles mbtFinalizarContrato.Click

        Dim frm As Imoveis = CType(Owner, Imoveis)
        access.AddParam("@data_final", Today())


        access.ExecuteQuerry("UPDATE contratos SET  status = false, data_final = @data_final WHERE Código = " & cod_contrato)
        access.ExecuteQuerry("UPDATE imoveis SET  contrato = false WHERE Código = " & cod_imovel)



        'finaliza todos os lançamentos em aberto daquele imóvel
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT * FROM lancamentos")

        dt = access.dt

        For Each row As DataRow In dt.Rows

            If row("status") = "Em Aberto" Then
                If row("cod_planoContas") = 10 Then
                    If row("imovel") = mlbCodigoImovel.Text Then
                        access.ExecuteQuerry("DELETE FROM lancamentos where Código = " & row("Código"))
                    End If
                End If
            End If
        Next

        MessageBox.Show("Contrato Finalizado com sucesso !")
        frm.preenchemgridContratos()
        Me.Close()
    End Sub
    Private Sub btExcluiContrato_Click(sender As Object, e As EventArgs) Handles mbtExcluirContrato.Click

        Dim frm As Imoveis = CType(Owner, Imoveis)

        access.ExecuteQuerry("DELETE FROM contratos WHERE Código = " & cod_contrato)
        'access.ExecuteQuerry("UPDATE imoveis SET  contrato = false WHERE Código = " & cod_imovel)


        MessageBox.Show("Contrato Excluido com sucesso !")

        frm.preenchemgridContratos()
        Me.Close()
    End Sub
    Private Sub btRenovarContrato_Click(sender As Object, e As EventArgs) Handles mbtrenovarCotnrato.Click

        access.ExecuteQuerry("SELECT * FROM imoveis WHERE Código = " & mlbCodigoImovel.Text)

        For Each row As DataRow In access.dt.Rows
            If row("contrato") = True Then
                MessageBox.Show("O Imovél selecionado já se encontra alugado. Verifique !")
                Exit Sub
            End If
        Next


        'atualiza o imovel para alugado 
        access.ExecuteQuerry("UPDATE imoveis set contrato= " & True & " where Código= " & mlbCodigoImovel.Text)

        ''insere lançamentos

        For i As Integer = 0 To numMesesContrato.Value - 1
            access.paramns.Clear()
            access.AddParam("@cod_inquilino", cbbInquilinos.SelectedValue)
            access.AddParam("@descricao", "ref mes " & mdt1Pagamento.Value.AddMonths(i - 1).Month & "/" & mdt1Pagamento.Value.AddMonths(i - 1).Year)
            access.AddParam("@data_emissao", CType(mdtDataInicial.Text, Date))
            access.AddParam("@data_vencimento", CType(mdt1Pagamento.Text, Date).AddMonths(i))
            access.AddParam("@valor", calculaValorContrato())
            access.AddParam("@observacoes", "Imovel " & mlbCodigoImovel.Text)
            access.AddParam("@imovel", mlbCodigoImovel.Text)

            access.ExecuteQuerry("INSERT INTO lancamentos (tipo_lancamento, cod_cenCusto, cod_conta,                         
                            cod_favorecidos, cod_planoContas, status, descricao, data_emissao, data_vencimento,
                             valor, observacoes, imovel) 
                                values (1,2,2,@cod_inquilino,10,'Em Aberto',@descricao,
                            @data_emissao,  @data_vencimento , @valor , @observacoes, @imovel)")
        Next

        ''atualiza o contrato para ativo 
        access.AddParam("@meses", numMesesContrato.Value)
        access.AddParam("@valor", calculaValorContrato())
        access.AddParam("@dia_vencimento", cbbDiaVencimento.Text)

        access.ExecuteQuerry("UPDATE contratos 
                            SET     
                                meses = @meses,
                                valor_contrato = @valor,
                                dia_vencimento = @dia_vencimento,
                                status = true 
                            WHERE

                                Código = " & cod_contrato)

        MessageBox.Show("Contrato renovado com sucesso !")

        Dim frm As Imoveis = CType(Owner, Imoveis)
        frm.preenchemgridContratos()
        Me.Close()
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
    Private Sub mbtSair_Click(sender As Object, e As EventArgs) Handles mbtSair.Click
        Me.Close()
    End Sub


End Class