Public Class frmTest
    Enum ToolKind
        Line
        Rectangle
        Polygon
    End Enum

    Dim Tool As ToolKind

    Dim WithEvents Elems As clsElems
    Dim sp As PointF, sps As List(Of PointF)  ' sp用于存储上一个点, sps用于存储上当前点序列（端点集）

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tool = ToolKind.Line
        m_Tool_Line.Checked = True : m_Tool_Rectangle.Checked = False
        sps = New List(Of PointF)
        Elems = New clsElems
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer1.MouseDown, picCanvas.MouseDown, lstElem.MouseDown
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
    ' 完成简单对象的建立
    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SplitContainer1.MouseUp, picCanvas.MouseUp, lstElem.MouseUp
        Dim ep As PointF = e.Location
        If Tool = ToolKind.Line Then
            Elems.Append(New clsLine(sp, ep))
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
        End If
        If Tool = ToolKind.Rectangle Then
            Elems.Append(New clsRectangle(sp, ep))
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
        End If
    End Sub
    ' 完成复杂对象的建立  (细节：DoubleClick之前，发生过两次MouseDown)
    Private Sub picCanvas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDoubleClick
        If Tool = ToolKind.Polygon Then
            sps.RemoveAt(sps.Count - 1)
            Elems.Append(New clsPolygon(sps))
            lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
            sps = New List(Of PointF)
        End If
    End Sub

    Private Sub Redraw(ByVal g As Graphics)
        Elems.Draw(g)
        g.Flush()
    End Sub
    Private Sub Lines_Redraw() Handles Elems.Redraw
        Dim g As Graphics = picCanvas.CreateGraphics()
        Redraw(g)
    End Sub
    Private Sub picCanvas_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        Dim g As Graphics = e.Graphics()
        Redraw(g)
    End Sub

    Private Sub m_Tool_Click(sender As System.Object, e As System.EventArgs) Handles m_Tool_Line.Click, m_Tool_Rectangle.Click, m_Tool_Polygon.Click
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

End Class
