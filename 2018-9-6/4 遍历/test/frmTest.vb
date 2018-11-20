Imports System.IO

Public Class frmTest
    Dim directory As ClaDirectory
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        lstInfo.Items.Clear()
        Dim Path As String
        Path = FolderBrowse() '"C:\Data\UI\2018-9-6\test"
        If Path = "" Then
            Return
        End If

        txtPath.Text = Path

        directory = New ClaDirectory(Path)
        directory.Display(lstInfo)

    End Sub

    Private Function FolderBrowse() As String
        Dim dlg As New FolderBrowserDialog
        Dim DS As DialogResult
        DS = dlg.ShowDialog()
        If (DS = DialogResult.OK) Then
            Return dlg.SelectedPath
        Else
            Return ""
        End If
    End Function

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Text = directory.Depth()
        'Text = directory.Count()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim res As List(Of String) = directory.Search(txtSearch.Text)
        lstInfo.Items.Clear()
        For i = 0 To res.Count - 1
            lstInfo.Items.Add(res(i))
        Next
    End Sub
End Class
