Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmTest
    Dim ds As List(Of DateSerial)
    ' ds(i).data(100): 235  颜色分量值为100的像素点的个数为235
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1.Location = New Point(50, 50)
        Me.Chart1.Size = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.Chart1)

        ds = New List(Of DateSerial)
        Dim ds1, ds2, ds3 As DateSerial
        ds1.Title = "R分析" : ds1.XTitle = "R分量" : ds1.YTitle = "像素个数"
        ReDim ds1.Data(255)
        For i = 0 To 255
            ds1.Data(i) = Rnd() * 100
        Next
        ds2.Title = "G分析" : ds2.XTitle = "G分量" : ds2.YTitle = "像素个数"
        ReDim ds2.Data(255)
        For i = 0 To 255
            ds2.Data(i) = Rnd() * 200
        Next
        ds3.Title = "B分析" : ds3.XTitle = "B分量" : ds3.YTitle = "像素个数"
        ReDim ds3.Data(255)
        For i = 0 To 255
            ds3.Data(i) = Rnd() * 300
        Next
        ds.Add(ds1) : ds.Add(ds2) : ds.Add(ds3)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Chart As clsChart = New clsChart(Chart1)
        Chart.Draw("RGB分析", ds)
    End Sub

End Class