Module Module1

    Sub Main()
        Dim i% = 0, sum% = 0, a%
        Console.WriteLine("please input number")
        a = Integer.Parse(Console.ReadLine())

        Do While i <= a
            sum = sum + i
            i = i + 2
        Loop
        Console.WriteLine("even sum is {0}", sum)
        Console.Read()
    End Sub

End Module
