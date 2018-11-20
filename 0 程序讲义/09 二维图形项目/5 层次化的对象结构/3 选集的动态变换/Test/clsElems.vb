Public Class clsElems
    Public Elems As List(Of clsElem)          ' 图形对象的集合
    Public Selection As clsSelection          ' 当前选集对象

    Event Redraw()
    ' 选集发生了变化（或增加或减少，或一个或多个图形对象）
    Event SelectionChanged()

    Public Sub New()
        elems = New List(Of clsElem)
        Selection = New clsSelection
    End Sub
    Public Sub Append(ByVal e As clsElem)
        elems.Add(e)
        RaiseEvent Redraw()
    End Sub

    Public Sub Draw(ByVal g As Graphics, ByVal M As clsMatrix3)

        Dim state As ObjectState
        For i = 0 To Elems.Count - 1
            If Selection.Contains(Elems(i)) Then
                state = ObjectState.Selected
            Else
                state = ObjectState.Common
            End If
            Elems(i).Draw(g, M, state)
        Next
    End Sub

    Public Function Count() As Integer
        Return elems.Count
    End Function
    Public Function Item(ByVal index As Integer) As clsElem
        Return elems(index)
    End Function

    ' 在点选过程中，改变了选集，并激发“选集改变”事件
    Public Sub SelectByPoint(ByVal p As PointF)
        Dim Change As Boolean = False
        For i = 0 To Elems.Count - 1
            If Elems(i).SelectByPoint(p) = True Then
                Selection.DoSelect(Elems(i)) : change = True
            End If
        Next
        If Change = True Then
            RaiseEvent SelectionChanged()
        End If
    End Sub

    Public Sub Transform(ByVal m As clsMatrix3)
        Selection.Transform(m)
        RaiseEvent Redraw()
    End Sub

End Class
