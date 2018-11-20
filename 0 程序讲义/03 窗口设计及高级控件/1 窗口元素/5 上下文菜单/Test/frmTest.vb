Public Class frmTest

    Dim WithEvents MenuOpState As clsMenuOpState

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MenuOpState = New clsMenuOpState
    End Sub

    Private Sub PictureBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MenuOpState.Show(Left + PictureBox1.Left + e.X, Top + PictureBox1.Top + e.Y)
        End If
    End Sub

    Private Sub MenuOpState_FlagChange(ByVal flag As OpState) Handles MenuOpState.FlagChange
        Text = flag.ToString
    End Sub
End Class


