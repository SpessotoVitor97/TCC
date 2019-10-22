Imports System.IO
Public Class Unidade1

    Public pbNewEquipment As New PictureBox
    Public pbEquipment As New PictureBox
    Dim separador() As Char = New Char() {","c}

    Public Sub Unidade1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim bgImagem As String

        bgImagem = Localidades.LocalPath
        Me.BackgroundImage = Image.FromFile(bgImagem)

        Obter_localização_dos_esquipamentos.Ler()

        pbEquipment.Width = Obter_localização_dos_esquipamentos.kWidth
        pbEquipment.Height = Obter_localização_dos_esquipamentos.kHeight
        pbEquipment.Top = Obter_localização_dos_esquipamentos.kTop
        pbEquipment.Left = Obter_localização_dos_esquipamentos.KLeft
        pbEquipment.ImageLocation = Obter_localização_dos_esquipamentos.kImageLocation
        Me.Controls.Add(pbEquipment)

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
        SalvarProriedadesPbEquipment()
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
        pbNewEquipment.Height = 228
        pbNewEquipment.Top = 100
        pbNewEquipment.Left = 100
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

    Sub SalvarProriedadesPbEquipment()
        'localização.Escreve(pbNewEquipment.Width & ";" & pbNewEquipment.Height & ";" & pbNewEquipment.Top & ";" & pbNewEquipment.Left & ";" & pbNewEquipment.ImageLocation)
        'localização.Escreve("")
        Obter_localização_dos_esquipamentos.Escreve(pbNewEquipment.Width)
        Obter_localização_dos_esquipamentos.Escreve(pbNewEquipment.Height)
        Obter_localização_dos_esquipamentos.Escreve(pbNewEquipment.Top)
        Obter_localização_dos_esquipamentos.Escreve(pbNewEquipment.Left)
        Obter_localização_dos_esquipamentos.Escreve(pbNewEquipment.ImageLocation)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Obter_localização_dos_esquipamentos.Show()
    End Sub
End Class


'TODO: Criar um método que salva a imagem de fundo do form
'TODO: Criar um método de carregar os equipamentos existentes quando o form for aparecer