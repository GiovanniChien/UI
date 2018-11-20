Imports System.IO

Public Class frmTest
    Dim m As clsStlModel

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        m = New clsStlModel("14882Woman.xls", "Sheet1")
        m.Display(lstTri)
    End Sub

End Class

