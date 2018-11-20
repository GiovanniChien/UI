Imports System.IO

Public Class frmTest
    Public WithEvents Watcher As FileSystemWatcher
    Delegate Sub DeleCreateFile(filename As String)
    Delegate Sub DeleRemoveFile(filename As String)
    Delegate Sub DeleRenameFile(oldfilename As String, newfilename As String)

    Dim opCreate As DeleCreateFile
    Dim opRemove As DeleRemoveFile
    Dim opRename As DeleRenameFile

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        opCreate = New DeleCreateFile(AddressOf Me.CreateFile)
        opRemove = New DeleRemoveFile(AddressOf Me.RemoveFile)
        opRename = New DeleRenameFile(AddressOf Me.RenameFile)
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim PathName As String = GetFolder()
        If PathName = "" Then Return
        txtPathName.Text = PathName
        Watcher = New FileSystemWatcher(PathName)
        Watcher.NotifyFilter = NotifyFilters.FileName Or NotifyFilters.DirectoryName
        Watcher.EnableRaisingEvents = True
        DisplayPath(PathName)
    End Sub
    Private Sub DisplayPath(path As String)
        Dim files() As String = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly)
        lstFile.Items.Clear()
        For i = 0 To files.Count - 1
            lstFile.Items.Add(files(i))
        Next
    End Sub
    '增加
    Private Sub Watcher_Created(sender As Object, e As System.IO.FileSystemEventArgs) Handles Watcher.Created
        Dim filename As String = e.FullPath
        Invoke(opCreate, filename)
    End Sub
    Private Sub CreateFile(filename As String)
        lstFile.Items.Add(filename)
    End Sub

    '删除
    Private Sub Watcher_Deleted(sender As Object, e As System.IO.FileSystemEventArgs) Handles Watcher.Deleted
        Dim filename As String = e.FullPath
        Invoke(opRemove, filename)
    End Sub
    Private Sub RemoveFile(filename As String)
        lstFile.Items.Remove(filename)
    End Sub

    '改名
    Private Sub Watcher_Renamed(sender As Object, e As System.IO.RenamedEventArgs) Handles Watcher.Renamed
        Dim oldfilename As String = e.OldFullPath
        Dim newfilename As String = e.FullPath
        Invoke(opRename, New String() {oldfilename, newfilename})
    End Sub
    Private Sub RenameFile(oldfilename As String, newfilename As String)
        Dim k As Integer = lstFile.Items.IndexOf(oldfilename)
        lstFile.Items(k) = newfilename
    End Sub

    Public Function GetFolder() As String
        Static dlg As New FolderBrowserDialog
        dlg.ShowNewFolderButton = True
        If dlg.ShowDialog() = DialogResult.OK Then Return dlg.SelectedPath
        Return ""
    End Function

End Class

