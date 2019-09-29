Public Class Alterar_Equipamento

    Private Access As New Controle
    Public Property Registro As Integer


    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If DateTimePicker.Value.Date > Nothing Or UnidadeTextBox.TextLength > 0 Or SetorTextBox.TextLength > 0 Or dasaTextBox.TextLength > 0 Or EquipamentoTextBox.TextLength > 0 Or ModeloTextBox.TextLength > 0 Or FabricanteTextBox.TextLength > 0 Or Número_de_SérieTextBox.TextLength > 0 And Registro > 0 Then

            Access.AddParams("@Data_de_aquisição", DateTimePicker.Value.Date)
            Access.AddParams("@Unidade", UnidadeTextBox.Text)
            Access.AddParams("@Setor", SetorTextBox.Text)
            Access.AddParams("@DASA", dasaTextBox.Text)
            Access.AddParams("@Equipamento", EquipamentoTextBox.Text)
            Access.AddParams("@Modelo", ModeloTextBox.Text)
            Access.AddParams("@Fabricante", FabricanteTextBox.Text)
            Access.AddParams("@Número_de_Série", Número_de_SérieTextBox.Text)
            Access.AddParams("@Registro", Registro)

            Access.ExecuteQuery("UPDATE Equipamentos SET Data_de_aquisição = @Data_de_aquisição, Unidade = @Unidade, Setor = @Setor, DASA = @DASA, Equipamento = @Equipamento, Modelo = @Modelo, Fabricante = @Fabricante, Número_de_Série = @Número_de_Série WHERE Identificação = @Registro")

            Close()

        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

End Class