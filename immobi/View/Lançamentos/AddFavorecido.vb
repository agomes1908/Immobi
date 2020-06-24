Public Class AddFavorecido
    Dim access As New Controller
    Dim x, y As Integer
    Dim NewPoint As New Point
    Public inicializado As Integer '' 0 lançamentos 1 contratos


    ''VALIDAÇÃO
    Private Function validaCampos() As Integer
        Dim dt As DataTable = New DataTable
        access.ExecuteQuerry("SELECT nome FROM favorecidos")
        dt = access.dt
        For Each row As DataRow In dt.Rows
            If mtbNome.Text = row("nome") Then

                MetroFramework.MetroMessageBox.Show(Me, "O favorecido " & mtbNome.Text & " já existe na base de dados, verifique ! ",
                                                        "Impossível Cadastrar !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return 1

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
        If inicializado = 0 Then

        ElseIf inicializado = 1 Then
            Dim frm As Imoveis = CType(Owner, Imoveis)

            frm.preencheCBBInquilinos()
            frm.cbbInquilinos.Text = mtbNome.Text
            Me.Close()
        End If
        Utils.LimparForm(Me)
    End Sub



    ''MOVIMENTO
    Private Sub mbtSair_Click(sender As Object, e As EventArgs) Handles mbtSair.Click
        Me.Close()
    End Sub
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

    Private Sub mbtsSair_Click(sender As Object, e As EventArgs) Handles mbtsSair.Click
        Me.Close()
    End Sub

End Class