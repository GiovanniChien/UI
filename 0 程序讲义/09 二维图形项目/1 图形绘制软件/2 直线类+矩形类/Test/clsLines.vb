Class clsLines
    Private Lines As List(Of clsLine)
    Event Redraw()

    Public Sub New()
        Lines = New List(Of clsLine)
    End Sub

    Public Sub Append(ByVal line As clsLine)
        Lines.Add(line)
        RaiseEvent Redraw()
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        For i = 0 To Lines.Count - 1
            Lines(i).Draw(g)
        Next
    End Sub

End Class
