Public Class ClsOp
    Private label As Label
    Private oldNum As String
    Private newNum As String
    Private numInMatrix As Integer

    Public Sub New(label As Label, oldNum As String, newNum As String, numInMatrix As Integer)
        Me.label = label
        Me.oldNum = oldNum
        Me.newNum = newNum
        Me.numInMatrix = numInMatrix
    End Sub

    Public Sub DoWork()
        If newNum = "" Then
            label.Text = ""
            numInMatrix = 0
        Else
            label.Text = newNum
            numInMatrix = newNum
        End If
    End Sub

    Public Sub Undo()
        If oldNum = "" Then
            label.Text = ""
            numInMatrix = 0
        Else
            label.Text = oldNum
            numInMatrix = oldNum
        End If
    End Sub

    Public Overrides Function ToString() As String
        Dim str As String = label.Name & " oldNum: " & oldNum & " newNum:" & newNum
        Return str
    End Function
End Class

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
        frmTest.SetMenuUndoStatus(True)
        frmTest.SetMenuRedoStatus(False)
    End Sub

    Public Sub Undo()
        'If cnt = 0 Then Return
        ops(cnt - 1).Undo()
        cnt -= 1
        frmTest.SetMenuRedoStatus(True)
        If cnt = 0 Then frmTest.SetMenuUndoStatus(False)
    End Sub

    Public Sub Redo()
        'If cnt = ops.Count Then Return
        ops(cnt).DoWork()
        cnt += 1
        frmTest.SetMenuUndoStatus(True)
        If cnt = ops.Count Then frmTest.SetMenuRedoStatus(False)
    End Sub
End Class
