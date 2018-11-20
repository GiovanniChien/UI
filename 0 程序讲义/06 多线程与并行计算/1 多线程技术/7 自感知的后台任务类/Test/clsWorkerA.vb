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
    Delegate Sub AppendMessage(id As Integer, msg As String) '函数类型

    Private para As WorkerPara
    Private frmOut As frmTest       '拥有控件的窗体，有权改写控件
    Private Worker As BackgroundWorker
    Private ReportProgress As AppendMessage   '函数对象，向界面报告计算的进度

    Public Event Complete(Cancel As Boolean, result As WorkerResult)

    Public Sub New(para As WorkerPara, frmOut As frmTest)
        Me.para = para : Me.frmOut = frmOut
        Me.Worker = New BackgroundWorker
        AddHandler Worker.DoWork, AddressOf DoWork
        AddHandler Worker.RunWorkerCompleted, AddressOf Completed
        Me.ReportProgress = New AppendMessage(AddressOf frmOut.AppendMessage)
    End Sub
    Public Sub Run()
        Me.Worker.RunWorkerAsync(para)
    End Sub
    Public Sub DoCancel()
        Worker.CancelAsync()
    End Sub

    Private Sub DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Dim sum As Single, k As Integer
        sum = 0
        For k = 1 To 2000
            If Worker.CancellationPending Then
                e.Cancel = True : Return
            End If

            For i = para.n1 To para.n2
                sum += i
            Next
            '在拥有控件的窗口线程上，用指定的参数列表执行指定委托函数。
            Try
                frmOut.Invoke(ReportProgress, para.id, sum.ToString & vbTab & k)
            Catch ex As Exception
                Me.Finalize()  '若与frmOut的交流出现故障，则自杀
                Return
            End Try
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
