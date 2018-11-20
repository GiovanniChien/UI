public Enum Status
    DrawPolygon
    SelectVertex
    MoveVertex
    RemoveVertex
    InsertVertex
End Enum

Public Class frmTest
    Dim polygons As clsPolygons   ' 核心数据对象
    Dim points As List(Of PointF) ' 辅助点集，用于构造单个多边形
    Dim Tool As Status
    Dim MoveOrigin As PointF      ' 修改多边形端点时的移动起点
    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tool = Status.DrawPolygon : SetToolMenu()
        polygons = New clsPolygons
        points = New List(Of PointF)
    End Sub

    Private Sub picCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDown
        If Tool = Status.DrawPolygon Then
            points.Add(e.Location)
        End If
        If Tool = Status.SelectVertex Then
            polygons.SelectVertex(e.Location)
        End If
        If Tool = Status.MoveVertex Then
            MoveOrigin = e.Location
        End If
    End Sub
    Private Sub picCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseUp
        If Tool = Status.MoveVertex Then
            Dim offset As PointF
            offset.X = e.Location.X - MoveOrigin.X : offset.Y = e.Location.Y - MoveOrigin.Y
            polygons.VertexMove(offset)
        End If
        If Tool = Status.InsertVertex Then
            polygons.InsertVertex(e.Location)
        End If
    End Sub

    Private Sub picCanvas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picCanvas.MouseDoubleClick
        points.RemoveAt(points.Count - 1)
        Dim Polygon As New clsPolygon(points)
        AddHandler Polygon.ActiveVertexChanged, AddressOf Draw
        polygons.Append(Polygon)
        points = New List(Of PointF)
        Dim g As Graphics = picCanvas.CreateGraphics
        Draw(g)
    End Sub

    Private Sub picCanvas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picCanvas.Paint
        If polygons Is Nothing Then Return
        Dim g As Graphics = e.Graphics
        Draw(g)
    End Sub

    Private Sub Draw(Optional ByVal g As Graphics = Nothing)
        If g Is Nothing Then g = picCanvas.CreateGraphics
        g.Clear(picCanvas.BackColor)
        polygons.Draw(g)
    End Sub

    Private Sub m_Tool_DrawPolygon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_Tool_DrawPolygon.Click, m_Tool_SelectVertex.Click, m_Tool_MoveVertex.Click, m_Tool_RemoveVertex.Click, m_Tool_InsertVertex.Click
        If sender Is m_Tool_DrawPolygon Then Tool = Status.DrawPolygon
        If sender Is m_Tool_SelectVertex Then Tool = Status.SelectVertex
        If sender Is m_Tool_MoveVertex Then Tool = Status.MoveVertex
        If sender Is m_Tool_RemoveVertex Then
            Tool = Status.RemoveVertex
            polygons.VertexRemove()
        End If

        If sender Is m_Tool_InsertVertex Then Tool = Status.InsertVertex
        SetToolMenu()
    End Sub
    Sub SetToolMenu()
        m_Tool_DrawPolygon.Checked = False
        m_Tool_SelectVertex.Checked = False
        m_Tool_MoveVertex.Checked = False
        m_Tool_RemoveVertex.Checked = False
        m_Tool_InsertVertex.Checked = False
        If Tool = Status.DrawPolygon Then m_Tool_DrawPolygon.Checked = True
        If Tool = Status.SelectVertex Then m_Tool_SelectVertex.Checked = True
        If Tool = Status.MoveVertex Then m_Tool_MoveVertex.Checked = True
        If Tool = Status.RemoveVertex Then m_Tool_RemoveVertex.Checked = True
        If Tool = Status.InsertVertex Then m_Tool_InsertVertex.Checked = True
    End Sub


End Class
