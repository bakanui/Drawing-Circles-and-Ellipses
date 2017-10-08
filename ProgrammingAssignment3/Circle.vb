Public Class Circle
    Public Property xc As Double
    Public Property yc As Double
    Public Property x As Double
    Public Property y As Double

    Public Property startN As Integer
    Public Property endN As Integer

    Public Shared tempN As Integer
    Public Shared c() As Circle
    Public Shared idx As Integer
    Public Shared N As Integer
    Public Shared Elmt() As Point
    Public Property cLength As Integer

    Sub circleInit()
        idx = 0
        N = 0
        tempN = 0
        ReDim c(-1)
        ReDim Elmt(-1)
    End Sub

    Public Sub circleIdx(sN As Integer, eN As Integer)
        startN = sN
        endN = eN
        cLength = endN - startN
    End Sub

    Public Shared Sub circleDelete(i As Integer)
        If i < idx - 1 Then
            MsgBox("You can only delete bottom-most object", MsgBoxStyle.Critical, "Error")
        Else
            Dim k As Integer = 0
            ReDim Preserve Elmt(N)
            Dim length As Integer = c(i).cLength
            Dim Nend As Integer = c(i).endN
            If Nend = N Then
                N = N - length
            End If
            For k = i To idx - 2
                c(i) = c(i + 1)
            Next
            idx = idx - 1
            ReDim Preserve c(idx)
            ReDim Preserve Elmt(N)
            Miscellanous.refreshPoints()
        End If
        'somehow needs to refill the screen with stored points
        'could point canvasRefresh here
    End Sub

    Public Shared Sub setCirclePixels(xc As Double, yc As Double, x As Double, y As Double)
        Miscellanous.setPixels(xc, yc, x, y)
    End Sub

    Sub storeCircle(pxc As Double, pyc As Double, px As Double, py As Double)
        Dim P As Point
        P = New Point
        P.SetP(pxc, pyc, px, py)
        ReDim Preserve Elmt(N)
        Elmt(N) = P
        N = N + 1
    End Sub

    Public Sub createCircle(xc As Double, yc As Double, r As Double)
        Dim cir As Circle = New Circle
        Dim y = r
        Dim x = 0
        Dim d = 1 - r
        tempN = N
        ReDim Preserve c(idx)
        setCirclePixels(xc, yc, x, y)
        storeCircle(xc, yc, x, y)
        While y >= x
            If MainWindow.DotCheck.Checked = True Then
                x = x + 2
                If d < 0 Then
                    d = d + (2 * x) + 3
                ElseIf d >= 0 Then
                    y = y - 2
                    d = d + (2 * x) - (2 * y) + 5
                End If
            End If
            If MainWindow.DotCheck.Checked = False Then
                x = x + 1
                If d < 0 Then
                    d = d + (2 * x) + 3
                ElseIf d >= 0 Then
                    y = y - 1
                    d = d + (2 * x) - (2 * y) + 5
                End If
            End If
            setCirclePixels(xc, yc, x, y)
            storeCircle(xc, yc, x, y)
        End While
        MainWindow.PictureBox1.Image = MainWindow.canvas
        cir.circleIdx(tempN, N)
        c(idx) = cir
        idx = idx + 1
    End Sub
End Class