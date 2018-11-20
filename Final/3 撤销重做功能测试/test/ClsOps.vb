Public Class ClsOps
    Private ops As List(Of ClsOp)
    Private cnt As Integer

    Public Sub New()
        ops = New List(Of ClsOp)
        cnt = 0
    End Sub

    Public Sub Add(op As ClsOp)
        ops.Add(op)
        cnt = ops.Count
    End Sub

    Public Sub Undo()
        If cnt = 0 Then Return
        ops(cnt - 1).Undo()
        cnt -= 1
    End Sub

    Public Sub Redo()
        If cnt = ops.Count Then Return
        ops(cnt).DoWork()
        cnt += 1
    End Sub
End Class
