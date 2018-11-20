Public Class frmTest

    Private Sub Array_Click(sender As System.Object, e As System.EventArgs) Handles btnSquenceArray.Click, btnParallelArray.Click
        Dim Array As clsParallelArray = New clsParallelArray(txtTaskCount.Text)
        If sender Is btnSquenceArray Then
            Me.Text = Array.RunSquence()  '5秒
        Else
            Me.Text = Array.RunParallel() '1.5秒
        End If
    End Sub
    Private Sub List_Click(sender As System.Object, e As System.EventArgs) Handles btnSequenceList.Click, btnParallelList.Click
        Dim List As clsParallelList = New clsParallelList(txtTaskCount.Text)
        If sender Is btnSequenceList Then
            Me.Text = List.RunSquence()  '8秒
        Else
            Me.Text = List.RunParallel() '20秒
        End If
    End Sub
End Class
