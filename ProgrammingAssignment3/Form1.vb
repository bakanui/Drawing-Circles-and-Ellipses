Public Class Form1
    Dim canvas As Bitmap

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Sub clearCanvas()
        For i = 0 To PictureBox1.Width - 1
            For j = 0 To PictureBox1.Height - 1
                canvas.SetPixel(i, j, Color.White)
            Next
        Next
        PictureBox1.Image = canvas
    End Sub

    Sub createCircle(xc As Integer, yc As Integer, r As Integer)
        Dim y = r
        Dim x = 0
        Dim d = 1 - r
        canvas.SetPixel(xc + x, yc + y, Color.Black)
        canvas.SetPixel(xc - x, yc + y, Color.Black)
        canvas.SetPixel(xc + x, yc - y, Color.Black)
        canvas.SetPixel(xc - x, yc - y, Color.Black)
        canvas.SetPixel(xc + y, yc + x, Color.Black)
        canvas.SetPixel(xc - y, yc + x, Color.Black)
        canvas.SetPixel(xc + y, yc - x, Color.Black)
        canvas.SetPixel(xc - y, yc - x, Color.Black)
        While y >= x
            x = x + 1
            If d < 0 Then
                d = d + (2 * x) + 3
            ElseIf d >= 0 Then
                y = y - 1
                d = d + (2 * x) - (2 * y) + 5
            End If
            canvas.SetPixel(xc + x, yc + y, Color.Black)
            canvas.SetPixel(xc - x, yc + y, Color.Black)
            canvas.SetPixel(xc + x, yc - y, Color.Black)
            canvas.SetPixel(xc - x, yc - y, Color.Black)
            canvas.SetPixel(xc + y, yc + x, Color.Black)
            canvas.SetPixel(xc - y, yc + x, Color.Black)
            canvas.SetPixel(xc + y, yc - x, Color.Black)
            canvas.SetPixel(xc - y, yc - x, Color.Black)
        End While
        PictureBox1.Image = canvas
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        clearCanvas()
        createCircle(100, 100, 20)
    End Sub
End Class
