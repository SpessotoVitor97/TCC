Imports System.Management
Public Class Comunicação_arduino

    Private WithEvents MonitoraDispositivo As ManagementEventWatcher

    Private Sub BtnMonitorar_Click(sender As Object, e As EventArgs) Handles btnMonitorar.Click
        Try
            Dim consulta As String = "SELECT * FROM __InstanceOperationEvent WITHIN 10 WHERE TargetInstance ISA ""Win32_DiskDrive"""
            MonitoraDispositivo = New ManagementEventWatcher(consulta)
            MonitoraDispositivo.Start()
            Label1.BackColor = Color.Green
            Label1.Text = "ATIVO"
            MonitoraDispositivo.WaitForNextEvent()
        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCrLf + ex.InnerException.ToString())
        End Try
    End Sub

    Private Sub Inserido(ByVal sender As Object, ByVal e As EventArrivedEventArgs) Handles MonitoraDispositivo.EventArrived
        Dim mbo, obj As ManagementBaseObject
        mbo = CType(e.NewEvent, ManagementBaseObject)
        obj = CType(mbo("TargetInstance"), ManagementBaseObject)
        Select Case mbo.ClassPath.ClassName
            Case "__InstanceCreationEvent"
                If obj("InterfaceType") = "USB" Then
                    MsgBox(obj("Caption") & " (Drive letter " & GetLetraDriverDoDisco(obj("Name")) & ") foi CONECTADO !")
                End If
            Case "__InstanceDeletionEvent"
                If obj("InterfaceType") = "USB" Then
                    MsgBox(obj("Caption") & " foi DESCONECTADO !")
                End If
        End Select
    End Sub

    Private Function GetLetraDriverDoDisco(ByVal Name As String) As String
        Dim oq_part, oq_disk As ObjectQuery
        Dim mos_part, mos_disk As ManagementObjectSearcher
        Dim obj_part, obj_disk As ManagementObject
        Dim ans As String = ""
        Name = Replace(Name, "\", "\\")
        oq_part = New ObjectQuery("ASSOCIATORS OF _ {Win32_DiskDrive.DeviceID=""" & Name & """} WHERE AssocClass = Win32_DiskDriveToDiskPartition")
        mos_part = New ManagementObjectSearcher(oq_part)
        For Each obj_part In mos_part.Get()
            oq_disk = New ObjectQuery("ASSOCIATORS OF {Win32_DiskPartition.DeviceID=""" & obj_part("DeviceID") & """} _
                WHERE AssocClass = Win32_LogicalDiskToPartition")
            mos_disk = New ManagementObjectSearcher(oq_disk)
            For Each obj_disk In mos_disk.Get()
                ans &= obj_disk("Name") & ","
            Next
        Next
        Return ans.Trim(","c)
    End Function

End Class


'TODO: Adicionar o botão "Parar o Monitoramento";
'Corrigir a detecção de quando o UBS é inserido;