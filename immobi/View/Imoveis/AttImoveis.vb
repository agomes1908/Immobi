Public Class AttImoveis

    Dim x, y As Integer
    Dim NewPoint As New Point
    Public inicializador As Integer ' 0 - novo, 1++ - editar
    Dim access As New Controller



    ''CONTROLES
    Private Sub mbtAtualizar_Click(sender As Object, e As EventArgs) Handles mbtAtualizar.Click
        access.AddParam("@logradouro", mtbLogradouro.Text)
        access.AddParam("@numero", mtbNum.Text)
        access.AddParam("@complemento", mtbComplemento.Text)
        access.AddParam("@bairro", mtbBairro.Text)
        access.AddParam("@cidade", mtbCidade.Text)
        access.AddParam("@estado", mtbEstado.Text)
        access.AddParam("@finalidade", cbbFinalidade.Text)
        access.AddParam("@tipo", cbbTipo.Text)
        access.AddParam("@dormitorios", nudDorm.Value)
        access.AddParam("@suites", nudSuite.Value)
        access.AddParam("@banheiros", nudbanho.Value)
        access.AddParam("@vagas", nudVagas.Value)
        access.AddParam("@valor_locacao", CType(mtbValorLocacao.Text, Double))
        access.AddParam("@valor_luz", mtbValorLuz.Text)
        access.AddParam("@valor_internet", mtbValorNet.Text)
        access.AddParam("@valor_agua", mtbValorAgua.Text)


        access.ExecuteQuerry("UPDATE imoveis SET logradouro=@logradouro, numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,     
                                                estado=@estado,finalidade=@finalidade,tipo=@tipo,dormitorios=@dormitorios,
                                                suites=@suites,banheiros=@banheiros,vagas=@vagas,valor_locacao=@valor_locacao,
                                                valor_luz=@valor_luz,valor_internet=@valor_internet,valor_agua=@valor_agua WHERE Código = " & inicializador)

        'atualizar lançamentos em aberto  e contrato

        atualizaContrato(mtbValorLocacao.Text, mtbValorLuz.Text, mtbValorNet.Text, mtbValorAgua.Text, inicializador)

        Dim frmImoveis As Imoveis = CType(Owner, Imoveis)
        frmImoveis.atualizarmGridImoveis()
        Me.Close()
    End Sub
    Private Sub mbtExcluir_Click(sender As Object, e As EventArgs) Handles mbtExcluir.Click

        Dim frmImoveis As Imoveis = CType(Owner, Imoveis)

        If MetroFramework.MetroMessageBox.Show(Me, "Você tem certeza que deseja remover o Imóvel selecionado ?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then


            Dim dt As DataTable = New DataTable
            access.ExecuteQuerry("SELECT imovel FROM lancamentos")
            dt = access.dt
            For Each row As DataRow In dt.Rows
                If Not row("imovel") Is DBNull.Value Then
                    If inicializador = row("imovel") Then
                        MetroFramework.MetroMessageBox.Show(Me, "Existem lançamentos para o Imóvel selecionado. Apague os registros e tente novamente  ! ",
                                                        "Impossível Excluir !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            Next

            Dim dt2 As DataTable = New DataTable
            access.ExecuteQuerry("SELECT cod_imovel FROM contratos")
            dt2 = access.dt
            For Each row As DataRow In dt2.Rows
                If inicializador = row("cod_imovel") Then
                    MetroFramework.MetroMessageBox.Show(Me, "O Imóvel selecionado está em um contrato. Exclua o contrato e tente novamente ! ",
                                                        "Impossível Excluir !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            access.ExecuteQuerry("DELETE FROM imoveis WHERE Código = " & inicializador)
                frmImoveis.atualizarmGridImoveis()
                Me.Close()
            End If

    End Sub

    ''AUX
    Public Sub atualizaContrato(ByVal valor_locacao As Double, ByVal valor_luz As Double, ByVal valor_net As Double, ByVal valor_agua As Double, ByVal codigo_imovel As Integer)

        'atualizar valor contrato 

        access.ExecuteQuerry("SELECT * FROM contratos")
        Dim dt As DataTable = New DataTable
        dt = access.dt
        Dim valor_contrato As Double

        For Each row As DataRow In dt.Rows
            If row("cod_imovel") = codigo_imovel Then

                Dim luz As Double = IIf(row("luz_incluso") = True, valor_luz, 0)
                Dim agua As Double = IIf(row("agua_incluso") = True, valor_agua, 0)
                Dim net As Double = IIf(row("internet_incluso") = True, valor_net, 0)
                valor_contrato = valor_locacao + luz + agua + net - CType(row("descontos"), Double)

                access.AddParam("@valor_luz", luz)
                access.AddParam("@valor_internet", net)
                access.AddParam("@valor_agua", agua)
                access.AddParam("@valor_contrato", valor_locacao + luz + agua + net - CType(row("descontos"), Double))

                access.ExecuteQuerry("UPDATE contratos 
                            SET     

                                valor_luz = @valor,
                                valor_internet = @dia_vencimento,
                                valor_agua = @valor_agua,
                                valor_contrato = @valor_contrato,
                                status = true 
                            WHERE

                                Código = " & row("Código"))

            End If
        Next

        'atualizar lançamentos em aberto 
        Dim dt1 As DataTable = New DataTable
        Dim valor_aluguel As Double = valor_contrato
        access.ExecuteQuerry("SELECT * FROM lancamentos")
        dt1 = access.dt

        For Each row As DataRow In dt1.Rows

            If row("status") = "Em Aberto" Then
                If row("cod_planoContas") = 10 Then
                    If row("imovel") = codigo_imovel Then

                        access.AddParam("@valor_contrato", valor_contrato)
                        access.ExecuteQuerry("UPDATE lancamentos set valor = @valor_contrato where Código = " & row("Código"))

                    End If
                End If
            End If
        Next


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