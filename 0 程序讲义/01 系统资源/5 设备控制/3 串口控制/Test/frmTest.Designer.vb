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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnSendT1 = New System.Windows.Forms.Button()
        Me.txtT1 = New System.Windows.Forms.TextBox()
        Me.lstReceive = New System.Windows.Forms.ListBox()
        Me.txtCom = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChartT1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartT2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartQ = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnSendT2 = New System.Windows.Forms.Button()
        Me.txtT2 = New System.Windows.Forms.TextBox()
        Me.btnSendQ = New System.Windows.Forms.Button()
        Me.txtQ = New System.Windows.Forms.TextBox()
        Me.txtBaud = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblState = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.gbT1 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.gbT2 = New System.Windows.Forms.GroupBox()
        Me.gbQ = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ChartT1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.gbT1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.gbT2.SuspendLayout()
        Me.gbQ.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(164, 3)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnSendT1
        '
        Me.btnSendT1.Location = New System.Drawing.Point(42, 40)
        Me.btnSendT1.Name = "btnSendT1"
        Me.btnSendT1.Size = New System.Drawing.Size(75, 23)
        Me.btnSendT1.TabIndex = 1
        Me.btnSendT1.Text = "SendT1"
        Me.btnSendT1.UseVisualStyleBackColor = True
        '
        'txtT1
        '
        Me.txtT1.Location = New System.Drawing.Point(123, 42)
        Me.txtT1.Name = "txtT1"
        Me.txtT1.Size = New System.Drawing.Size(55, 21)
        Me.txtT1.TabIndex = 3
        Me.txtT1.Text = "85"
        '
        'lstReceive
        '
        Me.lstReceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstReceive.FormattingEnabled = True
        Me.lstReceive.ItemHeight = 12
        Me.lstReceive.Location = New System.Drawing.Point(3, 17)
        Me.lstReceive.Name = "lstReceive"
        Me.lstReceive.Size = New System.Drawing.Size(318, 181)
        Me.lstReceive.TabIndex = 2
        '
        'txtCom
        '
        Me.txtCom.Location = New System.Drawing.Point(42, 3)
        Me.txtCom.Name = "txtCom"
        Me.txtCom.Size = New System.Drawing.Size(55, 21)
        Me.txtCom.TabIndex = 3
        Me.txtCom.Text = "COM4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstReceive)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 201)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receive"
        '
        'ChartT1
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartT1.ChartAreas.Add(ChartArea1)
        Me.ChartT1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.ChartT1.Legends.Add(Legend1)
        Me.ChartT1.Location = New System.Drawing.Point(3, 17)
        Me.ChartT1.Name = "ChartT1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartT1.Series.Add(Series1)
        Me.ChartT1.Size = New System.Drawing.Size(318, 135)
        Me.ChartT1.TabIndex = 5
        Me.ChartT1.Text = "Chart1"
        '
        'ChartT2
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartT2.ChartAreas.Add(ChartArea2)
        Me.ChartT2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.ChartT2.Legends.Add(Legend2)
        Me.ChartT2.Location = New System.Drawing.Point(3, 17)
        Me.ChartT2.Name = "ChartT2"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartT2.Series.Add(Series2)
        Me.ChartT2.Size = New System.Drawing.Size(333, 136)
        Me.ChartT2.TabIndex = 5
        Me.ChartT2.Text = "Chart1"
        '
        'ChartQ
        '
        ChartArea3.Name = "ChartArea1"
        Me.ChartQ.ChartAreas.Add(ChartArea3)
        Me.ChartQ.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.ChartQ.Legends.Add(Legend3)
        Me.ChartQ.Location = New System.Drawing.Point(3, 17)
        Me.ChartQ.Name = "ChartQ"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.ChartQ.Series.Add(Series3)
        Me.ChartQ.Size = New System.Drawing.Size(333, 180)
        Me.ChartQ.TabIndex = 5
        Me.ChartQ.Text = "Chart1"
        '
        'btnSendT2
        '
        Me.btnSendT2.Location = New System.Drawing.Point(208, 42)
        Me.btnSendT2.Name = "btnSendT2"
        Me.btnSendT2.Size = New System.Drawing.Size(75, 23)
        Me.btnSendT2.TabIndex = 1
        Me.btnSendT2.Text = "SendT2"
        Me.btnSendT2.UseVisualStyleBackColor = True
        '
        'txtT2
        '
        Me.txtT2.Location = New System.Drawing.Point(289, 44)
        Me.txtT2.Name = "txtT2"
        Me.txtT2.Size = New System.Drawing.Size(55, 21)
        Me.txtT2.TabIndex = 3
        Me.txtT2.Text = "100"
        '
        'btnSendQ
        '
        Me.btnSendQ.Location = New System.Drawing.Point(377, 44)
        Me.btnSendQ.Name = "btnSendQ"
        Me.btnSendQ.Size = New System.Drawing.Size(75, 23)
        Me.btnSendQ.TabIndex = 1
        Me.btnSendQ.Text = "SendQ"
        Me.btnSendQ.UseVisualStyleBackColor = True
        '
        'txtQ
        '
        Me.txtQ.Location = New System.Drawing.Point(458, 46)
        Me.txtQ.Name = "txtQ"
        Me.txtQ.Size = New System.Drawing.Size(55, 21)
        Me.txtQ.TabIndex = 3
        Me.txtQ.Text = "200"
        '
        'txtBaud
        '
        Me.txtBaud.Location = New System.Drawing.Point(103, 3)
        Me.txtBaud.Name = "txtBaud"
        Me.txtBaud.Size = New System.Drawing.Size(55, 21)
        Me.txtBaud.TabIndex = 3
        Me.txtBaud.Text = "9600"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblState)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClose)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpen)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSendT1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSendT2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSendQ)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtT1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtT2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtQ)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBaud)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(667, 440)
        Me.SplitContainer1.SplitterDistance = 76
        Me.SplitContainer1.TabIndex = 7
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(339, 9)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(41, 12)
        Me.lblState.TabIndex = 4
        Me.lblState.Text = "未连接"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(249, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(667, 360)
        Me.SplitContainer2.SplitterDistance = 324
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.gbT1)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer4.Size = New System.Drawing.Size(324, 360)
        Me.SplitContainer4.SplitterDistance = 155
        Me.SplitContainer4.TabIndex = 8
        '
        'gbT1
        '
        Me.gbT1.Controls.Add(Me.ChartT1)
        Me.gbT1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbT1.Location = New System.Drawing.Point(0, 0)
        Me.gbT1.Name = "gbT1"
        Me.gbT1.Size = New System.Drawing.Size(324, 155)
        Me.gbT1.TabIndex = 8
        Me.gbT1.TabStop = False
        Me.gbT1.Text = "GroupBox2"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.gbT2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.gbQ)
        Me.SplitContainer3.Size = New System.Drawing.Size(339, 360)
        Me.SplitContainer3.SplitterDistance = 156
        Me.SplitContainer3.TabIndex = 0
        '
        'gbT2
        '
        Me.gbT2.Controls.Add(Me.ChartT2)
        Me.gbT2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbT2.Location = New System.Drawing.Point(0, 0)
        Me.gbT2.Name = "gbT2"
        Me.gbT2.Size = New System.Drawing.Size(339, 156)
        Me.gbT2.TabIndex = 8
        Me.gbT2.TabStop = False
        Me.gbT2.Text = "GroupBox3"
        '
        'gbQ
        '
        Me.gbQ.Controls.Add(Me.ChartQ)
        Me.gbQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbQ.Location = New System.Drawing.Point(0, 0)
        Me.gbQ.Name = "gbQ"
        Me.gbQ.Size = New System.Drawing.Size(339, 200)
        Me.gbQ.TabIndex = 9
        Me.gbQ.TabStop = False
        Me.gbQ.Text = "GroupBox4"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 440)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ChartT1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartQ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.gbT1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.gbT2.ResumeLayout(False)
        Me.gbQ.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnSendT1 As System.Windows.Forms.Button
    Friend WithEvents txtT1 As System.Windows.Forms.TextBox
    Friend WithEvents lstReceive As System.Windows.Forms.ListBox
    Friend WithEvents txtCom As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChartT1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChartT2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChartQ As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnSendT2 As System.Windows.Forms.Button
    Friend WithEvents txtT2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSendQ As System.Windows.Forms.Button
    Friend WithEvents txtQ As System.Windows.Forms.TextBox
    Friend WithEvents txtBaud As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbT1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbT2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbQ As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblState As System.Windows.Forms.Label

End Class
