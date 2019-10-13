
Imports System.IO
Imports System.Windows.Forms
Public Class Obter_localização_dos_esquipamentos

    Private Const strCaminho As String = "C:\Users\spess\Desktop\Trab-Vitor\FATEC\Automação-AIM\TCC\06-PROGRAMAS\Supervisorio\Posição dos Equipamentos.txt"
    Public kWidth As Integer
    Public kHeight As Integer
    Public kTop As Integer
    Public KLeft As Integer
    Public kImageLocation As String


    Private Sub BtnObter_Click(sender As Object, e As EventArgs) Handles btnObter.Click
        Ler()
    End Sub

    Public Sub Ler()

        Using streamReader As New StreamReader(strCaminho)
            Do While streamReader.Peek <> -1
                TextBox1.Text = TextBox1.Text & streamReader.ReadLine & vbNewLine
            Loop

            kWidth &= streamReader.ReadLine
            kHeight &= streamReader.ReadLine
            kTop &= streamReader.ReadLine
            KLeft &= streamReader.ReadLine
            kImageLocation &= streamReader.ReadLine

        End Using
    End Sub

    Public Async Sub Escreve(ByVal texto As String)
        Using streamWriter As New StreamWriter(strCaminho, True)
            Await streamWriter.WriteLineAsync(texto)
            Print("Aqruivo salvo com sucesso!")
        End Using
    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Escreve(TextBox1.Text)
    End Sub
End Class
