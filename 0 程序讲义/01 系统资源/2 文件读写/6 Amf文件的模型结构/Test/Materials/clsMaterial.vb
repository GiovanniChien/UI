Imports System.Xml

Public Class clsMaterial
    Public materialid As Integer
    Public name As String
    Public r, g, b As Single

    Sub New(ByVal xNode As XmlNode)
        For i = 0 To xNode.Attributes.Count - 1
            If xNode.Attributes(i).Name = "id" Then
                materialid = xNode.Attributes(i).Value
            End If
        Next

        For i = 0 To xNode.ChildNodes.Count - 1
            If xNode.ChildNodes(i).Name = "color" Then
                Dim colornode As XmlNode = xNode.ChildNodes(i)
                For k = 0 To colornode.ChildNodes.Count - 1
                    If colornode.ChildNodes(k).Name = "r" Then r = colornode.ChildNodes(k).InnerText
                    If colornode.ChildNodes(k).Name = "g" Then g = colornode.ChildNodes(k).InnerText
                    If colornode.ChildNodes(k).Name = "b" Then b = colornode.ChildNodes(k).InnerText
                Next
            End If
            If xNode.ChildNodes(i).Name = "metadata" Then
                Dim metadatanode As XmlNode = xNode.ChildNodes(i)
                name = metadatanode.InnerText
            End If


        Next

    End Sub


End Class
