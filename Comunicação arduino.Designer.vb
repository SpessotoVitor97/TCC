<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Comunicação_arduino
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMonitorar = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxStringDeEntrada = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDelimitador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.ListBoxResultado = New System.Windows.Forms.ListBox()
        Me.btnMoverParaBancoDeDados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(140, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INATIVO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMonitorar
        '
        Me.btnMonitorar.Location = New System.Drawing.Point(77, 403)
        Me.btnMonitorar.Name = "btnMonitorar"
        Me.btnMonitorar.Size = New System.Drawing.Size(85, 35)
        Me.btnMonitorar.TabIndex = 1
        Me.btnMonitorar.Text = "Monitorar Dispositivos"
        Me.btnMonitorar.UseVisualStyleBackColor = True
        '
        'btnParar
        '
        Me.btnParar.Location = New System.Drawing.Point(168, 403)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(85, 35)
        Me.btnParar.TabIndex = 2
        Me.btnParar.Text = "Parar Monitoramento"
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "String de entrada:"
        '
        'TextBoxStringDeEntrada
        '
        Me.TextBoxStringDeEntrada.Location = New System.Drawing.Point(12, 25)
        Me.TextBoxStringDeEntrada.Multiline = True
        Me.TextBoxStringDeEntrada.Name = "TextBoxStringDeEntrada"
        Me.TextBoxStringDeEntrada.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxStringDeEntrada.Size = New System.Drawing.Size(318, 35)
        Me.TextBoxStringDeEntrada.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Delimitador:"
        '
        'TextBoxDelimitador
        '
        Me.TextBoxDelimitador.Location = New System.Drawing.Point(12, 90)
        Me.TextBoxDelimitador.Name = "TextBoxDelimitador"
        Me.TextBoxDelimitador.Size = New System.Drawing.Size(62, 20)
        Me.TextBoxDelimitador.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Resultado:"
        '
        'btnSplit
        '
        Me.btnSplit.Location = New System.Drawing.Point(255, 87)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.Size = New System.Drawing.Size(75, 23)
        Me.btnSplit.TabIndex = 9
        Me.btnSplit.Text = "Aplicar split"
        Me.btnSplit.UseVisualStyleBackColor = True
        '
        'ListBoxResultado
        '
        Me.ListBoxResultado.FormattingEnabled = True
        Me.ListBoxResultado.Location = New System.Drawing.Point(12, 155)
        Me.ListBoxResultado.MultiColumn = True
        Me.ListBoxResultado.Name = "ListBoxResultado"
        Me.ListBoxResultado.Size = New System.Drawing.Size(318, 186)
        Me.ListBoxResultado.TabIndex = 10
        '
        'btnMoverParaBancoDeDados
        '
        Me.btnMoverParaBancoDeDados.Location = New System.Drawing.Point(168, 117)
        Me.btnMoverParaBancoDeDados.Name = "btnMoverParaBancoDeDados"
        Me.btnMoverParaBancoDeDados.Size = New System.Drawing.Size(162, 23)
        Me.btnMoverParaBancoDeDados.TabIndex = 11
        Me.btnMoverParaBancoDeDados.Text = "Mover para o Banco de Dados"
        Me.btnMoverParaBancoDeDados.UseVisualStyleBackColor = True
        '
        'Comunicação_arduino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 450)
        Me.Controls.Add(Me.btnMoverParaBancoDeDados)
        Me.Controls.Add(Me.ListBoxResultado)
        Me.Controls.Add(Me.btnSplit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxDelimitador)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxStringDeEntrada)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnParar)
        Me.Controls.Add(Me.btnMonitorar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Comunicação_arduino"
        Me.Text = "Comunicação_arduino"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMonitorar As Button
    Friend WithEvents btnParar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxStringDeEntrada As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxDelimitador As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSplit As Button
    Friend WithEvents ListBoxResultado As ListBox
    Friend WithEvents btnMoverParaBancoDeDados As Button
End Class
