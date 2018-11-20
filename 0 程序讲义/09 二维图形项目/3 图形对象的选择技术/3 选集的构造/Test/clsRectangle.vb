Public Class clsRectangle
    Inherits clsElem
    Private xmin, xmax, ymin, ymax As Single

    Public Sub New(ByVal sp As PointF, ByVal ep As PointF)
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
    End Sub

    Public Overrides Sub Draw(ByVal g As Graphics, Optional isSelectElem As Boolean = False)
        If isSelectElem = True Then
            g.DrawRectangle(SelectedPen, xmin, ymin, xmax - xmin, ymax - ymin)
        Else
            g.DrawRectangle(CommonPen, xmin, ymin, xmax - xmin, ymax - ymin)
        End If
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = "Rectangle: "
        s = s & "(" & xmin & "," & ymin & ")-(" & xmax & "," & ymax & ")"
        Return s
    End Function

    Public Overrides Function SelectByPoint(p As PointF) As Boolean
        If clsLine.SelectByPoint(p, New PointF(xmin, ymin), New PointF(xmax, ymin)) = True Then Return True
        If clsLine.SelectByPoint(p, New PointF(xmax, ymin), New PointF(xmax, ymax)) = True Then Return True
        If clsLine.SelectByPoint(p, New PointF(xmax, ymax), New PointF(xmin, ymax)) = True Then Return True
        If clsLine.SelectByPoint(p, New PointF(xmin, ymax), New PointF(xmin, ymin)) = True Then Return True
        Return False
    End Function


End Class
