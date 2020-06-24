Public Class AttContas
    Dim x, y As Integer
    Dim NewPoint As New Point
    Public inicializador As Integer
    Dim access As New Controller
    Dim nome As String
    Dim n_conta As String
    Dim descricao As String


    ''SHOWN
    Private Sub AttContas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        preencheForm()
    End Sub

    ''CRUD
    Private Sub mbtAtualizar_Click(sender As Object, e As EventArgs) Handles mbtAtualizar.Click
        Dim frm As Contas = CType(Owner, Contas)
        If validaCampos() Then
            access.AddParam("@código", inicializador)

            access.ExecuteQuerry("UPDATE conta SET tipo='" & mcbTipoConta.Text &
                                 "', descricao = '" & mtbDescricao.Text &
                                 "', instituicao = '" & mtbInstituicao.Text &
                                 "', agencia = '" & mtbAgencia.Text &
                                 "', num_conta = '" & mtbNConta.Text &
                                 "' WHERE Código = @código")

            MetroFramework.MetroMessageBox.Show(Me, "Conta atualizada com sucesso ! ",
                                                        "Sucesso ! ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frm.AtualizaRegistro()
            Me.Close()
        End If
    End Sub
    Private Sub mbtExcluir_Click(sender As Object, e As EventArgs) Handles mbtExcluir.Click
        Dim frm As Contas = CType(Owner, Contas)

        If MetroFramework.MetroMessageBox.Show(Me, "Você tem certeza que deseja remover a Conta " & mtbNConta.Text & " - " & mtbDescricao.Text & " ?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

            Dim dt As DataTable = New DataTable
            access.ExecuteQuerry("SELECT cod_conta FROM lancamentos")
            dt = access.dt
            For Each row As DataRow In dt.Rows
                If inicializador = row("cod_conta") Then
                    MetroFramework.MetroMessageBox.Show(Me, "Existem lançamentos para a conta " & mtbNConta.Text & " - " & mtbDescricao.Text & ". Apague os registros e tente novamente  ! ",
                                                        "Impossível Excluir !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            access.AddParam("@registro", inicializador)
            access.ExecuteQuerry("DELETE FROM conta WHERE CÓDIGO = @registro")
            frm.AtualizaRegistro()
            Me.Close()
        End If
    End Sub

    ''AUX
    Private Sub preencheForm()
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT * from conta where código Like '" & inicializador & "'")
        dt = access.dt

        For Each row As DataRow In dt.Rows

            mcbTipoConta.Text = row("tipo").ToString
            mtbInstituicao.Text = row("instituicao").ToString
            mtbAgencia.Text = row("agencia").ToString
            mtbNConta.Text = row("num_conta").ToString
            mtbDescricao.Text = row("descricao").ToString
            mtbSaldoInicial.Text = row("saldo_Atual").ToString

            n_conta = row("num_conta").ToString
            descricao = row("descricao").ToString

            mtbSaldoInicial.Text = String.Format("{0:c}", Double.Parse(mtbSaldoInicial.Text))
            mtbSaldoInicial.Enabled = False

        Next
    End Sub
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