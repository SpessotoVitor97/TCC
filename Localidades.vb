Imports System.Data.OleDb

Public Class Localidades
    Public LocalPath As String

    Public Sub BtnIrPara_Click(sender As Object, e As EventArgs) Handles btnIrPara.Click
        If LocaliadadesListBox.SelectedItem = "Hospital A" Then
            LocalPath = "C:\Users\spess\Desktop\Trab-Vitor\FATEC\Automação-AIM\TCC\06-PROGRAMAS\Supervisorio\Laboratório.png"
            Unidade1.Show()
        ElseIf LocaliadadesListBox.SelectedItem = "Laboratório A" Then
            LocalPath = "C:\Users\spess\Desktop\Trab-Vitor\FATEC\Automação-AIM\TCC\06-PROGRAMAS\Supervisorio\PROJETO-ARQUITETÔNICO-Hospital-Federal-do-Andarai-Planta-Baixa-do-1º-Pavimento-1200x620.jpg"
            Unidade1.Show()
        End If
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub

End Class