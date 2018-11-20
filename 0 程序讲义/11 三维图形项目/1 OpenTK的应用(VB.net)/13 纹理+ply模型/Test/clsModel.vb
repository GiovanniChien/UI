Imports OpenTK
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing.Imaging
Imports System.IO

Public Class clsBox3
    Public xmin, xmax As Single
    Public ymin, ymax As Single
    Public zmin, zmax As Single

    Sub New()
        Me.xmin = 0 : Me.xmax = 0
        Me.ymin = 0 : Me.ymax = 0
        Me.zmin = 0 : Me.zmax = 0
    End Sub

    Sub New(ByVal xmin As Integer, ByVal xmax As Integer, ByVal ymin As Integer, ByVal ymax As Integer, ByVal zmin As Integer, ByVal zmax As Integer)
        Me.xmin = xmin : Me.xmax = xmax
        Me.ymin = ymin : Me.ymax = ymax
        Me.zmin = zmin : Me.zmax = zmax
    End Sub

    Sub New(ByVal Points As List(Of Vector3))
        xmin = Points(0).X : xmax = Points(0).X
        ymin = Points(0).Y : ymax = Points(0).Y
        zmin = Points(0).Z : zmax = Points(0).Z
        For i = 1 To Points.Count - 1
            If Points(i).X < xmin Then xmin = Points(i).X
            If Points(i).X > xmax Then xmax = Points(i).X
            If Points(i).Y < ymin Then ymin = Points(i).Y
            If Points(i).Y > ymax Then ymax = Points(i).Y
            If Points(i).Z < zmin Then zmin = Points(i).Z
            If Points(i).Z > zmax Then zmax = Points(i).Z
        Next
    End Sub
    Public Function Wx() As Single
        Return xmax - xmin
    End Function
    Public Function Wy() As Single
        Return ymax - ymin
    End Function
    Public Function Wz() As Single
        Return zmax - zmin
    End Function

    Public Function GetMid() As Vector3
        Return New Vector3((xmin + xmax) / 2, (ymin + ymax) / 2, (zmin + zmax) / 2)
    End Function

    Public Function XToString() As String
        XToString = Format(Wx, "0.00") & "[" & Format(xmin, "0.00") & "," & Format(xmax, "0.00") & "]"
    End Function
    Public Function YToString() As String
        YToString = Format(WY, "0.00") & "[" & Format(ymin, "0.00") & "," & Format(ymax, "0.00") & "]"
    End Function
    Public Function ZToString() As String
        ZToString = Format(WZ, "0.00") & "[" & Format(zmin, "0.00") & "," & Format(zmax, "0.00") & "]"
    End Function
End Class


Class clsModel
    Private Points As List(Of Vector3)
    Private Faces As List(Of clsFace)
    Private TextureID As Integer
    Public Box As clsBox3
    Public Node As New TreeNode

    Sub New(ByVal plyfile As String)
        InitNode()
        Const PrefixFile As String = "comment TextureFile "
        Const PrefixVertex As String = "element vertex "
        Const PrefixFace As String = "element face "
        Using fs As New IO.FileStream(plyfile, FileMode.Open)
            Using sr As New StreamReader(fs, System.Text.Encoding.Default)
                Dim line As String
                For i = 1 To 4
                    line = sr.ReadLine()
                Next
                Dim bmpfile As String = line.Substring(PrefixFile.Length)
                SetTexture(bmpfile)
                line = sr.ReadLine()
                Dim VertexCount As Integer = line.Substring(PrefixVertex.Length)
                For i = 1 To 4
                    line = sr.ReadLine()
                Next
                Dim FaceCount As Integer = line.Substring(PrefixFace.Length)
                For i = 1 To 3
                    line = sr.ReadLine()
                Next
                '构造点集对象
                Points = New List(Of Vector3)
                For i = 1 To VertexCount
                    Points.Add(TransVector3(sr.ReadLine()))
                Next
                Faces = New List(Of clsFace)
                For i = 1 To FaceCount
                    Faces.Add(TransFace(sr.ReadLine()))
                Next
            End Using
        End Using
        Box = New clsBox3(Points)
    End Sub

    Private Function TransFace(ByVal line As String) As clsFace
        Dim elem() As String = line.Split(" ")
        Dim PointID(2) As Integer, TexCoord(5) As Single
        PointID(0) = elem(1)
        PointID(1) = elem(2)
        PointID(2) = elem(3)
        TexCoord(0) = elem(5)
        TexCoord(1) = elem(6)
        TexCoord(2) = elem(7)
        TexCoord(3) = elem(8)
        TexCoord(4) = elem(9)
        TexCoord(5) = elem(10)
        Return New clsFace(PointID, TexCoord)
    End Function
    Private Function TransVector3(ByVal line As String) As Vector3
        Dim Coord() As String = line.Split(" ")
        Return New Vector3(Coord(0), Coord(1), Coord(2))
    End Function

    Private Sub SetTexture(ByVal bmpfile As String)
        GL.GenTextures(1, TextureID)
        GL.BindTexture(TextureTarget.Texture2D, TextureID)

        Dim TextureBmp As Bitmap = New Bitmap(bmpfile)
        Dim rect As New Rectangle(0, 0, TextureBmp.Width, TextureBmp.Height)
        Dim bmpData As BitmapData
        bmpData = TextureBmp.LockBits(rect, ImageLockMode.ReadOnly, Imaging.PixelFormat.Format32bppArgb)
        GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, bmpData.Width, bmpData.Height, 0, Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, bmpData.Scan0)
        TextureBmp.UnlockBits(bmpData)
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, TextureMinFilter.Linear)
    End Sub

    Public Sub Render()
        GL.BindTexture(TextureTarget.ProxyTexture2D, 1)
        For i = 0 To Faces.Count - 1
            Dim p1 As Vector3 = Points(Faces(i).Points(0).PointID)
            Dim p2 As Vector3 = Points(Faces(i).Points(1).PointID)
            Dim p3 As Vector3 = Points(Faces(i).Points(2).PointID)
            GL.Begin(PrimitiveType.Triangles)
            GL.TexCoord2(Faces(i).Points(0).TexCoordX, Faces(i).Points(0).TexCoordY) : GL.Vertex3(p1)
            GL.TexCoord2(Faces(i).Points(1).TexCoordX, Faces(i).Points(1).TexCoordY) : GL.Vertex3(p2)
            GL.TexCoord2(Faces(i).Points(2).TexCoordX, Faces(i).Points(2).TexCoordY) : GL.Vertex3(p3)
            GL.End()
        Next
    End Sub

    Private Sub InitNode()
        Node = New TreeNode("模型:")
        Node.Nodes.Add(New TreeNode("实体范围X: "))
        Node.Nodes.Add(New TreeNode("实体范围Y: "))
        Node.Nodes.Add(New TreeNode("实体范围Z: "))
        Node.Nodes.Add(New TreeNode("点数: "))
        Node.Nodes.Add(New TreeNode("面数: "))
    End Sub

    Function UpdateInfoNode() As TreeNode
        Node.Nodes(0).Text = "实体范围X: " & Box.XToString()
        Node.Nodes(1).Text = "实体范围Y: " & Box.YToString()
        Node.Nodes(2).Text = "实体范围Z: " & Box.ZToString()
        Node.Nodes(3).Text = "点数: " & Points.Count
        Node.Nodes(4).Text = "面数: " & Faces.Count
        Return Node
    End Function
End Class
