
Public Class frmTest
    Enum ToolKind
        Line
        Rectangle
        Polygon
    End Enum
    Dim Tool As ToolKind

    Dim WithEvents Elems As clsElems
    Dim sp As PointF            ' 临时变量,用于创建Line,Rectangle
    Dim sps As List(Of PointF)  ' 临时变量,用于创建Polygon
    Dim lastelem As clsElem = Nothing

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tool = ToolKind.Line
        m_Tool_Line.Checked = True : m_Tool_Rectangle.Checked = False
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
        If Tool = ToolKind.Polygon Then
            sps.Add(e.Location)
        End If
    End Sub
    Private Sub picCanvas_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Static g As Graphics = picCanvas.CreateGraphics()
        Static bkcolor As Color = picCanvas.BackColor
        Dim ep As PointF = e.Location
        If Tool = ToolKind.Line Then
            If lastelem IsNot Nothing Then
                lastelem.Draw(g, bkcolor)  '擦出旧的临时对象
            End If
            lastelem = New clsLine(sp, ep) '创建新的临时对象
            lastelem.Draw(g)               '绘制新的临时对象
        End If
        If Tool = ToolKind.Rectangle Then
            If lastelem IsNot Nothing Then
                lastelem.Draw(g, bkcolor)       '擦出旧的临时对象
            End If
            lastelem = New clsRectangle(sp, ep) '创建新的临时对象
            lastelem.Draw(g)                    '绘制新的临时对象
        End If
    End Sub
    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim ep As PointF = e.Location
        If Tool = ToolKind.Line Then
            lastelem = Nothing
            Elems.Append(New clsLine(sp, ep))
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
        End If
        If Tool = ToolKind.Rectangle Then
            lastelem = Nothing
            Elems.Append(New clsRectangle(sp, ep))
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
        End If
    End Sub
    Private Sub picCanvas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDoubleClick
        If Tool = ToolKind.Polygon Then
            sps.Add(e.Location)
            Elems.Append(New clsPolygon(sps))
            sps = New List(Of PointF)
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
        End If
    End Sub

    Private Sub m_Tool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_Tool_Line.Click, m_Tool_Rectangle.Click, m_Tool_Polygon.Click
        m_Tool_Line.Checked = False : m_Tool_Rectangle.Checked = False : m_Tool_Polygon.Checked = False
        If sender Is m_Tool_Line Then
            Tool = ToolKind.Line : m_Tool_Line.Checked = True
        End If
        If sender Is m_Tool_Rectangle Then
            Tool = ToolKind.Rectangle : m_Tool_Rectangle.Checked = True
        End If
        If sender Is m_Tool_Polygon Then
            Tool = ToolKind.Polygon : m_Tool_Polygon.Checked = True
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
