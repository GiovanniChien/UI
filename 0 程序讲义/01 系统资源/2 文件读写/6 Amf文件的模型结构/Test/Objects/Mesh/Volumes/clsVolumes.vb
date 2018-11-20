Imports System.Xml

Public Class clsVolumes
    Private Volumes As List(Of clsVolume)

    Sub New(ByVal volumeNodes As XmlNodeList)
        Volumes = New List(Of clsVolume)
        For i = 0 To volumeNodes.Count - 1
            Volumes.Add(New clsVolume(volumeNodes(i)))
        Next
    End Sub

End Class
