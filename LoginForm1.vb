Imports System.Data.OleDb

Public Class LoginForm1

    Private Access As New Controle

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        AutenticarUsu�rio()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Sub AutenticarUsu�rio()

        Access.AddParams("@Usu�rio", UsernameTextBox.Text)
        Access.AddParams("@Senha", PasswordTextBox.Text)

        Access.ExecuteQuery("SELECT * FROM Tab_Users WHERE Usu�rio = @Usu�rio AND Senha = @Senha")

        Access.DBDA.Fill(Access.DBDT)

        If Access.DBDT.Rows.Count > 0 Then
            Label1.Text = Access.DBDT.Rows(0).Item("Usu�rio")
            Label2.Text = Access.DBDT.Rows(0).Item("Senha")
            'Me.Close()
        Else
            MessageBox.Show("Usu�rio n�o encontrado. Por favor verifique se suas credencias est�o corretas.", "Aten��o", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
