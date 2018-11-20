Public Class clsWorker
    Private ith As Integer
    Public Sub New()
        ith = 0
    End Sub

    Public Function Run(n As Integer) As Integer
        ith += 1
        For i = 0 To n - 1
            ' 有此句：界面能响应事件
            ' 无此句：界面不响应事件，直到Run计算完成
            Application.DoEvents()  '计算之中，给事件处理一个机会
            For j = 1 To 10000
                For k = 1 To 1000
                    Dim a As Integer = i + j
                Next
            Next
        Next
        Return n * 10 + ith
    End Function

End Class
