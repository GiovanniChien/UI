Public Class frmLove
    Dim Boy As clsBoy, Girl As New clsGirl ' 一个男孩和一个女孩的世界
    Private Sub frmLove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Boy = New clsBoy
        Girl = New clsGirl
    End Sub
    Private Sub butLove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLove.Click
        lstWords.Items.Clear()
        Boy.Meet(Girl) : Girl.Meet(Boy) ' 男孩遇见女孩，女孩遇见男孩
        'Boy.Missing()       ' 从男孩开始的恋情(必须求婚)
        Girl.Missing()     ' 从女孩开始的恋情(求婚可以省略)
    End Sub

End Class



