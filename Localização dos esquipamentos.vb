
Imports System.IO
Imports System.Windows.Forms
Public Class Obter_localização_dos_esquipamentos

    Dim strCaminho As String = "C:\Users\spess\Desktop\Trab-Vitor\FATEC\Automação-AIM\TCC\06-PROGRAMAS\Supervisorio"
    Private Sub BtnObter_Click(sender As Object, e As EventArgs) Handles btnObter.Click
        Using stringReader As New StringReader(strCaminho & "Posição dos Equipamentos.txt")
            Do While stringReader.Peek <> -1
                TextBox1.Text = TextBox1.Text & stringReader.Read & vbNewLine
            Loop
        End Using
    End Sub

    Private Async Sub Escreve(ByVal texto As String)
        Using stringWriter As New StringWriter(strCaminho & "\Teste de escrita.txt")
            Await stringWriter.WriteAsync(texto)
            MessageBox.Show("Arquivo salvo!", "Aviso")

        End Using
    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Escreve(TextBox1.Text)
    End Sub
End Class


'TODO: Corrigir o método de escrita e leitura