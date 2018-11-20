Class clsLine
    Inherits clsElem

    Private sp, ep As PointF

    Public Sub New(ByVal Layer As clsLayer, ByVal sp As PointF, ByVal ep As PointF)
        MyBase.New(Layer)
        Me.sp = sp : Me.ep = ep
    End Sub

    Public Overrides Sub Draw(g As Graphics)
        g.DrawLine(Pen, sp, ep)
    End Sub
    Public Overrides Function ToString() As String
        Dim s As String = "Line "
        s = s & ": " & sp.ToString & "," & ep.ToString
        s = s & Layer.Name
        Return s
    End Function

End Class
