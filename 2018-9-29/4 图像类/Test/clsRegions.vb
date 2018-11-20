
Class clsRegions
    Private Regions As List(Of clsRegion)

    Public Sub New()
        Regions = New List(Of clsRegion)
    End Sub

    Sub New(ByVal Pixes As Color(,), ByVal th As Integer)
        Regions = New List(Of clsRegion)
        Dim width As Integer = Pixes.GetLength(0), height As Integer = Pixes.GetLength(1)
        Dim Visited(height - 1, width - 1) As Boolean
        For i = 0 To height - 1
            For j = 0 To width - 1
                Visited(i, j) = False
            Next
        Next
        For i = 0 To height - 1
            For j = 0 To width - 1
                If Pixes(i, j).R < th And Visited(i, j) = False Then
                    Dim Region As clsRegion = Bfs(Pixes, i, j, th, Visited)
                    Regions.Add(Region)
                End If
            Next
        Next
    End Sub
    Private Function Bfs(ByVal Pixes As Color(,), ByVal i As Integer, ByVal j As Integer, ByVal th As Integer, ByVal Visited As Boolean(,)) As clsRegion
        Dim width As Integer = Pixes.GetLength(0), height As Integer = Pixes.GetLength(1)
        Dim dx() As Integer = {-1, 1, 0, 0}
        Dim dy() As Integer = {0, 0, -1, 1}
        Dim Region As New clsRegion
        Dim Q As New Queue(Of Point)
        Q.Enqueue(New Point(i, j)) : Visited(i, j) = True
        While Q.Count > 0
            Dim p As Point = Q.Dequeue() : Region.Append(p)
            For k = 0 To 3
                i = p.X + dx(k) : j = p.Y + dy(k)
                If i < 0 Or i >= Height Then Continue For
                If j < 0 Or j >= Width Then Continue For
                If Pixes(i, j).R < th And Visited(i, j) = False Then
                    Q.Enqueue(New Point(i, j)) : Visited(i, j) = True
                End If
            Next
        End While
        Return Region
    End Function

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

    Function GetBuff(ByVal Width As Integer, ByVal Height As Integer, ByVal bkcolor As Color, ByVal ftcolor As Color) As Bitmap
        Dim newbuff As New Bitmap(Width, Width)  ' Height
        For i = 0 To Height - 1
            For j = 0 To Width - 1
                newbuff.SetPixel(j, i, bkcolor)
            Next
        Next
        For i = 0 To Regions.Count - 1
            For j = 0 To Regions(i).Count - 1
                Dim p As Point = Regions(i).Item(j)
                newbuff.SetPixel(p.X, p.Y, ftcolor)
            Next
        Next
        Return newbuff
    End Function
End Class
