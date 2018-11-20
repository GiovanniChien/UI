Imports System.Text.RegularExpressions

Public Enum DataType
    typeInteger
    typeSingle
    typeTime
End Enum

Public Class clsRegex
    'Const sDate As String = "^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$"
    '^( (((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|
    '   (((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|
    '   (((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|
    '   (((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|
    '   ((16|[2468][048]|[3579][26])00))-0?2-29-))$"
    ' yyyy/MM/dd格式
    Const sDate As String = "^(?<year>\\d{2,4})/(?<month>\\d{1,2})/(?<day>\\d{1,2})$"
    Const sTime As String = "^((20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d)$"
    Const sInteger As String = "^[0-9]*$"
    Const sSingle As String = "^[0-9]*.[0-9]*$"

    Function IsValidate(StrSource As String, DataType As DataType) As Boolean
        If DataType = DataType.typeInteger Then
            Return Regex.IsMatch(StrSource, sInteger)
        End If
        If DataType = DataType.typeSingle Then
            Return Regex.IsMatch(StrSource, sSingle)
        End If
        If DataType = DataType.typeTime Then
            Return Regex.IsMatch(StrSource, sTime)
        End If
        Return True
    End Function

End Class
