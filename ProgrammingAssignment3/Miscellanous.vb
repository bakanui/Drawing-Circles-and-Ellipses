Public Class Miscellanous
    Dim circle As Circle = New Circle()
    Dim ellipse As Ellipse = New Ellipse()
    Public Shared Sub clearCanvas()
        For i = 0 To MainWindow.PictureBox1.Width - 1
            For j = 0 To MainWindow.PictureBox1.Height - 1
                MainWindow.canvas.SetPixel(i, j, Color.White)
            Next
        Next
        MainWindow.PictureBox1.Image = MainWindow.canvas
    End Sub

    Public Shared Sub CirclerefreshPoints(eN As Integer)
        clearCanvas()
        If circle.Elmt(0).xc = 0 Then
            clearCanvas()
        Else
            For j = 0 To circle.Elmt.Length - 2
                circle.setCirclePixels(circle.Elmt(j).xc, circle.Elmt(j).yc, circle.Elmt(j).x, circle.Elmt(j).y)
            Next
        End If
    End Sub

    Public Shared Sub list()
        MainWindow.ListBox1.Items.Clear()
        For i = 0 To circle.idx - 1

            MainWindow.ListBox1.Items.Add("Circle " + CStr(i))

        Next
        For j = 0 To ellipse.idx - 1
            MainWindow.ListBox1.Items.Add("Ellipse " + CStr(j))
        Next
    End Sub

    Public Shared Sub EllipserefreshPoints(eN As Integer)
        clearCanvas()
        If ellipse.Elmt(0).yc = 0 Then
            clearCanvas()
        Else
            For j = 0 To ellipse.Elmt.Length - 2
                ellipse.setEllipsePixels(ellipse.Elmt(j).xc, ellipse.Elmt(j).yc, ellipse.Elmt(j).a, ellipse.Elmt(j).b)
            Next
        End If
    End Sub

End Class
