Public Enum ObjectState
    Common    ' 常规状态
    Selected  ' 选中状态
    Drag      ' 拖动状态
    None      ' 擦除状态
End Enum

Public MustInherit Class clsElem
    Protected Shared CommonPen, SelectedPen, DragPen, NonePen As Pen

    Public MustOverride Sub Draw(ByVal g As Graphics, ByVal M As clsMatrix3, ByVal State As ObjectState)
    Public MustOverride Function SelectByPoint(ByVal p As PointF) As Boolean
    Public MustOverride Function Clone() As clsElem
    Public MustOverride Sub Transform(ByVal m As clsMatrix3)

    Public Sub New()
        CommonPen = New Pen(Color.Blue, 1)
        SelectedPen = New Pen(Color.Red, 1)
        DragPen = New Pen(Color.Green, 1)
        NonePen = New Pen(Color.White, 1)
    End Sub
    Protected Function GetPen(ByVal State As ObjectState) As Pen
        If State = ObjectState.Common Then Return CommonPen
        If State = ObjectState.Selected Then Return SelectedPen
        If State = ObjectState.Drag Then Return DragPen
        If State = ObjectState.None Then Return NonePen
        Return Nothing
    End Function

End Class

