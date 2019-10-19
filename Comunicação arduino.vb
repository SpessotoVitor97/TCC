Public Class Comunicação_arduino

    Private Access As New Controle

    Dim index = 0
    'Dim evento As String = ""
    'Dim data As Integer = 0
    'Dim horário As Integer = 0
    'Dim unidade As String = ""
    'Dim local As String = ""
    'Dim equipamento As String = ""

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
        moveToDataBase()
    End Sub

    Sub moveToDataBase()
        Dim quantidadeDeEventos As Integer = ListBoxResultado.Items.Count
        Do While index <= quantidadeDeEventos
            If index = 0 Then
                'Access.AddParams("@Evento", evento)
                Access.AddParams("@Evento", ListBoxResultado.Items.IndexOf(index))
                index += 1
            ElseIf index = 1 Then
                'Access.AddParams("@Data", data)
                Access.AddParams("@Data", ListBoxResultado.Items.IndexOf(index))
                index += 1
            ElseIf index = 2 Then
                'Access.AddParams("@Horário", horário)
                Access.AddParams("@Horário", ListBoxResultado.Items.IndexOf(index))
                index += 1
            ElseIf index = 3 Then
                'Access.AddParams("@Unidade", unidade)
                Access.AddParams("@Unidade", ListBoxResultado.Items.IndexOf(index))
                index += 1
            ElseIf index = 4 Then
                'Access.AddParams("@Local", local)
                Access.AddParams("@Local", ListBoxResultado.Items.IndexOf(index))
                index += 1
            ElseIf index = 5 Then
                'Access.AddParams("@Equipamento", equipamento)
                Access.AddParams("@Equipamento", ListBoxResultado.Items.IndexOf(index))
                index += 1
            End If
            'Access.AddParams("@Evento", eventosArray)
            'Access.AddParams("@Data/Horário", eventosArray)
        Loop

        ''Consertar esse parâmetro
        'Access.AddParams("@Evento", ListBoxResultado.Items.IndexOf(index))
        'Access.AddParams("@Data", ListBoxResultado.Items.IndexOf(index))
        'Access.AddParams("@Horário", ListBoxResultado.Items.IndexOf(index))
        'Access.AddParams("@Unidade", ListBoxResultado.Items.IndexOf(index))
        'Access.AddParams("@Local", ListBoxResultado.Items.IndexOf(index))
        'Access.AddParams("@Equipamento", ListBoxResultado.Items.IndexOf(index))

        Access.ExecuteQuery("INSERT INTO Eventos (Evento, [Data], [Horário], [Unidade], [Local], [Equipamento]) VALUES (@Evento, @Data, @Horário, @Unidade, @Local, @Equipamento)")
    End Sub
End Class


'TODO: Adicionar o botão "Parar o Monitoramento";
'Corrigir a detecção de quando o USB é inserido;
'Retirar o DO WHILE e chumbar o index direto;