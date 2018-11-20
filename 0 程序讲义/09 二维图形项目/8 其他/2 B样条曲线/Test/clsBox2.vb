Public Class clsBox2
    Public xmin, xmax, ymin, ymax As Single

    Public Sub New(xmin As Single, xmax As Single, ymin As Single, ymax As Single)
        Me.xmin = xmin : Me.xmax = xmax
        Me.ymin = ymin : Me.ymax = ymax
    End Sub

    Public Sub New(box As clsBox2)
        Me.xmin = box.xmin : Me.xmax = box.xmax
        Me.ymin = box.ymin : Me.ymax = box.ymax
    End Sub

End Class
