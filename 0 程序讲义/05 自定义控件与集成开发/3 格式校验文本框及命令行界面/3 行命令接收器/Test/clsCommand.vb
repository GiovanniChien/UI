Imports System.Text.RegularExpressions

Public Enum CmdType
    cmdNone
    cmdCircle
    cmdLine
End Enum

Public Class clsCommand
    Public type As CmdType
    Private pattern As String                        '命令的模式串
    Private Const sInteger As String = "[0-9]+"      '命令参数的模式串(约定为整数)

    Public Sub New(type As CmdType, pattern As String)
        Me.type = type
        Me.pattern = pattern
    End Sub

    ' 检查content是否是一个合法的命令串
    Public Function IsMatch(content As String) As Boolean
        Return Regex.IsMatch(content, Me.pattern)
    End Function

    ' 约定content是一个合法的命令串，从中取出（实数）参数集合
    ' 问题简化：假设从每种命令中取出参数的方法是一样的
    Public Function GetPara(content As String) As Integer()
        Dim result As MatchCollection = Regex.Matches(content, sInteger)
        Dim para(result.Count - 1) As Integer
        For i = 0 To result.Count - 1
            para(i) = result(i).Value
        Next
        Return para
    End Function
End Class


