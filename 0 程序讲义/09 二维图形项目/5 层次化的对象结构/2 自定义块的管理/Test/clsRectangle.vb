Public Class clsRectangle
    Inherits clsElem

    Private sp, ep As PointF
    Private points(3) As PointF

    Public Sub New(ByVal sp As PointF, ByVal ep As PointF)
        Me.sp = sp : Me.ep = ep
        Init()
    End Sub
    Private Sub Init()
        Dim xmin, xmax, ymin, ymax As Single
        If sp.X < ep.X Then
            xmin = sp.X : xmax = ep.X
        Else
            xmin = ep.X : xmax = sp.X
        End If
        If sp.Y < ep.Y Then
            ymin = sp.Y : ymax = ep.Y
        Else
            ymin = ep.Y : ymax = sp.Y
        End If
        points(0) = New PointF(xmin, ymin)
        points(1) = New PointF(xmax, ymin)
        points(2) = New PointF(xmax, ymax)
        points(3) = New PointF(xmin, ymax)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = "Rectangle "
        For i = 0 To points.Count - 1
            s = s & ": " & points(i).ToString & " "
        Next
        Return s
    End Function

    Public Overrides Function SelectByPoint(ByVal p As PointF) As Boolean
        If clsLine.SelectByPoint(p, points(0), points(1)) = True Then Return True
        If clsLine.SelectByPoint(p, points(1), points(2)) = True Then Return True
        If clsLine.SelectByPoint(p, points(2), points(3)) = True Then Return True
        If clsLine.SelectByPoint(p, points(3), points(0)) = True Then Return True
        Return False
    End Function

    Public Overrides Sub Transform(ByVal m As clsMatrix3)
        For i = 0 To points.Count - 1
            points(i) = m.Tranform(points(i))
        Next
    End Sub

    Public Overrides Function Clone() As clsElem
        Return New clsRectangle(sp, ep)
    End Function

    Public Overrides Sub Draw(ByVal g As Graphics, Optional ByVal isSelectElem As Boolean = False)
        If isSelectElem = True Then
            g.DrawPolygon(CommonPen, points)
        Else
            g.DrawPolygon(SelectedPen, points)
        End If
    End Sub
    Public Overloads Overrides Sub Draw(ByVal g As System.Drawing.Graphics, ByVal M As clsMatrix3, Optional ByVal isSelectElem As Boolean = False)
        Dim ps(3) As PointF
        For i = 0 To 3
            ps(i) = M.Tranform(points(i))
        Next
        If isSelectElem = True Then
            g.DrawPolygon(CommonPen, ps)
        Else
            g.DrawPolygon(SelectedPen, ps)
        End If
    End Sub
End Class
