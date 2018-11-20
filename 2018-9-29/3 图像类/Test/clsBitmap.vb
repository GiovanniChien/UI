Public Class clsBitmap
    Dim buff As Bitmap
    Dim Pixes(,) As Color

    Public Sub New(ByVal filename As String)
        buff = New Bitmap(filename)
        ReDim Pixes(buff.Height - 1, buff.Width - 1)
        For i = 0 To buff.Height - 1
            For j = 0 To buff.Width - 1
                Pixes(i, j) = buff.GetPixel(j, i)
            Next
        Next
    End Sub
    Public Sub Display(ByVal picCanvas As PictureBox)
        picCanvas.Image = buff
    End Sub

    Sub DisplayRegion(ByVal picCanvas As PictureBox)
        Dim th As Integer = 250
        Dim Visited(buff.Height - 1, buff.Width - 1) As Boolean
        For i = 0 To buff.Height - 1
            For j = 0 To buff.Width - 1
                Visited(i, j) = False
            Next
        Next
        Dim Regions As New clsRegions
        For i = 0 To buff.Height - 1
            For j = 0 To buff.Width - 1
                If Pixes(i, j).R < th And Visited(i, j) = False Then
                    Dim Region As clsRegion = Bfs(i, j, th, Visited)
                    Regions.Append(Region)
                End If
            Next
        Next
        Dim newbuff As Bitmap = GetBuff(Regions)
        picCanvas.Image = newbuff
    End Sub
    Private Function GetBuff(ByVal Regions As clsRegions) As Bitmap
        Dim newbuff As New Bitmap(buff.Width, buff.Width)  ' Height
        For i = 0 To buff.Height - 1
            For j = 0 To buff.Width - 1
                newbuff.SetPixel(j, i, Color.Black)
            Next
        Next
        For i = 0 To Regions.Count - 1
            Dim r As clsRegion = Regions.Item(i)
            For j = 0 To r.Count - 1
                Dim p As Point = r.Item(j)
                newbuff.SetPixel(p.X, p.Y, Color.Blue)
            Next
        Next
        Return newbuff
    End Function

    Private Function Bfs(ByVal i As Integer, ByVal j As Integer, ByVal th As Integer, ByVal Visited As Boolean(,)) As clsRegion
        Dim dx() As Integer = {-1, 1, 0, 0}
        Dim dy() As Integer = {0, 0, -1, 1}
        Dim Region As New clsRegion
        Dim Q As New Queue(Of Point)
        Q.Enqueue(New Point(i, j)) : Visited(i, j) = True
        While Q.Count > 0
            Dim p As Point = Q.Dequeue() : Region.Append(p)
            For k = 0 To 3
                i = p.X + dx(k) : j = p.Y + dy(k)
                If i < 0 Or i >= buff.Height Then Continue For
                If j < 0 Or j >= buff.Width Then Continue For
                If Pixes(i, j).R < th And Visited(i, j) = False Then
                    Q.Enqueue(New Point(i, j)) : Visited(i, j) = True
                End If
            Next
        End While
        Return Region
    End Function

End Class
