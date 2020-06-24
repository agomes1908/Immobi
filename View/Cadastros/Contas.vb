Public Class Contas
    Dim access As New Controller
    Dim n_conta As String
    Dim descricao As String


    ''SHOWN
    Private Sub Contas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AtualizaRegistro()
        MtcContas.SelectTab(1)
        mcbTipoConta.Focus()
    End Sub

    ''MUDANÇA DE PÁGINA 
    Private Sub MtcContas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MtcContas.SelectedIndexChanged
        If MtcContas.SelectedIndex = 0 Then
            mlbNomeTela.Text = "Cadastrar Nova Conta"
        Else
            mlbNomeTela.Text = "Listar Todas Contas"
        End If
    End Sub


    ''PAGE CADASTRAR ----------------------------------------------------------------------------------------
    Private Function validaCampos() As Integer
        Dim dt As DataTable = New DataTable
        access.ExecuteQuerry("SELECT num_conta, descricao FROM conta")
        dt = access.dt
        For Each row As DataRow In dt.Rows
            If mtbNConta.Text = row("num_conta") Or mtbDescricao.Text = row("descricao") Then
                If row("num_conta") <> n_conta And row("descricao") <> descricao Then
                    MetroFramework.MetroMessageBox.Show(Me, "A conta " & mtbNConta.Text & " - " & mtbDescricao.Text & " já existe na base de dados, verifique ! ",
                                                        "Impossível Cadastrar !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return 0
                End If
            End If
        Next
        If mcbTipoConta.Text.Length < 1 Or
                mtbInstituicao.Text.Length < 1 Or
                mtbAgencia.Text.Length < 1 Or
                mtbNConta.Text.Length < 1 Or
                mtbSaldoInicial.Text.Length < 1 Then

            MetroFramework.MetroMessageBox.Show(Me, "É obrigatório o preenchimento de todos os campos ! ",
                                                        "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return 0
        Else
            Return 1
        End If
    End Function

    ''CRUD
    Private Sub mbtSalvar_Click(sender As Object, e As EventArgs) Handles mbtSalvar.Click
        If NovaConta() Then
            AtualizaRegistro()
        End If
    End Sub
    Private Function NovaConta() As Integer
        If validaCampos() Then
            access.AddParam("@descricao", mtbDescricao.Text)
            access.AddParam("@tipo", mcbTipoConta.Text)
            access.AddParam("@instituicao", mtbInstituicao.Text)
            access.AddParam("@agencia", mtbAgencia.Text)
            access.AddParam("@nConta", mtbNConta.Text)
            access.AddParam("@saldoInicial", mtbSaldoInicial.Text)
            access.AddParam("@saldoAtual", mtbSaldoInicial.Text)
            access.ExecuteQuerry("INSERT INTO CONTA (descricao, tipo, instituicao, agencia, num_conta, saldo_inicial, saldo_atual) 
                                VALUES(@descricao, @tipo, @instituicao, @agencia, @nConta, @saldoInicial, @saldo_atual)")

            MetroFramework.MetroMessageBox.Show(Me, "Conta criada com sucesso ! ",
                                                        "Sucesso ! ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Utils.LimparForm(Me)
            Return 1
        End If
        Return 0
    End Function


    ''PAGE LISTAR  ----------------------------------------------------------------------------------------

    ''DGV CONTAS
    Public Sub AtualizaRegistro()
        access.ExecuteQuerry("SELECT Código as CÓDIGO, 
                            descricao as DESCRIÇÃO,
                            tipo as TIPO,
                            instituicao as INSTITUIÇÃO,
                            agencia as AGÊNCIA,
                            num_conta as [NÚMERO CONTA],
                            saldo_atual as [SALDO ATUAL]
                            FROM conta")
        mGridContas.DataSource = access.dt
        mlbTotfavorecidos.Text = access.dt.Rows.Count & " Contas encontradas"
    End Sub
    Private Sub mGridContas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles mGridContas.CellFormatting

        If e.Value <> Nothing Then
            If e.ColumnIndex = 6 Then
                If e.Value < 0 Then
                    mGridContas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
                End If
            End If
        End If


        With mGridContas

            .Columns("CÓDIGO").Width = 60
            .Columns("CÓDIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("DESCRIÇÃO").Width = 230
            .Columns("DESCRIÇÃO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("TIPO").Width = 100
            .Columns("TIPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("INSTITUIÇÃO").Width = 230
            .Columns("INSTITUIÇÃO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("AGÊNCIA").Width = 60
            .Columns("AGÊNCIA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("NÚMERO CONTA").Width = 150
            .Columns("NÚMERO CONTA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("SALDO ATUAL").Width = 90
            .Columns("SALDO ATUAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("SALDO ATUAL").DefaultCellStyle.Format = "C2"
        End With


    End Sub
    Private Sub mGridContas_DoubleClick(sender As Object, e As EventArgs) Handles mGridContas.DoubleClick
        Dim frm As New AttContas
        frm.inicializador = mGridContas.CurrentRow.Cells(0).Value
        AddOwnedForm(frm)
        frm.Show()
    End Sub


End Class