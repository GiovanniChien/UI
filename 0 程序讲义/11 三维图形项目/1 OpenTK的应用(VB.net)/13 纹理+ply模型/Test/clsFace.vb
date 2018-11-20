Imports OpenTK.Graphics.OpenGL

Structure PText
    Public PointID As Integer
    Public TexCoordX As Single
    Public TexCoordY As Single
End Structure

Class clsFace
    Public Points(2) As PText

    Public Sub New(ByVal PointID() As Integer, ByVal TexCoord() As Single)
        Points(0) = New PText
        With Points(0)
            .PointID = PointID(0) : .TexCoordX = TexCoord(0) : .TexCoordY = TexCoord(1)
        End With
        Points(1) = New PText
        With Points(1)
            .PointID = PointID(1) : .TexCoordX = TexCoord(2) : .TexCoordY = TexCoord(3)
        End With
        Points(2) = New PText
        With Points(2)
            .PointID = PointID(2) : .TexCoordX = TexCoord(4) : .TexCoordY = TexCoord(5)
        End With
    End Sub

End Class
