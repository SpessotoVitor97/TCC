
Imports System.IO
Imports System.Windows.Forms
Public Class Obter_localização_dos_esquipamentos

    Dim strCaminho As String = "C:\Users\spess\Desktop\Trab-Vitor\FATEC\Automação-AIM\TCC\06-PROGRAMAS\Supervisorio"
    Private Sub BtnObter_Click(sender As Object, e As EventArgs) Handles btnObter.Click
        'Using MyReader As New Microsoft.VisualBasic.
        '              FileIO.TextFieldParser(
        '                "C:\Users\spess\Desktop\Trab-Vitor\FATEC\Automação-AIM\TCC\06-PROGRAMAS\Supervisorio\Posição dos Equipamentos.txt")
        '    MyReader.TextFieldType = FileIO.FieldType.Delimited
        '    MyReader.SetDelimiters(",")
        '    Dim currentRow As String()
        '    While Not MyReader.EndOfData
        '        Try
        '            currentRow = MyReader.ReadFields()
        '            Dim currentField As String
        '            For Each currentField In currentRow
        '                TextBox1.Text = currentField & vbNewLine
        '            Next
        '        Catch ex As Microsoft.VisualBasic.
        '                    FileIO.MalformedLineException
        '            MsgBox("Line " & ex.Message &
        '            "is not valid and will be skipped.")
        '        End Try
        '    End While
        'End Using

        Using streamReader As New StreamReader(strCaminho & "\Posição dos Equipamentos.txt")
            Do While streamReader.Peek <> -1
                TextBox1.Text = TextBox1.Text & streamReader.ReadLine & vbNewLine
            Loop
        End Using
    End Sub

    Private Async Sub Escreve(ByVal texto As String)
        Using streamWriter As New StreamWriter(strCaminho & "\Teste de escrita.txt")
            Await streamWriter.WriteAsync(texto)
            MessageBox.Show("Arquivo salvo!", "Aviso")

        End Using
    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Escreve(TextBox1.Text)
    End Sub
End Class


'TODO: Corrigir o método de escrita e leitura