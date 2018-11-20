Public Class frmTest
    Dim buttonMatrix As ClsLblMatrix
    Public timer As ClsTimer
    Public hard As Integer = 0

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles Me.Load
        PicTimer.Image = My.Resources.timer
        Dim newFrmStart As New frmStart
        newFrmStart.ShowDialog()
        timer = New ClsTimer(lblTime)
        NewGame()
    End Sub

    Private Sub mns_Option_NewGame_Click(sender As Object, e As EventArgs) Handles mns_Game_NewGame.Click
        NewGame()
    End Sub

    Private Sub mns_Game_Option_Click(sender As Object, e As EventArgs) Handles mns_Game_Option.Click
        Dim newFrmOption As New frmOption
        newFrmOption.ShowDialog()
    End Sub

    Public Sub NewGame()
        If buttonMatrix IsNot Nothing Then
            buttonMatrix.Remove()
        End If
        buttonMatrix = New ClsLblMatrix(picLblMatrix, hard)
        timer.Clear()
        timer.StartTimer()
    End Sub

    Private Sub mns_Game_Exit_Click(sender As Object, e As EventArgs) Handles mns_Game_Exit.Click
        Me.Close()
    End Sub
End Class
