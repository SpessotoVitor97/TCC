Public Class Form1

    Private Dados As New Controle
    Private intReg As Integer


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        AtualizaRegistro()
    End Sub

    Public Sub AtualizaRegistro()
        Dados.ExecuteQuery("SELECT * FROM Equipamentos")
        dgvDados.DataSource = Dados.DBDT
    End Sub

    Private Sub dgvDados_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.RowEnter
        intReg = dgvDados.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub BtnNovoEquipamento_Click(sender As Object, e As EventArgs) Handles btnNovoEquipamento.Click
        Dim frm As New Novo_Equipamento
        frm.ShowDialog(Me)
        AtualizaRegistro()
    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim frm As New Alterar_Equipamento
        frm.Registro = intReg
        frm.ShowDialog(Me)
        AtualizaRegistro()
    End Sub

    Private Sub BtnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        If MessageBox.Show("Parece que você está tentando remover um registro. Esta ação não poderá ser desfeita. Deseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dados.AddParams("@Registro", dgvDados.CurrentRow.Cells(0).Value)
            Dados.ExecuteQuery("DELETE FROM Equipamentos WHERE Identificação = @Registro")
            AtualizaRegistro()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLocais.Click
        Localidades.Show()
        Me.Hide()
    End Sub

    Private Sub btnUSB_Click(sender As Object, e As EventArgs) Handles btnUSB.Click
        Comunicação_arduino.Show()
    End Sub

    Private Sub BtnLocalização_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Obter_localização_dos_esquipamentos.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm1.Show()
    End Sub
End Class
