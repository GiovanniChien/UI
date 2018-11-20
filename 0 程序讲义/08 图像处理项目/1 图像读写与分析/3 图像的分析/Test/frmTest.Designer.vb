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
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBlue = New System.Windows.Forms.TextBox()
        Me.btnChangeColor = New System.Windows.Forms.Button()
        Me.rdRed = New System.Windows.Forms.RadioButton()
        Me.rdGreen = New System.Windows.Forms.RadioButton()
        Me.rdBlue = New System.Windows.Forms.RadioButton()
        Me.rdGray = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHue = New System.Windows.Forms.TextBox()
        Me.txtSaturation = New System.Windows.Forms.TextBox()
        Me.txtBrightness = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtC1 = New System.Windows.Forms.TextBox()
        Me.txtM1 = New System.Windows.Forms.TextBox()
        Me.txtY1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtK = New System.Windows.Forms.TextBox()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.btnTJ = New System.Windows.Forms.Button()
        Me.ChartRGB = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ChartRGB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(32, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'picCanvas
        '
        Me.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCanvas.Location = New System.Drawing.Point(12, 41)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(602, 459)
        Me.picCanvas.TabIndex = 1
        Me.picCanvas.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Red"
        '
        'txtRed
        '
        Me.txtRed.Location = New System.Drawing.Point(88, 17)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(49, 21)
        Me.txtRed.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Green"
        '
        'txtGreen
        '
        Me.txtGreen.Location = New System.Drawing.Point(88, 46)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(49, 21)
        Me.txtGreen.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blue"
        '
        'txtBlue
        '
        Me.txtBlue.Location = New System.Drawing.Point(88, 71)
        Me.txtBlue.Name = "txtBlue"
        Me.txtBlue.Size = New System.Drawing.Size(49, 21)
        Me.txtBlue.TabIndex = 3
        '
        'btnChangeColor
        '
        Me.btnChangeColor.Location = New System.Drawing.Point(123, 12)
        Me.btnChangeColor.Name = "btnChangeColor"
        Me.btnChangeColor.Size = New System.Drawing.Size(84, 23)
        Me.btnChangeColor.TabIndex = 0
        Me.btnChangeColor.Text = "ChangeColor"
        Me.btnChangeColor.UseVisualStyleBackColor = True
        '
        'rdRed
        '
        Me.rdRed.AutoSize = True
        Me.rdRed.Checked = True
        Me.rdRed.Location = New System.Drawing.Point(271, 12)
        Me.rdRed.Name = "rdRed"
        Me.rdRed.Size = New System.Drawing.Size(41, 16)
        Me.rdRed.TabIndex = 4
        Me.rdRed.TabStop = True
        Me.rdRed.Text = "Red"
        Me.rdRed.UseVisualStyleBackColor = True
        '
        'rdGreen
        '
        Me.rdGreen.AutoSize = True
        Me.rdGreen.Location = New System.Drawing.Point(318, 12)
        Me.rdGreen.Name = "rdGreen"
        Me.rdGreen.Size = New System.Drawing.Size(53, 16)
        Me.rdGreen.TabIndex = 4
        Me.rdGreen.Text = "Green"
        Me.rdGreen.UseVisualStyleBackColor = True
        '
        'rdBlue
        '
        Me.rdBlue.AutoSize = True
        Me.rdBlue.Location = New System.Drawing.Point(365, 12)
        Me.rdBlue.Name = "rdBlue"
        Me.rdBlue.Size = New System.Drawing.Size(47, 16)
        Me.rdBlue.TabIndex = 4
        Me.rdBlue.Text = "Blue"
        Me.rdBlue.UseVisualStyleBackColor = True
        '
        'rdGray
        '
        Me.rdGray.AutoSize = True
        Me.rdGray.Location = New System.Drawing.Point(412, 12)
        Me.rdGray.Name = "rdGray"
        Me.rdGray.Size = New System.Drawing.Size(47, 16)
        Me.rdGray.TabIndex = 4
        Me.rdGray.Text = "Gray"
        Me.rdGray.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(522, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Hue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Saturation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Brightness"
        '
        'txtHue
        '
        Me.txtHue.Location = New System.Drawing.Point(88, 24)
        Me.txtHue.Name = "txtHue"
        Me.txtHue.Size = New System.Drawing.Size(49, 21)
        Me.txtHue.TabIndex = 3
        '
        'txtSaturation
        '
        Me.txtSaturation.Location = New System.Drawing.Point(88, 53)
        Me.txtSaturation.Name = "txtSaturation"
        Me.txtSaturation.Size = New System.Drawing.Size(49, 21)
        Me.txtSaturation.TabIndex = 3
        '
        'txtBrightness
        '
        Me.txtBrightness.Location = New System.Drawing.Point(88, 78)
        Me.txtBrightness.Name = "txtBrightness"
        Me.txtBrightness.Size = New System.Drawing.Size(49, 21)
        Me.txtBrightness.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtRed)
        Me.GroupBox1.Controls.Add(Me.txtGreen)
        Me.GroupBox1.Controls.Add(Me.txtBlue)
        Me.GroupBox1.Location = New System.Drawing.Point(620, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 109)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RGB"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtHue)
        Me.GroupBox2.Controls.Add(Me.txtSaturation)
        Me.GroupBox2.Controls.Add(Me.txtBrightness)
        Me.GroupBox2.Location = New System.Drawing.Point(620, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(152, 124)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "HSB"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtC1)
        Me.GroupBox3.Controls.Add(Me.txtM1)
        Me.GroupBox3.Controls.Add(Me.txtY1)
        Me.GroupBox3.Location = New System.Drawing.Point(620, 257)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(152, 124)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CMY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 12)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "M"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 12)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Y"
        '
        'txtC1
        '
        Me.txtC1.Location = New System.Drawing.Point(88, 24)
        Me.txtC1.Name = "txtC1"
        Me.txtC1.Size = New System.Drawing.Size(49, 21)
        Me.txtC1.TabIndex = 3
        '
        'txtM1
        '
        Me.txtM1.Location = New System.Drawing.Point(88, 53)
        Me.txtM1.Name = "txtM1"
        Me.txtM1.Size = New System.Drawing.Size(49, 21)
        Me.txtM1.TabIndex = 3
        '
        'txtY1
        '
        Me.txtY1.Location = New System.Drawing.Point(88, 78)
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(49, 21)
        Me.txtY1.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtC)
        Me.GroupBox4.Controls.Add(Me.txtK)
        Me.GroupBox4.Controls.Add(Me.txtM)
        Me.GroupBox4.Controls.Add(Me.txtY)
        Me.GroupBox4.Location = New System.Drawing.Point(620, 387)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(152, 136)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CMYK"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 12)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "C"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 12)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "M"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 12)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "K"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 12)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Y"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(88, 24)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(49, 21)
        Me.txtC.TabIndex = 3
        '
        'txtK
        '
        Me.txtK.Location = New System.Drawing.Point(87, 106)
        Me.txtK.Name = "txtK"
        Me.txtK.Size = New System.Drawing.Size(49, 21)
        Me.txtK.TabIndex = 3
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(88, 53)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(49, 21)
        Me.txtM.TabIndex = 3
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(88, 78)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(49, 21)
        Me.txtY.TabIndex = 3
        '
        'btnTJ
        '
        Me.btnTJ.Location = New System.Drawing.Point(797, 9)
        Me.btnTJ.Name = "btnTJ"
        Me.btnTJ.Size = New System.Drawing.Size(75, 23)
        Me.btnTJ.TabIndex = 0
        Me.btnTJ.Text = "统计"
        Me.btnTJ.UseVisualStyleBackColor = True
        '
        'ChartRGB
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartRGB.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartRGB.Legends.Add(Legend1)
        Me.ChartRGB.Location = New System.Drawing.Point(795, 49)
        Me.ChartRGB.Name = "ChartRGB"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartRGB.Series.Add(Series1)
        Me.ChartRGB.Size = New System.Drawing.Size(292, 474)
        Me.ChartRGB.TabIndex = 7
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 566)
        Me.Controls.Add(Me.ChartRGB)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rdGray)
        Me.Controls.Add(Me.rdBlue)
        Me.Controls.Add(Me.rdGreen)
        Me.Controls.Add(Me.rdRed)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.btnChangeColor)
        Me.Controls.Add(Me.btnTJ)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Name = "frmTest"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ChartRGB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBlue As System.Windows.Forms.TextBox
    Friend WithEvents btnChangeColor As System.Windows.Forms.Button
    Friend WithEvents rdRed As System.Windows.Forms.RadioButton
    Friend WithEvents rdGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rdBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rdGray As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHue As System.Windows.Forms.TextBox
    Friend WithEvents txtSaturation As System.Windows.Forms.TextBox
    Friend WithEvents txtBrightness As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtC1 As System.Windows.Forms.TextBox
    Friend WithEvents txtM1 As System.Windows.Forms.TextBox
    Friend WithEvents txtY1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtK As System.Windows.Forms.TextBox
    Friend WithEvents txtM As System.Windows.Forms.TextBox
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents btnTJ As System.Windows.Forms.Button
    Friend WithEvents ChartRGB As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
