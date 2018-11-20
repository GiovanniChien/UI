Public Class clsImage
    Private Source, Target As Bitmap
    Private picCanvas As PictureBox

    Public Sub New(picfname As String, picCanvas As PictureBox)
        Me.Source = New Bitmap(picfname)   ' 在图像计算中，用作数据源
        Me.Target = New Bitmap(Me.Source)
        Me.picCanvas = picCanvas
        Me.picCanvas.Image = Target : Me.picCanvas.Width = Target.Width : Me.picCanvas.Height = Target.Height
    End Sub

    Public Sub SaveAs(fname As String, format As Imaging.ImageFormat)
        Target.Save(fname, format)
    End Sub

    Public Sub DrawString(text As String, font As Font, p As Point)
        Me.Target = New Bitmap(Me.Source)
        Dim g As Graphics = Graphics.FromImage(Me.Target)
        g.DrawString(text, font, Brushes.Red, p)
        Me.picCanvas.Image = Target
        Me.picCanvas.Refresh()
    End Sub

End Class
