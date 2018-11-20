Imports System.Xml

Class clsMaterials
    Private Materials As List(Of clsMaterial)

    Sub New(ByVal xNode As XmlNodeList)
        Materials = New List(Of clsMaterial)
        For i = 0 To xNode.Count - 1
            Materials.Add(New clsMaterial(xNode(i)))
        Next
    End Sub

End Class
