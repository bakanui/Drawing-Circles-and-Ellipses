Public Class Miscellanous
    Dim circle As Circle = New Circle()
    Public Shared Sub clearCanvas()
        For i = 0 To MainWindow.PictureBox1.Width - 1
            For j = 0 To MainWindow.PictureBox1.Height - 1
                MainWindow.canvas.SetPixel(i, j, Color.White)
            Next
        Next
        MainWindow.PictureBox1.Image = MainWindow.canvas
    End Sub

    Public Shared Sub refreshPoints(eN As Integer)
        clearCanvas()
        If Circle.Elmt(0).xc = 0 Then
            clearCanvas()
        Else
            For j = 0 To Circle.Elmt.Length - 2
                Circle.setCirclePixels(Circle.Elmt(j).xc, Circle.Elmt(j).yc, Circle.Elmt(j).x, Circle.Elmt(j).y)
            Next
        End If
    End Sub

    Public Shared Sub listCircle()
        MainWindow.ListBox1.Items.Clear()
        For i = 0 To Circle.idx - 1
            MainWindow.ListBox1.Items.Add("Circle " + CStr(i))
        Next
    End Sub
End Class
