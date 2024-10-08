﻿Option Explicit On
Option Strict On
Option Compare Binary
Imports System.Security.Cryptography

Public Class ShiftingArrays
    Private Sub ShiftingArrays_Click(sender As Object, e As EventArgs) Handles Me.Click
        plot(ShiftArray(RandomNumberFrom(0, ArrayPictureBox.Height)))
        Console.Read()
    End Sub

    Sub plot(plotdata() As Integer)
        Dim g As Graphics = ArrayPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Azure, 15)
        Dim height% = ArrayPictureBox.Height

        For x = 0 To UBound(plotdata)
            g.DrawLine(pen, x, plotdata(x), x + 1, plotdata(x))
        Next
    End Sub

    Function ShiftArray(newdata As Integer) As Integer()
        Static Dim data(99) As Integer

        For i = LBound(data) To UBound(data) - 1
            data(i) = data(i + 1)
        Next
        data(UBound(data)) = newdata
        'Console.Read()
        Return data
    End Function

    Sub CreateRandomness()
        Dim randomness(10) As Integer
        For i = 1 To 1000
            randomness(RandomNumberFrom(0, 10)) += 1
        Next

        For i = LBound(randomness) To UBound(randomness)

            Console.Write("| " & CStr(randomness(i)).PadLeft(4) & " |")
        Next
        Console.WriteLine()

    End Sub

    ''' <summary>
    ''' returns a random number within the context of the max and min
    ''' </summary>
    ''' <param name="min%"></param>
    ''' <param name="max%"></param>
    ''' <returns></returns>
    Function RandomNumberFrom(Optional min% = 0, Optional max% = 10) As Integer
        Dim _randomize As Integer
        Randomize(DateTime.Now.Millisecond)
        _randomize = CInt(Math.Floor(Rnd() * (max + 1 - min))) + min
        Return _randomize

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PlotButton_Click(sender As Object, e As EventArgs) Handles PlotButton.Click
        ArrayPictureBox.Refresh()

        For i = 0 To 100
            plot(ShiftArray(RandomNumberFrom(0, ArrayPictureBox.Height)))
        Next
    End Sub
End Class
