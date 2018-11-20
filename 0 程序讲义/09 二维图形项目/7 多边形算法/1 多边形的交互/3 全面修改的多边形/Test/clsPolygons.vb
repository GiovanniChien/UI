Public Class clsPolygons
    Private polygons As List(Of clsPolygon)  ' 核心数据对象
    Private ActivePolygon As clsPolygon      ' 当前数据对象

    Public Sub New()
        polygons = New List(Of clsPolygon)
    End Sub

    Public Sub Append(ByVal polygon As clsPolygon)
        polygons.Add(polygon)
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        For i = 0 To polygons.Count - 1
            polygons(i).Draw(g)
        Next
    End Sub

    Public Sub SelectVertex(ByVal p As Point)
        For i = 0 To polygons.Count - 1
            polygons(i).SelectVertex(p)
        Next
    End Sub

    Public Sub VertexMove(ByVal offset As PointF)
        For i = 0 To polygons.Count - 1
            polygons(i).VertexMove(offset)
        Next
    End Sub
    Public Sub VertexRemove()
        For i = 0 To polygons.Count - 1
            polygons(i).VertexRemove()
        Next
    End Sub

    Public Sub InsertVertex(ByVal point As Point)

    End Sub

End Class
