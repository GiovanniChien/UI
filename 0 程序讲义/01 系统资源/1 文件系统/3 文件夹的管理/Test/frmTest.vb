Imports System.IO

Public Class frmTest
    Dim PathName As String  '当前路径

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        PathName = GetFolder()
        If PathName = "" Then Exit Sub
        DisplayPath()
    End Sub

    Private Sub btnOp_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click, btnCopy.Click, btnMove.Click
        If lstFile.SelectedIndex = -1 Then Exit Sub
        Dim k As Integer = lstFile.SelectedIndex
        Dim fname As String = lstFile.Items(k)
        If sender Is btnDelete Then
            File.Delete(fname)
            DisplayPath()
        End If
        If sender Is btnCopy Then
            File.Copy(fname, "D:\1.slc", True)
        End If
        If sender Is btnMove Then
            File.Move(fname, fname & "a")  '改名的效果
            DisplayPath()
        End If
    End Sub

    Sub DisplayPath()
        Dim files() As String = Directory.GetFiles(PathName)
        lstFile.Items.Clear()
        For i = 0 To files.Count - 1
            lstFile.Items.Add(files(i))
        Next
    End Sub

    Public Function GetFolder() As String
        Static dlg As New FolderBrowserDialog
        dlg.ShowNewFolderButton = True
        If dlg.ShowDialog() = DialogResult.OK Then
            Return dlg.SelectedPath
        Else
            Return ""
        End If
    End Function

    Private Sub lstFile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFile.SelectedIndexChanged

    End Sub
End Class
