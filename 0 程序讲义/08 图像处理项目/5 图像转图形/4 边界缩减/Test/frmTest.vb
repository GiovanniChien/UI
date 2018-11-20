Public Class frmTest
    Dim BitmapModifier As clsBitmapModifier  ' 区域集合对象
    Dim Regions As clsRegions  ' 区域集合对象
    Dim Borders As clsBorders  ' 区域边界集合对象

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        '区域内点的颜色范围
        Dim red As Tuple(Of Integer, Integer) = New Tuple(Of Integer, Integer)(txtRedmin.Text, txtRedmax.Text)
        Dim green As Tuple(Of Integer, Integer) = New Tuple(Of Integer, Integer)(txtGreenmin.Text, txtGreenmax.Text)
        Dim blue As Tuple(Of Integer, Integer) = New Tuple(Of Integer, Integer)(txtBluemin.Text, txtBluemax.Text)
        BitmapModifier = New clsBitmapModifier("a1.jpg", red, green, blue, Color.Black)  ' 区域集合对象
        picCanvas.Image = BitmapModifier.SourceBuff
    End Sub

    Private Sub btnSource_Click(sender As System.Object, e As System.EventArgs) Handles btnSource.Click, btnTarget.Click
        If sender Is btnSource Then picCanvas.Image = BitmapModifier.SourceBuff
        If sender Is btnTarget Then picCanvas.Image = BitmapModifier.TargetBuff
        picCanvas.Refresh()
    End Sub

    Private Sub btnRegions_Click(sender As System.Object, e As System.EventArgs) Handles btnGetRegions.Click
        Regions = BitmapModifier.GetRegions()
        Regions.FillList(lstRegion)
        Regions.Draw(picCanvas.Image, Color.Blue)
        picCanvas.Refresh()
    End Sub

    Private Sub lstRegion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstRegion.SelectedIndexChanged
        If lstRegion.SelectedIndex = -1 Or lstRegion.SelectedIndex = 0 Then Exit Sub
        Dim k As Integer = lstRegion.SelectedIndex - 1
        Regions.Item(k).Draw(picCanvas.Image, Color.Red)
        picCanvas.Refresh()
    End Sub

    Private Sub btnBorders_Click(sender As System.Object, e As System.EventArgs) Handles btnGetBorders.Click
        Borders = Regions.GetBorders(picCanvas.Image)
        Borders.FillList(lstBorder)
        Borders.Draw(picCanvas.Image, Color.Red)
        picCanvas.Refresh()
    End Sub

    Private Sub lstBorder_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstBorder.SelectedIndexChanged
        If lstBorder.SelectedIndex = -1 Or lstBorder.SelectedIndex = 0 Then Exit Sub
        Dim k As Integer = lstBorder.SelectedIndex - 1
        Borders.Item(k).Draw(picCanvas.Image, Color.Red)
        picCanvas.Refresh()
    End Sub

    Private Sub btnDisplayOrderPoints_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplayOrderPoints.Click
        If lstBorder.SelectedIndex = -1 Or lstBorder.SelectedIndex = 0 Then Exit Sub
        Dim k As Integer = lstBorder.SelectedIndex - 1
        Dim OrderPointSets As clsOrderPointSets = Borders.Item(k).GetOrderPointSets()
        'txtOrderPoints.Text = OrderPointSets.ToString
        txtOrderPoints.Text = OrderPointSets.Fit()
    End Sub
End Class
