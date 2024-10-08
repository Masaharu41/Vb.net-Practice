Option Explicit On
Option Strict On
Option Compare Binary
Imports System.Security.Cryptography

Public Class ShiftingArrays
    Private Sub ShiftingArrays_Click(sender As Object, e As EventArgs) Handles Me.Click
        ShiftArray(RandomNumberFrom)
    End Sub

    Sub ShiftArray(newdata As Integer)
        Static Dim data(99) As Integer

        For i = LBound(data) To UBound(data) - 1
            data(i) = data(i + 1)
        Next


    End Sub

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


End Class
