﻿Imports System.IO.Ports
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading


Public Class EuartForm

    Dim sent(0) As Byte
    Dim msb As Byte
    Dim lsb As Byte
    Dim port As Boolean
    Private Sub SerialCom_Load(sender As Object, e As EventArgs) Handles Me.Load

        OpenPort()
    End Sub

    Sub OpenPort(Optional force As Boolean = False)
        Dim portValid As Boolean = False
        Dim portName As String
        ' auto test "all" COM port values until a valid connection or nothing reports back
        If force = True Then
            Try
                ' portName = ComComboBox.Text
                SerialPort.PortName = portName
                SerialPort.BaudRate = 9600
                SerialPort.Open()
                portValid = True
            Catch ex As Exception
                portValid = False
            End Try
        Else
            For i = 0 To 50
                portName = $"COM{i}"
                Try
                    SerialPort.PortName = portName
                    SerialPort.BaudRate = 9600
                    SerialPort.Open()
                    portValid = True
                    Exit For
                Catch ex As Exception

                    portValid = False

                End Try
            Next
        End If

        If portValid = True Then
            PortLabel.Text = "Port Is Open"
            port = True
        Else
            PortLabel.Text = "Port Is Closed"
            port = False
        End If
    End Sub



    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        SendData()
        TimerRestart()
        'DummyData()
    End Sub

    Sub TimerRestart()
        ScanTimer.Stop()
        ScanTimer.Interval = 500
        ScanTimer.Start()
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
        Dim data(2) As Byte
        ' Static adcSel As Boolean
        data(0) = &H24
        data(1) = pulse ' Xor &HFF ' gives the complement of the byte value

        data(2) = &H1

        SerialPort.Write(data, 0, 3)


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


    Function ConvertVtoF() As Single
        Dim totalCnt As Integer
        Dim f As Single
        Dim res As Single = 0.00391
        totalCnt = (CInt(msb) * 4) + CInt(lsb)

        f = res * totalCnt * 100

        Return f

    End Function

    Sub DisplayTemp()
        Static temp(4) As Single
        Static runCnt As Integer
        Dim avResult As Single
        ConvertVtoF()
        If runCnt = 0 Then
            temp(0) = ConvertVtoF()
            runCnt += 1
        ElseIf runCnt = 1 Then
            temp(1) = ConvertVtoF()
            runCnt += 1
        ElseIf runCnt = 2 Then
            temp(2) = ConvertVtoF()
            runCnt += 1
        ElseIf runCnt = 3 Then
            temp(3) = ConvertVtoF()
            runCnt += 1
        ElseIf runCnt = 4 Then
            temp(4) = ConvertVtoF()
            runCnt += 1
        Else
            For i = 0 To UBound(temp)
                avResult += temp(i)
            Next
            avResult = avResult / UBound(temp)
            If Me.DisplayLabel.InvokeRequired Then
                Me.DisplayLabel.Invoke(New MethodInvoker(Sub() DisplayLabel.Text = CStr(avResult)))
                runCnt = 0
            Else
                DisplayLabel.Text = "New Text"
            End If
            For i = 0 To UBound(temp)
                temp(i) = 0
            Next
        End If
    End Sub

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
        Thread.Sleep(3)
        Dim data(SerialPort.BytesToRead) As Byte
        SerialPort.Read(data, 0, SerialPort.BytesToRead)
        '' may need to add a delay to reading the data
        Try

            sent(0) = data(0)
            msb = data(1)
            lsb = data(2)
            ReadRecieved()
        Catch ex As Exception

        End Try
    End Sub



    Sub ReadRecieved()
        ' Validates that the data recieved has a valid start character
        ' then proceeds to shift the lsb and display the recieved data
        ' gives an output to console regardless to show what is sent in
        If Encoding.ASCII.GetString(sent) = "$" Then
            lsb = lsb >> 6

            ' DisplayLabel.Text = CStr(msb) & CStr(lsb)
            Console.WriteLine(CStr(msb))
            Console.WriteLine(CStr(lsb))
            If CInt(msb + lsb) = 258 Then

                DisplayTemp()
            Else

                Console.WriteLine(CStr(msb))
                Console.WriteLine(CStr(lsb))
            End If

        End If

    End Sub

    Private Sub ScanTimer_Tick(sender As Object, e As EventArgs) Handles ScanTimer.Tick
        If port Then
            SendData()
            TimerRestart()
        Else
            ScanTimer.Enabled = False

        End If
    End Sub


End Class
