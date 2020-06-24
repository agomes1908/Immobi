Public Class Utils
    ''' <summary>
    ''' Método que recebe um formulário e preenche com "" os controles : TextBox, MaskedTextBox, ComboBox e CheckBox
    ''' </summary>
    ''' <param name="controlP">Formulario a ser limpo</param>
    ''' <remarks></remarks>
    Public Shared Sub LimparForm(ByVal controlP As Control)

        Dim ctl As Control

        For Each ctl In controlP.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = String.Empty
            ElseIf TypeOf ctl Is MaskedTextBox Then
                DirectCast(ctl, MaskedTextBox).Text = String.Empty
            ElseIf TypeOf ctl Is ComboBox Then
                DirectCast(ctl, ComboBox).Text = String.Empty
            ElseIf TypeOf ctl Is CheckBox Then
                DirectCast(ctl, CheckBox).Checked = False
            ElseIf ctl.Controls.Count > 0 Then
                LimparForm(ctl)
            End If
        Next

    End Sub



    ''' <summary>
    ''' Método que Insere um novo registro na tabela de Imóveis
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Sub InsertImoveis(ByVal logradouro As String, ByVal numero As String, ByVal complemento As String,
                                    ByVal bairro As String, ByVal cidade As String, ByVal estado As String,
                                    ByVal finalidade As String, ByVal tipo As String, ByVal dormitorios As Integer,
                                    ByVal suites As Integer, ByVal banheiros As Integer, ByVal vagas As Integer,
                                    ByVal valor_locacao As Double, ByVal valor_luz As Double, ByVal valor_internet As Double,
                                    ByVal valor_agua As Double, ByVal contrato As Boolean)
        Dim access As New Controller

        access.paramns.Clear()

        access.AddParam("@logradouro", logradouro)
        access.AddParam("@numero", numero)
        access.AddParam("@complemento", complemento)
        access.AddParam("@bairro", bairro)
        access.AddParam("@cidade", cidade)
        access.AddParam("@estado", estado)
        access.AddParam("@finalidade", finalidade)
        access.AddParam("@tipo", tipo)
        access.AddParam("@dormitorios", dormitorios)
        access.AddParam("@suites", suites)
        access.AddParam("@banheiros", banheiros)
        access.AddParam("@vagas", vagas)

        access.AddParam("@valor_locacao", valor_locacao)
        access.AddParam("@valor_luz", valor_luz)
        access.AddParam("@valor_internet", valor_internet)
        access.AddParam("@valor_agua", valor_agua)

        access.AddParam("@contrato", contrato)



        access.ExecuteQuerry("INSERT INTO imoveis (logradouro,numero,complemento,bairro,cidade,
                        estado,finalidade,tipo,dormitorios,suites,banheiros,vagas,valor_locacao,
                        valor_luz,valor_internet,valor_agua,contrato)
                        values(@logradouro,@numero,@complemento,@bairro,@cidade,
                        @estado,@finalidade,@tipo,@dormitorios,@suites,@banheiros,@vagas,@valor_locacao,
                        @valor_luz,@valor_internet,@valor_agua,@contrato)")


    End Sub



    ''' <summary>
    ''' Método que atualiza o saldo atual de uma conta, 
    ''' calculando todos os seus lançamentos(Valores negativos subtraem, positivos somam)
    ''' </summary>
    ''' <param name="codigo">Código da conta</param>
    ''' <remarks></remarks>
    Public Shared Sub atualizaSaldoAtualConta(ByVal codigo As Integer)

        Dim access As New Controller
        Dim dt As DataTable = New DataTable
        Dim dt1 As DataTable = New DataTable
        Dim dt2 As DataTable = New DataTable
        Dim dt3 As DataTable = New DataTable
        Dim receitas As Double
        Dim despesas As Double
        Dim novo_valor As Double
        Dim valor_transferencias As Double
        Dim aux As Double
        Dim aux2 As Double
        Dim saldo_inicial As Double


        Try
            access.ExecuteQuerry("SELECT sum(valor) as valor FROM lancamentos WHERE cod_conta = " & codigo &
                                 " and status = 'Pago' and tipo_lancamento = 1 ")
            dt = access.dt
            For Each row As DataRow In dt.Rows
                receitas = row("valor")
            Next
        Catch ex As Exception
            receitas = 0
        End Try
        Console.WriteLine("Receitas : " & receitas)
        Try
            access.ExecuteQuerry("SELECT sum(valor) as valor FROM lancamentos WHERE cod_conta = " & codigo &
                                 " and status = 'Pago' and tipo_lancamento = 2 ")
            dt = access.dt
            For Each row As DataRow In dt.Rows
                despesas = row("valor")
            Next
        Catch ex As Exception
            despesas = 0
        End Try
        Console.WriteLine("Despesas : " & despesas)
        Try
            access.ExecuteQuerry("SELECT sum(valor) as valor FROM transferencias WHERE cod_cOrigem = " & codigo)
            dt1 = access.dt
            For Each row As DataRow In dt1.Rows
                aux2 = row("valor")
            Next
        Catch ex As Exception
            aux2 = 0
        End Try
        Console.WriteLine("Transferencia saida : " & aux2)
        Try
            access.ExecuteQuerry("SELECT sum(valor) as valor FROM transferencias WHERE con_cDestino = " & codigo)
            dt2 = access.dt
            For Each row As DataRow In dt2.Rows
                aux = row("valor")
            Next
        Catch ex As Exception
            aux = 0
        End Try

        access.ExecuteQuerry("SELECT saldo_inicial from conta where Código = " & codigo)
        dt3 = access.dt
        For Each row As DataRow In dt3.Rows
            saldo_inicial = row("saldo_inicial")
        Next

        Console.WriteLine("Transferencia entrada : " & aux)
        Console.WriteLine("Saldo Inicial : " & saldo_inicial)

        valor_transferencias = aux - aux2
        novo_valor = ((receitas - despesas) + valor_transferencias) + saldo_inicial

        updateSaldoConta(codigo, novo_valor)

    End Sub

    ''' <summary>
    ''' Método que realiza o update no banco 
    ''' </summary>
    ''' <param name="codigo">Código da conta</param>
    ''' <param name="novoValor">Valor a ser debitado ou subtraido da conta</param>
    ''' <remarks></remarks>
    Public Shared Sub updateSaldoConta(ByVal codigo As Integer, ByVal novoValor As Double)
        Dim access As New Controller

        access.ExecuteQuerry("UPDATE conta SET saldo_atual='" & novoValor &
                     "' WHERE Código = " & codigo)
    End Sub


    Public Shared Sub atualizaTodasContas()
        Dim access As New Controller
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT Código as COD FROM conta")

        dt = access.dt

        For Each row As DataRow In dt.Rows
            atualizaSaldoAtualConta(row("COD"))
        Next

    End Sub




End Class
