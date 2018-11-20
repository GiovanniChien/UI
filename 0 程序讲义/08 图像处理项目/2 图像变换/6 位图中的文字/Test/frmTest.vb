Public Class frmTest
    Dim image As clsImage

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        image = New clsImage("Tulips.jpg", picCanvas)
    End Sub

    Private Sub btnShowFonts_Click(sender As System.Object, e As System.EventArgs) Handles btnShowFonts.Click
        Dim Fonts() As FontFamily = FontFamily.Families()
        lstFonts.Items.Clear()
        For i = 0 To Fonts.Count - 1
            lstFonts.Items.Add(Fonts(i).Name)
        Next
    End Sub

    Private Sub btnAddString_Click(sender As System.Object, e As System.EventArgs) Handles btnAddString.Click
        Dim FontName As String = lstFonts.Text
        Dim font As Font = New Font(FontName, 12)
        Dim p As Point = New Point(10, 10)
        image.DrawString(txtSign.Text, font, p)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        image.SaveAs("Tulips2.jpg", Imaging.ImageFormat.Jpeg)
    End Sub

End Class
