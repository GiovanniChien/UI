Public Class clsBorders
    Private Borders As List(Of clsBorder)

    Public Sub New()
        Borders = New List(Of clsBorder)
    End Sub

    Public Sub Add(Border As clsBorder)
        Borders.Add(Border)
    End Sub

    Public Sub FillList(lstBorder As ListBox)
        With lstBorder.Items
            .Clear()
            .Add("区域数:" & Borders.Count)
            For i = 0 To Borders.Count - 1
                .Add(Borders(i).PointCount)
            Next
        End With
    End Sub

    Public Sub Draw(Buff As Bitmap, Mark As Color)
        For i = 0 To Borders.Count - 1
            Borders(i).Draw(Buff, Mark)
        Next
    End Sub

    Public Function Item(index) As clsBorder
        Return Borders(index)
    End Function

End Class
