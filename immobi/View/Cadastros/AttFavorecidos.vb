Public Class AttFavorecidos
    Dim x, y As Integer
    Dim NewPoint As New Point
    Public inicializador As Integer
    Dim access As New Controller
    Dim nome As String

    ''SHOWN
    Private Sub AttFavorecidos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim dt As DataTable = New DataTable
        Access.ExecuteQuerry("SELECT * from favorecidos where código Like '" & inicializador & "'")
        dt = Access.dt
        For Each row As DataRow In dt.Rows

            mtbNome.Text = row("nome").ToString
            mtbNumero.Text = row("numero").ToString
            mtbLogradouro.Text = row("logradouro").ToString
            mtbBairro.Text = row("bairro").ToString
            mtbCidade.Text = row("cidade").ToString
            mtbEstado.Text = row("uf").ToString
            mtbTel1.Text = row("telefone1").ToString
            mtbTel2.Text = row("telefone2").ToString
            mtbEmail.Text = row("email").ToString

            nome = row("nome").ToString
        Next
    End Sub

    ''CONTROLES
    Private Sub mbtSair_Click(sender As Object, e As EventArgs) Handles mbtSair.Click
        Me.Close()
    End Sub

    ''CRUD
    Private Sub mbtAtualizar_Click(sender As Object, e As EventArgs) Handles mbtAtualizar.Click

        If validaCampos() Then
            Exit Sub
        End If
        Dim frm As Favorecidos = CType(Owner, Favorecidos)
        access.AddParam("@código", inicializador)
        access.ExecuteQuerry("UPDATE favorecidos SET nome='" & mtbNome.Text &
                             "', logradouro = '" & mtbLogradouro.Text &
                             "', numero = '" & mtbNumero.Text &
                             "', bairro = '" & mtbBairro.Text &
                             "', cidade = '" & mtbCidade.Text &
                             "', uf = '" & mtbEstado.Text &
                             "', telefone1 = '" & mtbTel1.Text &
                             "', telefone2 = '" & mtbTel2.Text &
                             "', email = '" & mtbEmail.Text &
                             "' WHERE Código = @código")
        MetroFramework.MetroMessageBox.Show(Me, "Favorecido  " & mtbNome.Text & " atualizado com sucesso ! ",
                                                        "Sucesso ! ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frm.pPesquisa()

        Me.Close()
    End Sub
    Private Sub mbtExcluir_Click(sender As Object, e As EventArgs) Handles mbtExcluir.Click
        Dim frm As Favorecidos = CType(Owner, Favorecidos)

        If MetroFramework.MetroMessageBox.Show(Me, "Você tem certeza que deseja remover o favorecido " & mtbNome.Text & " ?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

            Dim dt As DataTable = New DataTable
            access.ExecuteQuerry("SELECT cod_favorecidos FROM lancamentos")
            dt = access.dt
            For Each row As DataRow In dt.Rows
                If inicializador = row("cod_favorecidos") Then
                    MetroFramework.MetroMessageBox.Show(Me, "Existem lançamentos com o favorecido " & mtbNome.Text & ". Apague os registros e tente novamente  ! ",
                                                        "Impossível Excluir !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next
            access.AddParam("@registro", inicializador)
            access.ExecuteQuerry("DELETE FROM favorecidos WHERE CÓDIGO = @registro")
            frm.pPesquisa()
            Me.Close()
        End If
    End Sub
    Private Function validaCampos() As Integer
        Dim dt As DataTable = New DataTable
        access.ExecuteQuerry("SELECT nome FROM favorecidos")
        dt = access.dt
        For Each row As DataRow In dt.Rows
            If mtbNome.Text = row("nome") Then
                If row("nome") <> nome Then
                    MetroFramework.MetroMessageBox.Show(Me, "O favorecido " & mtbNome.Text & " já existe na base de dados, verifique ! ",
                                                        "Impossível Cadastrar !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return 1
                End If
            End If
        Next
        If mtbNome.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo NOME FAVORECIDO é obrigatório, verifique por favor. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return 1
        End If
        Return 0
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


End Class