Module Module1

    Sub Main()
        Console.WriteLine("{0} {1} {2}", sum(2, 4, 5, 10), sum(1, 10, 100), sum(1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024))
        Console.Read()
    End Sub
    Function sum(ByVal ParamArray x() As Integer) 'paramarray是可以讓步規輒數目傳進來(但議定要是陣列型態)
        'byval是傳值 byref是傳址(不加是byval)
        Dim total% = 0
        For i = 0 To UBound(x)
            total += x(i)
        Next
        sum = total 'return total 皆可
    End Function

End Module

