Imports System.Data.OleDb

Public Class Controller
    ''Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; DATA SOURCE= C:\Program Files (x86)\VENATTI SOFTWARE\Instalador Sobreira\base.ACCDB")
    Private conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; DATA SOURCE= base.ACCDB")

    Private comando As OleDbCommand
    Private da As OleDbDataAdapter
    Public dt As DataTable
    Public paramns As New List(Of OleDbParameter)

    Public Sub ExecuteQuerry(ByVal Query As String)
        Try
            conn.Open()
            comando = New OleDbCommand(Query, conn) 'cria o comando
            paramns.ForEach(Sub(p) comando.Parameters.Add(p)) 'adiciona os paramentros no comando 
            paramns.Clear() 'limpa lista de parametros
            dt = New DataTable
            da = New OleDbDataAdapter(comando) 'executando
            da.Fill(dt) 'preenchendo a tabela

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    Public Sub AddParam(ByVal nome As String, ByVal valor As Object)

        Dim novo As New OleDbParameter(nome, valor)

        paramns.Add(novo)

    End Sub

End Class
