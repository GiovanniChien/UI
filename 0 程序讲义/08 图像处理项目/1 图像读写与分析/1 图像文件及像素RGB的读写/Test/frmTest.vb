Public Class frmTest
    Dim Fname As String
    Dim Source, Target As Bitmap

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Fname = "Tulips.jpg"
        Source = New Bitmap(Fname)   ' 在图像计算中，用作数据源
        Target = New Bitmap(Source)  ' 用于显示
        picCanvas.Image = Target     ' Bitmap是Image(虚类)的子类
        picCanvas.Width = Target.Width
        picCanvas.Height = Target.Height
    End Sub

    Private Sub picCanvas_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If Source Is Nothing Then Exit Sub
        Dim p As Point = e.Location
        Dim c As Color = Target.GetPixel(p.X, p.Y)
        txtRed.Text = c.R
        txtGreen.Text = c.G
        txtBlue.Text = c.B
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
End Class
