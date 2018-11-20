Public Class Form1
    Dim tree As ClsTree
    Dim tuples As New List(Of Tuple(Of String, String))

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tuples.Add(New Tuple(Of String, String)("Elem", "Line"))
        tuples.Add(New Tuple(Of String, String)("Elem", "Circle"))
        tuples.Add(New Tuple(Of String, String)("Elem", "Rectangle"))
        tuples.Add(New Tuple(Of String, String)("Line", "Line1"))
        tuples.Add(New Tuple(Of String, String)("Line", "Line2"))
        tuples.Add(New Tuple(Of String, String)("Line", "Line3"))
        tuples.Add(New Tuple(Of String, String)("Circle", "Circle1"))
        tuples.Add(New Tuple(Of String, String)("Circle", "Circle2"))
        tuples.Add(New Tuple(Of String, String)("Circle", "Circle3"))
        tree = New ClsTree(tuples)
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        TreeView1.Nodes.Add(tree.GetRoot)
        TreeView1.ExpandAll()
    End Sub
End Class
