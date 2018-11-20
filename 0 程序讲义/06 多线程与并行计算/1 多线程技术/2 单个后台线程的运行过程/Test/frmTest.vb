
Public Class frmTest
    Structure WorkerPara
        Dim n1 As Integer
        Dim n2 As Integer
    End Structure

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        Dim para As WorkerPara
        para.n1 = 100 : para.n2 = 1000000
        ' 计算n1+...+n2的和，重复计算1000次
        Me.bkWork.RunWorkerAsync(para)
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.bkWork.CancelAsync()
    End Sub

    Private Sub bkWork_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkWork.DoWork
        Dim para As WorkerPara = e.Argument  '提取所需的所有参数
        Dim sum As Single
        For k = 1 To 1000
            If bkWork.CancellationPending Then
                e.Cancel = True
                Return
            End If
            sum = 0
            For i = para.n1 To para.n2
                sum += i
            Next
        Next
        e.Result = sum  '将计算的结果赋给Result属性(Object类型)。
    End Sub

    Private Sub bkWork_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkWork.RunWorkerCompleted
        If e.Cancelled Then
            txtResult.Text = "Operation was canceled"
        Else
            txtResult.Text = e.Result
        End If
    End Sub

End Class
