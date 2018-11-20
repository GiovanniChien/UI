Imports System.IO

Public Class frmTest

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListView_Init()
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        txtPath.Text = GetFolder()
        Dim Directory As clsDirectory = New clsDirectory(txtPath.Text)
        TreeView1.Nodes.Add(Directory.Root)
        TreeView1.SelectedNode = Directory.Root
    End Sub
    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        '！！！ 取文件集合对象
        Dim Files As clsFiles = TreeView1.SelectedNode.Tag
        ListView1.Items.Clear()
        ListView1.Items.AddRange(Files.items)
    End Sub

    Public Function GetFolder() As String
        Static dlg As New FolderBrowserDialog
        dlg.ShowNewFolderButton = True
        If dlg.ShowDialog() = DialogResult.OK Then Return dlg.SelectedPath
        Return ""
    End Function

    Private Sub ListView_Init()
        Dim ColumnHeaders As ListView.ColumnHeaderCollection
        ColumnHeaders = New ListView.ColumnHeaderCollection(ListView1)
        ColumnHeaders.Add("名称")
        ColumnHeaders.Add("日期")
        ColumnHeaders.Add("类型")
        ColumnHeaders.Add("大小")
        ListView1.View = View.Details
        ListView1.LabelEdit = True
        ListView1.AllowColumnReorder = True
        ListView1.CheckBoxes = False
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Sorting = SortOrder.Ascending
    End Sub



End Class

