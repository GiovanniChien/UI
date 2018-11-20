<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.myStatus = New System.Windows.Forms.StatusStrip()
        Me.myStatus_Point = New System.Windows.Forms.ToolStripStatusLabel()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.tabCommand = New System.Windows.Forms.TabControl()
        Me.tabFile = New System.Windows.Forms.TabPage()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.tabPolygon = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtScaleY = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OptRotateOrientX = New System.Windows.Forms.RadioButton()
        Me.OptRotateOrientY = New System.Windows.Forms.RadioButton()
        Me.btnExpand = New System.Windows.Forms.Button()
        Me.btnPolygonNew = New System.Windows.Forms.Button()
        Me.tabSetup = New System.Windows.Forms.TabPage()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtYmax = New System.Windows.Forms.TextBox()
        Me.txtXmax = New System.Windows.Forms.TextBox()
        Me.txtYmin = New System.Windows.Forms.TextBox()
        Me.txtXmin = New System.Windows.Forms.TextBox()
        Me.tabGFile = New System.Windows.Forms.TabPage()
        Me.tvPoints = New System.Windows.Forms.TreeView()
        Me.myStatus.SuspendLayout()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.tabCommand.SuspendLayout()
        Me.tabFile.SuspendLayout()
        Me.tabPolygon.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tabSetup.SuspendLayout()
        Me.SuspendLayout()
        '
        'myStatus
        '
        Me.myStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.myStatus_Point})
        Me.myStatus.Location = New System.Drawing.Point(0, 441)
        Me.myStatus.Name = "myStatus"
        Me.myStatus.Size = New System.Drawing.Size(777, 22)
        Me.myStatus.TabIndex = 3
        Me.myStatus.Text = "StatusStrip1"
        '
        'myStatus_Point
        '
        Me.myStatus_Point.Name = "myStatus_Point"
        Me.myStatus_Point.Size = New System.Drawing.Size(41, 17)
        Me.myStatus_Point.Text = "点坐标"
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCanvas.Location = New System.Drawing.Point(0, 0)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(514, 441)
        Me.picCanvas.TabIndex = 1
        Me.picCanvas.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.picCanvas)
        Me.SplitContainer1.Size = New System.Drawing.Size(777, 441)
        Me.SplitContainer1.SplitterDistance = 259
        Me.SplitContainer1.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.tabCommand)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.tvPoints)
        Me.SplitContainer2.Size = New System.Drawing.Size(259, 441)
        Me.SplitContainer2.SplitterDistance = 240
        Me.SplitContainer2.TabIndex = 0
        '
        'tabCommand
        '
        Me.tabCommand.Controls.Add(Me.tabFile)
        Me.tabCommand.Controls.Add(Me.tabPolygon)
        Me.tabCommand.Controls.Add(Me.tabSetup)
        Me.tabCommand.Controls.Add(Me.tabGFile)
        Me.tabCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabCommand.Location = New System.Drawing.Point(0, 0)
        Me.tabCommand.Name = "tabCommand"
        Me.tabCommand.SelectedIndex = 0
        Me.tabCommand.Size = New System.Drawing.Size(259, 240)
        Me.tabCommand.TabIndex = 0
        '
        'tabFile
        '
        Me.tabFile.Controls.Add(Me.btnExit)
        Me.tabFile.Controls.Add(Me.btnSave)
        Me.tabFile.Controls.Add(Me.btnOpen)
        Me.tabFile.Location = New System.Drawing.Point(4, 22)
        Me.tabFile.Name = "tabFile"
        Me.tabFile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFile.Size = New System.Drawing.Size(251, 214)
        Me.tabFile.TabIndex = 0
        Me.tabFile.Text = "文件"
        Me.tabFile.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(8, 86)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(61, 27)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "退出"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(8, 54)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(61, 27)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(8, 19)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(61, 27)
        Me.btnOpen.TabIndex = 6
        Me.btnOpen.Text = "打开"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'tabPolygon
        '
        Me.tabPolygon.Controls.Add(Me.Label5)
        Me.tabPolygon.Controls.Add(Me.txtScaleY)
        Me.tabPolygon.Controls.Add(Me.GroupBox4)
        Me.tabPolygon.Controls.Add(Me.btnExpand)
        Me.tabPolygon.Controls.Add(Me.btnPolygonNew)
        Me.tabPolygon.Location = New System.Drawing.Point(4, 22)
        Me.tabPolygon.Name = "tabPolygon"
        Me.tabPolygon.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPolygon.Size = New System.Drawing.Size(251, 214)
        Me.tabPolygon.TabIndex = 1
        Me.tabPolygon.Text = "多边形"
        Me.tabPolygon.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(104, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "层数"
        '
        'txtScaleY
        '
        Me.txtScaleY.Location = New System.Drawing.Point(139, 58)
        Me.txtScaleY.Name = "txtScaleY"
        Me.txtScaleY.Size = New System.Drawing.Size(39, 21)
        Me.txtScaleY.TabIndex = 38
        Me.txtScaleY.Text = "5"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OptRotateOrientX)
        Me.GroupBox4.Controls.Add(Me.OptRotateOrientY)
        Me.GroupBox4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 91)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(124, 45)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        '
        'OptRotateOrientX
        '
        Me.OptRotateOrientX.AutoSize = True
        Me.OptRotateOrientX.Location = New System.Drawing.Point(19, 20)
        Me.OptRotateOrientX.Name = "OptRotateOrientX"
        Me.OptRotateOrientX.Size = New System.Drawing.Size(47, 16)
        Me.OptRotateOrientX.TabIndex = 30
        Me.OptRotateOrientX.Text = "内侧"
        Me.OptRotateOrientX.UseVisualStyleBackColor = True
        '
        'OptRotateOrientY
        '
        Me.OptRotateOrientY.AutoSize = True
        Me.OptRotateOrientY.Location = New System.Drawing.Point(72, 20)
        Me.OptRotateOrientY.Name = "OptRotateOrientY"
        Me.OptRotateOrientY.Size = New System.Drawing.Size(47, 16)
        Me.OptRotateOrientY.TabIndex = 31
        Me.OptRotateOrientY.Text = "外侧"
        Me.OptRotateOrientY.UseVisualStyleBackColor = True
        '
        'btnExpand
        '
        Me.btnExpand.Location = New System.Drawing.Point(8, 58)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Size = New System.Drawing.Size(61, 27)
        Me.btnExpand.TabIndex = 9
        Me.btnExpand.Text = "扩展"
        Me.btnExpand.UseVisualStyleBackColor = True
        '
        'btnPolygonNew
        '
        Me.btnPolygonNew.Location = New System.Drawing.Point(8, 15)
        Me.btnPolygonNew.Name = "btnPolygonNew"
        Me.btnPolygonNew.Size = New System.Drawing.Size(61, 27)
        Me.btnPolygonNew.TabIndex = 7
        Me.btnPolygonNew.Text = "新建"
        Me.btnPolygonNew.UseVisualStyleBackColor = True
        '
        'tabSetup
        '
        Me.tabSetup.Controls.Add(Me.btnSetup)
        Me.tabSetup.Controls.Add(Me.Label1)
        Me.tabSetup.Controls.Add(Me.Label6)
        Me.tabSetup.Controls.Add(Me.txtYmax)
        Me.tabSetup.Controls.Add(Me.txtXmax)
        Me.tabSetup.Controls.Add(Me.txtYmin)
        Me.tabSetup.Controls.Add(Me.txtXmin)
        Me.tabSetup.Location = New System.Drawing.Point(4, 22)
        Me.tabSetup.Name = "tabSetup"
        Me.tabSetup.Size = New System.Drawing.Size(251, 214)
        Me.tabSetup.TabIndex = 2
        Me.tabSetup.Text = "设置"
        Me.tabSetup.UseVisualStyleBackColor = True
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(68, 76)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(61, 27)
        Me.btnSetup.TabIndex = 8
        Me.btnSetup.Text = "设定"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "X:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "X:"
        '
        'txtYmax
        '
        Me.txtYmax.Location = New System.Drawing.Point(104, 49)
        Me.txtYmax.Name = "txtYmax"
        Me.txtYmax.Size = New System.Drawing.Size(55, 21)
        Me.txtYmax.TabIndex = 2
        Me.txtYmax.Text = "100"
        '
        'txtXmax
        '
        Me.txtXmax.Location = New System.Drawing.Point(104, 22)
        Me.txtXmax.Name = "txtXmax"
        Me.txtXmax.Size = New System.Drawing.Size(55, 21)
        Me.txtXmax.TabIndex = 2
        Me.txtXmax.Text = "100"
        '
        'txtYmin
        '
        Me.txtYmin.Location = New System.Drawing.Point(41, 49)
        Me.txtYmin.Name = "txtYmin"
        Me.txtYmin.Size = New System.Drawing.Size(57, 21)
        Me.txtYmin.TabIndex = 2
        Me.txtYmin.Text = "-100"
        '
        'txtXmin
        '
        Me.txtXmin.Location = New System.Drawing.Point(41, 22)
        Me.txtXmin.Name = "txtXmin"
        Me.txtXmin.Size = New System.Drawing.Size(57, 21)
        Me.txtXmin.TabIndex = 2
        Me.txtXmin.Text = "-100"
        '
        'tabGFile
        '
        Me.tabGFile.Location = New System.Drawing.Point(4, 22)
        Me.tabGFile.Name = "tabGFile"
        Me.tabGFile.Size = New System.Drawing.Size(251, 214)
        Me.tabGFile.TabIndex = 3
        Me.tabGFile.Text = "G文件"
        Me.tabGFile.UseVisualStyleBackColor = True
        '
        'tvPoints
        '
        Me.tvPoints.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvPoints.Location = New System.Drawing.Point(0, 0)
        Me.tvPoints.Name = "tvPoints"
        Me.tvPoints.Size = New System.Drawing.Size(259, 197)
        Me.tvPoints.TabIndex = 0
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 463)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.myStatus)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.myStatus.ResumeLayout(False)
        Me.myStatus.PerformLayout()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.tabCommand.ResumeLayout(False)
        Me.tabFile.ResumeLayout(False)
        Me.tabPolygon.ResumeLayout(False)
        Me.tabPolygon.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tabSetup.ResumeLayout(False)
        Me.tabSetup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents myStatus_Point As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents tabCommand As System.Windows.Forms.TabControl
    Friend WithEvents tabFile As System.Windows.Forms.TabPage
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents tabPolygon As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtScaleY As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents OptRotateOrientX As System.Windows.Forms.RadioButton
    Friend WithEvents OptRotateOrientY As System.Windows.Forms.RadioButton
    Friend WithEvents btnExpand As System.Windows.Forms.Button
    Friend WithEvents btnPolygonNew As System.Windows.Forms.Button
    Friend WithEvents tabSetup As System.Windows.Forms.TabPage
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtYmax As System.Windows.Forms.TextBox
    Friend WithEvents txtXmax As System.Windows.Forms.TextBox
    Friend WithEvents txtYmin As System.Windows.Forms.TextBox
    Friend WithEvents txtXmin As System.Windows.Forms.TextBox
    Friend WithEvents tabGFile As System.Windows.Forms.TabPage
    Friend WithEvents tvPoints As System.Windows.Forms.TreeView

End Class
