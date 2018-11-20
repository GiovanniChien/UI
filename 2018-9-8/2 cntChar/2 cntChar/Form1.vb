Public Class Form1
    Private Sub txtBox_TextChanged(sender As Object, e As EventArgs) Handles txtBox.TextChanged
        UpdateLblResult()
    End Sub

    Private Sub UpdateLblResult()
        If radCountChar.Checked Then
            Dim intChar As Integer
            intChar = CountCharacter(txtBox.Text)
            lblResult.Text = intChar & " characters"
        Else
            Dim intWord As Integer
            intWord = CountWord(txtBox.Text)
            lblResult.Text = intWord & " words"
        End If
    End Sub

    Private Function CountWord(text As String) As Integer
        If text.Length = 0 Then Return 0

        Dim strWords() As String
        strWords = text.Split(" "c)
        Return strWords.Length
    End Function

    Private Function CountCharacter(text As String) As Integer
        Return text.Length
    End Function
End Class
