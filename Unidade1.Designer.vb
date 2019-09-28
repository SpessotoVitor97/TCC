<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Unidade1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Unidade1))
        Me.btnCarregaImagem = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSimularEvento = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPararSimulação = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCarregaImagem
        '
        Me.btnCarregaImagem.Location = New System.Drawing.Point(12, 12)
        Me.btnCarregaImagem.Name = "btnCarregaImagem"
        Me.btnCarregaImagem.Size = New System.Drawing.Size(144, 23)
        Me.btnCarregaImagem.TabIndex = 0
        Me.btnCarregaImagem.Text = "Carregar nova imagem"
        Me.btnCarregaImagem.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(431, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 230)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnSimularEvento
        '
        Me.btnSimularEvento.Location = New System.Drawing.Point(12, 41)
        Me.btnSimularEvento.Name = "btnSimularEvento"
        Me.btnSimularEvento.Size = New System.Drawing.Size(144, 23)
        Me.btnSimularEvento.TabIndex = 2
        Me.btnSimularEvento.Text = "Simular um evento"
        Me.btnSimularEvento.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnPararSimulação
        '
        Me.btnPararSimulação.Location = New System.Drawing.Point(12, 70)
        Me.btnPararSimulação.Name = "btnPararSimulação"
        Me.btnPararSimulação.Size = New System.Drawing.Size(144, 23)
        Me.btnPararSimulação.TabIndex = 3
        Me.btnPararSimulação.Text = "Parar simulação"
        Me.btnPararSimulação.UseVisualStyleBackColor = True
        '
        'Unidade1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPararSimulação)
        Me.Controls.Add(Me.btnSimularEvento)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCarregaImagem)
        Me.Name = "Unidade1"
        Me.Text = "Unidade1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCarregaImagem As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSimularEvento As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPararSimulação As Button
End Class
