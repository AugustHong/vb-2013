Module Module1

    Sub Main()
        Console.WriteLine("(1,2)sum is {0}", sum(1, 2))
        Console.WriteLine("(1,2，3)sum is {0}", sum(1, 2, 3))
        Console.Read()
    End Sub

    Function sum(a As Integer, b As Integer)  '重構（可以用相同函式名稱，但參數的數目不同，他自已會去找）
        sum = a + b
    End Function

    Function sum(a As Integer, b As Integer, c As Integer)
        sum = a + b + c
    End Function

End Module
