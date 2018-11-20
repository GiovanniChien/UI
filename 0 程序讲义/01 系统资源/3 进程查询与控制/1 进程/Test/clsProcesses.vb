Public Class clsProcess
    Public Process As Process
    Public ProcessName As String
    Public FileName As String
    Public item As ListViewItem

    Public Sub New(proc As Process)
        Me.Process = proc
        ProcessName = proc.ProcessName
        Try
            FileName = proc.MainModule.FileName
        Catch ex As Exception
            FileName = ""           ' 为什么拒绝访问？
        End Try
        Me.item = New ListViewItem(ProcessName, 0)
        item.SubItems.Add(FileName)
    End Sub

    Public Function GetThread() As ProcessThreadCollection
        Return Process.Threads
    End Function
End Class

Public Class clsProcesses
    Private Processes As List(Of clsProcess)
    Public Items() As ListViewItem

    Public Sub New()
        Processes = New List(Of clsProcess)
        Dim Proces() As Process = Process.GetProcesses()
        For i = 0 To Proces.Count - 1
            Processes.Add(New clsProcess(Proces(i)))
        Next
        ReDim Items(Proces.Count - 1)
        For i = 0 To Proces.Count - 1
            Items(i) = Processes(i).item
        Next
    End Sub

    Public Sub ListView_Init(lv As ListView)
        Dim ColumnHeaders As ListView.ColumnHeaderCollection
        ColumnHeaders = New ListView.ColumnHeaderCollection(lv)
        ColumnHeaders.Add("进程名")
        ColumnHeaders.Add("程序名")
        With lv
            .View = View.Details
            .FullRowSelect = True
        End With
        lv.Columns(0).Width = 200
        lv.Columns(1).Width = 600
    End Sub
    Public Sub ListView_Display(lvItem As ListView)
        lvItem.Items.Clear()
        lvItem.Items.AddRange(Items)
    End Sub

    Public Sub Kill(FileName As String)
        Dim Proces() As Process = Process.GetProcesses()
        For i = 0 To Proces.Count - 1
            Try
                If Proces(i).MainModule.FileName = FileName Then
                    Proces(i).Kill()
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub
    Public Function GetFileName(index As Integer) As String
        Return Processes(index).FileName
    End Function
    Public Function GetProcessName(index As Integer) As String
        Return Processes(index).ProcessName
    End Function
    Public Function GetThread(index As Integer) As ProcessThreadCollection
        Return Processes(index).GetThread()
    End Function

End Class
