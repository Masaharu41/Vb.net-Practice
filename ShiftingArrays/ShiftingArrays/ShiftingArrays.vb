Option Explicit On
Option Strict On
Option Compare Binary

Public Class ShiftingArrays

    Function RandomNumberFrom(Optional min% = 0, Optional max% = 10) As Integer
        Dim _randomize As Integer
        Randomize(DateTime.Now.Millisecond)
        _randomize = CInt(Rnd() * (max - min))
        Return _randomize

    End Function


End Class
