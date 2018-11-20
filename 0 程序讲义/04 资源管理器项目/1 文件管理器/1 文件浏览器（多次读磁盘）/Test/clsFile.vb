Imports System.IO

Public Class clsFile
    Public name As String
    Public ModifyTime As Date
    Public Kind As String
    Public Size As Integer
    Public item As ListViewItem

    Public Sub New(filename As String)
        Dim info As FileInfo = New FileInfo(filename)
        name = info.Name
        ModifyTime = info.LastWriteTime
        Kind = info.Extension()
        Size = info.Length
        CreateItem()
    End Sub

    Private Sub CreateItem()
        item = New ListViewItem(name, 0)
        item.SubItems.Add(ModifyTime)
        item.SubItems.Add(Kind)
        item.SubItems.Add(Size)
    End Sub
End Class

