Module Module1

    Sub Main()
        Dim s As String = ""

        Console.Write("Type you string please : ")
        s = Console.ReadLine()
        If Len(s) > 4 Then
            Console.WriteLine("Final String : " & Left(s, 2) & Right(s, 2))
        Else
            Console.WriteLine("Final String : " & s)
        End If
        Console.ReadKey()

    End Sub

End Module
