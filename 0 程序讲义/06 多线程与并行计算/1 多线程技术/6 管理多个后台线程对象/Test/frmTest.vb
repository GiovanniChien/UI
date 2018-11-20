Public Class frmTest
    '当前正在运行的工人线程表：为了了解各个工人的状态，需要1个表对象
    Private Workers As List(Of clsWorkerA)

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Workers = New List(Of clsWorkerA)
    End Sub
    Private Sub startBtn_Click(sender As System.Object, e As System.EventArgs) Handles btnStart1.Click, btnStart2.Click
        Dim para As WorkerPara
        If sender Is btnStart1 Then para.id = 1 : para.n1 = 100 : para.n2 = 500000 : lstProgress1.Items.Clear()
        If sender Is btnStart2 Then para.id = 2 : para.n1 = 200 : para.n2 = 200000 : lstProgress2.Items.Clear()
        Dim Worker As clsWorkerA = New clsWorkerA(para, Me)
        AddHandler Worker.Complete, AddressOf WorkerComplete
        Workers.Add(Worker)
        Worker.Run()
    End Sub

    Private Sub WorkerComplete(sender As clsWorkerA, Cancel As Boolean, result As WorkerResult)
        If Cancel = True Then Exit Sub
        If result.id = 1 Then lstProgress1.Items.Add(result.sum)
        If result.id = 2 Then lstProgress2.Items.Add(result.sum)
        For i = 0 To Workers.Count - 1
            If sender Is Workers(i) Then
                Workers.RemoveAt(i)
            End If
        Next
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

    Private Sub frmTest_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '是否有worker还在运行
        If Workers.Count > 0 Then e.Cancel = True
    End Sub

End Class
