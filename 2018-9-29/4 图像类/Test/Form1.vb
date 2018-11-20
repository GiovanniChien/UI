Imports System.IO
Public Class Form1
    Dim obj As clsBitmap
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        obj = New clsBitmap("F:\0人机交互技术\00 课堂程序\9-29\a1.bmp")
        obj.Display(PictureBox1)
    End Sub

    Private Sub btnDisplayRegion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayRegion.Click
        obj.DisplayRegion(PictureBox1)
    End Sub
End Class
