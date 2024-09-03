'Owen Fujii
'Dart Game
'TODO
'[] Represent Dart Game Graphically
'[] Show Each Dart Thrown
'[] Track Dart Throws
'[] Recall old Games
'[] Have Graphical replay
'[] 

Option Explicit On
Option Strict On

Public Class DartBoard

    Sub DrawDartBoard()
        Dim g As Graphics = DartBoard.CreateGraphics
        Dim pen As New Pen(Color.Black, 5)
        Dim x As Double, y As Double
        Dim pi As Double = Math.PI
        Dim screenWidth = DartBoard.Width
        Dim screenHeight = DartBoard.Height
        Dim rect As New Rectangle(10, 10, 100, 50)
        'For i = 1 To 360
        ' x = screenWidth / 2
        'y = screenHeight * pi * 2
        g.DrawEllipse(pen, rect)



        ' Next


    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        DrawDartBoard()

    End Sub
End Class
