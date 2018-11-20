Public Class frmTest

    Dim Board As clsBoard ' 自定义的棋盘类
    Dim player As clsBoard.Status
    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Board = Nothing
    End Sub

    Private Sub m_Game_New_Click(sender As System.Object, e As System.EventArgs) Handles m_Game_New.Click
        Dim box As Rectangle = New Rectangle(0, 0, picCanvas.Width, picCanvas.Height)
        Board = New clsBoard(box, 19)
        Draw()
        player = clsBoard.Status.Black  '黑棋先下
    End Sub

    Private Sub picCanvas_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseClick
        If Board Is Nothing Then Return
        Dim p As Point = Board.GetLocation(e.Location)  '实现了棋盘坐标
        If Board.GetStatus(p) = clsBoard.Status.Outside Then Return
        If Board.GetStatus(p) <> clsBoard.Status.Empty Then Return
        Board.PlaceChess(player, p)
        Draw()
        If player = clsBoard.Status.Black Then
            player = clsBoard.Status.White
        Else
            player = clsBoard.Status.Black
        End If
    End Sub
    Private Sub Draw()
        If Board Is Nothing Then Return
        Dim g As Graphics = picCanvas.CreateGraphics
        Board.Draw(g)
    End Sub

    '解决了遮挡后的图形刷新问题
    Private Sub picCanvas_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        If Board Is Nothing Then Return
        Board.Draw(e.Graphics)
    End Sub

    Private Sub picCanvas_Resize(sender As System.Object, e As System.EventArgs) Handles picCanvas.Resize
        If Board Is Nothing Then Return
        Dim box As Rectangle = New Rectangle(0, 0, picCanvas.Width, picCanvas.Height)
        Board.Resize(box)
        Draw()
    End Sub
End Class
