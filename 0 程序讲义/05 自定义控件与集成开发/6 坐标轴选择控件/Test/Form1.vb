
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcCS1.bmX = New Bitmap("x.bmp")
        UcCS1.bmY = New Bitmap("y.bmp")
        UcCS1.bmZ = New Bitmap("z.bmp")
    End Sub

    Private Sub UcCS1_AxisChange(ByVal Axis As Commons.Axis) Handles UcCS1.AxisChange
        Text = Axis
    End Sub

End Class
