Imports System.IO

Public Class frmTest

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim PathName As String = GetFolder()
        If PathName = "" Then Return
        txtPathName.Text = PathName

        lstFile.Items.Clear()
        Dim directories() As String = Directory.GetDirectories(PathName)
        For i = 0 To directories.Count - 1
            lstFile.Items.Add(directories(i))
        Next
        Dim files() As String = Directory.GetFiles(PathName)
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

End Class

