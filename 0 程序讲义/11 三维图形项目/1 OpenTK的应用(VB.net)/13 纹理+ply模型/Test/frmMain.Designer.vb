<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.glCanvas = New OpenTK.GLControl()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.m_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_FileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_FileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_View = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ViewVertex = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ViewLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ViewFace = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ViewTexture = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvInfo = New System.Windows.Forms.TreeView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'glCanvas
        '
        Me.glCanvas.BackColor = System.Drawing.Color.Black
        Me.glCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.glCanvas.Location = New System.Drawing.Point(0, 0)
        Me.glCanvas.Name = "glCanvas"
        Me.glCanvas.Size = New System.Drawing.Size(579, 432)
        Me.glCanvas.TabIndex = 1
        Me.glCanvas.VSync = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_File, Me.m_View})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'm_File
        '
        Me.m_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_FileOpen, Me.m_FileExit})
        Me.m_File.Name = "m_File"
        Me.m_File.Size = New System.Drawing.Size(41, 20)
        Me.m_File.Text = "File"
        '
        'm_FileOpen
        '
        Me.m_FileOpen.Name = "m_FileOpen"
        Me.m_FileOpen.Size = New System.Drawing.Size(152, 22)
        Me.m_FileOpen.Text = "Open"
        '
        'm_FileExit
        '
        Me.m_FileExit.Name = "m_FileExit"
        Me.m_FileExit.Size = New System.Drawing.Size(152, 22)
        Me.m_FileExit.Text = "Exit"
        '
        'm_View
        '
        Me.m_View.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_ViewVertex, Me.m_ViewLine, Me.m_ViewFace, Me.m_ViewTexture})
        Me.m_View.Name = "m_View"
        Me.m_View.Size = New System.Drawing.Size(41, 20)
        Me.m_View.Text = "View"
        '
        'm_ViewVertex
        '
        Me.m_ViewVertex.Name = "m_ViewVertex"
        Me.m_ViewVertex.Size = New System.Drawing.Size(112, 22)
        Me.m_ViewVertex.Text = "Vertex"
        '
        'm_ViewLine
        '
        Me.m_ViewLine.Name = "m_ViewLine"
        Me.m_ViewLine.Size = New System.Drawing.Size(112, 22)
        Me.m_ViewLine.Text = "Line"
        '
        'm_ViewFace
        '
        Me.m_ViewFace.Name = "m_ViewFace"
        Me.m_ViewFace.Size = New System.Drawing.Size(112, 22)
        Me.m_ViewFace.Text = "Face"
        '
        'm_ViewTexture
        '
        Me.m_ViewTexture.Name = "m_ViewTexture"
        Me.m_ViewTexture.Size = New System.Drawing.Size(112, 22)
        Me.m_ViewTexture.Text = "Texture"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvInfo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.glCanvas)
        Me.SplitContainer1.Size = New System.Drawing.Size(754, 434)
        Me.SplitContainer1.SplitterDistance = 169
        Me.SplitContainer1.TabIndex = 3
        '
        'tvInfo
        '
        Me.tvInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvInfo.Location = New System.Drawing.Point(0, 0)
        Me.tvInfo.Name = "tvInfo"
        Me.tvInfo.Size = New System.Drawing.Size(167, 432)
        Me.tvInfo.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 458)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents glCanvas As OpenTK.GLControl
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents m_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_FileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_FileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_View As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ViewVertex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ViewLine As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ViewFace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ViewTexture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tvInfo As System.Windows.Forms.TreeView

End Class
