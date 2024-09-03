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
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black, 5)
        Dim x As Double, y As Double
        Dim pi As Double = Math.PI
        Dim screenWidth = DartBoardPictureBox.Width
        Dim screenHeight = DartBoardPictureBox.Height
        Dim rect As New Rectangle(10, 10, CInt((screenWidth - 10)), CInt(screenHeight - 10))
        g.DrawEllipse(pen, rect)



    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        DrawDartBoard()
        DartThrow()
    End Sub

    Sub DartThrow()
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics
        Dim pen As New Pen(Color.DarkRed, 5)
        Dim centerX As Integer, centerY As Integer

        centerX = DartCord()
        centerY = DartCord()

        g.DrawLine(pen, centerX, centerY - 10, centerX, centerY + 10)
        g.DrawLine(pen, centerX - 10, centerY, centerX + 10, centerY)


    End Sub

    Function DartCord() As Integer
        Dim temp As Integer
        Dim screenWidth = DartBoardPictureBox.Width
        Randomize()
        temp = CInt(Rnd() * 250) + CInt(screenWidth / 8)
        Return temp
    End Function
End Class
