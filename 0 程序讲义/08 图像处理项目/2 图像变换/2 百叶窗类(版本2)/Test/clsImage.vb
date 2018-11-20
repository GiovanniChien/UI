Public Enum SlideKind
    Left2Right
    Up2Down
End Enum

Public Class clsImage
    Private fname As String, Image As Bitmap
    Public Sub New(fname As String)
        Me.fname = fname
        Image = New Bitmap(fname)
    End Sub
    Public Sub Save(fname As String, format As Imaging.ImageFormat)
        Image.Save(fname, format)
    End Sub

    Public Sub Display(g As Graphics)
        g.DrawImage(Image, New Rectangle(0, 0, Image.Width, Image.Height))
    End Sub
    Public Sub Display(g As Graphics, destRect As Rectangle, sourceRect As Rectangle)
        g.DrawImage(Image, destRect, sourceRect, GraphicsUnit.Pixel)
    End Sub
    '3点决定一个平行四边形
    Public Sub Display(g As Graphics, p1 As Point, p2 As Point, p3 As Point)
        g.DrawImage(Image, {p1, p2, p3})
    End Sub

    ReadOnly Property Width() As Integer
        Get
            Return Image.Width
        End Get
    End Property
    ReadOnly Property Height() As Integer
        Get
            Return Image.Height
        End Get
    End Property

    Public Sub AddString(s As String, font As Font, p As Point)
        Dim g As Graphics = Graphics.FromImage(Me.Image)
        g.DrawString(s, font, Brushes.Red, p)
        g.DrawLine(Pens.Black, 0, 0, 100, 100)
        g.Dispose() '释放
    End Sub

    Public Sub Slide(g As Graphics, Kind As SlideKind, blockCount As Integer, TimeInterval As Integer)
        Dim Timer As clsTimer
        Timer = New clsTimer(g, Image, Kind, blockCount, TimeInterval)
        Timer.Slide()
    End Sub




End Class
