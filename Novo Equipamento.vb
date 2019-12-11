Public Class Novo_Equipamento

    Public Access As New Controle
    Dim timeOut As Integer = 0
    Dim timeOutValue As Integer = 0

    Private Sub EquipamentoTextBox_TextChanged(sender As Object, e As EventArgs) Handles equipamentoTextBox.TextChanged
        If equipamentoTextBox.TextLength > 0 Then
            BtnSalvar.Enabled = True
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        NovoRegistro()
        'GravarNoArduino()
        Me.Hide()
        Resumo.Show()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub NovoRegistro()

        Access.AddParams("@Data_de_aquisição", dateTimePicker.Value.Date)
        Access.AddParams("@Unidade", unidadeTextBox.Text)
        Access.AddParams("@Setor", setorTextBox.Text)
        Access.AddParams("@DASA", dasaTextBox.Text)
        Access.AddParams("@Equipamento", equipamentoTextBox.Text)
        Access.AddParams("@Modelo", modeloTextBox.Text)
        Access.AddParams("@Fabricante", fabricanteTextBox.Text)
        Access.AddParams("@Número_de_Série", Número_de_SérieTextBox.Text)

        Access.ExecuteQuery("INSERT INTO Equipamentos (Data_de_aquisição, [Unidade], [Setor], [DASA], [Equipamento], [Modelo], [Fabricante], [Número_de_Série]) VALUES (@Data_de_aquisição, @Unidade, @Setor, @DASA, @Equipamentos, @Modelo, @Fabricante, @Número_de_Série)")

    End Sub

    'Public Sub GravarNoArduino()
    '    Dim strToArduino As String

    '    TimeOutTimer.Interval = 20000
    '    strToArduino = CStr(unidadeTextBox.Text & "," & setorTextBox.Text & "," & dasaTextBox.Text & "," & equipamentoTextBox.Text & "," & modeloTextBox.Text & "," & fabricanteTextBox.Text & "," & Número_de_SérieTextBox.Text & "#")

    '    Try
    '        Comunicação_arduino.SerialPort1.Open()
    '        TimeOutTimer.Start()
    '        WaitFor(3)
    '        Comunicação_arduino.SerialPort1.Write("G")
    '        WaitFor(3)
    '        Comunicação_arduino.SerialPort1.Write(strToArduino)
    '        Comunicação_arduino.SerialPort1.Close()
    '        TimeOutTimer.Stop()
    '    Catch ex As Exception
    '        MessageBox.Show("Algo deu errado, por favor tente novamente mais tarde.", "Software Supervisório", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try

    'End Sub

    Private Sub TimeOutTimer_Tick(sender As Object, e As EventArgs) Handles TimeOutTimer.Tick
        Do Until timeOut
            timeOutValue += 1
            If timeOutValue = TimeOutTimer.Interval Then
                timeOut = True
            End If
        Loop
    End Sub

    Private Sub WaitFor(ByVal interval As Integer)
        Dim stopWatch As New Stopwatch
        stopWatch.Start()
        Do While stopWatch.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        stopWatch.Stop()
    End Sub

End Class