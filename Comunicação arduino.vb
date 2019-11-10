Imports System.Diagnostics
Imports System
Imports System.IO.Ports
Public Class Comunicação_arduino

    Private Access As New Controle

    Dim DataEHoraAtual As DateTime
    Dim Data As DateTime
    Dim Horário As String
    Dim comPORT As String
    Dim receivedData As String

    Private Sub Comunicação_arduino_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AtualizaRegistro()
    End Sub

    Private Sub Comunicação_arduino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mySerialPortList = {}

        ''TODO: Remover o comboBox e criar uma variável para armazenar a comboBox
        TimeOutTimer.Enabled = False
        For Each SerialPort As String In My.Computer.Ports.SerialPortNames
            mySerialPortList.Append(SerialPort)
            comPort_ComboBox.Items.Add(SerialPort)
        Next
        TimeOutTimer.Interval = 10000
    End Sub


    Private Sub BtnSplit_Click(sender As Object, e As EventArgs) Handles btnSplit.Click
        Dim strDoArduino As String = TextBoxStringDeEntrada.Text
        Dim separador() As Char
        Dim eventosArray = {}
        Dim eventos As String()

        separador = New Char() + ",".ToCharArray
        eventos = strDoArduino.Split(separador)
        ListBoxResultado.Items.Clear()
        For Each evento As String In eventos
            ListBoxResultado.Items.Add(evento)
            eventosArray.Append(evento)
        Next

    End Sub

    Private Sub BtnMoverParaBancoDeDados_Click(sender As Object, e As EventArgs) Handles btnMoverParaBancoDeDados.Click
        MoveToDataBase()
        AtualizaRegistro()
    End Sub

    Public Sub AtualizaRegistro()
        Access.ExecuteQuery("SELECT * FROM Eventos")
        DataGridView1.DataSource = Access.DBDT
    End Sub

    Sub MoveToDataBase()

        Dim valuesArray() As String = {"@Evento", "@Unidade", "@Local", "@Equipamento"}

        For valuesArrayIndex As Integer = 0 To valuesArray.Count - 1
            Dim valuesArrayStr As String = CStr(valuesArray(valuesArrayIndex))
            Access.AddParams(valuesArrayStr, ListBoxResultado.Items(valuesArrayIndex))
        Next

        DataEHoraAtual = Now
        Data = DataEHoraAtual.Date
        Horário = CStr(DataEHoraAtual.Hour & ":" & DataEHoraAtual.Minute & ":" & DataEHoraAtual.Second)

        Access.AddParams("@Data", Data)
        Access.AddParams("@Horário", Horário)

        Access.ExecuteQuery("INSERT INTO Eventos (Evento, [Unidade], [Local], [Equipamento], [Data], [Horário]) VALUES (@Evento, @Unidade, @Local, @Equipamento, @Data, @Horário)")
    End Sub

    Private Sub ComPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub


    Private Sub Connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.UTF8
                SerialPort1.ReadTimeout = 20000
                SerialPort1.WriteTimeout = 20000

                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                TimeOutTimer.Enabled = True
                Timer_LBL.Text = "Timer: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            TimeOutTimer.Enabled = False
            Timer_LBL.Text = "Timer: OFF"
        End If


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimeOutTimer.Tick
        receivedData = ReceiveSerialData()
        TextBoxStringDeEntrada.Text &= receivedData
    End Sub


    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Private Sub Clear_BTN_Click(sender As Object, e As EventArgs) Handles clear_BTN.Click
        TextBoxStringDeEntrada.Text = ""
    End Sub

End Class

'' TODO: Criar um WHILE LOOP no arduino para escapar do timeout; O mesmo vale para o VB.