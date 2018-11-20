Public Class frmTest
    Dim obj As Class1

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            obj = New Class1
        Catch ex As Exception
            MsgBox("!!!")
        End Try

    End Sub

    Private Sub btnRun1_Click(sender As System.Object, e As System.EventArgs) Handles btnRun1.Click
        obj = New Class1
        'obj.Run1()
    End Sub

    Private Sub btnRun2_Click(sender As System.Object, e As System.EventArgs) Handles btnRun2.Click
        obj.Run2()
    End Sub

End Class
