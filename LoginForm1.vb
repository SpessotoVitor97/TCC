Imports System.Data.OleDb

Public Class LoginForm1

    Private Access As New Controle

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        AutenticarUsuário()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Sub AutenticarUsuário()

        Access.AddParams("@Usuário", UsernameTextBox.Text)
        Access.AddParams("@Senha", PasswordTextBox.Text)

        Access.ExecuteQuery("SELECT * FROM Tab_Users WHERE Usuário = @Usuário AND Senha = @Senha")

        Access.DBDA.Fill(Access.DBDT)

        If Access.DBDT.Rows.Count > 0 Then
            Label1.Text = Access.DBDT.Rows(0).Item("Usuário")
            Label2.Text = Access.DBDT.Rows(0).Item("Senha")
            'Me.Close()
        Else
            MessageBox.Show("Usuário não encontrado. Por favor verifique se suas credencias estão corretas.", "Atenção", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning)
        End If
    End Sub

End Class
