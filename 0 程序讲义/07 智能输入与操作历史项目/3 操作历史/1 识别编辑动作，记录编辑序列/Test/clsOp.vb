Public Enum OpKind
    Insert
    Update
    Delete
End Enum

Public MustInherit Class clsOp
    Public MustOverride Sub DoWork(txtContent As TextBox)
End Class

'在position之前插入newchars
Public Class clsInsertOp
    Inherits clsOp
    Private position As Integer, newchars As String
    Public Sub New(position As Integer, newchars As String)
        Me.position = position : Me.newchars = newchars
    End Sub
    Public Overrides Sub DoWork(txtContent As System.Windows.Forms.TextBox)
        Dim left As String = txtContent.Text.Substring(0, position)
        Dim right As String = txtContent.Text.Substring(position)
        If newchars = vbCr Then
            txtContent.Text = left & vbCrLf & right
        Else
            txtContent.Text = left & newchars & right
        End If
    End Sub
    Public Overrides Function ToString() As String
        Return "Insert: " & position & vbTab & newchars
    End Function
End Class

'从position开始删除长度为length的字符串
Public Class clsDeleteOp
    Inherits clsOp
    Private position As Integer, length As Integer

    Public Sub New(position As Integer, length As Integer)
        Me.position = position : Me.length = length
    End Sub
    Public Overrides Sub DoWork(txtContent As System.Windows.Forms.TextBox)
        Dim left As String = txtContent.Text.Substring(0, position)
        Dim right As String = txtContent.Text.Substring(position + length)
        txtContent.Text = left & right
    End Sub
    Public Overrides Function ToString() As String
        Return "Delete: " & position & vbTab & length
    End Function
End Class

'从position开始替换长度为length的字符串，新字符串为
Public Class clsUpdateOp
    Inherits clsOp
    Private position As Integer, length As Integer, newchars As String

    Public Sub New(position As Integer, length As Integer, newchars As String)
        Me.position = position : Me.length = length : Me.newchars = newchars
    End Sub
    Public Overrides Sub DoWork(txtContent As System.Windows.Forms.TextBox)
        Dim left As String = txtContent.Text.Substring(0, position)
        Dim right As String = txtContent.Text.Substring(position + length)
        txtContent.Text = left & newchars & right
    End Sub
    Public Overrides Function ToString() As String
        Return "Update: " & position & vbTab & length & vbTab & newchars
    End Function
End Class

