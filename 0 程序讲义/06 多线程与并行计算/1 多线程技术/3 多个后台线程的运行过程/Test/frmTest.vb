Imports System.ComponentModel

Structure WorkerPara
    Dim id As Integer
    Dim n1 As Integer
    Dim n2 As Integer
End Structure
Structure WorkerResult
    Dim id As Integer
    Dim sum As Single
End Structure

Public Class frmTest
    Private Worker As BackgroundWorker

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart1.Click, btnStart2.Click
        Worker = New BackgroundWorker
        AddHandler Worker.RunWorkerCompleted, AddressOf WorkerCompleted
        AddHandler Worker.DoWork, AddressOf WorkerDoWork
        Dim para As WorkerPara
        If sender Is btnStart1 Then para.id = 1 : para.n1 = 100 : para.n2 = 500000
        If sender Is btnStart2 Then para.id = 2 : para.n1 = 200 : para.n2 = 200000
        Me.Worker.RunWorkerAsync(para)
    End Sub

    Private Sub WorkerDoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Dim para As WorkerPara = e.Argument  '提取所需的所有参数
        Dim sum As Single
        For k = 1 To 2000
            If Worker.CancellationPending Then
                e.Cancel = True
                Return
            End If
            sum = 0
            For i = para.n1 To para.n2
                sum += i
            Next
        Next
        Dim result As WorkerResult
        result.id = para.id : result.sum = sum
        e.Result = result  '将计算的结果赋给Result属性(Object类型)。
    End Sub

    Private Sub WorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        Dim result As WorkerResult = e.Result
        If result.id = 1 Then txtResult1.Text = result.sum
        If result.id = 2 Then txtResult2.Text = result.sum
    End Sub


End Class
