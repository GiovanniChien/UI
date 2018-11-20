Class ItemComparer
    Implements IComparer
    Private ColumnID As Integer
    Private ColumnType As Type
    Private Ascending As Boolean 'True升序  False降序

    Public Sub New(ColumnID As Integer, ColumnType As Type, Ascending As Boolean)
        Me.ColumnID = ColumnID
        Me.ColumnType = ColumnType
        Me.Ascending = Ascending
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
        'x,y其实是ListViewItem
        Dim xItem As ListViewItem = x, yItem As ListViewItem = y
        Dim xText As String = xItem.SubItems(ColumnID).Text
        Dim yText As String = yItem.SubItems(ColumnID).Text
        Dim result As Integer
        Dim xvalue = Convert.ChangeType(xText, ColumnType)
        Dim yvalue = Convert.ChangeType(yText, ColumnType)
        If xvalue > yvalue Then result = 1
        If xvalue = yvalue Then result = 0
        If xvalue < yvalue Then result = -1
        If Ascending = True Then
            Return result
        Else
            Return -result
        End If
    End Function

End Class
