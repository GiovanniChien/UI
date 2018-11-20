Public Class clsStudent
    Public id As Integer
    Public name As String
    Public score As Single

    Public Sub New()
        Me.id = 101
        Me.name = "aaa"
        Me.score = 99.9
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = id
        s = s & vbTab & name
        s = s & vbTab & score
        Return s
    End Function

End Class
