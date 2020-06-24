Public Class SelecionarImovel
    Dim x, y As Integer
    Dim NewPoint As New Point
    Public inicializador As Integer ' 1 - contratos 2 - lançamentos 3 - att lançamentos 4 - edita contrato
    Dim access As New Controller

    ''SHOWN
    Private Sub SelecionarImovel_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        atualizarmGridImoveis()
    End Sub

    ''MGRID
    Public Sub atualizarmGridImoveis()

        If inicializador = 1 Or inicializador = 4 Then  '' contratos
            Dim querryy As String = "SELECT Código as CÓDIGO, 
                                finalidade as FINALIDADE,
                                tipo as TIPO,
                                logradouro as LOGRADOURO,
                                numero as NUM, 
                                complemento as COMPL,
                                bairro as BAIRRO, 
                                cidade as CIDADE, 
                                estado as UF,
                                dormitorios as DORM,
                                suites as SUITES,
                                banheiros as BANHO, 
                                vagas as VAGAS, 
                                valor_locacao as LOCAÇÃO,
                                valor_luz as [VALOR LUZ],
                                valor_internet as [VALOR NET],
                                valor_agua as [VALOR ÁGUA],
                                contrato as CONT 
                                From imoveis WHERE contrato = false "

            querryy = querryy & " ORDER BY contrato DESC"
            access.ExecuteQuerry(querryy)
            mGridimoveis.DataSource = access.dt
        ElseIf inicializador = 2 Or inicializador = 3 Then  '' lançamentos
            Dim querryy As String = "SELECT Código as CÓDIGO, 
                                finalidade as FINALIDADE,
                                tipo as TIPO,
                                logradouro as LOGRADOURO,
                                numero as NUM, 
                                complemento as COMPL,
                                bairro as BAIRRO, 
                                cidade as CIDADE, 
                                estado as UF,
                                dormitorios as DORM,
                                suites as SUITES,
                                banheiros as BANHO, 
                                vagas as VAGAS, 
                                valor_locacao as LOCAÇÃO,
                                valor_luz as [VALOR LUZ],
                                valor_internet as [VALOR NET],
                                valor_agua as [VALOR ÁGUA],
                                contrato as CONT 
                                From imoveis"

            If mtbPesquisar.Text.Length > 0 Then
                querryy = querryy & " where logradouro like '%" & mtbPesquisar.Text & "%' or bairro like '%" & mtbPesquisar.Text & "%'"
                querryy = querryy & "or complemento like '%" & mtbPesquisar.Text & "%' or cidade like '%" & mtbPesquisar.Text & "%' or Código like '%" & mtbPesquisar.Text & "%'"
            End If

            querryy = querryy & " ORDER BY contrato DESC"
            access.ExecuteQuerry(querryy)
            mGridimoveis.DataSource = access.dt
        End If



    End Sub
    Private Sub mGridimoveis_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles mGridimoveis.CellFormatting
        With mGridimoveis
            .Columns("CÓDIGO").Width = 60
            .Columns("CÓDIGO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("FINALIDADE").Width = 80
            .Columns("FINALIDADE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("TIPO").Width = 80
            .Columns("TIPO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("LOGRADOURO").Width = 200
            .Columns("LOGRADOURO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("NUM").Width = 60
            .Columns("NUM").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("COMPL").Width = 80
            .Columns("COMPL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("BAIRRO").Width = 100
            .Columns("BAIRRO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("CIDADE").Width = 80
            .Columns("CIDADE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            .Columns("LOCAÇÃO").Width = 80
            .Columns("LOCAÇÃO").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("LOCAÇÃO").DefaultCellStyle.Format = "C2"

            .Columns("VALOR LUZ").Width = 80
            .Columns("VALOR LUZ").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("VALOR LUZ").DefaultCellStyle.Format = "C2"

            .Columns("VALOR NET").Width = 80
            .Columns("VALOR NET").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("VALOR NET").DefaultCellStyle.Format = "C2"

            .Columns("VALOR ÁGUA").Width = 80
            .Columns("VALOR ÁGUA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("VALOR ÁGUA").DefaultCellStyle.Format = "C2"

            .Columns("UF").Visible = False
            .Columns("DORM").Visible = False
            .Columns("SUITES").Visible = False
            .Columns("BANHO").Visible = False
            .Columns("VAGAS").Visible = False
            .Columns("CONT").Visible = False


            If inicializador = 2 Then
                For i As Integer = 0 To mGridimoveis.Rows.Count - 1 Step +1
                    Dim val As Boolean
                    val = mGridimoveis.Rows(i).Cells("CONT").Value

                    If val Then
                        mGridimoveis.Rows(i).DefaultCellStyle.BackColor = Color.LavenderBlush
                        mGridimoveis.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    Else
                        mGridimoveis.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
                    End If
                Next
            End If
        End With
    End Sub
    Private Sub mtbPesquisar_TextChanged(sender As Object, e As EventArgs) Handles mtbPesquisar.TextChanged
        atualizarmGridImoveis()
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

    Private Sub mGridimoveis_DoubleClick(sender As Object, e As EventArgs) Handles mGridimoveis.DoubleClick
        If inicializador = 2 Then
            Dim frm As Lançamentos = CType(Owner, Lançamentos)
            frm.mlbCodigoImovel2.Text = mGridimoveis.CurrentRow.Cells(0).Value
            frm.mtbEndereco.Text = mGridimoveis.CurrentRow.Cells(3).Value & " " &
                                      mGridimoveis.CurrentRow.Cells(6).Value & " - " &
                                      mGridimoveis.CurrentRow.Cells(7).Value & "/" & mGridimoveis.CurrentRow.Cells(8).Value
            frm.mtbNum.Text = mGridimoveis.CurrentRow.Cells(4).Value
            frm.mtbComplemento.Text = mGridimoveis.CurrentRow.Cells(5).Value


            frm.mlbCodigoImovel1.Text = "Código do Imóvel : "
            Me.Close()

        ElseIf inicializador = 3 Then
            Dim frm As AttLançamentos = CType(Owner, AttLançamentos)
            frm.mlbCodigoImovel2.Text = mGridimoveis.CurrentRow.Cells(0).Value
            frm.mtbEndereco.Text = mGridimoveis.CurrentRow.Cells(3).Value & " " &
                                      mGridimoveis.CurrentRow.Cells(6).Value & " - " &
                                      mGridimoveis.CurrentRow.Cells(7).Value & "/" & mGridimoveis.CurrentRow.Cells(8).Value
            frm.mtbNum.Text = mGridimoveis.CurrentRow.Cells(4).Value
            frm.mtbComplemento.Text = mGridimoveis.CurrentRow.Cells(5).Value


            frm.mlbCodigoImovel1.Text = "Código do Imóvel : "
            Me.Close()
        ElseIf inicializador = 1 Then
            Dim frm As Imoveis = CType(Owner, Imoveis)
            frm.mlbCodigoImovel.Text = mGridimoveis.CurrentRow.Cells(0).Value
            frm.mtbEndereco.Text = mGridimoveis.CurrentRow.Cells(3).Value & " " &
                                      mGridimoveis.CurrentRow.Cells(6).Value & " - " &
                                      mGridimoveis.CurrentRow.Cells(7).Value & "/" & mGridimoveis.CurrentRow.Cells(8).Value
            frm.mtbNum.Text = mGridimoveis.CurrentRow.Cells(4).Value
            frm.mtbComplementoC.Text = mGridimoveis.CurrentRow.Cells(5).Value
            frm.mtbFinalidade.Text = mGridimoveis.CurrentRow.Cells(1).Value
            frm.mtbTipo.Text = mGridimoveis.CurrentRow.Cells(2).Value

            frm.mtbValorAguaC.Text = mGridimoveis.CurrentRow.Cells("VALOR ÁGUA").Value
            frm.mtbValorAguaC.Text = String.Format("{0:c}", Double.Parse(frm.mtbValorAguaC.Text))

            frm.mtbValorLocacaoC.Text = mGridimoveis.CurrentRow.Cells("LOCAÇÃO").Value
            frm.mtbValorLocacaoC.Text = String.Format("{0:c}", Double.Parse(frm.mtbValorLocacaoC.Text))

            frm.mtbValorNetC.Text = mGridimoveis.CurrentRow.Cells("VALOR NET").Value
            frm.mtbValorNetC.Text = String.Format("{0:c}", Double.Parse(frm.mtbValorNetC.Text))

            frm.mtbValorLuzC.Text = mGridimoveis.CurrentRow.Cells("VALOR LUZ").Value
            frm.mtbValorLuzC.Text = String.Format("{0:c}", Double.Parse(frm.mtbValorLuzC.Text))

            frm.mlbValorTotalContrato.Text = frm.calculaValorContrato()
            frm.mlbValorTotalContrato.Text = String.Format("{0:c}", Double.Parse(frm.mlbValorTotalContrato.Text))

            Me.Close()
        ElseIf inicializador = 4 Then
            Dim frm As AttContratos = CType(Owner, AttContratos)
            frm.preencheDadosImoveis(mGridimoveis.CurrentRow.Cells(0).Value)
            frm.mlbValorTotalContrato.Text = frm.calculaValorContrato()
            frm.mlbValorTotalContrato.Text = String.Format("{0:c}", Double.Parse(frm.mlbValorTotalContrato.Text))

            Me.Close()

        End If
    End Sub

End Class