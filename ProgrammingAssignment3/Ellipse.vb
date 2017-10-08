Public Class Ellipse
    Public Property xc As Double
    Public Property yc As Double
    Public Property x As Double
    Public Property y As Double

    Public Property startN As Integer
    Public Property endN As Integer
    Public Property thiccness As Integer

    Public Shared tempN As Integer
    Public Shared e() As Ellipse
    Public Shared idx As Integer
    Public Shared N As Integer
    Public Shared eElmt() As Point
    Public Property eLength As Integer

    Public Shared Sub ellipseInit()
        idx = 0
        N = 0
        tempN = 0
        ReDim e(-1)
        ReDim eElmt(-1)
    End Sub

    Public Sub ellipseIdx(sN As Integer, eN As Integer, thicc As Integer)
        startN = sN
        endN = eN
        eLength = endN - startN
        thiccness = thicc
    End Sub

    Public Shared Sub ellipseDelete(i As Integer)
        If i < idx - 1 Then
            MsgBox("You can only delete bottom-most object", MsgBoxStyle.Critical, "Error")
        Else
            Dim k As Integer
            ReDim Preserve eElmt(N)
            Dim length As Integer = e(i).eLength
            Dim Nend As Integer = e(i).endN
            If Nend = N Then
                N = N - length
            End If
            For k = i To idx - 2
                e(i) = e(i + 1)
            Next
            idx = idx - 1
            ReDim Preserve e(idx)
            ReDim Preserve eElmt(N)
            Miscellanous.refreshPoints()
        End If
    End Sub

    Public Shared Sub setEllipsePixels(xc As Double, yc As Double, x As Double, y As Double)
        Miscellanous.setPixelss(xc, yc, x, y)
    End Sub

    Sub storeEllipse(pxc As Double, pyc As Double, pa As Double, pb As Double)
        Dim P As Point
        P = New Point
        P.SetP(pxc, pyc, pa, pb)
        ReDim Preserve eElmt(N)
        eElmt(N) = P
        N = N + 1
    End Sub
    Sub createEllipse(xc As Double, yc As Double, a As Double, b As Double)
        Dim ells As Ellipse = New Ellipse
        Dim x = 0
        Dim y = b
        Dim a2 = a * a
        Dim b2 = b * b
        Dim getThicc = MainWindow.ComboBox1.Text
        Dim thicc As Integer = Convert.ToInt32(getThicc)
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
                Miscellanous.thiccEllipse(xc, yc, x, y, thicc)
            End While

            Dim d2 = (b2 * ((2 * x) + 1) * ((2 * x) + 1)) + (4 * a2 * ((y - 1) * (y - 1))) - (4 * a2 * b2)
            While y > 0
                y = y - 2
                If d2 < 0 Then
                    x = x + 2
                    d2 = d2 + ((b2 * (8 * x + 8)) + (a2 * (12 - (8 * y))))
                Else
                    d2 = d2 + (a2 * (12 - (8 * y)))
                End If
                setEllipsePixels(xc, yc, x, y)
                storeEllipse(xc, yc, x, y)
                Miscellanous.thiccEllipse(xc, yc, x, y, thicc)
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
                Miscellanous.thiccEllipse(xc, yc, x, y, thicc)
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
                Miscellanous.thiccEllipse(xc, yc, x, y, thicc)
            End While
        End If
        MainWindow.PictureBox1.Image = MainWindow.canvas
        ells.ellipseIdx(tempN, N, getThicc)
        e(idx) = ells
        idx = idx + 1
    End Sub
End Class
