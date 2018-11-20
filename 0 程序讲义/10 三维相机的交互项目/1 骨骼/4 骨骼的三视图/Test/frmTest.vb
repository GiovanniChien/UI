Imports System.IO

Public Class frmTest
    Dim skeleton As clsSkeleton

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        skeleton = Nothing
    End Sub

    Private Sub mnuFileOpen_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileOpen.Click
        Dim fname As String = My.Application.Info.DirectoryPath & "\d\1s.txt"
        skeleton = New clsSkeleton(fname)
        skeleton.Draw(picCanvas)
    End Sub

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        End
    End Sub

    Private Sub frmTest_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If skeleton Is Nothing Then Exit Sub
        skeleton.Draw(picCanvas)
    End Sub
End Class
