Public Class frmTest

    Private Sub UcDigit1_DigitPress(ByVal c As String) Handles UcDigit1.ButtonPress
        Insert(c, False)
    End Sub

    '实现按照括号层次的输入
    Private Sub UcOp1_ButtonPress(c As String, backOne As Boolean) Handles UcOp1.ButtonPress
        Insert(c, backOne)
    End Sub

    Private Sub Insert(ByVal c As String, backOne As Boolean)
        Dim k As Integer = txtContent.SelectionStart
        Dim left As String = txtContent.Text.Substring(0, k)
        Dim right As String = txtContent.Text.Substring(k)
        txtContent.Text = left & c & right
        If backOne = False Then
            txtContent.SelectionStart = k + c.Length
        Else
            txtContent.SelectionStart = k + c.Length - 1
        End If
    End Sub

End Class
