Module Module1

    Sub Main()
        Dim st1 As String = ""
        Console.Write("Input a string: ")
        st1 = Console.ReadLine()
        If Len(st1) >= 3 Then
            If LCase(Right(st1, 3)) <> "ing" Then
                st1 = st1 + "ing"
            Else
                st1 = st1 + "ly"
            End If
        End If
        Console.WriteLine("Final String is : " & st1)
        Console.ReadKey()

    End Sub

End Module
