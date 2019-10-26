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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxStringDeEntrada = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDelimitador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSplit = New System.Windows.Forms.Button()
        Me.ListBoxResultado = New System.Windows.Forms.ListBox()
        Me.btnMoverParaBancoDeDados = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.COMport_LBL = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clear_BTN = New System.Windows.Forms.Button()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 347)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(318, 163)
        Me.DataGridView1.TabIndex = 12
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(577, 102)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(88, 20)
        Me.Timer_LBL.TabIndex = 31
        Me.Timer_LBL.Text = "Timer: OFF"
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(581, 46)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(121, 28)
        Me.comPort_ComboBox.TabIndex = 26
        '
        'COMport_LBL
        '
        Me.COMport_LBL.AutoSize = True
        Me.COMport_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_LBL.Location = New System.Drawing.Point(600, 23)
        Me.COMport_LBL.Name = "COMport_LBL"
        Me.COMport_LBL.Size = New System.Drawing.Size(78, 20)
        Me.COMport_LBL.TabIndex = 25
        Me.COMport_LBL.Text = "COM Port"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(410, 134)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(608, 207)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(874, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "RECEIVING"
        '
        'clear_BTN
        '
        Me.clear_BTN.Location = New System.Drawing.Point(887, 361)
        Me.clear_BTN.Name = "clear_BTN"
        Me.clear_BTN.Size = New System.Drawing.Size(75, 23)
        Me.clear_BTN.TabIndex = 28
        Me.clear_BTN.Text = "CLEAR"
        Me.clear_BTN.UseVisualStyleBackColor = True
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(708, 46)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(120, 32)
        Me.connect_BTN.TabIndex = 27
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Comunicação_arduino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 522)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.COMport_LBL)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clear_BTN)
        Me.Controls.Add(Me.connect_BTN)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnMoverParaBancoDeDados)
        Me.Controls.Add(Me.ListBoxResultado)
        Me.Controls.Add(Me.btnSplit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxDelimitador)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxStringDeEntrada)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Comunicação_arduino"
        Me.Text = "Comunicação_arduino"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxStringDeEntrada As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxDelimitador As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSplit As Button
    Friend WithEvents ListBoxResultado As ListBox
    Friend WithEvents btnMoverParaBancoDeDados As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents COMport_LBL As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clear_BTN As Button
    Friend WithEvents connect_BTN As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
End Class
