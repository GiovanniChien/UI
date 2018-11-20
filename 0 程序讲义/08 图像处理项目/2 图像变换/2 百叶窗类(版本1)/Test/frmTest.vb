Public Class frmTest
    Dim Shutter1, Shutter2 As clsShutter

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        Shutter1 = New clsShutter("Tulips.jpg", picCanvas1)
        Shutter1.Open(20, clsShutter.ShutterKind.Horizontal)
        Shutter2 = New clsShutter("Tulips1.jpg", picCanvas2)
        Shutter2.Open(10, clsShutter.ShutterKind.Vertical)
    End Sub
End Class
