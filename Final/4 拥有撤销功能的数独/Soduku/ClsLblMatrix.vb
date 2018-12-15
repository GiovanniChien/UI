Public Class ClsLblMatrix
    Private Const row As Integer = 9
    Private Const col As Integer = 9
    Private Const delta As Integer = 20
    'Private Const dx As Integer = 10, dy As Integer = 10
    Private Const width As Integer = 30
    Private labels(,) As Label
    Private numMatrix(8, 8) As Integer
    Private waitSolveMatrix(8, 8) As Integer
    Private originalMatrix(8, 8) As Integer
    Private picLblMatrix As PictureBox

    Public Sub New(ByVal picLblMatrix As PictureBox, ByVal hard As Integer)
        Me.picLblMatrix = picLblMatrix
        Dim numMatrix As ClsNumMatrix = New ClsNumMatrix(hard)
        For i = 0 To 8
            For j = 0 To 8
                Me.numMatrix(i, j) = numMatrix.GetWaitSolveMatrix(i, j)
                originalMatrix(i, j) = numMatrix.GetWaitSolveMatrix(i, j)
                waitSolveMatrix(i, j) = numMatrix.GetWaitSolveMatrix(i, j)
            Next
        Next
        'originalMatrix = Me.numMatrix
        'waitSolveMatrix = Me.numMatrix
        '画标签矩阵的边框
        AddHandler picLblMatrix.Paint, AddressOf picLblMatrix_Paint
        InitLbls()
        'DrawBorder()
    End Sub

    Public Sub Remove()
        For i = 0 To 8
            For j = 0 To 8
                picLblMatrix.Controls.Remove(labels(i, j))
            Next
        Next
    End Sub

    Private Sub picLblMatrix_Paint(sender As Object, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        Dim pen As Pen = New Pen(Color.Black, 3)
        g.Clear(Color.White)
        '画初始有数字的格子的背景色
        For i = 0 To 8
            For j = 0 To 8
                If numMatrix(i, j) <> 0 Then
                    Dim p As Point = New Point(delta + j * (width), delta + i * (width))
                    Dim grayBrush As SolidBrush = New SolidBrush(Color.FromArgb(200, 200, 200))
                    g.FillRectangle(grayBrush, p.X, p.Y, width, width)
                End If
            Next
        Next
        '画所有的横线
        For i = 0 To 3
            Dim sp As Point = New Point(delta, delta + i * (width * 3))
            Dim ep As Point = New Point(delta + 9 * width, delta + i * (width * 3))
            g.DrawLine(pen, sp, ep)
        Next
        '画所有的竖线
        For i = 0 To 3
            Dim sp As Point = New Point(delta + i * (3 * width), delta)
            Dim ep As Point = New Point(delta + i * (3 * width), delta + 9 * width)
            g.DrawLine(pen, sp, ep)
        Next
    End Sub

    '初始化显示数独的标签矩阵
    Private Sub InitLbls()
        ReDim labels(row - 1, col - 1)
        For i = 0 To row - 1
            For j = 0 To col - 1
                Dim label As Label
                If numMatrix(i, j) <> 0 Then
                    label = New Label With {
                        .Name = "Label " & i & " " & j,
                        .Size = New System.Drawing.Size(width, width),
                        .Location = New System.Drawing.Point(delta + j * (width), delta + i * (width)),
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .BackColor = Color.Transparent,
                        .Parent = picLblMatrix,'让标签的父标签为picLblMatrix,设置标签backColor为Transparent实现（假）透明效果
                        .BorderStyle = BorderStyle.FixedSingle
                    }
                    label.Text = numMatrix(i, j).ToString
                Else
                    label = New Label With {
                        .Name = "Label " & i & " " & j,
                        .Size = New System.Drawing.Size(width, width),
                        .Location = New System.Drawing.Point(delta + j * (width), delta + i * (width)),
                        .Cursor = Cursors.IBeam,
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .BackColor = Color.Transparent,
                        .Parent = picLblMatrix,'让标签的父标签为picLblMatrix,设置标签backColor为Transparent实现（假）透明效果
                        .BorderStyle = BorderStyle.FixedSingle
                    }
                    AddHandler label.Click, AddressOf BtnMatrixs_clicks
                End If
                labels(i, j) = label
            Next
        Next
        For i = 0 To row - 1
            For j = 0 To row - 1
                picLblMatrix.Controls.Add(labels(i, j))
                'labels(i, j).SendToBack()
            Next
        Next
    End Sub

    Private Sub BtnMatrixs_clicks(sender As Object, e As EventArgs)
        Dim btnSugs As ClsLblSugs = New ClsLblSugs(sender, picLblMatrix, waitSolveMatrix)
    End Sub

    Public Sub Restart()
        For i = 0 To 8
            For j = 0 To 8
                waitSolveMatrix(i, j) = originalMatrix(i, j)
            Next
        Next
        Remove()
        InitLbls()
        frmTest.ops = New ClsOps
        frmTest.SetMenuRedoStatus(False)
        frmTest.SetMenuUndoStatus(False)
    End Sub
End Class