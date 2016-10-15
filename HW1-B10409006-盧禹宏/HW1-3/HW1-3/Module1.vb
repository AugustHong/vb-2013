Module Module1
    Dim number(10) As Integer
    Sub Main()
        Dim r As New Random
        Dim count% = 1, a%


        While count <= 10
            a = r.Next(1, 200)
            If judge(a) Then number(count) = a : count = count + 1
        End While

        Print()
        Console.Read()
    End Sub

    Function judge(b As Integer) '是否重複
        For i = 1 To UBound(number)
            If b = number(i) Then Return False
        Next
        Return True
    End Function

    Sub print()
        Dim tmp%
        For i = 1 To UBound(number) - 1 '排序
            For j = i + 1 To UBound(number)
                If number(i) > number(j) Then
                    tmp = number(i)
                    number(i) = number(j)
                    number(j) = tmp
                End If
            Next
        Next

        Console.Write("陣列元素為： ")
        For i = 1 To UBound(number)
            Console.Write("{0}   ", number(i))
        Next

        Console.WriteLine(vbCrLf & "最大的三個數分別為{0}, {1}, {2}", number(8), number(9), number(10))
    End Sub

End Module
