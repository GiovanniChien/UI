Public MustInherit Class clsElem
    Protected CommonPen, SelectedPen As Pen

    Public MustOverride Sub Draw(g As Graphics, Optional isSelectElem As Boolean = False)
    Public MustOverride Function SelectByPoint(p As PointF) As Boolean

    Public Sub New()
        CommonPen = New Pen(Color.Blue, 1)
        SelectedPen = New Pen(Color.Red, 1)
    End Sub
End Class

Public Class clsElems
    Public elems As List(Of clsElem)
    Private SelectIndex As Integer   ' 当前选中对象的序号，初始为-1
    Event Redraw()
    ' 选中对象序号从原值OldIndex，被改变为新值NewIndex
    Event SelectIndexChanging(OldIndex As Integer, NewIndex As Integer)
    Event SelectIndexChanged(OldIndex As Integer, NewIndex As Integer)

    Public Sub New()
        elems = New List(Of clsElem)
        SelectIndex = -1
    End Sub
    Public Sub Append(e As clsElem)
        elems.Add(e)
        RaiseEvent Redraw()
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        For i = 0 To elems.Count - 1
            If i = SelectIndex Then
                elems(i).Draw(g, True)
            Else
                elems(i).Draw(g)
            End If

        Next
    End Sub

    Public Function Count() As Integer
        Return elems.Count
    End Function
    Public Function GetElem(index As Integer) As clsElem
        Return elems(index)
    End Function

    ' “选项改变”事件：在其处理过程，将改变列表框的当前选项，并绘制局部变化的图形对象
    ' 在点选过程中，激发“选项改变”事件，但不改变当前选项。
    Public Sub SelectByPoint(p As PointF)
        For i = 0 To elems.Count - 1
            If elems(i).SelectByPoint(p) = True Then
                RaiseEvent SelectIndexChanging(SelectIndex, i)
                Return
            End If
        Next
    End Sub
    ' 在列表框的当前选项被改变时
    Public Sub SetSelectedIndex(index As Integer)
        RaiseEvent SelectIndexChanged(SelectIndex, index)
        SelectIndex = index
    End Sub

End Class
