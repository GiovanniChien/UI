Imports System.Xml

Public Class clsObjects
    Private Meshs As List(Of clsMesh)

    Public Sub New(ByVal Nodes As XmlNodeList)
        Meshs = New List(Of clsMesh)
        For i = 0 To Nodes.Count - 1
            Meshs.Add(New clsMesh(Nodes(i)))
        Next
    End Sub


End Class
