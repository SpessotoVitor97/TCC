Imports System.IO
Public Class Unidade1

    Private Sub Unidade1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Stop()
        PictureBox1.Visible = True
        btnPararSimulação.Enabled = False

    End Sub

    Private Sub BtnSimularEvento_Click(sender As Object, e As EventArgs) Handles btnSimularEvento.Click

        If PictureBox1.Visible = False Then
            PictureBox1.Visible = True
            Timer1.Start()
        Else
            Timer1.Start()

        End If

        btnPararSimulação.Enabled = True

    End Sub

    Private Sub BtnPararSimulação_Click(sender As Object, e As EventArgs) Handles btnPararSimulação.Click

        PictureBox1.Visible = True
        Timer1.Stop()
        btnPararSimulação.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False

        ElseIf PictureBox1.Visible = False Then
            PictureBox1.Visible = True

        End If

    End Sub

    Private Sub BtnCarregaImagem_Click(sender As Object, e As EventArgs) Handles btnCarregaImagem.Click

        Dim Caminho As New OpenFileDialog
        Caminho.InitialDirectory = Environment.SpecialFolder.MyComputer

        If Caminho.ShowDialog = DialogResult.OK Then
            Dim bgImagem As String
            bgImagem = Path.GetFullPath(Caminho.FileName)
            Me.BackgroundImage = Image.FromFile(bgImagem)
        End If

    End Sub

End Class


'TODO: Criar um botão que salva a imagem de fundo do form