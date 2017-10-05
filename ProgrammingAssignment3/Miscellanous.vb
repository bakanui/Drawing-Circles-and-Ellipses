Public Class Miscellanous
    Dim circle As Circle = New Circle()
    Sub clearCanvas()
        For i = 0 To MainWindow.PictureBox1.Width - 1
            For j = 0 To MainWindow.PictureBox1.Height - 1
                MainWindow.canvas.SetPixel(i, j, Color.White)
            Next
        Next
        MainWindow.PictureBox1.Image = MainWindow.canvas
    End Sub

    Sub listCircle()
        MainWindow.ListBox1.Items.Clear()
        For i = 0 To Circle.idx - 1
            MainWindow.ListBox1.Items.Add("Circle " + CStr(i))
        Next
    End Sub
End Class
