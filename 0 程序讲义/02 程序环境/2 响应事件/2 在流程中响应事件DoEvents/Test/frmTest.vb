Public Class frmTest

    Dim WithEvents worker As clsWorker

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        worker = New clsWorker
        ProgressBar1.Visible = False
    End Sub
    Private Sub DoWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoWork.Click
        worker.Run(400)
    End Sub

    Private Sub worker_Start(si As Integer, ei As Integer) Handles worker.Start
        ProgressBar1.Visible = True
        ProgressBar1.Minimum = si
        ProgressBar1.Maximum = ei
        ProgressBar1.Value = si
    End Sub
    Private Sub worker_Progress(i As Integer) Handles worker.Progress
        ProgressBar1.Value = i
    End Sub
    Private Sub worker_Complete() Handles worker.Complete
        ProgressBar1.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub frmTest_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("是否退出", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class

