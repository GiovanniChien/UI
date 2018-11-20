Public Class clsOps
    Private txtContent As TextBox
    Private Ops As List(Of clsOp), ith As Integer

    Public Sub New(txtContent As TextBox)
        Me.txtContent = txtContent
        Me.Ops = New List(Of clsOp) : Me.ith = 0
    End Sub
    Public Sub Add(op As clsOp)
        Ops.Add(op)
        ith = Ops.Count
    End Sub

    Public Sub Undo()
        If ith = 0 Then Return
        Ops(ith - 1).UnDo(txtContent)
        ith -= 1
    End Sub

    Public Sub Redo()
        If ith = Ops.Count Then Return
        Ops(ith).DoWork(txtContent)
        ith += 1
    End Sub
End Class
