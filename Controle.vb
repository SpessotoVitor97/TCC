Imports System.Data.OleDb

Public Class Controle
    Private DBCon As New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Acesso.mdb")

    Private DBcmd As OleDbCommand

    Private DBDA As OleDbDataAdapter

    Public DBDT As DataTable

    Public Params As New List(Of OleDbParameter)

    Public Sub ExecuteQuery(ByVal Query As String)

        Try
            'Abre a conexão
            DBCon.Open()

            'Cria o comando
            DBcmd = New OleDbCommand(Query, DBCon)

            'Adiciona os parametros ao comando
            Params.ForEach(Sub(p) DBcmd.Parameters.Add(p))

            'Limpa a lista de parametros
            Params.Clear()

            'Cria a tabela
            DBDT = New DataTable

            'Executa
            DBDA = New OleDbDataAdapter(DBcmd)

            'Preenche a DataTable
            DBDA.Fill(DBDT)

        Catch ex As Exception
            MsgBox("Houve um erro:", ex.Message)
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try

    End Sub

    Public Sub AddParams(ByVal Nome As String, ByVal Valor As Object)

        Dim novo As New OleDbParameter(Nome, Valor)

        Params.Add(novo)

    End Sub

End Class
