Public Class Novo_Usuário
    Public Access As New Controle

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        ConfirmarSenha()
    End Sub

    Private Sub ConfirmarSenha()
        Dim Senha As String = TextBoxSenha.Text
        Dim Confirmacao As String = TextBoxConfirmarSenha.Text

        If Senha = Confirmacao Then
            NovoUsuário()
            Me.Close()
        Else
            MessageBox.Show("As senhas devem ser idênticas. Tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub NovoUsuário()
        Access.AddParams("@Usuário", TextBoxUsuário.Text)
        Access.AddParams("@Senha", TextBoxSenha.Text)
        Access.AddParams("@Nome", TextBoxNome.Text)
        Access.AddParams("@Sobrenome", TextBoxSobrenome.Text)
        Access.AddParams("@Data_de_Nascimento", DateTimePicker1.Value.Date)
        Access.AddParams("@Email", TextBoxEmail.Text)

        Access.ExecuteQuery("INSERT INTO Tab_Users (Usuário, [Senha], [Nome], [Sobrenome], [Data_de_Nascimento], [Email]) VALUES (@Usuário, @Senha, @Nome, @Sobrenome, @Data_de_Nascimento, Email)")

    End Sub

End Class