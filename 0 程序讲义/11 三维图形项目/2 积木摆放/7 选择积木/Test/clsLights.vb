Imports System.Xml
Imports OpenTK.Graphics

Public Class clsLights
    Private Lights As List(Of clsLight)

    Public Sub New()
        Lights = New List(Of clsLight)
        Dim XML As New XmlDocument
        XML.LoadXml(My.Resources.ConfigLight)
        Dim node As System.Xml.XmlElement
        node = XML.SelectSingleNode("Lights")
        node = node.FirstChild
        While node IsNot Nothing
            Lights.Add(New clsLight(node))
            node = node.NextSibling
        End While
    End Sub

    Sub SetLight(index As Integer, open As Boolean)
        Dim Ln As EnableCap = EnableCap.Light0 + index  '灯号
        Lights(index).SetLight(Ln, open)
    End Sub

    Public Function Count() As Integer
        Return Lights.Count
    End Function

End Class
