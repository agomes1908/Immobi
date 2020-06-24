Public Class CentroDeCustos
    Dim access As New Controller

    ''SHOWN
    Private Sub CentroDeCustos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AtualizaRegistro()
        MetroTabControl1.SelectTab(1)
    End Sub

    ''PAGE CADASTRAR ----------------------------------------------------------------------------------------
    ''CRUD
    Private Sub insertCenCusto()

        access.AddParam("@descricao", mtbCenCustos.Text)
        access.ExecuteQuerry("INSERT INTO cenCusto (descricao) VALUES(@descricao)")

    End Sub
    Private Function validaCentroUnique(ByVal centro As String) As Integer
        Dim dt As DataTable = New DataTable
        access.ExecuteQuerry("SELECT descricao from cenCusto")
        dt = access.dt
        For Each row As DataRow In dt.Rows
            If row("descricao") = centro Then
                MetroFramework.MetroMessageBox.Show(Me, "O Centro de Custos " & mtbCenCustos.Text & " já existe na base de dados, verifique ! ",
                                                        "Impossível Cadastrar !", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return 1
            End If
        Next
        Return 0
    End Function
    Private Sub mbtSalvar_Click(sender As Object, e As EventArgs) Handles mbtSalvar.Click
        If validaCentroUnique(mtbCenCustos.Text) Then
            Exit Sub
        End If

        insertCenCusto()

        MetroFramework.MetroMessageBox.Show(Me, "Centro de Custos salvo com sucesso ! ",
                                                        "Sucesso ! ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        AtualizaRegistro()

        Utils.LimparForm(Me)

    End Sub

    ''PAGE LISTAR  ----------------------------------------------------------------------------------------

    ''MGRID
    Private Sub mgridCenCustos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles mgridCenCustos.CellFormatting
        With mgridCenCustos

            .Columns("Código").Width = 60
            .Columns("Código").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("Descricao").Width = 230
            .Columns("Descricao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        End With
    End Sub
    Private Sub mgridCenCustos_DoubleClick(sender As Object, e As EventArgs) Handles mgridCenCustos.DoubleClick
        Dim frm As New AttCenCustos
        frm.inicializador = mgridCenCustos.CurrentRow.Cells(0).Value
        AddOwnedForm(frm)
        frm.Show()
    End Sub

    ''AUX
    Public Sub AtualizaRegistro()
        access.ExecuteQuerry("SELECT * FROM cenCusto")
        mgridCenCustos.DataSource = access.dt
    End Sub

    ''MUDANÇA DE PÁGINA 
    Private Sub MetroTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroTabControl1.SelectedIndexChanged


        If MetroTabControl1.SelectedIndex = 0 Then
            mlbNomeTela.Text = "Cadastrar Novo Centro de Custos"
            mtbCenCustos.Focus()
        Else
            mlbNomeTela.Text = "Listar Todos Centro de Custos"
        End If

    End Sub

End Class