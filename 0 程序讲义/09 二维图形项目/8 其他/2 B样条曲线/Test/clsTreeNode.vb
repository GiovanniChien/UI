Public Class clsTreeNode : Inherits TreeNode
    Private _Active As Boolean

    Sub New(ByVal obj As Object)
        Tag = obj
    End Sub

    Public Property Active As Boolean
        Get
            Return _Active
        End Get
        Set(ByVal Active As Boolean)
            _Active = Active
            If _Active = True Then
                ForeColor = Color.Red
            Else
                ForeColor = Color.Black
            End If
        End Set
    End Property
End Class
