Public Class Class1
    Public xx As Integer
    Public Sub New()
        xx = 100
        Dim x As Integer = 0
        x = 10 / x
    End Sub
    Sub Class1()
        Try
            Dim x As Integer = 10
            x = 10 / x
        Catch ex As Exception
            MsgBox("class1 Exception")
        End Try
    End Sub

    '总有些异常，是编程时没有想到的
    Sub Run2()
        Dim x As Integer = 0
        x = 10 / x
    End Sub

End Class
