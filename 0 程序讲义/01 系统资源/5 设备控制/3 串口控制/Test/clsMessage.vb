Public Enum SensorFlag
    Invalid
    T1
    T2
    Q
End Enum
Public Structure Result
    Public Valid As SensorFlag
    Public T1 As Integer  ' 温度1
    Public T2 As Integer  ' 温度2
    Public Q As Integer   ' 气压
End Structure

Public Class clsMessage
    '5A A5 05 82
    Private p0, p1, p2, p3, p4, p5, p6, p7 As Byte

    Public Sub New()
        p0 = 90 : p1 = 165 : p2 = 5 : p3 = 130
    End Sub
    Function Align(ByVal Buff() As Byte) As Integer
        For i = 0 To 7
            If Buff(i) = p0 And Buff((i + 1) Mod 8) = p1 And Buff((i + 2) Mod 8) = p2 And Buff((i + 3) Mod 8) = p3 Then
                Return (i + 4) Mod 8
            End If
        Next
        Return -1
    End Function

    Function Match(ByVal buff() As Byte) As Result
        Dim k As Integer = Align(buff)  '有效数字的起始位置
        Dim r As Result : r.Valid = SensorFlag.Invalid
        If k = -1 Then Return r
        Dim v As Integer = buff((k + 2) Mod 8) * 256 + buff((k + 3) Mod 8)
        If buff(k) = 0 And buff((k + 1) Mod 8) = 0 Then
            r.T1 = v : r.Valid = SensorFlag.T1
        End If
        If buff(k) = 0 And buff((k + 1) Mod 8) = 1 Then
            r.T2 = v : r.Valid = SensorFlag.T2
        End If
        If buff(k) = 0 And buff((k + 1) Mod 8) = 2 Then
            r.Q = v : r.Valid = SensorFlag.Q
        End If
        Return r
    End Function

    Function GetCmd(ByVal Sensor As SensorFlag, ByVal v As Integer) As Byte()
        Dim cmd(7) As Byte
        cmd(0) = p0 : cmd(1) = p1 : cmd(2) = p2 : cmd(3) = p3
        If Sensor = SensorFlag.T1 Or Sensor = SensorFlag.T2 Then
            cmd(4) = 0 : cmd(5) = 4 : cmd(6) = v / 256 : cmd(7) = v Mod 256
        End If
        If Sensor = SensorFlag.Q Then
            cmd(4) = 0 : cmd(5) = 5 : cmd(6) = v / 256 : cmd(7) = v Mod 256
        End If
        Return cmd
    End Function

End Class
