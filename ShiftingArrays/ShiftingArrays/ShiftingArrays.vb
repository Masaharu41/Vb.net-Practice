Option Explicit On
Option Strict On
Option Compare Binary
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.Devices.ComputerInfo


Public Class ShiftingArrays
    Private Sub ShiftingArrays_Click(sender As Object, e As EventArgs) Handles Me.Click
        plot(ShiftArray(RandomNumberFrom(100, 200)))
        Console.Read()
    End Sub

    Sub plot(plotdata() As Integer)
        Dim g As Graphics = ArrayPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)
        Dim height% = ArrayPictureBox.Height
        Dim oldX%, oldY%
        Dim widthUnit% = CInt(ArrayPictureBox.Width / 100)
        g.ScaleTransform(CSng(ArrayPictureBox.Width / 100), 1)
        For x = 0 To UBound(plotdata)
            g.DrawLine(pen, oldX, oldY, x, plotdata(x))
            oldX = x
            oldY = plotdata(x)
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

        '  For i = 0 To 100
        plot(ShiftArray(RandomNumberFrom(0, ArrayPictureBox.Height)))
        ' Next

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ArrayPictureBox.Refresh()

        '  For i = 0 To 100
        '  plot(ShiftArray(Sensor()))
        plot(ShiftArray(MouseY()))
    End Sub

    Function Sensor() As Integer
        Dim ram As Integer
        ram = CInt(CInt(My.Computer.Info.AvailablePhysicalMemory) / 1000)


        Return ram
    End Function

    Function MouseY(Optional currentY As Integer = -1) As Integer
        Static _mouseY As Integer
        If currentY <> -1 Then

            _mouseY = currentY
        End If

        Return _mouseY

    End Function

    Private Sub ArrayPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles ArrayPictureBox.MouseMove
        MouseY(e.Y)
    End Sub
End Class
