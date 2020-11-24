Module Module1

    Sub Main()
        Dim Y As String = ""
        Dim mchar As Char = ""
        Dim a As Integer = 0
        Dim e As Integer = 0
        Dim i As Integer = 0
        Dim o As Integer = 0
        Dim u As Integer = 0

        Dim tvowel As Integer = 0

        Console.Write("Type your string : ")
        Y = Console.ReadLine()
        For x = 1 To Len(Y)
            mchar = LCase(Mid(Y, x, 1))
            If mchar = "a" Then
                a = a + 1
            ElseIf mchar = "e" Then
                e = e + 1
            ElseIf mchar = "i" Then
                i = i + 1
            ElseIf mchar = "o" Then
                o = o + 1
            ElseIf mchar = "u" Then
                u = u + 1
            End If
        Next
        tvowel = a + e + i + o + u
        Console.WriteLine("Number of each vowel in string: " & Str(tvowel))
        Console.WriteLine("a: " & Str(a))
        Console.WriteLine("e: " & Str(e))
        Console.WriteLine("i: " & Str(i))
        Console.WriteLine("o: " & Str(o))
        Console.WriteLine("u: " & Str(u))
        Console.ReadKey()
    End Sub

End Module
