Public Class frmTest
    Private Worker As clsWorkerA

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart1.Click
        Static paraid As Integer = 0
        paraid = paraid + 1
        Dim para As WorkerPara
        para.id = paraid : para.n1 = Rnd() * 100 : para.n2 = Rnd() * 1000000
        Me.Worker = New clsWorkerA(para)
        AddHandler Me.Worker.Complete, AddressOf WorkerComplete
        Me.Worker.Run()
        lstpara.Items.Add(para.id & vbTab & para.n1 & vbTab & para.n2)
    End Sub

    Private Sub WorkerComplete(Cancel As Boolean, result As WorkerResult)
        If Cancel = True Then Exit Sub
        lstResult.Items.Add(result.id & vbTab & result.sum)
    End Sub

End Class
