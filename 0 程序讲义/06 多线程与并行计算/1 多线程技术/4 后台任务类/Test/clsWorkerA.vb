Imports System.ComponentModel

Public Structure WorkerPara
    Dim id As Integer
    Dim n1 As Integer
    Dim n2 As Integer
End Structure
Public Structure WorkerResult
    Dim id As Integer
    Dim sum As Single
End Structure

Public Class clsWorkerA
    Private para As WorkerPara
    Private Worker As BackgroundWorker

    Public Event Complete(Cancel As Boolean, result As WorkerResult)

    Public Sub New(para As WorkerPara)
        Me.para = para
        Me.Worker = New BackgroundWorker
        AddHandler Worker.DoWork, AddressOf DoWork
        AddHandler Worker.RunWorkerCompleted, AddressOf Completed
    End Sub
    Public Sub Run()
        Me.Worker.RunWorkerAsync(para)
    End Sub
    Public Sub DoCancel()
        Worker.CancelAsync()
    End Sub

    Private Sub DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Dim sum As Single, k As Integer
        For k = 1 To 2000
            If Worker.CancellationPending Then
                e.Cancel = True : Return
            End If
            sum = 0
            For i = para.n1 To para.n2
                sum += i
            Next
        Next
        Dim result As WorkerResult
        result.id = para.id : result.sum = sum
        e.Result = result
    End Sub

    Private Sub Completed(sender As Object, e As RunWorkerCompletedEventArgs)
        Dim result As WorkerResult = e.Result
        RaiseEvent Complete(e.Cancelled, result)
    End Sub
End Class
