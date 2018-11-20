Public Class frmTest

    Dim Words() As String = {"abcde", "bed", "cash"}

    Private Sub txtContent_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtContent.KeyPress
        Dim lastchar As Char = txtContent.Text(txtContent.SelectionStart - 1)  '上一个字符
        Me.Text = lastchar
        Dim k As Integer = Find(e.KeyChar)
        If k <> -1 Then
            e.KeyChar = ""
            txtContent.SelectedText = Words(k) & " "
        End If
    End Sub

    Function Find(keychar As Char) As Integer
        For i = 0 To Words.Count - 1
            If Words(i).Substring(0, 1) = keychar Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub txtContent_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtContent.KeyDown

    End Sub
End Class

