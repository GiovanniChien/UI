Public Class frmTest
    Dim image As clsImage

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        image = New clsImage("千与千寻.jpg")
        '原样显示图像
        image.Display(picSource.CreateGraphics)
    End Sub

    Private Sub btnSlide_Click(sender As System.Object, e As System.EventArgs) Handles btnSlide.Click
        picSlide.Image = Nothing
        'image.Slide(picSlide.CreateGraphics, SlideKind.Left2Right, 20, 100)
        image.Slide(picSlide.CreateGraphics, SlideKind.Up2Down, 100, 100)
    End Sub
End Class
