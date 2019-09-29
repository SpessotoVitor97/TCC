<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alterar_Equipamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Número_de_SérieTextBox = New System.Windows.Forms.TextBox()
        Me.FabricanteTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.EquipamentoTextBox = New System.Windows.Forms.TextBox()
        Me.dasaTextBox = New System.Windows.Forms.TextBox()
        Me.SetorTextBox = New System.Windows.Forms.TextBox()
        Me.UnidadeTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(443, 41)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(145, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(443, 12)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(145, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Número_de_SérieTextBox)
        Me.GroupBox1.Controls.Add(Me.FabricanteTextBox)
        Me.GroupBox1.Controls.Add(Me.ModeloTextBox)
        Me.GroupBox1.Controls.Add(Me.EquipamentoTextBox)
        Me.GroupBox1.Controls.Add(Me.dasaTextBox)
        Me.GroupBox1.Controls.Add(Me.SetorTextBox)
        Me.GroupBox1.Controls.Add(Me.UnidadeTextBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 237)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados do Equipamento"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(162, 24)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(257, 20)
        Me.DateTimePicker.TabIndex = 8
        '
        'Número_de_SérieTextBox
        '
        Me.Número_de_SérieTextBox.Location = New System.Drawing.Point(162, 206)
        Me.Número_de_SérieTextBox.Name = "Número_de_SérieTextBox"
        Me.Número_de_SérieTextBox.Size = New System.Drawing.Size(257, 20)
        Me.Número_de_SérieTextBox.TabIndex = 16
        '
        'FabricanteTextBox
        '
        Me.FabricanteTextBox.Location = New System.Drawing.Point(162, 180)
        Me.FabricanteTextBox.Name = "FabricanteTextBox"
        Me.FabricanteTextBox.Size = New System.Drawing.Size(257, 20)
        Me.FabricanteTextBox.TabIndex = 15
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.Location = New System.Drawing.Point(162, 154)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(257, 20)
        Me.ModeloTextBox.TabIndex = 14
        '
        'EquipamentoTextBox
        '
        Me.EquipamentoTextBox.Location = New System.Drawing.Point(162, 128)
        Me.EquipamentoTextBox.Name = "EquipamentoTextBox"
        Me.EquipamentoTextBox.Size = New System.Drawing.Size(257, 20)
        Me.EquipamentoTextBox.TabIndex = 13
        '
        'dasaTextBox
        '
        Me.dasaTextBox.Location = New System.Drawing.Point(162, 102)
        Me.dasaTextBox.Name = "dasaTextBox"
        Me.dasaTextBox.Size = New System.Drawing.Size(257, 20)
        Me.dasaTextBox.TabIndex = 12
        '
        'SetorTextBox
        '
        Me.SetorTextBox.Location = New System.Drawing.Point(162, 76)
        Me.SetorTextBox.Name = "SetorTextBox"
        Me.SetorTextBox.Size = New System.Drawing.Size(257, 20)
        Me.SetorTextBox.TabIndex = 10
        '
        'UnidadeTextBox
        '
        Me.UnidadeTextBox.Location = New System.Drawing.Point(162, 50)
        Me.UnidadeTextBox.Name = "UnidadeTextBox"
        Me.UnidadeTextBox.Size = New System.Drawing.Size(257, 20)
        Me.UnidadeTextBox.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Número de série:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fabricante: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Modelo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Equipamento: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DASA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Setor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data de Aquisição:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(443, 99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 145)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Alterar Imagem"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Alterar_Equipamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 253)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Name = "Alterar_Equipamento"
        Me.Text = "Alterar_Equipamento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Número_de_SérieTextBox As TextBox
    Friend WithEvents FabricanteTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents EquipamentoTextBox As TextBox
    Friend WithEvents dasaTextBox As TextBox
    Friend WithEvents SetorTextBox As TextBox
    Friend WithEvents UnidadeTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker As DateTimePicker
End Class
