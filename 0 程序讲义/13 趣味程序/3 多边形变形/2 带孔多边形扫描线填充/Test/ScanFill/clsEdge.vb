Public Class clsEdge
    Public x As Single
    Public dx As Single
    Public ymax As Integer

    Public Sub New(ByVal lowp As Point, ByVal highp As Point)
        x = lowp.X
        dx = (highp.X - lowp.X) / (highp.Y - lowp.Y)
        ymax = highp.Y - 1
    End Sub

End Class
