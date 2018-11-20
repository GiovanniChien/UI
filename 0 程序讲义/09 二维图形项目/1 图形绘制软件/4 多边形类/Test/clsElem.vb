Public MustInherit Class clsElem
    Protected Pen As Pen

    Public MustOverride Sub Draw(ByVal g As Graphics)

    Public Sub New()
        Pen = New Pen(Color.Red, 1)
    End Sub

End Class

Public Class clsElems
    Public elems As List(Of clsElem)
    Event Redraw()

    Public Sub New()
        elems = New List(Of clsElem)
    End Sub
    Public Sub Append(e As clsElem)
        elems.Add(e)
        RaiseEvent Redraw()
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        For i = 0 To elems.Count - 1
            elems(i).Draw(g)
        Next
    End Sub

    Public Function Count() As Integer
        Return elems.Count
    End Function
    Public Function GetElem(index As Integer) As clsElem
        Return elems(index)
    End Function
End Class
