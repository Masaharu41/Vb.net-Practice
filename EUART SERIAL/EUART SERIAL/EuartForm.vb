Imports System.IO.Ports
Imports System.Runtime.InteropServices

Public Class EuartForm
    Private Sub SerialCom_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort.PortName = "COM5"
        SerialPort.BaudRate = 9600
        SerialPort.Open()
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        SendData()
    End Sub

    Sub SendData()
        Dim pulse% = PulseWidth()
        Dim data(1) As Byte
        data(0) = &H24
        data(1) = Hex(pulse)

        SerialPort.Write(data, 0, 2)


    End Sub


    Function PulseWidth() As Integer
        Dim pulse As Integer
        pulse = CInt(PwTrackBar.Value) * 6 + 32
        Return pulse
    End Function

End Class
