Option Explicit On
Option Strict On
Option Compare Binary

Public Class ShiftingArrays
    Private Sub ShiftingArrays_Click(sender As Object, e As EventArgs) Handles Me.Click
        For i = 1 To 100
            Console.WriteLine(RandomNumberFrom)
        Next
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
