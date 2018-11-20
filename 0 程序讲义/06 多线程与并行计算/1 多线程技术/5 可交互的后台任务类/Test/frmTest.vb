Public Class frmTest
    Private Worker As clsWorkerA

    Private Sub startBtn_Click(sender As System.Object, e As System.EventArgs) Handles btnStart1.Click, btnStart2.Click
        Dim para As WorkerPara
        If sender Is btnStart1 Then para.id = 1 : para.n1 = 100 : para.n2 = 500000 : lstProgress1.Items.Clear()
        If sender Is btnStart2 Then para.id = 2 : para.n1 = 200 : para.n2 = 200000 : lstProgress2.Items.Clear()
        Me.Worker = New clsWorkerA(para, Me)
        AddHandler Me.Worker.Complete, AddressOf WorkerComplete
        Me.Worker.Run()
    End Sub

    Private Sub WorkerComplete(Cancel As Boolean, result As WorkerResult)
        If Cancel = True Then Exit Sub
        If result.id = 1 Then lstProgress1.Items.Add(result.sum)
        If result.id = 2 Then lstProgress2.Items.Add(result.sum)
    End Sub

    Public Sub AppendMessage(id As Integer, msg As String)
        If id = 1 Then
            lstProgress1.Items.Add(msg)
            lstProgress1.SelectedIndex = lstProgress1.Items.Count - 1
        End If
        If id = 2 Then
            lstProgress2.Items.Add(msg)
            lstProgress2.SelectedIndex = lstProgress2.Items.Count - 1
        End If
    End Sub

End Class
