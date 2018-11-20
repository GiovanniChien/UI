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
        Me.m_Game = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Game_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_Game_Statistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Game_Option = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Game_Aspect = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_Game_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Help_View = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.m_Help_About = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCanvas.Location = New System.Drawing.Point(0, 24)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(763, 505)
        Me.picCanvas.TabIndex = 0
        Me.picCanvas.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Game, Me.m_Help})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(763, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'm_Game
        '
        Me.m_Game.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Game_New, Me.ToolStripSeparator2, Me.m_Game_Statistics, Me.m_Game_Option, Me.m_Game_Aspect, Me.ToolStripSeparator1, Me.m_Game_Exit})
        Me.m_Game.Name = "m_Game"
        Me.m_Game.Size = New System.Drawing.Size(59, 20)
        Me.m_Game.Text = "游戏(&G)"
        '
        'm_Game_New
        '
        Me.m_Game_New.Name = "m_Game_New"
        Me.m_Game_New.Size = New System.Drawing.Size(154, 22)
        Me.m_Game_New.Text = "新游戏(&N)   F2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(151, 6)
        '
        'm_Game_Statistics
        '
        Me.m_Game_Statistics.Name = "m_Game_Statistics"
        Me.m_Game_Statistics.Size = New System.Drawing.Size(154, 22)
        Me.m_Game_Statistics.Text = "统计信息(&S) F3"
        '
        'm_Game_Option
        '
        Me.m_Game_Option.Name = "m_Game_Option"
        Me.m_Game_Option.Size = New System.Drawing.Size(154, 22)
        Me.m_Game_Option.Text = "选项(&O)     F4"
        '
        'm_Game_Aspect
        '
        Me.m_Game_Aspect.Name = "m_Game_Aspect"
        Me.m_Game_Aspect.Size = New System.Drawing.Size(154, 22)
        Me.m_Game_Aspect.Text = "更改外观(&A) F7"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(151, 6)
        '
        'm_Game_Exit
        '
        Me.m_Game_Exit.Name = "m_Game_Exit"
        Me.m_Game_Exit.Size = New System.Drawing.Size(154, 22)
        Me.m_Game_Exit.Text = "退出(&X)"
        '
        'm_Help
        '
        Me.m_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_Help_View, Me.ToolStripSeparator3, Me.m_Help_About})
        Me.m_Help.Name = "m_Help"
        Me.m_Help.Size = New System.Drawing.Size(59, 20)
        Me.m_Help.Text = "帮助(&H)"
        '
        'm_Help_View
        '
        Me.m_Help_View.Name = "m_Help_View"
        Me.m_Help_View.Size = New System.Drawing.Size(160, 22)
        Me.m_Help_View.Text = "查看帮助(&V)  F1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(157, 6)
        '
        'm_Help_About
        '
        Me.m_Help_About.Name = "m_Help_About"
        Me.m_Help_About.Size = New System.Drawing.Size(160, 22)
        Me.m_Help_About.Text = "关于五子棋(&A)"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 529)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTest"
        Me.Text = "五子棋"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents m_Game As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Game_New As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Game_Statistics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Game_Option As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Game_Aspect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents m_Game_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Help_View As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents m_Help_About As System.Windows.Forms.ToolStripMenuItem

End Class
