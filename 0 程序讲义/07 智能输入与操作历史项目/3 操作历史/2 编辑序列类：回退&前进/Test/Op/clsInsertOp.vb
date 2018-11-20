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

    Public Overrides Sub UnDo(txtContent As System.Windows.Forms.TextBox)
        Dim left As String = txtContent.Text.Substring(0, position)
        Dim right As String
        If newchars = vbCr Then
            right = txtContent.Text.Substring(position + 2)
        Else
            right = txtContent.Text.Substring(position + 1)
        End If
        txtContent.Text = left & right
    End Sub

    Public Overrides Function ToString() As String
        Return "Insert: " & position & vbTab & newchars
    End Function

End Class
