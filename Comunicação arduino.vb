Imports System.Diagnostics
Public Class Comunicação_arduino

    Private Access As New Controle

    Dim index = 0

    Private Sub Comunicação_arduino_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AtualizaRegistro()
    End Sub

    Private Sub BtnSplit_Click(sender As Object, e As EventArgs) Handles btnSplit.Click
        Dim strDoArduino As String = TextBoxStringDeEntrada.Text
        Dim separador() As Char

        If TextBoxDelimitador.Text = String.Empty Then
            separador = New Char() {" "c}
        Else
            separador = New Char() + TextBoxDelimitador.Text.ToCharArray
        End If

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

        Dim valuesArray() As String = {"@Evento", "@Data", "@Horário", "@Unidade", "@Local", "@Equipamento"}

        For valuesArrayIndex As Integer = 0 To valuesArray.Count - 1
            Dim valuesArrayStr As String = CStr(valuesArray(valuesArrayIndex))
            Access.AddParams(valuesArrayStr, ListBoxResultado.Items(valuesArrayIndex))
        Next

        Access.ExecuteQuery("INSERT INTO Eventos (Evento, [Data], [Horário], [Unidade], [Local], [Equipamento]) VALUES (@Evento, @Data, @Horário, @Unidade, @Local, @Equipamento)")
    End Sub

End Class