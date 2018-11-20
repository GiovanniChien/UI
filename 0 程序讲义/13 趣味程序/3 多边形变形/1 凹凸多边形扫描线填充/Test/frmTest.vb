Public Class frmTest
    Dim Buffer As Bitmap
    Dim polygon As clsPolygon
    Dim sps As List(Of Point), lastelem As clsPLine  ' 临时变量,用于动态创建Polygon

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Buffer = New Bitmap(picCanvas.Width, picCanvas.Height)
        sps = New List(Of Point) : lastelem = Nothing
    End Sub

    Private Sub picCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        If sps.Count = 0 Then
            sps.Add(e.Location) : sps.Add(e.Location)  '第一条线段
        Else
            sps.Add(e.Location)   '其他线段
        End If
    End Sub

    Private Sub picCanvas_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Static g As Graphics = picCanvas.CreateGraphics()
        Static bkcolor As Color = picCanvas.BackColor
        '擦出旧的临时对象
        If lastelem IsNot Nothing Then
            lastelem.Draw(g, bkcolor)
        End If
        '创建新的临时对象,绘制之。一边创建，一边释放
        Dim ep As Point = e.Location
        sps.RemoveAt(sps.Count - 1) : sps.Add(ep)   ' 当前线段的新终点
        lastelem = New clsPLine(sps)
        lastelem.Draw(g, Color.Blue)
    End Sub

    Private Sub picCanvas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDoubleClick
        sps.RemoveAt(sps.Count - 1)
        polygon = New clsPolygon(sps)
        polygon.Fill(Buffer, Color.Blue)
        polygon.DrawBorder(Buffer, Color.Red)
        picCanvas.Image = Buffer
        sps = New List(Of Point)
        lastelem = Nothing
    End Sub

End Class

'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim poly As New clsPolygon
'    poly.Append(New Point(1, 7))
'    poly.Append(New Point(3, 1))
'    poly.Append(New Point(6, 5))
'    poly.Append(New Point(8, 1))
'    poly.Append(New Point(12, 9))
'    poly.Append(New Point(7, 8))
'    poly.Append(New Point(3, 12))
'    Dim buffer As Bitmap = New Bitmap(picCanvas.Width, picCanvas.Height)
'    poly.ScanFill(buffer)
'    picCanvas.Image = buffer
'End Sub
