Public Class clsShutter
    Public Enum ShutterKind
        Vertical
        Horizontal
    End Enum

    Private WithEvents Ticker As Timer
    Private Source, Target As Bitmap
    Private picCanvas As PictureBox
    Private Kind As ShutterKind

    Public Sub New(picfname As String, picCanvas As PictureBox)
        Me.Source = New Bitmap(picfname)   ' 在图像计算中，用作数据源
        Me.Target = New Bitmap(Source.Width, Source.Height)  ' 用于显示,暂时为空

        Me.picCanvas = picCanvas
        Me.picCanvas.Image = Target     ' Bitmap是Image(虚类)的子类
        Me.picCanvas.Width = Target.Width
        Me.picCanvas.Height = Target.Height

        Me.Ticker = New Timer
        Me.Ticker.Enabled = False
    End Sub

    Public Sub Open(Interval As Integer, kind As ShutterKind)
        Me.Kind = kind
        Me.Ticker.Interval = Interval
        Me.Ticker.Enabled = True
    End Sub

    Private Sub Ticker_Tick(sender As Object, e As System.EventArgs) Handles Ticker.Tick
        Const dx As Integer = 5, dy As Integer = 5
        If Kind = ShutterKind.Vertical Then DisplayVertical(dx)
        If Kind = ShutterKind.Horizontal Then DisplayHorizontal(dy)
        picCanvas.Refresh()
    End Sub
    Private Sub DisplayHorizontal(dy As Integer)
        Static yStart As Integer = 0
        If yStart >= Source.Height Then
            yStart = 0 : Ticker.Enabled = False
        End If
        For y = yStart To yStart + dy - 1
            If y >= Source.Height Then Exit For
            For x = 0 To Source.Width - 1
                Dim c As Color = Source.GetPixel(x, y)
                Target.SetPixel(x, y, c)
            Next
        Next
        yStart += dy
    End Sub

    Private Sub DisplayVertical(dx As Integer)
        Static xStart As Integer = 0
        If xStart >= Source.Width Then
            xStart = 0 : Ticker.Enabled = False
        End If
        For x = xStart To xStart + dx - 1
            If x >= Source.Width Then Exit For
            For y = 0 To Source.Height - 1
                Dim c As Color = Source.GetPixel(x, y)
                Target.SetPixel(x, y, c)
            Next
        Next
        xStart += dx
    End Sub

End Class
