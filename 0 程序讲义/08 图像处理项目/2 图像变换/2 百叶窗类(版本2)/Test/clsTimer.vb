Public Class clsTimer
    Private g As Graphics
    Private Image As Bitmap
    Private Kind As SlideKind, BlockCount As Integer, TimeInterval As Integer
    Private Timer As Timer

    Public Sub New(g As Graphics, Image As Bitmap, Kind As SlideKind, blockCount As Integer, TimeInterval As Integer)
        Me.g = g
        Me.Image = Image
        Me.Kind = Kind
        Me.BlockCount = blockCount
        Me.Timer = New Timer
        Timer.Enabled = False
        Timer.Interval = TimeInterval
        AddHandler Timer.Tick, AddressOf TimerTick
    End Sub

    Sub Slide()
        Timer.Enabled = True
    End Sub

    Private Sub TimerTick(sender As Timer, e As EventArgs)
        Static iBlock As Integer = 0
        If iBlock > BlockCount Then
            Timer.Enabled = False : Timer = Nothing
            Return
        End If
        '显示image的第iBlock块的图像
        Dim rect As Rectangle
        If Kind = SlideKind.Up2Down Then
            Dim dy As Integer = Image.Height / BlockCount
            rect = New Rectangle(0, dy * iBlock, Image.Width, dy)
        End If
        If Kind = SlideKind.Left2Right Then
            Dim dx As Integer = Image.Width / BlockCount
            rect = New Rectangle(dx * iBlock, 0, dx, Image.Height)
        End If
        g.DrawImage(Image, rect, rect, GraphicsUnit.Pixel)
        iBlock += 1
    End Sub


End Class
