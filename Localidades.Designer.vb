<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Localidades
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LocaliadadesListBox = New System.Windows.Forms.ListBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.AcessoDataSet = New Software_Supervisório.AcessoDataSet()
        Me.EquipamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquipamentosTableAdapter = New Software_Supervisório.AcessoDataSetTableAdapters.EquipamentosTableAdapter()
        Me.btnNovaLocalidade = New System.Windows.Forms.Button()
        Me.btnIrPara = New System.Windows.Forms.Button()
        CType(Me.AcessoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquipamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecione a localidade"
        '
        'LocaliadadesListBox
        '
        Me.LocaliadadesListBox.FormattingEnabled = True
        Me.LocaliadadesListBox.Items.AddRange(New Object() {"Hospital A", "Laboratório A"})
        Me.LocaliadadesListBox.Location = New System.Drawing.Point(66, 98)
        Me.LocaliadadesListBox.Name = "LocaliadadesListBox"
        Me.LocaliadadesListBox.Size = New System.Drawing.Size(482, 225)
        Me.LocaliadadesListBox.TabIndex = 1
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(521, 12)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 2
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'AcessoDataSet
        '
        Me.AcessoDataSet.DataSetName = "AcessoDataSet"
        Me.AcessoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquipamentosBindingSource
        '
        Me.EquipamentosBindingSource.DataMember = "Equipamentos"
        Me.EquipamentosBindingSource.DataSource = Me.AcessoDataSet
        '
        'EquipamentosTableAdapter
        '
        Me.EquipamentosTableAdapter.ClearBeforeFill = True
        '
        'btnNovaLocalidade
        '
        Me.btnNovaLocalidade.Location = New System.Drawing.Point(416, 12)
        Me.btnNovaLocalidade.Name = "btnNovaLocalidade"
        Me.btnNovaLocalidade.Size = New System.Drawing.Size(99, 23)
        Me.btnNovaLocalidade.TabIndex = 3
        Me.btnNovaLocalidade.Text = "Nova localidade"
        Me.btnNovaLocalidade.UseVisualStyleBackColor = True
        '
        'btnIrPara
        '
        Me.btnIrPara.Location = New System.Drawing.Point(258, 350)
        Me.btnIrPara.Name = "btnIrPara"
        Me.btnIrPara.Size = New System.Drawing.Size(75, 23)
        Me.btnIrPara.TabIndex = 4
        Me.btnIrPara.Text = "Ir para"
        Me.btnIrPara.UseVisualStyleBackColor = True
        '
        'Localidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 468)
        Me.Controls.Add(Me.btnIrPara)
        Me.Controls.Add(Me.btnNovaLocalidade)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.LocaliadadesListBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Localidades"
        Me.Text = "Localidades"
        CType(Me.AcessoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquipamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LocaliadadesListBox As ListBox
    Friend WithEvents btnSair As Button
    Friend WithEvents AcessoDataSet As AcessoDataSet
    Friend WithEvents EquipamentosBindingSource As BindingSource
    Friend WithEvents EquipamentosTableAdapter As AcessoDataSetTableAdapters.EquipamentosTableAdapter
    Friend WithEvents btnNovaLocalidade As Button
    Friend WithEvents btnIrPara As Button
End Class
