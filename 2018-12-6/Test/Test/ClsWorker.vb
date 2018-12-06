Imports System.ComponentModel

Public Structure WorkerPara
    Dim id As Integer
    Dim si As Integer
    Dim ei As Integer
End Structure

Public Structure WorkerResult
    Dim id As Integer
    Dim sum As Single
End Structure

Public Class ClsWorker
    Delegate Sub AppendMessage(ByVal id As Integer, ByVal msg As String)

    Private para As WorkerPara
    Private worker As BackgroundWorker
    Private frmOut As frmTest
    Private ReportProgress As AppendMessage
    Event Complete(ByVal isCannelled As Boolean, ByVal result As WorkerResult)

    Public Sub New(ByVal para As WorkerPara, ByVal frmOut As frmTest)
        Me.para = para : Me.frmOut = frmOut
        Me.worker = New BackgroundWorker
        AddHandler worker.DoWork, AddressOf DoWork
        AddHandler worker.RunWorkerCompleted, AddressOf Completed
        Me.ReportProgress = New AppendMessage(AddressOf frmOut.AppendMessage)
    End Sub

    Private Sub DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim sum As Single = 0
        For k = 1 To 2000
            If worker.CancellationPending Then
                e.Cancel = True
                Return
            End If
            For i = para.si To para.ei
                sum += i
            Next
            frmOut.Invoke(ReportProgress, para.id, sum.ToString & vbTab & k)
        Next
        Dim result As WorkerResult
        result.id = para.id : result.sum = sum
        e.Result = result
    End Sub

    Private Sub Completed(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Dim result As WorkerResult = e.Result
        RaiseEvent Complete(e.Cancelled, result)
    End Sub

    Sub Run()
        Me.worker.RunWorkerAsync()
    End Sub

    Sub doCancel()
        Me.worker.CancelAsync()
    End Sub
End Class
