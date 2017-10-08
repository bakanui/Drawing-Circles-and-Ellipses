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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EllsIndx = New System.Windows.Forms.Button()
        Me.DotCheck = New System.Windows.Forms.CheckBox()
        Me.Coordinate = New System.Windows.Forms.Label()
        Me.sfdImage = New System.Windows.Forms.SaveFileDialog()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavePictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsPictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsPointToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(674, 329)
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
        Me.GroupBox1.Location = New System.Drawing.Point(2, 395)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 115)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Circle and Ellipse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Center Points"
        '
        'EllipseButton
        '
        Me.EllipseButton.Location = New System.Drawing.Point(311, 83)
        Me.EllipseButton.Name = "EllipseButton"
        Me.EllipseButton.Size = New System.Drawing.Size(75, 28)
        Me.EllipseButton.TabIndex = 7
        Me.EllipseButton.Text = "Ellipse"
        Me.EllipseButton.UseVisualStyleBackColor = True
        '
        'b_box
        '
        Me.b_box.Location = New System.Drawing.Point(258, 93)
        Me.b_box.Name = "b_box"
        Me.b_box.Size = New System.Drawing.Size(39, 20)
        Me.b_box.TabIndex = 6
        '
        'a_box
        '
        Me.a_box.Location = New System.Drawing.Point(197, 91)
        Me.a_box.Name = "a_box"
        Me.a_box.Size = New System.Drawing.Size(39, 20)
        Me.a_box.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(242, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "b"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Radius"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "y"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "x"
        '
        'xc_Box
        '
        Me.xc_Box.Location = New System.Drawing.Point(25, 72)
        Me.xc_Box.Name = "xc_Box"
        Me.xc_Box.Size = New System.Drawing.Size(39, 20)
        Me.xc_Box.TabIndex = 1
        '
        'yc_Box
        '
        Me.yc_Box.Location = New System.Drawing.Point(98, 71)
        Me.yc_Box.Name = "yc_Box"
        Me.yc_Box.Size = New System.Drawing.Size(39, 20)
        Me.yc_Box.TabIndex = 2
        '
        'r_Box
        '
        Me.r_Box.Location = New System.Drawing.Point(197, 28)
        Me.r_Box.Name = "r_Box"
        Me.r_Box.Size = New System.Drawing.Size(100, 20)
        Me.r_Box.TabIndex = 3
        '
        'CircleButton
        '
        Me.CircleButton.Location = New System.Drawing.Point(311, 19)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(75, 28)
        Me.CircleButton.TabIndex = 4
        Me.CircleButton.Text = "Circle"
        Me.CircleButton.UseVisualStyleBackColor = True
        '
        'clearCanvas_button
        '
        Me.clearCanvas_button.Location = New System.Drawing.Point(598, 378)
        Me.clearCanvas_button.Name = "clearCanvas_button"
        Me.clearCanvas_button.Size = New System.Drawing.Size(78, 23)
        Me.clearCanvas_button.TabIndex = 0
        Me.clearCanvas_button.Text = "Clear Canvas"
        Me.clearCanvas_button.UseVisualStyleBackColor = True
        '
        'CrclIndx
        '
        Me.CrclIndx.Location = New System.Drawing.Point(701, 236)
        Me.CrclIndx.Margin = New System.Windows.Forms.Padding(2)
        Me.CrclIndx.Name = "CrclIndx"
        Me.CrclIndx.Size = New System.Drawing.Size(56, 37)
        Me.CrclIndx.TabIndex = 2
        Me.CrclIndx.Text = "Delete Circle"
        Me.CrclIndx.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(686, 58)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(81, 173)
        Me.ListBox1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(179, 38)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 36)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Outline Color"
        '
        'EllsIndx
        '
        Me.EllsIndx.Location = New System.Drawing.Point(701, 482)
        Me.EllsIndx.Margin = New System.Windows.Forms.Padding(2)
        Me.EllsIndx.Name = "EllsIndx"
        Me.EllsIndx.Size = New System.Drawing.Size(56, 41)
        Me.EllsIndx.TabIndex = 21
        Me.EllsIndx.Text = "Delete Ellipse"
        Me.EllsIndx.UseVisualStyleBackColor = True
        '
        'DotCheck
        '
        Me.DotCheck.AutoSize = True
        Me.DotCheck.Location = New System.Drawing.Point(13, 20)
        Me.DotCheck.Name = "DotCheck"
        Me.DotCheck.Size = New System.Drawing.Size(58, 17)
        Me.DotCheck.TabIndex = 13
        Me.DotCheck.Text = "Dotted"
        Me.DotCheck.UseVisualStyleBackColor = True
        '
        'Coordinate
        '
        Me.Coordinate.AutoSize = True
        Me.Coordinate.BackColor = System.Drawing.Color.Transparent
        Me.Coordinate.Location = New System.Drawing.Point(608, 335)
        Me.Coordinate.Name = "Coordinate"
        Me.Coordinate.Size = New System.Drawing.Size(20, 13)
        Me.Coordinate.TabIndex = 22
        Me.Coordinate.Text = "x,y"
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
        Me.ListBox2.Location = New System.Drawing.Point(686, 318)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(80, 160)
        Me.ListBox2.TabIndex = 25
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SavePictureToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SavePictureToolStripMenuItem
        '
        Me.SavePictureToolStripMenuItem.Name = "SavePictureToolStripMenuItem"
        Me.SavePictureToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SavePictureToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsPictureToolStripMenuItem, Me.SaveAsPointToolStripMenuItem})
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsPictureToolStripMenuItem
        '
        Me.SaveAsPictureToolStripMenuItem.Name = "SaveAsPictureToolStripMenuItem"
        Me.SaveAsPictureToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SaveAsPictureToolStripMenuItem.Text = "Save As Picture"
        '
        'SaveAsPointToolStripMenuItem
        '
        Me.SaveAsPointToolStripMenuItem.Name = "SaveAsPointToolStripMenuItem"
        Me.SaveAsPointToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SaveAsPointToolStripMenuItem.Text = "Save As Point"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(703, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Circle(s)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(698, 295)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Ellipse(s)"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 45)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(42, 17)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Arc"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(13, 71)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox2.TabIndex = 30
        Me.CheckBox2.Text = "Chart"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.DotCheck)
        Me.GroupBox2.Location = New System.Drawing.Point(402, 401)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 109)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Properties"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Line Thickness"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(98, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(496, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Refresh Canvas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 531)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Coordinate)
        Me.Controls.Add(Me.EllsIndx)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CrclIndx)
        Me.Controls.Add(Me.clearCanvas_button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainWindow"
        Me.Text = "Circle and Ellipse Generator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EllsIndx As System.Windows.Forms.Button
    Friend WithEvents DotCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Coordinate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents sfdImage As SaveFileDialog
    Friend WithEvents ofdImage As OpenFileDialog
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SavePictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsPictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsPointToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
