Imports System.Drawing

Public Class frmTest
    Dim path As String
    Dim Bitmaps As clsBitmaps

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        path = My.Application.Info.DirectoryPath
        path = path & "\Tif\"
    End Sub
    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Bitmaps = New clsBitmaps(path)
        Me.Text = Bitmaps.CreateXYZBitmaps()   '计时
        tbXY.Minimum = 0 : tbXY.Maximum = Bitmaps.Nz - 1 : tbXY.Value = 1
        tbXZ.Minimum = 0 : tbXZ.Maximum = Bitmaps.Ny - 1 : tbXZ.Value = 1
        tbYZ.Minimum = 0 : tbYZ.Maximum = Bitmaps.Nx - 1 : tbYZ.Value = 1
    End Sub


    Private Sub tbXY_ValueChanged(sender As Object, e As System.EventArgs) Handles tbXY.ValueChanged, tbXZ.ValueChanged, tbYZ.ValueChanged
        If sender Is tbXY Then picCanvasXY.Image = Bitmaps.GetXYBitmap(tbXY.Value)
        If sender Is tbXZ Then picCanvasXZ.Image = Bitmaps.GetXZBitmap(tbXZ.Value)
        If sender Is tbYZ Then picCanvasYZ.Image = Bitmaps.GetYZBitmap(tbYZ.Value)
    End Sub
End Class
