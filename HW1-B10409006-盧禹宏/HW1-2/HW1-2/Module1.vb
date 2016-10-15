Module Module1
    Dim money() As Integer = {1000, 500, 100, 50, 10, 5, 1}
    Sub Main()
        Dim gain_money%, cost%

        While True
            Console.WriteLine("請輸入消費金額")
            cost = Integer.Parse(Console.ReadLine())
            Console.WriteLine("請輸入收取金額")
            gain_money = Integer.Parse(Console.ReadLine())
            If gain_money < cost Then
                Console.WriteLine("收取金額不足")
                Console.WriteLine("============")
            Else
                Exit While
            End If
        End While

        money_number(gain_money - cost)
        Console.Read()

    End Sub
    Sub money_number(m As Integer)
        Console.Write("找零：")
        For i = 0 To UBound(money)
            Console.Write("{0}元*", money(i))
            If m >= money(i) Then
                Console.Write("{0}  ", Int(m / money(i))) 'int只有整數的部份
                m = m Mod money(i)
            Else
                Console.Write("{0}  ", 0)
            End If
        Next
        Console.WriteLine()
    End Sub

End Module
