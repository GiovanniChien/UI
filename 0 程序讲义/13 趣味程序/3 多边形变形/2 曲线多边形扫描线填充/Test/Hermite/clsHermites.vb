Public Class clsHermites
    Private sVertexes As List(Of Point)  ' 原始端点序列
    Private Hermites As List(Of clsHermite) '曲线段对象的集合
    Private deltaAngles As List(Of Single)  '曲线段对象的转角的集合

    Public Sub New(ByVal Vertexes As List(Of Point))
        sVertexes = New List(Of Point)(Vertexes)
        CreateHermites()
    End Sub
    ' 样条化多边形
    Private Sub CreateHermites()
        sVertexes.Add(sVertexes(0))
        sVertexes.Add(sVertexes(1))
        Hermites = New List(Of clsHermite)
        For i = 0 To sVertexes.Count - 3
            Hermites.Add(New clsHermite(sVertexes(i), sVertexes(i + 1), sVertexes(i + 2)))
        Next
    End Sub
    Public Function DrawBorder(ByVal k As Integer) As List(Of PointF)
        Dim points As New List(Of PointF)
        For i = 0 To Hermites.Count - 1
            For t As Single = 0 To (k - 1) / k Step 1 / k
                points.Add(Hermites(i).GetPoint(t))
            Next
        Next
        Return points
    End Function

    Public Sub DrawBorder(ByVal Buffer As Bitmap, ByVal color As Color)
        Dim points As List(Of PointF) = DrawBorder(20)
        For i = 0 To points.Count - 1
            Buffer.SetPixel(points(i).X, points(i).Y, color)
        Next
    End Sub

End Class
