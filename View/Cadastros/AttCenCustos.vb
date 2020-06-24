Public Class AttCenCustos
    Private Access As New Controller
    Dim x, y As Integer
    Dim NewPoint As New Point
    Public inicializador As Integer ' 0 - novo, 1++ - editar

    ''SHOWN
    Private Sub AttCenCustos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        preencheForm()
        mtbDescricao.Focus()
    End Sub

    ''AUX
    Private Sub preencheForm()
        Dim dt As DataTable = New DataTable

        Access.ExecuteQuerry("SELECT * from cenCusto where código Like '" & inicializador & "'")
        dt = Access.dt
        For Each row As DataRow In dt.Rows
            mtbDescricao.Text = row("descricao").ToString
        Next
    End Sub

    ''CRUD
    Private Function validaCentroUnique(ByVal centro As String) As Integer
        Dim dt As DataTable = New DataTable
        Access.ExecuteQuerry("SELECT descricao from cenCusto")
        dt = Access.dt
        For Each row As DataRow In dt.Rows
            If row("descricao") = centro Then
                MetroFramework.MetroMessageBox.Show(Me, "O Centro de Custos " & mtbDescricao.Text & " já existe na base de dados, verifique ! ",
                                                        "Impossível Cadastrar !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 1
            End If
        Next
        Return 0
    End Function
    Private Sub mbtAtualizar_Click(sender As Object, e As EventArgs) Handles mbtAtualizar.Click
        If validaCentroUnique(mtbDescricao.Text) Then
            Exit Sub
        End If

        Dim frm As CentroDeCustos = CType(Owner, CentroDeCustos)

        Access.AddParam("@Código", inicializador)

        Access.ExecuteQuerry("UPDATE cenCusto set descricao='" & mtbDescricao.Text & "' WHERE Código=@Código")

        MetroFramework.MetroMessageBox.Show(Me, "Centro de Custos atualizado com sucesso ! ",
                                                        "Sucesso ! ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        frm.AtualizaRegistro()
        Me.Close()
    End Sub
    Private Sub mbtExcluir_Click(sender As Object, e As EventArgs) Handles mbtExcluir.Click

        Dim frm As CentroDeCustos = CType(Owner, CentroDeCustos)

        If MetroFramework.MetroMessageBox.Show(Me, "Você tem certeza que deseja remover o Centro de Custos " & mtbDescricao.Text & " ?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then


            Dim dt As DataTable = New DataTable
            Access.ExecuteQuerry("SELECT cod_cenCusto FROM lancamentos")
            dt = Access.dt
            For Each row As DataRow In dt.Rows
                If inicializador = row("cod_cenCusto") Then
                    MetroFramework.MetroMessageBox.Show(Me, "Existem lançamentos para o Centro de Custos " & mtbDescricao.Text & ". Apague os registros e tente novamente  ! ",
                                                        "Impossível Excluir !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Next

            Access.AddParam("@registro", inicializador)
            Access.ExecuteQuerry("DELETE FROM cenCusto WHERE CÓDIGO = @registro")

            frm.AtualizaRegistro()
            Me.Close()
        End If
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