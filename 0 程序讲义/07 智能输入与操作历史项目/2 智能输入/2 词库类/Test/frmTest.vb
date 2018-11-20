Public Class frmTest
    Dim WithEvents frm As frmListBox

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        frm = New frmListBox
        frm.Hide()
    End Sub

    Private Sub txtContent_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtContent.KeyPress
        Dim K As Integer = txtContent.SelectionStart
        Dim LOC As Point = txtContent.GetPositionFromCharIndex(K)
        Dim LastChars As String = GetLastChars()
        frm.Show()
        frm.WordListInit(LastChars & e.KeyChar)
        frm.Location = New Point(Me.Left + LOC.X, Me.Top + LOC.Y + 50)
    End Sub

    Private Function GetLastChars() As String
        Dim Chars As String = ""
        Dim K As Integer = txtContent.SelectionStart
        While True
            If K = 0 Then Exit While
            Dim lastchar As Char = txtContent.Text(K - 1)  '上一个字符
            If lastchar = " " Or lastchar = vbLf Then Exit While
            Chars = lastchar & Chars
            K = K - 1
        End While
        Return Chars
    End Function

    Private Sub frm_WordSelected(Word As String) Handles frm.WordSelected
        txtContent.SelectedText = Word & " "
    End Sub

    Private Sub frm_CharPress(C As Char) Handles frm.CharPress
        txtContent.SelectedText = C
    End Sub


End Class

