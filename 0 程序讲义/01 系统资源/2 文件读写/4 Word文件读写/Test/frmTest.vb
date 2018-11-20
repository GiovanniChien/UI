Public Class frmTest
    Dim doc As clsDocument

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        doc = New clsDocument("开学第一课.doc")
        doc.Display(lstParagraph)
    End Sub

End Class

