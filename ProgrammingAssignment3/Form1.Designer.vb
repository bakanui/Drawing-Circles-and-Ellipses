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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.xc_Box = New System.Windows.Forms.TextBox()
        Me.yc_Box = New System.Windows.Forms.TextBox()
        Me.r_Box = New System.Windows.Forms.TextBox()
        Me.CircleButton = New System.Windows.Forms.Button()
        Me.clearCanvas_button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(250, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 362)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.xc_Box)
        Me.GroupBox1.Controls.Add(Me.yc_Box)
        Me.GroupBox1.Controls.Add(Me.r_Box)
        Me.GroupBox1.Controls.Add(Me.CircleButton)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 166)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Circle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Center Points"
        '
        'xc_Box
        '
        Me.xc_Box.Location = New System.Drawing.Point(50, 35)
        Me.xc_Box.Name = "xc_Box"
        Me.xc_Box.Size = New System.Drawing.Size(100, 20)
        Me.xc_Box.TabIndex = 5
        '
        'yc_Box
        '
        Me.yc_Box.Location = New System.Drawing.Point(50, 61)
        Me.yc_Box.Name = "yc_Box"
        Me.yc_Box.Size = New System.Drawing.Size(100, 20)
        Me.yc_Box.TabIndex = 4
        '
        'r_Box
        '
        Me.r_Box.Location = New System.Drawing.Point(51, 111)
        Me.r_Box.Name = "r_Box"
        Me.r_Box.Size = New System.Drawing.Size(100, 20)
        Me.r_Box.TabIndex = 3
        '
        'CircleButton
        '
        Me.CircleButton.Location = New System.Drawing.Point(63, 137)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(75, 23)
        Me.CircleButton.TabIndex = 2
        Me.CircleButton.Text = "Generate"
        Me.CircleButton.UseVisualStyleBackColor = True
        '
        'clearCanvas_button
        '
        Me.clearCanvas_button.Location = New System.Drawing.Point(77, 204)
        Me.clearCanvas_button.Name = "clearCanvas_button"
        Me.clearCanvas_button.Size = New System.Drawing.Size(99, 23)
        Me.clearCanvas_button.TabIndex = 0
        Me.clearCanvas_button.Text = "Clear Canvas"
        Me.clearCanvas_button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Radius"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 386)
        Me.Controls.Add(Me.clearCanvas_button)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
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
End Class
