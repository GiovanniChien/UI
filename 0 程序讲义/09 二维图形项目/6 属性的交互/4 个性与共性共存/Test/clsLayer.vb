Public Class clsLayer
    Public Name As String
    Public Properties As clsProperty
    Public Show As Boolean

    Public Sub New(ByVal Name As String, ByVal Pen As Pen)
        Me.Name = Name
        Me.Properties = New clsProperty(Pen)
        Show = True
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = Name & ": "
        Return s & Properties.Pen.Color.ToString & vbTab & "显示" & Show
    End Function
End Class
