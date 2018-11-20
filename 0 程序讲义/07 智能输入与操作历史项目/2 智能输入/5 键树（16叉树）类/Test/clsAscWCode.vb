Public Class clsAscWCode
    Private Shared K0 As UInt16 = 61440  '15 * 16 * 16 * 16
    Private Shared K1 As UInt16 = 3840   '15 * 16 * 16 
    Private Shared K2 As UInt16 = 240    '15 * 16 
    Private Shared K3 As UInt16 = 15

    Public Shared Function Deform(x As UInt16) As UInt16()
        Dim digits(3) As UInt16
        digits(0) = (x And K0) >> 12
        digits(1) = (x And K1) >> 8
        digits(2) = (x And K2) >> 4
        digits(3) = x And K3
        Return digits
    End Function

    Public Shared Function Compose(digits() As UInt16) As UInt16
        Return (digits(0) << 12) + (digits(1) << 8) + (digits(2) << 4) + digits(3)
    End Function

End Class
