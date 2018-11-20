Imports System.Management

Public Class frmTest
    Enum OpKind
        Creation
        Modification
        Deletion
    End Enum

    Public WithEvents CreationWatcher As ManagementEventWatcher      ' 用于观察进程新建的事件
    Public WithEvents ModificationWatcher As ManagementEventWatcher  ' 用于观察进程变化的事件
    Public WithEvents DeletionWatcher As ManagementEventWatcher      ' 用于观察进程退出的事件

    Delegate Sub deleAddOp(Process As ManagementBaseObject, kind As OpKind)
    Dim AddProcessOp As deleAddOp

    Private Sub frmTest_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        AddProcessOp = New deleAddOp(AddressOf AddOp)
        ' 建立WMI事件查询对象    WITHIN 1表示采集事件的事件间隔为1秒
        Dim qCreation As EventQuery = New EventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 1 WHERE TargetInstance isa ""Win32_Process""")
        Dim qModification As EventQuery = New EventQuery("SELECT * FROM __InstanceModificationEvent WITHIN 1 WHERE TargetInstance isa ""Win32_Process""")
        Dim qDeletion As EventQuery = New EventQuery("SELECT * FROM __InstanceDeletionEvent WITHIN 1 WHERE TargetInstance isa ""Win32_Process""")
        ' 建立观察对象
        CreationWatcher = New ManagementEventWatcher(qCreation)
        ModificationWatcher = New ManagementEventWatcher(qModification)
        DeletionWatcher = New ManagementEventWatcher(qDeletion)
    End Sub
    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        lstCreation.Items.Clear() : lstModification.Items.Clear() : lstDeletion.Items.Clear()
        ' 异步开始侦听
        CreationWatcher.Start() : ModificationWatcher.Start() : DeletionWatcher.Start()
    End Sub
    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        CreationWatcher.Stop() : ModificationWatcher.Stop() : DeletionWatcher.Stop()
    End Sub

    Private Sub CreationWatcher_EventArrived(sender As Object, e As System.Management.EventArrivedEventArgs) Handles CreationWatcher.EventArrived
        'e.NewEvent的所有成员：PreviousInstance  SECURITY_DESCRIPTOR  TargetInstance  TIME_CREATED
        Dim Process As ManagementBaseObject = e.NewEvent("TargetInstance")
        Me.Invoke(Me.AddProcessOp, Process, OpKind.Creation)
    End Sub
    Private Sub ModificationWatcher_EventArrived(sender As Object, e As System.Management.EventArrivedEventArgs) Handles ModificationWatcher.EventArrived
        Dim Process As ManagementBaseObject = e.NewEvent("TargetInstance")
        Me.Invoke(Me.AddProcessOp, Process, OpKind.Modification)
    End Sub
    Private Sub DeletionWatcher_EventArrived(sender As Object, e As System.Management.EventArrivedEventArgs) Handles DeletionWatcher.EventArrived
        Dim Process As ManagementBaseObject = e.NewEvent.Item("TargetInstance")
        Me.Invoke(Me.AddProcessOp, Process, OpKind.Deletion)
    End Sub

    Private Sub frmTest_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CreationWatcher.Stop() : ModificationWatcher.Stop() : DeletionWatcher.Stop()
    End Sub

    Sub AddOp(Process As ManagementBaseObject, kind As OpKind)
        If kind = OpKind.Creation Then
            lstCreation.Items.Add(Process.Item("Name"))
            lstCreation.SelectedIndex = lstCreation.Items.Count - 1
        End If
        If kind = OpKind.Modification Then
            lstModification.Items.Add(Process("Name"))
            lstModification.SelectedIndex = lstModification.Items.Count - 1
        End If
        If kind = OpKind.Deletion Then
            lstDeletion.Items.Add(Process.Item("Name"))
            lstDeletion.SelectedIndex = lstDeletion.Items.Count - 1
        End If
        '观察进程的所有属性名和值
        With lstProperty.Items
            .Clear()
            For Each p As PropertyData In Process.Properties
                .Add(p.Name & vbTab & p.Value)
            Next
        End With
    End Sub

End Class

