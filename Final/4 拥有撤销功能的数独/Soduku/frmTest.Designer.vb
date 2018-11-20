<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTest
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTest))
        Me.picLblMatrix = New System.Windows.Forms.PictureBox()
        Me.mns = New System.Windows.Forms.MenuStrip()
        Me.mns_Game = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mns_Game_NewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Mns_Game_Option = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mns_Game_Undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mns_Game_Redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Mns_Game_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PicTimer = New System.Windows.Forms.PictureBox()
        Me.Mns_Game_Restart = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picLblMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mns.SuspendLayout()
        CType(Me.PicTimer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLblMatrix
        '
        Me.picLblMatrix.Location = New System.Drawing.Point(48, 98)
        Me.picLblMatrix.Name = "picLblMatrix"
        Me.picLblMatrix.Size = New System.Drawing.Size(310, 310)
        Me.picLblMatrix.TabIndex = 3
        Me.picLblMatrix.TabStop = False
        '
        'mns
        '
        Me.mns.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mns.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mns_Game})
        Me.mns.Location = New System.Drawing.Point(0, 0)
        Me.mns.Name = "mns"
        Me.mns.Size = New System.Drawing.Size(404, 42)
        Me.mns.TabIndex = 4
        Me.mns.Text = "MenuStrip1"
        '
        'mns_Game
        '
        Me.mns_Game.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mns_Game_NewGame, Me.Mns_Game_Restart, Me.ToolStripSeparator1, Me.Mns_Game_Option, Me.Mns_Game_Undo, Me.Mns_Game_Redo, Me.ToolStripSeparator2, Me.Mns_Game_Exit})
        Me.mns_Game.Name = "mns_Game"
        Me.mns_Game.Size = New System.Drawing.Size(74, 38)
        Me.mns_Game.Text = "游戏"
        '
        'Mns_Game_NewGame
        '
        Me.Mns_Game_NewGame.Name = "Mns_Game_NewGame"
        Me.Mns_Game_NewGame.Size = New System.Drawing.Size(324, 38)
        Me.Mns_Game_NewGame.Text = "新游戏"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(321, 6)
        '
        'Mns_Game_Option
        '
        Me.Mns_Game_Option.Name = "Mns_Game_Option"
        Me.Mns_Game_Option.Size = New System.Drawing.Size(324, 38)
        Me.Mns_Game_Option.Text = "选项"
        '
        'Mns_Game_Undo
        '
        Me.Mns_Game_Undo.Name = "Mns_Game_Undo"
        Me.Mns_Game_Undo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.Mns_Game_Undo.Size = New System.Drawing.Size(324, 38)
        Me.Mns_Game_Undo.Text = "撤销"
        '
        'Mns_Game_Redo
        '
        Me.Mns_Game_Redo.Name = "Mns_Game_Redo"
        Me.Mns_Game_Redo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.Mns_Game_Redo.Size = New System.Drawing.Size(324, 38)
        Me.Mns_Game_Redo.Text = "重做"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(321, 6)
        '
        'Mns_Game_Exit
        '
        Me.Mns_Game_Exit.Name = "Mns_Game_Exit"
        Me.Mns_Game_Exit.Size = New System.Drawing.Size(324, 38)
        Me.Mns_Game_Exit.Text = "退出"
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(195, 57)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(41, 27)
        Me.lblTime.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PicTimer
        '
        Me.PicTimer.Image = CType(resources.GetObject("PicTimer.Image"), System.Drawing.Image)
        Me.PicTimer.Location = New System.Drawing.Point(159, 54)
        Me.PicTimer.Name = "PicTimer"
        Me.PicTimer.Size = New System.Drawing.Size(30, 30)
        Me.PicTimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicTimer.TabIndex = 6
        Me.PicTimer.TabStop = False
        '
        'Mns_Game_Restart
        '
        Me.Mns_Game_Restart.Name = "Mns_Game_Restart"
        Me.Mns_Game_Restart.Size = New System.Drawing.Size(324, 38)
        Me.Mns_Game_Restart.Text = "重新开始"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 429)
        Me.Controls.Add(Me.PicTimer)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.picLblMatrix)
        Me.Controls.Add(Me.mns)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.mns
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmTest"
        Me.Text = "Sudoku"
        CType(Me.picLblMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mns.ResumeLayout(False)
        Me.mns.PerformLayout()
        CType(Me.PicTimer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picLblMatrix As PictureBox
    Friend WithEvents mns As MenuStrip
    Friend WithEvents mns_Game As ToolStripMenuItem
    Friend WithEvents Mns_Game_NewGame As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Mns_Game_Option As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Mns_Game_Exit As ToolStripMenuItem
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PicTimer As PictureBox
    Friend WithEvents Mns_Game_Undo As ToolStripMenuItem
    Friend WithEvents Mns_Game_Redo As ToolStripMenuItem
    Friend WithEvents Mns_Game_Restart As ToolStripMenuItem
End Class
