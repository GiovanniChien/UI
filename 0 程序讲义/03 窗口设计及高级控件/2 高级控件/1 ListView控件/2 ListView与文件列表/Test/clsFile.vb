Imports System.IO

Public Class clsFile
    Public Name As String
    Public ModifyTime As Date
    Public Kind As String
    Public Size As Integer
    Public Item As ListViewItem

    Public Sub New(filename As String)
        Dim info As FileInfo = New FileInfo(filename)
        Me.name = info.Name
        Me.ModifyTime = info.LastWriteTime
        Me.Kind = info.Extension()
        Me.Size = info.Length
        Me.item = New ListViewItem(name, 0)
        Me.item.SubItems.Add(ModifyTime)
        Me.item.SubItems.Add(Kind)
        Me.item.SubItems.Add(Size)
    End Sub
End Class

