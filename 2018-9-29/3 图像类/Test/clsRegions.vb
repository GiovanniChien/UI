
Class clsRegions
    Private Regions As List(Of clsRegion)

    Public Sub New()
        Regions = New List(Of clsRegion)
    End Sub
    Public Sub Append(ByVal r As clsRegion)
        Regions.Add(r)
    End Sub
    ReadOnly Property Count As Integer
        Get
            Return Regions.Count
        End Get
    End Property
    Function Item(ByVal index As Integer) As clsRegion
        Return Regions(index)
    End Function

    Public Sub Display()
        For i = 0 To Regions.Count - 1
            Regions(i).Display()
        Next
    End Sub



End Class
