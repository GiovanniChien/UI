Imports System.Drawing

Class clsLine
    Inherits clsElem

    Private Sp, Ep As PointF

    Public Sub New(ByVal sp As PointF, ByVal ep As PointF)
        Me.Sp = sp : Me.Ep = ep
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = "Line: "
        s = s & Sp.ToString & "," & Ep.ToString
        Return s
    End Function

    Public Overrides Function SelectByPoint(ByVal p As PointF) As Boolean
        Return SelectByPoint(p, Me.Sp, Me.Ep)
    End Function

    ' 设计为共享方法，用心良苦：其他类也需要调用本算法
    Public Overloads Shared Function SelectByPoint(ByVal p As PointF, ByVal sp As PointF, ByVal ep As PointF) As Boolean
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

    Public Overrides Sub Transform(ByVal m As clsMatrix3)
        Sp = m.Tranform(Sp)
        Ep = m.Tranform(Ep)
    End Sub

    Public Overrides Function Clone() As clsElem
        Return New clsLine(Sp, Ep)
    End Function

    Public Overloads Overrides Sub Draw(ByVal g As System.Drawing.Graphics, Optional ByVal isSelectElem As Boolean = False)
        If isSelectElem = True Then
            g.DrawLine(SelectedPen, Sp, Ep)
        Else
            g.DrawLine(CommonPen, Sp, Ep)
        End If
    End Sub
    Public Overrides Sub Draw(ByVal g As Graphics, ByVal M As clsMatrix3, Optional ByVal isSelectElem As Boolean = False)
        Dim sp1 As PointF = M.Tranform(Sp)
        Dim ep1 As PointF = M.Tranform(Ep)
        If isSelectElem = True Then
            g.DrawLine(SelectedPen, sp1, ep1)
        Else
            g.DrawLine(CommonPen, sp1, ep1)
        End If
    End Sub

End Class
