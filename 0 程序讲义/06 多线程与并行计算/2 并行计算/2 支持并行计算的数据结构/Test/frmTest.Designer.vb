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
        Me.txtTaskCount = New System.Windows.Forms.TextBox()
        Me.btnParallelList = New System.Windows.Forms.Button()
        Me.btnParallelArray = New System.Windows.Forms.Button()
        Me.btnSequenceList = New System.Windows.Forms.Button()
        Me.btnSquenceArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTaskCount
        '
        Me.txtTaskCount.Location = New System.Drawing.Point(187, 102)
        Me.txtTaskCount.Name = "txtTaskCount"
        Me.txtTaskCount.Size = New System.Drawing.Size(100, 21)
        Me.txtTaskCount.TabIndex = 6
        Me.txtTaskCount.Text = "4"
        '
        'btnParallelList
        '
        Me.btnParallelList.Location = New System.Drawing.Point(187, 176)
        Me.btnParallelList.Name = "btnParallelList"
        Me.btnParallelList.Size = New System.Drawing.Size(135, 45)
        Me.btnParallelList.TabIndex = 5
        Me.btnParallelList.Text = "btnParallelList"
        Me.btnParallelList.UseVisualStyleBackColor = True
        '
        'btnParallelArray
        '
        Me.btnParallelArray.Location = New System.Drawing.Point(187, 51)
        Me.btnParallelArray.Name = "btnParallelArray"
        Me.btnParallelArray.Size = New System.Drawing.Size(135, 45)
        Me.btnParallelArray.TabIndex = 4
        Me.btnParallelArray.Text = "btnParallelArray"
        Me.btnParallelArray.UseVisualStyleBackColor = True
        '
        'btnSequenceList
        '
        Me.btnSequenceList.Location = New System.Drawing.Point(36, 176)
        Me.btnSequenceList.Name = "btnSequenceList"
        Me.btnSequenceList.Size = New System.Drawing.Size(119, 45)
        Me.btnSequenceList.TabIndex = 3
        Me.btnSequenceList.Text = "btnSequenceList"
        Me.btnSequenceList.UseVisualStyleBackColor = True
        '
        'btnSquenceArray
        '
        Me.btnSquenceArray.Location = New System.Drawing.Point(36, 51)
        Me.btnSquenceArray.Name = "btnSquenceArray"
        Me.btnSquenceArray.Size = New System.Drawing.Size(119, 45)
        Me.btnSquenceArray.TabIndex = 2
        Me.btnSquenceArray.Text = "btnSquenceArray"
        Me.btnSquenceArray.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 273)
        Me.Controls.Add(Me.txtTaskCount)
        Me.Controls.Add(Me.btnParallelList)
        Me.Controls.Add(Me.btnParallelArray)
        Me.Controls.Add(Me.btnSequenceList)
        Me.Controls.Add(Me.btnSquenceArray)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTaskCount As System.Windows.Forms.TextBox
    Friend WithEvents btnParallelList As System.Windows.Forms.Button
    Friend WithEvents btnParallelArray As System.Windows.Forms.Button
    Friend WithEvents btnSequenceList As System.Windows.Forms.Button
    Friend WithEvents btnSquenceArray As System.Windows.Forms.Button

End Class
