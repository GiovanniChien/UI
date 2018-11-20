Public Class clsFade
    Private WithEvents Ticker As Timer
    Private Source, Target As Bitmap
    Private picCanvas As PictureBox
    Private StepN As Integer

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

    Public Sub Open(Interval As Integer, StepN As Integer)
        Me.StepN = StepN
        Me.Ticker.Interval = Interval
        Me.Ticker.Enabled = True
    End Sub

    Private Sub Ticker_Tick(sender As Object, e As System.EventArgs) Handles Ticker.Tick
        DisplayStep()
        picCanvas.Refresh()
    End Sub
    Private Sub DisplayStep()
        Static Stepi As Integer = 0
        If Stepi >= StepN * StepN Then
            Stepi = 0 : Ticker.Enabled = False
        End If
        Dim x1, y1 As Integer
        For x = 0 To Source.Width - 1 Step StepN
            x1 = x + Fix(Stepi / StepN)
            If x1 >= Source.Width Then Continue For
            For y = 0 To Source.Height - 1 Step StepN
                y1 = y + Stepi Mod StepN
                If y1 >= Source.Height Then Continue For
                Dim c As Color = Source.GetPixel(x1, y1)
                Target.SetPixel(x1, y1, c)
            Next
        Next
        Stepi += 1
    End Sub
End Class
