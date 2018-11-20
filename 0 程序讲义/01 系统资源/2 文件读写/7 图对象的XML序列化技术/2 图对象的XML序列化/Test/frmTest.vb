Imports System.IO
Imports System.Xml.Serialization

Public Class frmTest
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim G As New clsGraph
        G.Init()
        Dim serializer As New XmlSerializer(GetType(clsGraph))
        Dim writer As TextWriter = New StreamWriter("G.xml")
        serializer.Serialize(writer, G)
        writer.Close()
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim serializer As New XmlSerializer(GetType(clsGraph))
        Dim fs As New FileStream("G.xml", FileMode.Open)
        Dim G As New clsGraph
        G = CType(serializer.Deserialize(fs), clsGraph)
        G.Flush()
    End Sub
End Class


