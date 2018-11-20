Public Class frmTest
    Dim Ops As clsOps

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Ops = New clsOps(txtContent)
    End Sub

    ' 识别Delete键
    Private Sub txtContent_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtContent.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim Op1 As clsOp = New clsDeleteOp(txtContent.SelectionStart, txtContent.SelectionLength, txtContent.SelectedText)
            Ops.Add(Op1)
            lstOp.Items.Add(Op1.ToString)
        End If
    End Sub

    ' 识别一般按键和BackSpace键
    ' 不能处理汉字，因为每个汉字引发两次事件
    Private Sub txtContent_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtContent.KeyPress
        Dim Op1 As clsOp
        If txtContent.SelectedText = "" Then
            If Asc(e.KeyChar) = Keys.Back Then
                Dim delchars As String = txtContent.Text.Substring(txtContent.SelectionStart - 1, 1)
                Op1 = New clsDeleteOp(txtContent.SelectionStart - 1, 1, delchars)
            Else
                Op1 = New clsInsertOp(txtContent.SelectionStart, e.KeyChar)
            End If
        Else
            If Asc(e.KeyChar) = Keys.Back Then
                Op1 = New clsDeleteOp(txtContent.SelectionStart, txtContent.SelectionLength, txtContent.SelectedText)
            Else
                Op1 = New clsUpdateOp(txtContent.SelectionStart, txtContent.SelectionLength, txtContent.SelectedText, e.KeyChar)
            End If
        End If
        Ops.Add(Op1)
        lstOp.Items.Add(Op1.ToString)
    End Sub

    Private Sub btnRedo_Click(sender As System.Object, e As System.EventArgs) Handles btnRedo.Click
        Ops.Redo()
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndo.Click
        Ops.Undo()
    End Sub
End Class
