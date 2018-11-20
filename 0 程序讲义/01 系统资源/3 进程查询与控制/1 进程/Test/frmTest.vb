
Public Class frmTest
    Dim Processes As clsProcesses
    Private Sub btnDisplayProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayProc.Click
        Processes = New clsProcesses
        Processes.ListView_Init(lvProcess)
        Processes.ListView_Display(lvProcess)
    End Sub

    Private Sub btnKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKill.Click
        If lvProcess.SelectedIndices.Count = 0 Then Exit Sub
        For i = lvProcess.SelectedIndices.Count - 1 To 0 Step -1
            Dim FileName As String = Processes.GetFileName(lvProcess.SelectedIndices(i))
            Processes.Kill(FileName)
        Next
    End Sub

    Private Sub lvProcess_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvProcess.SelectedIndexChanged
        If lvProcess.SelectedIndices.Count = 0 Then Exit Sub
        Dim k As Integer = lvProcess.SelectedIndices(0)
        Dim Threads As ProcessThreadCollection = Processes.GetThread(k)
        lstThread.Items.Clear()
        For i = 0 To Threads.Count - 1
            Dim Thread As ProcessThread = Threads(i)
            lstThread.Items.Add(Thread.Id & vbTab & Thread.ThreadState.ToString)
        Next
    End Sub
End Class


