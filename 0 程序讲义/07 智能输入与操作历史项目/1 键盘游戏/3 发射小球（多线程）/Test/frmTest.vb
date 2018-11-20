Imports System.ComponentModel

Public Class frmTest
    Dim BkWorker As BackgroundWorker
    Dim box As clsBox

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        picCanvas.BackColor = Color.White
    End Sub

    Private Sub frmTest_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        BkWorker = New BackgroundWorker
        AddHandler BkWorker.DoWork, AddressOf BkWorker_DoWork
        AddHandler BkWorker.RunWorkerCompleted, AddressOf BkWorker_RunWorkerCompleted
        BkWorker.WorkerReportsProgress = True
        BkWorker.WorkerSupportsCancellation = True
        BkWorker.RunWorkerAsync(True)
    End Sub
    Private Sub BkWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Dim p As Point
        p.X = 0 : p.Y = picCanvas.Height / 2
        If e.Argument = True Then
            box = New clsBox(BoxKind.Circle, p, picCanvas.DisplayRectangle, picCanvas.CreateGraphics())
        Else
            box = New clsBox(BoxKind.Box, p, picCanvas.DisplayRectangle, picCanvas.CreateGraphics())
        End If
    End Sub

    Private Sub frmTest_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        BkWorker = New BackgroundWorker
        BkWorker.WorkerReportsProgress = True
        BkWorker.WorkerSupportsCancellation = True
        BkWorker.RunWorkerAsync(False)
    End Sub

    Private Sub BkWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)

    End Sub


End Class
