<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Novo_Equipamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.equipamentoTextBox = New System.Windows.Forms.TextBox()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.numeroDeSerieTextBox = New System.Windows.Forms.TextBox()
        Me.fabricanteTextBox = New System.Windows.Forms.TextBox()
        Me.modeloTextBox = New System.Windows.Forms.TextBox()
        Me.dasaTextBox = New System.Windows.Forms.TextBox()
        Me.setorTextBox = New System.Windows.Forms.TextBox()
        Me.unidadeTextBox = New System.Windows.Forms.TextBox()
        Me.modeloLabel = New System.Windows.Forms.Label()
        Me.numeroDeSerieLabel = New System.Windows.Forms.Label()
        Me.fabricanteLabel = New System.Windows.Forms.Label()
        Me.dasaLabel = New System.Windows.Forms.Label()
        Me.setorLabel = New System.Windows.Forms.Label()
        Me.unidadeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.equipamentoLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'equipamentoTextBox
        '
        Me.equipamentoTextBox.Location = New System.Drawing.Point(162, 128)
        Me.equipamentoTextBox.Name = "equipamentoTextBox"
        Me.equipamentoTextBox.Size = New System.Drawing.Size(257, 20)
        Me.equipamentoTextBox.TabIndex = 0
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(443, 12)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(145, 23)
        Me.BtnSalvar.TabIndex = 1
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(443, 41)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(145, 23)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dateTimePicker)
        Me.GroupBox1.Controls.Add(Me.numeroDeSerieTextBox)
        Me.GroupBox1.Controls.Add(Me.fabricanteTextBox)
        Me.GroupBox1.Controls.Add(Me.modeloTextBox)
        Me.GroupBox1.Controls.Add(Me.dasaTextBox)
        Me.GroupBox1.Controls.Add(Me.setorTextBox)
        Me.GroupBox1.Controls.Add(Me.unidadeTextBox)
        Me.GroupBox1.Controls.Add(Me.modeloLabel)
        Me.GroupBox1.Controls.Add(Me.numeroDeSerieLabel)
        Me.GroupBox1.Controls.Add(Me.fabricanteLabel)
        Me.GroupBox1.Controls.Add(Me.dasaLabel)
        Me.GroupBox1.Controls.Add(Me.setorLabel)
        Me.GroupBox1.Controls.Add(Me.unidadeLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.equipamentoLabel)
        Me.GroupBox1.Controls.Add(Me.equipamentoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 237)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Cadastrais"
        '
        'dateTimePicker
        '
        Me.dateTimePicker.Location = New System.Drawing.Point(162, 24)
        Me.dateTimePicker.Name = "dateTimePicker"
        Me.dateTimePicker.Size = New System.Drawing.Size(257, 20)
        Me.dateTimePicker.TabIndex = 17
        Me.dateTimePicker.TabStop = False
        Me.dateTimePicker.Value = New Date(2019, 8, 28, 0, 0, 0, 0)
        '
        'numeroDeSerieTextBox
        '
        Me.numeroDeSerieTextBox.Location = New System.Drawing.Point(162, 207)
        Me.numeroDeSerieTextBox.Name = "numeroDeSerieTextBox"
        Me.numeroDeSerieTextBox.Size = New System.Drawing.Size(257, 20)
        Me.numeroDeSerieTextBox.TabIndex = 16
        '
        'fabricanteTextBox
        '
        Me.fabricanteTextBox.Location = New System.Drawing.Point(162, 180)
        Me.fabricanteTextBox.Name = "fabricanteTextBox"
        Me.fabricanteTextBox.Size = New System.Drawing.Size(257, 20)
        Me.fabricanteTextBox.TabIndex = 15
        '
        'modeloTextBox
        '
        Me.modeloTextBox.Location = New System.Drawing.Point(162, 154)
        Me.modeloTextBox.Name = "modeloTextBox"
        Me.modeloTextBox.Size = New System.Drawing.Size(257, 20)
        Me.modeloTextBox.TabIndex = 14
        '
        'dasaTextBox
        '
        Me.dasaTextBox.Location = New System.Drawing.Point(162, 102)
        Me.dasaTextBox.Name = "dasaTextBox"
        Me.dasaTextBox.Size = New System.Drawing.Size(257, 20)
        Me.dasaTextBox.TabIndex = 13
        '
        'setorTextBox
        '
        Me.setorTextBox.Location = New System.Drawing.Point(162, 76)
        Me.setorTextBox.Name = "setorTextBox"
        Me.setorTextBox.Size = New System.Drawing.Size(257, 20)
        Me.setorTextBox.TabIndex = 12
        '
        'unidadeTextBox
        '
        Me.unidadeTextBox.Location = New System.Drawing.Point(162, 50)
        Me.unidadeTextBox.Name = "unidadeTextBox"
        Me.unidadeTextBox.Size = New System.Drawing.Size(257, 20)
        Me.unidadeTextBox.TabIndex = 11
        '
        'modeloLabel
        '
        Me.modeloLabel.AutoSize = True
        Me.modeloLabel.Location = New System.Drawing.Point(6, 157)
        Me.modeloLabel.Name = "modeloLabel"
        Me.modeloLabel.Size = New System.Drawing.Size(45, 13)
        Me.modeloLabel.TabIndex = 7
        Me.modeloLabel.Text = "Modelo:"
        '
        'numeroDeSerieLabel
        '
        Me.numeroDeSerieLabel.AutoSize = True
        Me.numeroDeSerieLabel.Location = New System.Drawing.Point(6, 210)
        Me.numeroDeSerieLabel.Name = "numeroDeSerieLabel"
        Me.numeroDeSerieLabel.Size = New System.Drawing.Size(87, 13)
        Me.numeroDeSerieLabel.TabIndex = 9
        Me.numeroDeSerieLabel.Text = "Número de série:"
        '
        'fabricanteLabel
        '
        Me.fabricanteLabel.AutoSize = True
        Me.fabricanteLabel.Location = New System.Drawing.Point(6, 183)
        Me.fabricanteLabel.Name = "fabricanteLabel"
        Me.fabricanteLabel.Size = New System.Drawing.Size(60, 13)
        Me.fabricanteLabel.TabIndex = 8
        Me.fabricanteLabel.Text = "Fabricante:"
        '
        'dasaLabel
        '
        Me.dasaLabel.AutoSize = True
        Me.dasaLabel.Location = New System.Drawing.Point(6, 105)
        Me.dasaLabel.Name = "dasaLabel"
        Me.dasaLabel.Size = New System.Drawing.Size(39, 13)
        Me.dasaLabel.TabIndex = 5
        Me.dasaLabel.Text = "DASA:"
        '
        'setorLabel
        '
        Me.setorLabel.AutoSize = True
        Me.setorLabel.Location = New System.Drawing.Point(6, 79)
        Me.setorLabel.Name = "setorLabel"
        Me.setorLabel.Size = New System.Drawing.Size(35, 13)
        Me.setorLabel.TabIndex = 4
        Me.setorLabel.Text = "Setor:"
        '
        'unidadeLabel
        '
        Me.unidadeLabel.AutoSize = True
        Me.unidadeLabel.Location = New System.Drawing.Point(6, 53)
        Me.unidadeLabel.Name = "unidadeLabel"
        Me.unidadeLabel.Size = New System.Drawing.Size(50, 13)
        Me.unidadeLabel.TabIndex = 3
        Me.unidadeLabel.Text = "Unidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Data de Aquisição:"
        '
        'equipamentoLabel
        '
        Me.equipamentoLabel.AutoSize = True
        Me.equipamentoLabel.Location = New System.Drawing.Point(6, 131)
        Me.equipamentoLabel.Name = "equipamentoLabel"
        Me.equipamentoLabel.Size = New System.Drawing.Size(72, 13)
        Me.equipamentoLabel.TabIndex = 1
        Me.equipamentoLabel.Text = "Equipamento:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(443, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 145)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Nova Imagem"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Novo_Equipamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 253)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Novo_Equipamento"
        Me.Text = "Novo_Equipamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents equipamentoTextBox As TextBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents numeroDeSerieLabel As Label
    Friend WithEvents fabricanteLabel As Label
    Friend WithEvents modeloLabel As Label
    Friend WithEvents dasaLabel As Label
    Friend WithEvents setorLabel As Label
    Friend WithEvents unidadeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents equipamentoLabel As Label
    Friend WithEvents numeroDeSerieTextBox As TextBox
    Friend WithEvents fabricanteTextBox As TextBox
    Friend WithEvents modeloTextBox As TextBox
    Friend WithEvents dasaTextBox As TextBox
    Friend WithEvents setorTextBox As TextBox
    Friend WithEvents unidadeTextBox As TextBox
    Friend WithEvents dateTimePicker As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
