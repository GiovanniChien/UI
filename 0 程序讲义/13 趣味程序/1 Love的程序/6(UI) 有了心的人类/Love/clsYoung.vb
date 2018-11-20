Public MustInherit Class clsYoung
    Protected Const Max As Integer = 9

    ' 每个人都有一颗心，都有追求心的努力Count
    Protected Heart As clsYoung, Count As Integer
    Public MustOverride Sub Meet(ByVal Young As clsYoung)
    Public MustOverride Sub Missing()

    Public Sub New()
        ' 生命诞生了，但还又有心
        Heart = Nothing : Count = 0
    End Sub

    Protected Sub Say(ByVal words As String)   ' 爱要说出口
        frmLove.lstWords.Items.Add(words)
    End Sub
End Class
