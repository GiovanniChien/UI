Public Class frmTest

    'Dim Words As List(Of String) = New List(Of String)
    Dim WithEvents frm As frmListBox

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frm = New frmListBox
        frm.Hide()
    End Sub

    Private Sub txtContent_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContaint.KeyPress
        Dim K As Integer = txtContaint.SelectionStart
        Dim LOC As Point = txtContaint.GetPositionFromCharIndex(K)
        Dim LastChars As String = GetLastChars()
        frm.Show()
        frm.WordListInit(LastChars & e.KeyChar)
        frm.Location = New Point(Me.Left + LOC.X, Me.Top + LOC.Y + 50)
    End Sub

    Private Function GetLastChars() As String
        Dim Chars As String = ""
        Dim K As Integer = txtContaint.SelectionStart
        While True
            If K = 0 Then Exit While
            Dim lastchar As Char = txtContaint.Text(K - 1)  '上一个字符
            If lastchar = " " Or lastchar = vbLf Then Exit While
            Chars = lastchar & Chars
            K = K - 1
        End While
        Return Chars
    End Function

    Private Sub frm_WordSelected(ByVal Word As String) Handles frm.WordSelected
        txtContaint.SelectedText = Word & " "
    End Sub

    Private Sub frm_CharPress(ByVal C As Char) Handles frm.CharPress
        txtContaint.SelectedText = C
    End Sub


End Class
