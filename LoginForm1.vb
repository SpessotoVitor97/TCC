Public Class LoginForm1

    Private Access As New Controle
    Public Reader As OleDb.OleDbDataReader

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Sub AutenticarUsuário(ByVal User As String, ByVal Password As String)

        Access.AddParams("@Usuário", UsernameTextBox.Text)
        Access.AddParams("@Senha", PasswordTextBox.Text)

        Access.ExecuteQuery("SELECT * FROM Tab_Users WHERE Usuário = @Usuário, Senha = @Senha")

        Dim userNameVerificator As String
        Dim passwordVerificator As String

        userNameVerificator = ""
        passwordVerificator = ""

        'TODO: Terminar os método de consulta no banco de dados para autenticação de usuário

    End Sub

End Class
