Public Class clsPoint
    Public x As Single
    Public y As Single
    Public z As Single
    Public color As Color

    Public Sub New(xyzargb() As String)
        x = xyzargb(0)
        y = xyzargb(1)
        z = xyzargb(2)
        color = color.FromArgb(xyzargb(3), xyzargb(4), xyzargb(5), xyzargb(6))
    End Sub
End Class
