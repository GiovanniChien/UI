Imports System.IO
Imports Tools

Public Class frmTest

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Dim FileName As String = GetOpenFileName("所有文件(*.*)|*.*")
        If FileName = "" Then Return
        txtFileName.Text = FileName
        Me.Icon = clsFileHelper.GetFileIcon(FileName)
        Me.Text = clsFileHelper.GetFileType(filename)
    End Sub

    '保证用户指定一个合法的用于打开的文件名
    Public Function GetOpenFileName(ByVal filekind As String) As String
        Dim dlg As New OpenFileDialog
        dlg.CheckFileExists = False
        dlg.Filter = filekind
        If dlg.ShowDialog() = DialogResult.OK Then
            Return dlg.FileName
        Else
            Return ""
        End If
    End Function

End Class
