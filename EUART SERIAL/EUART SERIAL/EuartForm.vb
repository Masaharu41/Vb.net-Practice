Imports System.IO.Ports
Imports System.Runtime.InteropServices

Public Class EuartForm
    Private Sub SerialCom_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort.PortName = "COM6"
        SerialPort.BaudRate = 9600
        SerialPort.Open()
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        SendData()
        'DummyData()
    End Sub
    Sub DummyData()
        'Gives an alternating output. makes seeing baud easier
        Dim data(1) As Byte
        data(0) = &H55
        data(1) = &H55
        SerialPort.Write(data, 0, 2)
    End Sub

    ''' <summary>
    ''' Creates a byte array with valid start character and byte to be transmitted
    ''' </summary>
    Sub SendData()
        Dim pulse As Byte = PulseWidth()
        Dim data(1) As Byte
        data(0) = &H24
        data(1) = pulse ' Xor &HFF ' gives the complement of the byte value

        SerialPort.Write(data, 0, 2)


    End Sub

    ''' <summary>
    ''' Calculates the desired pulse width for servo based on slider
    ''' </summary>
    ''' <returns></returns>
    Function PulseWidth() As Byte
        Dim pulse As Byte
        pulse = CByte(CInt(PwTrackBar.Value) * 6 + 32)

        Return pulse
    End Function



    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub EuartForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            PwTrackBar.Value += 1
        ElseIf e.KeyCode = Keys.Left Then
            PwTrackBar.Value -= 1
        End If
    End Sub
End Class
