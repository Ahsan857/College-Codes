Module Module1

    Sub Main()
        Dim s As String = ""
        Dim c1 As Char = ""
        Dim c2 As Char = ""
        Dim newstring As String = ""
        Dim x As Integer = 0
        Dim mychar As Char = ""
        Console.Write("Type your string : ")
        s = Console.ReadLine()
        Console.Write("Enter the character you want to replace: ")
        c1 = Console.ReadLine()
        Console.Write("Enter the character you want to replace with: ")
        c2 = Console.ReadLine()

        For x = 1 To Len(s)
            mychar = Mid(s, x, 1)
            If LCase(mychar) = LCase(c1) Then
                mychar = c2

            End If
            newstring = newstring + mychar

        Next
        Console.WriteLine("The Final String : " & newstring)
        Console.ReadKey()

    End Sub

End Module
