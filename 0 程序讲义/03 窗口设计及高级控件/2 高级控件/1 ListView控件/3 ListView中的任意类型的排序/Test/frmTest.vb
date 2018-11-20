Imports System.IO

Public Class frmTest
    Dim Files As clsFiles

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListView_Init()
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        txtPath.Text = GetFolder()
        Files = New clsFiles(txtPath.Text)
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
        ListView1.Sorting = SortOrder.None
    End Sub

    '通过 IComparer 接口对项进行排序，并使用 ArrayList 的 Sort 方法。
    Private Sub ListView1_ColumnClick(sender As System.Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        Dim Columnid As Integer = e.Column
        Files.Sort(Columnid)
        ListView1.Items.Clear()
        ListView1.Items.AddRange(Files.items)
    End Sub
End Class

