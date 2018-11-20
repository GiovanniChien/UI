
Public Class frmTest
    Enum ToolKind
        Line
        Rectangle
        Polygon
        PointSelect
    End Enum
    Dim Tool As ToolKind

    Dim WithEvents Elems As clsElems
    Dim sp As PointF, sps As List(Of PointF)  ' sp用于存储上一个点, sps用于存储上当前点序列

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tool = ToolKind.Line
        m_Tool_Line.Checked = True : m_Tool_Rectangle.Checked = False
        sps = New List(Of PointF)
        Elems = New clsElems
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub
    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim ep As PointF = e.Location
        If Tool = ToolKind.Line Then
            Elems.Append(New clsLine(sp, ep))
            lstElem.Items.Add(Elems.Item(Elems.Count - 1).ToString)
            Return
        End If
        If Tool = ToolKind.Rectangle Then
            Elems.Append(New clsRectangle(sp, ep))
            lstElem.Items.Add(Elems.Item(Elems.Count - 1).ToString)
            Return
        End If
        If Tool = ToolKind.Polygon Then
            sps.Add(ep)
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Elems.Append(New clsPolygon(sps))
                sps.Clear()
                lstElem.Items.Add(Elems.Item(Elems.Count - 1).ToString)
            End If
            Return
        End If
        If Tool = ToolKind.PointSelect Then
            Elems.SelectByPoint(ep)
        End If
    End Sub

    Private Sub Elems_SelectionChanged() Handles Elems.SelectionChanged
        lstElem.SelectedIndices.Clear()
        For i = 0 To Elems.Count - 1
            If Elems.Selection.Contains(Elems.Item(i)) Then
                lstElem.SelectedIndices.Add(i)
            End If
        Next
        Dim g As Graphics = picCanvas.CreateGraphics()
        Elems.Draw(g)
    End Sub

    Private Sub Elems_Redraw() Handles Elems.Redraw
        Dim g As Graphics = picCanvas.CreateGraphics()
        Elems.Draw(g)
        g.Flush()
    End Sub
    Private Sub picCanvas_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        Dim g As Graphics = e.Graphics()
        Elems.Draw(g)
        g.Flush()
    End Sub

    Private Sub m_Tool_Click(sender As System.Object, e As System.EventArgs) Handles m_Tool_Line.Click, m_Tool_Rectangle.Click, m_Tool_Polygon.Click, m_Tool_PointSelect.Click
        m_Tool_Line.Checked = False : m_Tool_Rectangle.Checked = False : m_Tool_Polygon.Checked = False : m_Tool_PointSelect.Checked = False
        If sender Is m_Tool_Line Then
            Tool = ToolKind.Line : m_Tool_Line.Checked = True
        End If
        If sender Is m_Tool_Rectangle Then
            Tool = ToolKind.Rectangle : m_Tool_Rectangle.Checked = True
        End If
        If sender Is m_Tool_Polygon Then
            Tool = ToolKind.Polygon : m_Tool_Polygon.Checked = True
        End If
        If sender Is m_Tool_PointSelect Then
            Tool = ToolKind.PointSelect : m_Tool_PointSelect.Checked = True
        End If
    End Sub

End Class
