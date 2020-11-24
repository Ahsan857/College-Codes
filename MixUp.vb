Module Module1

    Sub Main()
        Dim Y As String = ""
        Dim X As String = ""
        Dim a As String = ""
        Dim b As String = ""



        Console.Write("Enter string a ")
        a = Console.ReadLine()
        Console.Write("Enter string b ")
        b = Console.ReadLine()

        X = Left(a, 2)
        Y = Left(b, 2)
        b = X + Mid(b, 3, Len(b))
        a = Y + Mid(a, 3, Len(a))
        Console.WriteLine("The output string is: " & a & " " & b)
        Console.ReadKey()

    End Sub

End Module
