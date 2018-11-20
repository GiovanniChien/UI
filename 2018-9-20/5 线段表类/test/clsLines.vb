Public Class clsLines
    Dim lines As List(Of clsLine)
    Dim pen As Pen

    Public Sub New()
        pen = New Pen(Color.Red)
        lines = New List(Of clsLine)
    End Sub

    Public Sub Append(ByVal line As clsLine)
        lines.Add(line)
    End Sub
    Public Sub Draw(ByVal g As Graphics)
        For i = 0 To lines.Count - 1
            lines(i).draw(g, pen)
        Next
    End Sub
End Class
