Public Class frmTest
    Dim kt As clsKeyTree

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        kt = New clsKeyTree
    End Sub

    Private Sub txtContent_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtContent.TextChanged
        Dim Prefix As String = txtContent.Text
        Dim SelectWords As List(Of String) = kt.SearchbyPrefix(Prefix)
        lstWords.Items.Clear()
        For i = 0 To SelectWords.Count - 1
            lstWords.Items.Add(Prefix & SelectWords(i))
        Next
    End Sub

End Class

