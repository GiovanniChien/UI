Imports System.IO

Public Class clsFiles
    Public Files() As clsFile
    Public Items() As ListViewItem
    Public Ascending() As Boolean    '排序状态数组。Ascending(i)=True表示按照第i列排序

    Public Sub New(pathname As String)
        Dim filenames() As String = Directory.GetFiles(pathname, "*.*", SearchOption.TopDirectoryOnly)
        ReDim Files(filenames.Count - 1), Items(filenames.Count - 1)
        For i = 0 To Files.Count - 1
            Files(i) = New clsFile(filenames(i))
            Items(i) = Files(i).Item
        Next
        ReDim Ascending(clsFile.GetColumnCount - 1)
        For i = 0 To Ascending.Count - 1
            Ascending(i) = False    '初始化时，每列都是未排列。对第一个被点击的列，进行升序升序排序。
        Next
    End Sub

    Public Sub Sort(columnid As Integer)
        Ascending(columnid) = Not Ascending(columnid)
        Dim columntype As Type = clsFile.GetColumnType(columnid)
        Dim compare As ItemComparer = New ItemComparer(columnid, columntype, Ascending(columnid))
        Array.Sort(Items, compare)
    End Sub

End Class
