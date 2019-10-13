Imports System.IO
Public Class Unidade1

    Dim pbNewEquipment As New PictureBox

    Private Sub Unidade1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Stop()
        btnPararSimulação.Enabled = False

    End Sub

    Private Sub BtnSimularEvento_Click(sender As Object, e As EventArgs) Handles btnSimularEvento.Click

        If pbNewEquipment.Visible = False Then
            pbNewEquipment.Visible = True
            Timer1.Start()
        Else
            Timer1.Start()

        End If

        btnPararSimulação.Enabled = True

    End Sub

    Private Sub BtnPararSimulação_Click(sender As Object, e As EventArgs) Handles btnPararSimulação.Click

        pbNewEquipment.Visible = True
        Timer1.Stop()
        btnPararSimulação.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If pbNewEquipment.Visible = True Then
            pbNewEquipment.Visible = False

        ElseIf pbNewEquipment.Visible = False Then
            pbNewEquipment.Visible = True

        End If

    End Sub

    Private Sub BtnCarregaImagem_Click(sender As Object, e As EventArgs) Handles btnCarregaImagem.Click
        LoadImageToFomrBackGround()
    End Sub

    Private Sub BtnNovoEquipamento_Click(sender As Object, e As EventArgs) Handles btnNovoEquipamento.Click
        LoadImageInEquipmentPictureBox()
    End Sub

    Sub LoadImageInEquipmentPictureBox()
        Dim newEquipmentImagePath As New OpenFileDialog
        Dim newEquipmentImage As String = ""

        newEquipmentImagePath.InitialDirectory = Environment.SpecialFolder.MyComputer

        If newEquipmentImagePath.ShowDialog = DialogResult.OK Then
            newEquipmentImage = Path.GetFullPath(newEquipmentImagePath.FileName)
        Else
            MessageBox.Show("Por Favor, escolha uma imagem.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        pbNewEquipment.Width = 228
        pbNewEquipment.Height = 230
        pbNewEquipment.Top = 0
        pbNewEquipment.Left = 0
        pbNewEquipment.ImageLocation = newEquipmentImage
        Me.Controls.Add(pbNewEquipment)
    End Sub

    Sub LoadImageToFomrBackGround()
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