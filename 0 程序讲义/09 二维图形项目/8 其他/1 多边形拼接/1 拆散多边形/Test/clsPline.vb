Imports System.Math

Public Class clsPline
    Private KeyPoints() As PointF

    Public Sub New(Points As List(Of PointF))
        Dim N As Integer = Points.Count
        ReDim KeyPoints(N - 1)
        For i = 0 To N - 1
            KeyPoints(i) = Points(i)
        Next
    End Sub

    Public Sub DrawPolygon(g As Graphics)
        Dim myPen As New Pen(Color.Red, 1)
        g.DrawPolygon(myPen, KeyPoints)
    End Sub
    Public Sub DrawPline(g As Graphics)
        Dim myPen As New Pen(Color.Red, 1)
        g.DrawLines(myPen, KeyPoints)
    End Sub

    Public Sub Offset(dx As Integer, dy As Integer)
        For i = 0 To KeyPoints.Count - 1
            KeyPoints(i).X += dx
            KeyPoints(i).Y += dy
        Next
    End Sub

    Public Function Divide(k As Integer) As List(Of clsPline)
        Dim plines As New List(Of clsPline), pline As clsPline
        Dim Points As List(Of PointF)
        Dim L1 As Single = Length() / k
        Dim sp As PointF = KeyPoints(0)  '第一个多段线的起点
        Dim nextVexID As Integer = 1     '起点后的端点下标 
        For i = 1 To k
            Points = New List(Of PointF)
            Points.Add(sp)   '添加起点
            '构造多段线的端点序列Points，使之总长度等于L1
            Dim Li As Single = 0   '当前多段线的总长
            While 1
                If nextVexID = KeyPoints.Count Then  '转回到了多边形的起点
                    Exit While
                End If
                Dim Li1 As Single = Length(sp, KeyPoints(nextVexID))
                If Li + Li1 > L1 Then
                    Exit While
                End If
                Points.Add(KeyPoints(nextVexID))     '添加端点
                Li += Li1
                nextVexID += 1
            End While
            If nextVexID = KeyPoints.Count Then
                sp = KeyPoints(0)
            Else
                '当前多段线的终点，下一个多段线的起点
                sp = GetIp(KeyPoints(nextVexID - 1), KeyPoints(nextVexID), L1 - Li)
            End If
            Points.Add(sp)     '添加终点
            pline = New clsPline(Points)
            plines.Add(pline)
        Next
        Return plines
    End Function

    Public Function Length() As Single
        Dim L As Single = 0
        For i = 0 To KeyPoints.Count - 2
            L += Length(KeyPoints(i), KeyPoints(i + 1))
        Next
        L += Length(KeyPoints(KeyPoints.Count - 1), KeyPoints(0))
        Return L
    End Function
    Private Function Length(sp As PointF, ep As PointF) As Single
        Return Sqrt((ep.X - sp.X) ^ 2 + (ep.Y - sp.Y) ^ 2)
    End Function

    '在线段sp->ep中，寻找内部点Ip，使得sp->ip的距离为dist
    Private Function GetIp(sp As PointF, ep As PointF, dist As Single) As PointF
        Dim k As Single = dist / Length(sp, ep) ' k取值在(0,1)之间
        Dim p As PointF
        p.X = (1 - k) * sp.X + k * ep.X
        p.Y = (1 - k) * sp.Y + k * ep.Y
        Return p
    End Function
    '求多边形的中心点
    Public Function GetCp() As PointF
        Dim cp As PointF = KeyPoints(0)
        For i = 1 To KeyPoints.Count - 1
            cp.X += KeyPoints(i).X
            cp.Y += KeyPoints(i).Y
        Next
        cp.X /= KeyPoints.Count
        cp.Y /= KeyPoints.Count
        Return cp
    End Function

End Class
