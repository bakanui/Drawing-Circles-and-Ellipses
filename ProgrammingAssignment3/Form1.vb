﻿Public Class Form1
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

    Sub createEllipse(xc As Integer, yc As Integer, a As Integer, b As Integer)
        Dim x = 0
        Dim y = b
        Dim a2 = a * a
        Dim b2 = b * b
        Dim d1 = 4 * b2 - 4 * a2 * b + a2
        canvas.SetPixel(xc + x, yc + y, Color.Black)
        canvas.SetPixel(xc - x, yc + y, Color.Black)
        canvas.SetPixel(xc + x, yc - y, Color.Black)
        canvas.SetPixel(xc - x, yc - y, Color.Black)
        canvas.SetPixel(xc + y, yc + x, Color.Black)
        canvas.SetPixel(xc - y, yc + x, Color.Black)
        canvas.SetPixel(xc + y, yc - x, Color.Black)
        canvas.SetPixel(xc - y, yc - x, Color.Black)

        While 2 * b2 * (x + 1) >= a2 * (2 * y - 1)
            x = x + 1
            If d1 > 0 Then
                y = y - 1
                d1 = d1 + b2 * (8 * x + 12) + a2 * (8 - 8 * y)
            Else
                d1 = d1 + b2 * (8 * x + 12)
            End If
        End While

        Dim d2 = b2 * (2 * x + 1) * 2 + 4 * a2 * (y - 1) * 2 - 4 * a2 * b2
        While y > 0
            y = y - 1
            If d2 < 0 Then
                x = x + 1
                d2 = d2 + b2 * (8 * x + 8) + a2 * (12 - 8 * y)
            Else
                d2 = d2 + a2 * (12 - 8 * y)
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
        createEllipse(50, 50, 75, 25)
    End Sub
End Class
