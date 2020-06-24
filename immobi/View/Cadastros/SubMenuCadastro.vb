Public Class SubMenuCadastro

    Dim x, y As Integer
    Dim NewPoint As New Point

    ''SHOWN
    Private Sub SubMenuCadastro_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Label1.Focus()
    End Sub

    ''CONTROLES
    Private Sub mbtSair_Click(sender As Object, e As EventArgs) Handles mbtSair.Click
        Me.Close()
    End Sub
    Private Sub mtileFavorecidos_Click(sender As Object, e As EventArgs) Handles mtileFavorecidos.Click
        Dim frm As MenuPrincipal = CType(Owner, MenuPrincipal)
        frm.abrirfavorecido()
        Me.Close()
    End Sub
    Private Sub mTileContas_Click(sender As Object, e As EventArgs) Handles mTileContas.Click
        Dim frm As MenuPrincipal = CType(Owner, MenuPrincipal)
        frm.AbrirContas()
        Me.Close()
    End Sub
    Private Sub mTileCenCustos_Click(sender As Object, e As EventArgs) Handles mTileCenCustos.Click
        Dim frm As MenuPrincipal = CType(Owner, MenuPrincipal)
        frm.AbrirCenCustos()
        Me.Close()
    End Sub
    Private Sub mTilePConta_Click(sender As Object, e As EventArgs) Handles mTilePConta.Click
        Dim frm As MenuPrincipal = CType(Owner, MenuPrincipal)
        frm.AbrirPlanoContas()
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




End Class