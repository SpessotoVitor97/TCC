Public Class Novo_Equipamento

    Private Access As New Controle

    Private Sub NovoRegistro()

        If dateTimePicker.Value.Date > Nothing Or unidadeTextBox.TextLength Or setorTextBox.TextLength Or dasaTextBox.TextLength Or equipamentoTextBox.TextLength Or modeloTextBox.TextLength Or fabricanteTextBox.TextLength Or Número_de_SérieTextBox.TextLength > 0 Then

            Access.AddParams("@Data_de_aquisição", dateTimePicker.Value.Date)
            Access.AddParams("@Unidade", unidadeTextBox.Text)
            Access.AddParams("@Setor", setorTextBox.Text)
            Access.AddParams("@DASA", dasaTextBox.Text)
            Access.AddParams("@Equipamento", equipamentoTextBox.Text)
            Access.AddParams("@Modelo", modeloTextBox.Text)
            Access.AddParams("@Fabricante", fabricanteTextBox.Text)
            Access.AddParams("@Número_de_Série", Número_de_SérieTextBox.Text)

            Access.ExecuteQuery("INSERT INTO Equipamentos (Data_de_aquisição, [Unidade], [Setor], [DASA], [Equipamento], [Modelo], [Fabricante], [Número_de_Série]) VALUES (@Data_de_aquisição, @Unidade, @Setor, @DASA, @Equipamentos, @Modelo, @Fabricante, @Número_de_Série)")

        End If
    End Sub

    Private Sub EquipamentoTextBox_TextChanged(sender As Object, e As EventArgs) Handles equipamentoTextBox.TextChanged
        If equipamentoTextBox.TextLength > 0 Then
            BtnSalvar.Enabled = True
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        NovoRegistro()
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

End Class