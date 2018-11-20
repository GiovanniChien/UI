Public Class clsBitmap
    Dim buff As Bitmap
    Dim pixes(,) As Color

    Public Sub New(ByVal filename As String)
        buff = New Bitmap(filename)
        ReDim pixes(buff.Width - 1, buff.Height - 1)
        For i = 0 To buff.Width - 1
            For j = 0 To buff.Height - 1
                pixes(i, j) = buff.GetPixel(i, j)
            Next
        Next
        'ReDim pixes(buff.Height - 1, buff.Width - 1)
        'For i = 0 To buff.Height - 1
        '    For j = 0 To buff.Width - 1
        '        pixes(i, j) = buff.GetPixel(j, i)
        '    Next
        'Next
    End Sub

    Sub display(ByVal pictureBox As PictureBox)
        Dim newBuff As New Bitmap(buff.Width, buff.Height)
        For i = 0 To buff.Width - 1
            For j = 0 To buff.Height - 1
                newBuff.SetPixel(i, j, pixes(i, j))
            Next
        Next
        'For i = 0 To buff.Height - 1
        '    For j = 0 To buff.Width - 1
        '        newBuff.SetPixel(j, i, pixes(i, j))
        '    Next
        'Next
        pictureBox.Image = newBuff
    End Sub

End Class
