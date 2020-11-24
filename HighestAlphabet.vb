Module Module1

    Sub Main()
        Dim str1 As String = ""
        Dim count As Integer = 0
        Dim hchar As Char = ""
        Dim alpha As String = "abcdefghijklmnopqrstuvwxyz"
        Dim halpha As Integer = -1000
        Dim mychar As Char = ""

        Dim z As Integer = 0

        Console.Write("Type your string: ")
        str1 = LCase(Console.ReadLine())
        For x = 1 To 26
            count = 0
            mychar = Mid(alpha, x, 1)
            z = InStr(str1, mychar)
            While z > 0
                count = count + 1
                z = z + 1
                z = InStr(z, str1, mychar)
            End While
            If count > hcount Then
                hcount = count
                haplha = mychar

            End If

        Next
        Console.WriteLine("Alphabet which occured the most times : " & haplha)
        Console.WriteLine("The alphabet occured : " & Str(hcount))
        Console.ReadKey()

    End Sub

End Module
