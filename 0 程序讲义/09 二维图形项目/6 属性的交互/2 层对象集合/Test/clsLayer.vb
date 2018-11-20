Public Class clsLayer
    Public Pen As Pen
    Public Name As String

    Public Sub New(ByVal Name As String, ByVal Pen As Pen)
        Me.Name = Name
        Me.Pen = Pen
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = Name & ": "
        Return s & Pen.Color.ToString
    End Function
End Class
