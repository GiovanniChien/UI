Public Class clsCommands
    Private Commands As List(Of clsCommand)

    Public Sub New()
        Commands = New List(Of clsCommand)
        Commands.Add(New clsCommand(CmdType.cmdLine, "^Line \(([0-9]*,[0-9]*)\) \(([0-9]*,[0-9]*)\)$"))
        Commands.Add(New clsCommand(CmdType.cmdCircle, "^Circle \(([0-9]*,[0-9]*)\) ([0-9]*)$"))
    End Sub

    '判断content是哪种命令
    Public Function IsMatch(content As String) As CmdType
        For i = 0 To Commands.Count - 1
            If Commands(i).IsMatch(content) = True Then
                Return Commands(i).type
            End If
        Next
        Return CmdType.cmdNone
    End Function

    '取出content中的参数
    Public Function GetPara(content As String, type As CmdType) As Integer()
        For i = 0 To Commands.Count - 1
            If Commands(i).type = type Then
                Return Commands(i).GetPara(content)
            End If
        Next
        Return Nothing  ' 根本不会执行此句
    End Function

End Class

