Public Class frmTest

    Dim Filter As myIMessageFilter = New myIMessageFilter

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Filter = New myIMessageFilter
    End Sub
    Private Sub Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click, btnNoFilter.Click
        If sender Is btnFilter Then
            Application.AddMessageFilter(Filter)   '添加消息筛选器
        End If
        If sender Is btnNoFilter Then
            Application.RemoveMessageFilter(Filter)   '添加消息筛选器
        End If
    End Sub

End Class

Class myIMessageFilter
    Implements IMessageFilter

    Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements System.Windows.Forms.IMessageFilter.PreFilterMessage
        '鼠标左键: down：513   up：514    
        '鼠标右键: down：516   up：517
        '鼠标双击：doubleclick：515 
        '鼠标滚轮：522 
        ' 可在windows.h中查找
        If m.Msg = 513 And m.Msg <= 517 Then
            Return True
        End If
        Return False
    End Function
End Class

