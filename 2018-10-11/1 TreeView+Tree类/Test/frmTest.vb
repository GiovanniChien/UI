Public Class Form1
    Dim tree As ClsTree

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tree = New ClsTree
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        TreeView1.Nodes.Add(tree.GetRoot)
        TreeView1.ExpandAll()
    End Sub
End Class
