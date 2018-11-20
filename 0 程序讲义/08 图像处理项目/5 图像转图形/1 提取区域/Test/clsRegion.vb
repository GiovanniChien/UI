' Buff中Mark的连通分量（区域）
Public Class clsRegion
    Private Points As List(Of Point)  '区域内部所有的点

    Public Sub New(Points As List(Of Point))
        Me.Points = Points
    End Sub

    Public Sub Draw(Buff As Bitmap, Mark As Color)
        For i = 0 To Points.Count - 1
            Buff.SetPixel(Points(i).X, Points(i).Y, Mark)
        Next
    End Sub

    Public Function PointCount() As Integer
        Return Points.Count
    End Function

End Class
