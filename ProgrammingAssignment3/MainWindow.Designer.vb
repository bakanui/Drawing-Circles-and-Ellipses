<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EllipseButton = New System.Windows.Forms.Button()
        Me.b_box = New System.Windows.Forms.TextBox()
        Me.a_box = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xc_Box = New System.Windows.Forms.TextBox()
        Me.yc_Box = New System.Windows.Forms.TextBox()
        Me.r_Box = New System.Windows.Forms.TextBox()
        Me.CircleButton = New System.Windows.Forms.Button()
        Me.clearCanvas_button = New System.Windows.Forms.Button()
        Me.CrclIndx = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TBRed = New System.Windows.Forms.TrackBar()
        Me.TBGreen = New System.Windows.Forms.TrackBar()
        Me.TBBlue = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.REDCLR = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GREENCLR = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.BLUECLR = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TMRGen = New System.Windows.Forms.Timer(Me.components)
        Me.PrvwBtn = New System.Windows.Forms.Button()
        Me.EllsIndx = New System.Windows.Forms.Button()
        Me.DotCheck = New System.Windows.Forms.CheckBox()
        Me.Coordinate = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TBRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(525, 459)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.EllipseButton)
        Me.GroupBox1.Controls.Add(Me.b_box)
        Me.GroupBox1.Controls.Add(Me.a_box)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.xc_Box)
        Me.GroupBox1.Controls.Add(Me.yc_Box)
        Me.GroupBox1.Controls.Add(Me.r_Box)
        Me.GroupBox1.Controls.Add(Me.CircleButton)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 470)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(525, 133)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Circle and Ellipse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Center Points"
        '
        'EllipseButton
        '
        Me.EllipseButton.Location = New System.Drawing.Point(415, 88)
        Me.EllipseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EllipseButton.Name = "EllipseButton"
        Me.EllipseButton.Size = New System.Drawing.Size(100, 35)
        Me.EllipseButton.TabIndex = 7
        Me.EllipseButton.Text = "Ellipse"
        Me.EllipseButton.UseVisualStyleBackColor = True
        '
        'b_box
        '
        Me.b_box.Location = New System.Drawing.Point(346, 101)
        Me.b_box.Margin = New System.Windows.Forms.Padding(4)
        Me.b_box.Name = "b_box"
        Me.b_box.Size = New System.Drawing.Size(51, 22)
        Me.b_box.TabIndex = 6
        '
        'a_box
        '
        Me.a_box.Location = New System.Drawing.Point(263, 102)
        Me.a_box.Margin = New System.Windows.Forms.Padding(4)
        Me.a_box.Name = "a_box"
        Me.a_box.Size = New System.Drawing.Size(51, 22)
        Me.a_box.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "b"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Radius"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "y"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "x"
        '
        'xc_Box
        '
        Me.xc_Box.Location = New System.Drawing.Point(33, 89)
        Me.xc_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.xc_Box.Name = "xc_Box"
        Me.xc_Box.Size = New System.Drawing.Size(51, 22)
        Me.xc_Box.TabIndex = 1
        '
        'yc_Box
        '
        Me.yc_Box.Location = New System.Drawing.Point(131, 87)
        Me.yc_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.yc_Box.Name = "yc_Box"
        Me.yc_Box.Size = New System.Drawing.Size(51, 22)
        Me.yc_Box.TabIndex = 2
        '
        'r_Box
        '
        Me.r_Box.Location = New System.Drawing.Point(263, 35)
        Me.r_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.r_Box.Name = "r_Box"
        Me.r_Box.Size = New System.Drawing.Size(132, 22)
        Me.r_Box.TabIndex = 3
        '
        'CircleButton
        '
        Me.CircleButton.Location = New System.Drawing.Point(415, 23)
        Me.CircleButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(100, 34)
        Me.CircleButton.TabIndex = 4
        Me.CircleButton.Text = "Circle"
        Me.CircleButton.UseVisualStyleBackColor = True
        '
        'clearCanvas_button
        '
        Me.clearCanvas_button.Location = New System.Drawing.Point(536, 431)
        Me.clearCanvas_button.Margin = New System.Windows.Forms.Padding(4)
        Me.clearCanvas_button.Name = "clearCanvas_button"
        Me.clearCanvas_button.Size = New System.Drawing.Size(104, 28)
        Me.clearCanvas_button.TabIndex = 0
        Me.clearCanvas_button.Text = "Clear Canvas"
        Me.clearCanvas_button.UseVisualStyleBackColor = True
        '
        'CrclIndx
        '
        Me.CrclIndx.Location = New System.Drawing.Point(551, 345)
        Me.CrclIndx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CrclIndx.Name = "CrclIndx"
        Me.CrclIndx.Size = New System.Drawing.Size(75, 23)
        Me.CrclIndx.TabIndex = 2
        Me.CrclIndx.Text = "DelCir"
        Me.CrclIndx.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(536, 248)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(107, 84)
        Me.ListBox1.TabIndex = 3
        '
        'TBRed
        '
        Me.TBRed.BackColor = System.Drawing.Color.Red
        Me.TBRed.Location = New System.Drawing.Point(597, 3)
        Me.TBRed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBRed.Maximum = 255
        Me.TBRed.Name = "TBRed"
        Me.TBRed.Size = New System.Drawing.Size(198, 56)
        Me.TBRed.TabIndex = 4
        Me.TBRed.TickFrequency = 5
        Me.TBRed.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TBGreen
        '
        Me.TBGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TBGreen.Location = New System.Drawing.Point(597, 80)
        Me.TBGreen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBGreen.Maximum = 255
        Me.TBGreen.Name = "TBGreen"
        Me.TBGreen.Size = New System.Drawing.Size(198, 56)
        Me.TBGreen.TabIndex = 5
        Me.TBGreen.TickFrequency = 5
        Me.TBGreen.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TBBlue
        '
        Me.TBBlue.BackColor = System.Drawing.Color.Blue
        Me.TBBlue.Location = New System.Drawing.Point(597, 155)
        Me.TBBlue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBBlue.Maximum = 255
        Me.TBBlue.Name = "TBBlue"
        Me.TBBlue.Size = New System.Drawing.Size(198, 56)
        Me.TBBlue.TabIndex = 6
        Me.TBBlue.TickFrequency = 5
        Me.TBBlue.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(535, 11)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(46, 15)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Red"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REDCLR
        '
        Me.REDCLR.BackColor = System.Drawing.Color.Red
        Me.REDCLR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.REDCLR.Location = New System.Drawing.Point(535, 44)
        Me.REDCLR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.REDCLR.Name = "REDCLR"
        Me.REDCLR.ReadOnly = True
        Me.REDCLR.Size = New System.Drawing.Size(46, 15)
        Me.REDCLR.TabIndex = 8
        Me.REDCLR.Text = "0"
        Me.REDCLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(535, 80)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(46, 15)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "Green"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GREENCLR
        '
        Me.GREENCLR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GREENCLR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GREENCLR.Location = New System.Drawing.Point(535, 118)
        Me.GREENCLR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GREENCLR.Name = "GREENCLR"
        Me.GREENCLR.ReadOnly = True
        Me.GREENCLR.Size = New System.Drawing.Size(46, 15)
        Me.GREENCLR.TabIndex = 10
        Me.GREENCLR.Text = "0"
        Me.GREENCLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Blue
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(535, 155)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(46, 15)
        Me.TextBox5.TabIndex = 11
        Me.TextBox5.Text = "Blue"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BLUECLR
        '
        Me.BLUECLR.BackColor = System.Drawing.Color.Blue
        Me.BLUECLR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BLUECLR.Location = New System.Drawing.Point(535, 196)
        Me.BLUECLR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BLUECLR.Name = "BLUECLR"
        Me.BLUECLR.ReadOnly = True
        Me.BLUECLR.Size = New System.Drawing.Size(46, 15)
        Me.BLUECLR.TabIndex = 12
        Me.BLUECLR.Text = "0"
        Me.BLUECLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(823, 100)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(829, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Preview Color"
        '
        'TMRGen
        '
        Me.TMRGen.Enabled = True
        Me.TMRGen.Interval = 1
        '
        'PrvwBtn
        '
        Me.PrvwBtn.Location = New System.Drawing.Point(848, 164)
        Me.PrvwBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrvwBtn.Name = "PrvwBtn"
        Me.PrvwBtn.Size = New System.Drawing.Size(75, 23)
        Me.PrvwBtn.TabIndex = 15
        Me.PrvwBtn.Text = "Button2"
        Me.PrvwBtn.UseVisualStyleBackColor = True
        '
        'EllsIndx
        '
        Me.EllsIndx.Location = New System.Drawing.Point(689, 345)
        Me.EllsIndx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EllsIndx.Name = "EllsIndx"
        Me.EllsIndx.Size = New System.Drawing.Size(75, 23)
        Me.EllsIndx.TabIndex = 21
        Me.EllsIndx.Text = "Dellips"
        Me.EllsIndx.UseVisualStyleBackColor = True
        '
        'DotCheck
        '
        Me.DotCheck.AutoSize = True
        Me.DotCheck.Location = New System.Drawing.Point(536, 402)
        Me.DotCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.DotCheck.Name = "DotCheck"
        Me.DotCheck.Size = New System.Drawing.Size(72, 21)
        Me.DotCheck.TabIndex = 13
        Me.DotCheck.Text = "Dotted"
        Me.DotCheck.UseVisualStyleBackColor = True
        '
        'Coordinate
        '
        Me.Coordinate.AutoSize = True
        Me.Coordinate.BackColor = System.Drawing.Color.Transparent
        Me.Coordinate.Location = New System.Drawing.Point(493, 436)
        Me.Coordinate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Coordinate.Name = "Coordinate"
        Me.Coordinate.Size = New System.Drawing.Size(25, 17)
        Me.Coordinate.TabIndex = 22
        Me.Coordinate.Text = "x,y"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(723, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Load Picture"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(723, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Save Picture"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sfdImage
        '
        Me.sfdImage.DefaultExt = "jpg"
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "Image Name"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(675, 248)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(106, 84)
        Me.ListBox2.TabIndex = 25
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1399, 614)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DotCheck)
        Me.Controls.Add(Me.Coordinate)
        Me.Controls.Add(Me.EllsIndx)
        Me.Controls.Add(Me.PrvwBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BLUECLR)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.GREENCLR)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.REDCLR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TBBlue)
        Me.Controls.Add(Me.TBGreen)
        Me.Controls.Add(Me.TBRed)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CrclIndx)
        Me.Controls.Add(Me.clearCanvas_button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainWindow"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TBRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CircleButton As Button
    Friend WithEvents clearCanvas_button As Button
    Friend WithEvents xc_Box As TextBox
    Friend WithEvents yc_Box As TextBox
    Friend WithEvents r_Box As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents b_box As System.Windows.Forms.TextBox
    Friend WithEvents a_box As System.Windows.Forms.TextBox
    Friend WithEvents EllipseButton As System.Windows.Forms.Button
    Friend WithEvents CrclIndx As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TBRed As TrackBar
    Friend WithEvents TBGreen As TrackBar
    Friend WithEvents TBBlue As TrackBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents REDCLR As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GREENCLR As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents BLUECLR As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TMRGen As Timer
    Friend WithEvents PrvwBtn As Button
    Friend WithEvents EllsIndx As System.Windows.Forms.Button
    Friend WithEvents DotCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Coordinate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents sfdImage As SaveFileDialog
    Friend WithEvents ofdImage As OpenFileDialog
    Friend WithEvents ListBox2 As ListBox
End Class
