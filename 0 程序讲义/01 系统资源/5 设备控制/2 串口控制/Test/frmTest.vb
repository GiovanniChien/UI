Imports System.IO.Ports

Public Class frmTest

    Dim WithEvents sp As SerialPort

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        sp = New SerialPort("COM1", 9600)
        sp.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If sp.IsOpen Then
            sp.WriteLine(txtCommand.Text)
        End If
    End Sub

    Private Sub sp_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles sp.DataReceived
        lstReceive.Items.Add(sp.ReadLine())
    End Sub
End Class


