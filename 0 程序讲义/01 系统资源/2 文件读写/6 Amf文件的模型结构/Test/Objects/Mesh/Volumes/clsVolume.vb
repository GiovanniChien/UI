Imports System.Xml

Class clsVolume
    Private materialid As Integer
    Private Triangles As List(Of clsTriangle)

    Sub New(ByVal xNode As XmlNode)
        For i = 0 To XNode.Attributes.Count - 1
            If XNode.Attributes(i).Name = "materialid" Then
                materialid = XNode.Attributes(i).Value
            End If
        Next
        Triangles = New List(Of clsTriangle)
        For i = 0 To xNode.ChildNodes.Count - 1
            Triangles.Add(New clsTriangle(xNode.ChildNodes(i)))
        Next

    End Sub

End Class
