Imports System.Drawing
Imports System.ComponentModel

Public Class frmTest
    Dim path As String
    Dim WithEvents Bitmaps As clsBitmaps
    Dim WithEvents BkWorker As BackgroundWorker

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

    ' 在漫长的保存过程中，界面能够响应事件！！！
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        path = My.Application.Info.DirectoryPath
        path = path & "\Tif\Bitmaps\"
        BkWorker = New BackgroundWorker
        BkWorker.WorkerReportsProgress = True
        BkWorker.WorkerSupportsCancellation = True
        BkWorker.RunWorkerAsync(True)
    End Sub

    ' 线程之间的通讯与动作
    Delegate Sub deleSetProgressBegin(ByVal min As Integer, ByVal max As Integer)
    Delegate Sub deleSetProgressValue(ByVal value As Integer)
    Delegate Sub deleSetProgressEnd()
    Private Sub SetProgressRange(ByVal min As Integer, ByVal max As Integer)
        pbProgress1.Min = min : pbProgress1.Max = max
        pbProgress1.Value = min
        btnSave.Enabled = False
    End Sub
    Private Sub SetProgressValue(ByVal value As Integer)
        pbProgress1.Value = value
    End Sub
    Private Sub SetProgressEnd()
        pbProgress1.Value = pbProgress1.Min
        btnSave.Enabled = True
    End Sub

    Private Sub Bitmaps_SaveBegin(ByVal Total As Integer) Handles Bitmaps.SaveBegin
        Dim f As deleSetProgressBegin = New deleSetProgressBegin(AddressOf SetProgressRange)
        Invoke(f, {0, Total})
    End Sub
    Private Sub Bitmaps_SaveProgress(ByVal ith As Integer) Handles Bitmaps.SaveProgress
        Dim f As deleSetProgressValue = New deleSetProgressValue(AddressOf SetProgressValue)
        ' 在拥有控件的基础窗口句柄的线程上，用指定的参数列表执行指定委托。
        Invoke(f, {ith})
    End Sub
    Private Sub Bitmaps_SaveEnd() Handles Bitmaps.SaveEnd
        Dim f As deleSetProgressEnd = New deleSetProgressEnd(AddressOf SetProgressEnd)
        Invoke(f)
    End Sub

    Private Sub BkWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BkWorker.DoWork
        Bitmaps.Save(path)
    End Sub

End Class
