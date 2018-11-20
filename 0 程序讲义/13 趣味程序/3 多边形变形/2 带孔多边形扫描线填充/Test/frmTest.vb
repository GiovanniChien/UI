Public Class frmTest
    Dim Buffer As Bitmap
    Dim polygon As clsPolygon
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Buffer = New Bitmap(picCanvas.Width, picCanvas.Height)
        Dim OutPoints As New List(Of Point)
        OutPoints.Add(New Point(75, 125))
        OutPoints.Add(New Point(151, 34))
        OutPoints.Add(New Point(292, 37))
        OutPoints.Add(New Point(353, 110))
        OutPoints.Add(New Point(327, 240))
        OutPoints.Add(New Point(165, 256))
        OutPoints.Add(New Point(44, 215))
        OutPoints.Add(New Point(140, 216))
        OutPoints.Add(New Point(24, 170))
        OutPoints.Add(New Point(83, 152))
        OutPoints.Add(New Point(52, 136))

        Dim InPointss As New List(Of List(Of Point))
        Dim InPoints1 As New List(Of Point)
        InPoints1.Add(New Point(264, 196))
        InPoints1.Add(New Point(279, 211))
        InPoints1.Add(New Point(299, 176))
        InPoints1.Add(New Point(274, 166))
        InPoints1.Add(New Point(273, 183))
        InPointss.Add(InPoints1)

        Dim InPoints2 As New List(Of Point)
        InPoints2.Add(New Point(275, 96))
        InPoints2.Add(New Point(286, 109))
        InPoints2.Add(New Point(306, 92))
        InPoints2.Add(New Point(290, 84))
        InPointss.Add(InPoints2)

        polygon = New clsPolygon(OutPoints, InPointss)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        polygon.Fill(Buffer, Color.Blue)
        polygon.DrawBorder(Buffer, Color.Red)
        picCanvas.Image = Buffer
    End Sub
End Class

'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
'    Dim poly As New clsPolygon
'    poly.Append(New Point(1, 7))
'    poly.Append(New Point(3, 1))
'    poly.Append(New Point(6, 5))
'    poly.Append(New Point(8, 1))
'    poly.Append(New Point(12, 9))
'    poly.Append(New Point(7, 8))
'    poly.Append(New Point(3, 12))
'    Dim buffer As Bitmap = New Bitmap(picCanvas.Width, picCanvas.Height)
'    poly.ScanFill(buffer)
'    picCanvas.Image = buffer
'End Sub
