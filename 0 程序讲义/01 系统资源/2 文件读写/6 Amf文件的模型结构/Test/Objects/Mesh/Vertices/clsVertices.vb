Imports System.Xml

Public Class clsVertices
    Private vertices As List(Of clsVertex)

    Sub New(ByVal xNode As XmlNode)
        vertices = New List(Of clsVertex)
        For i = 0 To xNode.ChildNodes.Count - 1
            vertices.Add(New clsVertex(xNode.ChildNodes(i)))
        Next
    End Sub


End Class
