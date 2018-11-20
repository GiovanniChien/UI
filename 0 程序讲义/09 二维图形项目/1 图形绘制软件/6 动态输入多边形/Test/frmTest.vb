
Public Class frmTest
    Enum ToolKind
        Line
        Rectangle
        Polygon
        PLine
    End Enum
    Dim Tool As ToolKind

    Dim WithEvents Elems As clsElems
    Dim sp As PointF            ' 临时变量,用于创建Line,Rectangle
    Dim sps As List(Of PointF)  ' 临时变量,用于创建Polygon,PLine
    Dim lastelem As clsElem = Nothing

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tool = ToolKind.Polygon
        m_Tool_Line.Checked = False : m_Tool_Rectangle.Checked = False : m_Tool_Polygon.Checked = True
        sps = New List(Of PointF)
        Elems = New clsElems
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        If Tool = ToolKind.Line Then
            sp = e.Location
        End If
        If Tool = ToolKind.Rectangle Then
            sp = e.Location
        End If
        If Tool = ToolKind.PLine Or Tool = ToolKind.Polygon Then
            ' 设定当前线段的已经确定的起点，正待调整的终点
            If sps.Count = 0 Then
                sps.Add(e.Location) : sps.Add(e.Location)  '第一条线段
            Else
                sps.Add(e.Location)   '其他线段
            End If
        End If
    End Sub
    ' 实现图形对象创建过程中的橡皮筋技术
    Private Sub picCanvas_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Static g As Graphics = picCanvas.CreateGraphics()
        Static bkcolor As Color = picCanvas.BackColor
        '擦出旧的临时对象
        If lastelem IsNot Nothing Then
            lastelem.Draw(g, bkcolor)
        End If
        '创建新的临时对象,绘制之。一边创建，一边释放
        Dim ep As PointF = e.Location
        If Tool = ToolKind.Line Then
            lastelem = New clsLine(sp, ep) : lastelem.Draw(g)
        End If
        If Tool = ToolKind.Rectangle Then
            lastelem = New clsRectangle(sp, ep) : lastelem.Draw(g)
        End If
        If Tool = ToolKind.PLine Or Tool = ToolKind.Polygon Then
            sps.RemoveAt(sps.Count - 1) : sps.Add(ep)   ' 当前线段的新终点
            lastelem = New clsPLine(sps)
            lastelem.Draw(g)
        End If
    End Sub
    ' 完成简单对象的建立
    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim ep As PointF = e.Location
        If Tool = ToolKind.Line Then
            Elems.Append(New clsLine(sp, ep))
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
            lastelem = Nothing
        End If
        If Tool = ToolKind.Rectangle Then
            Elems.Append(New clsRectangle(sp, ep))
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
            lastelem = Nothing
        End If
    End Sub
    ' 完成复杂对象的建立  (细节：DoubleClick之前，发生过两次MouseDown)
    Private Sub picCanvas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDoubleClick
        If Tool = ToolKind.PLine Then
            sps.RemoveAt(sps.Count - 1)
            Elems.Append(New clsPLine(sps))
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
            sps = New List(Of PointF)
            lastelem = Nothing
        End If
        If Tool = ToolKind.Polygon Then
            sps.RemoveAt(sps.Count - 1)
            Elems.Append(New clsPolygon(sps))
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
            sps = New List(Of PointF)
            lastelem = Nothing
        End If
    End Sub

    Private Sub m_Tool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_Tool_Line.Click, m_Tool_Rectangle.Click, m_Tool_Polygon.Click, m_Tool_PLine.Click
        m_Tool_Line.Checked = False : m_Tool_Rectangle.Checked = False : m_Tool_Polygon.Checked = False : m_Tool_PLine.Checked = False
        If sender Is m_Tool_Line Then
            Tool = ToolKind.Line : m_Tool_Line.Checked = True
        End If
        If sender Is m_Tool_Rectangle Then
            Tool = ToolKind.Rectangle : m_Tool_Rectangle.Checked = True
        End If
        If sender Is m_Tool_Polygon Then
            Tool = ToolKind.Polygon : m_Tool_Polygon.Checked = True
            sps = New List(Of PointF)
            lastelem = New clsPLine(sps)    '创建新的临时对象
        End If
        If sender Is m_Tool_PLine Then
            Tool = ToolKind.PLine : m_Tool_PLine.Checked = True
            sps = New List(Of PointF)
            lastelem = New clsPLine(sps)    '创建新的临时对象
        End If
    End Sub
    Private Sub Redraw(ByVal g As Graphics)
        Elems.Draw(g)
        g.Flush()
    End Sub
    Private Sub Elems_Redraw() Handles Elems.Redraw
        Dim g As Graphics = picCanvas.CreateGraphics()
        Redraw(g)
    End Sub
    Private Sub picCanvas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        Dim g As Graphics = e.Graphics()
        Redraw(g)
    End Sub

    
End Class
