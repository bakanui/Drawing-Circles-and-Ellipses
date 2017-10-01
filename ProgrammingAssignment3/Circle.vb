Public Class Circle

    Public Property xc As Integer
    Public Property yc As Integer
    Public Property x As Integer
    Public Property y As Integer

    'How to init circle list?
    Dim circles As List(Of Circle)
    Public Shared circleID As Integer = 0
    Dim points As Integer = 0

    Public Sub New(ByVal ID As Integer, ByVal point As Integer, pxc As Integer, ByVal pyc As Integer, ByVal px As Integer, ByVal py As Integer)
        circleID = ID
        points = point
        xc = pxc
        yc = pyc
        x = px
        y = py
    End Sub

    Sub circleInit()
        circles = New List(Of Circle) From {
            New Circle(circleID, points, 0, 0, 0, 0)
        }
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
        circles.Add(New Circle(circleID, points, xc, yc, x, y))
    End Sub

    Public Sub createCircle(xc As Integer, yc As Integer, r As Integer)
        Dim y = r
        Dim x = 0
        Dim d = 1 - r
        Dim circlePixelPasses As Integer = 0
        ' circleInit()
        setCirclePixels(xc, yc, x, y)
        ' storeCircle(xc, yc, x, y)
        points = points + 1
        While y >= x
            x = x + 1
            If d < 0 Then
                d = d + (2 * x) + 3
            ElseIf d >= 0 Then
                y = y - 1
                d = d + (2 * x) - (2 * y) + 5
            End If
            setCirclePixels(xc, yc, x, y)
            '   storeCircle(xc, yc, x, y)
            points = points + 1
        End While
        MainWindow.PictureBox1.Image = MainWindow.canvas
        circleID = circleID + 1
    End Sub
End Class
