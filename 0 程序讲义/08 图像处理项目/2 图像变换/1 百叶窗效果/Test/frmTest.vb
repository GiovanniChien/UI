Public Class frmTest
    Private WithEvents Timer1 As System.Windows.Forms.Timer
    Dim Source, Target As Bitmap

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim Fname As String = "Tulips.jpg"
        Source = New Bitmap(Fname)   ' 在图像计算中，用作数据源
        Target = New Bitmap(Source.Width, Source.Height)  ' 用于显示,暂时为空
        picCanvas.Image = Target     ' Bitmap是Image(虚类)的子类
        picCanvas.Width = Target.Width
        picCanvas.Height = Target.Height

        Timer1 = New System.Windows.Forms.Timer
        Timer1.Interval = 50
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        Const dx As Integer = 5, dy As Integer = 5
        If RadioVertical.Checked = True Then DisplayVertical(dx)
        If RadioHorizontal.Checked = True Then DisplayHorizontal(dy)
        picCanvas.Refresh()
    End Sub

    Private Sub DisplayHorizontal(dy As Integer)
        Static yStart As Integer = 0
        If yStart >= Source.Height Then
            yStart = 0 : Timer1.Enabled = False
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
            xStart = 0 : Timer1.Enabled = False
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

    Private Sub picCanvas_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If picCanvas.Image Is Nothing Then Exit Sub
        Dim p As Point = e.Location
        Dim c As Color = Target.GetPixel(p.X, p.Y)
        Me.Text = c.R & "," & c.G & "," & c.B
    End Sub
End Class
