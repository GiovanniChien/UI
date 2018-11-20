
Public Class clsFitPolygon

    Private points As List(Of PointF)

    Public Sub New(lines As List(Of LineSegment))
        points = New List(Of PointF)
        Dim Ip As PointF
        For i = 0 To lines.Count - 2
            If GetIp(lines(i), lines(i + 1), Ip) = True Then points.Add(Ip)
        Next
        If GetIp(lines(lines.Count - 1), lines(0), Ip) = True Then points.Add(Ip)
    End Sub

    ' 计算直线La与直线Lb的交点
    Private Function GetIp(L1 As LineSegment, L2 As LineSegment, ByRef Ip As PointF) As Boolean
        Dim x As Single
        If (Not Single.IsNaN(L1.B)) And (Not Single.IsNaN(L2.B)) Then   ' 斜率都不是无穷大
            If Math.Abs(L1.B - L2.B) < 0.1 Then
                Return False  '无交点
            Else
                Ip.X = (L2.A - L1.A) / ((L1.B - L2.B)) : Ip.Y = L1.A + L1.B * Ip.X
                Return True
            End If
        End If
        If Single.IsNaN(L1.B) And (Not Single.IsNaN(L2.B)) Then   ' L1是竖直线（斜率无穷大）， 方程是 x=L1.A
            Ip.X = L1.A : Ip.Y = L2.A + L2.B * Ip.X
            Return True
        End If
        If (Not Single.IsNaN(L1.B)) And Single.IsNaN(L2.B) Then   ' L2是竖直线（斜率无穷大）， 方程是 x=L2.A
            Ip.X = L2.A : Ip.Y = L1.A + L1.B * Ip.X
            Return True
        End If
        ' L1和L2都是竖直线（斜率无穷大）， 方程是 x=L1.A  x=L2.A
        Return False
    End Function

    Public Sub Draw(Buff As Bitmap, Mark As Color)
        For i = 0 To points.Count - 1
            Buff.SetPixel(points(i).X, points(i).Y, Mark)
        Next
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = ""
        For i = 0 To points.Count - 1
            s = s & points(i).X & "," & points(i).Y & vbTab
        Next
        Return s
    End Function

End Class

