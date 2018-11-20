Imports System.IO

Public Class frmTest
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        lstInfo.Items.Clear()
        Dim Path As String
        Path = FolderBrowse() '"C:\Data\UI\2018-9-6\test"
        If Path = "" Then
            Return
        End If

        txtPath.Text = Path

        Dim directory As New ClaDirectory(Path)
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
End Class
