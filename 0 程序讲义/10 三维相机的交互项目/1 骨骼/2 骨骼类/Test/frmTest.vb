Imports System.IO

Public Class frmTest
    Dim skeleton As clsSkeleton

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        skeleton = Nothing
    End Sub
    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim fname As String = My.Application.Info.DirectoryPath & "\d\1s.txt"
        skeleton = New clsSkeleton(fname)
    End Sub

    Private Sub radXY_Click(sender As System.Object, e As System.EventArgs) Handles radXY.Click, radXZ.Click, radYZ.Click
        If skeleton Is Nothing Then Exit Sub
        If radXY.Checked = True Then skeleton.Draw(picCanvas, ViewKind.XY)
        If radXZ.Checked = True Then skeleton.Draw(picCanvas, ViewKind.XZ)
        If radYZ.Checked = True Then skeleton.Draw(picCanvas, ViewKind.YZ)
    End Sub

End Class
