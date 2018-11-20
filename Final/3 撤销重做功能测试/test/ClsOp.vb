Public Class ClsOp
    Private label As Label
    Private oldNum As String
    Private newNum As String

    Public Sub New(label As Label, oldNum As String, newNum As String)
        Me.label = label
        Me.oldNum = oldNum
        Me.newNum = newNum
    End Sub

    Public Sub DoWork()
        label.Text = newNum
    End Sub

    Public Sub Undo()
        label.Text = oldNum
    End Sub

    Public Overrides Function ToString() As String
        Dim str As String = label.Name & " oldNum: " & oldNum & " newNum:" & newNum
        Return str
    End Function

End Class
