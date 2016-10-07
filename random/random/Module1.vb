Module Module1

    Sub Main()
        Dim keyin%, min%, max%, guess%
        Dim r As New random '創一個random的物件
        guess = r.Next(1, 100) '用出1-99的亂數給guess
        min = 1
        max = 99
        keyin = 100

        Console.WriteLine("guess number game is start!")
        Console.WriteLine("=============================")

        Do While True
            Console.WriteLine("please input {0} - {1} number", min, max)
            keyin = Integer.Parse(Console.ReadLine()) '要用readline()用read()會出錯

            If keyin >= min And keyin <= max Then

                If keyin > guess Then Console.WriteLine("too high") : max = keyin '用:可繼續接下一行
                If keyin = guess Then Console.WriteLine("you right") : Exit Do
                If keyin < guess Then Console.WriteLine("too low") : min = keyin
            Else
                Console.WriteLine("you input number over range")
            End If
        Loop

        Console.Read()
    End Sub

End Module
