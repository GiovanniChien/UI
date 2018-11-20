Imports System.Xml

Public Class clsLight
    Public Name As String
    Public Position As String
    Public Ambient As String
    Public Diffuse As String
    Public Specular As String

    Public Sub New(node As System.Xml.XmlElement)
        Name = node.Name
        Position = node.SelectSingleNode("position").InnerText
        Ambient = node.SelectSingleNode("ambient").InnerText
        Diffuse = node.SelectSingleNode("diffuse").InnerText
        Specular = node.SelectSingleNode("specular").InnerText
    End Sub
End Class

Public Class clsLights
    Public Lights As List(Of clsLight)

    Public Sub New(Content As String)
        Dim XML As New XmlDocument
        XML.LoadXml(Content)
        Lights = New List(Of clsLight)

        Dim node As XmlNode
        node = XML.FirstChild.FirstChild
        While node IsNot Nothing
            Lights.Add(New clsLight(node))
            node = node.NextSibling
        End While
    End Sub

End Class
