
Public Class frmTest
    Enum ToolKind
        Line
        Rectangle
    End Enum
    Dim Tool As ToolKind

    Dim WithEvents Elems As clsElems
    Dim WithEvents layers As clsLayers
    Dim sp As PointF

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tool = ToolKind.Line
        m_Tool_Line.Checked = True : m_Tool_Rectangle.Checked = False
        Elems = New clsElems
        layers = New clsLayers
        layers.Append(New clsLayer("红层", Pens.Red))
        layers.Append(New clsLayer("绿层", Pens.Green))
        layers.Append(New clsLayer("兰层", Pens.Blue))
        layers.Active = layers.Item(0)
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        sp = e.Location
    End Sub
    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        Dim ep As PointF = e.Location
        If Tool = ToolKind.Line Then
            Elems.Append(New clsLine(layers.Active, sp, ep))
        End If
        If Tool = ToolKind.Rectangle Then
            Elems.Append(New clsRectangle(layers.Active, sp, ep))
        End If
        lstElem.Items.Add(Elems.GetElem(Elems.Count - 1).ToString)
    End Sub

    Private Sub m_Tool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_Tool_Line.Click, m_Tool_Rectangle.Click
        If sender Is m_Tool_Line Then
            Tool = ToolKind.Line
            m_Tool_Line.Checked = True : m_Tool_Rectangle.Checked = False
        End If
        If sender Is m_Tool_Rectangle Then
            Tool = ToolKind.Rectangle
            m_Tool_Line.Checked = False : m_Tool_Rectangle.Checked = True
        End If
    End Sub

    Private Sub m_Layer_Manage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_Layer_Manage.Click
        Dim frm As New frmLayerManage
        frm.layers = layers
        frm.ShowDialog()
    End Sub

    Private Sub picCanvas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        Dim g As Graphics = e.Graphics
        Elems.Draw(g)
        g.Flush()
    End Sub
    Private Sub Redraw() Handles Elems.Redraw, layers.Redraw
        Dim g As Graphics = picCanvas.CreateGraphics()
        g.Clear(picCanvas.BackColor)
        Elems.Draw(g)
        g.Flush()
    End Sub
End Class
