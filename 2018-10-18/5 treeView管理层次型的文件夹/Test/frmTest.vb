Imports System.IO

Public Class frmTest

    Dim Directory As clsDirectory
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim path As String
        path = GetFolder ' "F:\0人机交互技术\0 程序讲义\00 课堂程序\9-6\Test"
        Directory = New clsDirectory(path)
        tvDirectory.Nodes.Add(Directory.Node)
    End Sub

    Private Function GetFolder() As String
        Dim dlg As New FolderBrowserDialog
        Dim res As DialogResult = dlg.ShowDialog()
        If res = Windows.Forms.DialogResult.OK Then
            Return dlg.SelectedPath
        Else
            Return ""
        End If
    End Function

End Class
