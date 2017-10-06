﻿Imports System.IO

Public Class MainWindow
    Public canvas As Bitmap
    Dim circleIdentifier As Integer
    Dim circle As Circle = New Circle()
    Dim ellipse As Ellipse
    Dim previewColor
    Dim a As StreamReader
    Dim b As String
    Dim c As String = "C:\Saved\pwtest.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        circle.circleInit()
        canvas = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Miscellanous.clearCanvas()
        If Not File.Exists(c) Then
            Dim d As FileStream
            d = File.Create(c)
            d.Close()
        End If
        ReadFile()
    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        Dim xc As Integer = xc_Box.Text
        Dim yc As Integer = yc_Box.Text
        Dim r As Integer = r_Box.Text
        circle.createCircle(xc, yc, r)
        Miscellanous.listCircle()
    End Sub

    Private Sub clearCanvas_button_Click(sender As Object, e As EventArgs) Handles clearCanvas_button.Click
        Miscellanous.clearCanvas()
    End Sub

    Private Sub EllipseButton_Click(sender As Object, e As EventArgs) Handles EllipseButton.Click
        ellipse = New Ellipse
        Dim xc As Integer = xc_Box.Text
        Dim yc As Integer = yc_Box.Text
        Dim a As Integer = a_box.Text
        Dim b As Integer = b_box.Text
        ellipse.createEllipse(xc, yc, a, b)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Circle.circleDelete(ListBox1.SelectedIndex)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub TMRGen_Tick(sender As Object, e As EventArgs) Handles TMRGen.Tick
        REDCLR.Text = TBRed.Value
        GREENCLR.Text = TBGreen.Value
        BLUECLR.Text = TBBlue.Value
        Dim red1, green1, blue1 As Integer
        red1 = REDCLR.Text
        green1 = GREENCLR.Text
        blue1 = BLUECLR.Text
        previewColor = Color.FromArgb(red1, green1, blue1)
        PictureBox2.BackColor = previewColor
        Circle.color = previewColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Circle.color = previewColor

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox2.Text = Nothing Then
            MsgBox("Enter a password to be saved")
        Else
            File.AppendAllText(c, TextBox2.Text & vbCrLf)
            TextBox2.Text = ""
            MsgBox("password saved", MsgBoxStyle.Information, "saved")
            ReadFile()
        End If
    End Sub

    Private Sub ReadFile()
        Try
            ComboBox1.Items.Clear()
            a = File.OpenText(c)
            While a.Peek <> -1
                b = a.ReadLine()
                ComboBox1.Items.Add(b)
            End While
            a.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
