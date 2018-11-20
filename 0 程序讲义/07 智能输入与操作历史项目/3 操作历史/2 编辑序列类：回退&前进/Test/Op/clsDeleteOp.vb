'从position开始删除长度为length的字符串
Public Class clsDeleteOp
    Inherits clsOp

    Private position As Integer, length As Integer
    Private deletetxt As String   ' 删除的文本

    Public Sub New(position As Integer, length As Integer, deletetxt As String)
        Me.position = position : Me.length = length
        Me.deletetxt = deletetxt
    End Sub

    Public Overrides Sub DoWork(txtContent As System.Windows.Forms.TextBox)
        Dim left As String = txtContent.Text.Substring(0, position)
        Dim right As String = txtContent.Text.Substring(position + length)
        txtContent.Text = left & right
    End Sub

    Public Overrides Sub UnDo(txtContent As System.Windows.Forms.TextBox)
        Dim left As String = txtContent.Text.Substring(0, position)
        Dim right As String = txtContent.Text.Substring(position)
        txtContent.Text = left & deletetxt & right
    End Sub

    Public Overrides Function ToString() As String
        Return "Delete: " & position & vbTab & length
    End Function
End Class
