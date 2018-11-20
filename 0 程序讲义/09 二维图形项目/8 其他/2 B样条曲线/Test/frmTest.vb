Imports System.Drawing.Drawing2D

Enum OpFlag
    Create
    Modify
End Enum

Public Class frmTest
    Private CS As clsCS2   'picCanvas中的坐标系
    Private Lines As clsLine2s   '绘制多边形过程中的辅助线段集合
    Private Polygon As clsPolygon2        'Polygon：主要操作对象
    Private Flag As OpFlag
    Dim DBox, LBox As clsBox2    '设备坐标、逻辑坐标的范围
    Dim sp As PointF    ' 顶点移动过程中的起点

    Private Sub picCanvas_Resize(sender As System.Object, e As System.EventArgs) Handles picCanvas.Resize
        If LBox Is Nothing Then Exit Sub
        DBox = New clsBox2(0, picCanvas.Width, picCanvas.Height, 0)
        CS = New clsCS2(DBox, LBox)
        Redraw()
    End Sub
    Private Sub btnSetup_Click(sender As System.Object, e As System.EventArgs) Handles btnSetup.Click
        LBox = New clsBox2(txtXmin.Text, txtXmax.Text, txtYmin.Text, txtYmax.Text)
        CS = New clsCS2(DBox, LBox)
        Redraw()
    End Sub
    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DBox = New clsBox2(0, picCanvas.Width, picCanvas.Height, 0)
        LBox = New clsBox2(txtXmin.Text, txtXmax.Text, txtYmin.Text, txtYmax.Text)
        CS = New clsCS2(DBox, LBox)
        Lines = New clsLine2s : Polygon = Nothing
        Flag = OpFlag.Create : tvPoints.Nodes.Add(Lines.Node)
        Redraw()
    End Sub
    Private Sub btnPolygonNew_Click(sender As System.Object, e As System.EventArgs) Handles btnPolygonNew.Click
        Lines.Clear()
        If Polygon IsNot Nothing Then Polygon = Nothing
        Flag = OpFlag.Create : tvPoints.Nodes.Clear() : tvPoints.Nodes.Add(Lines.Node)
        Redraw()
    End Sub

    Private Sub picCanvas_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        Dim dp As Point = e.Location
        Dim lp As PointF = CS.Dp2Lp(dp)
        myStatus_Point.Text = lp.X & "," & lp.Y
    End Sub
    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        If Flag = OpFlag.Create Then
            Dim p As PointF = CS.Dp2Lp(e.Location)
            Lines.Append(p)
            Dim g As Graphics = picCanvas.CreateGraphics()
            Lines.Draw(g, CS)
        End If
        If Flag = OpFlag.Modify Then
            If Polygon.SelectPoint(e.Location, CS) = True Then
                Redraw()
            End If
            sp = CS.Dp2Lp(e.Location)
        End If

    End Sub
    Private Sub picCanvas_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        If Flag = OpFlag.Modify Then
            Dim ep As PointF = CS.Dp2Lp(e.Location)
            Polygon.Move(ep.X - sp.X, ep.Y - sp.Y)
            Redraw()   '顶点位移后，重绘图形
        End If
    End Sub


    Private Sub picCanvas_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDoubleClick
        If Flag = OpFlag.Create Then
            Dim p As PointF = CS.Dp2Lp(e.Location)
            Lines.Append(p)
            Polygon = New clsPolygon2(Lines)
            Dim g As Graphics = picCanvas.CreateGraphics()
            Polygon.Draw(g, CS)
            Flag = OpFlag.Modify : tvPoints.Nodes.Clear() : tvPoints.Nodes.Add(Polygon.Node)
        End If
    End Sub

    Private Sub btnFile_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click, btnSave.Click, btnExit.Click
        Dim fname As String = ""
        If sender Is btnOpen Then
            Polygon = New clsPolygon2(fname)
        End If
        If sender Is btnSave Then
            Polygon.Save(fname)
        End If
    End Sub


    Private Sub picCanvas_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        e.Graphics.Clear(Color.White)
        CS.Draw(e.Graphics)
    End Sub



    Private Sub Redraw()
        Dim g As Graphics = picCanvas.CreateGraphics
        g.Clear(Color.White)
        CS.Draw(g)
        If Flag = OpFlag.Create Then Lines.Draw(g, CS)
        If Flag = OpFlag.Modify Then Polygon.Draw(g, CS)
    End Sub

    Private Sub btnExpand_Click(sender As System.Object, e As System.EventArgs) Handles btnExpand.Click
        Const deltaZ As Single = 0.2
        Dim newPolygon1 As clsPolygon2
        newPolygon1 = New clsPolygon2(Polygon, deltaZ)
        Dim newPolygon2 As clsPolygon2
        newPolygon2 = New clsPolygon2(newPolygon1, deltaZ)
        Dim newPolygon3 As clsPolygon2
        newPolygon3 = New clsPolygon2(newPolygon2, deltaZ)
        Dim newPolygon4 As clsPolygon2
        newPolygon4 = New clsPolygon2(newPolygon3, deltaZ)
        Dim g As Graphics = picCanvas.CreateGraphics()
        Polygon.Draw(g, CS)
        newPolygon1.Draw(g, CS)
        newPolygon2.Draw(g, CS)
        newPolygon3.Draw(g, CS)
        newPolygon4.Draw(g, CS)
    End Sub

    Private Sub tvPoints_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvPoints.AfterSelect
        If Flag = OpFlag.Create Then Exit Sub
        If e.Node.Parent Is Nothing Then Exit Sub '忽略根节点
        Polygon.SetActive(e.Node.Index)   '设置当前点
        Redraw()
    End Sub

End Class
