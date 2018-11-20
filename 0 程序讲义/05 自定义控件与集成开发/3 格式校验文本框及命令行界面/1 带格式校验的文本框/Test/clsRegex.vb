Imports System.Text.RegularExpressions

Public Class clsRegex
    Enum Type
        typeInteger
        typeSingle
        typeTime
    End Enum

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
    Const sSingle As String = "^[-]?[0-9]*.[0-9]*$"

    Public Function IsValidate(StrSource As String) As Boolean
        'Return Regex.IsMatch(StrSource, sTime)
        'Return Regex.IsMatch(StrSource, sInteger)
        Return Regex.IsMatch(StrSource, sSingle)
    End Function

End Class
