Public Class AddPlanoContas

    Dim access As New Controller
    Dim x, y As Integer
    Dim NewPoint As New Point

    Public lancamento As Boolean = False
    Public repetido As Boolean = False


    ''SHOWN
    Private Sub PlanoContas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        preencheTV()

        mtbDescricao.Enabled = False
        mbtAtualizar.Enabled = False
        mbtExcluir.Enabled = False


    End Sub

    ''TV
    Private Sub preencheTV()

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
        mtbDescricao.Text = e.Node.Text
    End Sub
    Public Function retornaCod(descricao As String) As Integer
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT * from planoContas where descricao Like '" & descricao & "'")
        dt = access.dt

        For Each row As DataRow In dt.Rows
            Return row("código")
        Next
        Return 0
    End Function

    ''CONTROLES 
    Private Sub mbtEditar_Click(sender As Object, e As EventArgs) Handles mbtEditar.Click
        If mtbDescricao.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Primeiro Selecione um Plano de Contas. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        mbtAtualizar.Enabled = True
        mbtExcluir.Enabled = True
        mtbDescricao.Enabled = True
    End Sub
    Private Sub mbtAtualizar_Click(sender As Object, e As EventArgs) Handles mbtAtualizar.Click

        Dim cod As String = retornaCod(tvPlanoContas.SelectedNode.Text)

        access.AddParam("@Código", cod)
        access.ExecuteQuerry("UPDATE planoContas set descricao = '" & mtbDescricao.Text &
                             "' WHERE Código=@Código")

        access.AddParam("@Código", cod)
        access.ExecuteQuerry("UPDATE planoContas set Hierarquia = '" & tvPlanoContas.SelectedNode.Parent.FullPath & "|" & mtbDescricao.Text &
                             "' WHERE Código=@Código")
        preencheTV()

        mtbDescricao.Enabled = False
        mbtAtualizar.Enabled = False
        mbtExcluir.Enabled = False
    End Sub
    Private Sub mbtExcluir_Click(sender As Object, e As EventArgs) Handles mbtExcluir.Click

        Dim descricao As Integer = retornaCod(tvPlanoContas.SelectedNode.Text)

        If MetroFramework.MetroMessageBox.Show(Me, "Você tem certeza que deseja remover o registro selecionado ?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

            Dim dt As DataTable = New DataTable
            access.ExecuteQuerry("SELECT cod_planoContas FROM lancamentos")
            dt = access.dt
            For Each row As DataRow In dt.Rows
                If descricao = row("cod_planoContas") Then
                    MetroFramework.MetroMessageBox.Show(Me, "Existem lançamentos com o Plano de contas " & tvPlanoContas.SelectedNode.Text & ". Apague os registros e tente novamente  ! ",
                                                        "Impossível Excluir !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next

            access.AddParam("@Código", retornaCod(tvPlanoContas.SelectedNode.Text))
            access.ExecuteQuerry("DELETE from planoContas WHERE Código =@Código ")

        End If
        preencheTV()
        mtbDescricao.Enabled = False
        mbtAtualizar.Enabled = False
        mbtExcluir.Enabled = False
    End Sub
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles mbtInserir.Click

        If mtbDescricao.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Primeiro Selecione um Plano de Contas para inserir a baixo. ",
                                                        "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If mtbNovoNode.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "Insira a descrição do novo Plano de Contas",
                                            "Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        PercorrerNos(tvPlanoContas.Nodes)
        If repetido Then
            MetroFramework.MetroMessageBox.Show(Me, "O Plano de Contas " & mtbNovoNode.Text & " já existe. " & vbCrLf & "Verifique e tente novamente  ! ",
                                                        "Impossível Inserir !", MessageBoxButtons.OK, MessageBoxIcon.Error)
            repetido = False
            Exit Sub
        End If

        Dim newNode As TreeNode = New TreeNode(mtbNovoNode.Text)
        Dim aux As String

        aux = mtbNovoNode.Text

        If tvPlanoContas.SelectedNode.Level < 2 Then
            tvPlanoContas.SelectedNode.Nodes.Add(newNode)
            access.ExecuteQuerry("INSERT INTO planoContas (descricao, nivel, superior, Hierarquia) 
                            values ('" _
                            & mtbNovoNode.Text & "'," _
                            & tvPlanoContas.SelectedNode.Level + 1 & "," _
                            & retornaCod(tvPlanoContas.SelectedNode.Text) & ",'" _
                            & tvPlanoContas.SelectedNode.FullPath & "|" & mtbNovoNode.Text & "')")
            mtbNovoNode.Clear()
        Else

            MetroFramework.MetroMessageBox.Show(Me, "Impossivel Inserir Categoria nível 4",
                                            "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Dim frm As Lançamentos = CType(Owner, Lançamentos)


        frm.preencheTV()
        frm.cbbCategoria.Text = aux

        Me.Close()

    End Sub
    Private Sub PercorrerNos(ByVal Nos As TreeNodeCollection)

        For Each no As TreeNode In Nos
            If no.Text = mtbNovoNode.Text Then
                repetido = True
            End If
            PercorrerNos(no.Nodes)
        Next

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
    Private Sub mbtsSair_Click(sender As Object, e As EventArgs) Handles mbtSair.Click
        Me.Close()
    End Sub

End Class