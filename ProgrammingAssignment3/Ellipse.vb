Public Class Ellipse
    Sub createEllipse(xc As Integer, yc As Integer, a As Integer, b As Integer)
        Dim x = 0
        Dim y = b
        Dim a2 = a * a
        Dim b2 = b * b

        Dim d1 = (4 * b2) - (4 * a2 * b) + a2

        While a2 * ((2 * y) - 1) >= 2 * b2 * (x + 1)
            x = x + 1
            If d1 > 0 Then
                y = y - 1
                d1 = d1 + ((b2 * (8 * x + 12)) + (a2 * (8 - 8 * y)))
            Else
                d1 = d1 + (b2 * ((8 * x) + 12))
            End If
            MainWindow.canvas.SetPixel(xc + x, yc + y, Color.Black)
            MainWindow.canvas.SetPixel(xc - x, yc + y, Color.Black)
            MainWindow.canvas.SetPixel(xc + x, yc - y, Color.Black)
            MainWindow.canvas.SetPixel(xc - x, yc - y, Color.Black)

        End While

        Dim d2 = (b2 * ((2 * x) + 1) * ((2 * x) + 1)) + (4 * a2 * ((y - 1) * (y - 1))) - (4 * a2 * b2)
        While y > 0
            y = y - 1
            If d2 < 0 Then
                x = x + 1
                d2 = d2 + ((b2 * (8 * x + 8)) + (a2 * (12 - (8 * y))))
            Else
                d2 = d2 + (a2 * (12 - (8 * y)))
            End If
            MainWindow.canvas.SetPixel(xc + x, yc + y, Color.Black)
            MainWindow.canvas.SetPixel(xc - x, yc + y, Color.Black)
            MainWindow.canvas.SetPixel(xc + x, yc - y, Color.Black)
            MainWindow.canvas.SetPixel(xc - x, yc - y, Color.Black)

        End While
        MainWindow.PictureBox1.Image = MainWindow.canvas
    End Sub
End Class
