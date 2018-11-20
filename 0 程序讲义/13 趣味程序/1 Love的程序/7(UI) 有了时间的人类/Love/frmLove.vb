Public Class frmLove
    Dim Girl As clsGirl, Boy As clsBoy ' 一个男孩和一个女孩的世界

    Private Sub frmLove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Boy = New clsBoy
        Girl = New clsGirl
    End Sub

    Private Sub butLove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLove.Click
        lstWords.Items.Clear()
        Girl.Meet(Boy) : Boy.Meet(Girl) ' 男孩遇见女孩，女孩遇见男孩
    End Sub

End Class



