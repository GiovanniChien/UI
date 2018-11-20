
Public Class frmTest
    Enum ToolKind
        Line
        Rectangle
    End Enum
    Dim Tool As ToolKind

    Dim WithEvents Elems As clsElems
    Dim sp As PointF
    Dim layer As clsLayer

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tool = ToolKind.Line
        m_Tool_Line.Checked = True : m_Tool_Rectangle.Checked = False
        Elems = New clsElems
        layer = New clsLayer(Pens.Black)
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub
    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim ep As PointF = e.Location
        If Tool = ToolKind.Line Then
            Elems.Append(New clsLine(layer, sp, ep))
        End If
        If Tool = ToolKind.Rectangle Then
            Elems.Append(New clsRectangle(layer, sp, ep))
        End If
        lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
    End Sub

    Private Sub Lines_Redraw() Handles Elems.Redraw
        Dim g As Graphics = picCanvas.CreateGraphics()
        Elems.Draw(g)
        g.Flush()
    End Sub

    Private Sub m_Tool_Click(sender As System.Object, e As System.EventArgs) Handles m_Tool_Line.Click, m_Tool_Rectangle.Click
        If sender Is m_Tool_Line Then
            Tool = ToolKind.Line
            m_Tool_Line.Checked = True : m_Tool_Rectangle.Checked = False
        End If
        If sender Is m_Tool_Rectangle Then
            Tool = ToolKind.Rectangle
            m_Tool_Line.Checked = False : m_Tool_Rectangle.Checked = True
        End If
    End Sub

End Class
