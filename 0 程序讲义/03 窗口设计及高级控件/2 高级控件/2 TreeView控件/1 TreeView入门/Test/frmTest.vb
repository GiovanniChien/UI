Imports System.IO

Public Class frmTest
    Dim Tree As clsTree
    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Tree = New clsTree
    End Sub
    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add(Tree.Root)
        TreeView1.ExpandAll()
    End Sub

    Private Sub btnAppend_Click(sender As System.Object, e As System.EventArgs) Handles btnAppend.Click
        Dim tuple As Tuple(Of String, String)
        tuple = New Tuple(Of String, String)(txtParent.Text, txtChild.Text)
        Tree.Append(tuple)
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Tree.Remove(txtKey.Text)
    End Sub
End Class

