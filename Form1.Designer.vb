<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.btnNovoEquipamento = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnLocais = New System.Windows.Forms.Button()
        Me.btnUSB = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(12, 80)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.Size = New System.Drawing.Size(752, 358)
        Me.dgvDados.TabIndex = 3
        '
        'btnNovoEquipamento
        '
        Me.btnNovoEquipamento.Location = New System.Drawing.Point(12, 51)
        Me.btnNovoEquipamento.Name = "btnNovoEquipamento"
        Me.btnNovoEquipamento.Size = New System.Drawing.Size(111, 23)
        Me.btnNovoEquipamento.TabIndex = 4
        Me.btnNovoEquipamento.Text = "Novo Equipamento"
        Me.btnNovoEquipamento.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(129, 51)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 5
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnDeletar
        '
        Me.btnDeletar.Location = New System.Drawing.Point(210, 51)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletar.TabIndex = 6
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnLocais
        '
        Me.btnLocais.Location = New System.Drawing.Point(291, 51)
        Me.btnLocais.Name = "btnLocais"
        Me.btnLocais.Size = New System.Drawing.Size(93, 23)
        Me.btnLocais.TabIndex = 7
        Me.btnLocais.Text = "Vizualizar Locais"
        Me.btnLocais.UseVisualStyleBackColor = True
        '
        'btnUSB
        '
        Me.btnUSB.Location = New System.Drawing.Point(689, 51)
        Me.btnUSB.Name = "btnUSB"
        Me.btnUSB.Size = New System.Drawing.Size(75, 23)
        Me.btnUSB.TabIndex = 8
        Me.btnUSB.Text = "USB"
        Me.btnUSB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(457, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUSB)
        Me.Controls.Add(Me.btnLocais)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnNovoEquipamento)
        Me.Controls.Add(Me.dgvDados)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents btnNovoEquipamento As Button
    Friend WithEvents btnAlterar As Button
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnLocais As Button
    Friend WithEvents btnUSB As Button
    Friend WithEvents Button1 As Button
End Class
