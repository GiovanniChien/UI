Imports System.Xml.Serialization

<XmlRootAttribute("clsGraph", Namespace:="http://www.clsGraph.com", IsNullable:=False)>
Public Class clsGraph
    <XmlArrayAttribute()> Public AdjList As List(Of clsNode)

    Public Sub Init()
        AdjList = New List(Of clsNode)
        For index = 0 To 4
            AdjList.Add(New clsNode(index))
        Next
        AppendRef(0, 2)
        AppendRef(0, 4)
        AppendRef(1, 2)
        AppendRef(2, 0)
        AppendRef(2, 3)
        AppendRef(3, 0)
    End Sub

    Private Sub AppendRef(ByVal id1 As Integer, ByVal id2 As Integer)
        AdjList(id1).Adjs.Add(AdjList(id2))
        AdjList(id1).AdjIDs.Add(id2)
    End Sub

    Public Sub Flush()
        For i = 0 To AdjList.Count - 1
            For j = 0 To AdjList(i).AdjIDs.Count - 1
                Dim adj As Integer = AdjList(i).AdjIDs(j)
                AdjList(i).Adjs.Add(AdjList(adj))
            Next
        Next
    End Sub
End Class

Public Class clsNode
    <XmlAttribute()> Public id As Integer
    <XmlElement()> Public name As String
    <XmlIgnore()> Public Adjs As List(Of clsNode)
    <XmlArrayAttribute()> Public AdjIDs As List(Of Integer)

    Public Sub New()
        Adjs = New List(Of clsNode)
    End Sub

    Public Sub New(ByVal id As Integer)
        Me.id = id
        Me.name = id
        Adjs = New List(Of clsNode)
        AdjIDs = New List(Of Integer)
    End Sub

End Class