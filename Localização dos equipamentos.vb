
Imports System.IO
Imports System.Windows.Forms
Public Class Obter_localização_dos_esquipamentos

    Private Const strCaminho As String = "C:\Users\spess\Desktop\Trab-Vitor\FATEC\Automação-AIM\TCC\06-PROGRAMAS\Supervisorio\Posição dos Equipamentos.txt"
    Public kWidth As Integer = 228
    Public kHeight As Integer = 228
    Public kTop As Integer = 436
    Public KLeft As Integer = 657
    Public kImageLocation As String = "C : \Users\spess\Desktop\Trab-Vitor\FATEC\Automação-AIM\TCC\06-PROGRAMAS\Supervisorio\backupsystem_seagate_copiadeseguridad_1770.ico"

    Dim index As Integer = 0

    Dim propertiesArray(5) As String


    Private Sub BtnObter_Click(sender As Object, e As EventArgs) Handles btnObter.Click
        Ler()
    End Sub

    Public Sub Ler()

        Using streamReader As New StreamReader(strCaminho)
            Do While streamReader.Peek <> -1
                TextBox1.Text = TextBox1.Text & streamReader.ReadLine & vbNewLine
                propertiesArray.Append(TextBox1.Text(index))
                index += 1
            Loop

            'kWidth = 228
            'kHeight = 228
            'kTop = 436
            'KLeft = 657
            'kImageLocation = "C : \Users\spess\Desktop\Trab-Vitor\FATEC\Automação-AIM\TCC\06-PROGRAMAS\Supervisorio\backupsystem_seagate_copiadeseguridad_1770.ico"

            'TODO: Criar um vetor para armazenar o que o streamReader leu e só depois atribuir à variáveis

        End Using
    End Sub

    Public Async Sub Escreve(ByVal texto As String)
        Using streamWriter As New StreamWriter(strCaminho, True)
            Await streamWriter.WriteLineAsync(texto)
            'Print("Aqruivo salvo com sucesso!")
        End Using
    End Sub

    Private Sub BtnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Escreve(TextBox1.Text)
    End Sub
End Class
