Public Class frmTest

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'UcDigit.Kind = BeanchKind.Digits
        'UcOp.Kind = BeanchKind.Ops
        Dim digitTexts() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "."}
        UcDigit.InitButtons(digitTexts)
        Dim OpTexts() As String = {"+", "-", "*", "/", "()", "sin()", "sqrt()"}
        UcOp.InitButtons(OpTexts)
    End Sub

    '实现按照括号层次的输入
    Private Sub UcDigit_ButtonPress(c As String, backOne As Boolean) Handles UcDigit.ButtonPress
        Insert(c, backOne)
    End Sub
    Private Sub UcOp_ButtonPress(c As String, backOne As Boolean) Handles UcOp.ButtonPress
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

    Private Sub UcOp_Load(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
