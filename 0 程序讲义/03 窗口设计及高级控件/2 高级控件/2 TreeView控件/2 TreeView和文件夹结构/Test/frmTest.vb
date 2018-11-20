Imports System.IO

Public Class frmTest
    Dim DirectoryTree As clsDirectoryTree
    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        txtPath.Text = GetFolder()
        DirectoryTree = New clsDirectoryTree(txtPath.Text)
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add(DirectoryTree.Root)
        TreeView1.ExpandAll()
    End Sub

    Public Function GetFolder() As String
        Static dlg As New FolderBrowserDialog
        dlg.ShowNewFolderButton = True
        If dlg.ShowDialog() = DialogResult.OK Then Return dlg.SelectedPath
        Return ""
    End Function

    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim node As TreeNode = TreeView1.SelectedNode
        txtActiveNode.Text = node.Text
    End Sub

    Private Sub btnManage_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click, btnDelete.Click, btnRename.Click
        Dim node As TreeNode = TreeView1.SelectedNode
        If sender Is btnCreate Then
            DirectoryTree.CreateNode(node, txtCreateFolder.Text)
        End If
        If sender Is btnDelete Then
             DirectoryTree.DeleteFolder(node)
        End If
        If sender Is btnRename Then
            DirectoryTree.RenameFolder(node, txtMoveFolder.Text)
        End If
    End Sub
End Class

