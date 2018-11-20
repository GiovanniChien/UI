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
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.m_Tool = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_Line = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_Rectangle = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_Polygon = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool_PointSelect = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform_Pan = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform_Rotate = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform_Scale = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform_RotatePoint = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tranform_SymLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstElem = New System.Windows.Forms.ListBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BackColor = System.Drawing.Color.White
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCanvas.Location = New System.Drawing.Point(0, 0)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(213, 249)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tool, Me.m_Tranform})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(639, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'm_Tool
        '
        Me.m_Tool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tool_Line, Me.m_Tool_Rectangle, Me.m_Tool_Polygon, Me.m_Tool_PointSelect})
        Me.m_Tool.Name = "m_Tool"
        Me.m_Tool.Size = New System.Drawing.Size(41, 20)
        Me.m_Tool.Text = "工具"
        '
        'm_Tool_Line
        '
        Me.m_Tool_Line.Name = "m_Tool_Line"
        Me.m_Tool_Line.Size = New System.Drawing.Size(106, 22)
        Me.m_Tool_Line.Text = "线段"
        '
        'm_Tool_Rectangle
        '
        Me.m_Tool_Rectangle.Name = "m_Tool_Rectangle"
        Me.m_Tool_Rectangle.Size = New System.Drawing.Size(106, 22)
        Me.m_Tool_Rectangle.Text = "矩形"
        '
        'm_Tool_Polygon
        '
        Me.m_Tool_Polygon.Name = "m_Tool_Polygon"
        Me.m_Tool_Polygon.Size = New System.Drawing.Size(106, 22)
        Me.m_Tool_Polygon.Text = "多边形"
        '
        'm_Tool_PointSelect
        '
        Me.m_Tool_PointSelect.Name = "m_Tool_PointSelect"
        Me.m_Tool_PointSelect.Size = New System.Drawing.Size(106, 22)
        Me.m_Tool_PointSelect.Text = "选择"
        '
        'm_Tranform
        '
        Me.m_Tranform.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Tranform_Pan, Me.m_Tranform_Rotate, Me.m_Tranform_Scale, Me.m_Tranform_RotatePoint, Me.m_Tranform_SymLine})
        Me.m_Tranform.Name = "m_Tranform"
        Me.m_Tranform.Size = New System.Drawing.Size(41, 20)
        Me.m_Tranform.Text = "变换"
        '
        'm_Tranform_Pan
        '
        Me.m_Tranform_Pan.Name = "m_Tranform_Pan"
        Me.m_Tranform_Pan.Size = New System.Drawing.Size(118, 22)
        Me.m_Tranform_Pan.Text = "平移"
        '
        'm_Tranform_Rotate
        '
        Me.m_Tranform_Rotate.Name = "m_Tranform_Rotate"
        Me.m_Tranform_Rotate.Size = New System.Drawing.Size(118, 22)
        Me.m_Tranform_Rotate.Text = "旋转"
        '
        'm_Tranform_Scale
        '
        Me.m_Tranform_Scale.Name = "m_Tranform_Scale"
        Me.m_Tranform_Scale.Size = New System.Drawing.Size(118, 22)
        Me.m_Tranform_Scale.Text = "缩放"
        '
        'm_Tranform_RotatePoint
        '
        Me.m_Tranform_RotatePoint.Name = "m_Tranform_RotatePoint"
        Me.m_Tranform_RotatePoint.Size = New System.Drawing.Size(118, 22)
        Me.m_Tranform_RotatePoint.Text = "绕点旋转"
        '
        'm_Tranform_SymLine
        '
        Me.m_Tranform_SymLine.Name = "m_Tranform_SymLine"
        Me.m_Tranform_SymLine.Size = New System.Drawing.Size(118, 22)
        Me.m_Tranform_SymLine.Text = "直线对称"
        '
        'lstElem
        '
        Me.lstElem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstElem.FormattingEnabled = True
        Me.lstElem.ItemHeight = 12
        Me.lstElem.Location = New System.Drawing.Point(0, 0)
        Me.lstElem.Name = "lstElem"
        Me.lstElem.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstElem.Size = New System.Drawing.Size(422, 249)
        Me.lstElem.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.picCanvas)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lstElem)
        Me.SplitContainer1.Size = New System.Drawing.Size(639, 249)
        Me.SplitContainer1.SplitterDistance = 213
        Me.SplitContainer1.TabIndex = 5
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 273)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents m_Tool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_Line As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_Rectangle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstElem As System.Windows.Forms.ListBox
    Friend WithEvents m_Tool_Polygon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool_PointSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform_Pan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform_Rotate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform_Scale As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform_RotatePoint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tranform_SymLine As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

End Class
