Public Class frmTest
    Private worker As ClsWorker

    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart1.Click, btnStart2.Click
        Dim para As WorkerPara
        If sender Is btnStart1 Then para.id = 1 : para.si = 100 : para.ei = 500000 : lstProgress1.Items.Clear()
        If sender Is btnStart2 Then para.id = 2 : para.si = 200 : para.ei = 200000 : lstProgress2.Items.Clear()
        Me.worker = New ClsWorker(para, Me)
        AddHandler Me.worker.Complete, AddressOf WorkerComplete
        Me.worker.Run()
    End Sub

    Private Sub WorkerComplete(ByVal isCannelled As Boolean, ByVal result As WorkerResult)
        If isCannelled = True Then
            Exit Sub
        End If
        If result.id = 1 Then lstProgress1.Items.Add(result.sum)
        If result.id = 2 Then lstProgress2.Items.Add(result.sum)
    End Sub

    Public Sub AppendMessage(ByVal id As Integer, ByVal msg As String)
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
