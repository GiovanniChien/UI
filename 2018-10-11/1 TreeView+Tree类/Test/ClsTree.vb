Public Class ClsTree
    Private root As TreeNode

    ReadOnly Property GetRoot
        Get
            Return root
        End Get
    End Property

    Public Sub New()
        root = New TreeNode("root")
        root.Nodes.Add("b1")
        Dim b2 As TreeNode = root.Nodes.Add("b2")
        root.Nodes.Add("b3")
        b2.Nodes.Add("c1")
        b2.Nodes.Add("c2")
        b2.Nodes.Add("c3")
    End Sub
End Class
