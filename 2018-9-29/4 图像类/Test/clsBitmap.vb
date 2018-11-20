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
        Dim regions As New clsRegions(Pixes, th)
        Dim newbuff As Bitmap = regions.GetBuff(buff.Width, buff.Width, Color.Black, Color.Blue)
        picCanvas.Image = newbuff
    End Sub
End Class
