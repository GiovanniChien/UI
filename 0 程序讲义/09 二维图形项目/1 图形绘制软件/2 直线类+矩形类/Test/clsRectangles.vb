Public Class clsRectangles
    Private Rectangles As List(Of clsRectangle)
    Event Redraw()

    Public Sub New()
        Rectangles = New List(Of clsRectangle)
    End Sub

    Public Sub Append(ByVal Rectangle As clsRectangle)
        Rectangles.Add(Rectangle)
        RaiseEvent Redraw()
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        For i = 0 To Rectangles.Count - 1
            Rectangles(i).Draw(g)
        Next
    End Sub

End Class

