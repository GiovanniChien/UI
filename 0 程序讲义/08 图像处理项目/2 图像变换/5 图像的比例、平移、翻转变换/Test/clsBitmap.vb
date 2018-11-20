Imports System.Drawing.Drawing2D

Public Class clsBitmap
    Private Source, Target As Bitmap
    Private picCanvas As PictureBox

    Public Sub New(picfname As String, picCanvas As PictureBox)
        Me.Source = New Bitmap(picfname)   ' 在图像计算中，用作数据源
        Me.Target = New Bitmap(Me.Source)
        Me.picCanvas = picCanvas
        Me.picCanvas.Image = Target : Me.picCanvas.Width = Target.Width : Me.picCanvas.Height = Target.Height
    End Sub

    Public Sub Scale(ScaleX As Single, ScaleY As Single)
        Dim g As Graphics = Graphics.FromImage(Target)
        'g.InterpolationMode = InterpolationMode.High ' 设置高质量插值法   
        'g.SmoothingMode = SmoothingMode.AntiAlias    ' 消除锯齿 
        Dim sourceRect As Rectangle = New Rectangle(0, 0, Source.Width, Source.Height)
        Dim w As Integer = Source.Width * ScaleX, h As Integer = Source.Height * ScaleY
        Dim destRect As Rectangle = New Rectangle(0, 0, w, h)
        g.DrawImage(Source, destRect, sourceRect, GraphicsUnit.Pixel)
        Me.picCanvas.Width = w : Me.picCanvas.Height = h
        Me.picCanvas.Refresh()
    End Sub

    Public Sub Rotate()
        Target.RotateFlip(RotateFlipType.Rotate90FlipNone) '顺时针旋转
        Me.picCanvas.Width = Target.Width : Me.picCanvas.Height = Target.Height
        Me.picCanvas.Refresh()
    End Sub

End Class
