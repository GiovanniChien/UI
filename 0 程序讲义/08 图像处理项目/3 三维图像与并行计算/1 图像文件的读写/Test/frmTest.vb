Imports System.Drawing

Public Class frmTest
    Dim path As String
    Dim Source, Target As Bitmap

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        path = My.Application.Info.DirectoryPath
        path = path & "\Tif\"
    End Sub
    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim xyBitmapFile As String = path & "00000.tif"
        Source = New Bitmap(xyBitmapFile)
        picCanvas.Image = Source
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Target = New Bitmap(Source.Width, Source.Height)
        For i = 0 To Source.Width - 1
            For j = 0 To Source.Height - 1
                Dim pcolor As Color = Source.GetPixel(i, j)
                Target.SetPixel(i, j, pcolor)
            Next
        Next
        Target.Save(path & "0000a.tif")
    End Sub

End Class
