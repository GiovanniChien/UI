Imports System.Xml

Class clsConstellations
    Private Constellations As List(Of clsConstellation)

    Sub New(ByVal xNode As XmlNodeList)
        Constellations = New List(Of clsConstellation)
        For i = 0 To xNode.Count - 1
            Constellations.Add(New clsConstellation(xNode(i)))
        Next
    End Sub

End Class
