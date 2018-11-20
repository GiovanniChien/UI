Public Class frmTest
    Dim Shutter1 As clsFade
    Dim Shutter2 As clsFade

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Shutter1 = New clsFade("Tulips.jpg", picCanvas1)
        Shutter1.Open(20, 5)
        Shutter2 = New clsFade("Tulips.jpg", picCanvas2)
        Shutter2.Open(20, 9)
    End Sub
End Class
