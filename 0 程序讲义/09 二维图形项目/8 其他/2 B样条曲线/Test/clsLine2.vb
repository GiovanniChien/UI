Class clsLine2
    Private sp, ep As PointF

    Public Sub New(ByVal sp As PointF, ByVal ep As PointF)
        Me.sp = sp : Me.ep = ep
    End Sub

    Public Sub Draw(ByVal g As Graphics, myPen As Pen)
        g.DrawLine(myPen, sp, ep)
    End Sub

End Class
