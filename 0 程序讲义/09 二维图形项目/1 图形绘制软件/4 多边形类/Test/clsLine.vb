Class clsLine
    Inherits clsElem

    Private sp, ep As PointF

    Public Sub New(ByVal sp As PointF, ByVal ep As PointF)
        Me.sp = sp : Me.ep = ep
    End Sub

    Public Overrides Sub Draw(g As Graphics)
        Dim myPen As New Pen(Color.Red, 1)
        g.DrawLine(myPen, sp, ep)
    End Sub
    Public Overrides Function ToString() As String
        Dim s As String = "Line: "
        s = s & sp.ToString & "," & ep.ToString
        Return s
    End Function

End Class
