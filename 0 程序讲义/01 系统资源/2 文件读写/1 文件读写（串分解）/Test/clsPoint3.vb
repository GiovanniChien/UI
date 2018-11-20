Public Class clsPoint3
    Public x, y, z As Single

    Public Sub New(content As String)
        Dim separator() As String = {" ", vbTab}
        Dim sp() As String = content.Split(separator, System.StringSplitOptions.RemoveEmptyEntries)
        x = sp(1)
        y = sp(2)
        z = sp(3)
    End Sub

    Overrides Function ToString() As String
        Return (x.ToString & "," & y.ToString & "," & z.ToString)
    End Function

End Class
