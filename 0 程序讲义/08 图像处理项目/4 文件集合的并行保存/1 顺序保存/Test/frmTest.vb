Imports System.Drawing

Public Class frmTest
    Dim path As String
    Dim WithEvents Bitmaps As clsBitmaps

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        path = My.Application.Info.DirectoryPath
        path = path & "\Tif\"
    End Sub
    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Bitmaps = New clsBitmaps(path)
    End Sub

    Private Sub tbXY_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbXY.ValueChanged
        picCanvasXY.Image = Bitmaps.GetBitmap(tbXY.Value)
    End Sub

    ' 在漫长的保存过程中，界面不能响应事件
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        path = My.Application.Info.DirectoryPath
        path = path & "\Tif\Bitmaps\"
        Bitmaps.Save(path)
    End Sub

    Private Sub Bitmaps_SaveBegin(Total As Integer) Handles Bitmaps.SaveBegin
        pbProgress1.Min = 0 : pbProgress1.Max = Total - 1
        pbProgress1.Value = 0
    End Sub
    Private Sub Bitmaps_SaveProgress(ith As Integer) Handles Bitmaps.SaveProgress
        pbProgress1.Value = ith
    End Sub
    Private Sub Bitmaps_SaveEnd() Handles Bitmaps.SaveEnd
        pbProgress1.Value = 0
    End Sub

End Class
