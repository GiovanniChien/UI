Imports System.IO

Public Class frmTest
    Dim m As clsStlModel

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        m = New clsStlModel("14882Woman.stl")
        m.Display(lstTri)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        m.Save("mymodel.stl")
    End Sub
End Class

