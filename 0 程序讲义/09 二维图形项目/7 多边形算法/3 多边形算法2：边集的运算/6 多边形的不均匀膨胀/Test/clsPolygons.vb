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

    Public Sub Add(Polygon As clsPolygon)
        Polygons.Add(Polygon)
    End Sub

    ' 计算射线ray与当前多边形集合中每个多边形的交点的最小t值
    Public Function GetNearestXP(ray As clsLineSegement) As Single
        Const inf As Single = 10000
        Dim mint As Single = inf
        For i = 0 To Polygons.Count - 1
            Dim t As Single = Polygons(i).GetNearestXP(ray)
            If t = -1 Then Continue For
            If t < mint Then
                mint = t
            End If
        Next
        If mint = inf Then mint = -1 '射线ray与当前多边形集合无交点
        Return mint
    End Function

End Class
