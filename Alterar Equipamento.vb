﻿Public Class Alterar_Equipamento

    Private Access As New Controle
    Public Property Registro As Integer


    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If DateTimePicker.Value.Date > Nothing Or UnidadeTextBox.TextLength > 0 Or SetorTextBox.TextLength > 0 Or dasaTextBox.TextLength > 0 Or EquipamentoTextBox.TextLength > 0 Or ModeloTextBox.TextLength > 0 Or FabricanteTextBox.TextLength > 0 Or númeroDeSérieTextBox.TextLength > 0 And Registro > 0 Then

            Access.AddParams("@Data de aquisição", DateTimePicker.Value.Date)
            Access.AddParams("@Unidade", UnidadeTextBox.Text)
            Access.AddParams("@Equipamento", EquipamentoTextBox.Text)
            Access.AddParams("@Registro", Registro)

            Access.ExecuteQuery("UPDATE Equipamentos SET Unidade = @Unidade, Equipamento = @Equipamento WHERE Identificação = @Registro")
            Close()

        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub Alterar_Equipamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class