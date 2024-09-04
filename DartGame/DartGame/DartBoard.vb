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
        DartBoardPictureBox.Refresh()

        If screenHeight < screenWidth Then
            Dim rect As New Rectangle(CInt((screenWidth - screenHeight) / 2), 0, screenHeight, screenHeight)
            g.DrawEllipse(pen, rect)
        Else
            Dim rect As New Rectangle(0, CInt((screenHeight - screenWidth) / 2), screenWidth, screenWidth)
            g.DrawEllipse(pen, rect)
        End If

        ' g.DrawEllipse(pen, rect)



    End Sub

    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        DrawDartBoard()
        ' DartThrow(1)
    End Sub

    'Sub DartThrow(offset As Integer)
    '    Dim g As Graphics = DartBoardPictureBox.CreateGraphics
    '    Dim pen As New Pen(Color.DarkRed, 5)
    '    Dim centerX As Integer, centerY As Integer
    '    Dim referenceX = DartBoardPictureBox.Width
    '    Dim referenceY = DartBoardPictureBox.Height
    '    centerX = DartCord() + CInt(centerX / 2)
    '    centerY = DartCord() + CInt(centerY / 2)

    '    g.DrawLine(pen, centerX, centerY - 10, centerX, centerY + 10)
    '    g.DrawLine(pen, centerX - 10, centerY, centerX + 10, centerY)


    'End Sub

    Function DartCord() As Integer
        Dim temp As Integer
        Dim screenWidth = DartBoardPictureBox.Width
        Randomize()
        temp = CInt(Rnd() * (screenWidth - (screenWidth - 1 / 8) / 10))
        Return temp
    End Function
End Class
