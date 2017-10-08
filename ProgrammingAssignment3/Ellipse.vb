Public Class Ellipse
    Public Property xc As Double
    Public Property yc As Double
    Public Property x As Double
    Public Property y As Double

    Public Property startN As Integer
    Public Property endN As Integer

    Public Shared color

    Public Shared tempN As Integer
    Public Shared e() As Ellipse
    Public Shared idx As Integer
    Public Shared N As Integer
    Public Shared Elmt() As Point
    Public Property eLength As Integer

    Sub ellipseInit()
        idx = 0
        N = 0
        tempN = 0
        ReDim e(-1)
        ReDim Elmt(-1)
    End Sub

    Public Sub ellipseIdx(sN As Integer, eN As Integer)
        startN = sN
        endN = eN
        eLength = endN - startN - 1
    End Sub

    Public Shared Sub ellipseDelete(i As Integer)
        If i < idx - 1 Then
            MsgBox("You can only delete bottom-most object", MsgBoxStyle.Critical, "Error")
        Else
            Dim j As Integer
            Dim k As Integer = 0
            ReDim Preserve Elmt(N)
            Dim erasure As Integer = Elmt.Length - 2
            Dim length As Integer = e(i).eLength + 1
            Dim Nend As Integer = e(i).endN
            If Nend = N Then
                N = N - length
            End If
            For k = i To idx - 2
                e(i) = e(i + 1)
            Next
            idx = idx - 1
            ReDim Preserve e(idx - 1)
            ReDim Preserve Elmt(N)
            Miscellanous.EllipserefreshPoints(N)
        End If
        'somehow needs to refill the screen with stored points
        'could point canvasRefresh here
    End Sub

    Public Shared Sub setEllipsePixels(xc As Double, yc As Double, x As Double, y As Double)
        MainWindow.canvas.SetPixel(xc + x - 1, yc + y, color)
        MainWindow.canvas.SetPixel(xc - x + 1, yc + y, color)
        MainWindow.canvas.SetPixel(xc + x - 1, yc - y, color)
        MainWindow.canvas.SetPixel(xc - x + 1, yc - y, color)
    End Sub

    Overloads Sub storeEllipse(P As Point)
        Dim i As Integer
        ReDim Preserve Elmt(N)
        Elmt(N) = P
        N = N + 1
    End Sub

    Overloads Sub storeEllipse(pxc As Double, pyc As Double, pa As Double, pb As Double)
        Dim P As Point
        Dim i As Integer
        P = New Point
        P.SetP(pxc, pyc, pa, pb)
        ReDim Preserve Elmt(N)
        Elmt(N) = P
        N = N + 1
    End Sub
    'help to simplify the code :D
    Sub createEllipse(xc As Integer, yc As Integer, a As Integer, b As Integer)
        Dim ells As Ellipse = New Ellipse
        Dim x = 0
        Dim y = b
        Dim a2 = a * a
        Dim b2 = b * b
        tempN = N
        ReDim Preserve e(idx)
        If MainWindow.DotCheck.Checked = True Then
            Dim d1 = (4 * b2) - (4 * a2 * b) + a2
            While a2 * ((2 * y) - 1) >= 2 * b2 * (x + 1)
                x = x + 2
                If d1 > 0 Then
                    y = y - 2
                    d1 = d1 + ((b2 * (8 * x + 12)) + (a2 * (8 - 8 * y)))
                Else
                    d1 = d1 + (b2 * ((8 * x) + 12))
                End If
                setEllipsePixels(xc, yc, x, y)
                storeEllipse(xc, yc, x, y)
            End While

            Dim d2 = (b2 * ((2 * x) + 1) * ((2 * x) + 1)) + (4 * a2 * ((y - 1) * (y - 1))) - (4 * a2 * b2)
            While y > 0
                y = y - 2
                If d2 < 0 Then
                    x = x + 1
                    x = x + 1
                    d2 = d2 + ((b2 * (8 * x + 8)) + (a2 * (12 - (8 * y))))
                Else
                    d2 = d2 + (a2 * (12 - (8 * y)))
                End If
                setEllipsePixels(xc, yc, x, y)
                storeEllipse(xc, yc, x, y)
            End While
        ElseIf MainWindow.DotCheck.Checked = False Then
            Dim d1 = (4 * b2) - (4 * a2 * b) + a2
            While a2 * ((2 * y) - 1) >= 2 * b2 * (x + 1)
                x = x + 1
                If d1 > 0 Then
                    y = y - 1
                    d1 = d1 + ((b2 * (8 * x + 12)) + (a2 * (8 - 8 * y)))
                Else
                    d1 = d1 + (b2 * ((8 * x) + 12))
                End If
                setEllipsePixels(xc, yc, x, y)
                storeEllipse(xc, yc, x, y)
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
                setEllipsePixels(xc, yc, x, y)
                storeEllipse(xc, yc, x, y)
            End While
        End If
        MainWindow.PictureBox1.Image = MainWindow.canvas
        ells.ellipseIdx(tempN, N)
        e(idx) = ells
        idx = idx + 1
    End Sub
End Class
