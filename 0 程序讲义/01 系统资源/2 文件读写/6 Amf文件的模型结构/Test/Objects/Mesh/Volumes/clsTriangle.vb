Imports System.Xml

Public Class clsTriangle
    Public v1, v2, v3 As Integer

    'XNode: "<v1>2</v1><v2>1</v2><v3>0</v3>"
    Public Sub New(ByVal XNode As XmlNode)
        Dim tris As XmlNodeList = XNode.ChildNodes
        For i = 0 To tris.Count - 1
            If tris(i).Name = "v1" Then v1 = tris(i).InnerText
            If tris(i).Name = "v2" Then v2 = tris(i).InnerText
            If tris(i).Name = "v3" Then v3 = tris(i).InnerText
        Next
    End Sub
End Class
