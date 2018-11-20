Public Class frmLove
    Dim World As clsWorld ' 一个世界

    Private Sub frmLove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        World = New clsWorld
    End Sub

    Private Sub butLove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLove.Click
        World.Start()
    End Sub

End Class



