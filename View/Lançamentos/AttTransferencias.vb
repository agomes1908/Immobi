Public Class AttTransferencias
    Public cod_trans As Integer
    Dim eventsTbOrigem As Boolean = False
    Dim eventsTbDestino As Boolean = False
    Dim access As New Controller
    Dim x, y As Integer
    Dim NewPoint As New Point

    Private Sub AttTransferencias_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        preencheCBBcOrigem()
        preencheCBBcDestino()
        carregaInfo()
    End Sub


    ''CARREGAMENTO CBB
    Public Sub preencheCBBcOrigem()
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT Código, num_conta & ' - ' & descricao as d FROM conta")
        dt = access.dt

        With cbbContaOrigem
            .DataSource = dt
            .DisplayMember = "d"
            .ValueMember = "Código"
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        cbbContaOrigem.Text = ""
        eventsTbOrigem = True
    End Sub
    Public Sub preencheCBBcDestino()
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT Código, num_conta & ' - ' & descricao as d FROM conta")
        dt = access.dt

        With cbbContaDestino
            .DataSource = dt
            .DisplayMember = "d"
            .ValueMember = "Código"
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
        End With
        cbbContaDestino.Text = ""
        eventsTbDestino = True
    End Sub

    ''AUXILIARES 
    Public Sub attSaldoAtualOrigem()

        Dim dt As DataTable = New DataTable
        access.ExecuteQuerry("SELECT saldo_atual FROM conta where Código= " & cbbContaOrigem.SelectedValue)
        dt = access.dt

        If cbbContaOrigem.Text <> "" Then
            For Each row As DataRow In dt.Rows
                mtbSAOrigem.Text = row("saldo_atual")
                mtbSAOrigem.Text = String.Format("{0:c}", Double.Parse(mtbSAOrigem.Text))
                If CType(mtbSAOrigem.Text, Double) < 0 Then
                    mtbSAOrigem.ForeColor = Color.Red
                Else
                    mtbSAOrigem.ForeColor = Color.Black
                End If
            Next

        End If
    End Sub
    Public Sub attSaldoAtualDestino()

        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT saldo_atual FROM conta where Código= " & cbbContaDestino.SelectedValue)
        dt = access.dt
        If cbbContaDestino.Text <> "" Then
            For Each row As DataRow In dt.Rows
                mtbSADestino.Text = row("saldo_atual")
                mtbSADestino.Text = String.Format("{0:c}", Double.Parse(mtbSADestino.Text))
                If CType(mtbSADestino.Text, Double) < 0 Then
                    mtbSADestino.ForeColor = Color.Red
                Else
                    mtbSADestino.ForeColor = Color.Black
                End If
            Next
        End If
        If mtbValorT.Text.Count > 0 Then
            attSaldoPrevistoOrigem()
        End If
    End Sub
    Public Sub attSaldoPrevistoOrigem()
        If mtbValorT.Text.Count > 0 Then

            mtbSPOrigem.Text = CType(mtbSAOrigem.Text, Double) - CType(mtbValorT.Text, Double)
            mtbSPOrigem.Text = String.Format("{0:c}", Double.Parse(mtbSPOrigem.Text))
            If CType(mtbSPOrigem.Text, Double) < 0 Then
                mtbSPOrigem.ForeColor = Color.Red
            Else
                mtbSPOrigem.ForeColor = Color.Black
            End If

        End If
    End Sub
    Public Sub attSaldoPrevistoDestino()
        If mtbValorT.Text.Count > 0 Then
            mtbSPDestino.Text = CType(mtbSADestino.Text, Double) + CType(mtbValorT.Text, Double)
            mtbSPDestino.Text = String.Format("{0:c}", Double.Parse(mtbSPDestino.Text))
            If CType(mtbSPDestino.Text, Double) < 0 Then
                mtbSPDestino.ForeColor = Color.Red
            Else
                mtbSPDestino.ForeColor = Color.Black
            End If
        End If
    End Sub
    Public Sub carregaInfo()

        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT 
                t.Código as CÓDIGO,
                C1.num_conta & ' - ' & c1.descricao as ORIGEM,
                C2.num_conta & ' - ' & c2.descricao as DESTINO,
                t.valor AS VALOR,
                t.n_cheque as CHEQUE,
                t.data AS DATA,
                t.observacoes as  OBS

                FROM 
                    (transferencias as t
                    INNER JOIN conta as c1 on t.cod_cOrigem = c1.Código)
                    INNER JOIN conta as c2 on t.con_cDestino = c2.Código
                WHERE 
                     t.Código = " & cod_trans)
        dt = access.dt

        For Each row As DataRow In dt.Rows
            cbbContaOrigem.Text = row("ORIGEM")
            cbbContaDestino.Text = row("DESTINO")
            mtbValorT.Text = row("VALOR")
            mtbNum_chequeT.Text = row("CHEQUE")
            mdtData.Value = row("DATA")
            mtbObservacoesT.Text = row("OBS")
        Next
    End Sub

    ''EVENTOS CBB
    Private Sub cbbContaOrigem_TextChanged(sender As Object, e As EventArgs) Handles cbbContaOrigem.TextChanged
        If eventsTbOrigem Then
            attSaldoAtualOrigem()
            attSaldoPrevistoOrigem()
        End If
    End Sub
    Private Sub cbbContaDestino_TextChanged(sender As Object, e As EventArgs) Handles cbbContaDestino.TextChanged
        If eventsTbDestino Then
            attSaldoAtualDestino()
            attSaldoPrevistoDestino()
        End If
    End Sub

    ''EVENTOS TB
    Private Sub tbValor_Leave(sender As Object, e As EventArgs) Handles mtbValorT.Leave
        If cbbContaOrigem.Text <> "" Then
            attSaldoPrevistoOrigem()
        End If
        If cbbContaDestino.Text <> "" Then
            attSaldoPrevistoDestino()
        End If

    End Sub

    ''VALIDAÇÕES
    Public Function validaCamposT() As Integer

        If mtbValorT.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo VALOR deve ser preenchido! ",
                                                        "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mtbValorT.Focus()
            Return 1
        End If
        If cbbContaOrigem.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo Conta de Origem deve ser preenchido! ",
                                                        "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbContaOrigem.Focus()
            Return 1
        End If
        If cbbContaDestino.Text.Length < 1 Then
            MetroFramework.MetroMessageBox.Show(Me, "O campo Conta de Destino deve ser preenchido! ",
                                                        "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbbContaDestino.Focus()
            Return 1
        End If

        Return 0
    End Function
    Private Sub mtbValorT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbValorT.KeyPress
        If e.KeyChar = Chr(46) Then e.KeyChar = Chr(44)
        If e.KeyChar = Chr(44) And InStr(mtbValorT.Text, ",") <> 0 Then
            e.KeyChar = Chr(0)
            Exit Sub
        End If
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(44) Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    ''CONTROLES
    Private Sub btSalvar_Click(sender As Object, e As EventArgs) Handles mbtSalvar.Click
        If validaCamposT() Then
            Exit Sub
        End If



        access.paramns.Clear()

        access.AddParam("@cod_cOrigem", cbbContaOrigem.SelectedValue)
        access.AddParam("@con_cDestino", cbbContaDestino.SelectedValue)
        access.AddParam("@valor", CType(mtbValorT.Text, Double))
        access.AddParam("@n_cheque", mtbNum_chequeT.Text)
        access.AddParam("@data", mdtData.Text)
        access.AddParam("@observacoes", mtbObservacoesT.Text)

        access.ExecuteQuerry("UPDATE transferencias 
                                SET 
                                    cod_cOrigem = @cod_cOrigem,
                                    con_cDestino = @con_cDestino,
                                    valor = @valor,
                                    n_cheque = @n_cheque,
                                    data = @data, 
                                    observacoes = @observacoes
                              WHERE 
                                    Código = " & cod_trans)


        Utils.atualizaTodasContas()

        Dim frm As Lançamentos = CType(Owner, Lançamentos)

        frm.carregaMgridTransferencias()
        Me.Close()
    End Sub
    Private Sub btExcluir_Click(sender As Object, e As EventArgs) Handles mbtExcluir.Click
        If MetroFramework.MetroMessageBox.Show(Me, "Você tem certeza que deseja remover essa transferência ?",
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then


            access.AddParam("@Código", cod_trans)
            access.ExecuteQuerry("DELETE FROM transferencias where Código = @Código")
            Utils.atualizaTodasContas()

            Dim frm As Lançamentos = CType(Owner, Lançamentos)
            frm.carregaMgridTransferencias()
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles mbtSair.Click
        Me.Close()
    End Sub



End Class