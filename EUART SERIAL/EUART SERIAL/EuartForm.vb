Imports System.IO.Ports
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class EuartForm

    Dim sent As Byte
    Dim msb As Byte
    Dim lsb As Byte
    Private Sub SerialCom_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort.PortName = "COM6"
        SerialPort.BaudRate = 9600
        Try

            SerialPort.Open()
        Catch ex As Exception
            MsgBox("A valid com device could not be detected")
        End Try
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

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Thread.Sleep(5)
        Dim data(SerialPort.BytesToRead) As Byte
        SerialPort.Read(data, 0, SerialPort.BytesToRead)
        '' may need to add a delay to reading the data
        sent = data(0)
        msb = data(1)
        lsb = data(2)
        ReadRecieved()
    End Sub


    Sub ReadRecieved()
        ' Validates that the data recieved has a valid start character
        ' then proceeds to shift the lsb and display the recieved data
        If CStr(sent) = "$" Then
            lsb = lsb >> 6

            DisplayLabel.Text = CStr(msb) & CStr(lsb)

        Else
        End If

    End Sub

End Class
