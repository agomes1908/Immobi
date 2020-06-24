Public Class SubMenuLançamentos
    Dim access As New Controller
    Dim x, y As Integer
    Dim NewPoint As New Point
    Public cod_lancamento As Integer
    Public n_cheque As String
    Public status As String

    ''SHOWN
    Private Sub SubMenuLançamentos_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If status = "Pago" Then
            mtilePagarReceberL.Enabled = False
        End If

    End Sub

    ''CONTROLES
    Private Sub mtilePagarReceberL_Click(sender As Object, e As EventArgs) Handles mtilePagarReceberL.Click
        If tbNCheque.Text.Length < 1 Then
            MessageBox.Show("O preenchimento do número do cheque é obrigatório")
            Exit Sub
        End If

        access.AddParam("@status", "Pago")
        access.AddParam("@data_pagamento", mdtPgto.Text)
        access.AddParam("@n_cheque", tbNCheque.Text)



        access.ExecuteQuerry("UPDATE lancamentos 
                              SET status = @status,
                                  data_pagamento = @data_pagamento,
                                  n_cheque = @n_cheque
                              WHERE Código = " & cod_lancamento)

        Dim frm As Lançamentos = CType(Owner, Lançamentos)


        MessageBox.Show("Conta Paga com Sucesso !")
        frm.preencheDtvLancamentos()
        Me.Close()
    End Sub
    Private Sub mTileEditarL_Click(sender As Object, e As EventArgs) Handles mTileEditarL.Click
        Dim frm As Lançamentos = CType(Owner, Lançamentos)

        frm.abrirEditar(cod_lancamento)
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