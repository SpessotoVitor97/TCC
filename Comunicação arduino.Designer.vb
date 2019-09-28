<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comunicação_arduino
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMonitorar = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(364, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INATIVO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMonitorar
        '
        Me.btnMonitorar.Location = New System.Drawing.Point(301, 184)
        Me.btnMonitorar.Name = "btnMonitorar"
        Me.btnMonitorar.Size = New System.Drawing.Size(85, 35)
        Me.btnMonitorar.TabIndex = 1
        Me.btnMonitorar.Text = "Monitorar Dispositivos"
        Me.btnMonitorar.UseVisualStyleBackColor = True
        '
        'btnParar
        '
        Me.btnParar.Location = New System.Drawing.Point(392, 184)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(85, 35)
        Me.btnParar.TabIndex = 2
        Me.btnParar.Text = "Parar Monitoramento"
        Me.btnParar.UseVisualStyleBackColor = True
        '
        'Comunicação_arduino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
