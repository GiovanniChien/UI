Imports System.Management

Public Class frmTest
    Enum OpKind
        Creation
        Modification
        Deletion
    End Enum

    Public WithEvents CreationWatcher As ManagementEventWatcher      ' 用于观察设备新建的事件
    Public WithEvents DeletetionWatcher As ManagementEventWatcher    ' 用于观察设备删除的事件
    Delegate Sub deleAddOp(Process As ManagementBaseObject, kind As OpKind)
    Dim AddProcessOp As deleAddOp

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        AddProcessOp = New deleAddOp(AddressOf AddOp)
        ' 建立WMI事件查询对象    WITHIN 1表示采集事件的事件间隔为1秒
        Dim qCreation As EventQuery = New EventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 1 WHERE Targetinstance isa ""Win32_LogicalDisk""")
        Dim qDeletion As EventQuery = New EventQuery("SELECT * FROM __InstanceDeletionEvent WITHIN 1 WHERE Targetinstance isa ""Win32_LogicalDisk""")
        ' 建立观察对象
        CreationWatcher = New ManagementEventWatcher(qCreation)
        DeletetionWatcher = New ManagementEventWatcher(qDeletion)
    End Sub
    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        lstCreation.Items.Clear() : lstDeletion.Items.Clear()
        ' 异步开始侦听
        CreationWatcher.Start()
        DeletetionWatcher.Start()
    End Sub
    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        CreationWatcher.Stop() : DeletetionWatcher.Stop()
    End Sub

    Private Sub CreationWatcher_EventArrived(sender As Object, e As System.Management.EventArrivedEventArgs) Handles CreationWatcher.EventArrived
        'e.NewEvent的所有成员：PreviousInstance  SECURITY_DESCRIPTOR  TargetInstance  TIME_CREATED
        Dim Instance As ManagementBaseObject = e.NewEvent("TargetInstance")
        Me.Invoke(Me.AddProcessOp, Instance, OpKind.Creation)
    End Sub
    Private Sub DeletetionWatcher_EventArrived(sender As Object, e As System.Management.EventArrivedEventArgs) Handles DeletetionWatcher.EventArrived
        Dim Instance As ManagementBaseObject = e.NewEvent("TargetInstance")
        Me.Invoke(Me.AddProcessOp, Instance, OpKind.Deletion)
    End Sub

    Private Sub frmTest_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CreationWatcher.Stop() : DeletetionWatcher.Stop()
    End Sub

    Sub AddOp(Instance As ManagementBaseObject, kind As OpKind)
        If kind = OpKind.Creation Then
            lstCreation.Items.Add(Instance.Item("Name"))
            lstCreation.SelectedIndex = lstCreation.Items.Count - 1
        End If
        If kind = OpKind.Modification Then
            lstModification.Items.Add(Instance("Name"))
            lstModification.SelectedIndex = lstModification.Items.Count - 1
        End If
        If kind = OpKind.Deletion Then
            lstDeletion.Items.Add(Instance.Item("Name"))
            lstDeletion.SelectedIndex = lstDeletion.Items.Count - 1
        End If
        With lstProperty.Items
            .Clear()
            For Each p As PropertyData In Instance.Properties
                .Add(p.Name & vbTab & p.Value)
            Next
        End With
    End Sub

End Class

