Imports System.Globalization

' Environment: 有关当前环境和平台的信息
Public Class frmTest
    Private Sub btnOS_Click(sender As System.Object, e As System.EventArgs) Handles btnOS.Click
        With lstOS.Items
            .Clear()
            .Add(Environment.MachineName)      '本地计算机的 NetBIOS 名称
            .Add(Environment.ProcessorCount)   '当前计算机上的处理器数
            .Add(Environment.OSVersion)
            .Add(Environment.Version)          '公共语言运行时库的版本
            .Add(Environment.UserName)
            .Add(Environment.WorkingSet / 1024)   '映射到进程上下文的物理内存量。对应任务管理器中的“内存-工作集”列
            .Add(Environment.TickCount)           '系统启动后经过的毫秒数
            .Add(Environment.CurrentDirectory)    '当前工作目录的绝对路径
            ' 由指定枚举标识的系统特殊文件夹的路径。
            ' 枚举类型SpecialFolder的取值，值得一看
            .Add(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)) '应用程序间共享的组件的目录。
            .Add(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))        '用户的配置文件文件夹
        End With
    End Sub
    Private Sub btnCommandLine_Click(sender As System.Object, e As System.EventArgs) Handles btnCommandLine.Click
        ' 返回包含当前进程的命令行参数的字符串数组。
        Dim Args() As String = Environment.GetCommandLineArgs()
        For i = 0 To Args.Count - 1
            lstArgs.Items.Add(Args(i))
        Next
    End Sub
    Private Sub btnEnvironmentVariables_Click(sender As System.Object, e As System.EventArgs) Handles btnEnvironmentVariables.Click
        Dim Variables As IDictionary = Environment.GetEnvironmentVariables()
        For Each Variable As DictionaryEntry In Variables
            lstEnvironmentVariables.Items.Add(Variable.Key & ": " & vbTab & Variable.Value)
        Next
    End Sub

End Class
