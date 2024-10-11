Imports System.IO.Ports

Public Class EuartForm
    Private Sub SerialCom_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort.PortName = "COM5"
        SerialPort.BaudRate = 9600
        SerialPort.Open()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SendButton.Click

    End Sub
End Class
