Public Class Form1
    Dim canvas As Bitmap
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        For i = 0 To PictureBox1.Width - 1
            For j = 0 To PictureBox1.Height - 1
                canvas.SetPixel(i, j, Color.White)
            Next
        Next
        canvas.SetPixel(52, 50, Color.Black)
        PictureBox1.Image = canvas
    End Sub
End Class
