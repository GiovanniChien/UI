Imports System.Security.Principal
Imports Microsoft.VisualBasic.Devices


Public Class frmTest

    Private Sub btnPorts_Click(sender As System.Object, e As System.EventArgs) Handles btnPorts.Click
        Dim ports As Ports = My.Computer.Ports
        For i = 0 To ports.SerialPortNames.Count - 1
            lstPorts.Items.Add(ports.SerialPortNames(i))
        Next
        ' ports.OpenSerialPort()
    End Sub

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAudio_Click(sender As System.Object, e As System.EventArgs) Handles btnAudio.Click
        Dim audio As Audio = My.Computer.Audio
        audio.PlaySystemSound(Media.SystemSounds.Exclamation)

    End Sub

    Private Sub btnDownload_Click(sender As System.Object, e As System.EventArgs) Handles btnDownload.Click
        Dim s As String = "ftp://f11.njnu.edu.cn/EDU/电子书/4693本亚马逊正版原版英文书/Booklist_12-26_XLS.xls" ' "ftp://f1.njnu.edu.cn/EDU/TOEFL/tflx.zip"
        Dim t As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        t = t & "\" & System.IO.Path.GetFileName(s)
        Try
            ' DownLoadFile 方法使用的 FTP 协议以纯文本方式发送信息（包括密码），因此不应用它传送敏感信息。
            My.Computer.Network.DownloadFile(s, t, "SPECiAL", "SPECiAL", True, 500, True)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("下载位置：" & t)
    End Sub

    Private Sub btnPing_Click(sender As System.Object, e As System.EventArgs) Handles btnPing.Click
        If My.Computer.Network.Ping("127.0.0.1") Then
            MsgBox("OK")
        End If
    End Sub
End Class

'Private Declare Function URLDownloadToFile Lib "urlmon" Alias "URLDownloadToFileA" (ByVal pCaller As Long, ByVal szURL As String, ByVal szFileName As String, ByVal dwReserved As Long, ByVal lpfnCB As Long) As Long
'Dim s As String = "http://www.3dxia.com/3dmoxing/download.php?auth=XW4IbwYlUGUBM11lDD1TY1wwBzMDaF0yByBRNwY%2FB2ZVZwp3CC5TZABmDDgAeAZxDSYBOQR4CnlUMVY5ACdRMl0kCDMGNlBzATNdYAwuUzNcaAdoA39dMgdiUXwGMgdlVXUKbAhxUzoAawxhAD4GKg1nATMEeApnVGRWeQB1UR5dPwglBhNQPgF%2FXUIMOFN1XEQHRwN1XUMHMlF0BhQHOFUxCkYIeVNLAG8MdQBNBjYNcwFHBGcKc1QWVhIAfVF5XUgIMAZ3UE4BbF0kDEJTYVwiB0cDFV0zBzZRYQZvBydVMQo1CGlTJgApDDEAfgYjDSUBdwQ2CiRUIVYiADlRMV1vCD0GY1A%2FAW5dMQw4U2ZcMwcwA2ZdNwcgUTgGJgc3VTAKMAhtUyYAaQxiADoGKw1iATcEeQpnVGNWZAB2UTFdYwhyBiBQZAEoXTw%3D"
'URLDownloadToFile()


