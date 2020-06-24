Imports Microsoft.Office.Interop
Public Class Relatorios
    Private txtarquivoPDF As Object
    Dim ultimoRelatorio As String
    Dim access As New Controller
    Dim dtChecked As DataTable = New DataTable
    Dim dtF As DataTable = New DataTable
    Dim countPC As Integer = 0
    Dim listPConta() As Integer
    Dim ctrl As Boolean = True
    Dim aux_transf As Boolean = True


    ''SHOWN
    Private Sub geraRelatorio_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        mrbAmbos.Checked = True
        mrbAmbos2.Checked = True
        lbTot.Text = ""
        lbValorTotal.Text = ""

        mdtpVencInicial.Checked = False
        mdtpVencFinal.Checked = False

        mdtpPgtoInicial.Checked = False
        mdtpPgtoFinal.Checked = False

        preencheCLBXContas()
        preencheCLBXCenCustos()
        preencheLBXFavorecidos()
        preencheTV()



    End Sub

    ''GERA E IMPRIME RELATORIO
    Public Sub imprimeRelatorio()

        Dim app As Microsoft.Office.Interop.Excel.Application
        Dim book As Microsoft.Office.Interop.Excel.Workbook
        Dim sheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        app = New Microsoft.Office.Interop.Excel.Application
        app.Visible = False
        book = app.Workbooks.Add(misValue)
        sheet = book.Sheets("Planilha1")
        app.Windows.Application.ActiveWindow.DisplayGridlines = False

        Dim relatorio_title As Excel.Range = sheet.Range("A1", "G1")
        Dim table_header As Excel.Range = sheet.Range("A10", "G10")
        Dim info_header As Excel.Range = sheet.Range("A2", "G9")

        sheet.Cells(1, 1) = "Relatório Analítico " & Today()
        sheet.Cells(1, 1).Font.bold = True


        relatorio_title.Merge(Type.Missing)
        relatorio_title.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

        ''HEADER TABLE
        For i As Integer = 0 To mGridRelatorios.ColumnCount - 2
            sheet.Cells(10, i + 1) = mGridRelatorios.Columns(i).HeaderText
        Next

        With table_header
            With .Borders(Excel.XlBordersIndex.xlEdgeTop)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .ColorIndex = 0
                .TintAndShade = 0
                .Weight = Excel.XlBorderWeight.xlThin
            End With
            With .Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .ColorIndex = 0
                .TintAndShade = 0
                .Weight = Excel.XlBorderWeight.xlThin
            End With
        End With
        sheet.Rows(11).RowHeight = 10

        ''INFO HEADER
        If mrbAmbos.Checked Then
            sheet.Cells(3, 1) = "Tipo : Receitas e Despesas"
        ElseIf mrbReceita.Checked Then
            sheet.Cells(3, 1) = "Tipo : Receitas"
        Else
            sheet.Cells(3, 1) = "Tipo : Despesas"
        End If

        If mrbAmbos2.Checked Then
            sheet.Cells(4, 1) = "Status : Pago e Em Aberto"
        ElseIf mrbPago.Checked Then
            sheet.Cells(4, 1) = "Status : Pago"
        Else
            sheet.Cells(4, 1) = "Status : Em Aberto"
        End If

        If mdtpPgtoInicial.Checked And mdtpPgtoFinal.Checked Then
            sheet.Cells(5, 1) = "Data : de " & mdtpPgtoInicial.Text & " até " & mdtpPgtoFinal.Text
        ElseIf mdtpPgtoInicial.Checked Then
            sheet.Cells(5, 1) = "Data : A partir de " & mdtpPgtoInicial.Text
        ElseIf mdtpPgtoFinal.Checked Then
            sheet.Cells(5, 1) = "Data : Até " & mdtpPgtoFinal.Text
        Else
            sheet.Cells(5, 1) = "Data : Todo o Período"
        End If

        Dim contas As String = "Contas : "
        Dim cont As Integer = 0
        For Each item As DataRowView In clbxContas.CheckedItems
            If cont > 0 Then
                contas &= "; " & item.Item(1)
            Else
                contas &= item.Item(1)
            End If
            cont += 1
        Next
        If clbxContas.CheckedItems.Count = 0 Then
            contas = "Contas : Todas "
        End If
        sheet.Cells(6, 1) = contas

        Dim centros As String = "Centros : "
        Dim countCen As Integer = 0
        For Each item As DataRowView In clbxCenCustos.CheckedItems
            If countCen > 0 Then
                centros &= "; " & item.Item(1)
            Else
                centros &= item.Item(1)
            End If
            countCen += 1
        Next
        If clbxCenCustos.CheckedItems.Count = 0 Then
            centros = "Centros : Todos "
        End If
        sheet.Cells(7, 1) = centros

        ''CORPO 
        For row As Integer = 1 To mGridRelatorios.RowCount
            sheet.Rows(row + 11).Font.Size = 8
            sheet.Rows(row + 11).RowHeight = 10
            For column As Integer = 0 To mGridRelatorios.ColumnCount - 2
                sheet.Cells(row + 11, column + 1) = mGridRelatorios(column, row - 1).Value
            Next
        Next

        sheet.Columns(1).ColumnWidth = 5
        sheet.Columns(2).ColumnWidth = 20
        sheet.Columns(3).ColumnWidth = 20
        sheet.Columns(4).ColumnWidth = 20
        sheet.Columns(5).ColumnWidth = 10
        sheet.Columns(6).ColumnWidth = 15
        sheet.Columns(7).ColumnWidth = 10
        sheet.Columns(7).NumberFormat = "$ #,###,###.00"

        sheet.Columns(1).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        sheet.Columns(5).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        sheet.Columns(6).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        sheet.Columns(7).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

        With info_header
            .Font.Size = 8
            .RowHeight = 10
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
        End With

        sheet.Cells(mGridRelatorios.RowCount + 13, 2) = "Nº Total de Registros : " & mGridRelatorios.RowCount
        sheet.Cells(mGridRelatorios.RowCount + 13, 6) = "Total  : " & lbValorTotal.Text

        sheet.Cells(mGridRelatorios.RowCount + 13, 6).Font.Bold = True
        sheet.Cells(mGridRelatorios.RowCount + 13, 2).Font.Bold = True

        Dim datahoraAtual As DateTime = Now

        ultimoRelatorio = "C:\Relatorios\relatorio" & CType(datahoraAtual, String).Replace(" ", "").Replace("/", "").Replace(":", "") & ".xlsx"
        sheet.SaveAs(ultimoRelatorio)
        book.Close()
        app.Quit()

        PObject(app)
        PObject(book)
        PObject(sheet)

    End Sub
    Private Sub PObject(ByRef obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Public Sub geraRelatorio()

        Dim access As New Controller
        Dim dtOriginal As DataTable = New DataTable
        Dim iterateIndex As Integer = 0
        Dim receitas As Double = 0
        Dim despesas As Double = 0

        access.ExecuteQuerry("SELECT 
                lancamentos.Código as CÓD,
                favorecidos.nome AS FAVORECIDO,
                planoContas.descricao AS CATEGORIA,
                lancamentos.descricao AS DESCRIÇÃO,
                lancamentos.data_pagamento AS PGTO,
                lancamentos.n_cheque AS CHEQUE,
                lancamentos.valor AS VALOR,
                lancamentos.observacoes AS OBS,
                lancamentos.tipo_lancamento as TIPO,
                lancamentos.status as STATUS,
                lancamentos.data_emissao AS EMISSAO,
                lancamentos.data_vencimento AS VENC,
                lancamentos.cod_conta as CONTA,
                lancamentos.cod_cenCusto as CENCUS,
                lancamentos.cod_favorecidos as FAVOR,
                lancamentos.cod_planoContas as PCONTA

                FROM 
                    (lancamentos 
                    LEFT JOIN favorecidos on lancamentos.cod_favorecidos = favorecidos.Código)
                    LEFT JOIN planoContas on lancamentos.cod_planoContas = planoContas.Código ORDER BY lancamentos.data_pagamento asc")

        Dim dtAuxiliar As New DataTable
        dtAuxiliar.Columns.Add("CÓD", GetType(Integer))
        dtAuxiliar.Columns.Add("FAVORECIDO", GetType(String))
        dtAuxiliar.Columns.Add("CATEGORIA", GetType(String))
        dtAuxiliar.Columns.Add("DESCRIÇÃO", GetType(String))
        dtAuxiliar.Columns.Add("PGTO", GetType(Date))
        dtAuxiliar.Columns.Add("CHEQUE", GetType(String))
        dtAuxiliar.Columns.Add("VALOR", GetType(Double))
        dtAuxiliar.Columns.Add("TIPO", GetType(Integer))

        ''RB RECEITA E DESPESA 
        Dim tipo(0) As Integer
        If mrbReceita.Checked Then
            tipo(0) = 1
        ElseIf mrbDespesa.Checked Then
            tipo(0) = 2
        Else
            ReDim tipo(1)
            tipo(0) = 1
            tipo(1) = 2
        End If

        ''RB PAGO EM ABERTO 
        Dim status(0) As String
        If mrbPago.Checked Then
            status(0) = "Pago"
        ElseIf mrbAberto.Checked Then
            status(0) = "Em Aberto"
        Else
            ReDim status(1)
            status(0) = "Pago"
            status(1) = "Em Aberto"
        End If

        ReDim listPConta(0)
        ctrl = True
        PercorrerNos(tvPlanoContas.Nodes)

        Dim dataPgto As Date

        For Each row As DataRow In access.dt.Rows
            If row("STATUS") = "Pago" Then
                dataPgto = row("PGTO")
            Else
                dataPgto = CType("01/01/1900", Date)
            End If

            If isIntInArray(row("TIPO"), tipo) Then
                If isStringInArray(row("STATUS"), status) Then
                    If verificaDataVcto(row("VENC")) Then
                        If verificaDataPgto(dataPgto) Then
                            If percorreCLBXContasChecked(row("CONTA")) Then
                                If percorreCLBXCenCusChecked(row("CENCUS")) Then
                                    If percorreDtFavorecidosChecked(row("FAVORECIDO")) Then
                                        If verificaPConta(row("PCONTA")) Then
                                            If percorreTB(IIf(row("OBS") IsNot DBNull.Value, row("OBS"), ""),
                                                        IIf(row("DESCRIÇÃO") IsNot DBNull.Value, row("DESCRIÇÃO"), ""),
                                                        IIf(row("CHEQUE") IsNot DBNull.Value, row("CHEQUE"), "")) Then
                                                dtAuxiliar.Rows.Add(row("CÓD"),
                                                    row("FAVORECIDO"),
                                                    row("CATEGORIA"),
                                                    row("DESCRIÇÃO"),
                                                    row("PGTO"),
                                                    row("CHEQUE"),
                                                    row("VALOR"),
                                                    row("TIPO"))
                                                If row("TIPO") = 1 Then
                                                    receitas += row("VALOR")
                                                Else
                                                    despesas += row("VALOR")
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next

        ''INSERE TRANSFERENCIAS NO DGV
        access.ExecuteQuerry("SELECT * FROM  transferencias")

        PercorrerNos2(tvPlanoContas.Nodes)

        For Each row As DataRow In access.dt.Rows

            If isStringInArray("Pago", status) Then
                If clbxCenCustos.CheckedItems.Count = 0 Then
                    If dtChecked.Rows.Count = 0 Then
                        If aux_transf = True Then
                            If verificaDataPgto(row("data")) Then

                                If percorreCLBXContasChecked2(row("con_cDestino")) Then
                                    If isIntInArray(1, tipo) Then
                                        dtAuxiliar.Rows.Add(row("Código"), ''código
                                        "TRANSFERENCIA", ''favorecido
                                        "TRANSFERENCIA ENTRE CONTAS", '' categoria
                                        row("observacoes"), '' descricao
                                        row("data"), '' pagamento
                                        row("n_cheque"), '' cheque
                                        row("valor"), '' valor 
                                        1) '' tipo 

                                        receitas += row("valor")
                                    End If
                                ElseIf percorreCLBXContasChecked2(row("cod_cOrigem")) Then
                                    If isIntInArray(2, tipo) Then

                                        dtAuxiliar.Rows.Add(row("Código"), ''código
                                                "TRANSFERENCIA", ''favorecido
                                                "TRANSFERENCIA ENTRE CONTAS", '' categoria
                                                row("observacoes"), '' descricao
                                                row("data"), '' pagamento
                                                row("n_cheque"), '' cheque
                                                row("valor"), '' valor 
                                                2) '' tipo 

                                        despesas += row("valor")
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Next

        lbTot.Text = dtAuxiliar.Rows.Count
        lbValorTotal.Text = String.Format("{0:c}", Double.Parse(receitas - despesas))
        'lbValorTotal.Text = receitas - despesas
        mGridRelatorios.DataSource = dtAuxiliar

    End Sub

    ''CONTROLES
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles mbtGeraRelatorio.Click
        geraRelatorio()
    End Sub
    Private Sub btImprimeRelatorio_Click(sender As Object, e As EventArgs) Handles mbtImprimeRelatorio.Click
        imprimeRelatorio()
        Process.Start(ultimoRelatorio)
    End Sub

    ''AUXILIAR
    Public Function isIntInArray(ByVal valor As Integer, ByVal lista As Array) As Integer
        For Each item In lista
            If valor = item Then
                Return 1
            End If
        Next
        Return 0
    End Function
    Public Function isStringInArray(ByVal valor As String, ByVal lista As Array) As Integer
        For Each item In lista
            If valor = item Then
                Return 1
            End If
        Next
        Return 0
    End Function
    Public Function verificaDataPgto(ByVal dataLanc As Date) As Integer

        If dataLanc = "01/01/1900" Then
            Return 1
        End If
        If mdtpPgtoInicial.Checked Then
            If DateTime.Compare(dataLanc, mdtpPgtoInicial.Text) < 0 Then
                Return 0
            End If
        End If
        If mdtpPgtoFinal.Checked Then
            If DateTime.Compare(mdtpPgtoFinal.Text, dataLanc) < 0 Then
                Return 0
            End If
        End If


        Return 1
    End Function
    Public Function verificaDataVcto(ByVal dataVcto As Date) As Integer


        If mdtpVencInicial.Checked Then
            If DateTime.Compare(dataVcto, mdtpVencInicial.Text) < 0 Then
                Return 0
            End If
        End If
        If mdtpVencFinal.Checked Then
            If DateTime.Compare(mdtpVencFinal.Text, dataVcto) < 0 Then
                Return 0
            End If
        End If
        Return 1
    End Function

    ''CLBX CONTAS 
    Public Sub preencheCLBXContas()
        Dim dta As DataTable = New DataTable
        access.ExecuteQuerry("SELECT Código, num_conta & ' - ' & descricao as d FROM conta")
        dta = access.dt
        clbxContas.DataSource = dta
        clbxContas.DisplayMember = "d"
        clbxContas.ValueMember = "Código"
    End Sub
    Public Function percorreCLBXContasChecked(ByVal conta As Integer) As Integer

        If clbxContas.CheckedItems.Count = 0 Then Return 1
        For Each item As DataRowView In clbxContas.CheckedItems
            If conta = item.Item(0) Then
                Return 1
            End If
        Next
        Return 0
    End Function
    Public Function percorreCLBXContasChecked2(ByVal conta As Integer) As Integer
        For Each item As DataRowView In clbxContas.CheckedItems
            If conta = item.Item(0) Then
                Return 1
            End If
        Next
        Return 0
    End Function

    ''LBX CENTRO CUSTOS
    Public Sub preencheCLBXCenCustos()
        Dim dtCC As DataTable = New DataTable
        access.ExecuteQuerry("SELECT * FROM cenCusto")
        dtCC = access.dt
        clbxCenCustos.DataSource = dtCC
        clbxCenCustos.DisplayMember = "descricao"
        clbxCenCustos.ValueMember = "Código"
    End Sub
    Public Function percorreCLBXCenCusChecked(ByVal CentroCustos As Integer) As Integer
        If clbxCenCustos.CheckedItems.Count = 0 Then Return 1
        For Each item As DataRowView In clbxCenCustos.CheckedItems
            If CentroCustos = item.Item(0) Then
                Return 1
            End If
        Next
        Return 0
    End Function

    ''LBX  FAVORECIDOS 
    Public Sub preencheLBXFavorecidos()

        dtChecked.Columns.Add("Código")
        dtChecked.Columns.Add("nome")

        access.ExecuteQuerry("SELECT * from favorecidos")

        dtF = access.dt

        lbxFavorecidos.DataSource = dtF
        lbxFavorecidos.DisplayMember = "nome"
        lbxFavorecidos.ValueMember = "Código"

        lbxFavorecidosChecked.DataSource = dtChecked
        lbxFavorecidosChecked.DisplayMember = "nome"
        lbxFavorecidosChecked.ValueMember = "Código"

    End Sub
    Private Sub lbxFavorecidos_DoubleClick(sender As Object, e As EventArgs) Handles lbxFavorecidos.DoubleClick

        Dim r As DataRow = dtChecked.NewRow

        r("nome") = lbxFavorecidos.Text
        r("Código") = lbxFavorecidos.SelectedValue
        dtChecked.Rows.Add(r)

        dtF.Rows.Remove(dtF.Rows(indexDT(lbxFavorecidos.Text)))

        lbxFavorecidosChecked.DataSource = dtChecked
        tbPesquisaFavorecido.Text = ""
        lbxFavorecidos.DataSource = dtF

    End Sub
    Private Sub lbxFavorecidosChecked_DoubleClick(sender As Object, e As EventArgs) Handles lbxFavorecidosChecked.DoubleClick
        Dim r As DataRow = dtF.NewRow

        r("nome") = lbxFavorecidosChecked.Text
        r("Código") = lbxFavorecidosChecked.SelectedValue
        dtF.Rows.Add(r)

        dtChecked.Rows.Remove(dtChecked.Rows(indexDTChecked(lbxFavorecidosChecked.Text)))

        lbxFavorecidosChecked.DataSource = dtChecked

        If tbPesquisaFavorecido.Text.Length < 1 Then
            lbxFavorecidos.DataSource = dtF
        End If
    End Sub
    Public Function indexDT(ByVal descricao As String) As Integer
        Dim count As Integer = 0
        For Each row As DataRow In dtF.Rows
            If row("nome") = descricao Then
                Return count
            End If
            count += 1
        Next
        Return 0
    End Function
    Public Function indexDTChecked(ByVal descricao As String) As Integer
        Dim count As Integer = 0
        For Each row As DataRow In dtChecked.Rows
            If row("nome") = descricao Then
                Return count
            End If
            count += 1
        Next
        Return 0
    End Function
    Private Sub tbPesquisaFavorecido_TextChanged(sender As Object, e As EventArgs) Handles tbPesquisaFavorecido.TextChanged

        If tbPesquisaFavorecido.Text.Length = 0 Then
            lbxFavorecidos.DataSource = dtF
        End If

        Dim dtMatching As DataTable = New DataTable

        dtMatching.Columns.Add("Código")
        dtMatching.Columns.Add("nome")

        For Each row As DataRow In dtF.Rows
            Dim nome = row("nome").ToString.ToLower
            Dim texto = tbPesquisaFavorecido.Text.ToLower
            If nome.IndexOf(texto) > -1 Then
                Dim r As DataRow = dtMatching.NewRow
                r("nome") = row("nome")
                r("Código") = row("Código")                ''MessageBox.Show(lbxFavorecidosChecked.Text)
                dtMatching.Rows.Add(r)
            End If
        Next
        lbxFavorecidos.DataSource = dtMatching
    End Sub
    Public Function percorreDtFavorecidosChecked(ByVal cod_favorecido As String) As Integer

        If dtChecked.Rows.Count = 0 Then Return 1
        For Each row As DataRow In dtChecked.Rows
            If cod_favorecido = row("nome") Then
                Return 1
            End If
        Next
        Return 0
    End Function

    ''TREEVIEW
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
        tvPlanoContas.CheckBoxes = True
    End Sub
    Private Sub tvPlanoContas_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvPlanoContas.AfterCheck
        CheckChildNodes(e.Node, e.Node.Checked)
    End Sub
    Sub CheckChildNodes(ByVal parent As TreeNode, checked As Boolean)
        For Each child As TreeNode In parent.Nodes
            child.Checked = checked
            If child.Nodes.Count > 0 Then CheckChildNodes(child, checked)
        Next
    End Sub
    Private Sub PercorrerNos(ByVal Nos As TreeNodeCollection)

        For Each no As TreeNode In Nos
            If no.Checked = True Then
                ctrl = False
                If countPC > 0 Then
                    ReDim Preserve listPConta(countPC)
                    listPConta(countPC) = retornaidPC(no.Text)
                Else
                    listPConta(countPC) = retornaidPC(no.Text)
                End If
                countPC += 1
            End If
            PercorrerNos(no.Nodes)
        Next

    End Sub
    Private Sub PercorrerNos2(ByVal Nos As TreeNodeCollection)

        For Each no As TreeNode In Nos
            If no.Checked = True Then
                aux_transf = False
            End If
            PercorrerNos2(no.Nodes)
        Next

    End Sub
    Public Function retornaidPC(ByVal descricao As String) As Integer
        Dim dt As DataTable = New DataTable

        access.ExecuteQuerry("SELECT * from planoContas where descricao Like '" & descricao & "'")
        dt = access.dt

        For Each row As DataRow In dt.Rows
            Return row("código")
        Next
        Return 0
    End Function
    Public Function verificaPConta(ByVal cod_conta As Integer) As Integer
        If ctrl Then
            Return 1
        End If
        If isIntInArray(cod_conta, listPConta) Then
            Return 1
        End If

        Return 0

    End Function

    ''TB 
    Public Function percorreTB(ByVal obs As String, ByVal desc As String, ByVal cq As String)
        Dim aux As Boolean = True

        If mtbObs.Text.Length > 0 Then
            If Not mtbObs.Text = obs Then
                aux = False
            End If
        End If

        If mtbDescricao.Text.Length > 0 Then
            If Not mtbDescricao.Text = desc Then
                aux = False
            End If
        End If

        If mtbCheque.Text.Length > 0 Then
            If Not mtbCheque.Text = cq Then
                aux = False
            End If
        End If

        If aux Then
            Return 1
        End If
        Return 0
    End Function

    ''DGV
    Private Sub dgvRelatorio_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles mGridRelatorios.CellFormatting
        With mGridRelatorios
            .Columns("CÓD").Width = 35
            .Columns("FAVORECIDO").Width = 220
            .Columns("CATEGORIA").Width = 220
            .Columns("DESCRIÇÃO").Width = 245
            .Columns("PGTO").Width = 80
            .Columns("CHEQUE").Width = 100
            .Columns("VALOR").Width = 100
            .Columns("TIPO").Visible = False

            .Columns("PGTO").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("VALOR").DefaultCellStyle.Format = "C2"


        End With
        For i As Integer = 0 To mGridRelatorios.Rows.Count - 1 Step +1
            Dim tipo As String
            tipo = mGridRelatorios.Rows(i).Cells("TIPO").Value

            If tipo = "2" Then
                mGridRelatorios.Rows(i).DefaultCellStyle.BackColor = Color.LavenderBlush
                mGridRelatorios.Rows(i).DefaultCellStyle.ForeColor = Color.Red
            Else
                mGridRelatorios.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub







End Class