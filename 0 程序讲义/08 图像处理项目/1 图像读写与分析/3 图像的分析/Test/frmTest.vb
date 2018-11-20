Public Class frmTest
    Dim Fname As String
    Dim Source, Target As Bitmap

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Fname = "Tulips.jpg"
        Source = New Bitmap(Fname)   ' 在图像计算中，用作数据源
        Target = New Bitmap(Source)  ' 用于显示
        picCanvas.Image = Target  'Bitmap是Image(虚类)的子类
        picCanvas.Width = Target.Width
        picCanvas.Height = Target.Height
    End Sub

    Private Sub picCanvas_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If Source Is Nothing Then Exit Sub
        Dim p As Point = e.Location
        Dim pc As Color = Target.GetPixel(p.X, p.Y)
        txtRed.Text = pc.R
        txtGreen.Text = pc.G
        txtBlue.Text = pc.B

        ' “色调-饱和度-亮度”(HSB)
        Dim hue As Single = pc.GetHue()               ' 色调值，以度为单位[0,360]。
        Dim saturation As Single = pc.GetSaturation() ' 饱和度值[0,1]。
        Dim brightness As Single = pc.GetBrightness() ' 亮度值[0,1]。
        txtHue.Text = hue
        txtSaturation.Text = saturation
        txtBrightness.Text = brightness

        ' CMY
        Dim C1 As Integer = 255 - pc.R
        Dim M1 As Integer = 255 - pc.G
        Dim Y1 As Integer = 255 - pc.B
        txtC1.Text = C1
        txtM1.Text = M1
        txtY1.Text = Y1
        ' CMYK
        Dim K As Integer = Math.Min(C1, Math.Min(M1, Y1))
        Dim C As Integer = C1 - K
        Dim M As Integer = M1 - K
        Dim Y As Integer = Y1 - K
        txtC.Text = C
        txtM.Text = M
        txtY.Text = Y
        txtK.Text = K
    End Sub

    Private Sub btnChangeColor_Click(sender As System.Object, e As System.EventArgs) Handles btnChangeColor.Click
        Dim choice As Integer
        If rdRed.Checked Then choice = 1
        If rdGreen.Checked Then choice = 2
        If rdBlue.Checked Then choice = 3
        If rdGray.Checked Then choice = 4
        For i = 0 To Source.Width - 1
            For j = 0 To Source.Height - 1
                Dim oldcolor As Color = Source.GetPixel(i, j)
                Dim newcolor As Color
                If choice = 1 Then newcolor = Color.FromArgb(oldcolor.R, 0, 0)
                If choice = 2 Then newcolor = Color.FromArgb(0, oldcolor.G, 0)
                If choice = 3 Then newcolor = Color.FromArgb(0, 0, oldcolor.B)
                If choice = 4 Then
                    Dim gray As Integer = oldcolor.R
                    gray = (gray + oldcolor.G + oldcolor.R) / 3
                    newcolor = Color.FromArgb(gray, gray, gray)
                End If
                Target.SetPixel(i, j, newcolor)
            Next
        Next
        picCanvas.Refresh()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim Fname1 As String = "Tulips1.jpg"
        Target.Save(Fname1)
    End Sub

    Private Sub btnTJ_Click(sender As System.Object, e As System.EventArgs) Handles btnTJ.Click
        Dim ds As List(Of DateSerial)
        ds = New List(Of DateSerial)
        Dim ds1, ds2, ds3 As DateSerial
        ds1.Title = "R分析" : ds1.XTitle = "R分量" : ds1.YTitle = "像素个数"
        ds2.Title = "G分析" : ds2.XTitle = "G分量" : ds2.YTitle = "像素个数"
        ds3.Title = "B分析" : ds3.XTitle = "B分量" : ds3.YTitle = "像素个数"
        ReDim ds1.Data(255), ds2.Data(255), ds3.Data(255)
        Dim bitmap As clsBitmap = New clsBitmap(Target)
        bitmap.GetRGBs(ds1.Data, ds2.Data, ds3.Data)
        ds.Add(ds1) : ds.Add(ds2) : ds.Add(ds3)
        Dim Chart As clsChart = New clsChart(ChartRGB)
        Chart.Draw("RGB分析", ds)
    End Sub
End Class
