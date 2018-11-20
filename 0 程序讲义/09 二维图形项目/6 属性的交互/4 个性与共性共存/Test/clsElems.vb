Public Class clsElems
    Public elems As List(Of clsElem)
    Event Redraw()

    Public Sub New()
        elems = New List(Of clsElem)
    End Sub
    Public Sub Append(ByVal e As clsElem)
        elems.Add(e)
        RaiseEvent Redraw()
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        For i = 0 To elems.Count - 1
            If elems(i).Layer.Show = True Then
                elems(i).Draw(g)
            End If
        Next
    End Sub

    Public Function Count() As Integer
        Return elems.Count
    End Function
    Public Function GetElem(ByVal index As Integer) As clsElem
        Return elems(index)
    End Function
End Class
