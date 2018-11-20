
Public Class clsOrderPointSet
    Private Points As List(Of Point)

    Public Sub New()
        Me.Points = New List(Of Point)
    End Sub

    Public Sub Add(p As Point)
        Me.Points.Add(p)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = ""
        For i = 0 To Points.Count - 1
            s = s & Points(i).X & "," & Points(i).Y & vbTab
        Next
        Return s
    End Function

End Class
