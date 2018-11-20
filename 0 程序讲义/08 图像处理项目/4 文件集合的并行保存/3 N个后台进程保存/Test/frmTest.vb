Imports System.Drawing
Imports System.ComponentModel

Public Class frmTest
    Dim path As String
    Dim WithEvents Bitmaps As clsBitmaps
    Dim BkWorker As BackgroundWorker

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        path = My.Application.Info.DirectoryPath
        path = path & "\Tif\"
    End Sub
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Bitmaps = New clsBitmaps(path)
    End Sub

    Private Sub tbXY_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbXY.ValueChanged
        picCanvasXY.Image = Bitmaps.GetBitmap(tbXY.Value)
    End Sub

    Structure bkWorkerPara
        Public si As Integer
        Public ei As Integer
    End Structure

    ' 在漫长的保存过程中，界面能够响应事件！！！
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        pbProgress2.TaskCount = Bitmaps.N

        path = My.Application.Info.DirectoryPath
        path = path & "\Tif\Bitmaps\"
        Dim WorkerCount As Integer = 10
        Dim para As bkWorkerPara
        For i = 0 To WorkerCount - 1
            BkWorker = New BackgroundWorker
            AddHandler BkWorker.DoWork, AddressOf BkWorker_DoWork
            para.si = i * Bitmaps.N / WorkerCount
            para.ei = (i + 1) * Bitmaps.N / WorkerCount
            BkWorker.WorkerReportsProgress = True
            BkWorker.WorkerSupportsCancellation = True
            BkWorker.RunWorkerAsync(para)
        Next
    End Sub

    ' 线程之间的通讯与动作
    Delegate Sub deleSetProgressValue(ByVal value As Integer)
    Private Sub SetProgressValue(ByVal value As Integer)
        pbProgress2.SetValue(value)
    End Sub
    Private Sub Bitmaps_SaveProgress(ByVal ith As Integer) Handles Bitmaps.SaveProgress
        Dim f As deleSetProgressValue = New deleSetProgressValue(AddressOf SetProgressValue)
        ' 在拥有控件的基础窗口句柄的线程上，用指定的参数列表执行指定委托。
        Invoke(f, {ith})
    End Sub

    Private Sub BkWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        Dim para As bkWorkerPara = e.Argument
        Bitmaps.Save(path, para.si, para.ei)
    End Sub

End Class
