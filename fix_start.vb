Module Module1

    Sub Main()

        Dim s As String = ""
        Dim x As Integer = 0
        Dim finalchar As Char = ""
        Dim mychar As Char = ""
        Dim newstring As String = ""


        Console.Write("Input your string: ")
        s = Console.ReadLine()
        finalchar = Mid(s, 1, 1)

        For x = 2 To Len(s)
            mychar = Mid(s, x, 1)
            If LCase(finalchar) = LCase(mychar) Then
                mychar = "*"
            End If
            newstring = newstring + mychar

        Next
        Console.WriteLine("Final String : " & finalchar & newstring)

        Console.ReadKey()
    End Sub

End Module
