Public Class clsLine
    Dim sp As Point
    Dim ep As Point

    Public Sub New(ByVal sp As Point, ByVal ep As Point)
        Me.sp = sp
        Me.ep = ep
    End Sub
    Public Sub draw(ByVal g As Graphics, ByVal pen As Pen)
        g.DrawLine(pen, sp, ep)
    End Sub
End Class
