Imports System.Windows.Forms.DataVisualization.Charting

Public Class clsAccumulatedCounter
    Inherits clsCounter
    Private LastValue As Long

    Public Sub New(Counter As PerformanceCounter, ChtValue As Chart, lblValue As Label)
        MyBase.new(Counter, ChtValue, lblValue)
        LastValue = Counter.RawValue
    End Sub
    Protected Overrides Function GetValue() As Long
        Dim CurrentValue As Long = Counter.RawValue
        Dim Value As Long = CurrentValue - LastValue
        LastValue = CurrentValue
        Return Value
    End Function

End Class
