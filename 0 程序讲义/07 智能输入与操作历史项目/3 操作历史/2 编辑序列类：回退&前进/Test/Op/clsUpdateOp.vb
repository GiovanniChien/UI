'从position开始替换长度为length的字符串，新字符串为
Public Class clsUpdateOp
    Inherits clsOp

    Private position As Integer, length As Integer
    Private oldchars As String, newchars As String    ' 替换前的旧文本, 替换后的新文本

    Public Sub New(position As Integer, length As Integer, oldchars As String, newchars As String)
        Me.position = position : Me.length = length
        Me.oldchars = oldchars : Me.newchars = newchars
    End Sub

    Public Overrides Sub DoWork(txtContent As System.Windows.Forms.TextBox)
        Dim left As String = txtContent.Text.Substring(0, position)
        Dim right As String = txtContent.Text.Substring(position + length)
        txtContent.Text = left & newchars & right
    End Sub

    Public Overrides Sub UnDo(txtContent As System.Windows.Forms.TextBox)
        Dim left As String = txtContent.Text.Substring(0, position)
        Dim right As String = txtContent.Text.Substring(position + newchars.Length)
        txtContent.Text = left & oldchars & right
    End Sub

    Public Overrides Function ToString() As String
        Return "Update: " & position & vbTab & length & vbTab & newchars
    End Function

End Class

