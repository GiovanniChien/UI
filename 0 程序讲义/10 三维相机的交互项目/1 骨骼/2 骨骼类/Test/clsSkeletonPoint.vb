Public Class clsSkeletonPoint
    Public x As Single
    Public y As Single
    Public z As Single

    Public Sub New(xyz() As String)
        x = xyz(0)
        y = xyz(1)
        z = xyz(2)
    End Sub

End Class
