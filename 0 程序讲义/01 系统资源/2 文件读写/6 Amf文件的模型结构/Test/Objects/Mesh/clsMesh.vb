Imports System.Xml

Class clsMesh
    Private vertices As clsVertices
    Private volumes As clsVolumes

    Sub New(ByVal Node As XmlElement)
        Dim VerticesNodes As XmlNodeList = Node.GetElementsByTagName("vertices")
        ' 只有一个vertices段：VerticesNodes(0)
        vertices = New clsVertices(VerticesNodes(0))

        Dim volumeNodes As XmlNodeList = Node.GetElementsByTagName("volume")
        volumes = New clsVolumes(volumeNodes)
    End Sub

End Class
