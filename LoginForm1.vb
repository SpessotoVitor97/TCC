Public Class LoginForm1

    Private Access As New Controle
    Public Reader As OleDb.OleDbDataReader

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Sub AutenticarUsu�rio(ByVal User As String, ByVal Password As String)

        Access.AddParams("@Usu�rio", UsernameTextBox.Text)
        Access.AddParams("@Senha", PasswordTextBox.Text)

        Access.ExecuteQuery("SELECT * FROM Tab_Users WHERE Usu�rio = @Usu�rio, Senha = @Senha")

        Dim userNameVerificator As String
        Dim passwordVerificator As String

        userNameVerificator = ""
        passwordVerificator = ""

        'TODO: Terminar os m�todo de consulta no banco de dados para autentica��o de usu�rio

    End Sub

End Class
