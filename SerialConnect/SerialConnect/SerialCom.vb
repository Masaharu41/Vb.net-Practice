Imports System.IO.Ports
Imports System.Threading.Thread

Public Class SerialCom
    Private Sub SerialCom_Load(sender As Object, e As EventArgs) Handles Me.Load


        Try
            SerialPort.PortName = "COM5"
            SerialPort.BaudRate = 9600
            SerialPort.Open()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort.Write("U")
        Dim data(0) As Byte
        data(0) = &B11110000
        SerialPort.Write(data, 0, 1)
        WriteDigital()
    End Sub

    Sub GetPorts()
        For Each s As String In SerialPort.GetPortNames()
            ComboBox1.Items.Add($"{s}")
        Next

        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim data(SerialPort.BytesToRead) As Byte
        SerialPort.Read(data, 0, SerialPort.BytesToRead)
        For i = 0 To UBound(data)
            Console.Write($"{Hex(data(i))}:")
            Console.WriteLine(Chr(data(i)))
        Next
    End Sub

    Sub WriteDigital()
        Dim data(1) As Byte
        data(0) = &H20
        data(1) = &H80
        SerialPort.Write(data, 0, 2)

        Do
            SerialPort.Write(data, 0, 2)
            If data(1) = &H80 Then

                data(1) = &H1
            Else
                data(1) = data(1) << 1
            End If
            Sleep(2)
        Loop
    End Sub
End Class
