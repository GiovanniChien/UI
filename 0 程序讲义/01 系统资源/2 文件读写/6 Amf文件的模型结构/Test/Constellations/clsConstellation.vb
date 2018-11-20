Imports System.Xml

Public Class clsConstellation
    Private constellationid As Integer
    Private name As String
    Private objectid As Integer
    Private deltax, deltay, deltaz As Single
    Private rx, ry, rz As Single

    Sub New(ByVal xNode As XmlNode)
        For i = 0 To xNode.Attributes.Count - 1
            If xNode.Attributes(i).Name = "id" Then
                constellationid = xNode.Attributes(i).Value
            End If
        Next
        For i = 0 To xNode.ChildNodes.Count - 1
            If xNode.ChildNodes(i).Name = "metadata" Then
                Dim metadatanode As XmlNode = xNode.ChildNodes(i)
                name = metadatanode.ChildNodes(0).InnerText
            End If
            If xNode.ChildNodes(i).Name = "instance" Then
                Dim instancenode As XmlNode = xNode.ChildNodes(i)
                For k = 0 To instancenode.Attributes.Count - 1
                    If instancenode.Attributes(k).Name = "objectid" Then
                        objectid = instancenode.Attributes(k).Value
                    End If
                Next

                For k = 0 To instancenode.ChildNodes.Count - 1
                    If instancenode.ChildNodes(k).Name = "deltax" Then deltax = instancenode.ChildNodes(k).InnerText
                    If instancenode.ChildNodes(k).Name = "deltay" Then deltay = instancenode.ChildNodes(k).InnerText
                    If instancenode.ChildNodes(k).Name = "deltaz" Then deltaz = instancenode.ChildNodes(k).InnerText
                    If instancenode.ChildNodes(k).Name = "rx" Then rx = instancenode.ChildNodes(k).InnerText
                    If instancenode.ChildNodes(k).Name = "ry" Then ry = instancenode.ChildNodes(k).InnerText
                    If instancenode.ChildNodes(k).Name = "rz" Then rz = instancenode.ChildNodes(k).InnerText
                Next
            End If
        Next


    End Sub

End Class
