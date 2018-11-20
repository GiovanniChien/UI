Public Class clsPolygons
    Private Polygons As List(Of clsPolygon)

    Public Sub New()
        Polygons = New List(Of clsPolygon)
    End Sub
    Public Sub Draw(g As Graphics)
        For i = 0 To Polygons.Count - 1
            Polygons(i).Draw(g)
        Next
    End Sub

    Sub Add(Polygon As clsPolygon)
        Polygons.Add(Polygon)
    End Sub

End Class
