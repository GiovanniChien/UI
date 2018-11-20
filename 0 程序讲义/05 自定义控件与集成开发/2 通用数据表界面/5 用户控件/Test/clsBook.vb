Public Class clsBook
    Public id As String
    Public name As String
    Public author As String
    Public price As Single

    Public Sub New()
        Me.id = "ISBN 978 111 407478"
        Me.name = "Vs.net"
        Me.author = "Microsoft"
        Me.price = 69.5
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = id
        s = s & vbTab & name
        s = s & vbTab & author
        s = s & vbTab & price
        Return s
    End Function

End Class
