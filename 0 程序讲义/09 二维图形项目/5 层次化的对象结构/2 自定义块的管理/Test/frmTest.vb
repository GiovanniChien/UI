
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
    Dim block As clsBlock

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
        g.Clear(picCanvas.BackColor)
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

    Private Sub m_Tranform_Click(sender As System.Object, e As System.EventArgs) Handles m_Tranform_Pan.Click, m_Tranform_Rotate.Click, m_Tranform_Scale.Click
        Dim m As clsMatrix3 = New clsMatrix3
        If sender Is m_Tranform_Pan Then m.SetPan(10, 10)
        If sender Is m_Tranform_Rotate Then m.SetRotate(30 / 180 * Math.PI)
        If sender Is m_Tranform_Scale Then m.SetScale(0.5, 0.5)
        Elems.Transform(m)
    End Sub

    Private Sub m_CombinedTranform(sender As System.Object, e As System.EventArgs) Handles m_Tranform_RotatePoint.Click, m_Tranform_SymLine.Click
        Dim M1, M2, M3, M4, M5 As clsMatrix3
        If sender Is m_Tranform_RotatePoint Then
            Dim p As PointF = New PointF(100, 100)
            Dim angle As Single = 20 / 180 * Math.PI
            M1 = New clsMatrix3 : M1.SetPan(-p.X, -p.Y)
            M2 = New clsMatrix3 : M2.SetRotate(angle)
            M3 = New clsMatrix3 : M3.SetPan(p.X, p.Y)
            M1.Mul(M2) : M1.Mul(M3)
            Elems.Transform(M1)
        End If
        If sender Is m_Tranform_SymLine Then
            Dim A As Single = 1, B As Single = -1, C As Single = 0  'Ax+By+C=0
            Dim angle As Single = Math.Atan2(-A, B)
            M1 = New clsMatrix3 : M1.SetPan(C / A, 0)
            M2 = New clsMatrix3 : M2.SetRotate(-angle)
            M3 = New clsMatrix3 : M3.SetScale(1, -1)
            M4 = New clsMatrix3 : M4.SetRotate(angle)
            M5 = New clsMatrix3 : M5.SetPan(-C / A, 0)
            M1.Mul(M2) : M1.Mul(M3) : M1.Mul(M4) : M1.Mul(M5)
            Elems.Transform(M1)
        End If
    End Sub

    Private Sub m_Block_Define_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_Block_Define.Click
        If Elems.Selection.Count = 0 Then Return
        Dim basepoint As PointF = New PointF(0, 0)
        block = New clsBlock(Elems.Selection, basepoint)
    End Sub
    Private Sub m_Block_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_Block_Insert.Click
        If block Is Nothing Then Return
        Dim blockinsert As clsBlockInsert
        Dim m As New clsMatrix3
        m.SetPan(100, 100)
        blockinsert = New clsBlockInsert(block, m)
        Elems.Append(blockinsert)
        lstElem.Items.Add(Elems.Item(Elems.Count - 1).ToString)
    End Sub
End Class
