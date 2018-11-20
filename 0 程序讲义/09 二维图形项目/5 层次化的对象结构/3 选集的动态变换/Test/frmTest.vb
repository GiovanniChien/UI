
Public Class frmTest
    Enum ToolKind
        Line
        Rectangle
        Polygon
        PointSelect
        Tranform_Pan
        Tranform_Scale
        Tranform_Rotate
        Tranform_RotatePoint
        Tranform_SymLine
    End Enum

    Dim Tool As ToolKind
    Dim WithEvents Elems As clsElems
    Dim Shadow As clsSelection    ' 被拖动的选集的影子
    Dim sp As PointF, sps As List(Of PointF)  ' sp用于存储上一个点, sps用于存储上当前点序列
    Dim LastM, M As clsMatrix3   ' 拖动过程中的"上一次矩阵LastM"和"当前矩阵M"

    Private Sub frmTest_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Tool = ToolKind.Rectangle : SetToolMenu(Tool)
        sps = New List(Of PointF)
        Elems = New clsElems : Shadow = Nothing
        M = New clsMatrix3
    End Sub

    Private Sub picCanvas_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Return
        sp = e.Location
        If Tool = ToolKind.Tranform_Pan Or Tool = ToolKind.Tranform_Rotate Or Tool = ToolKind.Tranform_Scale Then
            Shadow = Elems.Selection.Clone()
            LastM = Nothing
        End If
    End Sub
    Private Sub picCanvas_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Return
        If Tool = ToolKind.Line Or Tool = ToolKind.Rectangle Or Tool = ToolKind.Polygon Or Tool = ToolKind.PointSelect Then
            Return
        End If
        Dim ep As PointF = e.Location  ' 此刻的终点
        ' 拖动的过程：擦除旧的影子，绘制新的影子
        Static sp As PointF            ' 动态的起点，一步步移向ep (拖动过程中Me.sp保持不变)
        If LastM Is Nothing Then
            sp = Me.sp                 ' 拖动开始时的起点
        Else
            Shadow.Draw(picCanvas.CreateGraphics, LastM, ObjectState.None)  ' 擦出旧的影子
        End If
        If Tool = ToolKind.Tranform_Pan Then
            M.SetPan(ep.X - sp.X, ep.Y - sp.Y)     ' 影子移动一小步
        End If
        If Tool = ToolKind.Tranform_Rotate Then
            Dim angle As Single = Math.Atan2(ep.Y, ep.X) - Math.Atan2(sp.Y, sp.X)
            M.SetRotate(angle)                     ' 影子旋转一小角
        End If
        If Tool = ToolKind.Tranform_Scale Then
            Dim scaleX As Single = ep.X / sp.X, scaleY As Single = ep.Y / sp.Y
            M.SetScale(scaleX, scaleY)             ' 影子缩放一小比例
        End If
        Shadow.Transform(M)
        Shadow.Draw(picCanvas.CreateGraphics, M, ObjectState.Drag)  ' 绘制新的影子
        LastM = M
        sp = ep
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
            Return
        End If
        ' 拖动的结果：对图形对象集合进行
        Dim m As clsMatrix3 = New clsMatrix3
        If Tool = ToolKind.Tranform_Pan Then
            Dim dx As Single = ep.X - sp.X, dy As Single = ep.Y - sp.Y
            m.SetPan(dx, dy)
        End If
        If Tool = ToolKind.Tranform_Rotate Then
            Dim angle As Single = Math.Atan2(ep.Y, ep.X) - Math.Atan2(sp.Y, sp.X)
            m.SetRotate(angle)
        End If
        If Tool = ToolKind.Tranform_Scale Then
            Dim scaleX As Single = ep.X / sp.X, scaleY As Single = ep.Y / sp.Y
            m.SetScale(scaleX, scaleY)
        End If
        Elems.Transform(m)
        Shadow = Elems.Selection.Clone()
    End Sub

    Private Sub Elems_SelectionChanged() Handles Elems.SelectionChanged
        lstElem.SelectedIndices.Clear()
        For i = 0 To Elems.Count - 1
            If Elems.Selection.Contains(Elems.Item(i)) Then
                lstElem.SelectedIndices.Add(i)
            End If
        Next
        Redraw(picCanvas.CreateGraphics())
    End Sub

    Private Sub Elems_Redraw() Handles Elems.Redraw
        Redraw(picCanvas.CreateGraphics())
    End Sub
    Private Sub picCanvas_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        Redraw(e.Graphics())
    End Sub
    Private Sub Redraw(ByVal g As Graphics)
        g.Clear(picCanvas.BackColor)
        Dim m As New clsMatrix3   '单位阵
        Elems.Draw(g, m)
        g.Flush()
    End Sub

    Private Sub m_Tool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_Tool_Line.Click, m_Tool_Rectangle.Click, m_Tool_Polygon.Click, m_Tool_PointSelect.Click, m_Tranform_Pan.Click, m_Tranform_Rotate.Click, m_Tranform_Scale.Click, m_Tranform_RotatePoint.Click, m_Tranform_SymLine.Click
        If sender Is m_Tool_Line Then Tool = ToolKind.Line
        If sender Is m_Tool_Rectangle Then Tool = ToolKind.Rectangle
        If sender Is m_Tool_Polygon Then Tool = ToolKind.Polygon
        If sender Is m_Tool_PointSelect Then Tool = ToolKind.PointSelect
        If sender Is m_Tranform_Pan Then Tool = ToolKind.Tranform_Pan
        If sender Is m_Tranform_Rotate Then Tool = ToolKind.Tranform_Rotate
        If sender Is m_Tranform_Scale Then Tool = ToolKind.Tranform_Scale
        If sender Is m_Tranform_RotatePoint Then Tool = ToolKind.Tranform_RotatePoint
        If sender Is m_Tranform_SymLine Then Tool = ToolKind.Tranform_SymLine
        SetToolMenu(Tool)
    End Sub
    Private Sub SetToolMenu(ByVal tool As ToolKind)
        m_Tool_Line.Checked = False : m_Tool_Rectangle.Checked = False
        m_Tool_Polygon.Checked = False : m_Tool_PointSelect.Checked = False
        m_Tranform_Pan.Checked = False
        m_Tranform_Rotate.Checked = False
        m_Tranform_Scale.Checked = False
        m_Tranform_RotatePoint.Checked = False : m_Tranform_SymLine.Checked = False
        If tool = ToolKind.Line Then m_Tool_Line.Checked = True
        If tool = ToolKind.Rectangle Then m_Tool_Rectangle.Checked = True
        If tool = ToolKind.Polygon Then m_Tool_Polygon.Checked = True
        If tool = ToolKind.PointSelect Then m_Tool_PointSelect.Checked = True
        If tool = ToolKind.Tranform_Pan Then m_Tranform_Pan.Checked = True
        If tool = ToolKind.Tranform_Scale Then m_Tranform_Scale.Checked = True
        If tool = ToolKind.Tranform_Rotate Then m_Tranform_Rotate.Checked = True
        If tool = ToolKind.Tranform_RotatePoint Then m_Tranform_RotatePoint.Checked = True
        If tool = ToolKind.Tranform_SymLine Then m_Tranform_SymLine.Checked = True
    End Sub

    Private Sub m_CombinedTranform(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_Tranform_RotatePoint.Click, m_Tranform_SymLine.Click
        Dim M1, M2, M3, M4, M5 As clsMatrix3
        If sender Is m_Tranform_RotatePoint Then
            Tool = ToolKind.Tranform_RotatePoint
            Dim p As PointF = New PointF(100, 100)
            Dim angle As Single = 20 / 180 * Math.PI
            M1 = New clsMatrix3 : M1.SetPan(-p.X, -p.Y)
            M2 = New clsMatrix3 : M2.SetRotate(angle)
            M3 = New clsMatrix3 : M3.SetPan(p.X, p.Y)
            M1.Mul(M2) : M1.Mul(M3)
            Elems.Transform(M1)
        End If
        If sender Is m_Tranform_SymLine Then
            Tool = ToolKind.Tranform_SymLine
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

End Class
