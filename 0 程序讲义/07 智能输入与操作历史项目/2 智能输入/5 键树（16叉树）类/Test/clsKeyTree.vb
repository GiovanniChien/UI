Imports System.IO

Public Class clsKeyTree
    Class Node
        Public nextc() As Node
        Public Sub New()
            ReDim nextc(15)    '默认每个单元均为Nothing
        End Sub
    End Class

    Private Root As Node   ' 键树的根节点

    Public Sub New()
        Root = New Node
        Dim content As String
        Using fs As New IO.FileStream("Words.txt", FileMode.Open)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                content = sr.ReadToEnd()
            End Using
        End Using
        Dim separator() As Char = {vbLf, vbCr}
        Dim Words() As String = content.Split(separator, StringSplitOptions.RemoveEmptyEntries)
        For i = 0 To Words.Count - 1
            InsertWord(Words(i))
        Next
    End Sub

    ' 在Root所指的键树中插入单词word（每个字符的编码为16位整数，分解为4个小整数，每个整数在0到15之间）
    Private Sub InsertWord(ByVal word As String)
        Dim p As Node = Root
        For i = 0 To word.Length - 1
            ' 每个字符涉及4个结点，或许需要创建新结点
            Dim digits() As UInt16 = clsAscWCode.Deform(AscW(word(i)))
            For k = 0 To 3
                Dim f As UInt16 = digits(k)
                If p.nextc(f) Is Nothing Then p.nextc(f) = New Node
                p = p.nextc(f)
            Next
        Next
    End Sub
    Public Function SearchbyPrefix(ByVal prefix As String) As List(Of String)
        Dim p As Node = SearchNodebyPrefix(prefix)  ' 找到prefix的终点结点p
        Return TraverLeaf(p)                        ' 遍历p所指的16叉树，将所有叶子结点对应的单词存入words
    End Function

    Private Function SearchNodebyPrefix(ByVal prefix As String) As Node
        Dim p As Node = Root
        For i = 0 To prefix.Length - 1
            Dim digits() As UInt16 = clsAscWCode.Deform(AscW(prefix(i)))
            For k = 0 To 3
                Dim f As UInt16 = digits(k)
                p = p.nextc(f)
                If p Is Nothing Then Exit For
            Next
            If p Is Nothing Then Exit For
        Next
        Return p
    End Function

    Private Function TraverLeaf(p As Node) As List(Of String)
        Dim words As New List(Of String)
        Dim StackWord As Stack(Of UInt16) = New Stack(Of UInt16)    ' 字符编码栈，用来组织单词
        TraverLeaf(p, words, StackWord)
        Return words
    End Function
    Private Sub TraverLeaf(p As Node, words As List(Of String), StackCode As Stack(Of UInt16))
        If p Is Nothing Then Return
        ' 遍历当前结点的所有子树，并判别当前结点是否是叶子结点
        Dim isLeaf As Boolean = True
        For i = 0 To 15
            If p.nextc(i) IsNot Nothing Then
                StackCode.Push(i)
                TraverLeaf(p.nextc(i), words, StackCode)
                StackCode.Pop()
                isLeaf = False      '不是叶子结点
            End If
        Next
        ' 若p是叶子结点
        If isLeaf = True Then
            If StackCode.Count > 0 Then
                words.Add(GetWord(StackCode))
            End If
        End If
    End Sub

    Private Function GetWord(StackCode As Stack(Of UInt16)) As String
        Dim word As String = ""
        Dim digits(3) As UInt16
        For i = 0 To StackCode.Count - 1 Step 4
            digits(3) = StackCode(i) : digits(2) = StackCode(i + 1) : digits(1) = StackCode(i + 2) : digits(0) = StackCode(i + 3)
            word = ChrW(clsAscWCode.Compose(digits)) & word
        Next
        Return word
    End Function

End Class
