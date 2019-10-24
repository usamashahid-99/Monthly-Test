Module Module1

    Sub Main()
        Dim binstring, denstring, nextchar As String
        Dim count As Integer
        Dim validbinarystring As Boolean

        count = 0
        binstring = ""
        denstring = ""
        nextchar = ""
        validbinarystring = False

        Console.Write("Input your binary number: ")
        binstring = Console.ReadLine

        If Len(binstring) <= "8" Then
            validbinarystring = True
        Else
            validbinarystring = False
        End If

        For count = 1 To Len(binstring)
            nextchar = Mid(binstring, count, 1)
            If nextchar = "1" Or nextchar = "0" Then
                validbinarystring = True
            Else
                validbinarystring = False
            End If
        Next
        If validbinarystring = False Then
            Console.Write("Not a valid binary number.....")
        Else
            Console.Write("Valid binary number.....")
        End If

        Console.ReadKey()



































    End Sub


















End Module
