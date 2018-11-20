Imports OpenTK

Public Class clsViewBox
    Public left As Single
    Public right As Single
    Public bottom As Single
    Public top As Single
    Public near As Single
    Public far As Single

    Public Sub New(ByVal left As Single, ByVal right As Single, ByVal bottom As Single, ByVal top As Single, ByVal near As Single, ByVal far As Single)
        Me.left = left
        Me.right = right
        Me.bottom = bottom
        Me.top = top
        Me.near = near
        Me.far = far
    End Sub

    Public Function DpToLp(ByVal glCtrl As GLControl, ByVal x As Integer, ByVal y As Integer) As Vector2
        Dim p As New Vector2
        p.X = (x - glCtrl.Width / 2) / (glCtrl.Width / (right - left))
        p.Y = (-y + glCtrl.Height / 2) / (glCtrl.Height / (top - bottom))
        Return p
    End Function

    Public Sub Zoom(ByVal scale As Single)
        Dim midx As Single = (left + right) / 2
        Dim width As Single = (right - left) * scale
        left = midx - width / 2
        right = midx + width / 2

        Dim midy As Single = (bottom + top) / 2
        Dim height As Single = (top - bottom) * scale
        bottom = midy - height / 2
        top = midy + height / 2
    End Sub

    Sub Pan(ByVal dx As Single, ByVal dy As Single)
        left += dx : right += dx
        bottom += dy : top += dy
    End Sub


End Class
