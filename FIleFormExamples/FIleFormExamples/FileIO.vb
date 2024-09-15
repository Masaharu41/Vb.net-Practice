Public Class FileIO


    Sub main()
        Dim numTwo As Integer = 5
        WriteToFile()
        AppendToFile()
        ' SubTest(5, numTwo)
        '  Console.Write(numTwo)
        ReadFromFile()
        'Console.Read()
    End Sub


    Sub WriteToFile()

        Try
            FileOpen(1, "..\..\ShinyFile.txt", OpenMode.Output)
            Write(1, "Im Shiny!!!")
        Catch ex As Exception
            FileOpen(2, "Error.txt", OpenMode.Append)
            Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try

        FileClose(1)
    End Sub

    Sub AppendToFile()

        Try
            FileOpen(1, "..\..\ShinyestFile.txt", OpenMode.Append)
            Print(1, "Im Shiny!!!!!!!!!!")
        Catch ex As Exception
            FileOpen(2, "Error.txt", OpenMode.Append)
            Write(2, CStr($"Error: {Err.Number}, {Err.Description} {vbNewLine}"))
            FileClose(2)
        End Try

        FileClose(1)
    End Sub

    Sub ReadFromFile()
        Dim value As String
        FileOpen(1, "..\..\ShinyestFile.txt", OpenMode.Input)

        Do Until EOF(1)
            Input(1, value)
            ListBox1.Items.Add(value)

        Loop
        FileClose(1)

    End Sub

    Sub SubTest(numOne As Integer, ByRef numTwo As Integer)
        numTwo = numOne + numTwo
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main()
    End Sub
End Class
