
Public Class frmTest
    Enum ToolKind
        Line
        Rectangle
    End Enum
    Dim Tool As ToolKind

    Dim WithEvents Lines As clsLines, Rectangles As clsRectangles
    Dim sp As PointF

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tool = ToolKind.Line
        m_Tool_Line.Checked = True : m_Tool_Rectangle.Checked = False
        Lines = New clsLines
        Rectangles = New clsRectangles
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub
    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim ep As PointF = e.Location
        If Tool = ToolKind.Line Then
            Lines.Append(New clsLine(sp, ep))
        End If
        If Tool = ToolKind.Rectangle Then
            Rectangles.Append(New clsRectangle(sp, ep))
        End If
    End Sub

    Private Sub Lines_Redraw() Handles Lines.Redraw, Rectangles.Redraw
        Dim g As Graphics = picCanvas.CreateGraphics()
        Lines.Draw(g)
        Rectangles.Draw(g)
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
