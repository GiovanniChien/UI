Imports System.IO
Imports System.Xml.Serialization

Public Class frmTest
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim G As New clsGraph
        G.Init()
        G.Save()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim serializer As New XmlSerializer(GetType(clsGraph))
        Dim fs As New FileStream("G.xml", FileMode.Open)
        Dim G As clsGraph
        G = CType(serializer.Deserialize(fs), clsGraph)
    End Sub


End Class


