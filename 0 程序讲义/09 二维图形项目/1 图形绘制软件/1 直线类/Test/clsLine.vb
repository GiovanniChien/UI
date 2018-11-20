Class clsLine
    Private sp, ep As PointF

    Public Sub New(ByVal sp As PointF, ByVal ep As PointF)
        Me.sp = sp : Me.ep = ep
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        Dim myPen As New Pen(Color.Red, 1)
        g.DrawLine(myPen, sp, ep)
    End Sub

End Class
