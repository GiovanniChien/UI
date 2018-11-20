Imports System.Xml

Public Class frmTest
    Dim WithEvents ticker As Timer

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ticker = New Timer
        ticker.Interval = 100
        ticker.Enabled = True
    End Sub

    Private Sub ticker_Tick(sender As Object, e As System.EventArgs) Handles ticker.Tick
        Dim Icons() As Icon = {My.Resources.A1, My.Resources.A2, My.Resources.A3, My.Resources.A4}
        Static ith As Integer = 0
        Me.Icon = Icons(ith)
        ith = (ith + 1) Mod 4
    End Sub

    Private Sub btnXML_Click(sender As System.Object, e As System.EventArgs) Handles btnXML.Click
        Dim XML As New XmlDocument
        XML.LoadXml(My.Resources.ConfigMaterial)
        Dim node As System.Xml.XmlElement
        node = XML.FirstChild.SelectSingleNode("Model")
        Dim ambient As String = node.SelectSingleNode("ambient").InnerXml()
        MsgBox(ambient)
    End Sub
End Class
