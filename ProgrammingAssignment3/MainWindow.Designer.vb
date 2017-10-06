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
        Me.EllipseButton = New System.Windows.Forms.Button()
        Me.b_box = New System.Windows.Forms.TextBox()
        Me.a_box = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xc_Box = New System.Windows.Forms.TextBox()
        Me.yc_Box = New System.Windows.Forms.TextBox()
        Me.r_Box = New System.Windows.Forms.TextBox()
        Me.CircleButton = New System.Windows.Forms.Button()
        Me.clearCanvas_button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.sfdI = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
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
        Me.PictureBox1.Location = New System.Drawing.Point(843, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(447, 446)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EllipseButton)
        Me.GroupBox1.Controls.Add(Me.b_box)
        Me.GroupBox1.Controls.Add(Me.a_box)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xc_Box)
        Me.GroupBox1.Controls.Add(Me.yc_Box)
        Me.GroupBox1.Controls.Add(Me.r_Box)
        Me.GroupBox1.Controls.Add(Me.CircleButton)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 204)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Circle and Ellipse"
        '
        'EllipseButton
        '
        Me.EllipseButton.Location = New System.Drawing.Point(159, 169)
        Me.EllipseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EllipseButton.Name = "EllipseButton"
        Me.EllipseButton.Size = New System.Drawing.Size(100, 28)
        Me.EllipseButton.TabIndex = 14
        Me.EllipseButton.Text = "Ellipse"
        Me.EllipseButton.UseVisualStyleBackColor = True
        '
        'b_box
        '
        Me.b_box.Location = New System.Drawing.Point(149, 75)
        Me.b_box.Margin = New System.Windows.Forms.Padding(4)
        Me.b_box.Name = "b_box"
        Me.b_box.Size = New System.Drawing.Size(51, 22)
        Me.b_box.TabIndex = 13
        '
        'a_box
        '
        Me.a_box.Location = New System.Drawing.Point(149, 43)
        Me.a_box.Margin = New System.Windows.Forms.Padding(4)
        Me.a_box.Name = "a_box"
        Me.a_box.Size = New System.Drawing.Size(51, 22)
        Me.a_box.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(127, 79)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "b"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(127, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Radius"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "y"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Center Points"
        '
        'xc_Box
        '
        Me.xc_Box.Location = New System.Drawing.Point(67, 43)
        Me.xc_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.xc_Box.Name = "xc_Box"
        Me.xc_Box.Size = New System.Drawing.Size(51, 22)
        Me.xc_Box.TabIndex = 5
        '
        'yc_Box
        '
        Me.yc_Box.Location = New System.Drawing.Point(67, 75)
        Me.yc_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.yc_Box.Name = "yc_Box"
        Me.yc_Box.Size = New System.Drawing.Size(51, 22)
        Me.yc_Box.TabIndex = 4
        '
        'r_Box
        '
        Me.r_Box.Location = New System.Drawing.Point(68, 137)
        Me.r_Box.Margin = New System.Windows.Forms.Padding(4)
        Me.r_Box.Name = "r_Box"
        Me.r_Box.Size = New System.Drawing.Size(132, 22)
        Me.r_Box.TabIndex = 3
        '
        'CircleButton
        '
        Me.CircleButton.Location = New System.Drawing.Point(8, 169)
        Me.CircleButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(100, 28)
        Me.CircleButton.TabIndex = 2
        Me.CircleButton.Text = "Circle"
        Me.CircleButton.UseVisualStyleBackColor = True
        '
        'clearCanvas_button
        '
        Me.clearCanvas_button.Location = New System.Drawing.Point(137, 238)
        Me.clearCanvas_button.Margin = New System.Windows.Forms.Padding(4)
        Me.clearCanvas_button.Name = "clearCanvas_button"
        Me.clearCanvas_button.Size = New System.Drawing.Size(132, 28)
        Me.clearCanvas_button.TabIndex = 0
        Me.clearCanvas_button.Text = "Clear Canvas"
        Me.clearCanvas_button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 425)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(165, 302)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(159, 116)
        Me.ListBox1.TabIndex = 3
        '
        'TBRed
        '
        Me.TBRed.BackColor = System.Drawing.Color.Red
        Me.TBRed.Location = New System.Drawing.Point(346, 50)
        Me.TBRed.Maximum = 255
        Me.TBRed.Name = "TBRed"
        Me.TBRed.Size = New System.Drawing.Size(301, 56)
        Me.TBRed.TabIndex = 4
        Me.TBRed.TickFrequency = 5
        Me.TBRed.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TBGreen
        '
        Me.TBGreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TBGreen.Location = New System.Drawing.Point(346, 112)
        Me.TBGreen.Maximum = 255
        Me.TBGreen.Name = "TBGreen"
        Me.TBGreen.Size = New System.Drawing.Size(301, 56)
        Me.TBGreen.TabIndex = 5
        Me.TBGreen.TickFrequency = 5
        Me.TBGreen.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TBBlue
        '
        Me.TBBlue.BackColor = System.Drawing.Color.Blue
        Me.TBBlue.Location = New System.Drawing.Point(346, 174)
        Me.TBBlue.Maximum = 255
        Me.TBBlue.Name = "TBBlue"
        Me.TBBlue.Size = New System.Drawing.Size(301, 56)
        Me.TBBlue.TabIndex = 6
        Me.TBBlue.TickFrequency = 5
        Me.TBBlue.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(679, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 15)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Red"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REDCLR
        '
        Me.REDCLR.BackColor = System.Drawing.Color.Red
        Me.REDCLR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.REDCLR.Location = New System.Drawing.Point(679, 76)
        Me.REDCLR.Name = "REDCLR"
        Me.REDCLR.ReadOnly = True
        Me.REDCLR.Size = New System.Drawing.Size(100, 15)
        Me.REDCLR.TabIndex = 8
        Me.REDCLR.Text = "0"
        Me.REDCLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(679, 122)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(100, 15)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "Green"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GREENCLR
        '
        Me.GREENCLR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GREENCLR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GREENCLR.Location = New System.Drawing.Point(679, 143)
        Me.GREENCLR.Name = "GREENCLR"
        Me.GREENCLR.ReadOnly = True
        Me.GREENCLR.Size = New System.Drawing.Size(100, 15)
        Me.GREENCLR.TabIndex = 10
        Me.GREENCLR.Text = "0"
        Me.GREENCLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Blue
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Location = New System.Drawing.Point(679, 187)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 15)
        Me.TextBox5.TabIndex = 11
        Me.TextBox5.Text = "Blue"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BLUECLR
        '
        Me.BLUECLR.BackColor = System.Drawing.Color.Blue
        Me.BLUECLR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BLUECLR.Location = New System.Drawing.Point(679, 208)
        Me.BLUECLR.Name = "BLUECLR"
        Me.BLUECLR.ReadOnly = True
        Me.BLUECLR.Size = New System.Drawing.Size(100, 15)
        Me.BLUECLR.TabIndex = 12
        Me.BLUECLR.Text = "0"
        Me.BLUECLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(679, 279)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(685, 249)
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(539, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(361, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Enter password to be saved"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(364, 342)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 22)
        Me.TextBox2.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(464, 370)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(364, 400)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Saved password"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(367, 421)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 24)
        Me.ComboBox1.TabIndex = 20
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(664, 356)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 23)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Load Picture"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'sfdI
        '
        Me.sfdI.Location = New System.Drawing.Point(664, 386)
        Me.sfdI.Name = "sfdI"
        Me.sfdI.Size = New System.Drawing.Size(109, 23)
        Me.sfdI.TabIndex = 22
        Me.sfdI.Text = "Save Picture"
        Me.sfdI.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(698, 440)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'sfdImage
        '
        Me.sfdImage.DefaultExt = "jpg"
        '
        'ofdImage
        '
        Me.ofdImage.FileName = "Image Name"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 475)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.sfdI)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
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
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents b_box As System.Windows.Forms.TextBox
    Friend WithEvents a_box As System.Windows.Forms.TextBox
    Friend WithEvents EllipseButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents sfdI As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents sfdImage As SaveFileDialog
    Friend WithEvents ofdImage As OpenFileDialog
End Class
