
Public Class frmTest

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim PathName As String = GetFolder()
        If PathName = "" Then Return
        txtPathName.Text = PathName
        Dim Directories As clsDirectory = New clsDirectory(PathName)
        lstFile.Items.Clear()
        Directories.Output(lstFile)
    End Sub

    Public Function GetFolder() As String
        Static dlg As New FolderBrowserDialog
        dlg.ShowNewFolderButton = True
        If dlg.ShowDialog() = DialogResult.OK Then Return dlg.SelectedPath
        Return ""
    End Function
End Class

