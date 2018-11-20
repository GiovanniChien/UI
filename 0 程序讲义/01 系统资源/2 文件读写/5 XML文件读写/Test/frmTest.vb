Imports System.Xml

Public Class frmTest

    Dim doc As XmlDocument, amf As XmlElement

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim fname As String = "x1.amf"
        fname = My.Application.Info.DirectoryPath & "\" & fname
        doc = New XmlDocument : doc.Load(fname)
        amf = doc.SelectSingleNode("amf")
        '遍历整个结构的基本方法
        GetSegment(amf, "object", txtObjects)
        GetSegment(amf, "constellation", txtConstellations)
        GetSegment(amf, "material", txtMaterials)
    End Sub

    Private Sub GetSegment(ByVal amf As XmlElement, ByVal SName As String, ByVal textbox As TextBox)
        Dim Nodes As XmlNodeList = amf.GetElementsByTagName(SName)
        For i = 0 To Nodes.Count - 1
            Dim XNode As XmlNode = Nodes(i)
            Dim Attributes As String = ""
            For j = 0 To XNode.Attributes.Count - 1
                Attributes = Attributes & XNode.Attributes(j).Name & ": " & XNode.Attributes(j).Value & vbCrLf
            Next
            textbox.Text = textbox.Text & Attributes & XNode.InnerXml() & vbCrLf & vbCrLf
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        doc.Save("x.amf")
    End Sub
End Class

'修改某个节点的方法
'扩展、删除节点的方法
'保存整个结构的函数
