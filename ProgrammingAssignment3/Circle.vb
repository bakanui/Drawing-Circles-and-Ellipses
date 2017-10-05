Public Class Circle
    Public Property xc As Double
    Public Property yc As Double
    Public Property x As Double
    Public Property y As Double

    Public color

    Public Shared c(,) As Integer
    Public Shared cinside As Integer
    Public Shared idx As Integer
    Public Shared N As Integer
    Public Elmt() As Point

    Sub circleInit()
        cinside = 0
        idx = 0
        N = 0
        ReDim c(-1, -1)
        ReDim Elmt(-1)
    End Sub

    Sub circleDelete(i As Integer)
        'somehow needs to refill the screen with stored points
        'could point canvasRefresh here
    End Sub

    Public Sub setCirclePixels(xc As Double, yc As Double, x As Double, y As Double)
        MainWindow.canvas.SetPixel(xc + x, yc + y, color)
        MainWindow.canvas.SetPixel(xc - x, yc + y, color)
        MainWindow.canvas.SetPixel(xc + x, yc - y, color)
        MainWindow.canvas.SetPixel(xc - x, yc - y, color)
        MainWindow.canvas.SetPixel(xc + y, yc + x, color)
        MainWindow.canvas.SetPixel(xc - y, yc + x, color)
        MainWindow.canvas.SetPixel(xc + y, yc - x, color)
        MainWindow.canvas.SetPixel(xc - y, yc - x, color)
    End Sub

    Overloads Sub storeCircle(P As Point)
        Dim i As Integer
        ReDim Preserve Elmt(N)

        Elmt(0) = P
        N = N + 1
    End Sub

    Overloads Sub storeCircle(pxc As Double, pyc As Double, px As Double, py As Double)
        Dim P As Point
        Dim i As Integer
        P = New Point
        P.SetP(pxc, pyc, px, py)
        ReDim Preserve Elmt(N)

        Elmt(0) = P
        N = N + 1
    End Sub

    Public Sub createCircle(xc As Double, yc As Double, r As Double)
        Dim y = r
        Dim x = 0
        Dim d = 1 - r
        setCirclePixels(xc, yc, x, y)
        '  storeCircle(xc, yc, x, y)
        While y >= x
            x = x + 1
            If d < 0 Then
                d = d + (2 * x) + 3
            ElseIf d >= 0 Then
                y = y - 1
                d = d + (2 * x) - (2 * y) + 5
            End If
            setCirclePixels(xc, yc, x, y)
            '       storeCircle(xc, yc, x, y)
        End While
        MainWindow.PictureBox1.Image = MainWindow.canvas
        idx = idx + 1
    End Sub
End Class