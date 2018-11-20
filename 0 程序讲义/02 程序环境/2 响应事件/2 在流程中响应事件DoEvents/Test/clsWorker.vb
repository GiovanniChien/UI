Public Class clsWorker
    Public Event Start(si As Integer, ei As Integer)
    Public Event Progress(i As Integer)
    Public Event Complete()

    Public Sub Run(n As Integer)
        RaiseEvent Start(0, n - 1)
        For i = 0 To n - 1
            ' 有此句：界面能响应事件
            ' 无此句：界面不响应事件，直到Run计算完成
            Application.DoEvents()  '计算之中，给事件处理一个机会
            For j = 1 To 10000
                For k = 1 To 1000
                    Dim a As Integer = i + j
                Next
            Next
            RaiseEvent Progress(i)
        Next
        RaiseEvent Complete()
    End Sub
End Class
