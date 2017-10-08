Public Class Miscellanous
    Dim circle As Circle = New Circle()
    Dim ellipse As Ellipse = New Ellipse()
    Public Shared color
    Public Shared Sub clearCanvas()
        For i = 0 To MainWindow.PictureBox1.Width - 1
            For j = 0 To MainWindow.PictureBox1.Height - 1
                MainWindow.canvas.SetPixel(i, j, Color.White)
            Next
        Next
        MainWindow.PictureBox1.Image = MainWindow.canvas
        Circle.circleInit()
        Ellipse.ellipseInit()
        MainWindow.ListBox1.Items.Clear()
        MainWindow.ListBox2.Items.Clear()
    End Sub

    Public Shared Sub refreshPoints()
        clearCanvas()
        refreshCircle()
        refreshEllipse()
    End Sub

    Public Shared Sub thiccCircle(xc As Double, yc As Double, x As Double, y As Double, thiccness As Integer)
        If thiccness = 1 Then
            thiccness = 0
        Else
            thiccness = thiccness - 2
            For t = 1 To thiccness
                MainWindow.canvas.SetPixel(xc + x, yc + y - t, color)
                MainWindow.canvas.SetPixel(xc - x, yc + y - t, color)
                MainWindow.canvas.SetPixel(xc + x, yc - y - t, color)
                MainWindow.canvas.SetPixel(xc - x, yc - y - t, color)
                MainWindow.canvas.SetPixel(xc + y - t, yc + x, color)
                MainWindow.canvas.SetPixel(xc - y - t, yc + x, color)
                MainWindow.canvas.SetPixel(xc + y - t, yc - x, color)
                MainWindow.canvas.SetPixel(xc - y - t, yc - x, color)
                MainWindow.canvas.SetPixel(xc + x, yc + y + t, color)
                MainWindow.canvas.SetPixel(xc - x, yc + y + t, color)
                MainWindow.canvas.SetPixel(xc + x, yc - y + t, color)
                MainWindow.canvas.SetPixel(xc - x, yc - y + t, color)
                MainWindow.canvas.SetPixel(xc + y + t, yc + x, color)
                MainWindow.canvas.SetPixel(xc - y + t, yc + x, color)
                MainWindow.canvas.SetPixel(xc + y + t, yc - x, color)
                MainWindow.canvas.SetPixel(xc - y + t, yc - x, color)
            Next

        End If
    End Sub

    Public Shared Sub thiccEllipse(xc As Double, yc As Double, x As Double, y As Double, thiccness As Integer)
        If thiccness = 1 Then
            thiccness = 0
        Else
            thiccness = thiccness - 2
            For t = 1 To thiccness
                MainWindow.canvas.SetPixel(xc + x, yc + y + t, color)
                MainWindow.canvas.SetPixel(xc - x, yc + y + t, color)
                MainWindow.canvas.SetPixel(xc + x, yc - y + t, color)
                MainWindow.canvas.SetPixel(xc - x, yc - y + t, color)
                MainWindow.canvas.SetPixel(xc + x, yc + y - t, color)
                MainWindow.canvas.SetPixel(xc - x, yc + y - t, color)
                MainWindow.canvas.SetPixel(xc + x, yc - y - t, color)
                MainWindow.canvas.SetPixel(xc - x, yc - y - t, color)
            Next
        End If
    End Sub

    Public Shared Sub refreshCircle()
        If MainWindow.ListBox1.Items.Count > 0 Then
            If Circle.Elmt(0).xc = 0 Then
                clearCanvas()
                refreshEllipse()
            Else
                For j = 0 To Circle.Elmt.Length - 2
                    Circle.setCirclePixels(Circle.Elmt(j).xc, Circle.Elmt(j).yc, Circle.Elmt(j).x, Circle.Elmt(j).y)
                Next
            End If
        End If
    End Sub
    Public Shared Sub refreshEllipse()
        If MainWindow.ListBox2.Items.Count > 0 Then
            If Ellipse.eElmt(0).xc = 0 Then
                clearCanvas()
                refreshCircle()
            Else
                For f = 0 To Ellipse.eElmt.Length - 2
                    Ellipse.setEllipsePixels(Ellipse.eElmt(f).xc, Ellipse.eElmt(f).yc, Ellipse.eElmt(f).x, Ellipse.eElmt(f).y)
                Next
            End If
        End If
    End Sub

    Public Shared Sub list()
        MainWindow.ListBox1.Items.Clear()
        MainWindow.ListBox2.Items.Clear()
        For i = 0 To circle.idx - 1

            MainWindow.ListBox1.Items.Add("Circle " + CStr(i))

        Next
        For j = 0 To ellipse.idx - 1
            MainWindow.ListBox2.Items.Add("Ellipse " + CStr(j))
        Next
    End Sub

    Public Shared Sub setPixels(xc As Double, yc As Double, x As Double, y As Double)
        MainWindow.canvas.SetPixel(xc + x, yc + y, color)
        MainWindow.canvas.SetPixel(xc - x, yc + y, color)
        MainWindow.canvas.SetPixel(xc + x, yc - y, color)
        MainWindow.canvas.SetPixel(xc - x, yc - y, color)
        MainWindow.canvas.SetPixel(xc + y, yc + x, color)
        MainWindow.canvas.SetPixel(xc - y, yc + x, color)
        MainWindow.canvas.SetPixel(xc + y, yc - x, color)
        MainWindow.canvas.SetPixel(xc - y, yc - x, color)
    End Sub

    Public Shared Sub setPixelss(xc As Double, yc As Double, x As Double, y As Double)
        MainWindow.canvas.SetPixel(xc + x, yc + y, color)
        MainWindow.canvas.SetPixel(xc - x, yc + y, color)
        MainWindow.canvas.SetPixel(xc + x, yc - y, color)
        MainWindow.canvas.SetPixel(xc - x, yc - y, color)
    End Sub

    Public Shared Sub populateCombo()
        For h = 0 To 11
            h = h + 1
            MainWindow.ComboBox1.Items.Add(h)
        Next
        MainWindow.ComboBox1.SelectedText = 1
    End Sub
End Class
