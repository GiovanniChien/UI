Imports System.Threading.Tasks

'监视多线程的计算过程，体会进程的并发（无顺序）
Public Class frmTest

    Delegate Sub DisplayItem(ByVal x As Integer)
    Dim subDisplay As DisplayItem

    Private Sub frmTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        subDisplay = New DisplayItem(AddressOf AddItem)
    End Sub
    Private Sub btnParallel_Click(sender As System.Object, e As System.EventArgs) Handles btnParallel.Click
        ListBox1.Items.Clear()
        ' 第三个参数是一个函数地址（该函数只有一个参数，无返回值）
        Parallel.For(0, 10, AddressOf Run)
    End Sub

    Private Sub Run(x As Integer)
        ' 计算工作(略)
        ' .....
        ' 在列表框中显示并行的线程的标记
        Invoke(subDisplay, {x})
    End Sub

    Private Sub AddItem(ByVal x As Integer)
        ListBox1.Items.Add(x)
    End Sub

End Class
