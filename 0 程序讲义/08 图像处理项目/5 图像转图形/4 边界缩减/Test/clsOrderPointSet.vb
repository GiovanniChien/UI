
Public Class clsOrderPointSet
    Private Points As List(Of Point)

    Public Sub New()
        Me.Points = New List(Of Point)
    End Sub

    Public Sub Add(p As Point)
        Me.Points.Add(p)
    End Sub

    Public Overrides Function ToString() As String
        Dim s As String = ""
        For i = 0 To Points.Count - 1
            s = s & Points(i).X & "," & Points(i).Y & vbTab
        Next
        Return s
    End Function

    ' 直线拟合点集合Points为新的多边形
    Public Function Fit() As String
        Dim k As Integer = 10
        Dim LSs As New List(Of LineSegment)   '新多边形的方程系数的向量
        For i = 0 To Points.Count - 1 Step k
            Dim pts As New List(Of Point)
            For j = 0 To k - 1
                If i + j < Points.Count Then
                    pts.Add(Points(i + j))
                End If
            Next
            Dim fitline As clsFitLineSegment = New clsFitLineSegment(pts)
            LSs.Add(fitline.GetLineSegment())
        Next
        Dim fitpolygon As clsFitPolygon = New clsFitPolygon(LSs)
        Return fitpolygon.ToString
    End Function

End Class
