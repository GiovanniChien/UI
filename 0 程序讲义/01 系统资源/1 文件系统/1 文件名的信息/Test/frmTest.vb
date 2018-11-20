Imports System.IO

Public Class frmTest

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim FilePathName As String = GetOpenFileName("文档文件(*.doc)|*.doc")
        If FilePathName = "" Then Return
        txtFilePathName.Text = FilePathName
        txtDirectoryName.Text = Path.GetDirectoryName(FilePathName)
        txtFileNameWithoutExtension.Text = Path.GetFileNameWithoutExtension(FilePathName)
        txtExtension.Text = Path.GetExtension(FilePathName)
    End Sub

    '保证用户指定一个合法的用于打开的文件名
    Public Function GetOpenFileName(ByVal filekind As String) As String
        Dim dlg As New SaveFileDialog
        dlg.CheckPathExists = True
        dlg.CheckFileExists = True
        dlg.Filter = filekind
        If dlg.ShowDialog() = DialogResult.OK Then
            Return dlg.FileName
        Else
            Return ""
        End If
    End Function
End Class

