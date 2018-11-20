Imports System.IO
Imports System.Xml.Serialization

Public Class clsGraph
    Public data As Integer
    Public AdjList As List(Of String)

    Public Sub New()
        AdjList = New List(Of String)
    End Sub

    'Public Sub New(fname As String)
    '    Dim serializer As New XmlSerializer(GetType(clsGraph))
    '    Dim fs As New FileStream(fname, FileMode.Open)
    '    Dim G As New clsGraph
    '    G = CType(serializer.Deserialize(fs), clsGraph)
    '    Me = G
    'End Sub

    Public Sub Save()
        Dim serializer As New XmlSerializer(GetType(clsGraph))
        Dim writer As StreamWriter = New StreamWriter("G.xml")
        serializer.Serialize(writer, Me)
        writer.Close()
    End Sub

    Public Sub Init()
        AdjList = New List(Of String)
        data = 1
        AdjList.Add("edge1")
        AdjList.Add("edge2")
    End Sub

End Class

