Public Class frmTest

    Dim worker As clsWorker

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        worker = New clsWorker
    End Sub
    Private Sub DoWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoWork.Click
        Dim para As Integer = Rnd() * 100
        Dim result As Integer = worker.Run(para)
        lstResult.Items.Add(para & vbTab & result)
    End Sub

End Class

