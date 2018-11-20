Public Class clsRegion
    Private Region As List(Of Point)

    Public Sub New()
        Region = New List(Of Point)
    End Sub
    Public Sub Append(ByVal p As Point)
        Region.Add(p)
    End Sub
    ReadOnly Property Count As Integer
        Get
            Return Region.Count
        End Get
    End Property
    Function Item(ByVal index As Integer) As Point
        Return Region(index)
    End Function

    Public Sub Display()
        For i = 0 To Region.Count - 1
            ' Region(i)
        Next
    End Sub

End Class
