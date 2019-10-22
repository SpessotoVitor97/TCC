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
        Me.btnSimularEvento = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPararSimulação = New System.Windows.Forms.Button()
        Me.btnNovoEquipamento = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCarregaImagem
        '
        resources.ApplyResources(Me.btnCarregaImagem, "btnCarregaImagem")
        Me.btnCarregaImagem.Name = "btnCarregaImagem"
        Me.btnCarregaImagem.UseVisualStyleBackColor = True
        '
        'btnSimularEvento
        '
        resources.ApplyResources(Me.btnSimularEvento, "btnSimularEvento")
        Me.btnSimularEvento.Name = "btnSimularEvento"
        Me.btnSimularEvento.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnPararSimulação
        '
        resources.ApplyResources(Me.btnPararSimulação, "btnPararSimulação")
        Me.btnPararSimulação.Name = "btnPararSimulação"
        Me.btnPararSimulação.UseVisualStyleBackColor = True
        '
        'btnNovoEquipamento
        '
        resources.ApplyResources(Me.btnNovoEquipamento, "btnNovoEquipamento")
        Me.btnNovoEquipamento.Name = "btnNovoEquipamento"
        Me.btnNovoEquipamento.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Unidade1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNovoEquipamento)
        Me.Controls.Add(Me.btnPararSimulação)
        Me.Controls.Add(Me.btnSimularEvento)
        Me.Controls.Add(Me.btnCarregaImagem)
        Me.Name = "Unidade1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCarregaImagem As Button
    Friend WithEvents btnSimularEvento As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnPararSimulação As Button
    Friend WithEvents btnNovoEquipamento As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
