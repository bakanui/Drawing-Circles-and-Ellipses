Public Class MainWindow
    Public canvas As Bitmap
    Dim circleIdentifier As Integer
    Dim circle As Circle = New Circle()
    Dim ellipse As Ellipse
    Dim misc As Miscellanous = New Miscellanous
    Dim previewColor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        misc.clearCanvas()
    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        Dim xc As Integer = xc_Box.Text
        Dim yc As Integer = yc_Box.Text
        Dim r As Integer = r_Box.Text
        circle.createCircle(xc, yc, r)
        misc.listCircles()
    End Sub

    Private Sub clearCanvas_button_Click(sender As Object, e As EventArgs) Handles clearCanvas_button.Click
        misc.clearCanvas()
    End Sub

    Private Sub EllipseButton_Click(sender As Object, e As EventArgs) Handles EllipseButton.Click
        ellipse = New Ellipse
        Dim xc As Integer = xc_Box.Text
        Dim yc As Integer = yc_Box.Text
        Dim a As Integer = a_box.Text
        Dim b As Integer = b_box.Text
        ellipse.createEllipse(xc, yc, a, b)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        circle.circleDelete(ListBox1.SelectedIndex)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub TMRGen_Tick(sender As Object, e As EventArgs) Handles TMRGen.Tick
        REDCLR.Text = TBRed.Value
        GREENCLR.Text = TBGreen.Value
        BLUECLR.Text = TBBlue.Value
        Dim red1, green1, blue1 As Integer
        red1 = REDCLR.Text
        green1 = GREENCLR.Text
        blue1 = BLUECLR.Text
        previewColor = Color.FromArgb(red1, green1, blue1)
        PictureBox2.BackColor = previewColor
        circle.color = previewColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        circle.color = previewColor

    End Sub

End Class
