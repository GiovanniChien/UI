
Class clsLine
    Private sp, ep As PointF

    Public Sub New(sp As PointF, ep As PointF)
        Me.sp = sp : Me.ep = ep
    End Sub

    Public Sub draw(g As Graphics, RM As clsMatrix)
        g.DrawLine(Pens.Blue, RM.Transform(sp), RM.Transform(ep))
    End Sub

End Class
