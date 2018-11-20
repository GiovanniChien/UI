Public Class Form1
    Dim labels As List(Of Label)
    Dim ops As ClsOps

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labels = New List(Of Label)
        ops = New ClsOps
    End Sub

    Private Sub initPic_Click(sender As Object, e As EventArgs) Handles initPic.Click
        Dim dy As Integer = 50
        For i = 0 To 2
            Dim label As New Label With {
                .Location = New System.Drawing.Point(50, 30 + i * dy),
                .Size = New System.Drawing.Size(30, 30),
                .Text = i,
                .Name = "label " & i,
                .BorderStyle = BorderStyle.FixedSingle
            }
            AddHandler label.Click, AddressOf Label_clicks
            labels.Add(label)
        Next
        For i = 0 To 2
            picLbl.Controls.Add(labels(i))
        Next
    End Sub

    Private Sub Label_clicks(sender As Object, e As EventArgs)
        sender.text += 1
        Dim op As New ClsOp(sender, sender.text - 1, sender.text)
        ops.Add(op)
        lstOps.Items.Add(op.ToString)
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        ops.Undo()
    End Sub

    Private Sub redo_Click(sender As Object, e As EventArgs) Handles redo.Click
        ops.Redo()
    End Sub
End Class
