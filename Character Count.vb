Module Module1

    Sub Main()
        Dim s As String = ""
        Dim mchar As Char = ""
        Dim x As Integer = 0
        Dim charcount As Integer = 0


        Console.Write("Type your string : ")
        s = Console.ReadLine()
        Console.Write("Which character you want to count? : ")
        mchar = Console.ReadLine()
        For x = 1 To Len(s)
            If mchar = LCase(Mid(s, x, 1)) Then
                charcount = charcount + 1

            End If
        Next
        Console.WriteLine("The number of '" & mchar & "' in string is: " & charcount)
        Console.ReadKey()
    End Sub

End Module
