Class clsLine
    Inherits clsElem

    Private Sp, Ep As PointF

    Public Sub New(ByVal sp As PointF, ByVal ep As PointF)
        Me.Sp = sp : Me.Ep = ep
    End Sub

    Public Overrides Sub Draw(g As Graphics, Optional isSelectElem As Boolean = False)
        If isSelectElem = True Then
            g.DrawLine(SelectedPen, Sp, Ep)
        Else
            g.DrawLine(CommonPen, Sp, Ep)
        End If
    End Sub
    Public Overrides Function ToString() As String
        Dim s As String = "Line: "
        s = s & Sp.ToString & "," & Ep.ToString
        Return s
    End Function

    Public Overrides Function SelectByPoint(p As PointF) As Boolean
        Return SelectByPoint(p, Me.Sp, Me.Ep)
    End Function

    ' 设计为共享方法，用心良苦：其他类也需要调用本算法
    Public Overloads Shared Function SelectByPoint(p As PointF, sp As PointF, ep As PointF) As Boolean
        Const DELTA As Single = 5
        Dim A As Double = (ep.X - sp.X) / Math.Sqrt((ep.X - sp.X) * (ep.X - sp.X) + (ep.Y - sp.Y) * (ep.Y - sp.Y))
        Dim B As Double = (ep.Y - sp.Y) / Math.Sqrt((ep.X - sp.X) * (ep.X - sp.X) + (ep.Y - sp.Y) * (ep.Y - sp.Y))
        Dim t As Double = (A * (p.X - sp.X) + B * (p.Y - sp.Y)) / (A * (ep.X - sp.X) + B * (ep.Y - sp.Y))
        If t < 0 Or t > 1 Then Return False
        Dim x As Double = sp.X + (ep.X - sp.X) * t
        Dim y As Double = sp.Y + (ep.Y - sp.Y) * t
        Dim d2 As Double = (x - p.X) * (x - p.X) + (y - p.Y) * (y - p.Y)
        If d2 <= DELTA * DELTA Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
