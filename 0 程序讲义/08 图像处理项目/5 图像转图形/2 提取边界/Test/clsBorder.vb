Public Class clsBorder
    Private Points As List(Of Point)  '点集合

    Public Sub New()
        Points = New List(Of Point)
    End Sub

    Public Sub Add(p As Point)
        Points.Add(p)
    End Sub

    Public Function PointCount() As Integer
        Return Points.Count
    End Function

    Public Sub Draw(Buff As Bitmap, Mark As Color)
        For i = 0 To Points.Count - 1
            Buff.SetPixel(Points(i).X, Points(i).Y, Mark)
        Next
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = ""
        For i = 0 To Points.Count - 1
            s = s & Points(i).X & "," & Points(i).Y & vbTab
        Next
        Return s
    End Function

End Class
