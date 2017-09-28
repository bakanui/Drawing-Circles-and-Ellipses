<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(333, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 204)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Circle and Ellipse"
        '
        'EllipseButton
        '
        Me.EllipseButton.Location = New System.Drawing.Point(159, 169)
        Me.EllipseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EllipseButton.Name = "EllipseButton"
        Me.EllipseButton.Size = New System.Drawing.Size(100, 28)
        Me.EllipseButton.TabIndex = 14
        Me.EllipseButton.Text = "Ellipse"
        Me.EllipseButton.UseVisualStyleBackColor = True
        '
        'b_box
        '
        Me.b_box.Location = New System.Drawing.Point(149, 75)
        Me.b_box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.b_box.Name = "b_box"
        Me.b_box.Size = New System.Drawing.Size(51, 22)
        Me.b_box.TabIndex = 13
        '
        'a_box
        '
        Me.a_box.Location = New System.Drawing.Point(149, 43)
        Me.a_box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.xc_Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.xc_Box.Name = "xc_Box"
        Me.xc_Box.Size = New System.Drawing.Size(51, 22)
        Me.xc_Box.TabIndex = 5
        '
        'yc_Box
        '
        Me.yc_Box.Location = New System.Drawing.Point(67, 75)
        Me.yc_Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.yc_Box.Name = "yc_Box"
        Me.yc_Box.Size = New System.Drawing.Size(51, 22)
        Me.yc_Box.TabIndex = 4
        '
        'r_Box
        '
        Me.r_Box.Location = New System.Drawing.Point(68, 137)
        Me.r_Box.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.r_Box.Name = "r_Box"
        Me.r_Box.Size = New System.Drawing.Size(132, 22)
        Me.r_Box.TabIndex = 3
        '
        'CircleButton
        '
        Me.CircleButton.Location = New System.Drawing.Point(8, 169)
        Me.CircleButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(100, 28)
        Me.CircleButton.TabIndex = 2
        Me.CircleButton.Text = "Circle"
        Me.CircleButton.UseVisualStyleBackColor = True
        '
        'clearCanvas_button
        '
        Me.clearCanvas_button.Location = New System.Drawing.Point(103, 251)
        Me.clearCanvas_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clearCanvas_button.Name = "clearCanvas_button"
        Me.clearCanvas_button.Size = New System.Drawing.Size(132, 28)
        Me.clearCanvas_button.TabIndex = 0
        Me.clearCanvas_button.Text = "Clear Canvas"
        Me.clearCanvas_button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 475)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.clearCanvas_button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
