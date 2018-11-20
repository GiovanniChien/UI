Public Structure HCB
    Public hue As Single
    Public saturation As Single
    Public brightness As Single
End Structure
Public Structure CMY
    Public C As Single
    Public M As Single
    Public Y As Single
End Structure
Public Structure CMYK
    Public C As Single
    Public M As Single
    Public Y As Single
    Public K As Single
End Structure

Public Class clsBitmap
    Private Buff As Bitmap

    Public Sub New(fname As String)
        Me.Buff = New Bitmap(fname)
    End Sub
    Public Sub New(buff As Bitmap)
        Me.Buff = buff
    End Sub

    Function GetRGB(x As Integer, y As Integer) As Color
        Return Buff.GetPixel(x, y)
    End Function
    Function GetHCB(x As Integer, y As Integer) As HCB
        Dim pc As Color = GetRGB(x, y)
        Dim hcb As HCB
        hcb.hue = pc.GetHue()               ' 色调值，以度为单位[0,360]。
        hcb.saturation = pc.GetSaturation() ' 饱和度值[0,1]。
        hcb.brightness = pc.GetBrightness() ' 亮度值[0,1]。
        Return hcb
    End Function
    Function GetCMY(x As Integer, y As Integer) As CMY
        Dim pc As Color = GetRGB(x, y)
        Dim cmy As CMY
        cmy.C = 255 - pc.R
        cmy.M = 255 - pc.G
        cmy.Y = 255 - pc.B
        Return cmy
    End Function
    Function GetCMYK(x As Integer, y As Integer) As CMYK
        Dim cmy As CMY = GetCMY(x, y)
        Dim cmyk As CMYK
        cmyk.K = Math.Min(cmy.C, Math.Min(cmy.M, cmy.Y))
        cmyk.C = cmy.C - cmyk.K
        cmyk.M = cmy.M - cmyk.K
        cmyk.Y = cmy.Y - cmyk.K
        Return cmyk
    End Function

    Public Sub GetRGBs(Reds() As Integer, Greens() As Integer, Blues() As Integer)
        For i = 0 To 255
            Reds(i) = 0 : Greens(i) = 0 : Blues(i) = 0
        Next
        For i = 0 To Buff.Width - 1
            For j = 0 To Buff.Height - 1
                Dim c As Color = Buff.GetPixel(i, j)
                Reds(c.R) += 1 : Greens(c.G) += 1 : Blues(c.B) += 1
            Next
        Next
    End Sub

End Class
