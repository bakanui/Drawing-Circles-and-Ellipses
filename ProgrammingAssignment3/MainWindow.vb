Public Class MainWindow
    Public canvas As Bitmap
    Dim circleIdentifier As Integer
    Dim circle As Circle
    Dim ellipse As Ellipse
    Dim misc As Miscellanous = New Miscellanous

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        circle.circleInit()
        canvas = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        misc.clearCanvas()
    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        circle = New Circle
        Dim xc As Integer = xc_Box.Text
        Dim yc As Integer = yc_Box.Text
        Dim r As Integer = r_Box.Text
        circle.createCircle(xc, yc, r)

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

    End Sub

End Class
