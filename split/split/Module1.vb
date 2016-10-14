Module Module1

    Sub Main()
        Console.WriteLine("please input number")
        Dim s() = Microsoft.VisualBasic.Split(Console.ReadLine(), " ") '要這樣寫(不能先宣告 會錯)，且要打Microsoft.VisualBasic.Split這樣才行
        For i = 0 To UBound(s)
            Console.WriteLine(s(i))
        Next
        Console.Read()
    End Sub

End Module

