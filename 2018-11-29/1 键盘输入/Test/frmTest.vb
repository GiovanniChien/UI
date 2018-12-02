Public Class frmTest

    Dim Words As List(Of String) = New List(Of String)

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strWords() As String = {"abcd", "bcd", "cd"}
        Words.AddRange(strWords)
    End Sub


    Private Sub txtContaint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContaint.KeyPress
        Dim lastchar As Char
        If txtContaint.SelectionStart = 0 Then
            lastchar = ""
        Else
            lastchar = txtContaint.Text(txtContaint.SelectionStart - 1)
        End If
        Me.Text = lastchar
        Dim k As Integer = Find(e.KeyChar)
        If k <> -1 Then
            e.KeyChar = ""
            txtContaint.SelectedText = Words(k) & " "
        End If
    End Sub

    Private Function Find(ByVal keychar As Char) As Integer
        For i = 0 To Words.Count - 1
            If Words(i).StartsWith(keychar) Then
                Return i
            End If
        Next
        Return -1
    End Function

End Class
