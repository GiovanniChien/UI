Public Class frmChild
    ' 提供了访问键盘当前状态（例如，当前按下了什么键）的属性，并提供了向活动窗口发送键击的方法。
    Dim Keyboard As Devices.Keyboard

    Private Sub frmChild_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Keyboard = New Devices.Keyboard
    End Sub

    Private Sub m_FileNew_Click(sender As System.Object, e As System.EventArgs) Handles m_FileNew.Click, m_FileOpen.Click, m_FileSave.Click, m_FileExit.Click
        If sender Is m_FileNew Then FileNew()
        If sender Is m_FileOpen Then FileOpen()
        If sender Is m_FileSave Then FileSave()
        If sender Is m_FileExit Then FileExit()
    End Sub
    Private Sub FileNew()
        MsgBox("FileNew")
    End Sub
    Private Sub FileOpen()
        MsgBox("FileOpen")
    End Sub
    Private Sub FileSave()
        MsgBox("FileSave")
    End Sub
    Private Sub FileExit()
        Me.Close()
    End Sub

    Private Sub m_ToolLine_Click(sender As System.Object, e As System.EventArgs) Handles m_ToolLine.Click, m_ToolRectangle.Click, m_ToolCircle.Click, m_ToolPolygon.Click, m_ToolSelect.Click
        If sender Is m_ToolLine Then ToolLine()
        If sender Is m_ToolRectangle Then ToolRectangle()
        If sender Is m_ToolCircle Then ToolCircle()
        If sender Is m_ToolPolygon Then ToolPolygon()
        If sender Is m_ToolSelect Then Toolselect()
    End Sub
    Private Sub ToolLine()
        MsgBox("ToolLine")
    End Sub
    Private Sub ToolRectangle()
        MsgBox("ToolRectangle")
    End Sub
    Private Sub ToolCircle()
        MsgBox("ToolCircle")
    End Sub
    Private Sub ToolPolygon()
        MsgBox("ToolPolygon")
    End Sub
    Private Sub ToolSelect()
        MsgBox("ToolSelect")
    End Sub

    Private Sub m_TransformPan_Click(sender As System.Object, e As System.EventArgs) Handles m_TransformPan.Click, m_TransformScale.Click, m_TransformRotate.Click
        If sender Is m_TransformPan Then TransformPan()
        If sender Is m_TransformScale Then TransformScale()
        If sender Is m_TransformRotate Then TransformRotate()
    End Sub
    Private Sub TransformPan()
        MsgBox("TransformPan")
    End Sub
    Private Sub TransformScale()
        MsgBox("TransformScale")
    End Sub
    Private Sub TransformRotate()
        MsgBox("TransformRotate")
    End Sub

    Private Sub m_PropertyColor_Click(sender As System.Object, e As System.EventArgs) Handles m_PropertyColor.Click, m_PropertyWidth.Click, m_PropertyStyle.Click
        If sender Is m_PropertyColor Then PropertyColor()
        If sender Is m_PropertyWidth Then PropertyWidth()
        If sender Is m_PropertyStyle Then PropertyStyle()
    End Sub
    Private Sub PropertyColor()
        MsgBox("PropertyColor")
    End Sub
    Private Sub PropertyWidth()
        MsgBox("PropertyWidth")
    End Sub
    Private Sub PropertyStyle()
        MsgBox("PropertyStyle")
    End Sub

    ' 使用状态栏中的标签控件
    Private Sub m_FileNew_MouseEnter(sender As System.Object, e As System.EventArgs) Handles m_FileNew.MouseEnter
        sslblMnuPrompt.Text = "新建文件"
    End Sub
    Private Sub m_FileNew_MouseLeave(sender As System.Object, e As System.EventArgs) Handles m_FileNew.MouseLeave
        sslblMnuPrompt.Text = ""
    End Sub

    ' 使用状态栏中的进度条
    Private Sub btnWork_Click(sender As System.Object, e As System.EventArgs) Handles btnWork.Click
        ssprgWork.Minimum = 0
        ssprgWork.Maximum = 100
        DoWork()
    End Sub
    Private Sub DoWork()
        For i = ssprgWork.Minimum To ssprgWork.Maximum
            System.Threading.Thread.Sleep(10)
            ssprgWork.Value = i
        Next
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        sslblTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
        If Keyboard.CapsLock = True Then
            sslblCapsLock.Text = "大写"
        Else
            sslblCapsLock.Text = "小写"
        End If
        If Keyboard.NumLock = True Then
            sslblNumLock.Text = "数字"
        Else
            sslblNumLock.Text = "非数字"
        End If
    End Sub
End Class