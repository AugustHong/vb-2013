Module Module1

    Sub Main()
        Dim a(1)() As Double
        Dim number1%, number2%
        Dim number3#
        Console.WriteLine("請輸入A班總人數")
        number1 = Integer.Parse(Console.ReadLine())

        a(0) = New Double(number1) {}
        For i = 1 To number1
            Console.WriteLine("請輸入體重")
            a(0)(i) = CType(Console.ReadLine, Double)
        Next

        Console.WriteLine("請輸入B班總人數")
        number2 = Integer.Parse(Console.ReadLine())
        a(1) = New Double(number2) {}

        For i = 1 To number2
            Console.WriteLine("請輸入體重")
            a(1)(i) = CType(Console.ReadLine, Double)
        Next

        Console.WriteLine("最大體重:{0}", getmax(a))

        number3 = getavg(a, number1 + number2)
        Console.WriteLine("平均體重:{0}", number3)

        For i = 0 To 1
            If i = 0 Then Console.WriteLine("class A")
            If i = 1 Then Console.WriteLine("class B")
            For k = 1 To UBound(a(i))
                Console.Write(a(i)(k))
                judge(a(i)(k), number3)
            Next
        Next

        Console.Read()
    End Sub

    Function getmax(a()() As Double)
        Dim j#
        j = a(0)(1)

        For i = 0 To 1
            For k = 1 To UBound(a(i))
                If j < a(i)(k) Then j = a(i)(k)
            Next
        Next

        Return j
    End Function

    Function getavg(a()() As Double, n As Integer)
        Dim sum# = 0
        For i = 0 To 1
            For k = 1 To UBound(a(i))
                sum = sum + a(i)(k)
            Next
        Next

        Return sum / n
    End Function

    Sub judge(a As Double, n As Double)
        If a > n Then Console.Write(" >" + vbCrLf)
        If a = n Then Console.Write(" =" + vbCrLf)
        If a < n Then Console.Write(" <" + vbCrLf)
    End Sub

End Module
