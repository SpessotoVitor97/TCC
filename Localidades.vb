Imports System.Data.OleDb

Public Class Localidades

    Private Sub BtnIrPara_Click(sender As Object, e As EventArgs) Handles btnIrPara.Click
        If LocaliadadesListBox.SelectedItem = "Hospital A" Then
            Unidade1.Show()
        ElseIf LocaliadadesListBox.SelectedItem = "Laboratório A" Then
            'Unidade2.Show()
        End If
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End

    End Sub

    'Private Sub Localidades_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    '    Dim DBcon As New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Acesso.mdb")
    '    Dim Reader As OleDbDataReader

    '    Try
    '        DBcon.Open()
    '        Dim Querry As String
    '        Querry = "SELECT * FROM Acesso.Equipamentos"
    '        Dim Command As New OleDbCommand(Querry, DBcon)
    '        Reader = Command.ExecuteReader

    '        While Reader.Read
    '            Dim Unidade = Reader.GetString("Unidade")
    '            LocaliadadesListBox.Items.Add(Unidade)
    '        End While

    '        DBcon.Close()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        DBcon.Dispose()
    '    End Try

    'End Sub

End Class