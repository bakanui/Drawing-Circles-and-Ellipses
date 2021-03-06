﻿Imports System.IO

Public Class MainWindow
    Public canvas As Bitmap
    Dim circle As Circle = New Circle()
    Dim ellipse As Ellipse = New Ellipse()
    Public file

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Miscellanous.color = Color.Black
        PictureBox2.BackColor = Color.Black
        circle.circleInit()
        canvas = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Miscellanous.clearCanvas()
        Miscellanous.populateCombo()
    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        Dim xc As Integer = xc_Box.Text
        Dim yc As Integer = yc_Box.Text
        Dim r As Integer = r_Box.Text
        If r > xc Or yc Then
            MsgBox("Radius cannot be greater than the center points!", MsgBoxStyle.Critical, "Error")
        ElseIf r < 0 Then
            MsgBox("Radius out of bounds, cannot be negative numbers!", MsgBoxStyle.Critical, "Error")
        Else
            circle.createCircle(xc, yc, r)
        End If
        Miscellanous.list()
    End Sub

    Private Sub clearCanvas_button_Click(sender As Object, e As EventArgs) Handles clearCanvas_button.Click
        Miscellanous.clearCanvas()
    End Sub

    Private Sub EllipseButton_Click(sender As Object, e As EventArgs) Handles EllipseButton.Click
        Dim xc As Integer = xc_Box.Text
        Dim yc As Integer = yc_Box.Text
        Dim a As Integer = a_box.Text
        Dim b As Integer = b_box.Text
        If a Or b > xc Or yc Then
            MsgBox("A or B cannot be greater than the center points!", MsgBoxStyle.Critical, "Error")
        ElseIf a Or b < 0 Then
            MsgBox("A or B out of bounds, cannot be negative numbers!", MsgBoxStyle.Critical, "Error")
        Else
            ellipse.createEllipse(xc, yc, a, b)
        End If
        Miscellanous.list()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CrclIndx.Click
        circle.circleDelete(ListBox1.SelectedIndex)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles EllsIndx.Click
        Ellipse.ellipseDelete(ListBox2.SelectedIndex)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseMove
        Coordinate.Text = (e.X & ", " & e.Y)
    End Sub

    Private Sub SaveAsPictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsPictureToolStripMenuItem.Click
        sfdImage.ShowDialog()
        sfdImage.Title = "Save Canvas as JPEG"
        sfdImage.Filter = "JPEG Image|*.jpg"
        If sfdImage.FileName > "" Then
            PictureBox1.Image.Save(sfdImage.FileName)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim colors As DialogResult
        colors = ColorDialog1.ShowDialog()

        If colors = Windows.Forms.DialogResult.OK Then
            Miscellanous.color = ColorDialog1.Color
            PictureBox2.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Miscellanous.refreshPoints()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New About()
        about.Show()
    End Sub
End Class
