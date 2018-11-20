' 不能处理的情形：
' 识别（初始、中间）运算数为负数，不能是科学记数法，
' 括号不匹配
' 函数不能处理（因为函数是后缀表达式）
' 运算数是符号不能处理

Public Class clsMidExpress
    Private expr As String
    Shared Ops() As String = {"#", "+", "-", "*", "/"}   '可识别的运算符

    Public Sub New(expr As String)
        Me.expr = expr & "#"
    End Sub

    Public Function EvalStep() As Boolean
        Dim si, ei As Integer '一对括号的起始终止位置
        Dim val As Single
        For i = 0 To expr.Length - 1
            If expr(i) = "(" Then
                si = i
            End If
            If expr(i) = ")" Then
                ei = i
                ' 找到第一个最内层的表达式
                Dim firstExpr As New clsMidExpress(expr.Substring(si + 1, ei - si - 1))
                val = firstExpr.Eval()
                Dim left As String = expr.Substring(0, si)
                Dim right As String = expr.Substring(ei + 1)
                expr = left & val & right   '替换字符串
                Return True
            End If
        Next
        expr = Eval() & "#"
        Return False
    End Function

    Private Function Eval() As Single
        Dim OPND As New Stack(Of Single) ' 运算数栈
        Dim OPTR As New Stack(Of String) ' 运算符栈
        OPTR.Push("#")
        Dim i As Integer = 0
        While (expr(i) <> "#" Or OPTR.First <> "#")
            If OpID(expr(i)) = -1 Then
                OPND.Push(GetNum(i)) : Continue While
            End If
            Dim Op As Char = expr(i)
            Dim preOp As Char = OPTR.First
            Select Case Precede(preOp, Op)
                Case "<" ' preOp < Op
                    OPTR.Push(Op) : i += 1 : Exit Select
                Case "="
                    OPTR.Pop() : i += 1 : Exit Select
                Case ">" ' preOp > Op 执行preOp
                    OPTR.Pop()
                    Dim opd1 As Single = OPND.Pop()
                    Dim opd2 As Single = OPND.Pop()
                    OPND.Push(ALU(opd2, preOp, opd1))
            End Select
        End While
        Return OPND.First
    End Function

    '算数逻辑单元
    Private Function ALU(a As Single, op As String, b As Single) As Single
        Select Case op
            Case "+" : Return (a + b)
            Case "-" : Return (a - b)
            Case "*" : Return (a * b)
            Case "/" : Return (a / b)
        End Select
        Return 0
    End Function

    Private Function Precede(preOp As String, Op As String) As Char
        Static priority(,) As Char = {{"=", "<", "<", "<", "<"},
                                      {">", ">", ">", "<", "<"},
                                      {">", ">", ">", "<", "<"},
                                      {">", ">", ">", ">", ">"},
                                      {">", ">", ">", ">", ">"}}
        Return priority(OpID(preOp), OpID(Op))
    End Function
    Private Function OpID(op As String) As Integer
        For i = 0 To Ops.Count - 1
            If Ops(i) = op Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Function GetNum(ByRef i As Integer) As Single
        Dim ei As Integer = i
        While OpID(expr(ei)) = -1
            ei += 1
        End While
        If expr(ei) = "." Then
            ei += 1
            While OpID(expr(ei)) = -1
                ei += 1
            End While
        End If
        Dim num As Single = expr.Substring(i, ei - i)
        i = ei
        Return num
    End Function

    Public Overrides Function ToString() As String
        Return expr.Substring(0, expr.Length - 1)
    End Function
End Class
