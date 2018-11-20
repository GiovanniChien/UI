Imports System.IO

Public Class frmTest

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim PathName As String = GetFolder()
        If PathName = "" Then Return
        txtPathName.Text = PathName
        Dim files As List(Of String) = GetFiles(PathName)
        'Dim files() As String = Directory.GetDirectories(PathName, "*.*", SearchOption.AllDirectories)
        'Dim files() As String = Directory.GetFiles(PathName, "*.*", SearchOption.AllDirectories)
        lstFile.Items.Clear()
        For i = 0 To files.Count - 1
            lstFile.Items.Add(files(i))
        Next
    End Sub

    Private Function GetFiles(PathName As String) As List(Of String)
        Dim files As List(Of String) = Directory.GetFiles(PathName).ToList
        Dim directories() As String = Directory.GetDirectories(PathName)
        For i = 0 To directories.Count - 1
            Dim directoryfiles As List(Of String) = GetFiles(directories(i)).ToList
            files.AddRange(directoryfiles)
        Next
        Return files
    End Function

    Public Function GetFolder() As String
        Static dlg As New FolderBrowserDialog
        dlg.ShowNewFolderButton = True
        If dlg.ShowDialog() = DialogResult.OK Then Return dlg.SelectedPath
        Return ""
    End Function
End Class

