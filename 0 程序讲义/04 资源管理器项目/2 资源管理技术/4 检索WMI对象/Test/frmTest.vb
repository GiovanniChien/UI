Imports System.Management

Public Class frmTest

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstWMIPath.Items.Add("\\.\root\cimv2:Win32_Product")
        lstWMIPath.Items.Add("\\.\root\cimv2:Win32_Process")
        lstWMIPath.Items.Add("\\.\root\cimv2:Win32_NetworkAdapterConfiguration")
        lstWMIPath.Items.Add("\\.\root\cimv2:Win32_Service")
        lstWMIPath.SelectedIndex = 0
    End Sub
    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click
        If lstWMIPath.SelectedIndex = -1 Then Exit Sub
        Dim path As String = lstWMIPath.Text
        Dim mc As ManagementClass = New ManagementClass(path)
        Dim objects As ManagementObjectCollection = mc.GetInstances() '返回该类的所有实例的集合。
        lstWMI.Items.Clear()
        For Each obj As ManagementObject In objects
            Try
                lstWMI.Items.Add(obj("Name"))
            Catch ex As Exception
                lstWMI.Items.Add(obj("Caption"))  '某些对象无Name
            End Try

            For Each p As PropertyData In obj.Properties
                Try
                    lstWMI.Items.Add(vbTab & p.Name & vbTab & p.Value)
                Catch ex As Exception
                    lstWMI.Items.Add(vbTab & p.Name & vbTab & "???") '某些值无法转换为字符串
                End Try
            Next
        Next
    End Sub

End Class

