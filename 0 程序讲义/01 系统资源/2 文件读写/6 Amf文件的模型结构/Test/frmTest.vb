Public Class frmTest
    Dim model As clsModel

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim fname As String = "x1.amf"
        fname = My.Application.Info.DirectoryPath & "\" & fname
        model = New clsModel(fname)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        model.Save("x2.amf")
    End Sub

End Class

' 尚待思考的问题：
' 1 clsModel中未能充分表示三维模型中的拓扑关系
' 2 模型局部一旦发生修改、扩展、删除，如何存储文件
