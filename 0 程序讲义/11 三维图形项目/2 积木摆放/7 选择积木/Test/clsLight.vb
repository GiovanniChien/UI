Imports OpenTK
Imports OpenTK.Graphics.OpenGL

Public Class clsLight
    Private position(3) As Single '位置(x,y,z,1)
    Private ambient(3) As Single     '环境光
    Private diffuse(3) As Single   '散射光
    Private specular(3) As Single   '高亮光

    Public Sub New(node As System.Xml.XmlElement)
        Dim v() As String
        v = getArray(node.GetElementsByTagName("position")(0).InnerXml)
        For i = 0 To 3
            position(i) = v(i)
        Next
        v = getArray(node.GetElementsByTagName("ambient")(0).InnerXml)
        For i = 0 To 3
            ambient(i) = v(i) / 255.0
        Next
        v = getArray(node.GetElementsByTagName("diffuse")(0).InnerXml)
        For i = 0 To 3
            diffuse(i) = v(i) / 255.0
        Next
        v = getArray(node.GetElementsByTagName("specular")(0).InnerXml)
        For i = 0 To 3
            specular(i) = v(i) / 255.0
        Next
    End Sub

    Private Function getArray(s As String) As String()
        Return s.Split(",")
    End Function

    Public Sub SetLight(Ln As EnableCap, open As Boolean)
        If open = True Then
            GL.Enable(Ln)
            GL.Light(Ln, LightParameter.Position, position)
            GL.Light(Ln, LightParameter.Ambient, ambient)
            GL.Light(Ln, LightParameter.Diffuse, diffuse)
            GL.Light(Ln, LightParameter.Specular, specular)
        Else
            GL.Disable(Ln)
        End If
    End Sub

End Class
