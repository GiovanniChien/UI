Imports OpenTK

Public Class clsViewBox
    Public left, right As Single
    Public bottom, top As Single
    Public near, far As Single

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

End Class
