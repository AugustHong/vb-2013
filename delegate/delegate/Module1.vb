Module Module1
    Delegate Function hello(ByVal num1 As Integer, ByVal num2 As Integer) As Boolean '不能放在main中會錯
    'Delegate Sub hello2(ByVal num1 As Integer, ByVal num2 As Integer)  宣告sub不用回傳形態

    Function issmall(a As Integer, b As Integer)
        Return a > b
    End Function

    Function isbig(a As Integer, b As Integer)
        Return a < b
    End Function

    Sub sort(y() As Integer, b As hello)
        Dim a As Integer = 0
        For i = 0 To UBound(y) - 1
            For j = i + 1 To UBound(y)
                If b(y(i), y(j)) Then
                    a = y(i)
                    y(i) = y(j)
                    y(j) = a
                End If
            Next
        Next
    End Sub
    Sub print(g() As Integer)
        For i = 0 To UBound(g)
            Console.WriteLine(g(i))
        Next
    End Sub

    Sub main()

        Dim c() As Integer = {20, 58, 45, 33, 69, 87, 44}
        Dim ok As hello '宣告

        Console.WriteLine("begin small to big")
        ok = AddressOf issmall
        sort(c, ok)  'or sort(c, addressof issmall)
        print(c)

        Console.WriteLine("begin big to small")
        ok = AddressOf isbig
        sort(c, ok)
        print(c)

        Console.Read()
    End Sub


End Module


