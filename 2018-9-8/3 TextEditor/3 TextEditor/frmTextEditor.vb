Public Class frmTextEditor
    Public Property StatusText() As String
        Get
            Return sslStatus.Text
        End Get
        Set(value As String)
            sslStatus.Text = value
        End Set
    End Property

    Public Property EditText() As String
        Get
            Return txtEdit.Text
        End Get
        Set(value As String)
            txtEdit.Text = value
        End Set
    End Property

    Public Sub ClearEditBox()
        EditText = String.Empty
        txtEdit.ForeColor = Color.Black
        StatusText = "Text bar cleared"
    End Sub

    Private Sub txtEdit_TextChanged(sender As Object, e As EventArgs) Handles txtEdit.TextChanged
        StatusText = "Ready"
    End Sub

    Private Sub tbrClear_Click(sender As Object, e As EventArgs) Handles tbrClear.Click
        ClearEditBox()
    End Sub

    Private Sub tbrRed_Click(sender As Object, e As EventArgs) Handles tbrRed.Click
        txtEdit.ForeColor = Color.Red
        StatusText = "The text is red"
    End Sub

    Private Sub tbrBlue_Click(sender As Object, e As EventArgs) Handles tbrBlue.Click
        txtEdit.ForeColor = Color.Blue
        StatusText = "The text is blue"
    End Sub

    Private Sub tbrUppercase_Click(sender As Object, e As EventArgs) Handles tbrUppercase.Click
        EditText = EditText.ToUpper
        StatusText = "The text is all uppercase"
    End Sub

    Private Sub tbrLowercase_Click(sender As Object, e As EventArgs) Handles tbrLowercase.Click
        EditText = EditText.ToLower
        StatusText = "The text is all lowercase"
    End Sub

    Private Sub tbrAbout_Click(sender As Object, e As EventArgs) Handles tbrAbout.Click
        Using objAoubt As New About
            objAoubt.ShowDialog(Me)
        End Using
    End Sub
End Class
