Public Class clsRegion
    Private points As List(Of PointF), path As Drawing2D.GraphicsPath
    Private region As Region
    Public Selected As Boolean

    Private Sub Init()
        path = New Drawing2D.GraphicsPath
        For i = 0 To points.Count - 2
            path.AddLine(points(i), points(i + 1))
        Next
        path.AddLine(points(points.Count - 1), points(0))
        region = New Region(path)
        Selected = False
    End Sub
    Public Sub New(points As List(Of PointF))
        Me.points = New List(Of PointF)(points) : Init()
    End Sub
    Public Sub New(r As clsRegion)
        Me.points = New List(Of PointF)(r.points) : Init()
    End Sub
    Function Clone() As clsRegion
        Return New clsRegion(Me)
    End Function

    Sub Draw(g As Graphics)
        g.FillRegion(Brushes.Blue, region)
        If Selected = True Then
            g.DrawPath(Pens.Red, path)
        Else
            g.DrawPath(Pens.Black, path)
        End If
    End Sub
    Sub Op(r As clsRegion, kind As RegionOp)
        Select Case kind
            Case RegionOp.Intersect
                Me.region.Intersect(r.region)
            Case RegionOp.Union
                Me.region.Union(r.region)
            Case RegionOp.Xor
                Me.region.Xor(r.region)
        End Select
    End Sub
    Sub SelectbyPoint(ByVal p As PointF)
        If region.IsVisible(p) = True Then
            Selected = Not Selected
        End If
    End Sub


End Class
