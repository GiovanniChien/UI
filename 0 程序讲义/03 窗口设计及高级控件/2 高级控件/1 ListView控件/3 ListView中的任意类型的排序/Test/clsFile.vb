Imports System.IO

Public Class clsFile
    Public Name As String
    Public ModifyTime As Date
    Public Kind As String
    Public Size As Integer
    Public Item As ListViewItem

    Public Sub New()
        Name = "" : Kind = ""
    End Sub
    Public Sub New(filename As String)
        Dim info As FileInfo = New FileInfo(filename)
        Me.Name = info.Name
        Me.ModifyTime = info.LastWriteTime
        Me.Kind = info.Extension()
        Me.Size = info.Length
        CreateItem()
    End Sub
    Private Sub CreateItem()
        Item = New ListViewItem(Name, 0)
        Item.SubItems.Add(ModifyTime)
        Item.SubItems.Add(Kind)
        Item.SubItems.Add(Size)
    End Sub

    Public Shared Function GetColumnCount() As Integer
        Return 4
    End Function
    Public Shared Function GetColumnType(id As Integer) As Type
        Dim a As New clsFile  '因为是共享函数，需要对象实例，所以创建一个对象a
        Dim ColumnType As Type = Nothing
        Select Case id
            Case 0 : ColumnType = a.Name.GetType()
            Case 1 : ColumnType = a.ModifyTime.GetType()
            Case 2 : ColumnType = a.Kind.GetType()
            Case 3 : ColumnType = a.Size.GetType()
        End Select
        Return ColumnType
    End Function


End Class


