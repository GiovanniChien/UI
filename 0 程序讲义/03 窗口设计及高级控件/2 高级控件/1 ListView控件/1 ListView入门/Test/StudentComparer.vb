Class StudentComparer
    Implements IComparer
    Private ColumnID As Integer

    Public Sub New(ColumnID As Integer)
        Me.ColumnID = ColumnID
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
        'x,y其实是ListViewItem
        Dim xItem As ListViewItem = x, yItem As ListViewItem = y
        Dim xvalue As String = xItem.SubItems(ColumnID).Text
        Dim yValue As String = yItem.SubItems(ColumnID).Text
        If xvalue > yValue Then Return 1
        If xvalue = yValue Then
            Return 0
        Else
            Return -1
        End If
    End Function

End Class
