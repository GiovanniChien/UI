<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChild
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
        Me.components = New System.ComponentModel.Container()
        Me.m_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_FileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_FileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_FileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_FileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Tool = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ToolLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ToolRectangle = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ToolCircle = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ToolPolygon = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_ToolSelect = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Transform = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_TransformPan = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_TransformScale = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_TransformRotate = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_Property = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_PropertyColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_PropertyWidth = New System.Windows.Forms.ToolStripMenuItem()
        Me.m_PropertyStyle = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslblMnuPrompt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslblCap = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssprgWork = New System.Windows.Forms.ToolStripProgressBar()
        Me.sslblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnWork = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.sslblCapsLock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslblNumLock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.msMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'm_File
        '
        Me.m_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_FileNew, Me.m_FileOpen, Me.m_FileSave, Me.m_FileExit})
        Me.m_File.Name = "m_File"
        Me.m_File.Size = New System.Drawing.Size(41, 20)
        Me.m_File.Text = "File"
        '
        'm_FileNew
        '
        Me.m_FileNew.Name = "m_FileNew"
        Me.m_FileNew.Size = New System.Drawing.Size(94, 22)
        Me.m_FileNew.Text = "New"
        Me.m_FileNew.ToolTipText = "新建文件"
        '
        'm_FileOpen
        '
        Me.m_FileOpen.Name = "m_FileOpen"
        Me.m_FileOpen.Size = New System.Drawing.Size(94, 22)
        Me.m_FileOpen.Text = "Open"
        '
        'm_FileSave
        '
        Me.m_FileSave.Name = "m_FileSave"
        Me.m_FileSave.Size = New System.Drawing.Size(94, 22)
        Me.m_FileSave.Text = "Save"
        '
        'm_FileExit
        '
        Me.m_FileExit.Name = "m_FileExit"
        Me.m_FileExit.Size = New System.Drawing.Size(94, 22)
        Me.m_FileExit.Text = "Exit"
        '
        'm_Tool
        '
        Me.m_Tool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_ToolLine, Me.m_ToolRectangle, Me.m_ToolCircle, Me.m_ToolPolygon, Me.m_ToolSelect})
        Me.m_Tool.Name = "m_Tool"
        Me.m_Tool.Size = New System.Drawing.Size(41, 20)
        Me.m_Tool.Text = "Tool"
        '
        'm_ToolLine
        '
        Me.m_ToolLine.Name = "m_ToolLine"
        Me.m_ToolLine.Size = New System.Drawing.Size(124, 22)
        Me.m_ToolLine.Text = "Line"
        '
        'm_ToolRectangle
        '
        Me.m_ToolRectangle.Name = "m_ToolRectangle"
        Me.m_ToolRectangle.Size = New System.Drawing.Size(124, 22)
        Me.m_ToolRectangle.Text = "Rectangle"
        '
        'm_ToolCircle
        '
        Me.m_ToolCircle.Name = "m_ToolCircle"
        Me.m_ToolCircle.Size = New System.Drawing.Size(124, 22)
        Me.m_ToolCircle.Text = "Circle"
        '
        'm_ToolPolygon
        '
        Me.m_ToolPolygon.Name = "m_ToolPolygon"
        Me.m_ToolPolygon.Size = New System.Drawing.Size(124, 22)
        Me.m_ToolPolygon.Text = "Polygon"
        '
        'm_ToolSelect
        '
        Me.m_ToolSelect.Name = "m_ToolSelect"
        Me.m_ToolSelect.Size = New System.Drawing.Size(124, 22)
        Me.m_ToolSelect.Text = "Select"
        '
        'm_Transform
        '
        Me.m_Transform.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_TransformPan, Me.m_TransformScale, Me.m_TransformRotate})
        Me.m_Transform.Name = "m_Transform"
        Me.m_Transform.Size = New System.Drawing.Size(71, 20)
        Me.m_Transform.Text = "Transform"
        '
        'm_TransformPan
        '
        Me.m_TransformPan.Name = "m_TransformPan"
        Me.m_TransformPan.Size = New System.Drawing.Size(106, 22)
        Me.m_TransformPan.Text = "Pan"
        '
        'm_TransformScale
        '
        Me.m_TransformScale.Name = "m_TransformScale"
        Me.m_TransformScale.Size = New System.Drawing.Size(106, 22)
        Me.m_TransformScale.Text = "Scale"
        '
        'm_TransformRotate
        '
        Me.m_TransformRotate.Name = "m_TransformRotate"
        Me.m_TransformRotate.Size = New System.Drawing.Size(106, 22)
        Me.m_TransformRotate.Text = "Rotate"
        '
        'm_Property
        '
        Me.m_Property.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_PropertyColor, Me.m_PropertyWidth, Me.m_PropertyStyle})
        Me.m_Property.Name = "m_Property"
        Me.m_Property.Size = New System.Drawing.Size(65, 20)
        Me.m_Property.Text = "Property"
        '
        'm_PropertyColor
        '
        Me.m_PropertyColor.Name = "m_PropertyColor"
        Me.m_PropertyColor.Size = New System.Drawing.Size(100, 22)
        Me.m_PropertyColor.Text = "Color"
        '
        'm_PropertyWidth
        '
        Me.m_PropertyWidth.Name = "m_PropertyWidth"
        Me.m_PropertyWidth.Size = New System.Drawing.Size(100, 22)
        Me.m_PropertyWidth.Text = "Width"
        '
        'm_PropertyStyle
        '
        Me.m_PropertyStyle.Name = "m_PropertyStyle"
        Me.m_PropertyStyle.Size = New System.Drawing.Size(100, 22)
        Me.m_PropertyStyle.Text = "Style"
        '
        'msMain
        '
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m_File, Me.m_Tool, Me.m_Transform, Me.m_Property})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Size = New System.Drawing.Size(762, 24)
        Me.msMain.TabIndex = 1
        Me.msMain.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslblMnuPrompt, Me.sslblCap, Me.ssprgWork, Me.sslblTime, Me.sslblCapsLock, Me.sslblNumLock, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 300)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(762, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslblMnuPrompt
        '
        Me.sslblMnuPrompt.AutoSize = False
        Me.sslblMnuPrompt.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.sslblMnuPrompt.Name = "sslblMnuPrompt"
        Me.sslblMnuPrompt.Size = New System.Drawing.Size(135, 17)
        Me.sslblMnuPrompt.Text = "aaaaaaaaaaaaaaaa"
        Me.sslblMnuPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sslblCap
        '
        Me.sslblCap.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.sslblCap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sslblCap.Name = "sslblCap"
        Me.sslblCap.Size = New System.Drawing.Size(0, 17)
        Me.sslblCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ssprgWork
        '
        Me.ssprgWork.Name = "ssprgWork"
        Me.ssprgWork.Size = New System.Drawing.Size(200, 16)
        '
        'sslblTime
        '
        Me.sslblTime.AutoSize = False
        Me.sslblTime.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.sslblTime.Name = "sslblTime"
        Me.sslblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.sslblTime.Size = New System.Drawing.Size(135, 17)
        Me.sslblTime.Text = "0:0:0"
        Me.sslblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnWork
        '
        Me.btnWork.Location = New System.Drawing.Point(53, 49)
        Me.btnWork.Name = "btnWork"
        Me.btnWork.Size = New System.Drawing.Size(75, 23)
        Me.btnWork.TabIndex = 3
        Me.btnWork.Text = "btnWork"
        Me.btnWork.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'sslblCapsLock
        '
        Me.sslblCapsLock.Name = "sslblCapsLock"
        Me.sslblCapsLock.Size = New System.Drawing.Size(29, 17)
        Me.sslblCapsLock.Text = "大写"
        '
        'sslblNumLock
        '
        Me.sslblNumLock.Name = "sslblNumLock"
        Me.sslblNumLock.Size = New System.Drawing.Size(29, 17)
        Me.sslblNumLock.Text = "数字"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(131, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'frmChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 322)
        Me.Controls.Add(Me.btnWork)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.msMain)
        Me.Name = "frmChild"
        Me.Text = "frmChild"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents m_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_FileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_FileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_FileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_FileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Tool As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ToolLine As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ToolRectangle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ToolCircle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ToolPolygon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_ToolSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Transform As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_TransformPan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_TransformScale As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_TransformRotate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_Property As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_PropertyColor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_PropertyWidth As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m_PropertyStyle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents sslblMnuPrompt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssprgWork As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnWork As System.Windows.Forms.Button
    Friend WithEvents sslblCap As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents sslblCapsLock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslblNumLock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
