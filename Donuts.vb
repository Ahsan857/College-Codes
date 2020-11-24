Module Module1

    Sub Main()
        Dim s As Integer = 0

        Console.Write("How many donuts? : ")
        s = Console.ReadLine()
        If s < 10 Then
            Console.WriteLine("The number of donuts " & Str(s))
        Else
            Console.WriteLine("The number of donuts 'many'")
        End If
        Console.ReadKey()


    End Sub

End Module
