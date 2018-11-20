Public Class frmTest
    Dim buttonMatrix As ClsLblMatrix
    Public timer As ClsTimer
    Public hard As Integer = 0
    Public ops As ClsOps

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        PicTimer.Image = My.Resources.timer
        Dim newFrmStart As New frmStart
        newFrmStart.ShowDialog()
        timer = New ClsTimer(lblTime)
        NewGame()
    End Sub

    Private Sub Mns_Option_NewGame_Click(sender As Object, e As EventArgs) Handles Mns_Game_NewGame.Click
        NewGame()
    End Sub

    Private Sub Mns_Game_Option_Click(sender As Object, e As EventArgs) Handles Mns_Game_Option.Click
        Dim newFrmOption As New frmOption
        newFrmOption.ShowDialog()
    End Sub

    Public Sub NewGame()
        If buttonMatrix IsNot Nothing Then
            buttonMatrix.Remove()
        End If
        ops = New ClsOps
        SetMenuRedoStatus(False)
        SetMenuUndoStatus(False)
        buttonMatrix = New ClsLblMatrix(picLblMatrix, hard)
        timer.Clear()
        timer.StartTimer()
    End Sub

    Private Sub Mns_Game_Undo_Click(sender As Object, e As EventArgs) Handles Mns_Game_Undo.Click
        ops.Undo()
    End Sub

    Private Sub Mns_Game_Redo_Click(sender As Object, e As EventArgs) Handles Mns_Game_Redo.Click
        ops.Redo()
    End Sub

    Public Sub SetMenuUndoStatus(status As Boolean)
        Mns_Game_Undo.Enabled = status
    End Sub

    Public Sub SetMenuRedoStatus(status As Boolean)
        Mns_Game_Redo.Enabled = status
    End Sub

    Private Sub Mns_Game_Restart_Click(sender As Object, e As EventArgs) Handles Mns_Game_Restart.Click
        buttonMatrix.Restart()
    End Sub
End Class
