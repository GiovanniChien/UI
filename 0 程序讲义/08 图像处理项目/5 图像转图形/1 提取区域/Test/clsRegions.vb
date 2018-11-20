Public Class clsRegions
    Private Regions As List(Of clsRegion)

    Public Sub New()
        Regions = New List(Of clsRegion)
    End Sub

    Public Sub Add(Region As clsRegion)
        Regions.Add(Region)
    End Sub

    Public Sub Draw(buff As Bitmap, mark As Color)
        For i = 0 To Regions.Count - 1
            Regions(i).Draw(buff, mark)
        Next
    End Sub

    Public Sub FillList(List As ListBox)
        With List.Items
            .Clear()
            .Add("区域数:" & Regions.Count)
            For i = 0 To Regions.Count - 1
                .Add(Regions(i).PointCount)
            Next
        End With
    End Sub

    Public Function Item(index) As clsRegion
        Return Regions(index)
    End Function

End Class

