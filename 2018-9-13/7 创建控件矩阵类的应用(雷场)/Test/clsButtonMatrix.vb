Public Class clsButtonMatrix
    Private row As Integer, col As Integer
    Private Const Width As Integer = 30
    Private Const dx As Integer = 10, dy As Integer = 10
    Private Buttons As List(Of Button)
    Private mineMatrix As clsMineMatrix

    Sub New(ByVal Row As Integer, ByVal Col As Integer)
        Me.row = Row : Me.col = Col
        Buttons = New List(Of Button)
        For k = 0 To Row * Col - 1
            Dim i As Integer = Fix(k / Col), j As Integer = k Mod Col
            Dim Button1 As New Button
            Button1.Name = "Button " & i & " " & j
            Button1.Size = New System.Drawing.Size(30, 30)
            Button1.Location = New System.Drawing.Point(dy + j * (dy + Width), dx + i * (dx + Width))
            AddHandler Button1.Click, AddressOf Buttons_Click
            Buttons.Add(Button1)
        Next
        mineMatrix = New clsMineMatrix(Row, Col, 25)
    End Sub

    Friend Sub Display()
        For i = 0 To row - 1
            For j = 0 To col - 1
                Dim mineCnt As Integer = mineMatrix.IsMine(i, j)
                If mineCnt = -1 Then
                    Buttons(i * col + j).Text = "雷"
                Else
                    Buttons(i * col + j).Text = mineCnt
                End If
            Next
        Next
    End Sub

    Public Sub AppendContainer(ByVal Container As Control.ControlCollection)
        For i = 0 To Buttons.Count - 1
            Container.Add(Buttons(i))
        Next
    End Sub

    Private Sub Buttons_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim words() As String = sender.Name.ToString.Split(" ")
        Dim i As Integer = words(1), j As Integer = words(2)
        BFS(i, j)
    End Sub

    Private Sub BFS(ByVal i As Integer, ByVal j As Integer)
        Dim q As Queue(Of Point) = New Queue(Of Point)
        Dim visited(,) As Boolean
        ReDim visited(row - 1, col - 1)
        For i1 = 0 To row - 1
            For j1 = 0 To col - 1
                visited(i1, j1) = False
            Next
        Next
        q.Enqueue(New Point(i, j))
        While q.Count > 0
            Dim p As Point = q.Dequeue()
            visited(p.X, p.Y) = True
            Buttons(p.X * col + p.Y).BackColor = Color.Red
            If p.X - 1 >= 0 Then
                If visited(p.X - 1, p.Y) <> True And mineMatrix.IsMine(p.X - 1, p.Y) <> -1 Then
                    q.Enqueue(New Point(p.X - 1, p.Y))
                    visited(p.X - 1, p.Y) = True
                End If
            End If
            If p.Y - 1 >= 0 Then
                If visited(p.X, p.Y - 1) <> True And mineMatrix.IsMine(p.X, p.Y - 1) <> -1 Then
                    q.Enqueue(New Point(p.X, p.Y - 1))
                    visited(p.X, p.Y - 1) = True
                End If
            End If
            If p.Y + 1 < col Then
                If visited(p.X, p.Y + 1) <> True And mineMatrix.IsMine(p.X, p.Y + 1) <> -1 Then
                    q.Enqueue(New Point(p.X, p.Y + 1))
                    visited(p.X, p.Y + 1) = True
                End If
            End If
            If p.X + 1 < row Then
                If visited(p.X + 1, p.Y) <> True And mineMatrix.IsMine(p.X + 1, p.Y) <> -1 Then
                    q.Enqueue(New Point(p.X + 1, p.Y))
                    visited(p.X + 1, p.Y) = True
                End If
            End If
        End While
    End Sub

    Sub RemoveContainer(ByVal Container As Control.ControlCollection)
        For i = 0 To Buttons.Count - 1
            Container.Remove(Buttons(i))
        Next
    End Sub
End Class
