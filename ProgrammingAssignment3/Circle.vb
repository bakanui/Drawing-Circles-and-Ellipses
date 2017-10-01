Public Class Circle

    Dim xc As Integer, yc As Integer, x As Integer, y As Integer

    'How to init circle list?
    Dim circle(,,) As List(Of Integer)
    Dim i = 0
    Dim j = 0

    Sub circleInit()
        For i = 0 To 99
            For j = 0 To 99
                For k = 0 To 3
                    circle(i, j, k).Add(0)
                Next
            Next
        Next
    End Sub

    Public Sub setCirclePixels(xc As Integer, yc As Integer, x As Integer, y As Integer)
        MainWindow.canvas.SetPixel(xc + x, yc + y, Color.Black)
        MainWindow.canvas.SetPixel(xc - x, yc + y, Color.Black)
        MainWindow.canvas.SetPixel(xc + x, yc - y, Color.Black)
        MainWindow.canvas.SetPixel(xc - x, yc - y, Color.Black)
        MainWindow.canvas.SetPixel(xc + y, yc + x, Color.Black)
        MainWindow.canvas.SetPixel(xc - y, yc + x, Color.Black)
        MainWindow.canvas.SetPixel(xc + y, yc - x, Color.Black)
        MainWindow.canvas.SetPixel(xc - y, yc - x, Color.Black)
    End Sub

    Sub storeCircle(xc As Integer, yc As Integer, x As Integer, y As Integer)
        circle(i, j, 0).Add(xc)
        circle(i, j, 1).Add(yc)
        circle(i, j, 2).Add(x)
        circle(i, j, 3).Add(y)
    End Sub

    Public Sub createCircle(xc As Integer, yc As Integer, r As Integer)
        Dim y = r
        Dim x = 0
        Dim d = 1 - r
        Dim circlePixelPasses As Integer = 0
        setCirclePixels(xc, yc, x, y)
        storeCircle(xc, yc, x, y)
        j = j + 1
        While y >= x
            x = x + 1
            If d < 0 Then
                d = d + (2 * x) + 3
            ElseIf d >= 0 Then
                y = y - 1
                d = d + (2 * x) - (2 * y) + 5
            End If
            setCirclePixels(xc, yc, x, y)
            storeCircle(xc, yc, x, y)
            j = j + 1
        End While
        MainWindow.PictureBox1.Image = MainWindow.canvas
        i = i + 1
    End Sub
End Class
