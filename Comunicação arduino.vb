Imports System.Diagnostics
Imports System
Imports System.IO.Ports
Public Class Comunicação_arduino

    Private Access As New Controle

    Dim DataEHoraAtual As DateTime
    Dim Data As DateTime
    Dim Horário As String
    Dim comPORT As String
    'Dim receivedData As String = ""
    Dim receivedData As String

    Private Sub Comunicação_arduino_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AtualizaRegistro()
    End Sub

    Private Sub Comunicação_arduino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        'comPORT = ""
        For Each SerialPort As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(SerialPort)
        Next
    End Sub


    Private Sub BtnSplit_Click(sender As Object, e As EventArgs) Handles btnSplit.Click
        Dim strDoArduino As String = TextBoxStringDeEntrada.Text
        Dim separador() As Char

        If TextBoxDelimitador.Text = String.Empty Then
            separador = New Char() {" "c}
        Else
            separador = New Char() + TextBoxDelimitador.Text.ToCharArray
        End If

        'separador = New Char() + "|".ToCharArray

        Dim eventosArray = {}
        Dim eventos As String() = strDoArduino.Split(separador)
        ListBoxResultado.Items.Clear()
        Dim evento As String
        For Each evento In eventos
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
                SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                Timer1.Enabled = True
                Timer_LBL.Text = "Timer: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            Timer_LBL.Text = "Timer: OFF"
        End If


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        TextBoxStringDeEntrada.Text &= receivedData
        SerialPort1.Close()
    End Sub


    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadLine()
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
        RichTextBox1.Text = ""
    End Sub
End Class