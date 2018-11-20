Public Class clsTreeNode : Inherits TreeNode

    Private _Active As Boolean

    Sub New(ByVal obj As Object)
        _Active = False
        Tag = obj
    End Sub

    Public Property Active As Boolean
        Get
            Return _Active
        End Get
        Set(ByVal Active As Boolean)
            _Active = Active
            If _Active = True Then
                Checked = True
                'ForeColor = Color.Red
                'Dim NodeFont=
            Else
                Checked = False
                'ForeColor = Color.Black
            End If
        End Set
    End Property


End Class
