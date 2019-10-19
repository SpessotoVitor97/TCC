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

End Class