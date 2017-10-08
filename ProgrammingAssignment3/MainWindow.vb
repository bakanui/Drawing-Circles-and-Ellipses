Imports System.IO

Public Class MainWindow
    Public canvas As Bitmap
    Dim circleIdentifier As Integer
    Dim circle As Circle = New Circle()
    Dim ellipse As Ellipse = New Ellipse
    Dim previewColor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        circle.circleInit()
        canvas = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Miscellanous.clearCanvas()
    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        Dim xc As Integer = xc_Box.Text
        Dim yc As Integer = yc_Box.Text
        Dim r As Integer = r_Box.Text
        circle.createCircle(xc, yc, r)
        Miscellanous.list()
    End Sub

    Private Sub clearCanvas_button_Click(sender As Object, e As EventArgs) Handles clearCanvas_button.Click
        Miscellanous.clearCanvas()
    End Sub

    Private Sub EllipseButton_Click(sender As Object, e As EventArgs) Handles EllipseButton.Click
        Dim xc As Integer = xc_Box.Text
        Dim yc As Integer = yc_Box.Text
        Dim a As Integer = a_box.Text
        Dim b As Integer = b_box.Text
        ellipse.createEllipse(xc, yc, a, b)
        Miscellanous.list()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CrclIndx.Click
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
        ellipse.color = previewColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PrvwBtn.Click
        circle.color = previewColor
        ellipse.color = previewColor

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles EllsIndx.Click
        ellipse.ellipseDelete(ListBox1.SelectedIndex)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        Coordinate.Text = (e.X & ", " & e.Y)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ofdImage.ShowDialog()
        If ofdImage.FileName > "" Then
            PictureBox1.ImageLocation = ofdImage.FileName
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        sfdImage.ShowDialog()
        If sfdImage.FileName > "" Then
            PictureBox1.Image.Save(sfdImage.FileName)
        End If
    End Sub
End Class
