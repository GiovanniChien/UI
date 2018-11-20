Imports System.Math

Public Class clsPolygon
    Private points As List(Of PointF)
    Private boxHalfWidth As Integer = 2, boxHalfHeight As Integer = 2
    Private ActiveID As Integer  '任何时刻只有一个当前点，或没有当前点(-1)
    Event ActiveVertexChanged()

    Public Sub New(ByVal points As List(Of PointF))
        Me.points = points
        ActiveID = -1
    End Sub

    Sub Draw(ByVal g As Graphics)
        Dim CommonPen As Pen = New Pen(Color.Black)
        Dim ActivePen As Pen = New Pen(Color.Red)
        g.DrawPolygon(CommonPen, points.ToArray)
        For i = 0 To points.Count - 1
            If i = ActiveID Then
                g.DrawRectangle(ActivePen, points(i).X - boxHalfWidth, points(i).Y - boxHalfHeight, 2 * boxHalfWidth, 2 * boxHalfHeight)
            Else
                g.DrawRectangle(CommonPen, points(i).X - boxHalfWidth, points(i).Y - boxHalfHeight, 2 * boxHalfWidth, 2 * boxHalfHeight)
            End If
        Next
    End Sub

    Sub SelectVertex(ByVal p As PointF)
        Dim minv As Single = Abs(points(0).X - p.X) + Abs(points(0).Y - p.Y)
        Dim minID As Integer = 0  '最近的点的下标
        For i = 1 To points.Count - 1
            Dim v As Single = Abs(points(i).X - p.X) + Abs(points(i).Y - p.Y) '棋盘距离
            If v < minv Then
                minv = v : minID = i
            End If
        Next
        If minv < 10 Then
            ActiveID = minID
            RaiseEvent ActiveVertexChanged()
        End If
    End Sub

End Class
