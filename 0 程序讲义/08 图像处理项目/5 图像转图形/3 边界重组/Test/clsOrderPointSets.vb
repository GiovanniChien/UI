Public Class clsOrderPointSets
    Private OrderPoints As List(Of clsOrderPointSet)

    Public Sub New()
        OrderPoints = New List(Of clsOrderPointSet)
    End Sub
    Public Sub Add(OrderPoint As clsOrderPointSet)
        OrderPoints.Add(OrderPoint)
    End Sub

    Public Function Count() As Integer
        Return OrderPoints.Count
    End Function

    Public Function Item(index) As clsOrderPointSet
        Return OrderPoints(index)
    End Function

    Public Overrides Function ToString() As String
        Dim s As String = ""
        For i = 0 To OrderPoints.Count - 1
            s = s & OrderPoints(i).ToString & vbCrLf & vbCrLf
        Next
        Return s
    End Function

End Class
