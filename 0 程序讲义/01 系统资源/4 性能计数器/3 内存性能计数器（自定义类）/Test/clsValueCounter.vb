Imports System.Windows.Forms.DataVisualization.Charting

Public Class clsValueCounter
    Inherits clsCounter

    Public Sub New(Counter As PerformanceCounter, ChtValue As Chart, lblValue As Label)
        MyBase.new(Counter, ChtValue, lblValue)
    End Sub

    Protected Overrides Function GetValue() As Long
        Return Counter.RawValue
    End Function

End Class
