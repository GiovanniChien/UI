Imports System.IO.Ports

Public Class frmTest
    Delegate Sub AddMessage(ByVal s As Result)
    Dim f As AddMessage

    Dim WithEvents sp As SerialPort
    Dim CounterT1, CounterT2, CounterQ As clsCounter

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sp = New SerialPort()
        f = New AddMessage(AddressOf DisplayMessage)
        CounterT1 = New clsCounter(SensorFlag.T1, ChartT1, gbT1)
        CounterT2 = New clsCounter(SensorFlag.T2, ChartT2, gbT2)
        CounterQ = New clsCounter(SensorFlag.Q, ChartQ, gbQ)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click, btnClose.Click
        If sender Is btnOpen Then
            If Not sp.IsOpen() Then
                sp.PortName = txtCom.Text : sp.BaudRate = txtBaud.Text : sp.Open()
                lstReceive.Items.Clear()
                lblState.Text = "已经连接"
            End If
        End If
        If sender Is btnClose Then
            If sp.IsOpen() Then
                sp.Close()
                lblState.Text = "已经断开"
            End If
        End If
    End Sub

    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendT1.Click, btnSendT2.Click, btnSendQ.Click
        If Not sp.IsOpen Then Return
        Dim Message As New clsMessage
        Dim f() As Byte
        If sender Is btnSendT1 Then f = Message.GetCmd(SensorFlag.T1, txtT1.Text)
        If sender Is btnSendT2 Then f = Message.GetCmd(SensorFlag.T2, txtT2.Text)
        If sender Is btnSendQ Then f = Message.GetCmd(SensorFlag.Q, txtQ.Text)
        sp.Write(f, 0, 8)
    End Sub

    Private Sub sp_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles sp.DataReceived
        Dim buff(7) As Byte
        Dim k As Integer = sp.Read(buff, 0, 8)
        ' 为什么需要延时？
        Threading.Thread.Sleep(1000)
        If k = 8 Then
            Dim Message As New clsMessage
            Dim r As Result = Message.Match(buff)
            If r.Valid <> SensorFlag.Invalid Then
                Invoke(f, r)
            End If
        End If
    End Sub

    ' 对有效数据，进行分类显示
    Sub DisplayMessage(ByVal r As Result)
        lstReceive.Items.Add(r.T1 & "," & r.T2 & "," & r.Q)
        lstReceive.SelectedIndex = lstReceive.Items.Count - 1
        If r.Valid = SensorFlag.T1 Then CounterT1.Append(r.T1)
        If r.Valid = SensorFlag.T2 Then CounterT2.Append(r.T2)
        If r.Valid = SensorFlag.Q Then CounterQ.Append(r.Q)
    End Sub

End Class


