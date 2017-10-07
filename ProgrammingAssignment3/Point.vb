Public Class Point
    Public xc, yc, x, y, a, b As Double
    Public Sub SetP(pxc As Double, pyc As Double, px As Double, py As Double)
        xc = pxc
        yc = pyc
        x = px
        y = py
    End Sub

    Public Sub SetP2(pxc As Double, pyc As Double, pa As Double, pb As Double)
        xc = pxc
        yc = pyc
        a = pa
        b = pb
    End Sub
End Class
